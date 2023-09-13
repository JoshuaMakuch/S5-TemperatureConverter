'Joshua Makuch
'RCET 3371
'Fall 2023
'Temperature Converter
'https://github.com/JoshuaMakuch/S5-TemperatureConverter

Option Strict On
Option Explicit On

Public Class TemperatureConverter

    'Sets the temp is fahrenheit variable true
    Dim TempIsF As Boolean = True

    'When the program starts
    Private Sub TemperatureConverter_Load(sender As Object, e As EventArgs) Handles Me.Load
        FahrenheitButton.Checked = True
    End Sub

    'When the user presses the quit button
    Private Sub Quitbutton_Click(sender As Object, e As EventArgs) Handles Quitbutton.Click
        Me.Close()
    End Sub

    'When the user changes the input temperature
    Private Sub InputTextBox_TextChanged(sender As Object, e As EventArgs) Handles InputTextBox.TextChanged

        'Prevents a convserion that may result in a crash
        Try
            If TempIsF Then
                'If the F is pressed, it will assume the input is in C and convert
                OutputTextBox.Text = CStr(Math.Round(((CInt(InputTextBox.Text) - 32) * 5 / 9), 1))
                OutputLabel.Text = "Output (F)"
            ElseIf Not TempIsF Then
                'If the C is pressed, it will assume the input is in F and convert
                OutputTextBox.Text = CStr(Math.Round(((CInt(InputTextBox.Text) * 5 / 9) + 32), 1))
                OutputLabel.Text = "Output (C)"
            End If
        Catch ex As Exception
            'If not a number, output an invalid state
            OutputTextBox.Text = "Invalid Number"
            OutputLabel.Text = "Output (?)"
        End Try

    End Sub

    'When the user presses the fahrenheit button sets the TempIsF to true
    Private Sub FahrenheitButton_CheckedChanged(sender As Object, e As EventArgs) Handles FahrenheitButton.CheckedChanged
        TempIsF = True
    End Sub

    'When the user presses the celsius button sets the TempIsF to false
    Private Sub CelsiusButton_CheckedChanged(sender As Object, e As EventArgs) Handles CelsiusButton.CheckedChanged
        TempIsF = False
    End Sub

End Class
