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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtaantalgetallen = New TextBox()
        txtverwijderen = New TextBox()
        txtvoor = New TextBox()
        txtna = New TextBox()
        btnGenereren = New Button()
        btnSluiten = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(68, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 0
        Label1.Text = "Aantal getallen:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(68, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 15)
        Label2.TabIndex = 1
        Label2.Text = "te verwijderen"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(68, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 2
        Label3.Text = "Voor"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(68, 253)
        Label4.Name = "Label4"
        Label4.Size = New Size(22, 15)
        Label4.TabIndex = 3
        Label4.Text = "Na"' 
        ' txtaantalgetallen
        ' 
        txtaantalgetallen.Location = New Point(133, 73)
        txtaantalgetallen.Multiline = True
        txtaantalgetallen.Name = "txtaantalgetallen"
        txtaantalgetallen.Size = New Size(100, 23)
        txtaantalgetallen.TabIndex = 4
        ' 
        ' txtverwijderen
        ' 
        txtverwijderen.Location = New Point(133, 132)
        txtverwijderen.Multiline = True
        txtverwijderen.Name = "txtverwijderen"
        txtverwijderen.Size = New Size(100, 23)
        txtverwijderen.TabIndex = 5
        ' 
        ' txtvoor
        ' 
        txtvoor.Location = New Point(133, 206)
        txtvoor.Multiline = True
        txtvoor.Name = "txtvoor"
        txtvoor.Size = New Size(100, 23)
        txtvoor.TabIndex = 6
        ' 
        ' txtna
        ' 
        txtna.Location = New Point(133, 284)
        txtna.Multiline = True
        txtna.Name = "txtna"
        txtna.Size = New Size(100, 23)
        txtna.TabIndex = 7
        ' 
        ' btnGenereren
        ' 
        btnGenereren.Location = New Point(68, 334)
        btnGenereren.Name = "btnGenereren"
        btnGenereren.Size = New Size(75, 23)
        btnGenereren.TabIndex = 8
        btnGenereren.Text = "Genereren"
        btnGenereren.UseVisualStyleBackColor = True
        ' 
        ' btnSluiten
        ' 
        btnSluiten.Location = New Point(233, 334)
        btnSluiten.Name = "btnSluiten"
        btnSluiten.Size = New Size(75, 23)
        btnSluiten.TabIndex = 9
        btnSluiten.Text = "Sluiten"
        btnSluiten.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSluiten)
        Controls.Add(btnGenereren)
        Controls.Add(txtna)
        Controls.Add(txtvoor)
        Controls.Add(txtverwijderen)
        Controls.Add(txtaantalgetallen)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtaantalgetallen As TextBox
    Friend WithEvents txtverwijderen As TextBox
    Friend WithEvents txtvoor As TextBox
    Friend WithEvents txtna As TextBox
    Friend WithEvents btnGenereren As Button
    Friend WithEvents btnSluiten As Button
End Class
