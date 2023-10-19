Imports DevExpress.Xpo
Imports DevExpress.XtraScheduler

Public Class CalendarRibbonForm
    Private _uow As New UnitOfWork
    Private Sub CalendarRibbonForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each appointment As Appointment In SchedulerDataStorage1.Appointments.Items
            If appointment.Duration > TimeSpan.Zero Then
                appointment.LabelKey = 7
            Else
                appointment.LabelKey = 1
            End If
        Next
    End Sub

End Class