<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcpu
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
        Me.lstcpu = New System.Windows.Forms.ListBox()
        Me.txtpccpu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnkiezen = New System.Windows.Forms.Button()
        Me.btnterug = New System.Windows.Forms.Button()
        Me.btnverder = New System.Windows.Forms.Button()
        Me.lbltotaal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstcpu
        '
        Me.lstcpu.FormattingEnabled = True
        Me.lstcpu.Location = New System.Drawing.Point(39, 59)
        Me.lstcpu.Name = "lstcpu"
        Me.lstcpu.Size = New System.Drawing.Size(247, 212)
        Me.lstcpu.TabIndex = 0
        '
        'txtpccpu
        '
        Me.txtpccpu.Location = New System.Drawing.Point(361, 59)
        Me.txtpccpu.Multiline = True
        Me.txtpccpu.Name = "txtpccpu"
        Me.txtpccpu.Size = New System.Drawing.Size(274, 194)
        Me.txtpccpu.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(387, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Overzichtconfiguratie"
        '
        'btnkiezen
        '
        Me.btnkiezen.Location = New System.Drawing.Point(66, 298)
        Me.btnkiezen.Name = "btnkiezen"
        Me.btnkiezen.Size = New System.Drawing.Size(187, 49)
        Me.btnkiezen.TabIndex = 3
        Me.btnkiezen.Text = "Kiezen"
        Me.btnkiezen.UseVisualStyleBackColor = True
        '
        'btnterug
        '
        Me.btnterug.Location = New System.Drawing.Point(663, 209)
        Me.btnterug.Name = "btnterug"
        Me.btnterug.Size = New System.Drawing.Size(125, 44)
        Me.btnterug.TabIndex = 4
        Me.btnterug.Text = "Ga terug"
        Me.btnterug.UseVisualStyleBackColor = True
        '
        'btnverder
        '
        Me.btnverder.Location = New System.Drawing.Point(663, 82)
        Me.btnverder.Name = "btnverder"
        Me.btnverder.Size = New System.Drawing.Size(125, 43)
        Me.btnverder.TabIndex = 5
        Me.btnverder.Text = "Ga verder"
        Me.btnverder.UseVisualStyleBackColor = True
        '
        'lbltotaal
        '
        Me.lbltotaal.AutoSize = True
        Me.lbltotaal.Location = New System.Drawing.Point(371, 298)
        Me.lbltotaal.Name = "lbltotaal"
        Me.lbltotaal.Size = New System.Drawing.Size(33, 13)
        Me.lbltotaal.TabIndex = 6
        Me.lbltotaal.Text = "totaal"
        '
        'frmcpu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbltotaal)
        Me.Controls.Add(Me.btnverder)
        Me.Controls.Add(Me.btnterug)
        Me.Controls.Add(Me.btnkiezen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpccpu)
        Me.Controls.Add(Me.lstcpu)
        Me.Name = "frmcpu"
        Me.Text = "Stap 1 cpu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstcpu As ListBox
    Friend WithEvents txtpccpu As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnkiezen As Button
    Friend WithEvents btnterug As Button
    Friend WithEvents btnverder As Button
    Friend WithEvents lbltotaal As Label
End Class
