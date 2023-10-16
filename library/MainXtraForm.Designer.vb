<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainXtraForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.AgendaXtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.BooksXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.BooksGridControl = New DevExpress.XtraGrid.GridControl()
        Me.BookXpServerCollectionSource = New DevExpress.Xpo.XPServerCollectionSource(Me.components)
        Me.BooksUnitOfWork = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.BooksGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAuthor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsAvailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.InStockGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BooksBarSubItem = New DevExpress.XtraBars.BarSubItem()
        Me.BookCreateBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.BookEditBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.ShowReaderBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.ReadersBarSubItem = New DevExpress.XtraBars.BarSubItem()
        Me.ReaderCreateBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.ReaderEditBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.BorrowingsBarSubItem = New DevExpress.XtraBars.BarSubItem()
        Me.CheckoutBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.CheckinBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.FooterBarStaticItem = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.ReadersXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.ReadersGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ReaderXpServerCollectionSource = New DevExpress.Xpo.XPServerCollectionSource(Me.components)
        Me.ReadersUnitOfWork = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.ReadersGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdCard = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBirthDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BorrowingsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.BorrowingGridControl = New DevExpress.XtraGrid.GridControl()
        Me.BorrowingXpServerCollectionSource = New DevExpress.Xpo.XPServerCollectionSource(Me.components)
        Me.BorrowingUnitOfWork = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.BorrowingGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCheckoutDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCheckinDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReader = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBook = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.Agenda = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.AgendaXtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AgendaXtraTabControl.SuspendLayout()
        Me.BooksXtraTabPage.SuspendLayout()
        CType(Me.BooksGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookXpServerCollectionSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksUnitOfWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReadersXtraTabPage.SuspendLayout()
        CType(Me.ReadersGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReaderXpServerCollectionSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReadersUnitOfWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReadersGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BorrowingsXtraTabPage.SuspendLayout()
        CType(Me.BorrowingGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowingXpServerCollectionSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowingUnitOfWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowingGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.AgendaXtraTabControl)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 20)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1106, 581)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'AgendaXtraTabControl
        '
        Me.AgendaXtraTabControl.Location = New System.Drawing.Point(12, 12)
        Me.AgendaXtraTabControl.Name = "AgendaXtraTabControl"
        Me.AgendaXtraTabControl.SelectedTabPage = Me.BooksXtraTabPage
        Me.AgendaXtraTabControl.Size = New System.Drawing.Size(1082, 557)
        Me.AgendaXtraTabControl.TabIndex = 7
        Me.AgendaXtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.BooksXtraTabPage, Me.ReadersXtraTabPage, Me.BorrowingsXtraTabPage})
        '
        'BooksXtraTabPage
        '
        Me.BooksXtraTabPage.Controls.Add(Me.BooksGridControl)
        Me.BooksXtraTabPage.Name = "BooksXtraTabPage"
        Me.BooksXtraTabPage.Size = New System.Drawing.Size(1080, 532)
        Me.BooksXtraTabPage.Text = "Books"
        '
        'BooksGridControl
        '
        Me.BooksGridControl.DataSource = Me.BookXpServerCollectionSource
        Me.BooksGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BooksGridControl.Location = New System.Drawing.Point(0, 0)
        Me.BooksGridControl.MainView = Me.BooksGridView
        Me.BooksGridControl.MenuManager = Me.BarManager1
        Me.BooksGridControl.Name = "BooksGridControl"
        Me.BooksGridControl.Size = New System.Drawing.Size(1080, 532)
        Me.BooksGridControl.TabIndex = 5
        Me.BooksGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BooksGridView})
        '
        'BookXpServerCollectionSource
        '
        Me.BookXpServerCollectionSource.ObjectType = GetType(library.Book)
        Me.BookXpServerCollectionSource.Session = Me.BooksUnitOfWork
        '
        'BooksGridView
        '
        Me.BooksGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTitle, Me.colAuthor, Me.colIsAvailable, Me.colQuantity, Me.InStockGridColumn})
        Me.BooksGridView.GridControl = Me.BooksGridControl
        Me.BooksGridView.Name = "BooksGridView"
        Me.BooksGridView.OptionsBehavior.Editable = False
        '
        'colTitle
        '
        Me.colTitle.FieldName = "Title"
        Me.colTitle.Name = "colTitle"
        Me.colTitle.Visible = True
        Me.colTitle.VisibleIndex = 0
        '
        'colAuthor
        '
        Me.colAuthor.FieldName = "Author"
        Me.colAuthor.Name = "colAuthor"
        Me.colAuthor.Visible = True
        Me.colAuthor.VisibleIndex = 1
        '
        'colIsAvailable
        '
        Me.colIsAvailable.Caption = "Available"
        Me.colIsAvailable.FieldName = "IsAvailable"
        Me.colIsAvailable.Name = "colIsAvailable"
        Me.colIsAvailable.Visible = True
        Me.colIsAvailable.VisibleIndex = 2
        '
        'colQuantity
        '
        Me.colQuantity.Caption = "Quantity"
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 4
        '
        'InStockGridColumn
        '
        Me.InStockGridColumn.Caption = "In Stock"
        Me.InStockGridColumn.FieldName = "InStock"
        Me.InStockGridColumn.Name = "InStockGridColumn"
        Me.InStockGridColumn.Visible = True
        Me.InStockGridColumn.VisibleIndex = 3
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar4})
        Me.BarManager1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("Readers", New System.Guid("07681dac-007f-4f3d-a1c4-e1dc6a0de0c5")), New DevExpress.XtraBars.BarManagerCategory("Books", New System.Guid("9165bda4-ec64-42c8-8d5c-22e51d4d3c9c"))})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ReadersBarSubItem, Me.BarButtonItem1, Me.BooksBarSubItem, Me.FooterBarStaticItem, Me.BarButtonItem2, Me.BarButtonItem3, Me.ReaderCreateBarButtonItem, Me.ReaderEditBarButtonItem, Me.BookCreateBarButtonItem, Me.BookEditBarButtonItem, Me.BorrowingsBarSubItem, Me.CheckinBarButtonItem, Me.CheckoutBarButtonItem, Me.ShowReaderBarButtonItem})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 27
        Me.BarManager1.StatusBar = Me.Bar4
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BooksBarSubItem), New DevExpress.XtraBars.LinkPersistInfo(Me.ReadersBarSubItem), New DevExpress.XtraBars.LinkPersistInfo(Me.BorrowingsBarSubItem)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BooksBarSubItem
        '
        Me.BooksBarSubItem.Caption = "&Books"
        Me.BooksBarSubItem.Id = 14
        Me.BooksBarSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BookCreateBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.BookEditBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.ShowReaderBarButtonItem)})
        Me.BooksBarSubItem.Name = "BooksBarSubItem"
        '
        'BookCreateBarButtonItem
        '
        Me.BookCreateBarButtonItem.Caption = "&Create"
        Me.BookCreateBarButtonItem.Id = 21
        Me.BookCreateBarButtonItem.Name = "BookCreateBarButtonItem"
        '
        'BookEditBarButtonItem
        '
        Me.BookEditBarButtonItem.Caption = "&Edit"
        Me.BookEditBarButtonItem.Id = 22
        Me.BookEditBarButtonItem.Name = "BookEditBarButtonItem"
        '
        'ShowReaderBarButtonItem
        '
        Me.ShowReaderBarButtonItem.Caption = "&Show Reader"
        Me.ShowReaderBarButtonItem.Id = 26
        Me.ShowReaderBarButtonItem.Name = "ShowReaderBarButtonItem"
        '
        'ReadersBarSubItem
        '
        Me.ReadersBarSubItem.Caption = "&Readers"
        Me.ReadersBarSubItem.Id = 6
        Me.ReadersBarSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ReaderCreateBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.ReaderEditBarButtonItem)})
        Me.ReadersBarSubItem.Name = "ReadersBarSubItem"
        '
        'ReaderCreateBarButtonItem
        '
        Me.ReaderCreateBarButtonItem.Caption = "&Create"
        Me.ReaderCreateBarButtonItem.Id = 19
        Me.ReaderCreateBarButtonItem.Name = "ReaderCreateBarButtonItem"
        '
        'ReaderEditBarButtonItem
        '
        Me.ReaderEditBarButtonItem.Caption = "&Edit"
        Me.ReaderEditBarButtonItem.Id = 20
        Me.ReaderEditBarButtonItem.Name = "ReaderEditBarButtonItem"
        '
        'BorrowingsBarSubItem
        '
        Me.BorrowingsBarSubItem.Caption = "B&orrowings"
        Me.BorrowingsBarSubItem.Id = 23
        Me.BorrowingsBarSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CheckoutBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.CheckinBarButtonItem)})
        Me.BorrowingsBarSubItem.Name = "BorrowingsBarSubItem"
        '
        'CheckoutBarButtonItem
        '
        Me.CheckoutBarButtonItem.Caption = "Check&out"
        Me.CheckoutBarButtonItem.Id = 25
        Me.CheckoutBarButtonItem.Name = "CheckoutBarButtonItem"
        '
        'CheckinBarButtonItem
        '
        Me.CheckinBarButtonItem.Caption = "Check&in"
        Me.CheckinBarButtonItem.Id = 24
        Me.CheckinBarButtonItem.Name = "CheckinBarButtonItem"
        '
        'Bar4
        '
        Me.Bar4.BarName = "Custom 3"
        Me.Bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.FooterBarStaticItem)})
        Me.Bar4.OptionsBar.AllowQuickCustomization = False
        Me.Bar4.OptionsBar.DrawDragBorder = False
        Me.Bar4.OptionsBar.UseWholeRow = True
        Me.Bar4.Text = "Custom 3"
        '
        'FooterBarStaticItem
        '
        Me.FooterBarStaticItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.FooterBarStaticItem.Caption = "© My Library 2023"
        Me.FooterBarStaticItem.Id = 16
        Me.FooterBarStaticItem.Name = "FooterBarStaticItem"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1106, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 601)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1106, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 581)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1106, 20)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 581)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "&Home"
        Me.BarButtonItem1.Id = 9
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "&View"
        Me.BarButtonItem2.Id = 17
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "&View"
        Me.BarButtonItem3.Id = 18
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'ReadersXtraTabPage
        '
        Me.ReadersXtraTabPage.Controls.Add(Me.ReadersGridControl)
        Me.ReadersXtraTabPage.Name = "ReadersXtraTabPage"
        Me.ReadersXtraTabPage.Size = New System.Drawing.Size(1080, 532)
        Me.ReadersXtraTabPage.Text = "Readers"
        '
        'ReadersGridControl
        '
        Me.ReadersGridControl.DataSource = Me.ReaderXpServerCollectionSource
        Me.ReadersGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReadersGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ReadersGridControl.MainView = Me.ReadersGridView
        Me.ReadersGridControl.MenuManager = Me.BarManager1
        Me.ReadersGridControl.Name = "ReadersGridControl"
        Me.ReadersGridControl.Size = New System.Drawing.Size(1080, 532)
        Me.ReadersGridControl.TabIndex = 6
        Me.ReadersGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ReadersGridView})
        '
        'ReaderXpServerCollectionSource
        '
        Me.ReaderXpServerCollectionSource.DisplayableProperties = "FirstName;LastName;IdCard;BirthDate"
        Me.ReaderXpServerCollectionSource.ObjectType = GetType(library.Reader)
        Me.ReaderXpServerCollectionSource.Session = Me.ReadersUnitOfWork
        '
        'ReadersGridView
        '
        Me.ReadersGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFirstName, Me.colLastName, Me.colIdCard, Me.colBirthDay})
        Me.ReadersGridView.GridControl = Me.ReadersGridControl
        Me.ReadersGridView.Name = "ReadersGridView"
        Me.ReadersGridView.OptionsBehavior.Editable = False
        '
        'colFirstName
        '
        Me.colFirstName.Caption = "First Name"
        Me.colFirstName.FieldName = "FirstName"
        Me.colFirstName.Name = "colFirstName"
        Me.colFirstName.Visible = True
        Me.colFirstName.VisibleIndex = 0
        '
        'colLastName
        '
        Me.colLastName.Caption = "Last Name"
        Me.colLastName.FieldName = "LastName"
        Me.colLastName.Name = "colLastName"
        Me.colLastName.Visible = True
        Me.colLastName.VisibleIndex = 1
        '
        'colIdCard
        '
        Me.colIdCard.Caption = "ID Card"
        Me.colIdCard.FieldName = "IdCard"
        Me.colIdCard.Name = "colIdCard"
        Me.colIdCard.Visible = True
        Me.colIdCard.VisibleIndex = 2
        '
        'colBirthDay
        '
        Me.colBirthDay.Caption = "Birth Day"
        Me.colBirthDay.FieldName = "BirthDate"
        Me.colBirthDay.Name = "colBirthDay"
        Me.colBirthDay.Visible = True
        Me.colBirthDay.VisibleIndex = 3
        '
        'BorrowingsXtraTabPage
        '
        Me.BorrowingsXtraTabPage.Controls.Add(Me.BorrowingGridControl)
        Me.BorrowingsXtraTabPage.Name = "BorrowingsXtraTabPage"
        Me.BorrowingsXtraTabPage.Size = New System.Drawing.Size(1080, 532)
        Me.BorrowingsXtraTabPage.Text = "Borrowings"
        '
        'BorrowingGridControl
        '
        Me.BorrowingGridControl.DataSource = Me.BorrowingXpServerCollectionSource
        Me.BorrowingGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorrowingGridControl.Location = New System.Drawing.Point(0, 0)
        Me.BorrowingGridControl.MainView = Me.BorrowingGridView
        Me.BorrowingGridControl.MenuManager = Me.BarManager1
        Me.BorrowingGridControl.Name = "BorrowingGridControl"
        Me.BorrowingGridControl.Size = New System.Drawing.Size(1080, 532)
        Me.BorrowingGridControl.TabIndex = 0
        Me.BorrowingGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BorrowingGridView})
        '
        'BorrowingXpServerCollectionSource
        '
        Me.BorrowingXpServerCollectionSource.DisplayableProperties = "Reader;Book;CheckoutDate;CheckinDate"
        Me.BorrowingXpServerCollectionSource.ObjectType = GetType(library.Borrowing)
        Me.BorrowingXpServerCollectionSource.Session = Me.BorrowingUnitOfWork
        '
        'BorrowingGridView
        '
        Me.BorrowingGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCheckoutDate, Me.colCheckinDate, Me.colReader, Me.colBook})
        Me.BorrowingGridView.GridControl = Me.BorrowingGridControl
        Me.BorrowingGridView.Name = "BorrowingGridView"
        '
        'colCheckoutDate
        '
        Me.colCheckoutDate.FieldName = "CheckoutDate"
        Me.colCheckoutDate.Name = "colCheckoutDate"
        Me.colCheckoutDate.Visible = True
        Me.colCheckoutDate.VisibleIndex = 2
        '
        'colCheckinDate
        '
        Me.colCheckinDate.FieldName = "CheckinDate"
        Me.colCheckinDate.Name = "colCheckinDate"
        Me.colCheckinDate.Visible = True
        Me.colCheckinDate.VisibleIndex = 3
        '
        'colReader
        '
        Me.colReader.Caption = "Reader"
        Me.colReader.FieldName = "Reader.FullName"
        Me.colReader.Name = "colReader"
        Me.colReader.Visible = True
        Me.colReader.VisibleIndex = 1
        '
        'colBook
        '
        Me.colBook.Caption = "Book"
        Me.colBook.FieldName = "Book.Title"
        Me.colBook.Name = "colBook"
        Me.colBook.Visible = True
        Me.colBook.VisibleIndex = 0
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.Agenda})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1106, 581)
        Me.Root.TextVisible = False
        '
        'Agenda
        '
        Me.Agenda.Control = Me.AgendaXtraTabControl
        Me.Agenda.Location = New System.Drawing.Point(0, 0)
        Me.Agenda.Name = "Agenda"
        Me.Agenda.Size = New System.Drawing.Size(1086, 561)
        Me.Agenda.TextSize = New System.Drawing.Size(0, 0)
        Me.Agenda.TextVisible = False
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 3"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 1
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Custom 3"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 3"
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 1
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar3.Text = "Custom 3"
        '
        'MainXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 623)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "MainXtraForm"
        Me.Text = "My Library"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.AgendaXtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AgendaXtraTabControl.ResumeLayout(False)
        Me.BooksXtraTabPage.ResumeLayout(False)
        CType(Me.BooksGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookXpServerCollectionSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksUnitOfWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReadersXtraTabPage.ResumeLayout(False)
        CType(Me.ReadersGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReaderXpServerCollectionSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReadersUnitOfWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReadersGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BorrowingsXtraTabPage.ResumeLayout(False)
        CType(Me.BorrowingGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowingXpServerCollectionSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowingUnitOfWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowingGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ReadersBarSubItem As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BooksBarSubItem As DevExpress.XtraBars.BarSubItem
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents FooterBarStaticItem As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BooksGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents BooksUnitOfWork As DevExpress.Xpo.UnitOfWork
    Friend WithEvents BooksGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAuthor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsAvailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReadersGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ReadersGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ReaderXpServerCollectionSource As DevExpress.Xpo.XPServerCollectionSource
    Friend WithEvents colFirstName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCard As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBirthDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReaderCreateBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ReaderEditBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BookCreateBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BookEditBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ReadersUnitOfWork As DevExpress.Xpo.UnitOfWork
    Friend WithEvents AgendaXtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents BooksXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ReadersXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Agenda As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BorrowingsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BookXpServerCollectionSource As DevExpress.Xpo.XPServerCollectionSource
    Friend WithEvents BorrowingsBarSubItem As DevExpress.XtraBars.BarSubItem
    Friend WithEvents CheckinBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BorrowingGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents BorrowingXpServerCollectionSource As DevExpress.Xpo.XPServerCollectionSource
    Friend WithEvents BorrowingUnitOfWork As DevExpress.Xpo.UnitOfWork
    Friend WithEvents BorrowingGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCheckoutDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCheckinDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReader As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBook As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckoutBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ShowReaderBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InStockGridColumn As DevExpress.XtraGrid.Columns.GridColumn
End Class
