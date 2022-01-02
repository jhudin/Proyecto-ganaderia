Imports System.IO
Imports System
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class Inicio
    Dim comprob, cantidadid As Integer
    Dim sql3 As String
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Inicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        home.Show()
    End Sub

    Private Sub nombreProp_Enter(sender As Object, e As EventArgs) Handles nombreProp.Enter
        If nombreProp.Text = "Nombre" Then
            nombreProp.Text = ""
            nombreProp.ForeColor = Color.Orange


        End If
    End Sub

    Private Sub apellidoprop_Enter(sender As Object, e As EventArgs) Handles apellidoprop.Enter
        If apellidoprop.Text = "Apellido" Then
            apellidoprop.Text = ""
            apellidoprop.ForeColor = Color.Orange


        End If
    End Sub

    Private Sub cedulaprop_Enter(sender As Object, e As EventArgs) Handles cedulaprop.Enter
        If cedulaprop.Text = "Cedula" Then
            cedulaprop.Text = ""
            cedulaprop.ForeColor = Color.Orange


        End If
    End Sub

    Private Sub telefonoprop_Enter(sender As Object, e As EventArgs) Handles telefonoprop.Enter
        If telefonoprop.Text = "N# Telefono" Then
            telefonoprop.Text = ""
            telefonoprop.ForeColor = Color.Orange


        End If
    End Sub

    Private Sub verdaanimal_Enter(sender As Object, e As EventArgs) Handles verdaanimal.Enter
        If verdaanimal.Text = "Vereda" Then
            verdaanimal.Text = ""
            verdaanimal.ForeColor = Color.Orange


        End If
    End Sub



    Private Sub razaanimal_Enter(sender As Object, e As EventArgs) Handles razaanimal.Enter
        If razaanimal.Text = "Raza" Then
            razaanimal.Text = ""
            razaanimal.ForeColor = Color.Orange


        End If
    End Sub

    Private Sub fincaanimal_Enter(sender As Object, e As EventArgs) Handles fincaanimal.Enter
        If fincaanimal.Text = "Finca" Then
            fincaanimal.Text = ""
            fincaanimal.ForeColor = Color.Orange


        End If
    End Sub


    Private Sub medictext_Enter(sender As Object, e As EventArgs)
        If colorbx.Text = "" Then
            colorbx.Text = ""
            colorbx.ForeColor = Color.Orange


        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub nombreProp_Leave(sender As Object, e As EventArgs) Handles nombreProp.Leave
        If nombreProp.Text = "" Then
            nombreProp.Text = "Nombre"
            nombreProp.ForeColor = Color.White


        End If
    End Sub

    Private Sub apellidoprop_Leave(sender As Object, e As EventArgs) Handles apellidoprop.Leave
        If apellidoprop.Text = "" Then
            apellidoprop.Text = "Apellido"
            apellidoprop.ForeColor = Color.White


        End If
    End Sub

    Private Sub cedulaprop_Leave(sender As Object, e As EventArgs) Handles cedulaprop.Leave
        If cedulaprop.Text = "" Then
            cedulaprop.Text = "Cedula"
            cedulaprop.ForeColor = Color.White


        End If
    End Sub

    Private Sub telefonoprop_Leave(sender As Object, e As EventArgs) Handles telefonoprop.Leave
        If telefonoprop.Text = "" Then
            telefonoprop.Text = "N# Telefono"
            telefonoprop.ForeColor = Color.White


        End If
    End Sub

    Private Sub verdaanimal_Leave(sender As Object, e As EventArgs) Handles verdaanimal.Leave
        If verdaanimal.Text = "" Then
            verdaanimal.Text = "Vereda"
            verdaanimal.ForeColor = Color.White


        End If
    End Sub


    Private Sub razaanimal_Leave(sender As Object, e As EventArgs) Handles razaanimal.Leave
        If razaanimal.Text = "" Then
            razaanimal.Text = "Raza"
            razaanimal.ForeColor = Color.White


        End If
    End Sub

    Private Sub fincaanimal_Leave(sender As Object, e As EventArgs) Handles fincaanimal.Leave
        If fincaanimal.Text = "" Then
            fincaanimal.Text = "Finca"
            fincaanimal.ForeColor = Color.White


        End If
    End Sub



    Private Sub medictext_Leave(sender As Object, e As EventArgs)
        If colorbx.Text = "" Then
            colorbx.Text = ""
            colorbx.ForeColor = Color.White


        End If
    End Sub

    Private Sub btnañadir_Click(sender As Object, e As EventArgs) Handles btnañadir.Click
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
        If identificadortext.Text <> "Nombre Identificador" Then
            sql3 = "SELECT COUNT(*), `id animal` FROM registroganado WHERE `id animal` =" & identificadortext.Text & ""
            Dim consulta As New MySqlDataAdapter(sql3, conection)
            consulta.SelectCommand.CommandType = CommandType.Text
            Dim tabla As New DataTable
            consulta.Fill(tabla)
            cantidadid = tabla.Rows(0).Item(0)
        End If


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
                    comando.CommandText = "INSERT INTO registroganado VALUES(" & Me.cedulaprop.Text.ToLower & ",'" & Me.nombreProp.Text.ToLower & "','" & Me.apellidoprop.Text.ToLower & "'," & Me.telefonoprop.Text.ToLower & ",'" & Me.verdaanimal.Text.ToLower & "','" & Me.fincaanimal.Text.ToLower & "','" & Me.identificadortext.Text.ToLower & "','" & Me.razaanimal.Text.ToLower & "','" & Me.sexobox.Text.ToLower & "','" & Me.tipoanimal.Text.ToLower & "','" & Me.boxconsulta.Text.ToLower & "','" & Me.diagnostico.Text.ToLower & "','" & Me.colorbx.Text.ToLower & "','" & Me.pesobox.Text.ToLower & "','" & Me.edadbox.Text.ToLower & "',@Imagen)"
                    Dim ms As MemoryStream
                    ms = New MemoryStream()
                    Pbimagen.Image.Save(ms, ImageFormat.Jpeg)
                    Dim abyte As Byte()
                    abyte = ms.ToArray()
                    comando.Parameters.AddWithValue("Imagen", abyte)





                    comando.ExecuteNonQuery()
                    MsgBox("Datos agregados correctamente ", MsgBoxStyle.MsgBoxSetForeground)
                    identificadortext.Text = "Nombre Identificador"
                    colorbx.Text = ""
                    diagnostico.Text = "Diagnostico"
                Else
                    MsgBox("Identificador repetido", MsgBoxStyle.Critical, "Error")
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub identificadortext_Enter(sender As Object, e As EventArgs) Handles identificadortext.Enter
        If identificadortext.Text = "Nombre Identificador" Then
            identificadortext.Text = ""
            identificadortext.ForeColor = Color.Orange


        End If
    End Sub

    Private Sub identificadortext_Leave(sender As Object, e As EventArgs) Handles identificadortext.Leave
        If identificadortext.Text = "" Then
            identificadortext.Text = "Nombre Identificador"
            identificadortext.ForeColor = Color.White


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'restablecimiento de los campos de texto
        nombreProp.Text = "Nombre"
        apellidoprop.Text = "Apellido"
        cedulaprop.Text = "Cedula"
        telefonoprop.Text = "N# Telefono"
        verdaanimal.Text = "Vereda"
        razaanimal.Text = "Raza"
        fincaanimal.Text = "Finca"
        identificadortext.Text = "Nombre Identificador"
        sexobox.Text = ""
        tipoanimal.Text = ""
        diagnostico.Text = "Diagnostico"
        colorbx.Text = ""

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
    End Sub


    Private Sub Pbimagen_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        ofd.Filter = "Archivo de imagen |*.jpg| Archivo Png |*.png"
        Dim resultado As DialogResult
        resultado = ofd.ShowDialog()
        If resultado = DialogResult.OK Then
            Pbimagen.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub


    Private Sub diagnostico_Enter(sender As Object, e As EventArgs) Handles diagnostico.Enter
        If diagnostico.Text = "Diagnostico" Then
            diagnostico.Text = ""
            diagnostico.ForeColor = Color.Orange


        End If
    End Sub

    Private Sub diagnostico_Leave(sender As Object, e As EventArgs) Handles diagnostico.Leave
        If diagnostico.Text = "" Then
            diagnostico.Text = "Diagnostico"
            diagnostico.ForeColor = Color.White


        End If
    End Sub

    Private Sub colorbx_Enter(sender As Object, e As EventArgs) Handles colorbx.Enter
        colorbx.ForeColor = Color.Orange
    End Sub

    Private Sub pesobox_Enter(sender As Object, e As EventArgs) Handles pesobox.Enter
        pesobox.ForeColor = Color.Orange
    End Sub
    Private Sub edadbox_Enter(sender As Object, e As EventArgs) Handles edadbox.Enter
        edadbox.ForeColor = Color.Orange
    End Sub

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Close()
        home.Show()
    End Sub
End Class