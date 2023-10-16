Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Module Connection
    Sub Connect()
        Dim conn As String = DevExpress.Xpo.DB.MySqlConnectionProvider.GetConnectionString("localhost", "root", "Mario123", "library_xpo")
        XpoDefault.DataLayer = XpoDefault.GetDataLayer(conn, AutoCreateOption.DatabaseAndSchema)
    End Sub
End Module

