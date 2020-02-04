Public Class Km_To_Miles
    Dim input, output, hold As Decimal
    Const rate = 1.609

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        Try
            input = Convert.ToDecimal(TxtInput.Text)
        Catch
            MsgBox("Input must be an integer")
        End Try
        If CmbWay.Text = "Kilometres to Miles" Then
            Try
                output = input / rate
            Catch
                MsgBox("input must be a decimal data type")
                Exit Sub
            End Try
        ElseIf CmbWay.Text = "Miles to Kilometres" Then
            output = input * rate
            Try
                output = input * rate
            Catch
                MsgBox("input must be a decimal data type")
                Exit Sub
            End Try
        Else
            MsgBox("Choose a valid option")
            Exit Sub
        End If
        txtOut.Text = output
    End Sub

    Private Sub Km_To_Miles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class