Public Class Metres_to_Feet_and_Inches
    Dim Inch, Feet As Integer
    Dim Metres, HoldInch As Decimal
    Const mtoinch = 39.37
    Const rate = 12

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        Try
            Metres = Convert.ToDecimal(txtMetres.Text)
        Catch ex As Exception
            MsgBox("Metres must be a number")
            Exit Sub
        End Try
        HoldInch = Metres * mtoinch
        Feet = HoldInch \ rate
        Inch = HoldInch Mod rate
        txtFeet.Text = Feet
        txtInches.Text = Inch
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtInches.TextChanged

    End Sub

    Private Sub Metres_to_Feet_and_Inches_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class