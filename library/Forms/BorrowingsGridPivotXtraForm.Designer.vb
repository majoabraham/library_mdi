<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowingsGridPivotXtraForm
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
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.UnitOfWork1 = New DevExpress.Xpo.UnitOfWork(Me.components)
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.fieldCheckoutDate = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCheckinDate = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldReaderFullName = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBookAuthor = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBookTitle = New DevExpress.XtraPivotGrid.PivotGridField()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataSource = Me.XpCollection1
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCheckoutDate, Me.fieldCheckinDate, Me.fieldReaderFullName, Me.fieldBookAuthor, Me.fieldBookTitle})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
        Me.PivotGridControl1.Size = New System.Drawing.Size(846, 528)
        Me.PivotGridControl1.TabIndex = 0
        '
        'XpCollection1
        '
        Me.XpCollection1.DisplayableProperties = "Reader;Book;CheckoutDate;CheckinDate;Reader.FullName;Book.Author;Book.Title"
        Me.XpCollection1.ObjectType = GetType(library.Borrowing)
        Me.XpCollection1.Session = Me.UnitOfWork1
        '
        'fieldCheckoutDate
        '
        Me.fieldCheckoutDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldCheckoutDate.AreaIndex = 0
        Me.fieldCheckoutDate.Caption = "CheckoutDate"
        DataSourceColumnBinding1.ColumnName = "CheckoutDate"
        Me.fieldCheckoutDate.DataBinding = DataSourceColumnBinding1
        Me.fieldCheckoutDate.Name = "fieldCheckoutDate"
        '
        'fieldCheckinDate
        '
        Me.fieldCheckinDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldCheckinDate.AreaIndex = 1
        Me.fieldCheckinDate.Caption = "CheckinDate"
        DataSourceColumnBinding2.ColumnName = "CheckinDate"
        Me.fieldCheckinDate.DataBinding = DataSourceColumnBinding2
        Me.fieldCheckinDate.Name = "fieldCheckinDate"
        '
        'fieldReaderFullName
        '
        Me.fieldReaderFullName.AreaIndex = 0
        Me.fieldReaderFullName.Caption = "Reader.Full Name"
        DataSourceColumnBinding3.ColumnName = "Reader.FullName"
        Me.fieldReaderFullName.DataBinding = DataSourceColumnBinding3
        Me.fieldReaderFullName.Name = "fieldReaderFullName"
        '
        'fieldBookAuthor
        '
        Me.fieldBookAuthor.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldBookAuthor.AreaIndex = 0
        Me.fieldBookAuthor.Caption = "Book.Author"
        DataSourceColumnBinding4.ColumnName = "Book.Author"
        Me.fieldBookAuthor.DataBinding = DataSourceColumnBinding4
        Me.fieldBookAuthor.Name = "fieldBookAuthor"
        '
        'fieldBookTitle
        '
        Me.fieldBookTitle.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldBookTitle.AreaIndex = 1
        Me.fieldBookTitle.Caption = "Book.Title"
        DataSourceColumnBinding5.ColumnName = "Book.Title"
        Me.fieldBookTitle.DataBinding = DataSourceColumnBinding5
        Me.fieldBookTitle.Name = "fieldBookTitle"
        '
        'BorrowingsGridPivotXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 528)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "BorrowingsGridPivotXtraForm"
        Me.Text = "Borrowings Grid Pivot"
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
    Friend WithEvents fieldReaderFullName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBookAuthor As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBookTitle As DevExpress.XtraPivotGrid.PivotGridField
End Class
