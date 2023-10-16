Imports System.Security.Cryptography
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Public Class CheckoutXtraForm
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub CheckoutXtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim uow As New UnitOfWork()

        'books lookup
        Dim criteria As BinaryOperator = New BinaryOperator(NameOf(Book.IsAvailable), True, BinaryOperatorType.Equal)
        BookLookUpEdit.Properties.DataSource = New XPCollection(Of Book)(uow, criteria)
        BookLookUpEdit.Properties.DisplayMember = NameOf(Book.Title)
        BookLookUpEdit.Properties.ValueMember = NameOf(Book.Oid)
        BookLookUpEdit.EditValue = 0

        'readers lookup
        ReaderLookUpEdit.Properties.DataSource = New XPCollection(Of Reader)(uow)
        ReaderLookUpEdit.Properties.DisplayMember = NameOf(Reader.FullName)
        ReaderLookUpEdit.Properties.ValueMember = NameOf(Reader.Oid)
        ReaderLookUpEdit.EditValue = 0

        CheckoutDateEdit.DateTime = DateTime.Now()

    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Close()
    End Sub

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        Using uow As New UnitOfWork()

            Dim book = uow.GetObjectByKey(Of Book)(BookLookUpEdit.EditValue)
            Dim reader = uow.GetObjectByKey(Of Reader)(ReaderLookUpEdit.EditValue)

            Dim borrowing = New Borrowing(uow) With {
                .Book = book,
                .Reader = reader,
                .CheckoutDate = CheckoutDateEdit.DateTime
            }

            book.InStock -= 1
            book.IsAvailable = book.InStock > 0

            uow.CommitChanges()
        End Using

        MainXtraForm.BorrowingGridControl.DataSource = DataManipulation.GetAllBorrowings()
        MainXtraForm.BooksGridControl.DataSource = DataManipulation.GetAllBooks()

        Close()
    End Sub
End Class