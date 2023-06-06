Public Class frmssd
    Private Sub frmssd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To Startscherm.cpu.Length - 2
            lstssd.Items.Add(Startscherm.ssd(i) & " " & CStr(Startscherm.ssdprijs(i)))
        Next

    End Sub

    Private Sub btnkiezen_Click(sender As Object, e As EventArgs) Handles btnkiezen.Click

        Startscherm.pc.cpu = Startscherm.cpu(lstssd.SelectedIndex)
        Startscherm.pc.cpuprijs = Startscherm.cpuprijs(lstssd.SelectedIndex)
        txtpcssd.Text = "CPU: " & CStr(Startscherm.pc.cpu) & " " & CStr(Startscherm.pc.cpuprijs)
        lbltotaal.Text = CStr(Startscherm.pc.totaalberekenen())

    End Sub

    Private Sub btnverder_Click(sender As Object, e As EventArgs) Handles btnverder.Click

    End Sub

    Private Sub btnterug_Click(sender As Object, e As EventArgs) Handles btnterug.Click
        frmcpu.Show()
        Me.Hide()

    End Sub



End Class