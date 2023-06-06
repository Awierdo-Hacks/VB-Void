Imports System.Net.Security
' met f5 kan je springen tot volgende breakpunt
Public Class frmStart
    Public Shared configpc As New pc
    Public Shared cpus As New List(Of component)
    Public Shared moederborden As New List(Of component)
    Public Shared ssds As New List(Of component)
    Public Shared cases As New List(Of component)
    Public Shared grafischekaarten As New List(Of component)
    Public Shared geheugens As New List(Of component)

    Private Sub btnInlezen_Click(sender As Object, e As EventArgs) Handles btnInlezen.Click
        FileOpen(1, "PC componenten.txt", OpenMode.Input)
        Do While Not EOF(1)

            Dim type As String = ""
            Dim benaming As String = ""
            Dim prijs As Decimal
            Try
                Input(1, type)
                Input(1, benaming)
                Input(1, prijs)
                If type = "cpu" Then
                    Dim comcpu As New component
                    comcpu.benaming = benaming
                    comcpu.prijs = prijs
                    cpus.Add(comcpu)

                    ' tweede manier cpus.Add(New component(benaming, prijs))
                ElseIf type = "Moederbord" Then
                    moederborden.Add(New component(benaming, prijs))
                ElseIf type = "geheugen" Then
                    geheugens.Add(New component(benaming, prijs))
                ElseIf type = "Grafisch" Then
                    grafischekaarten.Add(New component(benaming, prijs))

                ElseIf type = "SSD" Then
                    ssds.Add(New component(benaming, prijs))
                ElseIf type = "case" Then
                    cases.Add(New component(benaming, prijs))
                End If

            Catch

            End Try

        Loop
        FileClose(1)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' bij structure moet je constructor met parameters maken 
        ' dit wiped de vorige config als dat niet wil geen  configpc = New pc
        configpc = New pc
        frmCPU.Show()
        Me.Hide()

    End Sub
End Class
