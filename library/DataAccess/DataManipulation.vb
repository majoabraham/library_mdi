Imports System.IO
Imports System.Xml
Imports DevExpress.Export
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
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

        Dim result As DialogResult = XtraMessageBox.Show("Do you want to open the xlsx file?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Process.Start(filePath)
        End If

    End Sub

    Sub ExportTreeListToXml(fileName As String, treeList As TreeList)

        Dim xmlDoc As New XmlDocument()

        Dim rootElement As XmlElement = xmlDoc.CreateElement("books")
        xmlDoc.AppendChild(rootElement)

        For Each bookNode As TreeListNode In treeList.Nodes

            Dim bookElement = xmlDoc.CreateElement("book")
            rootElement.AppendChild(bookElement)

            Dim authorElement = xmlDoc.CreateElement("author")
            authorElement.InnerText = bookNode.GetValue(treeList.Columns(0)).ToString()
            bookElement.AppendChild(authorElement)

            Dim titleNode = bookNode.Nodes(0)
            Dim titleElement = xmlDoc.CreateElement("title")
            titleElement.InnerText = titleNode.GetValue(treeList.Columns(0)).ToString()
            bookElement.AppendChild(titleElement)

            Dim borrowingsElement As XmlElement = Nothing

            If titleNode.Nodes.Count <> 0 Then
                borrowingsElement = xmlDoc.CreateElement("borrowings")
                bookElement.AppendChild(borrowingsElement)
            End If

            For Each readerNode As TreeListNode In titleNode.Nodes

                Dim borrowingElement = xmlDoc.CreateElement("borrowing")
                borrowingsElement.AppendChild(borrowingElement)

                Dim readerElement = xmlDoc.CreateElement("reader")
                readerElement.InnerText = readerNode.GetValue(treeList.Columns(0)).ToString()
                borrowingElement.AppendChild(readerElement)

                Dim checkoutNode = readerNode.Nodes(0)
                Dim checkoutElement = xmlDoc.CreateElement("checkout")
                checkoutElement.InnerText = checkoutNode.GetValue(treeList.Columns(0)).ToString()
                borrowingElement.AppendChild(checkoutElement)

            Next

        Next

        Dim exportPath = Path.Combine(Application.StartupPath, "exports")

        If Not System.IO.Directory.Exists(exportPath) Then
            System.IO.Directory.CreateDirectory(exportPath)
        End If


        Dim filePath = Path.Combine(exportPath, fileName)

        xmlDoc.Save(filePath)

        Dim result As DialogResult = XtraMessageBox.Show("Do you want to open the xml file?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Process.Start(filePath)
        End If

    End Sub

End Module
