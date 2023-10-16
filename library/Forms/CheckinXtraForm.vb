Imports DevExpress.Xpo

Public Class CheckinXtraForm

    Private _oid As Integer
    Private _borrowing As Borrowing
    Private _book As Book
    Private _reader As Reader
    Private Sub CheckinXtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadBorrowing()

        'book
        BookLookUpEdit.Properties.DataSource = New List(Of Book)({_book})
        BookLookUpEdit.Properties.DisplayMember = NameOf(Book.Title)
        BookLookUpEdit.Properties.ValueMember = NameOf(Book.Oid)
        BookLookUpEdit.EditValue = _book.Oid

        'reader
        Dim uow As New UnitOfWork
        _reader = uow.GetObjectByKey(Of Reader)(_reader.Oid)
        ReaderLookUpEdit.Properties.DataSource = New List(Of Reader)({_reader})
        ReaderLookUpEdit.Properties.DisplayMember = NameOf(Reader.FullName)
        ReaderLookUpEdit.Properties.ValueMember = NameOf(Reader.Oid)
        ReaderLookUpEdit.EditValue = _reader.Oid

        'checkout
        CheckoutDateEdit.DateTime = _borrowing.CheckoutDate.Value.Date

        'checkin
        CheckinDateEdit.DateTime = DateTime.Now

    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Close()
    End Sub

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        Using uow As New UnitOfWork()

            _borrowing = uow.GetObjectByKey(Of Borrowing)(_borrowing.Oid)
            _book = uow.GetObjectByKey(Of Book)(_book.Oid)

            _borrowing.CheckinDate = CheckinDateEdit.DateTime

            _book.InStock += 1
            _book.IsAvailable = True

            uow.CommitChanges()
        End Using

        MainXtraForm.BorrowingGridControl.DataSource = DataManipulation.GetAllBorrowings()
        MainXtraForm.BooksGridControl.DataSource = DataManipulation.GetAllBooks()

        Close()
    End Sub

    Private Sub LoadBorrowing()
        Dim rowId = MainXtraForm.BorrowingGridView.GetSelectedRows().First()
        Dim row As Borrowing = CType(MainXtraForm.BorrowingGridView.GetRow(rowId), Borrowing)
        _oid = row.Oid

        Using uow As New UnitOfWork()

            _borrowing = uow.GetObjectByKey(Of Borrowing)(_oid)
            _book = uow.GetObjectByKey(Of Book)(_borrowing.Book.Oid)
            _reader = uow.GetObjectByKey(Of Reader)(_borrowing.Reader.Oid)

        End Using

    End Sub
End Class