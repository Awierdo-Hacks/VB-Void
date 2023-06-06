Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If (txtLogin.Text = "An" Or txtLogin.Text = "Jan") _
    AndAlso txtWachtwoord.Text = "test" Then
            ' Wachtwoord ok
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Tag = txtLogin.Text
        Else
            ' Wachtwoord fout
            MessageBox.Show("Je hebt een foute gebruikersnaam " &
        “en/of wachtwoord gegeven.", "Fout bij het aanmelden",
MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If





    End Sub
End Class