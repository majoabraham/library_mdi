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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.AgendaBarSubItem = New DevExpress.XtraBars.BarSubItem()
        Me.BooksBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.ReadersBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.BorrowingsBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
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
        Me.WindowBarSubItem = New DevExpress.XtraBars.BarSubItem()
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.FooterBarStaticItem = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar4})
        Me.BarManager1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("Readers", New System.Guid("07681dac-007f-4f3d-a1c4-e1dc6a0de0c5")), New DevExpress.XtraBars.BarManagerCategory("Books", New System.Guid("9165bda4-ec64-42c8-8d5c-22e51d4d3c9c"))})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ReadersBarSubItem, Me.BarButtonItem1, Me.BooksBarSubItem, Me.FooterBarStaticItem, Me.BarButtonItem2, Me.BarButtonItem3, Me.ReaderCreateBarButtonItem, Me.ReaderEditBarButtonItem, Me.BookCreateBarButtonItem, Me.BookEditBarButtonItem, Me.BorrowingsBarSubItem, Me.CheckinBarButtonItem, Me.CheckoutBarButtonItem, Me.ShowReaderBarButtonItem, Me.AgendaBarSubItem, Me.WindowBarSubItem, Me.BooksBarButtonItem, Me.ReadersBarButtonItem, Me.BorrowingsBarButtonItem})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 32
        Me.BarManager1.StatusBar = Me.Bar4
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.AgendaBarSubItem), New DevExpress.XtraBars.LinkPersistInfo(Me.BooksBarSubItem), New DevExpress.XtraBars.LinkPersistInfo(Me.ReadersBarSubItem), New DevExpress.XtraBars.LinkPersistInfo(Me.BorrowingsBarSubItem), New DevExpress.XtraBars.LinkPersistInfo(Me.WindowBarSubItem)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'AgendaBarSubItem
        '
        Me.AgendaBarSubItem.Caption = "&Agenda"
        Me.AgendaBarSubItem.Id = 27
        Me.AgendaBarSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BooksBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.ReadersBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.BorrowingsBarButtonItem)})
        Me.AgendaBarSubItem.Name = "AgendaBarSubItem"
        '
        'BooksBarButtonItem
        '
        Me.BooksBarButtonItem.Caption = "Books"
        Me.BooksBarButtonItem.Id = 29
        Me.BooksBarButtonItem.Name = "BooksBarButtonItem"
        '
        'ReadersBarButtonItem
        '
        Me.ReadersBarButtonItem.Caption = "Readers"
        Me.ReadersBarButtonItem.Id = 30
        Me.ReadersBarButtonItem.Name = "ReadersBarButtonItem"
        '
        'BorrowingsBarButtonItem
        '
        Me.BorrowingsBarButtonItem.Caption = "Borrowings"
        Me.BorrowingsBarButtonItem.Id = 31
        Me.BorrowingsBarButtonItem.Name = "BorrowingsBarButtonItem"
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
        'WindowBarSubItem
        '
        Me.WindowBarSubItem.Caption = "&Window"
        Me.WindowBarSubItem.Id = 28
        Me.WindowBarSubItem.Name = "WindowBarSubItem"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1106, 25)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 600)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1106, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 25)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 575)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1106, 25)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 575)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
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
        'DocumentManager1
        '
        Me.DocumentManager1.MdiParent = Me
        Me.DocumentManager1.MenuManager = Me.BarManager1
        Me.DocumentManager1.View = Me.TabbedView1
        Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1})
        '
        'MainXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 623)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IsMdiContainer = True
        Me.Name = "MainXtraForm"
        Me.Text = "My Library"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents ReaderCreateBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ReaderEditBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BookCreateBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BookEditBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BorrowingsBarSubItem As DevExpress.XtraBars.BarSubItem
    Friend WithEvents CheckinBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents CheckoutBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ShowReaderBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents AgendaBarSubItem As DevExpress.XtraBars.BarSubItem
    Friend WithEvents WindowBarSubItem As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BooksBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ReadersBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BorrowingsBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
End Class
