Public Class MainXtraForm
    Public Sub New()
        InitializeComponent()
        Connection.Connect()
    End Sub

    Private Sub BookCreateBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BookCreateBarButtonItem.ItemClick
        BookCreateXtraForm.Show()
    End Sub

    Private Sub ReaderCreateBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReaderCreateBarButtonItem.ItemClick
        ReaderCreateXtraForm.Show()
    End Sub

    Private Sub BookEditButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BookEditBarButtonItem.ItemClick
        BookEditXtraForm.Show()
    End Sub

    Private Sub ReaderEditBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReaderEditBarButtonItem.ItemClick
        ReaderEditXtraForm.Show()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CheckoutBarButtonItem.ItemClick
        CheckoutXtraForm.Show()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CheckinBarButtonItem.ItemClick
        CheckinXtraForm.Show()
    End Sub

    Private Sub AgendaXtraTabControl_Selected(sender As Object, e As DevExpress.XtraTab.TabPageEventArgs) Handles AgendaXtraTabControl.Selected
        Select Case AgendaXtraTabControl.SelectedTabPage.Name
            Case "BooksXtraTabPage"
                BooksGridView.SelectRow(1)
                BookEditBarButtonItem.Enabled = True
                ReaderEditBarButtonItem.Enabled = False
                CheckinBarButtonItem.Enabled = False
                ShowReaderBarButtonItem.Enabled = IsSelectedBookBorrowed()
            Case "ReadersXtraTabPage"
                ReadersGridView.SelectRow(1)
                BookEditBarButtonItem.Enabled = False
                ReaderEditBarButtonItem.Enabled = True
                CheckinBarButtonItem.Enabled = False
                ShowReaderBarButtonItem.Enabled = False
            Case "BorrowingsXtraTabPage"
                BorrowingGridView.SelectRow(1)
                BookEditBarButtonItem.Enabled = False
                ReaderEditBarButtonItem.Enabled = False
                CheckinBarButtonItem.Enabled = IsSelectedBorrowingOpened()
                ShowReaderBarButtonItem.Enabled = False
        End Select
    End Sub

    Private Sub MainXtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReaderEditBarButtonItem.Enabled = False
        CheckinBarButtonItem.Enabled = False
        ShowReaderBarButtonItem.Enabled = IsSelectedBookBorrowed()
    End Sub

    Private Sub ShowReaderBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ShowReaderBarButtonItem.ItemClick

        '''1 book - 1 reader approach
        'Dim bookRowId = BooksGridView.GetSelectedRows().First()
        'Dim bookRow As Book = CType(BooksGridView.GetRow(bookRowId), Book)

        'Dim uow As New UnitOfWork()

        'Dim criteria As CriteriaOperator = CriteriaOperator.FromLambda(Of Borrowing)(Function(b) b.Book.Oid = bookRow.Oid)
        'Dim borrowing = New XPCollection(Of Borrowing)(uow, criteria).First()

        'Dim reader = uow.GetObjectByKey(Of Reader)(borrowing.Reader.Oid)

        'Dim readerEditXtraForm As New ReaderEditXtraForm(reader)
        'readerEditXtraForm.Show()

        BookReadersXtraForm.Show()

    End Sub

    Private Function IsSelectedBookBorrowed() As Boolean

        Dim rows = BooksGridView.GetSelectedRows()

        If rows.Length = 0 Then
            Return False
        End If

        Dim rowId = BooksGridView.GetSelectedRows().First()
        Dim row As Book = CType(BooksGridView.GetRow(rowId), Book)

        Return row.InStock < row.Quantity

    End Function

    Private Function IsSelectedBorrowingOpened() As Boolean

        Dim rows = BorrowingGridView.GetSelectedRows()

        If rows.Length = 0 Then
            Return False
        End If

        Dim rowId = rows.First()
        Dim row As Borrowing = CType(BorrowingGridView.GetRow(rowId), Borrowing)

        Return row.CheckinDate Is Nothing

    End Function

    Private Sub BooksGridView_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles BooksGridView.SelectionChanged
        ShowReaderBarButtonItem.Enabled = IsSelectedBookBorrowed()
    End Sub

    Private Sub BorrowingGridView_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles BorrowingGridView.SelectionChanged
        CheckinBarButtonItem.Enabled = IsSelectedBorrowingOpened()
    End Sub
End Class