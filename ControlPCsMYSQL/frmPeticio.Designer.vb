<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeticio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBuscar = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.buscEstat2 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.buscDept2 = New System.Windows.Forms.ComboBox()
        Me.Cercador2 = New System.Windows.Forms.Button()
        Me.TextData2 = New System.Windows.Forms.TextBox()
        Me.LabelData = New System.Windows.Forms.Label()
        Me.TextUsuari2 = New System.Windows.Forms.TextBox()
        Me.LabelUsuari = New System.Windows.Forms.Label()
        Me.buscadorId2 = New System.Windows.Forms.TextBox()
        Me.LabelIdCas = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbAssignat2 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bt_informe2 = New System.Windows.Forms.Button()
        Me.prioritat = New System.Windows.Forms.Label()
        Me.cmbState2 = New System.Windows.Forms.ComboBox()
        Me.categoria = New System.Windows.Forms.Label()
        Me.cmbTipus2 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txNomPacient2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btAccioActualitzar2 = New System.Windows.Forms.Button()
        Me.txSolucio2 = New System.Windows.Forms.TextBox()
        Me.txProblema2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txID2 = New System.Windows.Forms.TextBox()
        Me.cmbEstat2 = New System.Windows.Forms.ComboBox()
        Me.txUsuari2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txDataActualitzacio2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txDataObertura2 = New System.Windows.Forms.TextBox()
        Me.dataGrid2 = New System.Windows.Forms.DataGridView()
        Me.GroupBuscar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBuscar
        '
        Me.GroupBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBuscar.Controls.Add(Me.Label10)
        Me.GroupBuscar.Controls.Add(Me.buscEstat2)
        Me.GroupBuscar.Controls.Add(Me.Label9)
        Me.GroupBuscar.Controls.Add(Me.buscDept2)
        Me.GroupBuscar.Controls.Add(Me.Cercador2)
        Me.GroupBuscar.Controls.Add(Me.TextData2)
        Me.GroupBuscar.Controls.Add(Me.LabelData)
        Me.GroupBuscar.Controls.Add(Me.TextUsuari2)
        Me.GroupBuscar.Controls.Add(Me.LabelUsuari)
        Me.GroupBuscar.Controls.Add(Me.buscadorId2)
        Me.GroupBuscar.Controls.Add(Me.LabelIdCas)
        Me.GroupBuscar.Location = New System.Drawing.Point(12, 4)
        Me.GroupBuscar.Name = "GroupBuscar"
        Me.GroupBuscar.Size = New System.Drawing.Size(978, 86)
        Me.GroupBuscar.TabIndex = 9
        Me.GroupBuscar.TabStop = False
        Me.GroupBuscar.Text = "Cercar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(472, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Estat"
        '
        'buscEstat2
        '
        Me.buscEstat2.FormattingEnabled = True
        Me.buscEstat2.Location = New System.Drawing.Point(550, 60)
        Me.buscEstat2.Name = "buscEstat2"
        Me.buscEstat2.Size = New System.Drawing.Size(126, 21)
        Me.buscEstat2.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(472, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Categoria"
        '
        'buscDept2
        '
        Me.buscDept2.FormattingEnabled = True
        Me.buscDept2.Location = New System.Drawing.Point(550, 19)
        Me.buscDept2.Name = "buscDept2"
        Me.buscDept2.Size = New System.Drawing.Size(126, 21)
        Me.buscDept2.TabIndex = 27
        '
        'Cercador2
        '
        Me.Cercador2.Location = New System.Drawing.Point(721, 26)
        Me.Cercador2.Name = "Cercador2"
        Me.Cercador2.Size = New System.Drawing.Size(136, 46)
        Me.Cercador2.TabIndex = 29
        Me.Cercador2.Text = "Buscar"
        Me.Cercador2.UseVisualStyleBackColor = True
        '
        'TextData2
        '
        Me.TextData2.Location = New System.Drawing.Point(324, 61)
        Me.TextData2.Name = "TextData2"
        Me.TextData2.Size = New System.Drawing.Size(118, 20)
        Me.TextData2.TabIndex = 28
        '
        'LabelData
        '
        Me.LabelData.AutoSize = True
        Me.LabelData.Location = New System.Drawing.Point(248, 64)
        Me.LabelData.Name = "LabelData"
        Me.LabelData.Size = New System.Drawing.Size(30, 13)
        Me.LabelData.TabIndex = 27
        Me.LabelData.Text = "Data"
        '
        'TextUsuari2
        '
        Me.TextUsuari2.Location = New System.Drawing.Point(324, 19)
        Me.TextUsuari2.Name = "TextUsuari2"
        Me.TextUsuari2.Size = New System.Drawing.Size(118, 20)
        Me.TextUsuari2.TabIndex = 26
        '
        'LabelUsuari
        '
        Me.LabelUsuari.AutoSize = True
        Me.LabelUsuari.Location = New System.Drawing.Point(248, 22)
        Me.LabelUsuari.Name = "LabelUsuari"
        Me.LabelUsuari.Size = New System.Drawing.Size(37, 13)
        Me.LabelUsuari.TabIndex = 25
        Me.LabelUsuari.Text = "Usuari"
        '
        'buscadorId2
        '
        Me.buscadorId2.Location = New System.Drawing.Point(96, 19)
        Me.buscadorId2.Name = "buscadorId2"
        Me.buscadorId2.Size = New System.Drawing.Size(118, 20)
        Me.buscadorId2.TabIndex = 22
        '
        'LabelIdCas
        '
        Me.LabelIdCas.AutoSize = True
        Me.LabelIdCas.Location = New System.Drawing.Point(9, 22)
        Me.LabelIdCas.Name = "LabelIdCas"
        Me.LabelIdCas.Size = New System.Drawing.Size(81, 13)
        Me.LabelIdCas.TabIndex = 21
        Me.LabelIdCas.Text = "Número del cas"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.cmbAssignat2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.bt_informe2)
        Me.GroupBox1.Controls.Add(Me.prioritat)
        Me.GroupBox1.Controls.Add(Me.cmbState2)
        Me.GroupBox1.Controls.Add(Me.categoria)
        Me.GroupBox1.Controls.Add(Me.cmbTipus2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txNomPacient2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btAccioActualitzar2)
        Me.GroupBox1.Controls.Add(Me.txSolucio2)
        Me.GroupBox1.Controls.Add(Me.txProblema2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txID2)
        Me.GroupBox1.Controls.Add(Me.cmbEstat2)
        Me.GroupBox1.Controls.Add(Me.txUsuari2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txDataActualitzacio2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txDataObertura2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 303)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(975, 194)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dades del problema"
        '
        'cmbAssignat2
        '
        Me.cmbAssignat2.AutoCompleteCustomSource.AddRange(New String() {"Actiu", "Solucionat"})
        Me.cmbAssignat2.DisplayMember = "Joan,Sergi,Jordi"
        Me.cmbAssignat2.FormattingEnabled = True
        Me.cmbAssignat2.Location = New System.Drawing.Point(877, 37)
        Me.cmbAssignat2.Name = "cmbAssignat2"
        Me.cmbAssignat2.Size = New System.Drawing.Size(89, 21)
        Me.cmbAssignat2.TabIndex = 29
        Me.cmbAssignat2.ValueMember = "Joan,Sergi,Jordi"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(885, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Assignada a"
        '
        'bt_informe2
        '
        Me.bt_informe2.Location = New System.Drawing.Point(877, 95)
        Me.bt_informe2.Name = "bt_informe2"
        Me.bt_informe2.Size = New System.Drawing.Size(81, 89)
        Me.bt_informe2.TabIndex = 27
        Me.bt_informe2.Text = "Crear informe"
        Me.bt_informe2.UseVisualStyleBackColor = True
        '
        'prioritat
        '
        Me.prioritat.AutoSize = True
        Me.prioritat.Location = New System.Drawing.Point(634, 59)
        Me.prioritat.Name = "prioritat"
        Me.prioritat.Size = New System.Drawing.Size(42, 13)
        Me.prioritat.TabIndex = 26
        Me.prioritat.Text = "Prioritat"
        '
        'cmbState2
        '
        Me.cmbState2.FormattingEnabled = True
        Me.cmbState2.Location = New System.Drawing.Point(81, 48)
        Me.cmbState2.Name = "cmbState2"
        Me.cmbState2.Size = New System.Drawing.Size(133, 21)
        Me.cmbState2.TabIndex = 25
        '
        'categoria
        '
        Me.categoria.AutoSize = True
        Me.categoria.Location = New System.Drawing.Point(634, 22)
        Me.categoria.Name = "categoria"
        Me.categoria.Size = New System.Drawing.Size(52, 13)
        Me.categoria.TabIndex = 24
        Me.categoria.Text = "Categoria"
        '
        'cmbTipus2
        '
        Me.cmbTipus2.FormattingEnabled = True
        Me.cmbTipus2.Location = New System.Drawing.Point(700, 18)
        Me.cmbTipus2.Name = "cmbTipus2"
        Me.cmbTipus2.Size = New System.Drawing.Size(138, 21)
        Me.cmbTipus2.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(453, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Hora"
        '
        'txNomPacient2
        '
        Me.txNomPacient2.Enabled = False
        Me.txNomPacient2.Location = New System.Drawing.Point(523, 52)
        Me.txNomPacient2.Name = "txNomPacient2"
        Me.txNomPacient2.Size = New System.Drawing.Size(92, 20)
        Me.txNomPacient2.TabIndex = 15
        Me.txNomPacient2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(343, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Solució / Comentaris"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Problema"
        '
        'btAccioActualitzar2
        '
        Me.btAccioActualitzar2.Location = New System.Drawing.Point(748, 95)
        Me.btAccioActualitzar2.Name = "btAccioActualitzar2"
        Me.btAccioActualitzar2.Size = New System.Drawing.Size(90, 89)
        Me.btAccioActualitzar2.TabIndex = 12
        Me.btAccioActualitzar2.Text = "Actualitzar"
        Me.btAccioActualitzar2.UseVisualStyleBackColor = True
        '
        'txSolucio2
        '
        Me.txSolucio2.Location = New System.Drawing.Point(346, 95)
        Me.txSolucio2.Multiline = True
        Me.txSolucio2.Name = "txSolucio2"
        Me.txSolucio2.Size = New System.Drawing.Size(330, 90)
        Me.txSolucio2.TabIndex = 11
        '
        'txProblema2
        '
        Me.txProblema2.Location = New System.Drawing.Point(16, 95)
        Me.txProblema2.Multiline = True
        Me.txProblema2.Name = "txProblema2"
        Me.txProblema2.Size = New System.Drawing.Size(290, 90)
        Me.txProblema2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Estat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Número del cas"
        '
        'txID2
        '
        Me.txID2.Enabled = False
        Me.txID2.Location = New System.Drawing.Point(329, 48)
        Me.txID2.Name = "txID2"
        Me.txID2.Size = New System.Drawing.Size(118, 20)
        Me.txID2.TabIndex = 7
        Me.txID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbEstat2
        '
        Me.cmbEstat2.AutoCompleteCustomSource.AddRange(New String() {"Actiu", "Solucionat"})
        Me.cmbEstat2.DisplayMember = "Critica,Alta,Mitjana,Baixa"
        Me.cmbEstat2.FormattingEnabled = True
        Me.cmbEstat2.Location = New System.Drawing.Point(700, 56)
        Me.cmbEstat2.Name = "cmbEstat2"
        Me.cmbEstat2.Size = New System.Drawing.Size(138, 21)
        Me.cmbEstat2.TabIndex = 6
        Me.cmbEstat2.ValueMember = "Critica,Alta,Mitjana,Baixa"
        '
        'txUsuari2
        '
        Me.txUsuari2.Enabled = False
        Me.txUsuari2.Location = New System.Drawing.Point(523, 18)
        Me.txUsuari2.Name = "txUsuari2"
        Me.txUsuari2.Size = New System.Drawing.Size(92, 20)
        Me.txUsuari2.TabIndex = 5
        Me.txUsuari2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(453, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Solicitant"
        '
        'txDataActualitzacio2
        '
        Me.txDataActualitzacio2.Enabled = False
        Me.txDataActualitzacio2.Location = New System.Drawing.Point(327, 19)
        Me.txDataActualitzacio2.Name = "txDataActualitzacio2"
        Me.txDataActualitzacio2.Size = New System.Drawing.Size(120, 20)
        Me.txDataActualitzacio2.TabIndex = 3
        Me.txDataActualitzacio2.Text = "00/00/0000"
        Me.txDataActualitzacio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Darrera actualització"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data de la incidència"
        '
        'txDataObertura2
        '
        Me.txDataObertura2.Enabled = False
        Me.txDataObertura2.Location = New System.Drawing.Point(135, 18)
        Me.txDataObertura2.Name = "txDataObertura2"
        Me.txDataObertura2.Size = New System.Drawing.Size(76, 20)
        Me.txDataObertura2.TabIndex = 0
        Me.txDataObertura2.Text = "00/00/0000"
        Me.txDataObertura2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dataGrid2
        '
        Me.dataGrid2.AllowUserToAddRows = False
        Me.dataGrid2.AllowUserToDeleteRows = False
        Me.dataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGrid2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.dataGrid2.CausesValidation = False
        Me.dataGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGrid2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGrid2.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataGrid2.Location = New System.Drawing.Point(3, 96)
        Me.dataGrid2.Name = "dataGrid2"
        Me.dataGrid2.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGrid2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGrid2.Size = New System.Drawing.Size(966, 201)
        Me.dataGrid2.TabIndex = 7
        '
        'frmPeticio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(973, 498)
        Me.Controls.Add(Me.GroupBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dataGrid2)
        Me.Name = "frmPeticio"
        Me.Text = "Formulari petició"
        Me.GroupBuscar.ResumeLayout(False)
        Me.GroupBuscar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBuscar As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents buscEstat2 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents buscDept2 As ComboBox
    Friend WithEvents Cercador2 As Button
    Friend WithEvents TextData2 As TextBox
    Friend WithEvents LabelData As Label
    Friend WithEvents TextUsuari2 As TextBox
    Friend WithEvents LabelUsuari As Label
    Friend WithEvents buscadorId2 As TextBox
    Friend WithEvents LabelIdCas As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbAssignat2 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents bt_informe2 As Button
    Friend WithEvents prioritat As Label
    Friend WithEvents cmbState2 As ComboBox
    Friend WithEvents categoria As Label
    Friend WithEvents cmbTipus2 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txNomPacient2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btAccioActualitzar2 As Button
    Friend WithEvents txSolucio2 As TextBox
    Friend WithEvents txProblema2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txID2 As TextBox
    Friend WithEvents cmbEstat2 As ComboBox
    Friend WithEvents txUsuari2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txDataActualitzacio2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txDataObertura2 As TextBox
    Friend WithEvents dataGrid2 As DataGridView
End Class
