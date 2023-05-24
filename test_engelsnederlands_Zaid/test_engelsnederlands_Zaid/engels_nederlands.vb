Imports System.IO

Public Class engels_nederlands
    Dim engelswoord, nederlandswoord As New List(Of String)


    Private Sub btntoevoegen_Click(sender As Object, e As EventArgs) Handles btntoevoegen.Click
        engelswoord.Add(txtengels.Text)
        nederlandswoord.Add(txtnederlands.Text)

        File.AppendAllText("engned.txt", txtengels.Text & txtnederlands.Text & vbCrLf)
        lstengned.Items.Add(txtengels.Text & txtnederlands.Text)
    End Sub

    Private Sub engels_nederlands_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim lines = File.ReadAllLines("engned.txt")

        For Each line In lines
            If line.Substring(0, line.IndexOf(",") Then
        Next

        WoordenTonen()


    End Sub

    Private Sub btnVerwijderen_Click(sender As Object, e As EventArgs) Handles btnVerwijderen.Click
        Dim index = engelswoord.IndexOf(txtengels.Text)
        engelswoord.RemoveAt(index)
        nederlandswoord.RemoveAt(index)
        WoordenTonen()
    End Sub

    Private Sub WoordenTonen()
        lstengned.Items.Clear()

        For i = 0 To engelswoord.Count - 1
            lstengned.Items.Add(engelswoord(i) & "  --  " & nederlandswoord(i) & vbCrLf)
        Next
    End Sub
End Class