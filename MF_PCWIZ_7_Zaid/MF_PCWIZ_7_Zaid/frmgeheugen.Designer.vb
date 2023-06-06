<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmgeheugen
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
        Me.lbltotaal = New System.Windows.Forms.Label()
        Me.btnverder = New System.Windows.Forms.Button()
        Me.btnterug = New System.Windows.Forms.Button()
        Me.btnkiezen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpcssd = New System.Windows.Forms.TextBox()
        Me.lstssd = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lbltotaal
        '
        Me.lbltotaal.AutoSize = True
        Me.lbltotaal.Location = New System.Drawing.Point(344, 279)
        Me.lbltotaal.Name = "lbltotaal"
        Me.lbltotaal.Size = New System.Drawing.Size(33, 13)
        Me.lbltotaal.TabIndex = 20
        Me.lbltotaal.Text = "totaal"
        '
        'btnverder
        '
        Me.btnverder.Location = New System.Drawing.Point(636, 63)
        Me.btnverder.Name = "btnverder"
        Me.btnverder.Size = New System.Drawing.Size(125, 43)
        Me.btnverder.TabIndex = 19
        Me.btnverder.Text = "Ga verder"
        Me.btnverder.UseVisualStyleBackColor = True
        '
        'btnterug
        '
        Me.btnterug.Location = New System.Drawing.Point(636, 190)
        Me.btnterug.Name = "btnterug"
        Me.btnterug.Size = New System.Drawing.Size(125, 44)
        Me.btnterug.TabIndex = 18
        Me.btnterug.Text = "Ga terug"
        Me.btnterug.UseVisualStyleBackColor = True
        '
        'btnkiezen
        '
        Me.btnkiezen.Location = New System.Drawing.Point(39, 279)
        Me.btnkiezen.Name = "btnkiezen"
        Me.btnkiezen.Size = New System.Drawing.Size(187, 49)
        Me.btnkiezen.TabIndex = 17
        Me.btnkiezen.Text = "Kiezen"
        Me.btnkiezen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(360, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Overzichtconfiguratie"
        '
        'txtpcssd
        '
        Me.txtpcssd.Location = New System.Drawing.Point(334, 40)
        Me.txtpcssd.Multiline = True
        Me.txtpcssd.Name = "txtpcssd"
        Me.txtpcssd.Size = New System.Drawing.Size(274, 194)
        Me.txtpcssd.TabIndex = 15
        '
        'lstssd
        '
        Me.lstssd.FormattingEnabled = True
        Me.lstssd.Location = New System.Drawing.Point(12, 40)
        Me.lstssd.Name = "lstssd"
        Me.lstssd.Size = New System.Drawing.Size(247, 212)
        Me.lstssd.TabIndex = 14
        '
        'frmgeheugen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbltotaal)
        Me.Controls.Add(Me.btnverder)
        Me.Controls.Add(Me.btnterug)
        Me.Controls.Add(Me.btnkiezen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpcssd)
        Me.Controls.Add(Me.lstssd)
        Me.Name = "frmgeheugen"
        Me.Text = "frmgeheugen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltotaal As Label
    Friend WithEvents btnverder As Button
    Friend WithEvents btnterug As Button
    Friend WithEvents btnkiezen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpcssd As TextBox
    Friend WithEvents lstssd As ListBox
End Class
