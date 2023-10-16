Public Class ReadersXtraForm
    Private Sub CreateBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CreateBarButtonItem.ItemClick
        ReaderCreateXtraForm.Show()
    End Sub

    Private Sub EditBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles EditBarButtonItem.ItemClick
        ReaderEditXtraForm.Show()
    End Sub
End Class