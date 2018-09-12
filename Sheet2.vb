
Public Class Sheet2

    Private Sub Sheet2_Startup() Handles Me.Startup

    End Sub

    Private Sub Sheet2_Shutdown() Handles Me.Shutdown

    End Sub

    Private Sub cmdRun_Click(sender As Object, e As EventArgs) Handles cmdRun.Click

        Dim UI = New frmMain() 'no self-instantiation 
        UI.Show()


    End Sub

End Class
