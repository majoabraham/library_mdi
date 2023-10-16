Public Class MainXtraForm
    Public Sub New()
        InitializeComponent()
        Connection.Connect()
    End Sub

    Private Sub BooksBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BooksBarButtonItem.ItemClick
        Dim booksXtraForm = New BooksXtraForm()

        booksXtraForm.MdiParent = Me
        booksXtraForm.Show()
    End Sub

    Private Sub ReadersBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReadersBarButtonItem.ItemClick
        Dim readersXtraForm = New ReadersXtraForm()

        readersXtraForm.MdiParent = Me
        readersXtraForm.Show()
    End Sub

    Private Sub BorrowingsBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BorrowingsBarButtonItem.ItemClick
        Dim borrowingsXtraForm = New BorrowingsXtraForm()

        borrowingsXtraForm.MdiParent = Me
        borrowingsXtraForm.Show()
    End Sub
End Class