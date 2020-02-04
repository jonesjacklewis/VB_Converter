<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Celsius_and_Farenheight_Conversion
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
        Me.TxtCelsius = New System.Windows.Forms.TextBox()
        Me.TxtFahrenheit = New System.Windows.Forms.TextBox()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.LblCelsius = New System.Windows.Forms.Label()
        Me.LblFahrenheit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtCelsius
        '
        Me.TxtCelsius.Location = New System.Drawing.Point(351, 54)
        Me.TxtCelsius.Name = "TxtCelsius"
        Me.TxtCelsius.Size = New System.Drawing.Size(100, 22)
        Me.TxtCelsius.TabIndex = 0
        '
        'TxtFahrenheit
        '
        Me.TxtFahrenheit.Location = New System.Drawing.Point(351, 288)
        Me.TxtFahrenheit.Name = "TxtFahrenheit"
        Me.TxtFahrenheit.Size = New System.Drawing.Size(100, 22)
        Me.TxtFahrenheit.TabIndex = 0
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(351, 165)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(100, 23)
        Me.BtnConvert.TabIndex = 1
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'LblCelsius
        '
        Me.LblCelsius.AutoSize = True
        Me.LblCelsius.Location = New System.Drawing.Point(140, 58)
        Me.LblCelsius.Name = "LblCelsius"
        Me.LblCelsius.Size = New System.Drawing.Size(53, 17)
        Me.LblCelsius.TabIndex = 2
        Me.LblCelsius.Text = "Celsius"
        '
        'LblFahrenheit
        '
        Me.LblFahrenheit.AutoSize = True
        Me.LblFahrenheit.Location = New System.Drawing.Point(140, 293)
        Me.LblFahrenheit.Name = "LblFahrenheit"
        Me.LblFahrenheit.Size = New System.Drawing.Size(76, 17)
        Me.LblFahrenheit.TabIndex = 2
        Me.LblFahrenheit.Text = "Fahrenheit"
        '
        'Celsius_and_Farenheight_Conversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblFahrenheit)
        Me.Controls.Add(Me.LblCelsius)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.TxtFahrenheit)
        Me.Controls.Add(Me.TxtCelsius)
        Me.Name = "Celsius_and_Farenheight_Conversion"
        Me.Text = "Celsius and Fahrenheit Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCelsius As TextBox
    Friend WithEvents TxtFahrenheit As TextBox
    Friend WithEvents BtnConvert As Button
    Friend WithEvents LblCelsius As Label
    Friend WithEvents LblFahrenheit As Label
End Class
