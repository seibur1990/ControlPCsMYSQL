Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class frmIncidencies
    Public numCas As String
    Public idPC As String
    Public usuari As String
    Public data As String
    Public dept As String
    Public estat As String
    Public assignat As String
    'Public peticio As String per servicio peticion

    Private Sub frmIncidencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'assignada

        cmbAssignat.DisplayMember = ""
        cmbAssignat.Items.Add("")
        cmbAssignat.Items.Insert(1, "Joan")
        cmbAssignat.Items.Insert(2, "Sergi")
        cmbAssignat.Items.Insert(3, "Jordi")


        cmbEstat.DisplayMember = ""
        cmbEstat.Items.Add("")
        cmbEstat.Items.Insert(1, "Critica")
        cmbEstat.Items.Insert(2, "Alta")
        cmbEstat.Items.Insert(3, "Mitjana")
        cmbEstat.Items.Insert(4, "Baixa")

        cmbTipus.DisplayMember = ""
        cmbTipus.Items.Add("")
        cmbTipus.Items.Insert(1, "Aplicatius")
        cmbTipus.Items.Insert(2, "Correo Electrònic")
        cmbTipus.Items.Insert(3, "Evolution Manager")
        cmbTipus.Items.Insert(4, "Hardrware PC's")
        cmbTipus.Items.Insert(5, "Impressora")
        cmbTipus.Items.Insert(6, "Informes")
        cmbTipus.Items.Insert(7, "Servidors")
        cmbTipus.Items.Insert(8, "Telefonia")
        cmbTipus.Items.Insert(9, "Xarxa")


        buscDept.DisplayMember = ""
        buscDept.Items.Add("")
        buscDept.Items.Insert(1, "Aplicatius")
        buscDept.Items.Insert(2, "Correo Electrònic")
        buscDept.Items.Insert(3, "Evolution Manager")
        buscDept.Items.Insert(4, "Hardrware PC's")
        buscDept.Items.Insert(5, "Impressora")
        buscDept.Items.Insert(6, "Informes")
        buscDept.Items.Insert(7, "Servidors")
        buscDept.Items.Insert(8, "Telefonia")
        buscDept.Items.Insert(9, "Xarxa")


        cmbState.DisplayMember = ""
        cmbState.Items.Add("")
        cmbState.Items.Insert(1, "Oberta")
        cmbState.Items.Insert(2, "Tancada")
        cmbState.Items.Insert(3, "Treballant-hi")
        cmbState.Items.Insert(4, "Tancada Incompleta")
        cmbState.Items.Insert(5, "Tancada Completa")
        cmbState.Items.Insert(6, "Tancada Traspassada")
        cmbState.Items.Insert(7, "Resolta")

        buscEstat.DisplayMember = ""
        buscEstat.Items.Add("")
        buscEstat.Items.Insert(1, "Oberta")
        buscEstat.Items.Insert(2, "Tancada")
        buscEstat.Items.Insert(3, "Treballant-hi")
        buscEstat.Items.Insert(4, "Tancada Incompleta")
        buscEstat.Items.Insert(5, "Tancada Completa")
        buscEstat.Items.Insert(6, "Tancada Traspassada")
        buscEstat.Items.Insert(7, "Resolta")

        '  cmbpeticio.DisplayMember = ""
        '  cmbpeticio.Items.Add("")
        '  cmbpeticio.Items.Insert(1, "Nova campanya")
        '  cmbpeticio.Items.Insert(2, "Depurar base de dades")
        '  cmbpeticio.Items.Insert(3, "Creació / modificació scripts")
        '  cmbpeticio.Items.Insert(4, "Creació / modificació consultes")
        '  cmbpeticio.Items.Insert(5, "Creació / modificació informes")
        '  cmbpeticio.Items.Insert(6, "Gestió de registres")
        '  cmbpeticio.Items.Insert(7, "Retornar base de dades")

        comu.llistarIncidenciesUSR()
        dataGrid_Click(dataGrid.Rows(0), e)
    End Sub

    Sub updateIncidencia()

        Dim id As String = txID.Text
        Dim problema As String = "'" + txProblema.Text + "'"
        Dim solucio As String = "'" + txSolucio.Text + "'"
        Dim g As Integer = cmbEstat.SelectedIndex
        Dim grau As String = "'" + g.ToString + "'"         ' Critic, alta, mitjana i baixa
        g = cmbState.SelectedIndex
        Dim estat As String = "'" + g.ToString + "'"        ' Oberta, Resolta...
        g = cmbTipus.SelectedIndex
        Dim dept As String = "'" + g.ToString + "'"          'Aplicatiu, correu ...
        g = cmbAssignat.SelectedIndex
        Dim assignat As String = "'" + g.ToString + "'"


        ' Dim assignatg As String = cmbAssignat.SelectedIndex
        ' Dim assignat As String = "'" + assignatg.ToString + "'" ' joan sergi jordi

        Dim consulta As String
        Dim conSQL As SqlConnection

        Try
            consulta = "UPDATE incidencies SET solucio = " + solucio + ", problema = " + problema + ",  darrera_ullada = convert(varchar, getdate(),23), darrera_ullada_hora = convert(varchar, getdate(), 108), id_prioritat = " + grau + ", id_estat = " + estat + ", id_cat = " + dept + ", assignada = " + assignat + " WHERE LTRIM(STR(id_incidencia, 25, 0)) LIKE '" + id + "'"  'actualitzar solucio darrera ullada dia i hora 

            conSQL = conectarSQLSERVER()
            Dim myCommand As New SqlCommand(consulta, conSQL)
            myCommand.ExecuteNonQuery()
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
        Catch ex1 As InvalidCastException
            MsgBox("Error " & ex1.Message)
        End Try
        comu.llistarIncidenciesUSR()

    End Sub

    Function comprobarBusc()

        numCas = buscadorId.Text
        idPC = TextPC.Text
        usuari = TextUsuari.Text
        data = TextData.Text
        dept = buscDept.SelectedIndex.ToString

        If dept = "-1" Then
            dept = ""
        End If

        estat = buscEstat.SelectedIndex.ToString
        If estat = "-1" Then
            estat = ""
        End If

        If (numCas = "" Or numCas = Nothing) And (idPC = "" Or idPC = Nothing Or vbEmpty) And (usuari = "" Or usuari = Nothing) And (data = "" Or data = Nothing) And (dept = "" Or dept = Nothing) And (estat = "" Or estat = Nothing) Then
            Return False                                                    ' vbempty testeado       Or usuari = Nothing   testeado           
        Else
            Return True
        End If

    End Function
    Sub Buscar()

        numCas = buscadorId.Text
        idPC = TextPC.Text
        usuari = TextUsuari.Text
        data = TextData.Text
        dept = buscDept.SelectedIndex.ToString
        estat = buscEstat.SelectedIndex.ToString

        If dept = "-1" Or dept = Nothing Then
            dept = ""
        End If

        If estat = "-1" Or estat = Nothing Then
            estat = ""
        End If

        Dim x As Boolean = False
        Dim y As Boolean = False
        If numCas = "" And idPC = "" And usuari = "" And data = "" Then
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
            comu.llistarIncidenciesUSR()
            x = False
            Exit Sub
        End If
        '   MsgBox("dept " & dept + " estat " + estat)

        Dim condicion As String = ""
        Dim SQL As String
        Dim Reader As SqlDataReader = Nothing
        Dim conSQL As SqlConnection
        ' Dim conSQL2 As SqlConnection
        ' Dim consulta As New SqlCommand(SQL, conSQL) advertencia

        ' If dataGrid.CurrentRow.Index >= 0 Then
        'numCas = dataGrid.Rows(dataGrid.CurrentRow.Index).Cells(0).Value.ToString

        If numCas <> DBNull.Value.ToString Then
            'Construim la sentencia SQL i les condicions.   LTRIM(STR(id_incidencia, 25, 5))
            If condicion <> DBNull.Value.ToString Then
                condicion = condicion & " AND LTRIM(STR(id_incidencia, 25, 0)) LIKE '" & numCas & "%'"
                SQL = "SELECT id_incidencia, usr, id_pc, data, problema, solucio, id_cat, id_estat FROM incidencies " & condicion
            Else
                condicion = " WHERE LTRIM(STR(id_incidencia, 25, 0)) LIKE '" & numCas & "%'"
                SQL = "SELECT id_incidencia, usr, id_pc, data, problema, solucio, id_cat, id_estat FROM incidencies " & condicion
            End If
        End If

        If idPC <> DBNull.Value.ToString Then

            'Construim la sentencia SQL i les condicions.
            If condicion <> DBNull.Value.ToString Then
                condicion = condicion & " AND id_pc LIKE '" & idPC & "%'"
                SQL = "SELECT id_incidencia, usr, id_pc, data, problema, solucio, id_cat, id_estat, assignada FROM incidencies " & condicion
            Else
                condicion = " WHERE id_pc LIKE '" & idPC & "%'"
                SQL = "SELECT id_incidencia, usr, id_pc, data, problema, solucio, id_cat, id_estat, assignada FROM incidencies " & condicion
            End If
        End If

        If usuari <> DBNull.Value.ToString Then
            'Construim la sentencia SQL i les condicions.
            If condicion <> DBNull.Value.ToString Then
                condicion = condicion & " AND usr LIKE '" & usuari & "%'"
                SQL = "SELECT id_incidencia, usr, id_pc, data, problema, solucio, id_cat, id_estat, assignada FROM incidencies " & condicion
            Else
                condicion = "WHERE usr LIKE '" & usuari & "%'"
                SQL = "SELECT id_incidencia, usr, id_pc, data, problema, solucio, id_cat, id_estat, assignada FROM incidencies " & condicion
            End If
        End If

        If data <> DBNull.Value.ToString Then
            'Construim la sentencia SQL i les condicions.
            If condicion <> DBNull.Value.ToString Then
                condicion = condicion & " AND data LIKE '" & data & "%'"
                SQL = "SELECT id_incidencia, usr, id_pc, data, problema, solucio, id_cat, id_estat, assignada FROM incidencies " & condicion
            Else
                condicion = "WHERE data LIKE '" & data & "%'"
                SQL = "SELECT id_incidencia, usr, id_pc, data, problema, solucio, id_cat, id_estat, assignada FROM incidencies " & condicion
            End If
        End If
        If dept <> DBNull.Value.ToString Then
            'dept <> "" then
            'Construim la sentencia SQL i les condicions.
            If condicion <> DBNull.Value.ToString Then
                condicion = condicion & " AND id_cat LIKE '" & dept & "'"
                SQL = "SELECT id_incidencia, usr, id_pc, data, problema, solucio, id_cat, id_estat, assignada FROM incidencies " & condicion
            Else
                condicion = " WHERE id_cat LIKE '" & dept & "'"
                SQL = "SELECT id_incidencia, usr, id_pc, data, problema, solucio, id_cat, id_estat, assignada FROM incidencies " & condicion
            End If
        End If
        If estat <> DBNull.Value.ToString Then
            'Construim la sentencia SQL i les condicions.
            If condicion <> DBNull.Value.ToString Then
                condicion = condicion & " AND id_estat LIKE '" & estat & "'"
                SQL = "SELECT id_incidencia, usr, id_pc, data, problema, solucio, id_cat, id_estat, assignada FROM incidencies " & condicion
            Else
                condicion = " WHERE id_estat LIKE '" & estat & "'"
                SQL = "SELECT id_incidencia, usr, id_pc, data, problema, solucio, id_cat, id_estat, assignada FROM incidencies " & condicion
            End If
        End If
        Dim categoria As String
        Dim estat1 As String
        Dim assignada1 As String

        Try
            conSQL = conectarSQLSERVER()
            'conSQL2 = conectarSQLSERVER()
            dataGrid.Rows.Clear()
            Dim consulta As New SqlCommand(SQL, conSQL)
            ' conSQL.Open()
            Reader = consulta.ExecuteReader
            ' Dim lectura As SqlDataReader = consulta.ExecuteReader()

            Dim fila As String() = New String() {"", "", "", "", "", "", "", "", "", ""}
            While Reader.Read()
                fila(0) = Reader.GetDouble(0) ' ID
                fila(1) = Reader.GetString(1) ' USUARI
                fila(2) = Reader.GetString(2) ' PC
                fila(3) = Reader.GetString(3) ' DATA
                fila(4) = Reader.GetString(4) ' APP?
                fila(5) = Reader.GetString(5) ' DESCRIPCION PROBLEMA
                fila(6) = Reader.GetString(6) '  CATEGORIA

                Select Case Reader.GetString(6)
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
                fila(6) = categoria

                fila(7) = Reader.GetString(7)
                Select Case Reader.GetString(7)
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

                fila(7) = estat1

                Select Case Reader.GetString(8)
                    Case "0"
                        assignada1 = "Sense assignar"
                    Case "1"
                        assignada1 = "Joan"
                    Case "2"
                        assignada1 = "Sergi"
                    Case "3"
                        assignada1 = "Jordi"

                End Select
                fila(8) = assignada1

                dataGrid.Rows.Add(fila)
                '    Dim table10 As New DataTable

                '  DataBindings.DefaultDataSourceUpdateMode.ToObject(table10)
            End While
            Reader.Close()
            conSQL.Close()
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
        Catch e As InvalidCastException
            MsgBox("Error " & e.Message)
        End Try
        Exit Sub
    End Sub
    ' If SQL = DBNull.Value.ToString Then
    '         dataGrid.Rows.Clear()  
    '     Else
    '         conSQL = conectarSQLSERVER()
    '         consulta = New SqlCommand(SQL, conSQL)
    '         Reader = consulta.ExecuteReader
    '         If Reader.HasRows Then
    '             dataGrid.Rows.Clear()
    '         End If
    '
    '     End If
    ' End Sub
    Sub Correu_solucionat(ByVal destinatari As String, ByVal msg As String, ByVal id As String)
        Dim remitent As String = "resolutioncat@gmail.com"
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("resolutioncat@gmail.com", "gabrielamistral")

            Smtp_Server.Port = 465
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(remitent)
            e_mail.To.Add(destinatari)
            e_mail.Subject = "Incidencia resolta " + id
            e_mail.IsBodyHtml = False
            e_mail.Body = msg
            Smtp_Server.Send(e_mail)
        Catch er As Exception
            MsgBox(er.ToString)
        End Try
    End Sub
    Private Sub dataGrid_Click(sender As Object, e As EventArgs) Handles dataGrid.Click

        Dim fila As String() = New String() {"", "", "", "", "", "", ""}
        Dim consulta As String
        Dim idI As String

        If dataGrid.CurrentRow Is Nothing Then
            Return
        Else
            If dataGrid.CurrentRow.Index >= 0 Then ' agafa dades de la fila seleccionada de la taula per mostrarles al datagridview
                Try

                    txID.Text = dataGrid.Rows(dataGrid.CurrentRow.Index).Cells(0).Value.ToString ' ES FLOAT 
                    txNomPacient.Text = dataGrid.Rows(dataGrid.CurrentRow.Index).Cells(1).Value.ToString
                    txUsuari.Text = dataGrid.Rows(dataGrid.CurrentRow.Index).Cells(2).Value.ToString
                    txDataObertura.Text = dataGrid.Rows(dataGrid.CurrentRow.Index).Cells(3).Value.ToString
                    txProblema.Text = dataGrid.Rows(dataGrid.CurrentRow.Index).Cells(4).Value.ToString
                    txSolucio.Text = dataGrid.Rows(dataGrid.CurrentRow.Index).Cells(5).Value.ToString
                    idI = txID.Text
                    cmbAssignat.Text = dataGrid.Rows(dataGrid.CurrentRow.Index).Cells(8).Value.ToString

                    conSQL = conectarSQLSERVER()
                    'antigua ' consulta = "SELECT  darrera_ullada, solucio, id_prioritat FROM incidencies WHERE id_incidencia = " + idI + "ORDER BY data DESC, hora DESC"
                    consulta = "SELECT  darrera_ullada, id_prioritat, id_cat, id_estat, assignada FROM incidencies WHERE id_incidencia = '" + idI + "'" ' ORDER BY data DESC, hora DESC"

                    Dim myCommand As New SqlCommand(consulta, conSQL)
                    Dim lectura As SqlDataReader = myCommand.ExecuteReader()
                    While lectura.Read()
                        ' recull els valors de la taula i els introdueix en un vector 
                        fila(0) = lectura.GetString(0)
                        fila(1) = lectura.GetString(1)
                        fila(2) = lectura.GetString(2)
                        fila(3) = lectura.GetString(3)
                        fila(4) = lectura.GetString(4)
                        txDataActualitzacio.Text = fila(0)
                        cmbEstat.SelectedIndex = fila(1)
                        cmbTipus.SelectedIndex = fila(2)
                        cmbState.SelectedIndex = fila(3)
                        cmbAssignat.SelectedIndex = fila(4)
                    End While
                Catch ex As SqlException
                    MsgBox("Error " & ex.Message)
                Catch ex1 As InvalidCastException
                    ' MsgBox("Error " & ex1.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub btAccioActualitzar_Click(sender As Object, e As EventArgs) Handles btAccioActualitzar.Click
        updateIncidencia()
    End Sub

    Private Sub BuscadorEstat_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cercador_Click(sender As Object, e As EventArgs) Handles Cercador.Click

    End Sub

    Private Sub TextUsuari_TextChanged(sender As Object, e As EventArgs) Handles TextUsuari.TextChanged
        Dim x As Boolean = comprobarBusc()
        If x = True Then
            Buscar()
        Else
            comu.llistarIncidenciesUSR()
        End If
    End Sub

    Private Sub TextData_TextChanged(sender As Object, e As EventArgs) Handles TextData.TextChanged
        Dim x As Boolean = comprobarBusc()
        If x = True Then
            Buscar()
        Else
            comu.llistarIncidenciesUSR()
        End If
    End Sub

    Private Sub buscadorId_TextChanged(sender As Object, e As EventArgs) Handles buscadorId.TextChanged
        Dim x As Boolean = comprobarBusc()
        If x = True Then
            Buscar()
        Else
            comu.llistarIncidenciesUSR()
        End If
    End Sub

    Private Sub dataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGrid.CellContentClick

    End Sub

    Private Sub buscDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles buscDept.SelectedIndexChanged
        Dim x As Boolean = comprobarBusc()
        If x = True Then
            Buscar()
        Else
            comu.llistarIncidenciesUSR()
        End If
    End Sub

     Private Sub buscDept_TextChanged(sender As Object, e As EventArgs) Handles buscDept.TextChanged
         Dim x As Boolean = comprobarBusc()
         If x = True Then
             Buscar()
         Else
             comu.llistarIncidenciesUSR()
         End If
     End Sub

    Private Sub buscEstat_TextChanged(sender As Object, e As EventArgs) Handles buscEstat.TextChanged
        Dim x As Boolean = comprobarBusc()
        If x = True Then
            Buscar()
        Else
            comu.llistarIncidenciesUSR()
        End If
    End Sub

    Private Sub TextPC_TextChanged(sender As Object, e As EventArgs) Handles TextPC.TextChanged
        Dim x As Boolean = comprobarBusc()
        If x = True Then
            Buscar()
        Else
            comu.llistarIncidenciesUSR()
        End If
    End Sub

    Private Sub buscEstat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles buscEstat.SelectedIndexChanged
        Dim x As Boolean = comprobarBusc()
        If x = True Then
            Buscar()
        Else
            comu.llistarIncidenciesUSR()
        End If
    End Sub

    Private Sub bt_informe_Click(sender As Object, e As EventArgs) Handles bt_informe.Click

        Informes.ShowDialog()
    End Sub

End Class