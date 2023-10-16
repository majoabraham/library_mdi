<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReaderEditXtraForm
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
        Me.IdCardTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LastNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FirstNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BirthDayDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.SaveSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.CancelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.IdCardTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LastNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirstNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BirthDayDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BirthDayDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.IdCardTextEdit)
        Me.LayoutControl1.Controls.Add(Me.LastNameTextEdit)
        Me.LayoutControl1.Controls.Add(Me.FirstNameTextEdit)
        Me.LayoutControl1.Controls.Add(Me.BirthDayDateEdit)
        Me.LayoutControl1.Controls.Add(Me.SaveSimpleButton)
        Me.LayoutControl1.Controls.Add(Me.CancelSimpleButton)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(748, 318)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'IdCardTextEdit
        '
        Me.IdCardTextEdit.Location = New System.Drawing.Point(75, 60)
        Me.IdCardTextEdit.Name = "IdCardTextEdit"
        Me.IdCardTextEdit.Size = New System.Drawing.Size(661, 20)
        Me.IdCardTextEdit.StyleController = Me.LayoutControl1
        Me.IdCardTextEdit.TabIndex = 12
        '
        'LastNameTextEdit
        '
        Me.LastNameTextEdit.Location = New System.Drawing.Point(75, 36)
        Me.LastNameTextEdit.Name = "LastNameTextEdit"
        Me.LastNameTextEdit.Size = New System.Drawing.Size(661, 20)
        Me.LastNameTextEdit.StyleController = Me.LayoutControl1
        Me.LastNameTextEdit.TabIndex = 11
        '
        'FirstNameTextEdit
        '
        Me.FirstNameTextEdit.Location = New System.Drawing.Point(75, 12)
        Me.FirstNameTextEdit.Name = "FirstNameTextEdit"
        Me.FirstNameTextEdit.Size = New System.Drawing.Size(661, 20)
        Me.FirstNameTextEdit.StyleController = Me.LayoutControl1
        Me.FirstNameTextEdit.TabIndex = 10
        '
        'BirthDayDateEdit
        '
        Me.BirthDayDateEdit.EditValue = Nothing
        Me.BirthDayDateEdit.Location = New System.Drawing.Point(75, 84)
        Me.BirthDayDateEdit.Name = "BirthDayDateEdit"
        Me.BirthDayDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BirthDayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BirthDayDateEdit.Size = New System.Drawing.Size(661, 20)
        Me.BirthDayDateEdit.StyleController = Me.LayoutControl1
        Me.BirthDayDateEdit.TabIndex = 13
        '
        'SaveSimpleButton
        '
        Me.SaveSimpleButton.Location = New System.Drawing.Point(194, 108)
        Me.SaveSimpleButton.Name = "SaveSimpleButton"
        Me.SaveSimpleButton.Size = New System.Drawing.Size(178, 22)
        Me.SaveSimpleButton.StyleController = Me.LayoutControl1
        Me.SaveSimpleButton.TabIndex = 14
        Me.SaveSimpleButton.Text = "Save"
        '
        'CancelSimpleButton
        '
        Me.CancelSimpleButton.Location = New System.Drawing.Point(376, 108)
        Me.CancelSimpleButton.Name = "CancelSimpleButton"
        Me.CancelSimpleButton.Size = New System.Drawing.Size(178, 22)
        Me.CancelSimpleButton.StyleController = Me.LayoutControl1
        Me.CancelSimpleButton.TabIndex = 15
        Me.CancelSimpleButton.Text = "Cancel"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem2, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(748, 318)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.IdCardTextEdit
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(728, 24)
        Me.LayoutControlItem1.Text = "ID Card"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(51, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.BirthDayDateEdit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(728, 24)
        Me.LayoutControlItem4.Text = "Birth Day"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(51, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SaveSimpleButton
        Me.LayoutControlItem5.Location = New System.Drawing.Point(182, 96)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(182, 202)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.CancelSimpleButton
        Me.LayoutControlItem6.Location = New System.Drawing.Point(364, 96)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(182, 202)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(546, 96)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(182, 202)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 96)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(182, 202)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.FirstNameTextEdit
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(728, 24)
        Me.LayoutControlItem3.Text = "First Name"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(51, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.LastNameTextEdit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(728, 24)
        Me.LayoutControlItem2.Text = "Last Name"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(51, 13)
        '
        'ReaderEditXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 318)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ReaderEditXtraForm"
        Me.Text = "Edit Reader"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.IdCardTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LastNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirstNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BirthDayDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BirthDayDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents IdCardTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LastNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FirstNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BirthDayDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SaveSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CancelSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
