<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.button4 = New System.Windows.Forms.Button
        Me.button3 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.listBox1 = New System.Windows.Forms.ListBox
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(419, 372)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(120, 23)
        Me.button4.TabIndex = 11
        Me.button4.Text = "Renk Temizle"
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(419, 311)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(120, 23)
        Me.button3.TabIndex = 10
        Me.button3.Text = "Yerleþtir"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(419, 342)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(120, 23)
        Me.button2.TabIndex = 9
        Me.button2.Text = "Bul"
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.Items.AddRange(New Object() {"HULYA", "PINAR", "CEREN", "SIBEL", "OZAN", "DENIZ", "TUGCE", "KORHAN"})
        Me.listBox1.Location = New System.Drawing.Point(419, 39)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(120, 212)
        Me.listBox1.TabIndex = 8
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(419, 256)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(120, 20)
        Me.textBox1.TabIndex = 7
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(419, 282)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(120, 23)
        Me.button1.TabIndex = 6
        Me.button1.Text = "Ekle"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 466)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents button4 As System.Windows.Forms.Button
    Friend WithEvents button3 As System.Windows.Forms.Button
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents listBox1 As System.Windows.Forms.ListBox
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents button1 As System.Windows.Forms.Button

End Class
