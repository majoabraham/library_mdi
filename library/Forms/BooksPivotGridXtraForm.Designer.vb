<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BooksPivotGridXtraForm
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
        Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding6 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.UnitOfWork1 = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.fieldTitle = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAuthor = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInStock = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldIsAvailable = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCheckinDate = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataSource = Me.XpCollection1
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldTitle, Me.fieldAuthor, Me.fieldQuantity, Me.fieldInStock, Me.fieldIsAvailable, Me.fieldCheckinDate})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
        Me.PivotGridControl1.Size = New System.Drawing.Size(795, 466)
        Me.PivotGridControl1.TabIndex = 0
        '
        'fieldTitle
        '
        Me.fieldTitle.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldTitle.AreaIndex = 1
        Me.fieldTitle.Caption = "Title"
        DataSourceColumnBinding1.ColumnName = "Title"
        Me.fieldTitle.DataBinding = DataSourceColumnBinding1
        Me.fieldTitle.Name = "fieldTitle"
        '
        'fieldAuthor
        '
        Me.fieldAuthor.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldAuthor.AreaIndex = 0
        Me.fieldAuthor.Caption = "Author"
        DataSourceColumnBinding2.ColumnName = "Author"
        Me.fieldAuthor.DataBinding = DataSourceColumnBinding2
        Me.fieldAuthor.Name = "fieldAuthor"
        '
        'fieldQuantity
        '
        Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldQuantity.AreaIndex = 1
        Me.fieldQuantity.Caption = "Quantity"
        DataSourceColumnBinding3.ColumnName = "Quantity"
        Me.fieldQuantity.DataBinding = DataSourceColumnBinding3
        Me.fieldQuantity.Name = "fieldQuantity"
        '
        'fieldInStock
        '
        Me.fieldInStock.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldInStock.AreaIndex = 0
        Me.fieldInStock.Caption = "In Stock"
        DataSourceColumnBinding4.ColumnName = "InStock"
        Me.fieldInStock.DataBinding = DataSourceColumnBinding4
        Me.fieldInStock.Name = "fieldInStock"
        '
        'fieldIsAvailable
        '
        Me.fieldIsAvailable.AreaIndex = 0
        Me.fieldIsAvailable.Caption = "Is Available"
        DataSourceColumnBinding5.ColumnName = "IsAvailable"
        Me.fieldIsAvailable.DataBinding = DataSourceColumnBinding5
        Me.fieldIsAvailable.Name = "fieldIsAvailable"
        '
        'fieldCheckinDate
        '
        Me.fieldCheckinDate.AreaIndex = 1
        DataSourceColumnBinding6.ColumnName = "Borrowings.CheckinDate"
        DataSourceColumnBinding6.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
        Me.fieldCheckinDate.DataBinding = DataSourceColumnBinding6
        Me.fieldCheckinDate.Name = "fieldCheckinDate"
        '
        'XpCollection1
        '
        Me.XpCollection1.DisplayableProperties = "Title;Author;Quantity;InStock;IsAvailable;Borrowings"
        Me.XpCollection1.ObjectType = GetType(library.Book)
        Me.XpCollection1.Session = Me.UnitOfWork1
        '
        'BooksPivotGridXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 466)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "BooksPivotGridXtraForm"
        Me.Text = "Books Pivot Grid"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents UnitOfWork1 As DevExpress.Xpo.UnitOfWork
    Friend WithEvents fieldTitle As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAuthor As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInStock As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIsAvailable As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCheckinDate As DevExpress.XtraPivotGrid.PivotGridField
End Class
