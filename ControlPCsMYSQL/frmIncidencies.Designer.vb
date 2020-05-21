<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIncidencies
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbAssignat = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bt_informe = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.prioritat = New System.Windows.Forms.Label()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.categoria = New System.Windows.Forms.Label()
        Me.cmbTipus = New System.Windows.Forms.ComboBox()
        Me.txNomPacient = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btAccioActualitzar = New System.Windows.Forms.Button()
        Me.txSolucio = New System.Windows.Forms.TextBox()
        Me.txProblema = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txID = New System.Windows.Forms.TextBox()
        Me.cmbEstat = New System.Windows.Forms.ComboBox()
        Me.txUsuari = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txDataActualitzacio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txDataObertura = New System.Windows.Forms.TextBox()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBuscar = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.buscEstat = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.buscDept = New System.Windows.Forms.ComboBox()
        Me.Cercador = New System.Windows.Forms.Button()
        Me.TextData = New System.Windows.Forms.TextBox()
        Me.LabelData = New System.Windows.Forms.Label()
        Me.TextUsuari = New System.Windows.Forms.TextBox()
        Me.LabelUsuari = New System.Windows.Forms.Label()
        Me.TextPC = New System.Windows.Forms.TextBox()
        Me.LabelPC = New System.Windows.Forms.Label()
        Me.buscadorId = New System.Windows.Forms.TextBox()
        Me.LabelIdCas = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.cmbAssignat)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.bt_informe)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.prioritat)
        Me.GroupBox1.Controls.Add(Me.cmbState)
        Me.GroupBox1.Controls.Add(Me.categoria)
        Me.GroupBox1.Controls.Add(Me.cmbTipus)
        Me.GroupBox1.Controls.Add(Me.txNomPacient)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btAccioActualitzar)
        Me.GroupBox1.Controls.Add(Me.txSolucio)
        Me.GroupBox1.Controls.Add(Me.txProblema)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txID)
        Me.GroupBox1.Controls.Add(Me.cmbEstat)
        Me.GroupBox1.Controls.Add(Me.txUsuari)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txDataActualitzacio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txDataObertura)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(987, 194)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dades del problema"
        '
        'cmbAssignat
        '
        Me.cmbAssignat.AutoCompleteCustomSource.AddRange(New String() {"Actiu", "Solucionat"})
        Me.cmbAssignat.DisplayMember = "Joan,Sergi,Jordi"
        Me.cmbAssignat.FormattingEnabled = True
        Me.cmbAssignat.Location = New System.Drawing.Point(877, 37)
        Me.cmbAssignat.Name = "cmbAssignat"
        Me.cmbAssignat.Size = New System.Drawing.Size(89, 21)
        Me.cmbAssignat.TabIndex = 29
        Me.cmbAssignat.ValueMember = "Joan,Sergi,Jordi"
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
        'bt_informe
        '
        Me.bt_informe.Location = New System.Drawing.Point(877, 95)
        Me.bt_informe.Name = "bt_informe"
        Me.bt_informe.Size = New System.Drawing.Size(81, 89)
        Me.bt_informe.TabIndex = 27
        Me.bt_informe.Text = "Crear informe"
        Me.bt_informe.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(453, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Solicitant"
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
        'cmbState
        '
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Location = New System.Drawing.Point(81, 48)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(133, 21)
        Me.cmbState.TabIndex = 25
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
        'cmbTipus
        '
        Me.cmbTipus.FormattingEnabled = True
        Me.cmbTipus.Location = New System.Drawing.Point(700, 18)
        Me.cmbTipus.Name = "cmbTipus"
        Me.cmbTipus.Size = New System.Drawing.Size(138, 21)
        Me.cmbTipus.TabIndex = 23
        '
        'txNomPacient
        '
        Me.txNomPacient.Enabled = False
        Me.txNomPacient.Location = New System.Drawing.Point(523, 52)
        Me.txNomPacient.Name = "txNomPacient"
        Me.txNomPacient.Size = New System.Drawing.Size(92, 20)
        Me.txNomPacient.TabIndex = 15
        Me.txNomPacient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'btAccioActualitzar
        '
        Me.btAccioActualitzar.Location = New System.Drawing.Point(748, 95)
        Me.btAccioActualitzar.Name = "btAccioActualitzar"
        Me.btAccioActualitzar.Size = New System.Drawing.Size(90, 89)
        Me.btAccioActualitzar.TabIndex = 12
        Me.btAccioActualitzar.Text = "Actualitzar"
        Me.btAccioActualitzar.UseVisualStyleBackColor = True
        '
        'txSolucio
        '
        Me.txSolucio.Location = New System.Drawing.Point(346, 95)
        Me.txSolucio.Multiline = True
        Me.txSolucio.Name = "txSolucio"
        Me.txSolucio.Size = New System.Drawing.Size(330, 90)
        Me.txSolucio.TabIndex = 11
        '
        'txProblema
        '
        Me.txProblema.Location = New System.Drawing.Point(16, 95)
        Me.txProblema.Multiline = True
        Me.txProblema.Name = "txProblema"
        Me.txProblema.Size = New System.Drawing.Size(290, 90)
        Me.txProblema.TabIndex = 10
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
        'txID
        '
        Me.txID.Enabled = False
        Me.txID.Location = New System.Drawing.Point(329, 48)
        Me.txID.Name = "txID"
        Me.txID.Size = New System.Drawing.Size(118, 20)
        Me.txID.TabIndex = 7
        Me.txID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbEstat
        '
        Me.cmbEstat.AutoCompleteCustomSource.AddRange(New String() {"Actiu", "Solucionat"})
        Me.cmbEstat.DisplayMember = "Critica,Alta,Mitjana,Baixa"
        Me.cmbEstat.FormattingEnabled = True
        Me.cmbEstat.Location = New System.Drawing.Point(700, 56)
        Me.cmbEstat.Name = "cmbEstat"
        Me.cmbEstat.Size = New System.Drawing.Size(138, 21)
        Me.cmbEstat.TabIndex = 6
        Me.cmbEstat.ValueMember = "Critica,Alta,Mitjana,Baixa"
        '
        'txUsuari
        '
        Me.txUsuari.Enabled = False
        Me.txUsuari.Location = New System.Drawing.Point(523, 18)
        Me.txUsuari.Name = "txUsuari"
        Me.txUsuari.Size = New System.Drawing.Size(92, 20)
        Me.txUsuari.TabIndex = 5
        Me.txUsuari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(453, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ordinador"
        '
        'txDataActualitzacio
        '
        Me.txDataActualitzacio.Enabled = False
        Me.txDataActualitzacio.Location = New System.Drawing.Point(327, 19)
        Me.txDataActualitzacio.Name = "txDataActualitzacio"
        Me.txDataActualitzacio.Size = New System.Drawing.Size(120, 20)
        Me.txDataActualitzacio.TabIndex = 3
        Me.txDataActualitzacio.Text = "00/00/0000"
        Me.txDataActualitzacio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'txDataObertura
        '
        Me.txDataObertura.Enabled = False
        Me.txDataObertura.Location = New System.Drawing.Point(135, 18)
        Me.txDataObertura.Name = "txDataObertura"
        Me.txDataObertura.Size = New System.Drawing.Size(76, 20)
        Me.txDataObertura.TabIndex = 0
        Me.txDataObertura.Text = "00/00/0000"
        Me.txDataObertura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.AllowUserToDeleteRows = False
        Me.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.dataGrid.CausesValidation = False
        Me.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataGrid.Location = New System.Drawing.Point(12, 108)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGrid.Size = New System.Drawing.Size(987, 166)
        Me.dataGrid.TabIndex = 4
        '
        'GroupBuscar
        '
        Me.GroupBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBuscar.Controls.Add(Me.Label10)
        Me.GroupBuscar.Controls.Add(Me.buscEstat)
        Me.GroupBuscar.Controls.Add(Me.Label9)
        Me.GroupBuscar.Controls.Add(Me.buscDept)
        Me.GroupBuscar.Controls.Add(Me.Cercador)
        Me.GroupBuscar.Controls.Add(Me.TextData)
        Me.GroupBuscar.Controls.Add(Me.LabelData)
        Me.GroupBuscar.Controls.Add(Me.TextUsuari)
        Me.GroupBuscar.Controls.Add(Me.LabelUsuari)
        Me.GroupBuscar.Controls.Add(Me.TextPC)
        Me.GroupBuscar.Controls.Add(Me.LabelPC)
        Me.GroupBuscar.Controls.Add(Me.buscadorId)
        Me.GroupBuscar.Controls.Add(Me.LabelIdCas)
        Me.GroupBuscar.Location = New System.Drawing.Point(12, 13)
        Me.GroupBuscar.Name = "GroupBuscar"
        Me.GroupBuscar.Size = New System.Drawing.Size(987, 89)
        Me.GroupBuscar.TabIndex = 6
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
        'buscEstat
        '
        Me.buscEstat.FormattingEnabled = True
        Me.buscEstat.Location = New System.Drawing.Point(550, 60)
        Me.buscEstat.Name = "buscEstat"
        Me.buscEstat.Size = New System.Drawing.Size(126, 21)
        Me.buscEstat.TabIndex = 30
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
        'buscDept
        '
        Me.buscDept.FormattingEnabled = True
        Me.buscDept.Location = New System.Drawing.Point(550, 19)
        Me.buscDept.Name = "buscDept"
        Me.buscDept.Size = New System.Drawing.Size(126, 21)
        Me.buscDept.TabIndex = 27
        '
        'Cercador
        '
        Me.Cercador.Location = New System.Drawing.Point(721, 26)
        Me.Cercador.Name = "Cercador"
        Me.Cercador.Size = New System.Drawing.Size(136, 46)
        Me.Cercador.TabIndex = 29
        Me.Cercador.Text = "Buscar"
        Me.Cercador.UseVisualStyleBackColor = True
        '
        'TextData
        '
        Me.TextData.Location = New System.Drawing.Point(324, 61)
        Me.TextData.Name = "TextData"
        Me.TextData.Size = New System.Drawing.Size(118, 20)
        Me.TextData.TabIndex = 28
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
        'TextUsuari
        '
        Me.TextUsuari.Location = New System.Drawing.Point(324, 19)
        Me.TextUsuari.Name = "TextUsuari"
        Me.TextUsuari.Size = New System.Drawing.Size(118, 20)
        Me.TextUsuari.TabIndex = 26
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
        'TextPC
        '
        Me.TextPC.Location = New System.Drawing.Point(96, 61)
        Me.TextPC.Name = "TextPC"
        Me.TextPC.Size = New System.Drawing.Size(118, 20)
        Me.TextPC.TabIndex = 24
        '
        'LabelPC
        '
        Me.LabelPC.AutoSize = True
        Me.LabelPC.Location = New System.Drawing.Point(9, 64)
        Me.LabelPC.Name = "LabelPC"
        Me.LabelPC.Size = New System.Drawing.Size(33, 13)
        Me.LabelPC.TabIndex = 23
        Me.LabelPC.Text = "Id PC"
        '
        'buscadorId
        '
        Me.buscadorId.Location = New System.Drawing.Point(96, 19)
        Me.buscadorId.Name = "buscadorId"
        Me.buscadorId.Size = New System.Drawing.Size(118, 20)
        Me.buscadorId.TabIndex = 22
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
        'frmIncidencies
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1011, 556)
        Me.Controls.Add(Me.GroupBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dataGrid)
        Me.Name = "frmIncidencies"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulari Inccidències"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBuscar.ResumeLayout(False)
        Me.GroupBuscar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txNomPacient As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btAccioActualitzar As Button
    Friend WithEvents txSolucio As TextBox
    Friend WithEvents txProblema As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txID As TextBox
    Friend WithEvents cmbEstat As ComboBox
    Friend WithEvents txUsuari As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txDataActualitzacio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txDataObertura As TextBox
    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents GroupBuscar As GroupBox
    Friend WithEvents Cercador As Button
    Friend WithEvents TextData As TextBox
    Friend WithEvents LabelData As Label
    Friend WithEvents TextUsuari As TextBox
    Friend WithEvents LabelUsuari As Label
    Friend WithEvents TextPC As TextBox
    Friend WithEvents LabelPC As Label
    Friend WithEvents buscadorId As TextBox
    Friend WithEvents LabelIdCas As Label
    Friend WithEvents prioritat As Label
    Friend WithEvents cmbState As ComboBox
    Friend WithEvents categoria As Label
    Friend WithEvents cmbTipus As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents buscDept As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents buscEstat As ComboBox
    Friend WithEvents bt_informe As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbAssignat As ComboBox
End Class
