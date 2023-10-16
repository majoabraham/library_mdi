Imports DevExpress.Xpo

Public Class ReaderCreateXtraForm

    Private _uow As UnitOfWork

    Public Sub New()

        InitializeComponent()
        _uow = New UnitOfWork()

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

        MainXtraForm.ReadersGridControl.DataSource = DataManipulation.GetAllReaders()

        Close()
    End Sub
End Class