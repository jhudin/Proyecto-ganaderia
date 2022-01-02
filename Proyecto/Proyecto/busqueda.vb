Imports MySql.Data.MySqlClient
Imports System.ID
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System
Imports System.Drawing.Image
Imports System.Drawing.Imaging


Public Class busqueda
    'user=your mysql user name; password=your password; database=your database name
    Dim Connection As New MySqlConnection("server=localhost; user=root; password=; database=poblacionganadera")
    Dim MySQLCMD As New MySqlCommand
    Dim MySQLDA As New MySqlDataAdapter
    Dim DT As New DataTable
    Dim datos, datos1, datos2 As DataSet

    Dim Table_Name As String = " registroganado " 'your table name
    Dim Data As Integer

    Dim LoadImagesStr As Boolean = False
    Dim sql, veredas, raza, sexo, Id, dueño As String
    Dim IMG_FileNameInput As String
    Dim StatusInput As String = "Save"
    Dim SqlCmdSearchstr As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        home.Show()
    End Sub

    Private Sub busqueda_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        home.Show()

    End Sub
    Private Function AllCellsSelected(dgv As DataGridView) As Boolean
        AllCellsSelected = (tabla.SelectedCells.Count = (tabla.RowCount * tabla.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        Dim responder, style, sql2
        style = vbYesNo + vbCritical + vbDefaultButton2
        responder = MsgBox("Desea eliminar el registro correspondiente al codigo animal " & tabla.CurrentRow.Cells(6).Value.ToString(), style, 1000)
        If responder = vbYes Then
            Try
                sql2 = "DELETE FROM " & Table_Name & " WHERE `id animal`=" & tabla.CurrentRow.Cells(6).Value.ToString() & ""
                MySQLCMD.CommandType = CommandType.Text
                ''MsgBox(sql2)
                MySQLCMD.CommandText = sql2
                MySQLCMD.Connection = Connection
                MySQLCMD.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Failed to delete" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            End Try

        End If
        Connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles botonpdf.Click
        crearpdf()
    End Sub

    Private Sub tabla_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            If AllCellsSelected(tabla) = False Then
                If e.Button = MouseButtons.Left Then
                    tabla.CurrentCell = tabla(e.ColumnIndex, e.RowIndex)
                    Dim i As Integer
                    With tabla
                        If e.RowIndex >= 0 Then
                            i = .CurrentRow.Index
                            LoadImagesStr = True
                            Id = .Rows(i).Cells("6").Value.ToString

                            ShowData()
                        End If
                    End With
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click

        Dim id, id2 As String
        id = tabla.CurrentRow.Cells(0).Value.ToString()
        id2 = tabla.CurrentRow.Cells(6).Value.ToString()
        Editar.llenarcampos(id, id2)
        Editar.Bytes_Imagen(id, id2)
        Me.Close()
        Editar.Show()
        home.Hide()

    End Sub

    Private Sub tabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub tabla_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles tabla.CellPainting
        If (e.RowIndex < 0 Or e.ColumnIndex < 0) Then Return

        If tabla.Rows(e.RowIndex).Cells(e.ColumnIndex).ValueType = GetType(Byte()) Then
            CType(tabla.Rows(e.RowIndex).Cells(e.ColumnIndex),
              DataGridViewImageCell).ImageLayout = DataGridViewImageCellLayout.Zoom
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowData()
        botonpdf.Enabled = True
        btneditar.Enabled = True
    End Sub

    Dim Col0Ram As Integer = 0

    Private Sub ShowData()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        veredas = ""
        raza = ""
        sexo = ""
        dueño = ""
        If veredabox.Text <> "" Then
            veredas = " WHERE vereda ='" & veredabox.Text & "'"
        Else
            veredas = " WHERE "
        End If

        If razabox.Text <> "" Then
            If veredabox.Text <> "" Then
                raza = " and raza= '" & razabox.Text & "'"
            Else
                raza = " raza= '" & razabox.Text & "'"
            End If
        End If



        If Combodueño.Text <> "" Then
            If veredabox.Text <> "" Or razabox.Text <> "" Then
                dueño = " and concat(nombre,' ',apellido) = '" & Combodueño.Text & "'"
            Else
                dueño = " concat(nombre,' ',apellido) = '" & Combodueño.Text & "'"
            End If

        End If

        If sexobox.Text <> "" Then
            If veredabox.Text <> "" Or razabox.Text <> "" Or Combodueño.Text <> "" Then
                sexo = " and sexo= '" & sexobox.Text & "'"
            Else
                sexo = " sexo= '" & sexobox.Text & "'"
            End If

        End If

        If sexobox.Text = "" And razabox.Text = "" And veredabox.Text = "" And Combodueño.Text = "" Then
            veredas = ""
        End If

        Try
            MySQLCMD.CommandType = CommandType.Text
            sql = "SELECT cedula,nombre,apellido,telefono,vereda,finca,`id animal`,raza,sexo,tipo,Consulta,Diagnostico,color,peso,edad,foto, concat(nombre,' ',apellido) FROM " & Table_Name & "" & veredas & "" & raza & "" & dueño & "" & sexo & ""
            ''MsgBox(sql)
            MySQLCMD.CommandText = sql
            MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
            DT = New DataTable
            DT.Columns.Clear()

            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                tabla.DataSource = Nothing
                tabla.DataSource = DT
                tabla.Columns(2).DefaultCellStyle.Format = "c"
                tabla.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                tabla.DefaultCellStyle.ForeColor = Color.Black
                tabla.ClearSelection()

                tabla.RowHeadersVisible = False
                tabla.Columns.RemoveAt(16)

            Else
                tabla.DataSource = DT
            End If
        Catch ex As Exception
            MsgBox("Failed to load Database !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()
    End Sub

    Private Sub busqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.cargaropciones()
        botonpdf.Enabled = False
        btneditar.Enabled = False



    End Sub

    Private Sub cargaropciones()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLCMD.CommandType = CommandType.Text
            MySQLCMD.CommandText = "SELECT distinct vereda FROM " & Table_Name
            MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
            datos = New DataSet
            datos2 = New DataSet

            datos.Tables.Add(Table_Name)
            MySQLDA.Fill(datos.Tables(Table_Name))
            veredabox.DataSource = datos.Tables(Table_Name)
            veredabox.DisplayMember = "vereda"
            veredabox.Text = ""
            ''Connection.Close()


            MySQLCMD.CommandType = CommandType.Text
            MySQLCMD.CommandText = "SELECT distinct raza FROM " & Table_Name
            MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
            datos1 = New DataSet
            datos1.Tables.Add(Table_Name)
            MySQLDA.Fill(datos1.Tables(Table_Name))
            razabox.DataSource = datos1.Tables(Table_Name)
            razabox.DisplayMember = "raza"
            razabox.Text = ""
            ''Connection.Close()

            MySQLCMD.CommandType = CommandType.Text
            MySQLCMD.CommandText = "SELECT distinct CONCAT( nombre,' ',apellido) nombrecompleto FROM " & Table_Name
            MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
            datos2 = New DataSet
            datos2.Tables.Add(Table_Name)
            MySQLDA.Fill(datos2.Tables(Table_Name))
            Combodueño.DataSource = datos2.Tables(Table_Name)
            Combodueño.DisplayMember = "nombrecompleto"
            Combodueño.Text = ""

        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical)
        End Try
        Connection.Close()
    End Sub
    Private Sub crearpdf()
        Try
            Dim sfd As New SaveFileDialog With {.Filter = "PDF Files{*.pdf}|*.pdf"}
            sfd.FileName="registros.pdf"
            If sfd.ShowDialog = 1 Then
                Dim celda As PdfPCell = New PdfPCell(New Paragraph("encabezado de pagina"))
                Dim doc As New Document(PageSize.A4, 40, 40, 80, 20)
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(sfd.FileName, FileMode.Create))
                Dim pColumn As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 7, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
                Dim prow As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 7, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
                Dim tbHeader As PdfPTable = New PdfPTable(3)
                Dim pdftable As New PdfPTable(12)
                pdftable.TotalWidth = 550.0F
                pdftable.LockedWidth = True
                pdftable.HorizontalAlignment = Element.ALIGN_CENTER
                pdftable.HeaderRows = 1
                ''Dim withs As Single() = New Single() {1.0F, 1.0F, 1.0F, 1.0F, 1.0F, 1.0F, 1.0F, 0.9F, 0.6F, 0.8F, 0.9F, 1.1F}
                ''spdftable.SetWidths(withs)

                Dim pdfcell As PdfPCell = Nothing

                Dim oImagen As iTextSharp.text.Image
                Dim cbPie As PdfContentByte
                Dim cbEncabezado As PdfContentByte




                doc.Open()
                ''iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance()
                '-----------------------------------------------------------------------------------------
                ' DEFINICIÓN DEL OBJETO PdfContentByte PARA EL ENCABEZADO
                '-----------------------------------------------------------------------------------------
                cbEncabezado = writer.DirectContent
                cbEncabezado.BeginText()

                cbEncabezado.SetFontAndSize(FontFactory.GetFont(FontFactory.HELVETICA, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.BOLDITALIC).BaseFont, 9)
                cbEncabezado.SetColorFill(iTextSharp.text.BaseColor.GRAY)
                cbEncabezado.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Creado para la oficina omataa guachetá", 25, 800, 0)
                cbEncabezado.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Elaborado por luz Andrea", 25, 810, 0)
                cbEncabezado.EndText()

                '-----------------------------------------------------------------------------------------
                ' DEFINICIÓN DEL OBJETO PdfContentByte PARA EL PIE DE PAGINA
                '-----------------------------------------------------------------------------------------
                cbPie = writer.DirectContent
                cbPie.BeginText()
                cbPie.SetFontAndSize(FontFactory.GetFont(FontFactory.HELVETICA, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont, 10)
                cbPie.SetColorFill(iTextSharp.text.BaseColor.BLACK)
                cbPie.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Página: " & writer.PageNumber, 540, 25, 0)
                cbPie.EndText()
                '-----------------------------------------------------------------------------------------
                ' LOGOS DEL DOCUMENTO
                '-----------------------------------------------------------------------------------------
                oImagen = iTextSharp.text.Image.GetInstance("E:\Proyecto trabajo\Proyecto\Proyecto\logo\logo.png")
                oImagen.SetAbsolutePosition(520, 780)
                oImagen.ScalePercent(20)                 'Ajuste porcentual de la imagen
                doc.Add(oImagen)                    'Se agrega la imagen al documento


                ''pdfcell = New PdfPCell(New Paragraph("cedula", pColumn))
                ''pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                ''pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                ''pdftable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph("nombre", pColumn))
                pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdftable.AddCell(pdfcell)

                ''pdfcell = New PdfPCell(New Paragraph("apellido", pColumn))
                ''pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                ''pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                ''pdftable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph("telefono", pColumn))
                pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdftable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph("vereda", pColumn))
                pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdftable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph("finca", pColumn))
                pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdftable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph("id animal", pColumn))
                pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdftable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph("raza", pColumn))
                pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdftable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph("sexo", pColumn))
                pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdftable.AddCell(pdfcell)

                ''pdfcell = New PdfPCell(New Paragraph("consulta", pColumn))
                ''pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                ''pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                ''pdftable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph("diagnostico", pColumn))
                pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdftable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph("color", pColumn))
                pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdftable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph("peso", pColumn))
                pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdftable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph("edad", pColumn))
                pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdftable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph("foto", pColumn))
                pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdftable.AddCell(pdfcell)



                Dim dt As DataTable = getTable()

                For i = 0 To dt.Rows.Count - 1
                    For j = 0 To dt.Columns.Count - 1
                        If j <> 11 Then
                            pdfcell = New PdfPCell(New Paragraph(dt.Rows(i)(j).ToString, prow))
                            pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                            pdftable.AddCell(pdfcell)
                        End If

                        If j = 11 Then
                            Dim imageByte As Byte() = CType(tabla.Rows(i).Cells(15).Value, Byte())
                            Dim myImage As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(imageByte)
                            pdftable.AddCell(myImage)
                        End If

                    Next
                Next
                doc.Add(pdftable)
                doc.Close()
                MsgBox("Pdf exportado correctamente " & sfd.FileName, vbInformation)
                Process.Start(sfd.FileName)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Function getTable()
        Dim datatable As New DataTable("dt")
        ''Dim dataco0 As New DataColumn(tabla.Columns(0).HeaderText.ToString, GetType(String))
        Dim dataco1 As New DataColumn(tabla.Columns(1).HeaderText.ToString, GetType(String))
        ''Dim dataco2 As New DataColumn(tabla.Columns(2).HeaderText.ToString, GetType(String))
        Dim dataco3 As New DataColumn(tabla.Columns(3).HeaderText.ToString, GetType(String))
        Dim dataco4 As New DataColumn(tabla.Columns(4).HeaderText.ToString, GetType(String))
        Dim dataco5 As New DataColumn(tabla.Columns(5).HeaderText.ToString, GetType(String))
        Dim dataco6 As New DataColumn(tabla.Columns(6).HeaderText.ToString, GetType(String))
        Dim dataco7 As New DataColumn(tabla.Columns(7).HeaderText.ToString, GetType(String))
        Dim dataco8 As New DataColumn(tabla.Columns(8).HeaderText.ToString, GetType(String))
        ''Dim dataco9 As New DataColumn(tabla.Columns(9).HeaderText.ToString, GetType(String))
        ''Dim dataco10 As New DataColumn(tabla.Columns(10).HeaderText.ToString, GetType(String))
        Dim dataco11 As New DataColumn(tabla.Columns(11).HeaderText.ToString, GetType(String))
        Dim dataco12 As New DataColumn(tabla.Columns(12).HeaderText.ToString, GetType(String))
        Dim dataco13 As New DataColumn(tabla.Columns(13).HeaderText.ToString, GetType(String))
        Dim dataco14 As New DataColumn(tabla.Columns(14).HeaderText.ToString, GetType(String))
        Dim dataco15 As New DataColumn(tabla.Columns(15).HeaderText.ToString, GetType(String))


        ''datatable.Columns.Add(dataco0)
        datatable.Columns.Add(dataco1)
        ''datatable.Columns.Add(dataco2)
        datatable.Columns.Add(dataco3)
        datatable.Columns.Add(dataco4)
        datatable.Columns.Add(dataco5)
        datatable.Columns.Add(dataco6)
        datatable.Columns.Add(dataco7)
        datatable.Columns.Add(dataco8)
        ''datatable.Columns.Add(dataco9)
        ''datatable.Columns.Add(dataco10)
        datatable.Columns.Add(dataco11)
        datatable.Columns.Add(dataco12)
        datatable.Columns.Add(dataco13)
        datatable.Columns.Add(dataco14)
        datatable.Columns.Add(dataco15)


        Dim row As DataRow
        For i = 0 To tabla.Rows.Count - 2
            row = datatable.NewRow

            ''row(dataco0) = tabla.CurrentRow.Cells.Item(0).Value.ToString
            row(dataco1) = tabla.Rows(i).Cells.Item(1).Value.ToString
            ''row(dataco2) = tabla.Rows(i).Cells.Item(2).Value.ToString
            row(dataco3) = tabla.Rows(i).Cells.Item(3).Value.ToString
            row(dataco4) = tabla.Rows(i).Cells.Item(4).Value.ToString
            row(dataco5) = tabla.Rows(i).Cells.Item(5).Value.ToString
            row(dataco6) = tabla.Rows(i).Cells.Item(6).Value.ToString
            row(dataco7) = tabla.Rows(i).Cells.Item(7).Value.ToString
            row(dataco8) = tabla.Rows(i).Cells.Item(8).Value.ToString
            ''row(dataco9) = tabla.Rows(i).Cells.Item(9).Value.ToString
            ''row(dataco10) = tabla.Rows(i).Cells.Item(10).Value.ToString
            row(dataco11) = tabla.Rows(i).Cells.Item(11).Value.ToString
            row(dataco12) = tabla.Rows(i).Cells.Item(12).Value.ToString
            row(dataco13) = tabla.Rows(i).Cells.Item(13).Value.ToString
            row(dataco14) = tabla.Rows(i).Cells.Item(14).Value.ToString




            datatable.Rows.Add(row)


        Next
        datatable.AcceptChanges()
        Return datatable

    End Function
End Class