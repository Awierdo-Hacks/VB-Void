<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Startscherm
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
        Me.btnleesprijslijst = New System.Windows.Forms.Button()
        Me.btnstartconfig = New System.Windows.Forms.Button()
        Me.lblklaarmetladen = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnleesprijslijst
        '
        Me.btnleesprijslijst.Location = New System.Drawing.Point(61, 29)
        Me.btnleesprijslijst.Name = "btnleesprijslijst"
        Me.btnleesprijslijst.Size = New System.Drawing.Size(145, 33)
        Me.btnleesprijslijst.TabIndex = 0
        Me.btnleesprijslijst.Text = "Lees prijslijst componenten"
        Me.btnleesprijslijst.UseVisualStyleBackColor = True
        '
        'btnstartconfig
        '
        Me.btnstartconfig.Location = New System.Drawing.Point(61, 85)
        Me.btnstartconfig.Name = "btnstartconfig"
        Me.btnstartconfig.Size = New System.Drawing.Size(145, 37)
        Me.btnstartconfig.TabIndex = 1
        Me.btnstartconfig.Text = "Startconfiguratie"
        Me.btnstartconfig.UseVisualStyleBackColor = True
        '
        'lblklaarmetladen
        '
        Me.lblklaarmetladen.AutoSize = True
        Me.lblklaarmetladen.Location = New System.Drawing.Point(400, 219)
        Me.lblklaarmetladen.Name = "lblklaarmetladen"
        Me.lblklaarmetladen.Size = New System.Drawing.Size(0, 13)
        Me.lblklaarmetladen.TabIndex = 8
        '
        'Startscherm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblklaarmetladen)
        Me.Controls.Add(Me.btnstartconfig)
        Me.Controls.Add(Me.btnleesprijslijst)
        Me.Name = "Startscherm"
        Me.Text = "Startscherm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnleesprijslijst As Button
    Friend WithEvents btnstartconfig As Button
    Friend WithEvents lblklaarmetladen As Label
End Class
