Imports DevExpress.Xpo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class ReaderEditXtraForm

    Private _reader As Reader
    Private _uow As UnitOfWork
    Private _gridControl As GridControl
    Private _gridView As GridView

    Public Sub New()

        InitializeComponent()
        _uow = New UnitOfWork()

    End Sub

    Public Sub New(gridControl As GridControl, gridView As GridView)

        InitializeComponent()
        _uow = New UnitOfWork()
        _gridControl = gridControl
        _gridView = gridView

    End Sub

    Private Sub ReaderEditXtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadReader()

        FirstNameTextEdit.Text = _reader.FirstName
        LastNameTextEdit.Text = _reader.LastName
        IdCardTextEdit.Text = _reader.IdCard
        BirthDayDateEdit.DateTime = _reader.BirthDate

    End Sub

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        Using _uow

            _reader.FirstName = FirstNameTextEdit.Text
            _reader.LastName = LastNameTextEdit.Text
            _reader.IdCard = IdCardTextEdit.Text
            _reader.BirthDate = BirthDayDateEdit.DateTime

            _uow.CommitChanges()
        End Using

        _gridControl.DataSource = DataManipulation.GetAllReaders()

        Close()
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Close()
    End Sub

    Private Sub LoadReader()

        Dim row As Reader = CType(_gridView.GetFocusedRow(), Reader)

        _reader = _uow.GetObjectByKey(Of Reader)(row.Oid)

    End Sub
End Class