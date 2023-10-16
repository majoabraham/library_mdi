Public Class BooksXtraForm
    Private Sub CreateBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CreateBarButtonItem.ItemClick
        BookCreateXtraForm.Show()
    End Sub

    Private Sub EditBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles EditBarButtonItem.ItemClick
        BookEditXtraForm.Show()
    End Sub

    Private Sub ReadersBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReadersBarButtonItem.ItemClick
        BookReadersXtraForm.Show()
    End Sub
End Class