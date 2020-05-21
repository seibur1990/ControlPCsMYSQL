Public Class frmUsuarisUPDATE
    Private Sub frmUsuarisUPDATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comu.Llistat_usrAdmin()
    End Sub

    Private Sub cmbUsr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsr.SelectedIndexChanged
        If (cmbUsr.Text <> "") Then
            If (comu.verifica_usuari(cmbUsr.Text) = True) Then
                txCorreu.Enabled = True
                txPass.Enabled = True
                txPassRe.Enabled = True
                chActiu.Enabled = True
                chNotifice.Enabled = True
                txNom.Enabled = True
                chAdmin.Enabled = True
                Dades_usr(cmbUsr.Text)
            Else
                txNom.Text = ""
                txCorreu.Enabled = False
                txCorreu.Text = ""
                txPass.Enabled = False
                txPass.Text = ""
                txPassRe.Enabled = False
                txPassRe.Text = ""
                chActiu.Enabled = False
                chNotifice.Enabled = False
                chNotifice.Checked = False
                chActiu.Checked = False
                txNom.Enabled = False
                chAdmin.Enabled = False
                chAdmin.Checked = False
            End If
        End If
    End Sub

    Private Sub cmbUsr_TextChanged(sender As Object, e As EventArgs) Handles cmbUsr.TextChanged
        If (cmbUsr.Text <> "") Then
            If (comu.verifica_usuari(cmbUsr.Text) = True) Then
                txCorreu.Enabled = True
                txPass.Enabled = True
                txPassRe.Enabled = True
                chActiu.Enabled = True
                chNotifice.Enabled = True
                txNom.Enabled = True
                chAdmin.Enabled = True
                Dades_usr(cmbUsr.Text)
            Else
                txNom.Text = ""
                txCorreu.Enabled = False
                txCorreu.Text = ""
                txPass.Enabled = False
                txPass.Text = ""
                txPassRe.Enabled = False
                txPassRe.Text = ""
                chActiu.Enabled = False
                chNotifice.Enabled = False
                chNotifice.Checked = False
                chActiu.Checked = False
                txNom.Enabled = False
                chAdmin.Enabled = False
                chAdmin.Checked = False
            End If

        End If
    End Sub

    Private Sub btActualitzar_Click(sender As Object, e As EventArgs) Handles btActualitzar.Click
        If (txPass.Text <> "") Then
            If (MsgBox("Segur que vols actualitzar la contrasenya?", vbOK) = 1) Then
                If (txPass.Text = txPassRe.Text) Then
                    MsgBox("Actualitzada la pass i les dades")
                    ActualitzarUsuari(cmbUsr.Text, txPass.Text, txCorreu.Text, chActiu.Checked, chNotifice.Checked, False, txNom.Text)
                Else
                    MsgBox("La contrasenya no és igual en els dos camps", vbInformation)
                End If
            End If
        ElseIf (txPass.Text = txPassRe.Text) Then
            ActualitzarUsuari(cmbUsr.Text, "", txCorreu.Text, chActiu.Checked, chNotifice.Checked, chAdmin.Checked, txNom.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txNom.Text = ""
        cmbUsr.Text = ""
        cmbUsr.Items.Clear()
        txCorreu.Text = ""
        txPass.Text = ""
        txPassRe.Text = ""
        chActiu.Checked = False
        chNotifice.Checked = False
        chNotifice.Checked = False
        chActiu.Checked = False
        txNom.Enabled = False
        chAdmin.Enabled = False
        chAdmin.Checked = False
    End Sub

End Class