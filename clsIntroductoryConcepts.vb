Public Class clsIntroductoryConcepts

    Function UsingSimpleMessageBoxes(myWorksheet As Excel.Worksheet)

        MessageBox.Show("Hello World")
        MessageBox.Show(myWorksheet.Cells(1, 2).value) 'row, column

    End Function

    Function UsingSimpleVariables(myWorkbook As Excel.Workbook)

        Dim strTitle As String

        strTitle = myWorkbook.Sheets("Total Sales").Range("A1").Value

        strTitle = strTitle & " is the name of the company"

        MessageBox.Show(strTitle)

    End Function


End Class
