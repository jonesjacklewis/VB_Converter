Public Class MainMenu
    Private Sub CandF_Click(sender As Object, e As EventArgs) Handles CandF.Click
        Celsius_and_Farenheight_Conversion.Show()
    End Sub

    Private Sub KMandM_Click(sender As Object, e As EventArgs) Handles KMandM.Click
        Km_To_Miles.Show()
    End Sub

    Private Sub KGandLbs_Click(sender As Object, e As EventArgs) Handles KGandLbs.Click
        KG_to_Lbs.Show()
    End Sub

    Private Sub MandF_Click(sender As Object, e As EventArgs) Handles MandF.Click
        Metres_to_Feet_and_Inches.Show()
    End Sub
End Class
