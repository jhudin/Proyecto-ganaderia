Imports System.IO
Imports System
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Imaging
Public Class Editar
    Dim comprob, tamaño, cantidadid As Integer
    Dim sql3, cedula_prim, idseg As String
    Dim codigos(), arreglo(), cedulaarreglo() As Integer
    Function Bytes_Imagen(id As String, id2 As String) As Image
        cedula_prim = id
        idseg = id2
        'variables de conexion con servidor mysql
        Dim conection As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand
        'asignacion de propiedades a conector
        comando.Connection = conection
        'conexion con base de datos
        Try
            conection.ConnectionString = "server=localhost;database=poblacionganadera;user id=root;pwd=;"
            conection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim cSQL As String = "Select foto from registroganado where `id animal` = '" & id2 & "'"
        comando = conection.CreateCommand()
        comando.CommandType = CommandType.Text
        comando.CommandText = cSQL
        Dim CampoImagen As Byte() = comando.ExecuteScalar()

        Dim Bin As New IO.MemoryStream(CampoImagen)
        Dim Resultado As Image = Image.FromStream(Bin)
        Pbimagen.Image = Resultado
        conection.Close()
    End Function

    Private Sub Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        identificadortext.Enabled = False
        razaanimal.Enabled = False
        sexobox.Enabled = False
        colorbx.Enabled = False
        edadbox.Enabled = False
        arreglo = llenararreglo()
        cedulaarreglo = llenararreglocedula()





    End Sub

    Public Function llenararreglocedula() As Integer()

        'variables de conexion con servidor mysql
        Dim conection As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand
        Dim resultados As String
        'asignacion de propiedades a conector
        comando.Connection = conection
        'conexion con base de datos
        Try
            conection.ConnectionString = "server=localhost;database=poblacionganadera;user id=root;pwd=;"
            conection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        comando = New MySqlCommand("SELECT * FROM registroganado")
        'La consulta de la línea anterior debe devolver únicamente un registro
        comando.Connection = conection
        Dim rea As MySqlDataReader = comando.ExecuteReader()
        Dim i As Integer
        tamaño = 0
        i = 0
        While rea.Read
            tamaño = tamaño + 1
        End While
        conection.Close()

        Try
            conection.ConnectionString = "server=localhost;database=poblacionganadera;user id=root;pwd=;"
            conection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        comando = New MySqlCommand("SELECT * FROM registroganado")
        'La consulta de la línea anterior debe devolver únicamente un registro
        comando.Connection = conection
        Dim reader As MySqlDataReader = comando.ExecuteReader()

        Dim cedulaarreglo(tamaño - 1) As Integer
        If reader.HasRows Then
            Do While reader.Read()

                cedulaarreglo(i) = reader.GetValue(0)
                i = i + 1
            Loop
        End If
        conection.Close()
        Return cedulaarreglo
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Dim pos As Integer
        pos = 0
        For i = 0 To arreglo.Length - 1 Step 1
            If idseg = arreglo(i) Then
                pos = i
            End If
        Next
        If pos - 1 = 0 Then
            btnatras.Hide()
        End If
        If pos > 0 Then
            btnadelante.Show()
            pos = pos - 1
            Me.llenarcampos(cedulaarreglo(pos), arreglo(pos))
            Me.Bytes_Imagen(cedulaarreglo(pos), arreglo(pos))
            Me.Refresh()
            Me.Show()
        End If


    End Sub

    Public Function llenararreglo() As Integer()

        'variables de conexion con servidor mysql
        Dim conection As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand
        Dim resultados As String
        'asignacion de propiedades a conector
        comando.Connection = conection
        'conexion con base de datos
        Try
            conection.ConnectionString = "server=localhost;database=poblacionganadera;user id=root;pwd=;"
            conection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        comando = New MySqlCommand("SELECT * FROM registroganado")
        'La consulta de la línea anterior debe devolver únicamente un registro
        comando.Connection = conection
        Dim rea As MySqlDataReader = comando.ExecuteReader()
        Dim i As Integer
        tamaño = 0
        i = 0
        While rea.Read
            tamaño = tamaño + 1
        End While
        conection.Close()

        Try
            conection.ConnectionString = "server=localhost;database=poblacionganadera;user id=root;pwd=;"
            conection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        comando = New MySqlCommand("SELECT * FROM registroganado")
        'La consulta de la línea anterior debe devolver únicamente un registro
        comando.Connection = conection
        Dim reader As MySqlDataReader = comando.ExecuteReader()

        Dim arreglo(tamaño - 1) As Integer
        If reader.HasRows Then
            Do While reader.Read()

                arreglo(i) = reader.GetValue(6)
                i = i + 1
            Loop
        End If
        conection.Close()
        Return arreglo
    End Function

    Public Function llenarcampos(id As String, id2 As String)

        'variables de conexion con servidor mysql
        Dim conection As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand
        Dim resultados As String
        'asignacion de propiedades a conector
        comando.Connection = conection
        'conexion con base de datos
        Try
            conection.ConnectionString = "server=localhost;database=poblacionganadera;user id=root;pwd=;"
            conection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        comando = New MySqlCommand("SELECT * FROM registroganado where cedula ='" & id & "' AND `id animal` = '" & id2 & "' ")
        'La consulta de la línea anterior debe devolver únicamente un registro
        comando.Connection = conection
        Dim reader As MySqlDataReader = comando.ExecuteReader()
        If reader.Read() Then

            cedulaprop.Text = reader(0).ToString()
            nombreProp.Text = reader(1).ToString()
            apellidoprop.Text = reader(2).ToString()
            telefonoprop.Text = reader(3).ToString()
            verdaanimal.Text = reader(4).ToString()
            fincaanimal.Text = reader(5).ToString()
            identificadortext.Text = reader(6).ToString()
            razaanimal.Text = reader(7).ToString()
            sexobox.Text = reader(8).ToString()
            tipoanimal.Text = reader(9).ToString()
            boxconsulta.Text = reader(10).ToString()
            diagnostico.Text = reader(11).ToString
            colorbx.Text = reader(12).ToString
            pesobox.Value = reader(13).ToString
            edadbox.Value = reader(14).ToString

            nombreProp.ForeColor = Color.White
            apellidoprop.ForeColor = Color.White
            cedulaprop.ForeColor = Color.White
            telefonoprop.ForeColor = Color.White
            verdaanimal.ForeColor = Color.White
            razaanimal.ForeColor = Color.White
            fincaanimal.ForeColor = Color.White
            identificadortext.ForeColor = Color.White
            sexobox.ForeColor = Color.White
            tipoanimal.ForeColor = Color.White
            diagnostico.ForeColor = Color.White
            colorbx.ForeColor = Color.White
        End If
        conection.Close()

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnadelante.Click
        Dim pos As Integer
        pos = 0
        For i = 0 To arreglo.Length - 1 Step 1
            If idseg = arreglo(i) Then
                pos = i
            End If
        Next
        If pos + 1 = arreglo.Length - 1 Then
            btnadelante.Hide()
        End If
        If pos < arreglo.Length - 1 Then
            btnatras.Show()
            pos = pos + 1
            Me.llenarcampos(cedulaarreglo(pos), arreglo(pos))
            Me.Bytes_Imagen(cedulaarreglo(pos), arreglo(pos))
            Me.Refresh()
            Me.Show()
        End If


    End Sub

    Private Sub Pbimagen_Click_1(sender As Object, e As EventArgs) Handles Pbimagen.Click
        ofd.Filter = "Archivo de imagen |*.jpg| Archivo Png |*.png"
        Dim resultado As DialogResult
        resultado = ofd.ShowDialog()
        If resultado = DialogResult.OK Then
            Pbimagen.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub




    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Close()
        busqueda.Show()
    End Sub

    Private Sub btnañadir_Click(sender As Object, e As EventArgs) Handles btnañadir.Click
        Dim dlgR As DialogResult

        dlgR = MessageBox.Show("Estas a punto de editar el registro actual,¿deseas continuar?",
            "Attention!", MessageBoxButtons.YesNo)

        ' then test it:
        If dlgR = DialogResult.Yes Then
            'variables de conexion con servidor mysql
            Dim conection As MySqlConnection = New MySqlConnection
            Dim comando As MySqlCommand = New MySqlCommand
            'asignacion de propiedades a conector
            comando.Connection = conection
            'conexion con base de datos
            Try
                conection.ConnectionString = "server=localhost;database=poblacionganadera;user id=root;pwd=;"
                conection.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            comprob = 1
            Try
                If (nombreProp.Text = "Nombre" Or apellidoprop.Text = "Apellido" Or cedulaprop.Text = "Cedula" Or
                telefonoprop.Text = "N# Telefono" Or verdaanimal.Text = "Vereda" Or razaanimal.Text = "Raza" Or fincaanimal.Text = "Finca" Or
                identificadortext.Text = "Nombre Identificador" Or sexobox.Text = "" Or tipoanimal.Text = "" Or boxconsulta.Text = "") Then
                    comprob = 2
                    MsgBox("Error Campos vacios", MsgBoxStyle.Critical)
                End If
                If comprob = 1 Then

                    If diagnostico.Text = "Diagnostico" Then
                        diagnostico.Text = "Sin diagnostico"
                    End If

                    If cantidadid = 0 Then
                        Try
                            ''comando.CommandText = "INSERT INTO registroganado VALUES(" & Me.cedulaprop.Text.ToLower & ",'" & Me.nombreProp.Text.ToLower & "','" & Me.apellidoprop.Text.ToLower & "'," & Me.telefonoprop.Text.ToLower & ",'" & Me.verdaanimal.Text.ToLower & "','" & Me.fincaanimal.Text.ToLower & "','" & Me.identificadortext.Text.ToLower & "','" & Me.razaanimal.Text.ToLower & "','" & Me.sexobox.Text.ToLower & "','" & Me.tipoanimal.Text.ToLower & "','" & Me.boxconsulta.Text.ToLower & "','" & Me.diagnostictext.Text.ToLower & "','" & Me.medictext.Text.ToLower & "',@Imagen)"
                            comando.CommandText = "UPDATE registroganado SET `cedula`='" &
                                Me.cedulaprop.Text.ToLower & "' , nombre = '" &
                                Me.nombreProp.Text.ToLower & "' , apellido = '" &
                                Me.apellidoprop.Text.ToLower & "', telefono = '" &
                                Me.telefonoprop.Text.ToLower & "', vereda = '" &
                                Me.verdaanimal.Text.ToLower & "', finca = '" &
                                Me.fincaanimal.Text.ToLower & "', tipo = '" &
                                Me.tipoanimal.Text.ToLower & "',Diagnostico = '" &
                                Me.diagnostico.Text.ToLower & "',foto=@Imagen WHERE cedula = '" & cedula_prim & "' AND `id animal` = '" & idseg & "'"
                            Dim ms As MemoryStream
                            ms = New MemoryStream()
                            Pbimagen.Image.Save(ms, ImageFormat.Jpeg)
                            Dim abyte As Byte()
                            abyte = ms.ToArray()
                            comando.Parameters.AddWithValue("Imagen", abyte)


                            comando.ExecuteNonQuery()
                            MsgBox("Datos actualizados correctamente ", MsgBoxStyle.MsgBoxSetForeground)
                            identificadortext.Text = "Nombre Identificador"
                            diagnostico.Text = "Diagnostico"
                            conection.Close()
                            Me.Close()
                            busqueda.Show()
                        Catch ex As MySqlException
                            MsgBox(ex)
                        End Try

                    Else
                        MsgBox("Identificador repetido", MsgBoxStyle.Critical, "Error")
                    End If

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

End Class