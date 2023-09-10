<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TemperatureConverter
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
        Me.Quitbutton = New System.Windows.Forms.Button()
        Me.FahrenheitButton = New System.Windows.Forms.RadioButton()
        Me.CelsiusButton = New System.Windows.Forms.RadioButton()
        Me.InputLabel = New System.Windows.Forms.Label()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.ControlsGroupBox = New System.Windows.Forms.GroupBox()
        Me.InputGroupBox.SuspendLayout()
        Me.ControlsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Quitbutton
        '
        Me.Quitbutton.Location = New System.Drawing.Point(6, 100)
        Me.Quitbutton.Name = "Quitbutton"
        Me.Quitbutton.Size = New System.Drawing.Size(134, 66)
        Me.Quitbutton.TabIndex = 0
        Me.Quitbutton.Text = "Quit"
        Me.Quitbutton.UseVisualStyleBackColor = True
        '
        'FahrenheitButton
        '
        Me.FahrenheitButton.AutoSize = True
        Me.FahrenheitButton.Location = New System.Drawing.Point(6, 39)
        Me.FahrenheitButton.Name = "FahrenheitButton"
        Me.FahrenheitButton.Size = New System.Drawing.Size(98, 24)
        Me.FahrenheitButton.TabIndex = 1
        Me.FahrenheitButton.TabStop = True
        Me.FahrenheitButton.Text = "Fahrenheit"
        Me.FahrenheitButton.UseVisualStyleBackColor = True
        '
        'CelsiusButton
        '
        Me.CelsiusButton.AutoSize = True
        Me.CelsiusButton.Location = New System.Drawing.Point(6, 70)
        Me.CelsiusButton.Name = "CelsiusButton"
        Me.CelsiusButton.Size = New System.Drawing.Size(75, 24)
        Me.CelsiusButton.TabIndex = 2
        Me.CelsiusButton.TabStop = True
        Me.CelsiusButton.Text = "Celsius"
        Me.CelsiusButton.UseVisualStyleBackColor = True
        '
        'InputLabel
        '
        Me.InputLabel.AutoSize = True
        Me.InputLabel.Location = New System.Drawing.Point(6, 39)
        Me.InputLabel.Name = "InputLabel"
        Me.InputLabel.Size = New System.Drawing.Size(131, 20)
        Me.InputLabel.TabIndex = 3
        Me.InputLabel.Text = "Input Temperature"
        '
        'OutputLabel
        '
        Me.OutputLabel.AutoSize = True
        Me.OutputLabel.Location = New System.Drawing.Point(6, 97)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(76, 20)
        Me.OutputLabel.TabIndex = 4
        Me.OutputLabel.Text = "Output (?)"
        '
        'InputTextBox
        '
        Me.InputTextBox.Location = New System.Drawing.Point(6, 62)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(242, 27)
        Me.InputTextBox.TabIndex = 5
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Location = New System.Drawing.Point(6, 120)
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ReadOnly = True
        Me.OutputTextBox.Size = New System.Drawing.Size(242, 27)
        Me.OutputTextBox.TabIndex = 6
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.InputTextBox)
        Me.InputGroupBox.Controls.Add(Me.InputLabel)
        Me.InputGroupBox.Controls.Add(Me.OutputTextBox)
        Me.InputGroupBox.Controls.Add(Me.OutputLabel)
        Me.InputGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(381, 177)
        Me.InputGroupBox.TabIndex = 7
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Inputs/Outputs"
        '
        'ControlsGroupBox
        '
        Me.ControlsGroupBox.Controls.Add(Me.CelsiusButton)
        Me.ControlsGroupBox.Controls.Add(Me.FahrenheitButton)
        Me.ControlsGroupBox.Controls.Add(Me.Quitbutton)
        Me.ControlsGroupBox.Location = New System.Drawing.Point(427, 12)
        Me.ControlsGroupBox.Name = "ControlsGroupBox"
        Me.ControlsGroupBox.Size = New System.Drawing.Size(147, 177)
        Me.ControlsGroupBox.TabIndex = 0
        Me.ControlsGroupBox.TabStop = False
        Me.ControlsGroupBox.Text = "Convert To:"
        '
        'TemperatureConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 203)
        Me.Controls.Add(Me.ControlsGroupBox)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Name = "TemperatureConverter"
        Me.Text = "TemperatureConverterForm"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.ControlsGroupBox.ResumeLayout(False)
        Me.ControlsGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Quitbutton As Button
    Friend WithEvents FahrenheitButton As RadioButton
    Friend WithEvents CelsiusButton As RadioButton
    Friend WithEvents InputLabel As Label
    Friend WithEvents OutputLabel As Label
    Friend WithEvents InputTextBox As TextBox
    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents ControlsGroupBox As GroupBox
End Class
