Public Class frmIdentificar
    Public usuari As String = ""
    Public pass As String = ""
    Public correu As String = ""
    Public nom As String = ""
    Public status As Integer = 0 'Categoria de l'usuari, 0 Desconectat, 1 Conectat, 2 Administrador
    Private Sub btNou_Click(sender As Object, e As EventArgs) Handles btNou.Click
        txUsr.Text = ""
        txPass.Text = ""
        txNom.Text = ""
        txNom.Visible = True
        txPassRe.Text = ""
        txPassRe.Visible = True
        txCorreu.Text = ""
        txCorreu.Visible = True
        btNou.Enabled = False
        btRecordar.Enabled = False
        btIdentificar.Enabled = False
        btOk.Visible = True
        btCancelar.Visible = True
        lbCorreu.Visible = True
        lbNom.Visible = True
        lbPassRe.Visible = True
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        txUsr.Text = ""
        txPass.Text = ""
        txNom.Text = ""
        txNom.Visible = False
        lbNom.Visible = False
        txPassRe.Text = ""
        txPassRe.Visible = False
        lbPassRe.Visible = False
        txCorreu.Text = ""
        txCorreu.Visible = False
        lbCorreu.Visible = False
        btNou.Enabled = True
        btRecordar.Enabled = True
        btIdentificar.Enabled = True
        btOk.Visible = False
        btCancelar.Visible = False
        txPass.Visible = True
        lbPass.Visible = True
    End Sub

    Private Sub btRecordar_Click(sender As Object, e As EventArgs) Handles btRecordar.Click
        txUsr.Text = ""
        txPass.Text = ""
        txNom.Text = ""
        txNom.Visible = False
        lbNom.Visible = False
        txPass.Text = ""
        txPass.Visible = False
        lbPass.Visible = False
        txPassRe.Text = ""
        txPassRe.Visible = False
        lbPassRe.Visible = False
        txCorreu.Text = ""
        txCorreu.Visible = True
        lbCorreu.Visible = True
        btNou.Enabled = False
        btRecordar.Enabled = False
        btIdentificar.Enabled = False
        btOk.Visible = True
        btCancelar.Visible = True
    End Sub

    Private Sub btIdentificar_Click(sender As Object, e As EventArgs) Handles btIdentificar.Click
        If ((txPass.Text.Trim(" ") <> "") And (txUsr.Text.Trim(" ") <> "")) Then
            If (comu.verifica_usr() = True) Then
                Me.Visible = False
                frmPrincipal.ShowDialog()
            Else
                MsgBox("Usuari i/o contrasenya erronis", vbInformation, "Informació")
            End If
        Else
            MsgBox("L'usuari i/o la contrasenya està o estan en blanc.", vbInformation, "Informació")
        End If
    End Sub

    Private Sub txPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txPass.KeyDown
        If ((e.KeyCode = Keys.Enter) And (btNou.Enabled = True)) Then
            If ((txPass.Text.Trim(" ") <> "") And (txUsr.Text.Trim(" ") <> "")) Then
                If (comu.verifica_usr() = True) Then
                    Me.Visible = False
                    frmPrincipal.ShowDialog()
                Else
                    MsgBox("Usuari i/o contrasenya erronis", vbInformation, "Informació")
                End If
            Else
                MsgBox("L'usuari i/o la contrasenya està o estan en blanc.", vbInformation, "Informació")
            End If
        End If
    End Sub

    Private Sub frmIdentificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btOk_Click(sender As Object, e As EventArgs) Handles btOk.Click
        If ((txNom.Visible = True) And (txCorreu.Visible = True) And (txPassRe.Visible = True)) Then
            If ((txNom.Text.Trim(" ") <> " ") And (txCorreu.Text.Trim(" ") <> "") And (txPassRe.Text.Trim(" ") <> "") And (txPass.Text.Trim(" ") <> "") And (txPassRe.Text = txPass.Text)) Then
                comu.AltaUsuari(txNom.Text, txUsr.Text, txPass.Text, txCorreu.Text, 0, 0)
                comu.EnviamentCorreuNotificables("Nou usuari " + txNom.Text + " (" + txUsr.Text + ")", "Nova alta al sistema")
                txUsr.Text = ""
                txPass.Text = ""
                txNom.Text = ""
                txNom.Visible = False
                lbNom.Visible = False
                txPassRe.Text = ""
                txPassRe.Visible = False
                lbPassRe.Visible = False
                txCorreu.Text = ""
                txCorreu.Visible = False
                lbCorreu.Visible = False
                btNou.Enabled = True
                btRecordar.Enabled = True
                btIdentificar.Enabled = True
                btOk.Visible = False
                btCancelar.Visible = False
                txPass.Visible = True
                lbPass.Visible = True
                MsgBox("Ara cal esperar que els administradors activin aquest usuari")
            Else
                MsgBox("Els valors no estan correctes, revisa que la contrasenya estigui repetida correctament i les dades no siguin nules.", vbInformation)
            End If
        End If
    End Sub

    Private Sub lbPass_Click(sender As Object, e As EventArgs) Handles lbPass.Click

    End Sub

    Private Sub txPass_TextChanged(sender As Object, e As EventArgs) Handles txPass.TextChanged

    End Sub

    Private Sub lbPassRe_Click(sender As Object, e As EventArgs) Handles lbPassRe.Click

    End Sub

    Private Sub txPassRe_TextChanged(sender As Object, e As EventArgs) Handles txPassRe.TextChanged

    End Sub

    Private Sub txCorreu_TextChanged(sender As Object, e As EventArgs) Handles txCorreu.TextChanged

    End Sub

    Private Sub lbCorreu_Click(sender As Object, e As EventArgs) Handles lbCorreu.Click

    End Sub
End Class