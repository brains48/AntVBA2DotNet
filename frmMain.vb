Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Me.TopMost = True
            Me.CenterToScreen()
            Me.cmbReportType.Items.Add("hello")

            MessageBox.Show(1 / 0)

        Catch ex As ArgumentException

            MessageBox.Show("oops")

        End Try

    End Sub

End Class