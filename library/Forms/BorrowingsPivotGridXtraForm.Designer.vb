<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowingsPivotGridXtraForm
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
        Dim PivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
        Dim ExpressionDataBinding1 As DevExpress.XtraPivotGrid.ExpressionDataBinding = New DevExpress.XtraPivotGrid.ExpressionDataBinding()
        Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim ExpressionDataBinding2 As DevExpress.XtraPivotGrid.ExpressionDataBinding = New DevExpress.XtraPivotGrid.ExpressionDataBinding()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.UnitOfWork1 = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.fieldCheckoutDate = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCheckinDate = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBookAuthor = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBookTitle = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldReaderFullName = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.BorrowingsField = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
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
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCheckoutDate, Me.fieldCheckinDate, Me.fieldBookAuthor, Me.fieldBookTitle, Me.fieldReaderFullName, Me.BorrowingsField, Me.PivotGridField})
        PivotGridGroup1.Fields.Add(Me.fieldCheckoutDate)
        Me.PivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
        Me.PivotGridControl1.Size = New System.Drawing.Size(955, 531)
        Me.PivotGridControl1.TabIndex = 0
        '
        'fieldCheckoutDate
        '
        Me.fieldCheckoutDate.AreaIndex = 2
        Me.fieldCheckoutDate.Caption = "CheckoutDate"
        Me.fieldCheckoutDate.DataBinding = ExpressionDataBinding1
        Me.fieldCheckoutDate.Name = "fieldCheckoutDate"
        '
        'fieldCheckinDate
        '
        Me.fieldCheckinDate.AreaIndex = 0
        Me.fieldCheckinDate.Caption = "CheckinDate"
        DataSourceColumnBinding1.ColumnName = "CheckinDate"
        Me.fieldCheckinDate.DataBinding = DataSourceColumnBinding1
        Me.fieldCheckinDate.Name = "fieldCheckinDate"
        '
        'fieldBookAuthor
        '
        Me.fieldBookAuthor.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldBookAuthor.AreaIndex = 0
        Me.fieldBookAuthor.Caption = "Author"
        DataSourceColumnBinding2.ColumnName = "Book.Author"
        Me.fieldBookAuthor.DataBinding = DataSourceColumnBinding2
        Me.fieldBookAuthor.Name = "fieldBookAuthor"
        Me.fieldBookAuthor.Width = 250
        '
        'fieldBookTitle
        '
        Me.fieldBookTitle.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldBookTitle.AreaIndex = 1
        Me.fieldBookTitle.Caption = "Title"
        DataSourceColumnBinding3.ColumnName = "Book.Title"
        Me.fieldBookTitle.DataBinding = DataSourceColumnBinding3
        Me.fieldBookTitle.Name = "fieldBookTitle"
        Me.fieldBookTitle.Width = 250
        '
        'fieldReaderFullName
        '
        Me.fieldReaderFullName.AreaIndex = 1
        Me.fieldReaderFullName.Caption = "Reader.Full Name"
        DataSourceColumnBinding4.ColumnName = "Reader.FullName"
        Me.fieldReaderFullName.DataBinding = DataSourceColumnBinding4
        Me.fieldReaderFullName.Name = "fieldReaderFullName"
        '
        'BorrowingsField
        '
        Me.BorrowingsField.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.BorrowingsField.AreaIndex = 0
        Me.BorrowingsField.Caption = "Borrowings"
        DataSourceColumnBinding5.ColumnName = "CheckoutDate"
        DataSourceColumnBinding5.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
        Me.BorrowingsField.DataBinding = DataSourceColumnBinding5
        Me.BorrowingsField.EmptyValueText = "0"
        Me.BorrowingsField.Name = "BorrowingsField"
        '
        'PivotGridField
        '
        Me.PivotGridField.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField.AreaIndex = 0
        Me.PivotGridField.Caption = "Borrowings Count"
        Me.PivotGridField.CellFormat.FormatString = "n0"
        Me.PivotGridField.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        ExpressionDataBinding2.Expression = "Iif(Count() > 0, Count(), 0)"
        Me.PivotGridField.DataBinding = ExpressionDataBinding2
        Me.PivotGridField.EmptyCellText = "0"
        Me.PivotGridField.Name = "PivotGridField"
        Me.PivotGridField.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'XpCollection1
        '
        Me.XpCollection1.DisplayableProperties = "Reader;Book;CheckoutDate;CheckinDate;Book.Author;Book.Title;Reader.FullName"
        Me.XpCollection1.ObjectType = GetType(library.Borrowing)
        Me.XpCollection1.Session = Me.UnitOfWork1
        '
        'BorrowingsPivotGridXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 531)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "BorrowingsPivotGridXtraForm"
        Me.Text = "Borrowings Pivot Grid"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents UnitOfWork1 As DevExpress.Xpo.UnitOfWork
    Friend WithEvents fieldCheckoutDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCheckinDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBookAuthor As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBookTitle As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldReaderFullName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents BorrowingsField As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField As DevExpress.XtraPivotGrid.PivotGridField
End Class
