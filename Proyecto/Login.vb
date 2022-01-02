Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub Btningresar_Click(sender As Object, e As EventArgs) Handles Btningresar.Click
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
        'comprobacion de valores ingresados en login con bd
        comando.CommandText = "SELECT * FROM usuarios WHERE usuario='" + usuariotext.Text + "' and clave='" + contraseñatext.Text + "'"
        Dim reader As MySqlDataReader
        reader = comando.ExecuteReader
        'comprobacion de ingreso
        If (reader.HasRows <> False) Then
            reader.Read()
            Me.Hide() 'oculta el formulario actual
            home.Show() 'muestra el siguiente formulario
        Else
            MsgBox("Inicio Invalido", MsgBoxStyle.Critical)
        End If



    End Sub


    Private Sub usuariotext_Enter(sender As Object, e As EventArgs) Handles usuariotext.Enter
        If usuariotext.Text = "Usuario" Then
            usuariotext.Text = ""
            usuariotext.ForeColor = Color.Orange


        End If

    End Sub

    Private Sub contraseñatext_Enter(sender As Object, e As EventArgs) Handles contraseñatext.Enter
        If contraseñatext.Text = "Contraseña" Then
            contraseñatext.Text = ""
            contraseñatext.ForeColor = Color.Orange
            contraseñatext.UseSystemPasswordChar = True



        End If
    End Sub
    Private Sub usuariotext_Leave(sender As Object, e As EventArgs) Handles usuariotext.Leave
        If usuariotext.Text = "" Then
            usuariotext.Text = "Usuario"
            usuariotext.ForeColor = Color.White


        End If

    End Sub

    Private Sub contraseñatext_Leave(sender As Object, e As EventArgs) Handles contraseñatext.Leave
        If contraseñatext.Text = "" Then
            contraseñatext.Text = "Contraseña"
            contraseñatext.ForeColor = Color.White
            contraseñatext.UseSystemPasswordChar = False



        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
