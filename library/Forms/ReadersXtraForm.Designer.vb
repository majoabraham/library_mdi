<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReadersXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReadersXtraForm))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ReadersGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ReadersXpServerCollectionSource = New DevExpress.Xpo.XPServerCollectionSource(Me.components)
        Me.ReadersUnitOfWork = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.ReadersGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdCard = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBirthDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.CreateBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.EditBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ReadersGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReadersXpServerCollectionSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReadersUnitOfWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReadersGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ReadersGridControl)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(748, 294)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ReadersGridControl
        '
        Me.ReadersGridControl.DataSource = Me.ReadersXpServerCollectionSource
        Me.ReadersGridControl.Location = New System.Drawing.Point(12, 12)
        Me.ReadersGridControl.MainView = Me.ReadersGridView
        Me.ReadersGridControl.Name = "ReadersGridControl"
        Me.ReadersGridControl.Size = New System.Drawing.Size(724, 270)
        Me.ReadersGridControl.TabIndex = 7
        Me.ReadersGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ReadersGridView})
        '
        'ReadersXpServerCollectionSource
        '
        Me.ReadersXpServerCollectionSource.DisplayableProperties = "FirstName;LastName;IdCard;BirthDate;FullName"
        Me.ReadersXpServerCollectionSource.ObjectType = GetType(library.Reader)
        Me.ReadersXpServerCollectionSource.Session = Me.ReadersUnitOfWork
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
        Me.LayoutControlItem1.Control = Me.ReadersGridControl
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.CreateBarButtonItem, Me.EditBarButtonItem, Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CreateBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.EditBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True)})
        Me.Bar1.Text = "Tools"
        '
        'CreateBarButtonItem
        '
        Me.CreateBarButtonItem.Hint = "Add Reader"
        Me.CreateBarButtonItem.Id = 0
        Me.CreateBarButtonItem.ImageOptions.SvgImage = CType(resources.GetObject("CreateBarButtonItem.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.CreateBarButtonItem.Name = "CreateBarButtonItem"
        '
        'EditBarButtonItem
        '
        Me.EditBarButtonItem.Hint = "Edit Reader"
        Me.EditBarButtonItem.Id = 1
        Me.EditBarButtonItem.ImageOptions.SvgImage = CType(resources.GetObject("EditBarButtonItem.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.EditBarButtonItem.Name = "EditBarButtonItem"
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
        'BarButtonItem1
        '
        Me.BarButtonItem1.Hint = "Export to Xlsx"
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'ReadersXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 318)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ReadersXtraForm"
        Me.Text = "Readers"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ReadersGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReadersXpServerCollectionSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReadersUnitOfWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReadersGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ReadersGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ReadersGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFirstName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCard As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBirthDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ReadersXpServerCollectionSource As DevExpress.Xpo.XPServerCollectionSource
    Friend WithEvents ReadersUnitOfWork As DevExpress.Xpo.UnitOfWork
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents CreateBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents EditBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
End Class
