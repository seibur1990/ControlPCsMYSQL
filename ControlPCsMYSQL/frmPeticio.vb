Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class frmPeticio

    Public numCas As String
    Public idPC As String
    Public usuari As String
    Public data As String
    Public dept As String
    Public estat As String
    Public assignat As String

    Private Sub frmIncidencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbAssignat2.DisplayMember = ""
        cmbAssignat2.Items.Add("")
        cmbAssignat2.Items.Insert(1, "Joan")
        cmbAssignat2.Items.Insert(2, "Sergi")
        cmbAssignat2.Items.Insert(3, "Jordi")


        cmbEstat2.DisplayMember = ""
        cmbEstat2.Items.Add("")
        cmbEstat2.Items.Insert(1, "Critica")
        cmbEstat2.Items.Insert(2, "Alta")
        cmbEstat2.Items.Insert(3, "Mitjana")
        cmbEstat2.Items.Insert(4, "Baixa")

        cmbTipus2.DisplayMember = ""
        cmbTipus2.Items.Add("")
        cmbTipus2.Items.Insert(1, "Nova campaña")
        cmbTipus2.Items.Insert(2, "Depurar base de dades")
        cmbTipus2.Items.Insert(3, "Creació / modificació scripts")
        cmbTipus2.Items.Insert(4, "Creació / modificació consultes")
        cmbTipus2.Items.Insert(5, "Creació / modificació informes")
        cmbTipus2.Items.Insert(6, "Gestió de registros")
        cmbTipus2.Items.Insert(7, "Retornar base de dades")

        buscDept2.DisplayMember = ""
        buscDept2.Items.Add("")
        buscDept2.Items.Insert(1, "Nova campaña")
        buscDept2.Items.Insert(2, "Depurar base de dades")
        buscDept2.Items.Insert(3, "Creació / modificació scripts")
        buscDept2.Items.Insert(4, "Creació / modificació consultes")
        buscDept2.Items.Insert(5, "Creació / modificació informes")
        buscDept2.Items.Insert(6, "Gestió de registros")
        buscDept2.Items.Insert(7, "Retornar base de dades")

        cmbState2.DisplayMember = ""
        cmbState2.Items.Add("")
        cmbState2.Items.Insert(1, "Oberta")
        cmbState2.Items.Insert(2, "Tancada")
        cmbState2.Items.Insert(3, "Treballant-hi")
        cmbState2.Items.Insert(4, "Tancada Incompleta")
        cmbState2.Items.Insert(5, "Tancada Completa")
        cmbState2.Items.Insert(6, "Tancada Traspassada")
        cmbState2.Items.Insert(7, "Resolta")

        buscEstat2.DisplayMember = ""
        buscEstat2.Items.Add("")
        buscEstat2.Items.Insert(1, "Oberta")
        buscEstat2.Items.Insert(2, "Tancada")
        buscEstat2.Items.Insert(3, "Treballant-hi")
        buscEstat2.Items.Insert(4, "Tancada Incompleta")
        buscEstat2.Items.Insert(5, "Tancada Completa")
        buscEstat2.Items.Insert(6, "Tancada Traspassada")
        buscEstat2.Items.Insert(7, "Resolta")
        comu.llistarPeticionsUSR()

    End Sub


    Sub updatePeticio()

        Dim id2 As String = txID2.Text
        Dim problema2 As String = "'" + txProblema2.Text + "'"
        Dim solucio2 As String = "'" + txSolucio2.Text + "'"
        Dim g2 As Integer = cmbEstat2.SelectedIndex
        Dim grau2 As String = "'" + g2.ToString + "'"         ' Critic, alta, mitjana i baixa
        g2 = cmbState2.SelectedIndex
        Dim estat2 As String = "'" + g2.ToString + "'"        ' Oberta, Resolta...
        g2 = cmbTipus2.SelectedIndex
        Dim dept2 As String = "'" + g2.ToString + "'"          'Aplicatiu, correu ...
        g2 = cmbAssignat2.SelectedIndex
        Dim assignat2 As String = "'" + g2.ToString + "'"

        Dim consulta As String
        Dim conSQL2 As SqlConnection

        Try
            consulta = "UPDATE peticio SET solucio = " + solucio2 + ", problema = " + problema2 + ",  darrera_ullada = convert(varchar, getdate(),3), darrera_ullada_hora = convert(varchar, getdate(), 108), id_prioritat = " + grau2 + ", estat = " + estat2 + ", id_cat = " + dept2 + ", assignada = " + assignat2 + " WHERE LTRIM(STR(id_peticio, 25, 0)) LIKE '" + id2 + "'"  'actualitzar solucio darrera ullada dia i hora 
            '108 darrera ullada antes era 23
            conSQL2 = conectarSQLSERVER2()
            Dim myCommand As New SqlCommand(consulta, conSQL2)
            myCommand.ExecuteNonQuery()
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
        Catch ex1 As InvalidCastException
            MsgBox("Error " & ex1.Message)
        End Try
        comu.llistarPeticionsUSR()
    End Sub

    Function comprobarBusc()

        numCas = buscadorId2.Text
        usuari = TextUsuari2.Text
        data = TextData2.Text
        dept = buscDept2.SelectedIndex.ToString

        If dept = "-1" Then
            dept = ""
        End If

        estat = buscEstat2.SelectedIndex.ToString
        If estat = "-1" Then
            estat = ""
        End If

        If (numCas = "" Or numCas = Nothing) And (usuari = "" Or usuari = Nothing) And (data = "" Or data = Nothing) And (dept = "" Or dept = Nothing) And (estat = "" Or estat = Nothing) Then
            Return False                                                    ' vbempty testeado       Or usuari = Nothing   testeado           
        Else
            Return True
        End If

    End Function

    Sub Buscar()

        numCas = buscadorId2.Text
        'idPC = TextPC.Text
        usuari = TextUsuari2.Text
        data = TextData2.Text
        dept = buscDept2.SelectedIndex.ToString
        estat = buscEstat2.SelectedIndex.ToString

        If dept = "-1" Or dept = Nothing Then
            dept = ""
        End If

        If estat = "-1" Or estat = Nothing Then
            estat = ""
        End If


        Dim x As Boolean = False
        Dim y As Boolean = False
        If numCas = "" And usuari = "" And data = "" Then
            x = True
        End If
        If dept = "0" Then
            dept = ""
            y = True
        End If
        If estat = "0" Then
            estat = ""
            y = True
        End If

        If x = True And y = True And dept = "" And estat = "" Then        '(dept = "0" And estat = "") Or (dept = "" And estat = "0") Or (dept = "0" & estat = "0")
            comu.llistarPeticionsUSR()
            x = False
            Exit Sub
        End If
        '   MsgBox("dept " & dept + " estat " + estat)

        Dim condicion As String = ""
        Dim SQL As String
        Dim Reader As SqlDataReader = Nothing
        Dim conSQL2 As SqlConnection

        If numCas <> DBNull.Value.ToString Then
            'Construim la sentencia SQL i les condicions.   LTRIM(STR(id_incidencia, 25, 5))
            If condicion <> DBNull.Value.ToString Then
                condicion = condicion & " AND LTRIM(STR(id_peticio, 25, 0)) LIKE '" & numCas & "%'"
                SQL = "SELECT id_peticio, usr, data, hora, problema, id_cat, estat, assignada FROM peticio " & condicion
            Else
                condicion = " WHERE LTRIM(STR(id_peticio, 25, 0)) LIKE '" & numCas & "%'"
                SQL = "SELECT id_peticio, usr, data, hora, problema, id_cat, estat, assignada FROM peticio " & condicion
            End If
        End If

        If usuari <> DBNull.Value.ToString Then
            'Construim la sentencia SQL i les condicions.
            If condicion <> DBNull.Value.ToString Then
                condicion = condicion & " AND usr LIKE '" & usuari & "%'"
                SQL = "SELECT id_peticio, usr, data, hora, problema,  id_cat, estat, assignada FROM peticio " & condicion
            Else
                condicion = "WHERE usr LIKE '" & usuari & "%'"
                SQL = "SELECT id_peticio, usr, data, hora,  problema, id_cat, estat, assignada FROM peticio " & condicion
            End If
        End If

        If data <> DBNull.Value.ToString Then
            'Construim la sentencia SQL i les condicions.
            If condicion <> DBNull.Value.ToString Then
                condicion = condicion & " AND data LIKE '" & data & "%'"
                SQL = "SELECT id_peticio, usr, data, hora, problema, id_cat, estat, assignada FROM peticio " & condicion
            Else
                condicion = "WHERE data LIKE '" & data & "%'"
                SQL = "SELECT id_peticio, usr, data, hora, problema, id_cat, estat, assignada FROM peticio " & condicion
            End If
        End If
        If dept <> DBNull.Value.ToString Then
            'dept <> "" then
            'Construim la sentencia SQL i les condicions.
            If condicion <> DBNull.Value.ToString Then
                condicion = condicion & " AND id_cat LIKE '" & dept & "'"
                SQL = "SELECT id_peticio, usr, data, hora, problema, id_cat, estat, assignada FROM peticio " & condicion
            Else
                condicion = " WHERE id_cat LIKE '" & dept & "'"
                SQL = "SELECT id_peticio, usr, data, hora, problema, id_cat, estat, assignada FROM peticio " & condicion
            End If
        End If
        If estat <> DBNull.Value.ToString Then
            'Construim la sentencia SQL i les condicions.
            If condicion <> DBNull.Value.ToString Then
                condicion = condicion & " AND estat LIKE '" & estat & "'"
                SQL = "SELECT id_peticio, usr, data, hora, problema, id_cat, estat, assignada FROM peticio " & condicion
            Else
                condicion = " WHERE estat LIKE '" & estat & "'"
                SQL = "SELECT id_peticio, usr, data, hora, problema, id_cat, estat, assignada FROM peticio " & condicion
            End If
        End If
        Dim categoria As String
        Dim estat1 As String
        Dim assignada1 As String

        Try
            conSQL2 = conectarSQLSERVER2()

            dataGrid2.Rows.Clear()
            Dim consulta As New SqlCommand(SQL, conSQL2)
            ' conSQL.Open()
            Reader = consulta.ExecuteReader


            Dim fila As String() = New String() {"", "", "", "", "", "", "", "", ""}
            While Reader.Read()
                fila(0) = Reader.GetDouble(0) ' id
                fila(1) = Reader.GetString(1) ' roger
                'fila(1) = Reader.GetString(1)
                fila(2) = Reader.GetString(2) ' fecha
                fila(3) = Reader.GetString(3) ' descripcion/problema
                fila(4) = Reader.GetString(4) '  solucio hora
                fila(5) = Reader.GetString(5)

                Select Case Reader.GetString(5)  ' peticio roguer cojer un 6 en categoria    pero en base de datos es ESTAT
                    Case "1"
                        categoria = "Aplicatius"
                    Case "2"
                        categoria = "Correo Electrònic"
                    Case "3"
                        categoria = "Evolution Manager"
                    Case "4"
                        categoria = "Hardrware PC's"
                    Case "5"
                        categoria = "Impressora"
                    Case "6"
                        categoria = "Informes"
                    Case "7"
                        categoria = "Servidors"
                    Case "8"
                        categoria = "Telefonia"
                    Case "9"
                        categoria = "Xarxa"
                End Select
                fila(5) = categoria

                fila(6) = Reader.GetString(6)
                Select Case Reader.GetString(6) '' id_cat  otro 6 
                    Case "1"
                        estat1 = "Oberta"
                    Case "2"
                        estat1 = "Tancada"
                    Case "3"
                        estat1 = "Treballant-hi"
                    Case "4"
                        estat1 = "Tancada Incompleta"
                    Case "5"
                        estat1 = "Tancada Completa"
                    Case "6"
                        estat1 = "Tancada Traspassada"
                    Case "7"
                        estat1 = "Resolta"

                End Select

                fila(6) = estat1

                'fila(8) = Reader.GetString(8)
                Select Case Reader.GetString(7)
                    Case "0"
                        assignada1 = "Sense assignar"
                    Case "1"
                        assignada1 = "Joan"
                    Case "2"
                        assignada1 = "Sergi"
                    Case "3"
                        assignada1 = "Jordi"

                End Select
                fila(7) = assignada1

                dataGrid2.Rows.Add(fila)
                '    Dim table10 As New DataTable
                '  DataBindings.DefaultDataSourceUpdateMode.ToObject(table10)
            End While
            Reader.Close()
            conSQL2.Close()
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
        Catch e As InvalidCastException
            MsgBox("Error " & e.Message)
        End Try
        Exit Sub
    End Sub

    Private Sub TextUsuari_TextChanged(sender As Object, e As EventArgs) Handles TextUsuari2.TextChanged
        Dim x As Boolean = comprobarBusc()
        If x = True Then
            Buscar()
        Else
            comu.llistarPeticionsUSR()
        End If
    End Sub

    Private Sub TextData_TextChanged(sender As Object, e As EventArgs) Handles TextData2.TextChanged
        Dim x As Boolean = comprobarBusc()
        If x = True Then
            Buscar()
        Else
            comu.llistarPeticionsUSR()
        End If
    End Sub

    Private Sub buscadorId_TextChanged(sender As Object, e As EventArgs) Handles buscadorId2.TextChanged
        Dim x As Boolean = comprobarBusc()
        If x = True Then
            Buscar()
        Else
            comu.llistarPeticionsUSR()
        End If
    End Sub
    Private Sub dataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGrid2.CellContentClick

    End Sub

    Private Sub buscDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles buscDept2.SelectedIndexChanged
        Dim x As Boolean = comprobarBusc()
        If x = True Then
            Buscar()
        Else
            comu.llistarPeticionsUSR()
        End If
    End Sub

    Private Sub buscDept_TextChanged(sender As Object, e As EventArgs) Handles buscDept2.TextChanged
        Dim x As Boolean = comprobarBusc()
        If x = True Then
            Buscar()
        Else
            comu.llistarPeticionsUSR()
        End If
    End Sub

    Private Sub buscEstat_TextChanged(sender As Object, e As EventArgs) Handles buscEstat2.TextChanged
        Dim x As Boolean = comprobarBusc()
        If x = True Then
            Buscar()
        Else
            comu.llistarPeticionsUSR()
        End If
    End Sub

    Private Sub buscEstat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles buscEstat2.SelectedIndexChanged
        Dim x As Boolean = comprobarBusc()
        If x = True Then
            Buscar()
        Else
            comu.llistarPeticionsUSR()
        End If
    End Sub

    Private Sub dataGrid_Click(sender As Object, e As EventArgs) Handles dataGrid2.Click

        Dim fila As String() = New String() {"", "", "", "", "", "", "", ""}
        Dim consulta As String
        Dim idI2 As String

        If dataGrid2.CurrentRow Is Nothing Then
            Return
        Else
            If dataGrid2.CurrentRow.Index >= 0 Then ' agafa dades de la fila seleccionada de la taula per mostrarles al datagridview
                Try

                    txID2.Text = dataGrid2.Rows(dataGrid2.CurrentRow.Index).Cells(0).Value.ToString ' ES FLOAT 
                    'txNomPacient2.Text = dataGrid2.Rows(dataGrid2.CurrentRow.Index).Cells(3).Value.ToString ' donde tendria que poner darrera ullada
                    txUsuari2.Text = dataGrid2.Rows(dataGrid2.CurrentRow.Index).Cells(1).Value.ToString
                    txDataObertura2.Text = dataGrid2.Rows(dataGrid2.CurrentRow.Index).Cells(2).Value.ToString
                    txProblema2.Text = dataGrid2.Rows(dataGrid2.CurrentRow.Index).Cells(4).Value.ToString '
                    'txSolucio2.Text = dataGrid2.Rows(dataGrid2.CurrentRow.Index).Cells(5).Value.ToString
                    cmbAssignat2.Text = dataGrid2.Rows(dataGrid2.CurrentRow.Index).Cells(7).Value.ToString ' ESTADO
                    cmbTipus2.Text = dataGrid2.Rows(dataGrid2.CurrentRow.Index).Cells(5).Value.ToString  ' 6 = estat
                    cmbState2.Text = dataGrid2.Rows(dataGrid2.CurrentRow.Index).Cells(6).Value.ToString

                    idI2 = txID2.Text
                    conSQL2 = conectarSQLSERVER2()

                    'antigua ' consulta = "SELECT  darrera_ullada, solucio, id_prioritat FROM incidencies WHERE id_incidencia = " + idI + "ORDER BY data DESC, hora DESC"
                    consulta = "SELECT  darrera_ullada_hora, id_prioritat, id_cat,estat, assignada FROM peticio WHERE id_peticio = '" + idI2 + "'" ' ORDER BY data DESC, hora DESC"

                    Dim myCommand As New SqlCommand(consulta, conSQL2)
                    Dim lectura As SqlDataReader = myCommand.ExecuteReader()
                    While lectura.Read()
                        ' recull els valors de la taula i els introdueix en un vector 
                        fila(0) = lectura.GetString(0) ' DARRERA ULLADA
                        fila(1) = lectura.GetString(1) ' ID PRIORITAT  
                        fila(2) = lectura.GetString(2) ' id_cat
                        fila(3) = lectura.GetString(3) ' estat
                        fila(4) = lectura.GetString(4) ' assignada
                        txDataActualitzacio2.Text = fila(0)
                        cmbEstat2.SelectedIndex = fila(1)
                        cmbTipus2.SelectedIndex = fila(2)
                        cmbState2.SelectedIndex = fila(3)
                        cmbAssignat2.SelectedIndex = fila(4)
                    End While
                    conSQL2.Close()
                Catch ex As SqlException
                    MsgBox("Error " & ex.Message)
                Catch ex1 As InvalidCastException
                    ' MsgBox("Error " & ex1.Message)
                End Try
            End If
        End If
    End Sub
    Private Sub btAccioActualitzar_Click(sender As Object, e As EventArgs) Handles btAccioActualitzar2.Click
        updatePeticio()
    End Sub

    Private Sub txDataActualitzacio2_TextChanged(sender As Object, e As EventArgs) Handles txDataActualitzacio2.TextChanged

    End Sub
End Class