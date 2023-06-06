<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Basismodel
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
        Me.radreeks3 = New System.Windows.Forms.RadioButton()
        Me.radreeks5 = New System.Windows.Forms.RadioButton()
        Me.radreeks7 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbltotaalprijs = New System.Windows.Forms.Label()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'radreeks3
        '
        Me.radreeks3.AutoSize = True
        Me.radreeks3.Location = New System.Drawing.Point(46, 35)
        Me.radreeks3.Name = "radreeks3"
        Me.radreeks3.Size = New System.Drawing.Size(123, 17)
        Me.radreeks3.TabIndex = 0
        Me.radreeks3.TabStop = True
        Me.radreeks3.Text = "3 reeks(30 000 euro)"
        Me.radreeks3.UseVisualStyleBackColor = True
        '
        'radreeks5
        '
        Me.radreeks5.AutoSize = True
        Me.radreeks5.Location = New System.Drawing.Point(46, 83)
        Me.radreeks5.Name = "radreeks5"
        Me.radreeks5.Size = New System.Drawing.Size(123, 17)
        Me.radreeks5.TabIndex = 1
        Me.radreeks5.TabStop = True
        Me.radreeks5.Text = "5 reeks(50 000 euro)"
        Me.radreeks5.UseVisualStyleBackColor = True
        '
        'radreeks7
        '
        Me.radreeks7.AutoSize = True
        Me.radreeks7.Location = New System.Drawing.Point(46, 129)
        Me.radreeks7.Name = "radreeks7"
        Me.radreeks7.Size = New System.Drawing.Size(123, 17)
        Me.radreeks7.TabIndex = 2
        Me.radreeks7.TabStop = True
        Me.radreeks7.Text = "7 reeks(70 000 euro)"
        Me.radreeks7.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radreeks5)
        Me.GroupBox1.Controls.Add(Me.radreeks7)
        Me.GroupBox1.Controls.Add(Me.radreeks3)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 198)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'lbltotaalprijs
        '
        Me.lbltotaalprijs.AutoSize = True
        Me.lbltotaalprijs.Location = New System.Drawing.Point(100, 268)
        Me.lbltotaalprijs.Name = "lbltotaalprijs"
        Me.lbltotaalprijs.Size = New System.Drawing.Size(39, 13)
        Me.lbltotaalprijs.TabIndex = 4
        Me.lbltotaalprijs.Text = "Label1"
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(193, 258)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(132, 39)
        Me.btnnext.TabIndex = 5
        Me.btnnext.Text = "Verder"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'Basismodel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 309)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.lbltotaalprijs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Basismodel"
        Me.Text = "Basismodel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radreeks3 As RadioButton
    Friend WithEvents radreeks5 As RadioButton
    Friend WithEvents radreeks7 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbltotaalprijs As Label
    Friend WithEvents btnnext As Button
End Class
