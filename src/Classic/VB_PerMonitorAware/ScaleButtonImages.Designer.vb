<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScaleButtonImages
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
        Me.currentDPILabel = New PerMonitorAwareVB472.CurrentDPILabel()
        Me.errorButton = New PerMonitorAwareVB472.ImageButton()
        Me.propertiesButton = New PerMonitorAwareVB472.ImageButton()
        Me.label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'currentDPILabel
        '
        Me.currentDPILabel.AutoSize = True
        Me.currentDPILabel.Location = New System.Drawing.Point(12, 198)
        Me.currentDPILabel.Name = "currentDPILabel"
        Me.currentDPILabel.Size = New System.Drawing.Size(118, 13)
        Me.currentDPILabel.TabIndex = 0
        Me.currentDPILabel.Text = "Current Scaling is 150%"
        '
        'errorButton
        '
        Me.errorButton.Location = New System.Drawing.Point(42, 94)
        Me.errorButton.Name = "errorButton"
        Me.errorButton.Size = New System.Drawing.Size(30, 30)
        Me.errorButton.TabIndex = 1
        Me.errorButton.UseVisualStyleBackColor = True
        '
        'propertiesButton
        '
        Me.propertiesButton.Location = New System.Drawing.Point(100, 94)
        Me.propertiesButton.Name = "propertiesButton"
        Me.propertiesButton.Size = New System.Drawing.Size(30, 30)
        Me.propertiesButton.TabIndex = 2
        Me.propertiesButton.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(13, 19)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(200, 25)
        Me.label2.TabIndex = 7
        Me.label2.Text = "Buttons that select bitmap based on the current DPI."
        '
        'ScaleButtonImages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 247)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.propertiesButton)
        Me.Controls.Add(Me.errorButton)
        Me.Controls.Add(Me.currentDPILabel)
        Me.Name = "ScaleButtonImages"
        Me.Text = "ScaleButtonImages"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents currentDPILabel As CurrentDPILabel
    Friend WithEvents errorButton As ImageButton
    Friend WithEvents propertiesButton As ImageButton
    Private WithEvents label2 As Label
End Class
