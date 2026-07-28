Imports System.Runtime.CompilerServices
Class MainWindow
    Dim GamePlay As Boolean = True
    Private Sub btnLoop_Click(sender As Object, e As RoutedEventArgs) Handles btnLoop.Click
        'For Loop
        For intCount = 1 To 10
            txtData.Text += intCount.ToString() + vbNewLine
            txtData.Text = "Welcome to RateSong Version 2.!"
        Next

        For intCount2 = 1 To 10

            lstData.Items.Add("*Song Name*" & intCount2.ToString & "N/A / 10. *Insert Song Rating here*")
        Next

        '

    End Sub

    Private Sub btnClear_Click(sender As Object, e As RoutedEventArgs) Handles btnClear.Click
        lstData.items.clear()
        txtData.Text = ""

    End Sub


End Class
