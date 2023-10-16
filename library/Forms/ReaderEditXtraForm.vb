Imports DevExpress.Xpo

Public Class ReaderEditXtraForm

    Private _reader As Reader
    Private _uow As UnitOfWork
    Private _readersXtraForm As ReadersXtraForm

    Public Sub New()
        InitializeComponent()
        _uow = New UnitOfWork()
        _readersXtraForm = CType(MainXtraForm.ActiveMdiChild, ReadersXtraForm)

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

        _readersXtraForm.ReadersGridControl.DataSource = DataManipulation.GetAllReaders()

        Close()
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Close()
    End Sub

    Private Sub LoadReader()
        Dim rowId = _readersXtraForm.ReadersGridView.GetSelectedRows().First()
        Dim row As Reader = CType(_readersXtraForm.ReadersGridView.GetRow(rowId), Reader)

        _reader = _uow.GetObjectByKey(Of Reader)(row.Oid)

    End Sub
End Class