Imports DevExpress.Xpo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class CheckinXtraForm

    Private _uow As UnitOfWork
    Private _borrowing As Borrowing
    Private _gridControl As GridControl
    Private _gridView As GridView

    Public Sub New()

        InitializeComponent()
        _uow = New UnitOfWork()

    End Sub

    Public Sub New(gridControl As GridControl, gridView As GridView)

        InitializeComponent()
        _uow = New UnitOfWork()
        _gridControl = gridControl
        _gridView = gridView

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

        _gridControl.DataSource = DataManipulation.GetAllBorrowings()

        For Each child In MainXtraForm.MdiChildren
            Dim form = TryCast(child, BooksXtraForm)
            If form IsNot Nothing Then
                form.BooksGridControl.DataSource = DataManipulation.GetAllBooks()
            End If
        Next

        Close()

    End Sub

    Private Sub LoadBorrowing()

        Dim row As Borrowing = CType(_gridView.GetFocusedRow(), Borrowing)

        _borrowing = _uow.GetObjectByKey(Of Borrowing)(row.Oid)

    End Sub
End Class