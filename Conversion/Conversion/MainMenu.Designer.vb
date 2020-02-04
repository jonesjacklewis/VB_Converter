<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CandF = New System.Windows.Forms.Button()
        Me.KMandM = New System.Windows.Forms.Button()
        Me.MandF = New System.Windows.Forms.Button()
        Me.KGandLbs = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CandF
        '
        Me.CandF.Location = New System.Drawing.Point(108, 52)
        Me.CandF.Name = "CandF"
        Me.CandF.Size = New System.Drawing.Size(123, 70)
        Me.CandF.TabIndex = 0
        Me.CandF.Text = "Celsius and Farenheight"
        Me.CandF.UseVisualStyleBackColor = True
        '
        'KMandM
        '
        Me.KMandM.Location = New System.Drawing.Point(510, 52)
        Me.KMandM.Name = "KMandM"
        Me.KMandM.Size = New System.Drawing.Size(123, 70)
        Me.KMandM.TabIndex = 0
        Me.KMandM.Text = "Kilometres to Miles"
        Me.KMandM.UseVisualStyleBackColor = True
        '
        'MandF
        '
        Me.MandF.Location = New System.Drawing.Point(510, 226)
        Me.MandF.Name = "MandF"
        Me.MandF.Size = New System.Drawing.Size(123, 70)
        Me.MandF.TabIndex = 0
        Me.MandF.Text = "Metres to Feet and Inches"
        Me.MandF.UseVisualStyleBackColor = True
        '
        'KGandLbs
        '
        Me.KGandLbs.Location = New System.Drawing.Point(108, 226)
        Me.KGandLbs.Name = "KGandLbs"
        Me.KGandLbs.Size = New System.Drawing.Size(123, 70)
        Me.KGandLbs.TabIndex = 0
        Me.KGandLbs.Text = "Kg to Lbs"
        Me.KGandLbs.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.KGandLbs)
        Me.Controls.Add(Me.KMandM)
        Me.Controls.Add(Me.MandF)
        Me.Controls.Add(Me.CandF)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CandF As Button
    Friend WithEvents KMandM As Button
    Friend WithEvents MandF As Button
    Friend WithEvents KGandLbs As Button
End Class
