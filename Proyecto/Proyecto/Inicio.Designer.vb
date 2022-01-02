<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.TITULO = New System.Windows.Forms.Label()
        Me.nombreProp = New System.Windows.Forms.TextBox()
        Me.usuariolabel = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.telefonoprop = New System.Windows.Forms.TextBox()
        Me.cedulaprop = New System.Windows.Forms.TextBox()
        Me.apellidoprop = New System.Windows.Forms.TextBox()
        Me.animallabel = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sexobox = New System.Windows.Forms.ComboBox()
        Me.identificadortext = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tipoanimal = New System.Windows.Forms.ComboBox()
        Me.razaanimal = New System.Windows.Forms.TextBox()
        Me.fincaanimal = New System.Windows.Forms.TextBox()
        Me.verdaanimal = New System.Windows.Forms.TextBox()
        Me.btnañadir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.atras = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.vetcon = New System.Windows.Forms.GroupBox()
        Me.edadbox = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.colorbx = New System.Windows.Forms.TextBox()
        Me.pesobox = New System.Windows.Forms.NumericUpDown()
        Me.diagnostico = New System.Windows.Forms.RichTextBox()
        Me.Pbimagen = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.boxconsulta = New System.Windows.Forms.ComboBox()
        Me.usuariolabel.SuspendLayout()
        Me.animallabel.SuspendLayout()
        Me.vetcon.SuspendLayout()
        CType(Me.edadbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pesobox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pbimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TITULO
        '
        Me.TITULO.AutoSize = True
        Me.TITULO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TITULO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TITULO.Font = New System.Drawing.Font("Tw Cen MT Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TITULO.ForeColor = System.Drawing.Color.Cornsilk
        Me.TITULO.Location = New System.Drawing.Point(283, 9)
        Me.TITULO.Name = "TITULO"
        Me.TITULO.Size = New System.Drawing.Size(264, 40)
        Me.TITULO.TabIndex = 0
        Me.TITULO.Text = "REGISTRO GANADERO"
        Me.TITULO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nombreProp
        '
        Me.nombreProp.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.nombreProp.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.nombreProp.ForeColor = System.Drawing.Color.White
        Me.nombreProp.Location = New System.Drawing.Point(17, 45)
        Me.nombreProp.Name = "nombreProp"
        Me.nombreProp.Size = New System.Drawing.Size(180, 25)
        Me.nombreProp.TabIndex = 1
        Me.nombreProp.Text = "Nombre"
        '
        'usuariolabel
        '
        Me.usuariolabel.Controls.Add(Me.TextBox1)
        Me.usuariolabel.Controls.Add(Me.telefonoprop)
        Me.usuariolabel.Controls.Add(Me.cedulaprop)
        Me.usuariolabel.Controls.Add(Me.apellidoprop)
        Me.usuariolabel.Controls.Add(Me.nombreProp)
        Me.usuariolabel.ForeColor = System.Drawing.Color.White
        Me.usuariolabel.Location = New System.Drawing.Point(12, 91)
        Me.usuariolabel.Name = "usuariolabel"
        Me.usuariolabel.Size = New System.Drawing.Size(482, 148)
        Me.usuariolabel.TabIndex = 2
        Me.usuariolabel.TabStop = False
        Me.usuariolabel.Text = "PROPIETARIO"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(120, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(10, 18)
        Me.TextBox1.TabIndex = 0
        '
        'telefonoprop
        '
        Me.telefonoprop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.telefonoprop.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.telefonoprop.ForeColor = System.Drawing.Color.White
        Me.telefonoprop.Location = New System.Drawing.Point(271, 98)
        Me.telefonoprop.Name = "telefonoprop"
        Me.telefonoprop.Size = New System.Drawing.Size(188, 25)
        Me.telefonoprop.TabIndex = 4
        Me.telefonoprop.Text = "N# Telefono"
        '
        'cedulaprop
        '
        Me.cedulaprop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.cedulaprop.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cedulaprop.ForeColor = System.Drawing.Color.White
        Me.cedulaprop.Location = New System.Drawing.Point(271, 45)
        Me.cedulaprop.Name = "cedulaprop"
        Me.cedulaprop.Size = New System.Drawing.Size(188, 25)
        Me.cedulaprop.TabIndex = 3
        Me.cedulaprop.Text = "Cedula"
        '
        'apellidoprop
        '
        Me.apellidoprop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.apellidoprop.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.apellidoprop.ForeColor = System.Drawing.Color.White
        Me.apellidoprop.Location = New System.Drawing.Point(17, 98)
        Me.apellidoprop.Name = "apellidoprop"
        Me.apellidoprop.Size = New System.Drawing.Size(180, 25)
        Me.apellidoprop.TabIndex = 2
        Me.apellidoprop.Text = "Apellido"
        '
        'animallabel
        '
        Me.animallabel.Controls.Add(Me.Label2)
        Me.animallabel.Controls.Add(Me.sexobox)
        Me.animallabel.Controls.Add(Me.identificadortext)
        Me.animallabel.Controls.Add(Me.Label1)
        Me.animallabel.Controls.Add(Me.tipoanimal)
        Me.animallabel.Controls.Add(Me.razaanimal)
        Me.animallabel.Controls.Add(Me.fincaanimal)
        Me.animallabel.Controls.Add(Me.verdaanimal)
        Me.animallabel.ForeColor = System.Drawing.Color.White
        Me.animallabel.Location = New System.Drawing.Point(12, 255)
        Me.animallabel.Name = "animallabel"
        Me.animallabel.Size = New System.Drawing.Size(482, 156)
        Me.animallabel.TabIndex = 4
        Me.animallabel.TabStop = False
        Me.animallabel.Text = "ANIMAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(271, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Sexo"
        '
        'sexobox
        '
        Me.sexobox.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.sexobox.ForeColor = System.Drawing.Color.Orange
        Me.sexobox.FormattingEnabled = True
        Me.sexobox.Items.AddRange(New Object() {"Hembra", "Macho"})
        Me.sexobox.Location = New System.Drawing.Point(320, 77)
        Me.sexobox.Name = "sexobox"
        Me.sexobox.Size = New System.Drawing.Size(139, 27)
        Me.sexobox.TabIndex = 8
        '
        'identificadortext
        '
        Me.identificadortext.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.identificadortext.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.identificadortext.ForeColor = System.Drawing.Color.White
        Me.identificadortext.Location = New System.Drawing.Point(271, 35)
        Me.identificadortext.Name = "identificadortext"
        Me.identificadortext.Size = New System.Drawing.Size(188, 25)
        Me.identificadortext.TabIndex = 7
        Me.identificadortext.Text = "Nombre Identificador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(271, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Etapa"
        '
        'tipoanimal
        '
        Me.tipoanimal.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.tipoanimal.ForeColor = System.Drawing.Color.Orange
        Me.tipoanimal.FormattingEnabled = True
        Me.tipoanimal.Items.AddRange(New Object() {"Cria", "Joven", "Adulta"})
        Me.tipoanimal.Location = New System.Drawing.Point(320, 119)
        Me.tipoanimal.Name = "tipoanimal"
        Me.tipoanimal.Size = New System.Drawing.Size(139, 27)
        Me.tipoanimal.TabIndex = 5
        '
        'razaanimal
        '
        Me.razaanimal.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.razaanimal.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.razaanimal.ForeColor = System.Drawing.Color.White
        Me.razaanimal.Location = New System.Drawing.Point(17, 119)
        Me.razaanimal.Name = "razaanimal"
        Me.razaanimal.Size = New System.Drawing.Size(180, 25)
        Me.razaanimal.TabIndex = 4
        Me.razaanimal.Text = "Raza"
        '
        'fincaanimal
        '
        Me.fincaanimal.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.fincaanimal.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.fincaanimal.ForeColor = System.Drawing.Color.White
        Me.fincaanimal.Location = New System.Drawing.Point(17, 77)
        Me.fincaanimal.Name = "fincaanimal"
        Me.fincaanimal.Size = New System.Drawing.Size(180, 25)
        Me.fincaanimal.TabIndex = 3
        Me.fincaanimal.Text = "Finca"
        '
        'verdaanimal
        '
        Me.verdaanimal.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.verdaanimal.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.verdaanimal.ForeColor = System.Drawing.Color.White
        Me.verdaanimal.Location = New System.Drawing.Point(17, 34)
        Me.verdaanimal.Name = "verdaanimal"
        Me.verdaanimal.Size = New System.Drawing.Size(180, 25)
        Me.verdaanimal.TabIndex = 2
        Me.verdaanimal.Text = "Vereda"
        '
        'btnañadir
        '
        Me.btnañadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnañadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnañadir.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnañadir.ForeColor = System.Drawing.Color.White
        Me.btnañadir.Location = New System.Drawing.Point(105, 421)
        Me.btnañadir.Name = "btnañadir"
        Me.btnañadir.Size = New System.Drawing.Size(126, 38)
        Me.btnañadir.TabIndex = 5
        Me.btnañadir.Text = "Agregar"
        Me.btnañadir.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(368, 421)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 38)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Limpiar Campos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'atras
        '
        Me.atras.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.atras.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.atras.ForeColor = System.Drawing.Color.White
        Me.atras.Location = New System.Drawing.Point(621, 421)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(126, 38)
        Me.atras.TabIndex = 6
        Me.atras.Text = "Atras"
        Me.atras.UseVisualStyleBackColor = False
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'vetcon
        '
        Me.vetcon.Controls.Add(Me.edadbox)
        Me.vetcon.Controls.Add(Me.Label6)
        Me.vetcon.Controls.Add(Me.Label5)
        Me.vetcon.Controls.Add(Me.Label4)
        Me.vetcon.Controls.Add(Me.colorbx)
        Me.vetcon.Controls.Add(Me.pesobox)
        Me.vetcon.Controls.Add(Me.diagnostico)
        Me.vetcon.Controls.Add(Me.Pbimagen)
        Me.vetcon.Controls.Add(Me.Label3)
        Me.vetcon.Controls.Add(Me.boxconsulta)
        Me.vetcon.ForeColor = System.Drawing.Color.White
        Me.vetcon.Location = New System.Drawing.Point(518, 91)
        Me.vetcon.Name = "vetcon"
        Me.vetcon.Size = New System.Drawing.Size(321, 324)
        Me.vetcon.TabIndex = 8
        Me.vetcon.TabStop = False
        Me.vetcon.Text = "SALUD"
        '
        'edadbox
        '
        Me.edadbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.edadbox.ForeColor = System.Drawing.Color.White
        Me.edadbox.Location = New System.Drawing.Point(98, 114)
        Me.edadbox.Name = "edadbox"
        Me.edadbox.Size = New System.Drawing.Size(53, 25)
        Me.edadbox.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Edad (Años)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Color"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Peso (Kg)"
        '
        'colorbx
        '
        Me.colorbx.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.colorbx.ForeColor = System.Drawing.Color.White
        Me.colorbx.Location = New System.Drawing.Point(51, 76)
        Me.colorbx.Name = "colorbx"
        Me.colorbx.Size = New System.Drawing.Size(100, 25)
        Me.colorbx.TabIndex = 14
        '
        'pesobox
        '
        Me.pesobox.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pesobox.ForeColor = System.Drawing.Color.White
        Me.pesobox.Location = New System.Drawing.Point(103, 38)
        Me.pesobox.Name = "pesobox"
        Me.pesobox.Size = New System.Drawing.Size(46, 25)
        Me.pesobox.TabIndex = 13
        '
        'diagnostico
        '
        Me.diagnostico.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.diagnostico.ForeColor = System.Drawing.Color.White
        Me.diagnostico.Location = New System.Drawing.Point(6, 199)
        Me.diagnostico.Name = "diagnostico"
        Me.diagnostico.Size = New System.Drawing.Size(309, 119)
        Me.diagnostico.TabIndex = 12
        Me.diagnostico.Text = "Diagnostico"
        '
        'Pbimagen
        '
        Me.Pbimagen.Image = CType(resources.GetObject("Pbimagen.Image"), System.Drawing.Image)
        Me.Pbimagen.Location = New System.Drawing.Point(164, 15)
        Me.Pbimagen.Name = "Pbimagen"
        Me.Pbimagen.Size = New System.Drawing.Size(143, 143)
        Me.Pbimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbimagen.TabIndex = 11
        Me.Pbimagen.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Consulta Veterinaria"
        '
        'boxconsulta
        '
        Me.boxconsulta.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.boxconsulta.ForeColor = System.Drawing.Color.White
        Me.boxconsulta.FormattingEnabled = True
        Me.boxconsulta.Items.AddRange(New Object() {"Si", "No"})
        Me.boxconsulta.Location = New System.Drawing.Point(143, 164)
        Me.boxconsulta.Name = "boxconsulta"
        Me.boxconsulta.Size = New System.Drawing.Size(46, 27)
        Me.boxconsulta.TabIndex = 1
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(851, 467)
        Me.Controls.Add(Me.vetcon)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnañadir)
        Me.Controls.Add(Me.animallabel)
        Me.Controls.Add(Me.usuariolabel)
        Me.Controls.Add(Me.TITULO)
        Me.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.usuariolabel.ResumeLayout(False)
        Me.usuariolabel.PerformLayout()
        Me.animallabel.ResumeLayout(False)
        Me.animallabel.PerformLayout()
        Me.vetcon.ResumeLayout(False)
        Me.vetcon.PerformLayout()
        CType(Me.edadbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pesobox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pbimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TITULO As Label
    Friend WithEvents nombreProp As TextBox
    Friend WithEvents usuariolabel As GroupBox
    Friend WithEvents telefonoprop As TextBox
    Friend WithEvents cedulaprop As TextBox
    Friend WithEvents apellidoprop As TextBox
    Friend WithEvents animallabel As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tipoanimal As ComboBox
    Friend WithEvents razaanimal As TextBox
    Friend WithEvents fincaanimal As TextBox
    Friend WithEvents verdaanimal As TextBox
    Friend WithEvents btnañadir As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents identificadortext As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents sexobox As ComboBox
    Friend WithEvents atras As Button
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents vetcon As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents boxconsulta As ComboBox
    Friend WithEvents Pbimagen As PictureBox
    Friend WithEvents diagnostico As RichTextBox
    Friend WithEvents edadbox As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents colorbx As TextBox
    Friend WithEvents pesobox As NumericUpDown
End Class
