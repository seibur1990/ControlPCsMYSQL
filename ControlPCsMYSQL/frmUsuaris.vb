Public Class frmUsuaris
    Private Sub btAlta_Click(sender As Object, e As EventArgs) Handles btAlta.Click
        If ((txNom.Text <> "") And (txUsr.Text <> "") And (txPass.Text <> "") And (txCorreu.Text <> "")) Then
            If (txPass.Text = txPassRe.Text) Then
                Dim estat, notificacions As Integer
                If (chActiu.Checked) Then
                    estat = 1
                Else
                    estat = 0
                End If
                If (chNotifice.Checked) Then
                    notificacions = 1
                Else
                    notificacions = 0
                End If
                comu.AltaUsuari(txNom.Text, txUsr.Text, txPass.Text, txCorreu.Text, estat, notificacions)
            Else
                    MsgBox("La contrasenya no és igual", vbExclamation)
            End If
        Else
            MsgBox("Falten dades", vbExclamation)
        End If
    End Sub

    Private Sub frmUsuaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class