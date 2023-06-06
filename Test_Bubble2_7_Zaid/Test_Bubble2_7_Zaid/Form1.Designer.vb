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
        txtgetallen = New TextBox()
        btnsorteer = New Button()
        lblaantaldoorgangen = New Label()
        btnSluiten = New Button()
        SuspendLayout()
        ' 
        ' txtgetallen
        ' 
        txtgetallen.Location = New Point(32, 12)
        txtgetallen.Multiline = True
        txtgetallen.Name = "txtgetallen"
        txtgetallen.ReadOnly = True
        txtgetallen.ScrollBars = ScrollBars.Vertical
        txtgetallen.Size = New Size(763, 627)
        txtgetallen.TabIndex = 0
        ' 
        ' btnsorteer
        ' 
        btnsorteer.Location = New Point(833, 56)
        btnsorteer.Name = "btnsorteer"
        btnsorteer.Size = New Size(135, 39)
        btnsorteer.TabIndex = 1
        btnsorteer.Text = "Sorteer"
        btnsorteer.UseVisualStyleBackColor = True
        ' 
        ' lblaantaldoorgangen
        ' 
        lblaantaldoorgangen.AutoSize = True
        lblaantaldoorgangen.Location = New Point(833, 133)
        lblaantaldoorgangen.Name = "lblaantaldoorgangen"
        lblaantaldoorgangen.Size = New Size(112, 15)
        lblaantaldoorgangen.TabIndex = 2
        lblaantaldoorgangen.Text = "Aantal doorgangen:"' 
        ' btnSluiten
        ' 
        btnSluiten.Location = New Point(833, 216)
        btnSluiten.Name = "btnSluiten"
        btnSluiten.Size = New Size(135, 39)
        btnSluiten.TabIndex = 3
        btnSluiten.Text = "Sluiten"
        btnSluiten.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1027, 667)
        Controls.Add(btnSluiten)
        Controls.Add(lblaantaldoorgangen)
        Controls.Add(btnsorteer)
        Controls.Add(txtgetallen)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtgetallen As TextBox
    Friend WithEvents btnsorteer As Button
    Friend WithEvents lblaantaldoorgangen As Label
    Friend WithEvents btnSluiten As Button
End Class
