Imports System.IO
Imports System.Xml
Imports DevExpress.Export
Imports DevExpress.Xpo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Module DataManipulation

    Function GetAllBooks() As XPCollection(Of Book)

        Dim uow As New UnitOfWork()

        Return New XPCollection(Of Book)(uow)

    End Function

    Function GetAllReaders() As XPCollection(Of Reader)

        Dim uow As New UnitOfWork()

        Return New XPCollection(Of Reader)(uow)

    End Function

    Function GetAllBorrowings() As XPCollection(Of Borrowing)

        Dim uow As New UnitOfWork()

        Return New XPCollection(Of Borrowing)(uow)

    End Function

    Sub ExportGridToXlsx(fileName As String, gridControl As GridControl)

        Dim exportPath = Path.Combine(Application.StartupPath, "exports")

        If Not System.IO.Directory.Exists(exportPath) Then
            System.IO.Directory.CreateDirectory(exportPath)
        End If


        Dim filePath = Path.Combine(exportPath, fileName)

        Dim options = New XlsxExportOptionsEx With {
            .ExportType = ExportType.DataAware
        }

        gridControl.ExportToXlsx(filePath, options)

        Process.Start(filePath)

    End Sub

    Sub ExportTreeListToXml(fileName As String, treeList As TreeList)

        Dim exportPath = Path.Combine(Application.StartupPath, "exports")

        If Not System.IO.Directory.Exists(exportPath) Then
            System.IO.Directory.CreateDirectory(exportPath)
        End If


        Dim filePath = Path.Combine(exportPath, fileName)

        treeList.ExportToXml(filePath)

        Process.Start(filePath)

    End Sub

    Sub ExportTreeListToXml2(fileName As String, treeList As TreeList)

        Dim xmlDoc As New XmlDocument()

        Dim rootElement As XmlElement = xmlDoc.CreateElement("Books")
        xmlDoc.AppendChild(rootElement)

        For Each bookNode As TreeListNode In treeList.Nodes

            Dim bookElement = xmlDoc.CreateElement("Book")
            bookElement.SetAttribute("value", bookNode.GetValue(treeList.Columns(0)).ToString())
            rootElement.AppendChild(bookElement)

            For Each readerNode As TreeListNode In bookNode.Nodes

                Dim readerElement = xmlDoc.CreateElement("Reader")
                readerElement.SetAttribute("value", readerNode.GetValue(treeList.Columns(0)).ToString())
                bookElement.AppendChild(readerElement)

            Next

        Next

        Dim exportPath = Path.Combine(Application.StartupPath, "exports")

        If Not System.IO.Directory.Exists(exportPath) Then
            System.IO.Directory.CreateDirectory(exportPath)
        End If


        Dim filePath = Path.Combine(exportPath, fileName)

        xmlDoc.Save(filePath)

        Process.Start(filePath)

    End Sub

End Module
