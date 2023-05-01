Public Class sortfunclijst
    Sub SelectionSort(ByVal arr As Integer())
        ' The outer loop iterates over each element in the array, up to the second to last element.
        For i As Integer = 0 To arr.Length - 2
            ' Assume the current element is the minimum.
            Dim minIndex As Integer = i

            ' The inner loop searches for the smallest element in the unsorted portion of the array.
            For j As Integer = i + 1 To arr.Length - 1
                ' If the current element is smaller than the current minimum, update the minimum index.
                If arr(j) < arr(minIndex) Then
                    minIndex = j
                End If
            Next j

            ' If the current element is not the minimum, swap it with the minimum.
            If minIndex <> i Then
                Dim temp As Integer = arr(i)
                arr(i) = arr(minIndex)
                arr(minIndex) = temp
            End If
        Next i
    End Sub


    Sub BubbleSort(ByVal arr As Integer())
        ' The outer loop iterates over each element in the array, up to the second to last element.
        For i As Integer = 0 To arr.Length - 2
            ' The inner loop compares adjacent elements and swaps them if they are in the wrong order.
            For j As Integer = 0 To arr.Length - i - 2
                ' If the current element is greater than the next element, swap them.
                If arr(j) > arr(j + 1) Then
                    Dim temp As Integer = arr(j)
                    arr(j) = arr(j + 1)
                    arr(j + 1) = temp
                End If
            Next j
        Next i
    End Sub
End Class
