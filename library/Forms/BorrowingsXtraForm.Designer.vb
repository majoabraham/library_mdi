<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowingsXtraForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BorrowingsXtraForm))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.BorrowingGridControl = New DevExpress.XtraGrid.GridControl()
        Me.BorrowingXpServerCollectionSource = New DevExpress.Xpo.XPServerCollectionSource(Me.components)
        Me.BorrowingUnitOfWork = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.BorrowingGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCheckoutDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCheckinDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReader = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBook = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.CheckoutBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.BorrowingGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowingXpServerCollectionSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowingUnitOfWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowingGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.BorrowingGridControl)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(748, 294)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'BorrowingGridControl
        '
        Me.BorrowingGridControl.DataSource = Me.BorrowingXpServerCollectionSource
        Me.BorrowingGridControl.Location = New System.Drawing.Point(12, 12)
        Me.BorrowingGridControl.MainView = Me.BorrowingGridView
        Me.BorrowingGridControl.Name = "BorrowingGridControl"
        Me.BorrowingGridControl.Size = New System.Drawing.Size(724, 270)
        Me.BorrowingGridControl.TabIndex = 4
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
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(748, 294)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.BorrowingGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(728, 274)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.CheckoutBarButtonItem, Me.BarButtonItem2})
        Me.BarManager1.MaxItemId = 2
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(748, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 318)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(748, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 294)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(748, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 294)
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CheckoutBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
        Me.Bar1.Text = "Tools"
        '
        'CheckoutBarButtonItem
        '
        Me.CheckoutBarButtonItem.Hint = "Checkout Book"
        Me.CheckoutBarButtonItem.Id = 0
        Me.CheckoutBarButtonItem.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.CheckoutBarButtonItem.Name = "CheckoutBarButtonItem"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Hint = "Checkin Book"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BorrowingsXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 318)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "BorrowingsXtraForm"
        Me.Text = "Borrowings"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.BorrowingGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowingXpServerCollectionSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowingUnitOfWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowingGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BorrowingGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents BorrowingGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCheckoutDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCheckinDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReader As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBook As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BorrowingXpServerCollectionSource As DevExpress.Xpo.XPServerCollectionSource
    Friend WithEvents BorrowingUnitOfWork As DevExpress.Xpo.UnitOfWork
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents CheckoutBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
End Class
