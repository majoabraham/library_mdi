Public Class BorrowingsXtraForm
    Private Sub CheckoutBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CheckoutBarButtonItem.ItemClick

        Dim checkoutXtraForm = New CheckoutXtraForm(BorrowingGridControl)
        checkoutXtraForm.Show()

    End Sub

    Private Sub CheckinBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CheckinBarButtonItem.ItemClick

        Dim checkinXtraForm = New CheckinXtraForm(BorrowingGridControl, BorrowingGridView)
        checkinXtraForm.Show()

    End Sub

    Private Sub CalendarBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CalendarBarButtonItem.ItemClick
        CalendarRibbonForm.Show()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

        Dim exportPath As String = "exports/borrowings.xlsx"

        DataManipulation.ExportGridToXlsx(exportPath, BorrowingGridControl)

    End Sub
End Class