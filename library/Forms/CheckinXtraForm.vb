Imports DevExpress.Xpo

Public Class CheckinXtraForm

    Private _uow As UnitOfWork
    Private _borrowing As Borrowing
    Private _borrowingsXtraForm As BorrowingsXtraForm

    Public Sub New()

        InitializeComponent()
        _uow = New UnitOfWork()
        _borrowingsXtraForm = CType(MainXtraForm.ActiveMdiChild, BorrowingsXtraForm)

    End Sub
    Private Sub CheckinXtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadBorrowing()

        'book
        BookLookUpEdit.Properties.DataSource = New List(Of Book)({_borrowing.Book})
        BookLookUpEdit.Properties.DisplayMember = NameOf(Book.Title)
        BookLookUpEdit.Properties.ValueMember = NameOf(Book.Oid)
        BookLookUpEdit.EditValue = _borrowing.Book.Oid

        'reader
        Dim uow As New UnitOfWork
        ReaderLookUpEdit.Properties.DataSource = New List(Of Reader)({_borrowing.Reader})
        ReaderLookUpEdit.Properties.DisplayMember = NameOf(Reader.FullName)
        ReaderLookUpEdit.Properties.ValueMember = NameOf(Reader.Oid)
        ReaderLookUpEdit.EditValue = _borrowing.Reader.Oid

        'checkout
        CheckoutDateEdit.DateTime = _borrowing.CheckoutDate.Value.Date

        'checkin
        CheckinDateEdit.DateTime = DateTime.Now

    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Close()
    End Sub

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        Using _uow

            _borrowing.CheckinDate = CheckinDateEdit.DateTime

            _borrowing.Book.InStock += 1
            _borrowing.Book.IsAvailable = True

            _uow.CommitChanges()
        End Using

        _borrowingsXtraForm.BorrowingGridControl.DataSource = DataManipulation.GetAllBorrowings()

        'BooksXtraForm.BooksGridControl.DataSource = DataManipulation.GetAllBooks()
        For Each child In MainXtraForm.MdiChildren
            Dim form = TryCast(child, BooksXtraForm)
            If TryCast(child, BooksXtraForm) IsNot Nothing Then
                form.BooksGridControl.DataSource = DataManipulation.GetAllBooks()
            End If
        Next

        Close()
    End Sub

    Private Sub LoadBorrowing()
        Dim rowId = _borrowingsXtraForm.BorrowingGridView.GetSelectedRows().First()
        Dim row As Borrowing = CType(_borrowingsXtraForm.BorrowingGridView.GetRow(rowId), Borrowing)

        _borrowing = _uow.GetObjectByKey(Of Borrowing)(row.Oid)

    End Sub
End Class