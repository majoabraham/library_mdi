Imports DevExpress.Xpo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class BookEditXtraForm

    Private _book As Book
    Private _uow As UnitOfWork
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

        _gridControl.DataSource = DataManipulation.GetAllBooks()

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

        Dim row As Book = CType(_gridView.GetFocusedRow(), Book)

        _book = _uow.GetObjectByKey(Of Book)(row.Oid)

    End Sub
End Class