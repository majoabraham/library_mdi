﻿Imports DevExpress.XtraReports.UI

Public Class BooksXtraForm
    Private Sub CreateBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CreateBarButtonItem.ItemClick

        Dim bookCreateXtraForm = New BookCreateXtraForm(BooksGridControl)
        bookCreateXtraForm.Show()

    End Sub

    Private Sub EditBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles EditBarButtonItem.ItemClick

        Dim bookEditXtraForm = New BookEditXtraForm(BooksGridControl, BooksGridView)
        bookEditXtraForm.Show()

    End Sub

    Private Sub ReadersBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReadersBarButtonItem.ItemClick
        BookReadersXtraForm.Show()
    End Sub

    Private Sub ReportBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReportBarButtonItem.ItemClick
        Dim booksXtraReport = New BooksXtraReport()
        booksXtraReport.ShowPreview()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReportBorrowingsBarButtonItem.ItemClick
        Dim booksReadersXtraReport = New BooksReadersXtraReport()
        booksReadersXtraReport.ShowPreview()
    End Sub

    Private Sub ExportXlsxBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ExportXlsxBarButtonItem.ItemClick

        Dim fileName = "books.xlsx"

        DataManipulation.ExportGridToXlsx(fileName, BooksGridControl)

    End Sub

    Private Sub TreeViewBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles TreeViewBarButtonItem.ItemClick
        BooksTreeViewXtraForm.Show()
    End Sub

    Private Sub PivotGridBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PivotGridBarButtonItem.ItemClick


        BooksPivotGridXtraForm.Show()

    End Sub
End Class