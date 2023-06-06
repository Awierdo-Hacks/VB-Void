Imports System.Windows.Forms.VisualStyles

Public Class frmcpu
    Private Sub frmcpu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To Startscherm.cpu.Length - 2
            lstcpu.Items.Add(Startscherm.cpu(i) & " " & CStr(Startscherm.cpuprijs(i)))
        Next

    End Sub

    Private Sub btnkiezen_Click(sender As Object, e As EventArgs) Handles btnkiezen.Click

        Startscherm.pc.cpu = Startscherm.cpu(lstcpu.SelectedIndex)
        Startscherm.pc.cpuprijs = Startscherm.cpuprijs(lstcpu.SelectedIndex)
        txtpccpu.Text = "CPU: " & CStr(Startscherm.pc.cpu) & " " & CStr(Startscherm.pc.cpuprijs)
        lbltotaal.Text = CStr(Startscherm.pc.totaalberekenen())

    End Sub

    Private Sub btnverder_Click(sender As Object, e As EventArgs) Handles btnverder.Click
        frmssd.Show()
    End Sub
End Class