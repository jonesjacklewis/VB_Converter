<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Metres_to_Feet_and_Inches
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtMetres = New System.Windows.Forms.TextBox()
        Me.txtFeet = New System.Windows.Forms.TextBox()
        Me.txtInches = New System.Windows.Forms.TextBox()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.LblFeet = New System.Windows.Forms.Label()
        Me.LblInch = New System.Windows.Forms.Label()
        Me.LblMetres = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtMetres
        '
        Me.txtMetres.Location = New System.Drawing.Point(329, 45)
        Me.txtMetres.Name = "txtMetres"
        Me.txtMetres.Size = New System.Drawing.Size(100, 22)
        Me.txtMetres.TabIndex = 0
        '
        'txtFeet
        '
        Me.txtFeet.Location = New System.Drawing.Point(210, 202)
        Me.txtFeet.Name = "txtFeet"
        Me.txtFeet.Size = New System.Drawing.Size(100, 22)
        Me.txtFeet.TabIndex = 0
        '
        'txtInches
        '
        Me.txtInches.Location = New System.Drawing.Point(459, 202)
        Me.txtInches.Name = "txtInches"
        Me.txtInches.Size = New System.Drawing.Size(100, 22)
        Me.txtInches.TabIndex = 0
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(329, 141)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(100, 23)
        Me.BtnConvert.TabIndex = 1
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'LblFeet
        '
        Me.LblFeet.AutoSize = True
        Me.LblFeet.Location = New System.Drawing.Point(131, 202)
        Me.LblFeet.Name = "LblFeet"
        Me.LblFeet.Size = New System.Drawing.Size(36, 17)
        Me.LblFeet.TabIndex = 2
        Me.LblFeet.Text = "Feet"
        '
        'LblInch
        '
        Me.LblInch.AutoSize = True
        Me.LblInch.Location = New System.Drawing.Point(392, 205)
        Me.LblInch.Name = "LblInch"
        Me.LblInch.Size = New System.Drawing.Size(49, 17)
        Me.LblInch.TabIndex = 2
        Me.LblInch.Text = "Inches"
        '
        'LblMetres
        '
        Me.LblMetres.AutoSize = True
        Me.LblMetres.Location = New System.Drawing.Point(230, 45)
        Me.LblMetres.Name = "LblMetres"
        Me.LblMetres.Size = New System.Drawing.Size(51, 17)
        Me.LblMetres.TabIndex = 2
        Me.LblMetres.Text = "Metres"
        '
        'Metres_to_Feet_and_Inches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblInch)
        Me.Controls.Add(Me.LblMetres)
        Me.Controls.Add(Me.LblFeet)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.txtInches)
        Me.Controls.Add(Me.txtFeet)
        Me.Controls.Add(Me.txtMetres)
        Me.Name = "Metres_to_Feet_and_Inches"
        Me.Text = "Metres to Feet and Inches"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMetres As TextBox
    Friend WithEvents txtFeet As TextBox
    Friend WithEvents txtInches As TextBox
    Friend WithEvents BtnConvert As Button
    Friend WithEvents LblFeet As Label
    Friend WithEvents LblInch As Label
    Friend WithEvents LblMetres As Label
End Class
