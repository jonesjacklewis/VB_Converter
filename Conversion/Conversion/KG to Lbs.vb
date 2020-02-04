Public Class KG_to_Lbs
    Dim input, output As Decimal
    Const rate = 2.205
    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        txtOutput.Text = ""
        Try
            input = Convert.ToDecimal(txtInput.Text)
        Catch ex As Exception
            MsgBox("Input must be an integer")
            Exit Sub
        End Try
        If RADKGLbs.Checked Then
            output = input * rate
            txtOutput.Text = output
        ElseIf RADLbsKG.Checked Then
            output = input / rate

        End If
        txtOutput.Text = output
    End Sub
End Class