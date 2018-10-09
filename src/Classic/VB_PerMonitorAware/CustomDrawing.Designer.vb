<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomDrawing
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
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CurrentDPILabel = New System.Windows.Forms.Label()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(0, 25)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(428, 352)
        Me.pictureBox1.TabIndex = 1
        Me.pictureBox1.TabStop = False
        '
        'CurrentDPILabel
        '
        Me.CurrentDPILabel.AutoSize = True
        Me.CurrentDPILabel.Location = New System.Drawing.Point(12, 393)
        Me.CurrentDPILabel.Name = "CurrentDPILabel"
        Me.CurrentDPILabel.Size = New System.Drawing.Size(175, 20)
        Me.CurrentDPILabel.TabIndex = 21
        Me.CurrentDPILabel.Text = "Current scaling is 150%"
        '
        'CustomDrawing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 467)
        Me.Controls.Add(Me.CurrentDPILabel)
        Me.Controls.Add(Me.pictureBox1)
        Me.Name = "CustomDrawing"
        Me.Text = "CustomDrawing"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents CurrentDPILabel As Label
End Class
