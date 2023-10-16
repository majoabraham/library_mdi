<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookCreateXtraForm
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.IsAvailableCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.AuthorTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TitleTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OkSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.CancelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.QuantitySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.InStockSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.IsAvailableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitleTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InStockSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.IsAvailableCheckEdit)
        Me.LayoutControl1.Controls.Add(Me.AuthorTextEdit)
        Me.LayoutControl1.Controls.Add(Me.TitleTextEdit)
        Me.LayoutControl1.Controls.Add(Me.OkSimpleButton)
        Me.LayoutControl1.Controls.Add(Me.CancelSimpleButton)
        Me.LayoutControl1.Controls.Add(Me.QuantitySpinEdit)
        Me.LayoutControl1.Controls.Add(Me.InStockSpinEdit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1270, 57, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(748, 318)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'IsAvailableCheckEdit
        '
        Me.IsAvailableCheckEdit.Location = New System.Drawing.Point(12, 108)
        Me.IsAvailableCheckEdit.Name = "IsAvailableCheckEdit"
        Me.IsAvailableCheckEdit.Properties.Caption = "Is Available"
        Me.IsAvailableCheckEdit.Size = New System.Drawing.Size(724, 20)
        Me.IsAvailableCheckEdit.StyleController = Me.LayoutControl1
        Me.IsAvailableCheckEdit.TabIndex = 4
        '
        'AuthorTextEdit
        '
        Me.AuthorTextEdit.Location = New System.Drawing.Point(66, 36)
        Me.AuthorTextEdit.Name = "AuthorTextEdit"
        Me.AuthorTextEdit.Size = New System.Drawing.Size(670, 20)
        Me.AuthorTextEdit.StyleController = Me.LayoutControl1
        Me.AuthorTextEdit.TabIndex = 1
        '
        'TitleTextEdit
        '
        Me.TitleTextEdit.Location = New System.Drawing.Point(66, 12)
        Me.TitleTextEdit.Name = "TitleTextEdit"
        Me.TitleTextEdit.Properties.AdvancedModeOptions.Label = "Title"
        Me.TitleTextEdit.Properties.AdvancedModeOptions.LabelAppearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TitleTextEdit.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = True
        Me.TitleTextEdit.Size = New System.Drawing.Size(670, 20)
        Me.TitleTextEdit.StyleController = Me.LayoutControl1
        Me.TitleTextEdit.TabIndex = 1
        '
        'OkSimpleButton
        '
        Me.OkSimpleButton.Location = New System.Drawing.Point(200, 132)
        Me.OkSimpleButton.Name = "OkSimpleButton"
        Me.OkSimpleButton.Size = New System.Drawing.Size(184, 22)
        Me.OkSimpleButton.StyleController = Me.LayoutControl1
        Me.OkSimpleButton.TabIndex = 5
        Me.OkSimpleButton.Text = "OK"
        '
        'CancelSimpleButton
        '
        Me.CancelSimpleButton.Location = New System.Drawing.Point(388, 132)
        Me.CancelSimpleButton.Name = "CancelSimpleButton"
        Me.CancelSimpleButton.Size = New System.Drawing.Size(172, 22)
        Me.CancelSimpleButton.StyleController = Me.LayoutControl1
        Me.CancelSimpleButton.TabIndex = 6
        Me.CancelSimpleButton.Text = "Cancel"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.LayoutControlItem6, Me.LayoutControlItem7})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(748, 318)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TitleTextEdit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(728, 24)
        Me.LayoutControlItem4.Text = "Title"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(42, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.IsAvailableCheckEdit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(728, 24)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.AuthorTextEdit
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(728, 24)
        Me.LayoutControlItem1.Text = "Author"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(42, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.OkSimpleButton
        Me.LayoutControlItem3.Location = New System.Drawing.Point(188, 120)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(188, 178)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.CancelSimpleButton
        Me.LayoutControlItem5.Location = New System.Drawing.Point(376, 120)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(176, 178)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 120)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(188, 178)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(552, 120)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(176, 178)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'QuantitySpinEdit
        '
        Me.QuantitySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.QuantitySpinEdit.Location = New System.Drawing.Point(66, 60)
        Me.QuantitySpinEdit.Name = "QuantitySpinEdit"
        Me.QuantitySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.QuantitySpinEdit.Properties.IsFloatValue = False
        Me.QuantitySpinEdit.Properties.MaskSettings.Set("mask", "N00")
        Me.QuantitySpinEdit.Properties.MaxValue = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.QuantitySpinEdit.Size = New System.Drawing.Size(670, 20)
        Me.QuantitySpinEdit.StyleController = Me.LayoutControl1
        Me.QuantitySpinEdit.TabIndex = 7
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.QuantitySpinEdit
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(728, 24)
        Me.LayoutControlItem6.Text = "Quantity"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(42, 13)
        '
        'InStockSpinEdit
        '
        Me.InStockSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.InStockSpinEdit.Location = New System.Drawing.Point(66, 84)
        Me.InStockSpinEdit.Name = "InStockSpinEdit"
        Me.InStockSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InStockSpinEdit.Properties.IsFloatValue = False
        Me.InStockSpinEdit.Properties.MaskSettings.Set("mask", "N00")
        Me.InStockSpinEdit.Properties.MaxValue = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.InStockSpinEdit.Size = New System.Drawing.Size(670, 20)
        Me.InStockSpinEdit.StyleController = Me.LayoutControl1
        Me.InStockSpinEdit.TabIndex = 8
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.InStockSpinEdit
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(728, 24)
        Me.LayoutControlItem7.Text = "In Stock"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(42, 13)
        '
        'BookCreateXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 318)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "BookCreateXtraForm"
        Me.Text = "Create Book"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.IsAvailableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitleTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InStockSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TitleTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents AuthorTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents IsAvailableCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents OkSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CancelSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents QuantitySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents InStockSpinEdit As DevExpress.XtraEditors.SpinEdit
End Class
