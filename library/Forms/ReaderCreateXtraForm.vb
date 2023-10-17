Imports DevExpress.Xpo
Imports DevExpress.XtraGrid

Public Class ReaderCreateXtraForm

    Private _uow As UnitOfWork
    Private _gridControl As GridControl

    Public Sub New()

        InitializeComponent()
        _uow = New UnitOfWork()

    End Sub

    Public Sub New(gridControl As GridControl)

        InitializeComponent()
        _uow = New UnitOfWork()
        _gridControl = gridControl

    End Sub
    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Close()
    End Sub

    Private Sub OkSimpleButton_Click(sender As Object, e As EventArgs) Handles OkSimpleButton.Click
        Using _uow
            Dim reader = New Reader(_uow) With {
                .FirstName = FirstNameTextEdit.Text,
                .LastName = LastNameTextEdit.Text,
                .IdCard = IdCardTextEdit.Text,
                .BirthDate = BirthDayDateEdit.DateTime
            }

            _uow.CommitChanges()
        End Using

        _gridControl.DataSource = DataManipulation.GetAllReaders()

        Close()
    End Sub
End Class