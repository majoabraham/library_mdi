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
        col1.FieldName = "Borrowings"
        col1.Caption = "Borrowings"
        col1.VisibleIndex = 0

        treeList.EndUpdate()

    End Sub

    Private Sub CreateNodes(ByVal treeList As TreeList)

        Dim books = New XPCollection(Of Book)(_uow)

        treeList.BeginUnboundLoad()

        ' Create a root node
        Dim parentForRootNodes As TreeListNode = Nothing

        For Each book In books
            Dim bookAuthorNode = treeList.AppendNode(New Object() {book.Author}, parentForRootNodes)
            Dim bookTitleNode = treeList.AppendNode(New Object() {book.Title}, bookAuthorNode)

            For Each borrowing In book.Borrowings
                If borrowing.CheckinDate Is Nothing Then
                    Dim borrowingReaderName = treeList.AppendNode(New Object() {borrowing.Reader.FullName}, bookTitleNode)
                    Dim borrowingCheckout = treeList.AppendNode(New Object() {borrowing.CheckoutDate.Value.ToShortDateString()}, borrowingReaderName)
                End If

            Next
        Next

        treeList.EndUnboundLoad()

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

        Dim fileName = "books.xml"

        DataManipulation.ExportTreeListToXml(fileName, BooksTreeList)

    End Sub
End Class