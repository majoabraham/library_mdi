<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BooksXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BooksXtraForm))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.BooksGridControl = New DevExpress.XtraGrid.GridControl()
        Me.BooksXpServerCollectionSource = New DevExpress.Xpo.XPServerCollectionSource(Me.components)
        Me.BooksUnitOfWork = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.BooksGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAuthor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsAvailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.InStockGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.CreateBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.EditBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.ReadersBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.ReportBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.ReportBorrowingsBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.ExportXlsxBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.TreeViewBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.PivotGridBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.BooksGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksXpServerCollectionSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksUnitOfWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.BooksGridControl)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(748, 294)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'BooksGridControl
        '
        Me.BooksGridControl.DataSource = Me.BooksXpServerCollectionSource
        Me.BooksGridControl.Location = New System.Drawing.Point(12, 12)
        Me.BooksGridControl.MainView = Me.BooksGridView
        Me.BooksGridControl.Name = "BooksGridControl"
        Me.BooksGridControl.Size = New System.Drawing.Size(724, 270)
        Me.BooksGridControl.TabIndex = 6
        Me.BooksGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BooksGridView})
        '
        'BooksXpServerCollectionSource
        '
        Me.BooksXpServerCollectionSource.DisplayableProperties = "Title;Author;Quantity;InStock;IsAvailable"
        Me.BooksXpServerCollectionSource.ObjectType = GetType(library.Book)
        Me.BooksXpServerCollectionSource.Session = Me.BooksUnitOfWork
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
        Me.LayoutControlItem1.Control = Me.BooksGridControl
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.CreateBarButtonItem, Me.EditBarButtonItem, Me.ReadersBarButtonItem, Me.ReportBarButtonItem, Me.ReportBorrowingsBarButtonItem, Me.ExportXlsxBarButtonItem, Me.TreeViewBarButtonItem, Me.PivotGridBarButtonItem})
        Me.BarManager1.MaxItemId = 8
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CreateBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.EditBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.ReadersBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.ReportBarButtonItem, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.ReportBorrowingsBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.ExportXlsxBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.TreeViewBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.PivotGridBarButtonItem, "", False, True, False, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.Text = "Tools"
        '
        'CreateBarButtonItem
        '
        Me.CreateBarButtonItem.Hint = "Add Book"
        Me.CreateBarButtonItem.Id = 0
        Me.CreateBarButtonItem.ImageOptions.SvgImage = CType(resources.GetObject("CreateBarButtonItem.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.CreateBarButtonItem.Name = "CreateBarButtonItem"
        '
        'EditBarButtonItem
        '
        Me.EditBarButtonItem.Hint = "Edit Book"
        Me.EditBarButtonItem.Id = 1
        Me.EditBarButtonItem.ImageOptions.SvgImage = CType(resources.GetObject("EditBarButtonItem.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.EditBarButtonItem.Name = "EditBarButtonItem"
        '
        'ReadersBarButtonItem
        '
        Me.ReadersBarButtonItem.Hint = "Show Readers"
        Me.ReadersBarButtonItem.Id = 2
        Me.ReadersBarButtonItem.ImageOptions.SvgImage = CType(resources.GetObject("ReadersBarButtonItem.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.ReadersBarButtonItem.Name = "ReadersBarButtonItem"
        '
        'ReportBarButtonItem
        '
        Me.ReportBarButtonItem.Hint = "Books Report"
        Me.ReportBarButtonItem.Id = 3
        Me.ReportBarButtonItem.ImageOptions.Image = CType(resources.GetObject("ReportBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.ReportBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("ReportBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.ReportBarButtonItem.Name = "ReportBarButtonItem"
        '
        'ReportBorrowingsBarButtonItem
        '
        Me.ReportBorrowingsBarButtonItem.Hint = "Books Readers Report"
        Me.ReportBorrowingsBarButtonItem.Id = 4
        Me.ReportBorrowingsBarButtonItem.ImageOptions.Image = CType(resources.GetObject("ReportBorrowingsBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.ReportBorrowingsBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("ReportBorrowingsBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.ReportBorrowingsBarButtonItem.Name = "ReportBorrowingsBarButtonItem"
        '
        'ExportXlsxBarButtonItem
        '
        Me.ExportXlsxBarButtonItem.Hint = "Export to Xlsx"
        Me.ExportXlsxBarButtonItem.Id = 5
        Me.ExportXlsxBarButtonItem.ImageOptions.Image = CType(resources.GetObject("ExportXlsxBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.ExportXlsxBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("ExportXlsxBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.ExportXlsxBarButtonItem.Name = "ExportXlsxBarButtonItem"
        '
        'TreeViewBarButtonItem
        '
        Me.TreeViewBarButtonItem.Hint = "Tree View"
        Me.TreeViewBarButtonItem.Id = 6
        Me.TreeViewBarButtonItem.ImageOptions.Image = CType(resources.GetObject("TreeViewBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.TreeViewBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("TreeViewBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.TreeViewBarButtonItem.Name = "TreeViewBarButtonItem"
        '
        'PivotGridBarButtonItem
        '
        Me.PivotGridBarButtonItem.Hint = "Pivot Grid"
        Me.PivotGridBarButtonItem.Id = 7
        Me.PivotGridBarButtonItem.ImageOptions.Image = CType(resources.GetObject("PivotGridBarButtonItem.ImageOptions.Image"), System.Drawing.Image)
        Me.PivotGridBarButtonItem.ImageOptions.LargeImage = CType(resources.GetObject("PivotGridBarButtonItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.PivotGridBarButtonItem.Name = "PivotGridBarButtonItem"
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
        'BooksXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 318)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "BooksXtraForm"
        Me.Text = "Books"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.BooksGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksXpServerCollectionSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksUnitOfWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BooksGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents BooksGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAuthor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsAvailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InStockGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BooksXpServerCollectionSource As DevExpress.Xpo.XPServerCollectionSource
    Friend WithEvents BooksUnitOfWork As DevExpress.Xpo.UnitOfWork
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents CreateBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents EditBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ReadersBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ReportBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ReportBorrowingsBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ExportXlsxBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TreeViewBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PivotGridBarButtonItem As DevExpress.XtraBars.BarButtonItem
End Class
