<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Km_To_Miles
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
        Me.CmbWay = New System.Windows.Forms.ComboBox()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.LblDirection = New System.Windows.Forms.Label()
        Me.LblOut = New System.Windows.Forms.Label()
        Me.LblInput = New System.Windows.Forms.Label()
        Me.TxtInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CmbWay
        '
        Me.CmbWay.FormattingEnabled = True
        Me.CmbWay.Items.AddRange(New Object() {"", "Kilometres to Miles", "Miles to Kilometres"})
        Me.CmbWay.Location = New System.Drawing.Point(302, 53)
        Me.CmbWay.Name = "CmbWay"
        Me.CmbWay.Size = New System.Drawing.Size(121, 24)
        Me.CmbWay.TabIndex = 0
        '
        'txtOut
        '
        Me.txtOut.Location = New System.Drawing.Point(302, 235)
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(121, 22)
        Me.txtOut.TabIndex = 1
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(302, 160)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(121, 23)
        Me.BtnConvert.TabIndex = 2
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'LblDirection
        '
        Me.LblDirection.AutoSize = True
        Me.LblDirection.Location = New System.Drawing.Point(102, 56)
        Me.LblDirection.Name = "LblDirection"
        Me.LblDirection.Size = New System.Drawing.Size(64, 17)
        Me.LblDirection.TabIndex = 3
        Me.LblDirection.Text = "Direction"
        '
        'LblOut
        '
        Me.LblOut.AutoSize = True
        Me.LblOut.Location = New System.Drawing.Point(102, 240)
        Me.LblOut.Name = "LblOut"
        Me.LblOut.Size = New System.Drawing.Size(51, 17)
        Me.LblOut.TabIndex = 3
        Me.LblOut.Text = "Output"
        '
        'LblInput
        '
        Me.LblInput.AutoSize = True
        Me.LblInput.Location = New System.Drawing.Point(102, 104)
        Me.LblInput.Name = "LblInput"
        Me.LblInput.Size = New System.Drawing.Size(39, 17)
        Me.LblInput.TabIndex = 3
        Me.LblInput.Text = "Input"
        '
        'TxtInput
        '
        Me.TxtInput.Location = New System.Drawing.Point(301, 107)
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.Size = New System.Drawing.Size(121, 22)
        Me.TxtInput.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, -71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label1"
        '
        'Km_To_Miles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblOut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblInput)
        Me.Controls.Add(Me.LblDirection)
        Me.Controls.Add(Me.TxtInput)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.CmbWay)
        Me.Name = "Km_To_Miles"
        Me.Text = "KM to Miles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbWay As ComboBox
    Friend WithEvents txtOut As TextBox
    Friend WithEvents BtnConvert As Button
    Friend WithEvents LblDirection As Label
    Friend WithEvents LblOut As Label
    Friend WithEvents LblInput As Label
    Friend WithEvents TxtInput As TextBox
    Friend WithEvents Label2 As Label
End Class
