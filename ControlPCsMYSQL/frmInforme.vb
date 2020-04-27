Public Class Informes
    Private Sub frmInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ResolutionDataSet.incidencies' Puede moverla o quitarla según sea necesario.
        Me.incidenciesTableAdapter.Fill(Me.ResolutionDataSet.incidencies)
        'TODO: esta línea de código carga datos en la tabla 'ResolutionDataSet.incidencies' Puede moverla o quitarla según sea necesario.

        Me.ReportViewer1.RefreshReport
    End Sub


End Class