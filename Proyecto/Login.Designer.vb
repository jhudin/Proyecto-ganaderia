<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Btningresar = New System.Windows.Forms.Button()
        Me.usuariotext = New System.Windows.Forms.TextBox()
        Me.contraseñatext = New System.Windows.Forms.TextBox()
        Me.titulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btningresar
        '
        Me.Btningresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Btningresar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btningresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Btningresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btningresar.ForeColor = System.Drawing.Color.White
        Me.Btningresar.Location = New System.Drawing.Point(46, 468)
        Me.Btningresar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btningresar.Name = "Btningresar"
        Me.Btningresar.Size = New System.Drawing.Size(246, 39)
        Me.Btningresar.TabIndex = 0
        Me.Btningresar.Text = "Ingresar"
        Me.Btningresar.UseVisualStyleBackColor = False
        '
        'usuariotext
        '
        Me.usuariotext.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.usuariotext.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usuariotext.ForeColor = System.Drawing.SystemColors.Info
        Me.usuariotext.Location = New System.Drawing.Point(46, 364)
        Me.usuariotext.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.usuariotext.Name = "usuariotext"
        Me.usuariotext.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.usuariotext.Size = New System.Drawing.Size(245, 25)
        Me.usuariotext.TabIndex = 2
        Me.usuariotext.Text = "Usuario"
        '
        'contraseñatext
        '
        Me.contraseñatext.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.contraseñatext.ForeColor = System.Drawing.SystemColors.Info
        Me.contraseñatext.Location = New System.Drawing.Point(46, 409)
        Me.contraseñatext.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.contraseñatext.Name = "contraseñatext"
        Me.contraseñatext.Size = New System.Drawing.Size(245, 25)
        Me.contraseñatext.TabIndex = 3
        Me.contraseñatext.Text = "Contraseña"
        '
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.titulo.Location = New System.Drawing.Point(24, 42)
        Me.titulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(306, 21)
        Me.titulo.TabIndex = 6
        Me.titulo.Text = "POBLACION GANADERA DE GUACHETA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(46, 69)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 276)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(343, 533)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.contraseñatext)
        Me.Controls.Add(Me.usuariotext)
        Me.Controls.Add(Me.Btningresar)
        Me.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btningresar As Button
    Friend WithEvents usuariotext As TextBox
    Friend WithEvents contraseñatext As TextBox
    Friend WithEvents titulo As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
