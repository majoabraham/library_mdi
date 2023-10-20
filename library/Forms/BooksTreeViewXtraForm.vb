Imports DevExpress.Data
Imports DevExpress.Xpo
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraTreeList.Nodes

Public Class BooksTreeViewXtraForm

    Private _uow As UnitOfWork = New UnitOfWork()

    Private Sub BooksTreeViewXtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CreateColumns(BooksTreeList)
        CreateNodes(BooksTreeList)

    End Sub

    Private Sub CreateColumns(ByVal treeList As TreeList)

        treeList.BeginUpdate()

        Dim col1 As TreeListColumn = treeList.Columns.Add()
        col1.FieldName = "Books"
        col1.Caption = "Books"
        col1.VisibleIndex = 0

        treeList.EndUpdate()

    End Sub

    Private Sub CreateNodes(ByVal treeList As TreeList)

        Dim books = New XPCollection(Of Book)(_uow)

        treeList.BeginUnboundLoad()

        ' Create a root node
        Dim parentForRootNodes As TreeListNode = Nothing
        Dim bookNode As TreeListNode = Nothing

        For Each book In books
            bookNode = treeList.AppendNode(New Object() {$"{book.Author} : {book.Title}"}, parentForRootNodes)

            For Each borrowing In book.Borrowings
                If borrowing.CheckinDate Is Nothing Then
                    treeList.AppendNode(New Object() {borrowing.Reader.FullName}, bookNode)
                End If

            Next
        Next

        treeList.EndUnboundLoad()

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

        Dim fileName = "books.xml"

        DataManipulation.ExportTreeListToXml2(fileName, BooksTreeList)

    End Sub
End Class