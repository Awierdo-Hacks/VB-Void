<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class optiesbinnen
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
        Me.btnnext = New System.Windows.Forms.Button()
        Me.lbltotaalprijs = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radleder = New System.Windows.Forms.RadioButton()
        Me.radled = New System.Windows.Forms.RadioButton()
        Me.radairco = New System.Windows.Forms.RadioButton()
        Me.btnback = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(241, 263)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(132, 39)
        Me.btnnext.TabIndex = 8
        Me.btnnext.Text = "Verder"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'lbltotaalprijs
        '
        Me.lbltotaalprijs.AutoSize = True
        Me.lbltotaalprijs.Location = New System.Drawing.Point(51, 276)
        Me.lbltotaalprijs.Name = "lbltotaalprijs"
        Me.lbltotaalprijs.Size = New System.Drawing.Size(39, 13)
        Me.lbltotaalprijs.TabIndex = 7
        Me.lbltotaalprijs.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radleder)
        Me.GroupBox1.Controls.Add(Me.radled)
        Me.GroupBox1.Controls.Add(Me.radairco)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 199)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'radleder
        '
        Me.radleder.AutoSize = True
        Me.radleder.Location = New System.Drawing.Point(46, 83)
        Me.radleder.Name = "radleder"
        Me.radleder.Size = New System.Drawing.Size(106, 17)
        Me.radleder.TabIndex = 1
        Me.radleder.TabStop = True
        Me.radleder.Text = "Leder(3000 euro)"
        Me.radleder.UseVisualStyleBackColor = True
        '
        'radled
        '
        Me.radled.AutoSize = True
        Me.radled.Location = New System.Drawing.Point(46, 129)
        Me.radled.Name = "radled"
        Me.radled.Size = New System.Drawing.Size(171, 17)
        Me.radled.TabIndex = 2
        Me.radled.TabStop = True
        Me.radled.Text = "Led sfeerverlichting(4000 euro)"
        Me.radled.UseVisualStyleBackColor = True
        '
        'radairco
        '
        Me.radairco.AutoSize = True
        Me.radairco.Location = New System.Drawing.Point(46, 35)
        Me.radairco.Name = "radairco"
        Me.radairco.Size = New System.Drawing.Size(103, 17)
        Me.radairco.TabIndex = 0
        Me.radairco.TabStop = True
        Me.radairco.Text = "Airco(2000 euro)"
        Me.radairco.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(103, 263)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(132, 39)
        Me.btnback.TabIndex = 9
        Me.btnback.Text = "terug"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'optiesbinnen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.lbltotaalprijs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "optiesbinnen"
        Me.Text = "optiesbinnen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnnext As Button
    Friend WithEvents lbltotaalprijs As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radleder As RadioButton
    Friend WithEvents radled As RadioButton
    Friend WithEvents radairco As RadioButton
    Friend WithEvents btnback As Button
End Class
