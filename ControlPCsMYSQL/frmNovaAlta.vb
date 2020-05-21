Public Class frmNovaAlta
    Private Sub frmNovaAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comu.Llistat_responsables()
        comu.Llistat_PCs()
        comu.Llistat_Prioritats()

        cmbDept.Items.Add("")
        cmbDept.Items.Insert(1, "Aplicatius")
        cmbDept.Items.Insert(2, "Correo Electrònic") 'x
        cmbDept.Items.Insert(3, "Evolution Manager")
        cmbDept.Items.Insert(4, "Hardrware PC's") 'x
        cmbDept.Items.Insert(5, "Impressora") ' x
        cmbDept.Items.Insert(6, "Informes")
        cmbDept.Items.Insert(7, "Servidors") 'x
        cmbDept.Items.Insert(8, "Telefonia") 'x
        cmbDept.Items.Insert(9, "Xarxa") 'x
        ' falta Configuracio posicio agent

    End Sub

    Private Sub btNovaInci_Click(sender As Object, e As EventArgs) Handles btNovaInci.Click
        If ((cmbPrioritat.Text <> "") And (cmbResponsable.Text <> "") And (cmbPCs.Text <> "") And (txProblema.Text <> "")) Then
            Dim dept As String = "'" + cmbDept.SelectedIndex.ToString + "'"
            Dim estat As String = "'1'"
            comu.AltaIncidencia(comu.idGrau(cmbPrioritat.Text), comu.idafectat(cmbResponsable.Text), comu.id_PC(cmbPCs.Text), txProblema.Text, dept, estat, assignada:=0)
        Else
            MsgBox("Falten dades", vbInformation)
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub cmbDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDept.SelectedIndexChanged

    End Sub

    Private Sub cmbResponsable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbResponsable.SelectedIndexChanged

    End Sub
End Class