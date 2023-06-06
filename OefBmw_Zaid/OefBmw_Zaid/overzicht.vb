Public Class overzicht
    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        Basismodel.Show()
        Me.Hide()
    End Sub

    Private Sub overzicht_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim button As DialogResult = Login.ShowDialog()
        If button = Windows.Forms.DialogResult.OK Then
            ' OK
            Me.Text = "Gebruiker (Login: " &
              Login.Tag.ToString & ")"
        Else
            ' Cancel
            Me.Close()
        End If
    End Sub
End Class
