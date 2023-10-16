Public Class BorrowingsXtraForm
    Private Sub CheckoutBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CheckoutBarButtonItem.ItemClick
        CheckoutXtraForm.Show()
    End Sub

    Private Sub CheckinBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CheckinBarButtonItem.ItemClick
        CheckinXtraForm.Show()
    End Sub
End Class