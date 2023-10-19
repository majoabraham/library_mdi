Public Class BooksReadersXtraReport
    Private Sub Detail_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Detail.BeforePrint
        Dim bookQuantity As Integer = CType(GetCurrentColumnValue(NameOf(Book.Quantity)), Integer)
        Dim bookInStock As Integer = CType(GetCurrentColumnValue(NameOf(Book.InStock)), Integer)

        If bookInStock < bookQuantity Then
            GroupHeader1.Visible = True
            Detail1.Visible = True
        Else
            GroupHeader1.Visible = False
            Detail1.Visible = False
        End If
    End Sub
End Class