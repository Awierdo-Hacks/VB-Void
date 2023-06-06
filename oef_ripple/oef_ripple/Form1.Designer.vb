<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtnamen = New TextBox()
        txtdoorgangen = New TextBox()
        btnsorteren = New Button()
        btnSluiten = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtnamen
        ' 
        txtnamen.Location = New Point(91, 26)
        txtnamen.Multiline = True
        txtnamen.Name = "txtnamen"
        txtnamen.Size = New Size(234, 223)
        txtnamen.TabIndex = 0
        ' 
        ' txtdoorgangen
        ' 
        txtdoorgangen.Location = New Point(225, 312)
        txtdoorgangen.Multiline = True
        txtdoorgangen.Name = "txtdoorgangen"
        txtdoorgangen.Size = New Size(100, 23)
        txtdoorgangen.TabIndex = 1
        ' 
        ' btnsorteren
        ' 
        btnsorteren.Location = New Point(91, 358)
        btnsorteren.Name = "btnsorteren"
        btnsorteren.Size = New Size(97, 37)
        btnsorteren.TabIndex = 2
        btnsorteren.Text = "Sorteren"
        btnsorteren.UseVisualStyleBackColor = True
        ' 
        ' btnSluiten
        ' 
        btnSluiten.Location = New Point(225, 358)
        btnSluiten.Name = "btnSluiten"
        btnSluiten.Size = New Size(100, 37)
        btnSluiten.TabIndex = 3
        btnSluiten.Text = "Sluiten"
        btnSluiten.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(91, 315)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 15)
        Label1.TabIndex = 4
        Label1.Text = "Aantal Doorgangen"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(btnSluiten)
        Controls.Add(btnsorteren)
        Controls.Add(txtdoorgangen)
        Controls.Add(txtnamen)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtnamen As TextBox
    Friend WithEvents txtdoorgangen As TextBox
    Friend WithEvents btnsorteren As Button
    Friend WithEvents btnSluiten As Button
    Friend WithEvents Label1 As Label
End Class
