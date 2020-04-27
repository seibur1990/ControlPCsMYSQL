Imports System.ComponentModel

Public Class frmPrincipal
    Private Sub frmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        With frmIdentificar
            .txUsr.Text = ""
            .txPass.Text = ""
            .txNom.Text = ""
            .txNom.Visible = False
            .lbNom.Visible = False
            .txPassRe.Text = ""
            .txPassRe.Visible = False
            .lbPassRe.Visible = False
            .txCorreu.Text = ""
            .txCorreu.Visible = False
            .lbCorreu.Visible = False
            .btNou.Enabled = True
            .btRecordar.Enabled = True
            .btIdentificar.Enabled = True
            .btOk.Visible = False
            .btCancelar.Visible = False
            .txPass.Visible = True
            .lbPass.Visible = True
            .Show()
        End With
    End Sub

    Private Sub NovaIncidènciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaIncidènciaToolStripMenuItem.Click
        frmNovaAlta.MdiParent = Me
        frmNovaAlta.Show()
    End Sub

    Private Sub MantenimentUsuarisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimentUsuarisToolStripMenuItem.Click
        frmUsuarisUPDATE.MdiParent = Me
        frmUsuarisUPDATE.Show()
    End Sub

    Private Sub AltaNouUsuariToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaNouUsuariToolStripMenuItem.Click
        frmUsuaris.MdiParent = Me
        frmUsuaris.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (comu.verifica_usrAdmin(frmIdentificar.usuari) = True) Then
            AdministracióToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub EstatIncidènciesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstatIncidènciesToolStripMenuItem.Click
        frmIncidencies.MdiParent = Me
        frmIncidencies.Show()
    End Sub

    Private Sub SobreLaplicacióToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreLaplicacióToolStripMenuItem.Click
        frmSobre.MdiParent = Me
        frmSobre.Show()
    End Sub

    Private Sub IncidènciesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncidènciesToolStripMenuItem.Click

    End Sub

    Private Sub PeticióServeiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeticióServeiToolStripMenuItem.Click
        peticioServei.MdiParent = Me
        peticioServei.Show()
    End Sub

    Private Sub EstatPeticionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstatPeticionsToolStripMenuItem.Click
        frmPeticio.MdiParent = Me
        frmPeticio.Show()
    End Sub
End Class