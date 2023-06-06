Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView

Public Class Form1
    Dim getallen(19), aantaldoorgangen As Integer


    Private Sub btnsorteer_Click(sender As Object, e As EventArgs) Handles btnsorteer.Click
        txtgetallen.Text = ""

        'print van rnd getallen testen
        '  For i = 0 To getallen.Length - 1
        '   txtgetallen.Text += CStr(getallen(i)) & " "
        ' Next
        BubbleSort2(getallen, aantaldoorgangen)

        txtgetallen.Text += vbCrLf & "Dit is de gesorteerde array: "

        For i = 0 To getallen.Length - 1
            txtgetallen.Text += CStr(getallen(i)) & " "
        Next
        txtgetallen.Text += vbCrLf

        lblaantaldoorgangen.Text = "Aantal doorgangen: " & CStr(aantaldoorgangen)

    End Sub

    Sub genereergetallen(ByRef getallen() As Integer)
        Dim willekeurig As New System.Random()

        For i = 0 To getallen.Length - 1

            getallen(i) = willekeurig.Next(100) + 1

        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        genereergetallen(getallen)

        For i = 0 To getallen.Length - 1
            txtgetallen.Text += CStr(getallen(i)) & " "
        Next

    End Sub

    Sub BubbleSort2(ByRef arr As Integer(), ByRef aantaldoorgangen As Integer)
        Dim leftIndex As Integer = 0 ' The leftmost index of the unsorted subarray
        Dim rightIndex As Integer = arr.Length - 1 ' The rightmost index of the unsorted subarray
        Dim gewisseld As Boolean = False
        aantaldoorgangen = 1
        ' Continue until the unsorted subarray is empty
        While leftIndex < rightIndex

            ' Move the largest element to the right end of the unsorted subarray
            For i As Integer = leftIndex To rightIndex - 1
                If arr(i) > arr(i + 1) Then
                    Swap(arr, i, i + 1) ' Swap arr(i) and arr(i + 1)
                    doorganglatenzien(aantaldoorgangen, arr(i), arr(i + 1), "links naar rechts", arr)
                    gewisseld = True
                End If
            Next

            rightIndex -= 1 ' Decrement the right index since the rightmost element is sorted now

            ' Move the smallest element to the left end of the unsorted subarray
            For i As Integer = rightIndex To leftIndex Step -1
                If i > 0 Then 'deze if moet anders krijg je probleem met array
                    If arr(i) < arr(i - 1) Then
                        Swap(arr, i, i - 1) ' Swap arr(i) and arr(i - 1)
                        doorganglatenzien(aantaldoorgangen, arr(i), arr(i - 1), "rechts naar links", arr)
                        gewisseld = True
                    End If
                End If
            Next

            leftIndex += 1 ' Increment the left index since the leftmost element is sorted now
            If gewisseld = True Then
                aantaldoorgangen += 1
            ElseIf gewisseld = False Then
                Exit While
            End If
            gewisseld = False
        End While
    End Sub
    Sub Swap(ByVal arr As Integer(), ByVal i As Integer, ByVal j As Integer)
        ' Swaps the values of arr(i) and arr(j)
        Dim temp As Integer = arr(i)
        arr(i) = arr(j)
        arr(j) = temp
    End Sub

    Sub doorganglatenzien(ByVal doorgangnummer As Integer, ByVal grotergetal As Integer, ByVal kleinergetal As Integer, ByVal richting As String, ByVal huidigearray() As Integer)

        txtgetallen.Text += "doorgangnummer: " & CStr(doorgangnummer) & " " & "richting: " & richting & " " & "getallen die van plaats werden gewisseld: " & CStr(grotergetal) & "<=>" & CStr(kleinergetal) & " " & "array: " & vbCrLf

        For i = 0 To huidigearray.Length - 1
            txtgetallen.Text += CStr(huidigearray(i)) & " "
        Next
        txtgetallen.Text += vbCrLf

    End Sub

    Private Sub btnSluiten_Click(sender As Object, e As EventArgs) Handles btnSluiten.Click
        Me.Close()
    End Sub
End Class
