<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class optiesbuiten
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
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.lbltotaalprijs = New System.Windows.Forms.Label()
        Me.radairco = New System.Windows.Forms.RadioButton()
        Me.radvoet = New System.Windows.Forms.RadioButton()
        Me.radtitanium = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(84, 230)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(132, 39)
        Me.btnback.TabIndex = 13
        Me.btnback.Text = "terug"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(222, 230)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(132, 39)
        Me.btnnext.TabIndex = 12
        Me.btnnext.Text = "Verder"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'lbltotaalprijs
        '
        Me.lbltotaalprijs.AutoSize = True
        Me.lbltotaalprijs.Location = New System.Drawing.Point(32, 243)
        Me.lbltotaalprijs.Name = "lbltotaalprijs"
        Me.lbltotaalprijs.Size = New System.Drawing.Size(39, 13)
        Me.lbltotaalprijs.TabIndex = 11
        Me.lbltotaalprijs.Text = "Label1"
        '
        'radairco
        '
        Me.radairco.AutoSize = True
        Me.radairco.Location = New System.Drawing.Point(84, 47)
        Me.radairco.Name = "radairco"
        Me.radairco.Size = New System.Drawing.Size(153, 17)
        Me.radairco.TabIndex = 0
        Me.radairco.TabStop = True
        Me.radairco.Text = "Traktiecontrole(1 500 euro)"
        Me.radairco.UseVisualStyleBackColor = True
        '
        'radvoet
        '
        Me.radvoet.AutoSize = True
        Me.radvoet.Location = New System.Drawing.Point(84, 118)
        Me.radvoet.Name = "radvoet"
        Me.radvoet.Size = New System.Drawing.Size(182, 17)
        Me.radvoet.TabIndex = 2
        Me.radvoet.TabStop = True
        Me.radvoet.Text = "voetgangers detectie(3 500 euro)"
        Me.radvoet.UseVisualStyleBackColor = True
        '
        'radtitanium
        '
        Me.radtitanium.AutoSize = True
        Me.radtitanium.Location = New System.Drawing.Point(84, 83)
        Me.radtitanium.Name = "radtitanium"
        Me.radtitanium.Size = New System.Drawing.Size(118, 17)
        Me.radtitanium.TabIndex = 1
        Me.radtitanium.TabStop = True
        Me.radtitanium.Text = "titanium(2 500 euro)"
        Me.radtitanium.UseVisualStyleBackColor = True
        '
        'optiesbuiten
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.radvoet)
        Me.Controls.Add(Me.radtitanium)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.radairco)
        Me.Controls.Add(Me.lbltotaalprijs)
        Me.Name = "optiesbuiten"
        Me.Text = "optiesbuiten"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnback As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents lbltotaalprijs As Label
    Friend WithEvents radairco As RadioButton
    Friend WithEvents radvoet As RadioButton
    Friend WithEvents radtitanium As RadioButton
End Class
