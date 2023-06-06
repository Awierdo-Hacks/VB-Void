Public Class Form1
    Dim getallen(), aantalgetallen As Integer




    Private Sub btnSluiten_Click(sender As Object, e As EventArgs) Handles btnSluiten.Click
        Me.Close()
    End Sub

    Private Sub btnGenereren_Click(sender As Object, e As EventArgs) Handles btnGenereren.Click
        aantalgetallen = CInt(txtaantalgetallen.Text)
        ReDim getallen(aantalgetallen - 1)
        genereren(getallen())



    End Sub
    Sub genereren(ByRef getallen() As Integer)

    End Sub

End Class
