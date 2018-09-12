Imports System.Diagnostics

Public Class Sheet1

    Dim IntroductoryConcepts As New clsIntroductoryConcepts

    Private Sub Sheet1_Startup() Handles Me.Startup

    End Sub

    Private Sub Sheet1_Shutdown() Handles Me.Shutdown

    End Sub

    Private Sub ButtonHello_Click(sender As Object, e As EventArgs) Handles ButtonHello.Click


        IntroductoryConcepts.UsingSimpleMessageBoxes(Application.ActiveSheet)
        IntroductoryConcepts.UsingSimpleVariables(Application.ActiveWorkbook)



    End Sub

    Sub TestBed()

        Dim ws As Excel.Worksheet
        'Dim cr As Excel.CellRange
        ws = Application.ActiveSheet
        For index As Integer = 1 To 5

            ws.Cells(index, 5).value = index.ToString
            'ws.Cells(6, 0).Value
            'Debug.Write(index.ToString & " ")
        Next
        Debug.WriteLine("")
        ' Output: 1 2 3 4 5

    End Sub

End Class
