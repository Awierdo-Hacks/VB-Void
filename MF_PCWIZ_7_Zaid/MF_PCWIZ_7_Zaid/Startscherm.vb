Imports System.ComponentModel
Imports System.IO
Imports System.Reflection

Public Class Startscherm
    Public Shared pc As Computer
    Dim indexc, indexr, indexs, indexm, indexb, indexg As Integer
    Public Shared cpu(0), ram(0), ssd(0), moederbord(0), behuizing(0), grafisch(0) As String
    Public Shared cpuprijs(0), ramprijs(0), ssdprijs(0), moederbordprijs(0), behuizingprijs(0), grafischprijs(0) As Decimal
    Private Sub btnstartconfig_Click(sender As Object, e As EventArgs) Handles btnstartconfig.Click
        frmcpu.Show()
        Me.Hide()



    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnleesprijslijst.Click

        Dim componentType As String = ""
        Dim naam As String = ""
        Dim prijs As Decimal
        Dim fileName As String = "PCcomponenten.txt"

        ' Openen bestand
        FileOpen(1, fileName, OpenMode.Input)

        ' Lezen van de records in het bestand
        Do While Not EOF(1)
            ' Lezen lijn
            Dim line As String = LineInput(1)

            ' Split the line by commas
            Dim values As String() = line.Split(","c)

            ' Assign values to variables
            If values.Length >= 3 Then
                componentType = values(0).Trim()
                naam = values(1).Trim()
                prijs = CDec(values(2).Trim().Replace(",", ".")) / 100

                componentenverdelen(componentType, naam, prijs)




            End If


        Loop

        ' Sluiten van het bestand
        FileClose(1)
        lblklaarmetladen.Text = "klaar"
    End Sub
    Public Sub componentenverdelen(ByVal soortcomponent As String, ByVal naamcomponent As String, ByVal prijs As Decimal)

        If soortcomponent = "cpu" Then
            ReDim Preserve cpu(cpu.Length)
            ReDim Preserve cpuprijs(cpu.Length)
            cpu(indexc) = naamcomponent
            cpuprijs(indexc) = prijs
            indexc += 1
        ElseIf soortcomponent = "SSD" Then
            ReDim Preserve ssd(ssd.Length)
            ReDim Preserve ssdprijs(ssdprijs.Length)
            ssd(indexs) = naamcomponent
            ssdprijs(indexs) = prijs
            indexs += 1
        ElseIf soortcomponent = "geheugen" Then
            ReDim Preserve ram(ram.Length)
            ReDim Preserve ramprijs(ramprijs.Length)
            ram(indexr) = naamcomponent
            ramprijs(indexr) = prijs
            indexr += 1
        ElseIf soortcomponent = "Moederbord" Then
            ReDim Preserve moederbord(moederbord.Length)
            ReDim Preserve moederbordprijs(moederbordprijs.Length)
            moederbord(indexm) = naamcomponent
            moederbordprijs(indexm) = prijs
            indexm += 1
        ElseIf soortcomponent = "case" Then
            ReDim Preserve behuizing(behuizing.Length)
            ReDim Preserve behuizingprijs(behuizingprijs.Length)
            behuizing(indexb) = naamcomponent
            behuizingprijs(indexb) = prijs
            indexb += 1
        ElseIf soortcomponent = "Grafisch" Then
            ReDim Preserve grafisch(grafisch.Length)
            ReDim Preserve grafischprijs(grafischprijs.Length)
            grafisch(indexg) = naamcomponent
            grafischprijs(indexg) = prijs
            indexg += 1
        End If


    End Sub
End Class
