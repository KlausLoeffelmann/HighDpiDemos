<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.customDrawing = New System.Windows.Forms.Button()
        Me.buttonImages = New System.Windows.Forms.Button()
        Me.showLayoutButton = New System.Windows.Forms.Button()
        Me.dpiAwarenessLabel = New System.Windows.Forms.Label()
        Me.formSizeLabel = New System.Windows.Forms.Label()
        Me.currentDPILabel = New CurrentDPILabel()
        Me.SuspendLayout()
        '
        'customDrawing
        '
        Me.customDrawing.Location = New System.Drawing.Point(66, 77)
        Me.customDrawing.Name = "customDrawing"
        Me.customDrawing.Size = New System.Drawing.Size(231, 22)
        Me.customDrawing.TabIndex = 19
        Me.customDrawing.Text = "Custom Drawing"
        Me.customDrawing.UseVisualStyleBackColor = True
        '
        'buttonImages
        '
        Me.buttonImages.Location = New System.Drawing.Point(66, 49)
        Me.buttonImages.Name = "buttonImages"
        Me.buttonImages.Size = New System.Drawing.Size(231, 22)
        Me.buttonImages.TabIndex = 16
        Me.buttonImages.Text = "Scale Button Images"
        Me.buttonImages.UseVisualStyleBackColor = True
        '
        'showLayoutButton
        '
        Me.showLayoutButton.Location = New System.Drawing.Point(66, 18)
        Me.showLayoutButton.Name = "showLayoutButton"
        Me.showLayoutButton.Size = New System.Drawing.Size(231, 22)
        Me.showLayoutButton.TabIndex = 15
        Me.showLayoutButton.Text = "Simple Layout"
        Me.showLayoutButton.UseVisualStyleBackColor = True
        '
        'dpiAwarenessLabel
        '
        Me.dpiAwarenessLabel.AutoSize = True
        Me.dpiAwarenessLabel.Location = New System.Drawing.Point(66, 213)
        Me.dpiAwarenessLabel.Name = "dpiAwarenessLabel"
        Me.dpiAwarenessLabel.Size = New System.Drawing.Size(83, 13)
        Me.dpiAwarenessLabel.TabIndex = 17
        Me.dpiAwarenessLabel.Text = "DPI Awareness:"
        '
        'formSizeLabel
        '
        Me.formSizeLabel.AutoSize = True
        Me.formSizeLabel.Location = New System.Drawing.Point(66, 192)
        Me.formSizeLabel.Name = "formSizeLabel"
        Me.formSizeLabel.Size = New System.Drawing.Size(56, 13)
        Me.formSizeLabel.TabIndex = 18
        Me.formSizeLabel.Text = "Form Size:"
        '
        'CurrentDPILabel
        '
        Me.currentDPILabel.AutoSize = True
        Me.currentDPILabel.Location = New System.Drawing.Point(66, 171)
        Me.currentDPILabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.currentDPILabel.Name = "CurrentDPILabel"
        Me.currentDPILabel.Size = New System.Drawing.Size(116, 13)
        Me.currentDPILabel.TabIndex = 20
        Me.currentDPILabel.Text = "Current scaling is 150%"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 244)
        Me.Controls.Add(Me.currentDPILabel)
        Me.Controls.Add(Me.customDrawing)
        Me.Controls.Add(Me.buttonImages)
        Me.Controls.Add(Me.showLayoutButton)
        Me.Controls.Add(Me.dpiAwarenessLabel)
        Me.Controls.Add(Me.formSizeLabel)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MainForm"
        Me.Text = "PerMonitor Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents customDrawing As Button
    Private WithEvents buttonImages As Button
    Private WithEvents showLayoutButton As Button
    Private WithEvents dpiAwarenessLabel As Label
    Private WithEvents formSizeLabel As Label
    Friend WithEvents currentDPILabel As CurrentDPILabel
End Class
