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

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ExportXlsxBarButtonItem.ItemClick

        Dim fileName = "borrowings.xlsx"

        DataManipulation.ExportGridToXlsx(fileName, BorrowingGridControl)

    End Sub

    Private Sub PivotGridBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PivotGridBarButtonItem.ItemClick

        BorrowingsPivotGridXtraForm.Show()

    End Sub
End Class