Public Class peticioServei
    Private Sub peticioServei_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comu.Llistat_responsables2()
        comu.Llistat_Prioritats2()

        cmbDept2.Items.Add("")
        cmbDept2.Items.Insert(1, "Nova campaña")
        cmbDept2.Items.Insert(2, "Depuració base de dades") 'x
        cmbDept2.Items.Insert(3, "Creació / modificació scripts")
        cmbDept2.Items.Insert(4, "Creació / modificació consultas") 'x
        cmbDept2.Items.Insert(5, "Creació / modificació informes") ' x
        cmbDept2.Items.Insert(6, "Gestió de registres")
        cmbDept2.Items.Insert(7, "Retornar base de dades") 'x

    End Sub
    Private Sub btNovaInci_Click(sender As Object, e As EventArgs) Handles btNovaInci.Click
        If ((cmbPrioritat2.Text <> "") And (cmbResponsable2.Text <> "") And (txProblema2.Text <> "")) Then
            'Dim dept As String = "'" + cmbDept.SelectedIndex.ToString + "'"

            Dim estat As String '= "'1'"
            ' comu.AltaPeticioServei(comu.idGrau(cmbPrioritat.Text), comu.idafectat(cmbResponsable.Text), txProblema.Text, dept, estat:=1, assignada:=0)
            comu.AltaPeticioServei(comu.idGrau(cmbPrioritat2.Text), comu.idafectat(cmbResponsable2.Text), dept:="'" + cmbDept2.SelectedIndex.ToString + "'", assignada:=0, id_estat:=1, problema:=txProblema2.Text)
        Else
            MsgBox("Falten dades", vbInformation)
        End If
    End Sub

    Private Sub cmbDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDept2.SelectedIndexChanged

    End Sub

    Private Sub cmbResponsable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbResponsable2.SelectedIndexChanged

    End Sub

End Class