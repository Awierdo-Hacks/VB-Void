<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class overzicht
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
        Me.btnstart = New System.Windows.Forms.Button()
        Me.lbltotaalprijs = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnstart
        '
        Me.btnstart.Location = New System.Drawing.Point(89, 53)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(137, 47)
        Me.btnstart.TabIndex = 0
        Me.btnstart.Text = "Start nieuwe configuratie"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'lbltotaalprijs
        '
        Me.lbltotaalprijs.AutoSize = True
        Me.lbltotaalprijs.Location = New System.Drawing.Point(144, 34)
        Me.lbltotaalprijs.Name = "lbltotaalprijs"
        Me.lbltotaalprijs.Size = New System.Drawing.Size(39, 13)
        Me.lbltotaalprijs.TabIndex = 1
        Me.lbltotaalprijs.Text = "Label1"
        '
        'overzicht
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 147)
        Me.Controls.Add(Me.lbltotaalprijs)
        Me.Controls.Add(Me.btnstart)
        Me.Name = "overzicht"
        Me.Text = "overzicht"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnstart As Button
    Friend WithEvents lbltotaalprijs As Label
End Class
