Public Class BorrowingsXtraForm
    Private Sub CheckoutBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CheckoutBarButtonItem.ItemClick

        Dim checkoutXtraForm = New CheckoutXtraForm(BorrowingGridControl)
        checkoutXtraForm.Show()

    End Sub

    Private Sub CheckinBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CheckinBarButtonItem.ItemClick

        Dim checkinXtraForm = New CheckinXtraForm(BorrowingGridControl, BorrowingGridView)
        checkinXtraForm.Show()

    End Sub
End Class