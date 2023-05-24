<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class engels_nederlands
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
        OpenFileDialog1 = New OpenFileDialog()
        MenuStrip1 = New MenuStrip()
        BestandToolStripMenuItem = New ToolStripMenuItem()
        SluitenToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        Label2 = New Label()
        txtengels = New TextBox()
        txtnederlands = New TextBox()
        btntoevoegen = New Button()
        btnVerwijderen = New Button()
        lstengned = New ListBox()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {BestandToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"' 
        ' BestandToolStripMenuItem
        ' 
        BestandToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SluitenToolStripMenuItem})
        BestandToolStripMenuItem.Name = "BestandToolStripMenuItem"
        BestandToolStripMenuItem.Size = New Size(61, 20)
        BestandToolStripMenuItem.Text = "bestand"' 
        ' SluitenToolStripMenuItem
        ' 
        SluitenToolStripMenuItem.Name = "SluitenToolStripMenuItem"
        SluitenToolStripMenuItem.Size = New Size(109, 22)
        SluitenToolStripMenuItem.Text = "sluiten"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(349, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 2
        Label1.Text = "Engels woord:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(349, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 15)
        Label2.TabIndex = 3
        Label2.Text = "Nederlands woord:"' 
        ' txtengels
        ' 
        txtengels.Location = New Point(485, 40)
        txtengels.Multiline = True
        txtengels.Name = "txtengels"
        txtengels.Size = New Size(118, 34)
        txtengels.TabIndex = 4
        ' 
        ' txtnederlands
        ' 
        txtnederlands.Location = New Point(485, 98)
        txtnederlands.Multiline = True
        txtnederlands.Name = "txtnederlands"
        txtnederlands.Size = New Size(118, 35)
        txtnederlands.TabIndex = 5
        ' 
        ' btntoevoegen
        ' 
        btntoevoegen.Location = New Point(381, 181)
        btntoevoegen.Name = "btntoevoegen"
        btntoevoegen.Size = New Size(97, 23)
        btntoevoegen.TabIndex = 6
        btntoevoegen.Text = "Toevoegen"
        btntoevoegen.UseVisualStyleBackColor = True
        ' 
        ' btnVerwijderen
        ' 
        btnVerwijderen.Location = New Point(504, 181)
        btnVerwijderen.Name = "btnVerwijderen"
        btnVerwijderen.Size = New Size(99, 23)
        btnVerwijderen.TabIndex = 7
        btnVerwijderen.Text = "Verwijderen"
        btnVerwijderen.UseVisualStyleBackColor = True
        ' 
        ' lstengned
        ' 
        lstengned.FormattingEnabled = True
        lstengned.ItemHeight = 15
        lstengned.Location = New Point(52, 48)
        lstengned.Name = "lstengned"
        lstengned.Size = New Size(231, 259)
        lstengned.TabIndex = 8
        ' 
        ' engels_nederlands
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstengned)
        Controls.Add(btnVerwijderen)
        Controls.Add(btntoevoegen)
        Controls.Add(txtnederlands)
        Controls.Add(txtengels)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "engels_nederlands"
        Text = "engels_nederlands"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BestandToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtengels As TextBox
    Friend WithEvents txtnederlands As TextBox
    Friend WithEvents btntoevoegen As Button
    Friend WithEvents btnVerwijderen As Button
    Friend WithEvents SluitenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstengned As ListBox
End Class
