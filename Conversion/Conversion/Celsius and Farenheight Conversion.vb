Public Class Celsius_and_Farenheight_Conversion
    Dim Input, Output As Decimal

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        If TxtCelsius.TextLength > 0 And TxtFahrenheit.Text = "" Then
            Try
                Dim holdcel As Decimal
                holdcel = Convert.ToDecimal(TxtCelsius.Text)
                Input = holdcel
            Catch ex As Exception
                MsgBox("Must be a number")
                Exit Sub
            End Try
            Output = (Input * (9 / 5)) + 32
            TxtFahrenheit.Text = Output

        ElseIf TxtFahrenheit.TextLength > 0 And TxtCelsius.Text = "" Then
            Try
                Dim holdFah As Decimal
                holdFah = Convert.ToDecimal(TxtFahrenheit.Text)
                Input = holdFah
            Catch ex As Exception
                MsgBox("Must be a number")
                Exit Sub
            End Try
            Output = (Input - 32) * (5 / 9)
            TxtCelsius.Text = Output
        End If
    End Sub

    Private Sub Celsius_and_Farenheight_Conversion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class