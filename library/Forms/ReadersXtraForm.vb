Public Class ReadersXtraForm
    Private Sub CreateBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CreateBarButtonItem.ItemClick

        Dim readerCreateXtraForm = New ReaderCreateXtraForm(ReadersGridControl)
        readerCreateXtraForm.Show()

    End Sub

    Private Sub EditBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles EditBarButtonItem.ItemClick

        Dim readerEditXtraForm = New ReaderEditXtraForm(ReadersGridControl, ReadersGridView)
        readerEditXtraForm.Show()

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

        Dim exportPath As String = "exports/readers.xlsx"

        DataManipulation.ExportGridToXlsx(exportPath, ReadersGridControl)

    End Sub
End Class