<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleLayout
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
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.CurrentDPILabel1 = New PerMonitorAwareVB472.CurrentDPILabel()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Location = New System.Drawing.Point(181, 135)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.ShowToolTips = True
        Me.tabControl1.Size = New System.Drawing.Size(200, 97)
        Me.tabControl1.TabIndex = 20
        '
        'tabPage1
        '
        Me.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabPage1.Controls.Add(Me.comboBox1)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabPage1.Size = New System.Drawing.Size(192, 71)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "tabPage1"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(19, 25)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(121, 21)
        Me.comboBox1.TabIndex = 0
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.checkBox2)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabPage2.Size = New System.Drawing.Size(192, 71)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "tabPage2"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'checkBox2
        '
        Me.checkBox2.Location = New System.Drawing.Point(7, 18)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(86, 18)
        Me.checkBox2.TabIndex = 0
        Me.checkBox2.Text = "checkBox2"
        Me.checkBox2.UseVisualStyleBackColor = True
        '
        'checkBox1
        '
        Me.checkBox1.Location = New System.Drawing.Point(11, 221)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(164, 25)
        Me.checkBox1.TabIndex = 19
        Me.checkBox1.Text = "checkBox1"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(143, 92)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(195, 20)
        Me.textBox2.TabIndex = 18
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(8, 98)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(49, 13)
        Me.label4.TabIndex = 17
        Me.label4.Text = "TextBox:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(8, 6)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(47, 13)
        Me.label1.TabIndex = 16
        Me.label1.Text = "ListBox: "
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.Items.AddRange(New Object() {"United States Of America", "Canada", "New Zealand", "Australia", "Great Britain"})
        Me.listBox1.Location = New System.Drawing.Point(143, 6)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(195, 69)
        Me.listBox1.TabIndex = 15
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Location = New System.Drawing.Point(143, 252)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.numericUpDown1.TabIndex = 22
        '
        'richTextBox1
        '
        Me.richTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richTextBox1.Location = New System.Drawing.Point(9, 252)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(100, 59)
        Me.richTextBox1.TabIndex = 21
        Me.richTextBox1.Text = "RichTextBox"
        '
        'radioButton1
        '
        Me.radioButton1.Checked = True
        Me.radioButton1.Location = New System.Drawing.Point(6, 26)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(147, 17)
        Me.radioButton1.TabIndex = 0
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "radioButton1"
        Me.radioButton1.UseVisualStyleBackColor = True
        '
        'radioButton2
        '
        Me.radioButton2.Location = New System.Drawing.Point(6, 49)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(147, 25)
        Me.radioButton2.TabIndex = 1
        Me.radioButton2.Text = "radioButton2"
        Me.radioButton2.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.radioButton1)
        Me.groupBox1.Controls.Add(Me.radioButton2)
        Me.groupBox1.Location = New System.Drawing.Point(9, 124)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(166, 91)
        Me.groupBox1.TabIndex = 23
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "groupBox1"
        '
        'CurrentDPILabel1
        '
        Me.CurrentDPILabel1.AutoSize = True
        Me.CurrentDPILabel1.Location = New System.Drawing.Point(10, 332)
        Me.CurrentDPILabel1.Name = "CurrentDPILabel1"
        Me.CurrentDPILabel1.Size = New System.Drawing.Size(91, 13)
        Me.CurrentDPILabel1.TabIndex = 24
        Me.CurrentDPILabel1.Text = "CurrentDPILabel1"
        '
        'SimpleLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 354)
        Me.Controls.Add(Me.CurrentDPILabel1)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.checkBox1)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.numericUpDown1)
        Me.Controls.Add(Me.richTextBox1)
        Me.Controls.Add(Me.groupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "SimpleLayout"
        Me.Text = "SimpleLayout"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage2.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents tabControl1 As TabControl
    Private WithEvents tabPage1 As TabPage
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents tabPage2 As TabPage
    Private WithEvents checkBox2 As CheckBox
    Private WithEvents checkBox1 As CheckBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label1 As Label
    Private WithEvents listBox1 As ListBox
    Private WithEvents numericUpDown1 As NumericUpDown
    Private WithEvents richTextBox1 As RichTextBox
    Private WithEvents radioButton1 As RadioButton
    Private WithEvents radioButton2 As RadioButton
    Private WithEvents groupBox1 As GroupBox
    Friend WithEvents CurrentDPILabel1 As CurrentDPILabel
End Class
