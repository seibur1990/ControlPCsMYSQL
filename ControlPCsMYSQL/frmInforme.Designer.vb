<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Informes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.incidenciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResolutionDataSet = New Resolution.resolutionDataSet()
        Me.incidenciesTableAdapter = New Resolution.resolutionDataSetTableAdapters.incidenciesTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.incidenciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResolutionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'incidenciesBindingSource
        '
        Me.incidenciesBindingSource.DataMember = "incidencies"
        Me.incidenciesBindingSource.DataSource = Me.ResolutionDataSet
        '
        'ResolutionDataSet
        '
        Me.ResolutionDataSet.DataSetName = "ResolutionDataSet"
        Me.ResolutionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'incidenciesTableAdapter
        '
        Me.incidenciesTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "inform1Resolution"
        ReportDataSource2.Value = Me.incidenciesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Resolution.informe1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 55)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1197, 315)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(481, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Informe"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Informes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Informes"
        Me.Text = "Informe"
        CType(Me.incidenciesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResolutionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents incidenciesBindingSource As BindingSource
    Friend WithEvents ResolutionDataSet As resolutionDataSet
    Friend WithEvents incidenciesTableAdapter As resolutionDataSetTableAdapters.incidenciesTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As Label
End Class
