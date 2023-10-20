Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
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

    Sub ExportGridToXlsx(exportPath As String, gridControl As GridControl)

        Dim options = New XlsxExportOptionsEx With {
            .ExportType = ExportType.DataAware
        }

        gridControl.ExportToXlsx(exportPath, options)

        Process.Start(Path.Combine(Application.StartupPath, exportPath))
    End Sub

    Sub ExportTreeListToXml(exportPath As String, treeList As TreeList)

        treeList.ExportToXml(exportPath)

        Process.Start(Path.Combine(Application.StartupPath, exportPath))
    End Sub

    Private Sub Cosi(exportPath As String, treeList As TreeList)
        Dim xmlDoc As New XmlDocument()
        Dim folderPath As String = "D:/repos/LibraryNew/LibraryNew/Exports/"
        ' Create the root element for the XML document
        Dim rootElement As XmlElement = xmlDoc.CreateElement("BookTreeView")
        xmlDoc.AppendChild(rootElement)
        ' Traverse the TreeView nodes and add them to the XML document
        'TraverseNodes(treeList.Nodes, rootElement, xmlDoc)

        ' Save the XML document to a file
        Dim xmlFilePath As String = System.IO.Path.Combine(folderPath, "TreeViewData.xml")
        xmlDoc.Save(xmlFilePath)
        MessageBox.Show("TreeView data exported to XML successfully!", "Export to XML", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub TraverseNodes(nodes As TreeNodeCollection, parentElement As XmlElement, xmlDoc As XmlDocument)
        For Each node As TreeNode In nodes
            ' Create an XML element for the node
            Dim nodeElement As XmlElement = xmlDoc.CreateElement("Node")
            nodeElement.SetAttribute("Text", node.Text)
            ' Add the XML element to the parent element
            parentElement.AppendChild(nodeElement)
            ' Recursively traverse child nodes
            TraverseNodes(node.Nodes, nodeElement, xmlDoc)
        Next
    End Sub

End Module
