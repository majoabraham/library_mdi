Imports DevExpress.Xpo

Public Class BookEditXtraForm

    Private _oid As Integer
    Private _book As Book
    Private _uow As UnitOfWork

    Public Sub New()
        InitializeComponent()
        _uow = New UnitOfWork()
    End Sub
    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Close()
    End Sub

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        Using _uow

            _book.Title = TitleTextEdit.Text
            _book.Author = AuthorTextEdit.Text
            _book.IsAvailable = IsAvailableCheckEdit.Checked
            _book.Quantity = CInt(QuantitySpinEdit.Value)
            _book.InStock = CInt(InStockSpinEdit.Value)

            _uow.CommitChanges()
        End Using

        MainXtraForm.BooksGridControl.DataSource = DataManipulation.GetAllBooks()

        Close()
    End Sub

    Private Sub BookEditXtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadBook()

        TitleTextEdit.Text = _book.Title
        AuthorTextEdit.Text = _book.Author
        IsAvailableCheckEdit.Checked = _book.IsAvailable
        QuantitySpinEdit.Value = _book.Quantity
        InStockSpinEdit.Value = _book.InStock

    End Sub

    Private Sub LoadBook()
        Dim rowId = MainXtraForm.BooksGridView.GetSelectedRows().First()
        Dim row As Book = CType(MainXtraForm.BooksGridView.GetRow(rowId), Book)
        _oid = row.Oid

        _book = _uow.GetObjectByKey(Of Book)(_oid)

    End Sub
End Class