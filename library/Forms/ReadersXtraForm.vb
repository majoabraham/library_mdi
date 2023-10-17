Public Class ReadersXtraForm
    Private Sub CreateBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CreateBarButtonItem.ItemClick

        Dim readerCreateXtraForm = New ReaderCreateXtraForm(ReadersGridControl)
        readerCreateXtraForm.Show()

    End Sub

    Private Sub EditBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles EditBarButtonItem.ItemClick

        Dim readerEditXtraForm = New ReaderEditXtraForm(ReadersGridControl, ReadersGridView)
        readerEditXtraForm.Show()

    End Sub
End Class