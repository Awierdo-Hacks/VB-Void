Namespace Sortfunctions

    'slaagt de kleinst gevonden getal tot nu toe op en vergelijkt die met de rest van de array indien nog kleiner getal gevonden word deze opgeslagen en daarna verwisseld met de plaats in de array adhv de for i loop
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

    'paren van 2 vergelijken met elkaar dan opnieuw
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

    'getal met alle getallen van links vergelijken als chosen getal kleiner is van plaats verwisselen
    Sub InsertionSort(ByVal arr As Integer())
        ' Loop through each element in the array
        For i As Integer = 1 To arr.Length - 1
            ' Get the current element and the index of the previous element
            Dim current As Integer = arr(i)
            Dim j As Integer = i - 1

            ' Move elements that are greater than the current element one position to the right
            While j >= 0 AndAlso arr(j) > current
                arr(j + 1) = arr(j)
                j -= 1
            End While

            ' Insert the current element in its correct position
            arr(j + 1) = current
        Next i
    End Sub

    'is eigenlijk een bubble sort maar gaat ipv links nr rechts nu links nr rechts dan rechts naar links
    Sub RippleSort(ByVal arr As Integer())
        Dim leftIndex As Integer = 0 ' The leftmost index of the unsorted subarray
        Dim rightIndex As Integer = arr.Length - 1 ' The rightmost index of the unsorted subarray

        ' Continue until the unsorted subarray is empty
        While leftIndex < rightIndex

            ' Move the largest element to the right end of the unsorted subarray
            For i As Integer = leftIndex To rightIndex - 1
                If arr(i) > arr(i + 1) Then
                    Swap(arr, i, i + 1) ' Swap arr(i) and arr(i + 1)
                End If
            Next i

            rightIndex -= 1 ' Decrement the right index since the rightmost element is sorted now

            ' Move the smallest element to the left end of the unsorted subarray
            For i As Integer = rightIndex To leftIndex Step -1
                If arr(i) < arr(i - 1) Then
                    Swap(arr, i, i - 1) ' Swap arr(i) and arr(i - 1)
                End If
            Next i

            leftIndex += 1 ' Increment the left index since the leftmost element is sorted now
        End While
    End Sub

    Sub Swap(ByVal arr As Integer(), ByVal i As Integer, ByVal j As Integer)
        ' Swaps the values of arr(i) and arr(j)
        Dim temp As Integer = arr(i)
        arr(i) = arr(j)
        arr(j) = temp
    End Sub

    'Mergesort -------------------

    Sub MergeSort(ByRef array() As Integer)
        Dim length As Integer = array.Length
        If length <= 1 Then Return 'base case

        Dim middle As Integer = length \ 2
        Dim leftArray(middle - 1) As Integer
        Dim rightArray(length - middle - 1) As Integer

        Dim i As Integer = 0 'left array
        Dim j As Integer = 0 'right array

        For Each element In array
            If i < middle Then
                leftArray(i) = element
            Else
                rightArray(j) = element
                j += 1
            End If
            i += 1
        Next

        MergeSort(leftArray)
        MergeSort(rightArray)
        Merge(leftArray, rightArray, array)
    End Sub

    Sub Merge(ByVal leftArray() As Integer, ByVal rightArray() As Integer, ByRef array() As Integer)
        Dim leftSize As Integer = leftArray.Length
        Dim rightSize As Integer = rightArray.Length
        Dim i As Integer = 0
        Dim l As Integer = 0
        Dim r As Integer = 0 'indices

        'check the conditions for merging
        While l < leftSize AndAlso r < rightSize
            If leftArray(l) < rightArray(r) Then
                array(i) = leftArray(l)
                i += 1
                l += 1
            Else
                array(i) = rightArray(r)
                i += 1
                r += 1
            End If
        End While
        While l < leftSize
            array(i) = leftArray(l)
            i += 1
            l += 1
        End While
        While r < rightSize
            array(i) = rightArray(r)
            i += 1
            r += 1
        End While
    End Sub













End Namespace