<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class busqueda
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
        Me.TITULO = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Combodueño = New System.Windows.Forms.ComboBox()
        Me.textdueño = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sexobox = New System.Windows.Forms.ComboBox()
        Me.razabox = New System.Windows.Forms.ComboBox()
        Me.veredabox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tabla = New System.Windows.Forms.DataGridView()
        Me.Cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vereda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.finca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.botonpdf = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TITULO
        '
        Me.TITULO.AutoSize = True
        Me.TITULO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TITULO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TITULO.Font = New System.Drawing.Font("Tw Cen MT Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TITULO.ForeColor = System.Drawing.Color.Cornsilk
        Me.TITULO.Location = New System.Drawing.Point(326, 9)
        Me.TITULO.Name = "TITULO"
        Me.TITULO.Size = New System.Drawing.Size(140, 40)
        Me.TITULO.TabIndex = 1
        Me.TITULO.Text = "BUSQUEDA"
        Me.TITULO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Combodueño)
        Me.GroupBox1.Controls.Add(Me.textdueño)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.sexobox)
        Me.GroupBox1.Controls.Add(Me.razabox)
        Me.GroupBox1.Controls.Add(Me.veredabox)
        Me.GroupBox1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 147)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BUSQUEDA"
        '
        'Combodueño
        '
        Me.Combodueño.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Combodueño.ForeColor = System.Drawing.Color.Orange
        Me.Combodueño.FormattingEnabled = True
        Me.Combodueño.Location = New System.Drawing.Point(62, 95)
        Me.Combodueño.Name = "Combodueño"
        Me.Combodueño.Size = New System.Drawing.Size(228, 28)
        Me.Combodueño.TabIndex = 8
        '
        'textdueño
        '
        Me.textdueño.AutoSize = True
        Me.textdueño.Location = New System.Drawing.Point(10, 103)
        Me.textdueño.Name = "textdueño"
        Me.textdueño.Size = New System.Drawing.Size(46, 20)
        Me.textdueño.TabIndex = 7
        Me.textdueño.Text = "Dueño"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(323, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Filtrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(453, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sexo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Raza"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Vereda"
        '
        'sexobox
        '
        Me.sexobox.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.sexobox.ForeColor = System.Drawing.Color.Orange
        Me.sexobox.FormattingEnabled = True
        Me.sexobox.Items.AddRange(New Object() {"Hembra", "Macho"})
        Me.sexobox.Location = New System.Drawing.Point(509, 47)
        Me.sexobox.Name = "sexobox"
        Me.sexobox.Size = New System.Drawing.Size(121, 28)
        Me.sexobox.TabIndex = 2
        '
        'razabox
        '
        Me.razabox.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.razabox.ForeColor = System.Drawing.Color.Orange
        Me.razabox.FormattingEnabled = True
        Me.razabox.Location = New System.Drawing.Point(278, 47)
        Me.razabox.Name = "razabox"
        Me.razabox.Size = New System.Drawing.Size(121, 28)
        Me.razabox.TabIndex = 1
        '
        'veredabox
        '
        Me.veredabox.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.veredabox.ForeColor = System.Drawing.Color.Orange
        Me.veredabox.FormattingEnabled = True
        Me.veredabox.Location = New System.Drawing.Point(62, 47)
        Me.veredabox.Name = "veredabox"
        Me.veredabox.Size = New System.Drawing.Size(121, 28)
        Me.veredabox.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tabla)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 262)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 187)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESULTADOS"
        '
        'tabla
        '
        Me.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla.Location = New System.Drawing.Point(6, 25)
        Me.tabla.Name = "tabla"
        Me.tabla.RowTemplate.Height = 25
        Me.tabla.Size = New System.Drawing.Size(764, 150)
        Me.tabla.TabIndex = 0
        '
        'Cedula
        '
        Me.Cedula.HeaderText = "cedulacol"
        Me.Cedula.Name = "Cedula"
        '
        'nombre
        '
        Me.nombre.HeaderText = "nombre"
        Me.nombre.Name = "nombre"
        '
        'telefono
        '
        Me.telefono.HeaderText = "telefono"
        Me.telefono.Name = "telefono"
        '
        'vereda
        '
        Me.vereda.HeaderText = "vereda"
        Me.vereda.Name = "vereda"
        '
        'finca
        '
        Me.finca.HeaderText = "finca"
        Me.finca.Name = "finca"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "cedula"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "vereda"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(671, 470)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 29)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Atras"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(12, 470)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 29)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'botonpdf
        '
        Me.botonpdf.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.botonpdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonpdf.ForeColor = System.Drawing.Color.White
        Me.botonpdf.Location = New System.Drawing.Point(486, 470)
        Me.botonpdf.Name = "botonpdf"
        Me.botonpdf.Size = New System.Drawing.Size(117, 29)
        Me.botonpdf.TabIndex = 7
        Me.botonpdf.Text = "Pdf"
        Me.botonpdf.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditar.ForeColor = System.Drawing.Color.White
        Me.btneditar.Location = New System.Drawing.Point(224, 470)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(117, 29)
        Me.btneditar.TabIndex = 8
        Me.btneditar.Text = "Revicion Unitaria"
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'busqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 505)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.botonpdf)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TITULO)
        Me.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "busqueda"
        Me.Text = "Busqueda"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TITULO As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents sexobox As ComboBox
    Friend WithEvents razabox As ComboBox
    Friend WithEvents veredabox As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Cedula As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents vereda As DataGridViewTextBoxColumn
    Friend WithEvents finca As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents textdueño As Label
    Friend WithEvents Combodueño As ComboBox
    Friend WithEvents botonpdf As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents tabla As DataGridView
End Class
