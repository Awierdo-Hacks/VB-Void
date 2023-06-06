Public Class frmCPU
    Private Sub frmCPU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateAlles()

    End Sub

    Private Sub frmCPU_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' na load en na van hide naar show 
        updateAlles()
    End Sub
    Public Sub updateAlles()
        'listbox , textbox ,totaal label updaten

        'listbox update
        lstOnderdelen.Items.Clear()
        For Each componentje In frmStart.cpus
            Dim benaming As String = componentje.benaming
            Dim prijs As Decimal = componentje.prijs
            ' Dim liststring = benaming & " €" & CStr(prijs)
            Dim liststring = componentje.ToString
            lstOnderdelen.Items.Add(liststring)
        Next

        'tekstvak update

        txtOverzicht.Text = ""
        If Not frmStart.configpc.cpu.benaming = "" Then
            txtOverzicht.Text &= "cpu: " & frmStart.configpc.cpu.benaming & "- €" & CStr(frmStart.configpc.cpu.prijs) & vbCrLf

        End If

        If Not frmStart.configpc.moederbord.benaming = "" Then
            txtOverzicht.Text &= "moederbord: " & frmStart.configpc.moederbord.benaming & "- €" & CStr(frmStart.configpc.moederbord.prijs) & vbCrLf

        End If

        If Not frmStart.configpc.geheugen.benaming = "" Then
            txtOverzicht.Text &= "geheugen: " & frmStart.configpc.geheugen.benaming & "- €" & CStr(frmStart.configpc.geheugen.prijs) & vbCrLf

        End If

        If Not frmStart.configpc.grafischekaart.benaming = "" Then
            txtOverzicht.Text &= "grafischekaart: " & frmStart.configpc.grafischekaart.benaming & "- €" & CStr(frmStart.configpc.grafischekaart.prijs) & vbCrLf

        End If

        If Not frmStart.configpc.ssd.benaming = "" Then
            txtOverzicht.Text &= "ssd: " & frmStart.configpc.ssd.benaming & "- €" & CStr(frmStart.configpc.ssd.prijs) & vbCrLf

        End If

        If Not frmStart.configpc.casing.benaming = "" Then
            txtOverzicht.Text &= "case: " & frmStart.configpc.casing.benaming & "- €" & CStr(frmStart.configpc.casing.prijs) & vbCrLf

        End If
    End Sub

    Private Sub btnKiezen_Click(sender As Object, e As EventArgs) Handles btnKiezen.Click


        If lstOnderdelen.SelectedIndex <> -1 Then
            frmStart.configpc.cpu = frmStart.cpus(lstOnderdelen.SelectedIndex)
        End If


        updateAlles()
    End Sub
End Class