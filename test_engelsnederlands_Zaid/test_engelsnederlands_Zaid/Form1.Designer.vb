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
        btncontrole = New Button()
        btnopgave = New Button()
        txtengels = New TextBox()
        txtnederlands = New TextBox()
        MenuStrip1 = New MenuStrip()
        BestandToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        OpenFileDialog1 = New OpenFileDialog()
        IngevenWoordenToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(94, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 15)
        Label1.TabIndex = 0
        Label1.Text = "Engels woord"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(79, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nederlands woord"' 
        ' btncontrole
        ' 
        btncontrole.Location = New Point(298, 195)
        btncontrole.Name = "btncontrole"
        btncontrole.Size = New Size(96, 32)
        btncontrole.TabIndex = 2
        btncontrole.Text = "controle"
        btncontrole.UseVisualStyleBackColor = True
        ' 
        ' btnopgave
        ' 
        btnopgave.Location = New Point(190, 195)
        btnopgave.Name = "btnopgave"
        btnopgave.Size = New Size(81, 32)
        btnopgave.TabIndex = 3
        btnopgave.Text = "Opgave"
        btnopgave.UseVisualStyleBackColor = True
        ' 
        ' txtengels
        ' 
        txtengels.Location = New Point(221, 37)
        txtengels.Multiline = True
        txtengels.Name = "txtengels"
        txtengels.Size = New Size(152, 35)
        txtengels.TabIndex = 4
        ' 
        ' txtnederlands
        ' 
        txtnederlands.Location = New Point(221, 105)
        txtnederlands.Multiline = True
        txtnederlands.Name = "txtnederlands"
        txtnederlands.Size = New Size(152, 32)
        txtnederlands.TabIndex = 5
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {BestandToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(528, 24)
        MenuStrip1.TabIndex = 6
        MenuStrip1.Text = "MenuStrip1"' 
        ' BestandToolStripMenuItem
        ' 
        BestandToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {IngevenWoordenToolStripMenuItem})
        BestandToolStripMenuItem.Name = "BestandToolStripMenuItem"
        BestandToolStripMenuItem.Size = New Size(61, 20)
        BestandToolStripMenuItem.Text = "Bestand"' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"' 
        ' IngevenWoordenToolStripMenuItem
        ' 
        IngevenWoordenToolStripMenuItem.Name = "IngevenWoordenToolStripMenuItem"
        IngevenWoordenToolStripMenuItem.Size = New Size(180, 22)
        IngevenWoordenToolStripMenuItem.Text = "ingeven woorden"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(528, 310)
        Controls.Add(txtnederlands)
        Controls.Add(txtengels)
        Controls.Add(btnopgave)
        Controls.Add(btncontrole)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btncontrole As Button
    Friend WithEvents btnopgave As Button
    Friend WithEvents txtengels As TextBox
    Friend WithEvents txtnederlands As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BestandToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents IngevenWoordenToolStripMenuItem As ToolStripMenuItem
End Class
