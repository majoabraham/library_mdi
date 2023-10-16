Imports DevExpress.Xpo

Public Class BookCreateXtraForm

    Private _uow As UnitOfWork
    Private _booksXtraForm As BooksXtraForm

    Public Sub New()

        InitializeComponent()
        _uow = New UnitOfWork()
        _booksXtraForm = CType(MainXtraForm.ActiveMdiChild, BooksXtraForm)

    End Sub
    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Close()
    End Sub

    Private Sub OkSimpleButton_Click(sender As Object, e As EventArgs) Handles OkSimpleButton.Click
        Using _uow
            Dim book = New Book(_uow) With {
               .Title = TitleTextEdit.Text,
               .Author = AuthorTextEdit.Text,
               .IsAvailable = IsAvailableCheckEdit.Checked,
               .Quantity = CInt(QuantitySpinEdit.Value),
               .InStock = CInt(InStockSpinEdit.Value)
            }

            _uow.CommitChanges()
        End Using

        _booksXtraForm.BooksGridControl.DataSource = DataManipulation.GetAllBooks()

        Close()
    End Sub
End Class