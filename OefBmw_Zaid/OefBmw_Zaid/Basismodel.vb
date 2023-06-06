Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Basismodel
    Private Sub Basismodel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaultConfiguration()
    End Sub

    Sub SetDefaultConfiguration()
        radreeks3.Checked = False
        radreeks5.Checked = False
        radreeks7.Checked = False
    End Sub

    Private Sub radreeks3_CheckedChanged(sender As Object, e As EventArgs) Handles radreeks3.CheckedChanged

    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click

    End Sub

    Private Sub lbltotaalprijs_Click(sender As Object, e As EventArgs) Handles lbltotaalprijs.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class