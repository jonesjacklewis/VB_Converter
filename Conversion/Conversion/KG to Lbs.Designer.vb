<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KG_to_Lbs
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
        Me.RADKGLbs = New System.Windows.Forms.RadioButton()
        Me.RADLbsKG = New System.Windows.Forms.RadioButton()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.LblInput = New System.Windows.Forms.Label()
        Me.LblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RADKGLbs
        '
        Me.RADKGLbs.AutoSize = True
        Me.RADKGLbs.Location = New System.Drawing.Point(220, 31)
        Me.RADKGLbs.Name = "RADKGLbs"
        Me.RADKGLbs.Size = New System.Drawing.Size(92, 21)
        Me.RADKGLbs.TabIndex = 0
        Me.RADKGLbs.TabStop = True
        Me.RADKGLbs.Text = "KG to Lbs"
        Me.RADKGLbs.UseVisualStyleBackColor = True
        '
        'RADLbsKG
        '
        Me.RADLbsKG.AutoSize = True
        Me.RADLbsKG.Location = New System.Drawing.Point(220, 58)
        Me.RADLbsKG.Name = "RADLbsKG"
        Me.RADLbsKG.Size = New System.Drawing.Size(92, 21)
        Me.RADLbsKG.TabIndex = 0
        Me.RADLbsKG.TabStop = True
        Me.RADLbsKG.Text = "Lbs to KG"
        Me.RADLbsKG.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(220, 118)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(115, 22)
        Me.txtInput.TabIndex = 1
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(220, 192)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(115, 23)
        Me.BtnConvert.TabIndex = 2
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(220, 263)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(115, 22)
        Me.txtOutput.TabIndex = 1
        '
        'LblInput
        '
        Me.LblInput.AutoSize = True
        Me.LblInput.Location = New System.Drawing.Point(53, 122)
        Me.LblInput.Name = "LblInput"
        Me.LblInput.Size = New System.Drawing.Size(39, 17)
        Me.LblInput.TabIndex = 3
        Me.LblInput.Text = "Input"
        '
        'LblOutput
        '
        Me.LblOutput.AutoSize = True
        Me.LblOutput.Location = New System.Drawing.Point(53, 268)
        Me.LblOutput.Name = "LblOutput"
        Me.LblOutput.Size = New System.Drawing.Size(51, 17)
        Me.LblOutput.TabIndex = 3
        Me.LblOutput.Text = "Output"
        '
        'KG_to_Lbs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblOutput)
        Me.Controls.Add(Me.LblInput)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.RADLbsKG)
        Me.Controls.Add(Me.RADKGLbs)
        Me.Name = "KG_to_Lbs"
        Me.Text = "KG to Lbs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RADKGLbs As RadioButton
    Friend WithEvents RADLbsKG As RadioButton
    Friend WithEvents txtInput As TextBox
    Friend WithEvents BtnConvert As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents LblInput As Label
    Friend WithEvents LblOutput As Label
End Class
