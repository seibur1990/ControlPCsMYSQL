Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System
Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.SqlClient
Imports System.Net

Module comu
    Dim pos As Integer = 0
    Friend conMySQL As MySqlConnection
    Friend conSQL As SqlConnection
    Friend conSQL2 As SqlConnection
    Friend conMySQL2 As MySqlConnection

    Public correos As New MailMessage
    Public enviat As New SmtpClient
    ' Sub llistarIncidencies()
    '     'Ensenyar el llistat d'incidencies 
    '     'resoltes i sense resoldre per odre de data i hora
    '     Try
    '         conSQL = conectarSQLSERVER()
    '         Dim consulta As String = "SELECT id_incidencia, id_pc, data, problema FROM [CATMANAGER].[dbo].[incidencies] ORDER BY data DESC, hora DESC "
    '         Dim myCommand As New SqlCommand(consulta, conSQL)
    '         Dim lectura As SqlDataReader = myCommand.ExecuteReader()
    '         'Dim n As Integer = 1
    '         frmBase.dataGrid.Rows.Clear()
    '         frmBase.dataGrid.Columns.Clear()
    '         frmBase.dataGrid.ColumnCount = 3
    '         frmBase.dataGrid.Columns(0).Name = "ID"
    '         frmBase.dataGrid.Columns(1).Name = "PC"
    '         frmBase.dataGrid.Columns(2).Name = "Data alta"
    '         Dim fila As String() = New String() {"", "", "", ""}
    '         While lectura.Read()
    '             'frmBase.txTest.Text = lectura.GetString(0).ToString()
    '             fila = {lectura.GetDouble(0).ToString(), lectura.GetString(1), lectura.GetDateTime(2).ToString(), lectura.GetString(3)}
    '             frmBase.dataGrid.Rows.Add(fila)
    '         End While
    '     Catch ex As SqlException
    '         MsgBox("Error " & ex.Message)
    '     Catch ex As InvalidCastException
    '         MsgBox("Error " & ex.Message)
    '     End Try
    ' End Sub
    Sub llistarIncidenciesUSR()
        'Ensenyar el llistat d'incidencies 
        'resoltes i sense resoldre per odre de data i hora
        Dim categoria As String
        Dim estat As String
        Dim assignat As String
        Try
            conSQL = conectarSQLSERVER()

            Dim consulta As String
            If (verifica_usrAdmin(frmIdentificar.usuari) = True) Then

                'consulta mostrar datagrid en incidencies
                consulta = "SELECT id_incidencia, usr, id_pc, data, problema, solucio, id_cat, id_estat, assignada FROM incidencies ORDER BY data DESC, hora DESC "
            Else
                consulta = "SELECT * FROM incidencies WHERE usr='" + frmIdentificar.usuari + "' ORDER BY data DESC, hora DESC "
            End If
            Dim myCommand As New SqlCommand(consulta, conSQL)
            Dim lectura As SqlDataReader = myCommand.ExecuteReader()
            With frmIncidencies
                .dataGrid.Rows.Clear()
                .dataGrid.Columns.Clear()
                .dataGrid.ColumnCount = 9
                .dataGrid.Columns(0).Name = "ID"
                .dataGrid.Columns(1).Name = "Usuari"
                .dataGrid.Columns(1).Width = 70
                .dataGrid.Columns(2).Name = "PC"
                .dataGrid.Columns(2).Width = 70
                .dataGrid.Columns(3).Name = "Data alta"
                .dataGrid.Columns(3).Width = 80
                .dataGrid.Columns(4).Name = "Problema"
                .dataGrid.Columns(4).Width = 170
                .dataGrid.Columns(5).Name = "Solució"
                .dataGrid.Columns(5).Width = 170
                .dataGrid.Columns(6).Name = "Categoria"
                .dataGrid.Columns(7).Name = "Estat"
                .dataGrid.Columns(8).Name = "Assignat a"
                .dataGrid.Columns(8).Width = 70


                Dim fila As String() = New String() {"", "", "", "", "", "", "", "", ""}
                While lectura.Read()
                    ' recull els valors de la taula i els introdueix en un vector 
                    fila(0) = lectura.GetDouble(0).ToString() 'id
                    fila(1) = lectura.GetString(1)            'usuari
                    fila(2) = lectura.GetString(2) ' pc 
                    fila(3) = lectura.GetString(3) ' data alta 
                    fila(4) = lectura.GetString(4).ToString() ' problema 
                    fila(5) = lectura.GetString(5) ' solucio 
                    Select Case lectura.GetString(6) ' categoria 
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

                    Select Case lectura.GetString(7)
                        Case "1"
                            estat = "Oberta"
                        Case "2"
                            estat = "Tancada"
                        Case "3"
                            estat = "Treballant-hi"
                        Case "4"
                            estat = "Tancada Incompleta"
                        Case "5"
                            estat = "Tancada Completa"
                        Case "6"
                            estat = "Tancada Traspassada"
                        Case "7"
                            estat = "Resolta"

                    End Select

                    fila(7) = estat

                    'fila(8) = lectura.GetString(8)
                    Select Case lectura.GetString(8).ToString
                        Case "0"
                            assignat = "Sense assignar"
                        Case "1"
                            assignat = "Joan"
                        Case "2"
                            assignat = "Sergi"
                        Case "3"
                            assignat = "Jordi"

                    End Select

                    fila(8) = assignat

                    .dataGrid.Rows.Add(fila)
                End While
                lectura.Close()
            End With
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
        Catch e As InvalidCastException
            MsgBox("Error " & e.Message)
        End Try
        conSQL.Close()
    End Sub
    Function conectarMYSQL(ByVal ip As String, ByVal usuari As String, ByVal pass As String) As MySqlConnection
        Try
            'Funció per conectar-me a la base de dades
            'retorna la variable per mantenir la connecció
            conMySQL = New MySqlConnection()
            conMySQL.ConnectionString = "server=" & ip & ";" & "user id=" & usuari & ";" & "password=" & pass & ";"
            conMySQL.Open()
            Return conMySQL
        Catch ex As MySqlException
            MsgBox("Error " & ex.Message)
            Return conMySQL
        End Try
    End Function

    Sub llistarPeticionsUSR()
        'Ensenyar el llistat d'incidencies 
        'resoltes i sense resoldre per odre de data i hora
        Dim categoria As String
        Dim estat As String
        Dim assignat As String
        Try
            conSQL2 = conectarSQLSERVER2()
            'conSQL2.Open()
            Dim consulta As String
            If (verifica_usrAdmin(frmIdentificar.usuari) = True) Then

                'consulta mostrar datagrid en incidencies
                consulta = "SELECT id_peticio, usr, data, hora, problema, id_cat, estat, assignada FROM peticio ORDER BY data DESC " ' el id_estat lo he tenido que quitar que supuestamente era el bueno
            Else
                'SELECT id_incidencia, usr, id_pc, data, problema, solucio, id_cat, id_estat, assignada FROM incidencies ORDER BY data DESC, hora DESC "
                consulta = "SELECT * FROM peticio WHERE usr='" + frmIdentificar.usuari + "' ORDER BY data DESC "
            End If
            Dim myCommand As New SqlCommand(consulta, conSQL2)
            Dim lectura As SqlDataReader = myCommand.ExecuteReader()
            With frmPeticio
                .dataGrid2.Rows.Clear()
                .dataGrid2.Columns.Clear()
                .dataGrid2.ColumnCount = 8
                .dataGrid2.Columns(0).Name = "ID"
                .dataGrid2.Columns(1).Name = "Usuari"
                .dataGrid2.Columns(1).Width = 70
                .dataGrid2.Columns(2).Name = "Data alta"
                .dataGrid2.Columns(2).Width = 70
                .dataGrid2.Columns(3).Name = "Hora"
                .dataGrid2.Columns(3).Width = 65
                .dataGrid2.Columns(4).Name = "Problema"
                .dataGrid2.Columns(4).Width = 170
                .dataGrid2.Columns(5).Name = "Categoria"
                .dataGrid2.Columns(6).Name = "Estat"
                .dataGrid2.Columns(7).Name = "Assignat a"
                .dataGrid2.Columns(7).Width = 70


                Dim fila As String() = New String() {"", "", "", "", "", "", "", ""}
                While lectura.Read()
                    ' recull els valors de la taula i els introdueix en un vector 
                    fila(0) = lectura.GetDouble(0).ToString() 'id
                    fila(1) = lectura.GetString(1)             'usuari
                    'fila(2) = lectura.GetString(2) supuesto pc
                    fila(2) = lectura.GetString(2) ' data 
                    fila(3) = lectura.GetString(3).ToString() ' hora 
                    fila(4) = lectura.GetString(4) ' problema 
                    Select Case lectura.GetString(5)
                        Case "1"
                            categoria = "Nova campaña"
                        Case "2"
                            categoria = "Depuració base de dades"
                        Case "3"
                            categoria = "Creació / modificació scripts"
                        Case "4"
                            categoria = "Creació / modificació consultes"
                        Case "5"
                            categoria = "Creació / modificació informes"
                        Case "6"
                            categoria = "Gestió de registres"
                        Case "7"
                            categoria = "Retornar base de dades"

                    End Select
                    fila(5) = categoria


                    Select Case lectura.GetString(6)
                        Case "1"
                            estat = "Oberta"
                        Case "2"
                            estat = "Tancada"
                        Case "3"
                            estat = "Treballant-hi"
                        Case "4"
                            estat = "Tancada Incompleta"
                        Case "5"
                            estat = "Tancada Completa"
                        Case "6"
                            estat = "Tancada Traspassada"
                        Case "7"
                            estat = "Resolta"

                    End Select

                    fila(6) = estat

                    'fila(8) = lectura.GetString(8)
                    Select Case lectura.GetString(7).ToString
                        Case "0"
                            assignat = "Sense assignar"
                        Case "1"
                            assignat = "Joan"
                        Case "2"
                            assignat = "Sergi"
                        Case "3"
                            assignat = "Jordi"

                    End Select

                    fila(7) = assignat

                    .dataGrid2.Rows.Add(fila)
                End While
                lectura.Close()

            End With
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
        Catch e As InvalidCastException
            MsgBox("Error " & e.Message)
        End Try
        conSQL2.Close()
    End Sub

    Function conectarMYSQL2(ByVal ip As String, ByVal usuari As String, ByVal pass As String) As MySqlConnection
        Try
            'Funció per conectar-me a la base de dades
            'retorna la variable per mantenir la connecció
            conMySQL2 = New MySqlConnection()
            conMySQL2.ConnectionString = "server=" & ip & ";" & "user id=" & usuari & ";" & "password=" & pass & ";"
            conMySQL2.Open()
            Return conMySQL2
        Catch ex As MySqlException
            MsgBox("Error " & ex.Message)
            Return conMySQL2
        End Try
    End Function
    Function conectarSQLSERVER() As SqlConnection
        Try
            'Funció per conectar-me a la base de dades
            'retorna la variable per mantenir la connecció

            Dim conString As String = "Data Source=DESKTOP-O464FGK\SQLEXPRESS;Initial Catalog=CATMANAGER;Persist Security Info=True;User ID=resolution;Password=estopaera90"
            conSQL = New SqlConnection(conString)
            'conSQL.ConnectionString = "server=" & ip & ";" & "user id=" & usuari & ";" & "password=" & pass & ";"
            conSQL.Open()
            Return conSQL
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
            Return conSQL
        End Try
    End Function

    Function conectarSQLSERVER2() As SqlConnection
        Try
            'Funció per conectar-me a la base de dades
            'retorna la variable per mantenir la connecció
            Dim conString As String = "Data Source=DESKTOP-O464FGK\SQLEXPRESS;Initial Catalog=CATMANAGER;Persist Security Info=True;User ID=resolution;Password=estopaera90"
            conSQL2 = New SqlConnection(conString)
            'conSQL.ConnectionString = "server=" & ip & ";" & "user id=" & usuari & ";" & "password=" & pass & ";"
            conSQL2.Open()
            Return conSQL2
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
            Return conSQL2
        End Try
    End Function
    '   Sub LlegirDadesCas(ByVal filaSelecionada As Integer)
    '       Try
    '           'Retorna les dades del cas selecionat
    '           conSQL = conectarSQLSERVER()
    '           Dim NumeroID As String = frmIncidencies.dataGrid.Item(0, filaSelecionada).Value
    '           Dim consulta As String = "SELECT *, incidencies.id_pc AS NomPacient FROM usuaris, incidencies, ordinador, graus WHERE usuaris.usr=incidencies.usr AND ordinador.id_PC=incidencies.id_pc AND idGrau=id_prioritat AND id_incidencia= '" + NumeroID + "'"
    '           Dim myCommand As New SqlCommand(consulta, conSQL)
    '           Dim lectura As SqlDataReader = myCommand.ExecuteReader()
    '           Dim fila As String() = New String() {"", "", "", "", ""}
    '           Dim dataIni As String
    '           With frmBase
    '               While lectura.Read()
    '                   .txID.Text = lectura.GetDouble(0).ToString() ' 
    '                   .txDataObertura.Text = lectura.GetString(3).ToString() + " " + lectura.GetString(4).ToString()
    '                   dataIni = lectura.GetDateTime(3).ToString
    '                   .txDataObertura.Text = dataIni + " " + lectura.GetString(4).ToString()
    '                   .txDataObertura.Text = dataIni.ToString("yyyy/MM/dd") + " " + lectura.GetString(4).ToString()
    '                   .txProblema.Text = lectura.GetString(5).ToString()
    '                   .txSolucio.Text = lectura.GetString(8).ToString()
    '                   .txUsuari.Text = lectura.GetString(12).ToString()
    '                   .txNomPacient.Text = lectura.GetString(18).ToString()
    '                   .txSolucio.Text = consulta
    '                   Try
    '                       .txDataActualitzacio.Text = lectura.GetString(9).ToString()
    '                   Catch
    '                       .txDataActualitzacio.Text = "00/00/0000"
    '                   End Try
    '
    '               End While
    '           End With
    '       Catch ex As SqlException
    '           MsgBox("Error " & ex.Message)
    '       End Try
    '   End Sub
    Sub Llistat_responsables()
        Try
            'Dim frmTemp As frmNovaAlta
            'Obté un llistat de tots els responables
            conSQL = conectarSQLSERVER()
            Dim consulta As String = "SELECT nom FROM usuaris ORDER BY nom "
            Dim myCommand As New SqlCommand(consulta, conSQL)
            Dim lectura As SqlDataReader = myCommand.ExecuteReader()
            With frmNovaAlta
                .cmbResponsable.Items.Clear()
                .Text = frmIdentificar.nom
                While lectura.Read()
                    .cmbResponsable.Items.Add(lectura.GetString(0).ToString())
                End While
                conSQL.Close()
                .cmbResponsable.Text = frmIdentificar.nom
            End With
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
        End Try
    End Sub

    Sub Llistat_responsables2()
        Try
            'Dim frmTemp As frmNovaAlta
            'Obté un llistat de tots els responables
            conSQL2 = conectarSQLSERVER2()
            Dim consulta As String = "SELECT nom FROM usuaris ORDER BY nom "
            Dim myCommand As New SqlCommand(consulta, conSQL2)
            Dim lectura As SqlDataReader = myCommand.ExecuteReader()
            With peticioServei
                .cmbResponsable2.Items.Clear()
                .Text = frmIdentificar.nom
                While lectura.Read()
                    .cmbResponsable2.Items.Add(lectura.GetString(0).ToString())
                End While
                conSQL2.Close()
                .cmbResponsable2.Text = frmIdentificar.nom
            End With
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
        End Try
    End Sub
    Sub Llistat_usrAdmin()
        Try
            'obter un llistat d'usuaris Administrador
            conSQL = conectarSQLSERVER()
            Dim consulta As String = "SELECT usr FROM usuaris ORDER BY usr "
            Dim myCommand As New SqlCommand(consulta, conSQL)
            Dim lectura As SqlDataReader = myCommand.ExecuteReader()
            'Dim fila As String() = New String() {"", ""}
            With frmUsuarisUPDATE
                .cmbUsr.Items.Clear()
                While lectura.Read()
                    .cmbUsr.Items.Add(lectura.GetString(0).ToString())
                End While
            End With
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
        End Try
    End Sub
    Sub Dades_usr(ByVal usr As String)
        Try
            'Dades de l'usuari administrador
            conSQL = conectarSQLSERVER()
            Dim consulta As String = "SELECT * FROM usuaris WHERE usr='" + usr + "' "
            Dim myCommand As New SqlCommand(consulta, conSQL)
            Dim lectura As SqlDataReader = myCommand.ExecuteReader()
            'Dim fila As String() = New String() {"", ""}
            With frmUsuarisUPDATE
                lectura.Read()
                If (IsDBNull(lectura(3)) = False) Then
                    .txNom.Text = lectura.GetString(3).ToString()
                Else
                    .txNom.Text = ""
                End If

                If (IsDBNull(lectura(2)) = False) Then
                    .txCorreu.Text = lectura.GetString(2).ToString()
                Else
                    .txCorreu.Text = ""
                End If

                If (IsDBNull(lectura(6)) = True) Then
                    .chActiu.Checked = False
                ElseIf (lectura.GetInt32(6) = 0) Then
                    .chActiu.Checked = False
                Else
                    .chActiu.Checked = True
                End If

                If (IsDBNull(lectura(5)) = True) Then
                    .chNotifice.Checked = False
                ElseIf (lectura.GetInt32(5) = 0) Then
                    .chNotifice.Checked = False
                Else
                    .chNotifice.Checked = True
                End If

                If (IsDBNull(lectura(4)) = True) Then
                    .chAdmin.Checked = False
                ElseIf (lectura.GetInt32(4) = 0) Then
                    .chAdmin.Checked = False
                Else
                    .chAdmin.Checked = True
                End If

            End With
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
        End Try
    End Sub
    Function verifica_usrAdmin(ByVal usr As String) As Boolean
        Try
            'Verificador de que l'usuari X es administrador 
            'ja que els administradors solament estan en aquesta taula usuaris
            conSQL = conectarSQLSERVER()
            Dim consulta As String = "SELECT usr FROM usuaris WHERE usr='" + usr + "' "
            Dim myCommand As New SqlCommand(consulta, conSQL)
            'Dim fila As String() = New String() {"", ""}
            Dim reg As String = myCommand.ExecuteScalar
            If (reg = usr) Then
                Return True
            Else
                Return False
            End If
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
            Return False
        End Try
    End Function
    Function verifica_usr() As Boolean
        Dim estat As Boolean = False
        Try
            'Verificador d'usuaris
            ' Per la fase del loging on mirem també la contrasenya

            conSQL = conectarSQLSERVER()
            Dim consulta As String = "SELECT usr, admin, correu, psw, nom, estat FROM usuaris WHERE usr='" + frmIdentificar.txUsr.Text + "' AND psw='" + MD5(frmIdentificar.txPass.Text) + "' "
            'MsgBox(consulta)
            Try
                Dim myCommand As New SqlCommand(consulta, conSQL)
                Dim lectura As SqlDataReader = myCommand.ExecuteReader()
                While lectura.Read()
                    With frmIdentificar
                        .usuari = lectura.GetString(0).ToString()
                        .status = lectura.GetInt32(1)
                        .correu = lectura.GetString(2).ToString()
                        .pass = lectura.GetString(3).ToString()
                        .nom = lectura.GetString(4).ToString()
                        'MsgBox("Hola " + .nom)
                        estat = True
                        If (lectura.GetInt32(5).ToString() = 0) Then
                            MsgBox("Usuari desactivat", vbExclamation)
                            estat = False
                        End If
                    End With
                End While
                Return estat
            Catch ex As Exception
                'MsgBox("Error " & ex.Message)
                MsgBox("Error ")
                Return False
            End Try
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
            Return False
        End Try
    End Function
    Function verifica_usuari(ByVal usuari As String) As Boolean
        Dim estat As Boolean = False
        Try
            'Verifica si existeix un usuari

            conSQL = conectarSQLSERVER()
            Dim consulta As String = "SELECT usr, admin, correu, psw, nom, estat FROM usuaris WHERE usr='" + usuari + "' "
            'MsgBox(consulta)
            Try
                Dim myCommand As New SqlCommand(consulta, conSQL)
                Dim lectura As SqlDataReader = myCommand.ExecuteReader()
                While lectura.Read()
                    estat = True
                End While
                Return estat
            Catch ex As Exception
                MsgBox("Error")
                Return False
            End Try
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
            Return False
        End Try
    End Function

    Sub Llistat_PCs()
        Try
            'Llistat dels Pc's donats d'alta

            conSQL = conectarSQLSERVER()
            Dim consulta As String = "SELECT nomPC FROM ordinador ORDER BY nomPC "
            Dim myCommand As New SqlCommand(consulta, conSQL)
            Dim lectura As SqlDataReader = myCommand.ExecuteReader()
            'Dim fila As String() = New String() {"", ""}
            With frmNovaAlta
                .cmbPCs.Items.Clear()
                While lectura.Read()
                    .cmbPCs.Items.Add(lectura.GetString(0).ToString())
                End While
            End With
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
        End Try
    End Sub
    Sub Llistat_Prioritats()
        Try
            'Llistat de prioritats
            conSQL = conectarSQLSERVER()
            Dim consulta As String = "SELECT Grau FROM graus ORDER BY Grau "
            Dim myCommand As New SqlCommand(consulta, conSQL)
            Dim lectura As SqlDataReader = myCommand.ExecuteReader()
            'Dim fila As String() = New String() {"", ""}
            With frmNovaAlta
                .cmbPrioritat.Items.Clear()
                While lectura.Read()
                    .cmbPrioritat.Items.Add(lectura.GetString(0).ToString())
                End While
                conSQL.Close()
            End With
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
        End Try
    End Sub

    Sub Llistat_Prioritats2()
        Try
            'Llistat de prioritats
            conSQL2 = conectarSQLSERVER2()
            Dim consulta As String = "SELECT Grau FROM graus ORDER BY Grau "
            Dim myCommand As New SqlCommand(consulta, conSQL)
            Dim lectura As SqlDataReader = myCommand.ExecuteReader()
            'Dim fila As String() = New String() {"", ""}
            With peticioServei
                .cmbPrioritat2.Items.Clear()
                While lectura.Read()
                    .cmbPrioritat2.Items.Add(lectura.GetString(0).ToString())
                End While
                conSQL2.Close()
            End With
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
        End Try
    End Sub
    Function idGrau(ByVal nom As String)
        Try

            Dim id_grau As Integer = 0
            conSQL = conectarSQLSERVER()
            Dim consulta As String = "SELECT idGrau FROM graus WHERE Grau = '" + nom + "' "
            Dim myCommand As New SqlCommand(consulta, conSQL)
            Dim lectura As SqlDataReader = myCommand.ExecuteReader()
            lectura.Read()
            Return lectura.GetInt32(0)
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
            Return 0
        End Try
    End Function


    Function idassignada(ByVal nom As String)
        Try
            Dim idinformatics As Integer = 0
            conSQL = conectarSQLSERVER()
            Dim consulta As String = "SELECT idGrau FROM informatics WHERE informatics = '" + nom + "' "
            Dim myCommand As New SqlCommand(consulta, conSQL)
            Dim lectura As SqlDataReader = myCommand.ExecuteReader()
            lectura.Read()
            Return lectura.GetInt32(0)
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
            Return 0
        End Try

    End Function

    Function idafectat(ByVal nom As String)
        Try

            Dim id_grau As Integer = 0
            conSQL = conectarSQLSERVER()
            Dim consulta As String = "SELECT usr FROM usuaris WHERE nom = '" + nom + "' "
            Dim myCommand As New SqlCommand(consulta, conSQL)
            Dim lectura As SqlDataReader = myCommand.ExecuteReader()
            lectura.Read()
            Return lectura.GetString(0).ToString
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
            Return 0
        End Try
    End Function
    Function id_PC(ByVal nom As String)
        Try
            Dim id_grau As Integer = 0
            conSQL = conectarSQLSERVER()
            Dim consulta As String = "SELECT id_pc FROM ordinador WHERE nomPC = '" + nom + "' "
            Dim myCommand As New SqlCommand(consulta, conSQL)
            Dim lectura As SqlDataReader = myCommand.ExecuteReader()
            lectura.Read()
            Return lectura.GetString(0)
        Catch ex As SqlException

            MsgBox("Error " & ex.Message)
            Return 0
        End Try
    End Function

    Sub ActualitzarDadesCas(ByVal NumeroID As String)
        Try
            conSQL = conectarSQLSERVER()
            Dim consulta As String = "SELECT *, incidencies.id_pc AS NomPacient FROM incidencies, usuaris, ordinador, graus WHERE id_solicitant=idafectat AND ordinador.id_PC=incidencies.id_pc AND idGrau=id_prioritat AND id_incidencia= '" + NumeroID + "'"
            Dim myCommand As New SqlCommand(consulta, conSQL)
            Dim lectura As SqlDataReader = myCommand.ExecuteReader()
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
        End Try
    End Sub
    Sub AltaIncidencia(ByVal id_prioritat As String, ByVal id_solicitant As String, ByVal id_pc As String, ByVal problema As String, ByVal dept As String, ByVal estat As String, ByVal assignada As String)
        Dim rnd As New Random
        'Donem d'alta una nova incidencia en base a les dades enviades
        'En el cas de la data normalitzem afegint un 0 en cas de ser menor a 9
        'Per tant 9/2/2006 seria 09/02/2006

        'afegit
        'Dim id_prioritat As Integer
        'Select Case prioritat
        ' Case "Critica" : id_prioritat = 1
        'Case "Alta" : id_prioritat = 2
        'Case "Mitjana" : id_prioritat = 3
        'Case "Baixa" : id_prioritat = 4
        'End Select
        conSQL = conectarSQLSERVER()
        Dim zeroM, zeroD, ZeroH, ZeroMM As String
        If (Date.Now.Day < 10) Then
            zeroD = 0
        Else
            zeroD = ""
        End If
        If (Date.Now.Month < 10) Then
            zeroM = 0
        Else
            zeroM = ""
        End If
        If (Date.Now.Hour < 10) Then
            ZeroH = 0
        Else
            ZeroH = ""
        End If
        If (Date.Now.Minute < 10) Then
            ZeroMM = 0
        Else
            ZeroMM = ""
        End If

        Dim dataMysql As String = Date.Now.Year & "-" & zeroM & Date.Now.Month & "-" & zeroD & Date.Now.Day ' original de todos
        ' el modificado 
        ' Dim dataMysql As String = zeroD & Date.Now.Day & "/" & zeroM & Date.Now.Month & "/" & Date.Now.Year
        ' la siguiente linea esta comentada
        Dim id_incidencia As String = Date.Now.Year & zeroM & Date.Now.Month & zeroD & Date.Now.Day & ZeroH & Date.Now.Hour & ZeroMM & Date.Now.Minute & rnd.Next(10, 99)
        Dim hora As String = Date.Now.ToLongTimeString
        Dim data As String = Date.Now.ToShortDateString
        Dim sql As String = "INSERT INTO incidencies 
(id_incidencia, usr, id_pc, data, hora, problema, 
solucio, id_prioritat, estat, darrera_ullada, darrera_ullada_hora, id_cat, id_estat,assignada) VALUES 
('" + id_incidencia + "', '" + id_solicitant + "', '" + id_pc + "', '" + dataMysql + "',
'" + hora + "', '" + problema + "','', '" + id_prioritat + "', '1',  '" + dataMysql + "', '" + hora + "', " + dept + ", " + estat + ", " + assignada + ");"
        MsgBox("La teva incidència està registrada amb el número de seguiment: " + id_incidencia, vbInformation)
        Dim myCommand As New SqlCommand(sql, conSQL)
        'MsgBox(sql)
        'frmNovaAlta.txProblema.Text = sql
        myCommand.ExecuteNonQuery()
        'comu.llistarIncidencies()
        EnviamentCorreuNotificables("Incidència " + id_incidencia + " Usuari: " + id_solicitant, id_pc + vbCrLf + problema)
        frmNovaAlta.Close()
        'If myCommand.ExecuteNonQuery() > 0 Then MessageBox.Show("Data Saved")
    End Sub

    Sub AltaPeticioServei(ByVal id_prioritat As String, ByVal id_solicitant As String, ByVal problema As String, ByVal dept As String, ByVal id_estat As String, ByVal assignada As String)
        Dim rnd As New Random
        'Donem d'alta una nova incidencia en base a les dades enviades
        'En el cas de la data normalitzem afegint un 0 en cas de ser menor a 9
        'Per tant 9/2/2006 seria 09/02/2006

        'añadido
        'Dim id_prioritat As Integer
        'Select Case prioritat
        ' Case "Critica" : id_prioritat = 1
        'Case "Alta" : id_prioritat = 2
        'Case "Mitjana" : id_prioritat = 3
        'Case "Baixa" : id_prioritat = 4
        'End Select
        conSQL = conectarSQLSERVER()
        Dim zeroM, zeroD, ZeroH, ZeroMM As String
        If (Date.Now.Day < 10) Then
            zeroD = 0
        Else
            zeroD = ""
        End If
        If (Date.Now.Month < 10) Then
            zeroM = 0
        Else
            zeroM = ""
        End If
        If (Date.Now.Hour < 10) Then
            ZeroH = 0
        Else
            ZeroH = ""
        End If
        If (Date.Now.Minute < 10) Then
            ZeroMM = 0
        Else
            ZeroMM = ""
        End If

        Dim dataMysql As String = Date.Now.Year & "-" & zeroM & Date.Now.Month & "-" & zeroD & Date.Now.Day ' original de todos
        ' el modificado 
        ' Dim dataMysql As String = zeroD & Date.Now.Day & "/" & zeroM & Date.Now.Month & "/" & Date.Now.Year
        ' la siguiente linea esta comentada
        Dim id_peticio As String = Date.Now.Year & zeroM & Date.Now.Month & zeroD & Date.Now.Day & ZeroH & Date.Now.Hour & ZeroMM & Date.Now.Minute & rnd.Next(10, 99)
        Dim hora As String = Date.Now.ToLongTimeString
        Dim data As String = Date.Now.ToShortDateString
        Dim sql As String = "INSERT INTO peticio 
(id_peticio, usr, data, hora, problema, 
 id_prioritat, estat, darrera_ullada, darrera_ullada_hora, id_cat, id_estat,assignada) VALUES 
('" + id_peticio + "', '" + id_solicitant + "', '" + dataMysql + "',
'" + hora + "', '" + problema + "', '" + id_prioritat + "','1', '" + dataMysql + "', '" + hora + "', " + dept + ", '" + id_estat + "', " + assignada + ");"
        MsgBox("La teva incidència està registrada amb el número de seguiment: " + id_peticio, vbInformation)
        Dim myCommand As New SqlCommand(sql, conSQL2)
        'MsgBox(sql)
        'frmNovaAlta.txProblema.Text = sql
        myCommand.ExecuteNonQuery()
        'comu.llistarIncidencies()
        EnviamentCorreuNotificables("Incidència " + id_peticio + " Usuari: " + id_solicitant, problema)
        peticioServei.Close()
        'If myCommand.ExecuteNonQuery() > 0 Then MessageBox.Show("Data Saved")
    End Sub
    Sub EnviamentCorreuNotificables(ByVal id As String, ByVal missatgeCos As String)
        Try
            conSQL = conectarSQLSERVER()
            Dim consulta As String = "SELECT correu FROM usuaris WHERE notificacions = 1 AND estat = 1 ORDER BY usr "
            Dim myCommand As New SqlCommand(consulta, conSQL)
            Dim lectura As SqlDataReader = myCommand.ExecuteReader()
            While lectura.Read()
                Correu(lectura.GetString(0).ToString(), "Resolution, Informa que:" + vbCrLf + missatgeCos, id)
            End While
        Catch ex As SqlException
            MsgBox("Error " & ex.Message)
        End Try
    End Sub
    Sub AltaUsuari(ByVal nom As String, ByVal usuari As String, ByVal password As String, ByVal correu As String, ByVal estat As String, ByVal notificacions As String)
        'Altes de nous usuaris 
        password = MD5(password) ' Crida a la funció que retorna xifrada la contrasenya
        conSQL = conectarSQLSERVER()
        Dim sql As String = "INSERT INTO usuaris 
(nom, usr, psw, correu, estat, notificacions) VALUES 
('" + nom + "','" + usuari + "', '" + password + "', '" + correu + "', '" + estat + "','" + notificacions + "');"
        Try
            Dim myCommand As New SqlCommand(sql, conSQL)
            myCommand.ExecuteNonQuery()
            MsgBox("S'ha donat d'alta el nou usuari " + usuari + " correctament", vbInformation)
            With frmUsuaris
                .txCorreu.Text = ""
                .txNom.Text = ""
                .txPass.Text = ""
                .txPassRe.Text = ""
                .txUsr.Text = ""
            End With
        Catch ex As Exception
            MsgBox("Error en donar d'alta el nou usuari " + usuari + ".", vbInformation)
        End Try
        'comu.llistarIncidencies()
        'If myCommand.ExecuteNonQuery() > 0 Then MessageBox.Show("Data Saved")
    End Sub
    Sub ActualitzarUsuari(ByVal usuari As String, ByVal contrasenya As String, ByVal correu As String, ByVal estat As Boolean, ByVal notifocacions As Boolean, ByVal admin As Boolean, ByVal nom As String)
        Dim sql As String
        Dim estat_v, admin_v, notificacions_v As String
        conSQL = conectarSQLSERVER()
        If (estat = True) Then
            estat_v = "1"
        Else
            estat_v = "0"
        End If
        If (admin = True) Then
            admin_v = "1"
        Else
            admin_v = "0"
        End If
        If (notifocacions = True) Then
            notificacions_v = "1"
        Else
            notificacions_v = "0"
        End If
        Try

            If (contrasenya <> "") Then
                sql = "UPDATE usuaris SET psw = '" & MD5(contrasenya) & "',
                    correu = '" & correu & "',
                    nom = '" & nom & "',
                    estat = '" & estat_v & "',
                    notificacions = '" & notificacions_v & "',
                    admin = '" & admin_v & "' 
                    WHERE usr = '" & usuari & "'"
            Else
                sql = "UPDATE usuaris SET correu = '" & correu & "',
                    nom = '" & nom & "',
                    estat = '" & estat_v & "',
                    notificacions = '" & notificacions_v & "',
                    admin = '" & admin_v & "' 
                    WHERE usr = '" & usuari & "'"
            End If
            Dim myCommand As New SqlCommand(sql, conSQL)
            myCommand.ExecuteNonQuery()
            MsgBox(sql)
        Catch ex As Exception
            MsgBox("Error en l'actualització de l'usuari " + usuari + " " + ex.Message, vbInformation)
        End Try
    End Sub
    Sub Correu(ByVal destinatari As String, ByVal msg As String, ByVal id As String)


        Try
            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.Body = msg
            correos.Subject = "incidencia nova"
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatari))

            correos.From = New MailAddress("resolutioncat@gmail.com")
            enviat.Credentials = New NetworkCredential("resolutioncat@gmail.com", "gabrielamistral")

            'Datos importantes no modificables para tener acceso a las cuentas

            enviat.Host = "smtp.gmail.com"
            enviat.Port = 587
            enviat.EnableSsl = True

            enviat.Send(correos)
            MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Function MD5(ByVal cadena As String) As String
        Dim PasConMd5 As String = ""
        Dim md5B As New MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim i As Integer

        bytValue = System.Text.Encoding.UTF8.GetBytes(cadena)

        bytHash = md5B.ComputeHash(bytValue)
        md5B.Clear()

        For i = 0 To bytHash.Length - 1
            PasConMd5 &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next
        Return PasConMd5
    End Function



End Module
