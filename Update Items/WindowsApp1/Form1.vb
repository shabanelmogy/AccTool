Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form1

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dread As SqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Instances()
        Lbl_Countitem.Hide()
    End Sub

    Sub Instances()
        Dim dt As DataTable = SqlDataSourceEnumerator.Instance.GetDataSources
        Dim dr As DataRow
        For Each dr In dt.Rows

            CboServer.Items.Add(String.Concat(dr("ServerName"), "\", dr("InstanceName")))
        Next
    End Sub

    Private Function rowServer(v As String) As Object
        Throw New NotImplementedException()
    End Function

    Sub connection()
        Try
            con = New SqlConnection("Data Source=" & Trim(CboServer.Text) & ";Database=Master;user id=sa;password=togetherforever;")
            con.Open()
            CboData.Items.Clear()
            cmd = New SqlCommand("SELECT [name] FROM sys.databases Where [name] Not In('master','model','msdb','tempdb','ReportServer','ReportServerTempDB')", con)
            dread = cmd.ExecuteReader()
            While dread.Read
                CboData.Items.Add(dread(0))
            End While
            dread.Close()
        Catch ex As Exception
            MsgBox("")
        End Try

    End Sub

    Private Sub CboServer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboServer.SelectedIndexChanged
        connection()
    End Sub


    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click

        ofd.Filter = "Excel 97-2003|*.xls;*.xlsx"
        If ofd.ShowDialog() = DialogResult.OK Then
            TextFileName.Text = ofd.FileName

            Dim path As String = TextFileName.Text
            Dim connstring As String = String.Empty

            'IMEX=1 To Allow Insert Many Datatype in Same Column In Datagridview
            connstring = String.Format("provider=Microsoft.ace.oledb.12.0;" &
            "data source={0};extended properties='excel 12.0 xml;Hdr=yes;Imex=1' ", path)

            Dim conn As New OleDbConnection(connstring)

            conn.Open()
            cbosheets.DataSource = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            cbosheets.DisplayMember = "Table_name"
            cbosheets.ValueMember = "table_name"
            conn.Close()

            Dim cmd As New OleDbDataAdapter("select * from [" & cbosheets.Text & "" & "]", conn)
            cmd.TableMappings.Add("table", "table")
            Dim dt As New DataSet
            cmd.Fill(dt)
            DataGridView1.DataSource = dt.Tables(0)
            DelEmptyGridRows()
            LblCountGrdview.Text = DataGridView1.Rows.Count
            Lbl_Countitem.Show()

        End If
    End Sub

    Private Sub BtnSaveSql_Click(sender As Object, e As EventArgs) Handles BtnSaveSql.Click

        Dim Connsql As New SqlConnection("Data source=" & CboServer.Text & ";initial catalog=" & CboData.Text & ";user id=sa;password=togetherforever")

        If CboServer.Text <> "" And CboData.Text <> "" And TextFileName.Text <> "" Then

            Dim i As Integer = 0
            ProgressBar1.Maximum = DataGridView1.Rows.Count - 1

            For Each row As DataGridViewRow In DataGridView1.Rows

                DataGridView1.AllowUserToAddRows = False

                Dim CmdInsertSign As New SqlCommand(" If Not Exists(Select Sign From Items Where Sign = @Sign) 
                Begin Insert Into Items (Sign)  Select @Sign Where @Sign<>'' End ", Connsql)

                CmdInsertSign.Parameters.AddWithValue("Sign", row.Cells("Sign").Value.ToString)

                '========================================================================================================          
                Dim CmdUsed As New SqlCommand("Update Items Set Used='True' Where Sign=@Sign", Connsql)
                CmdUsed.Parameters.AddWithValue("Sign", row.Cells("Sign").Value.ToString)

                '========================================================================================================

                Dim CmdName As New SqlCommand("If Exists(Select Sign From Items Where Sign=@Sign) 
                Begin Update Items Set Name=@Name Where Sign=@Sign And @Name<>'' End ", Connsql)
                Try
                    If Chk_Name.Checked = True Then
                        CmdName.Parameters.AddWithValue("Sign", row.Cells("Sign").Value.ToString)
                        CmdName.Parameters.AddWithValue("Name", row.Cells("Name").Value.ToString)
                    End If
                Catch ex As Exception
                    MsgBox("لم يتم إستيراد بيانات إسم الصنف / راجع ملف الاكسل طبقا للنموذج المرفق", MessageBoxIcon.Error, "تنبيه")
                    Exit Sub
                End Try
                '========================================================================================================

                Dim CmdItemclassid As New SqlCommand("If Exists(Select Sign From Items Where Sign=@Sign) 
                Begin Update Items Set Itemclassid=@Itemclassid Where Sign=@Sign And @Itemclassid>0 End ", Connsql)
                Try
                    If Chk_ItemClassid.Checked = True Then
                        CmdItemclassid.Parameters.AddWithValue("Sign", row.Cells("Sign").Value.ToString)
                        CmdItemclassid.Parameters.AddWithValue("Itemclassid", row.Cells("Itemclassid").Value.ToString)
                    End If
                Catch ex As Exception
                    MsgBox("لم يتم إستيراد بيانات رقم مجموعة الصنف / راجع ملف الاكسل طبقا للنموذج المرفق", MessageBoxIcon.Error, "تنبيه")
                    Exit Sub
                End Try

                '========================================================================================================

                Dim CmdMainUnit As New SqlCommand("If Exists(Select Sign From Items Where Sign=@Sign) 
                Begin Update Items set MainUnit=@MainUnit Where Sign=@Sign and @MainUnit<>'' end ", Connsql)
                Try
                    If Chk_MainUnit.Checked = True Then
                        CmdMainUnit.Parameters.AddWithValue("Sign", row.Cells("Sign").Value.ToString)
                        CmdMainUnit.Parameters.AddWithValue("MainUnit", row.Cells("MainUnit").Value.ToString)
                    End If
                Catch ex As Exception
                    MsgBox("لم يتم إستيراد بيانات الوحدة الرئيسية/ راجع ملف الاكسل طبقا للنموذج المرفق", MessageBoxIcon.Error, "تنبيه")
                    Exit Sub
                End Try

                '========================================================================================================

                Dim CmdSubUnit As New SqlCommand("If Exists(Select Sign From Items Where Sign=@Sign) 
                Begin Update Items set SubUnit=@SubUnit Where Sign=@Sign and @SubUnit<>'' end ", Connsql)
                Try
                    If Chk_Subunit.Checked = True Then
                        CmdSubUnit.Parameters.AddWithValue("Sign", row.Cells("Sign").Value.ToString)
                        CmdSubUnit.Parameters.AddWithValue("SubUnit", row.Cells("SubUnit").Value.ToString)
                    End If
                Catch ex As Exception
                    MsgBox("لم يتم إستيراد بيانات الوحدة الفرعية/ راجع ملف الاكسل طبقا للنموذج المرفق", MessageBoxIcon.Error, "تنبيه")
                    Exit Sub
                End Try
                '========================================================================================================

                Dim CmdMainUnitpack As New SqlCommand("If Exists(Select Sign From Items Where Sign=@Sign) 
                Begin Update Items set MainUnitPack=@MainUnitPack Where Sign=@Sign and @MainUnitPack>0 end ", Connsql)
                Try
                    If Chk_MainUnitpack.Checked = True Then
                        CmdMainUnitpack.Parameters.AddWithValue("Sign", row.Cells("Sign").Value.ToString)
                        CmdMainUnitpack.Parameters.AddWithValue("MainUnitPack", row.Cells("MainUnitPack").Value.ToString)
                    End If
                Catch ex As Exception
                    MsgBox("لم يتم إستيراد بيانات كمية الوحدة الفرعية/ راجع ملف الاكسل طبقا للنموذج المرفق", MessageBoxIcon.Error, "تنبيه")
                    Exit Sub
                End Try

                '========================================================================================================

                Dim CmdSellprice1 As New SqlCommand("If Exists(Select Sign From Items Where Sign=@Sign) 
                Begin Update Items set SellPrice1=@Sellprice1 Where Sign=@Sign And @SellPrice1>0 end ", Connsql)
                Try
                    If Chk_Sellprice1.Checked = True Then
                        CmdSellprice1.Parameters.AddWithValue("Sign", row.Cells("Sign").Value.ToString)
                        CmdSellprice1.Parameters.AddWithValue("SellPrice1", row.Cells("SellPrice1").Value.ToString)
                    End If
                Catch ex As Exception
                    MsgBox("لم يتم إستيراد بيانات قائمة أسعار 1/ راجع ملف الاكسل طبقا للنموذج المرفق", MessageBoxIcon.Error, "تنبيه")
                    Exit Sub
                End Try
                '========================================================================================================
                Dim CmdSellprice2 As New SqlCommand("If Exists(Select Sign From Items Where Sign=@Sign) 
                Begin Update Items set SellPrice2=@Sellprice2 Where Sign=@Sign And @SellPrice2>0 end ", Connsql)

                Try
                    If Chk_Sellprice2.Checked = True Then
                        CmdSellprice2.Parameters.AddWithValue("Sign", row.Cells("Sign").Value.ToString)
                        CmdSellprice2.Parameters.AddWithValue("SellPrice2", row.Cells("SellPrice2").Value.ToString)
                    End If
                Catch ex As Exception
                    MsgBox("لم يتم إستيراد بيانات قائمة أسعار 2 / راجع ملف الاكسل طبقا للنموذج المرفق", MessageBoxIcon.Error, "تنبيه")
                    Exit Sub
                End Try
                '=========================================================================================================
                Dim CmdIstoried As New SqlCommand("If Exists(Select Sign From Items Where Sign=@Sign) 
                Begin Update Items Set Istoreid=@Istoreid Where Sign=@Sign And @Istoreid>0 End ", Connsql)

                Try
                    If Chk_Istoried.Checked = True Then
                        CmdIstoried.Parameters.AddWithValue("Sign", row.Cells("Sign").Value.ToString)
                        CmdIstoried.Parameters.AddWithValue("Istoreid", row.Cells("Istoreid").Value.ToString)
                    End If
                Catch ex As Exception
                    MsgBox("لم يتم استيراد بيانات مخزن الصنف / راجع ملف الاكسل طبقا للنموذج المرفق", MessageBoxIcon.Exclamation, "تنبيه")
                    Exit Sub
                End Try
                '=========================================================================================================
                Dim CmdTax As New SqlCommand("If Exists(Select Sign From Items Where Sign=@Sign) 
                Begin Update Items Set SaleTaxPer=@SaleTaxPer Where Sign=@Sign And @SaleTaxPer>0 End ", Connsql)

                Try
                    If Chk_Tax.Checked = True Then
                        CmdTax.Parameters.AddWithValue("Sign", row.Cells("Sign").Value.ToString)
                        CmdTax.Parameters.AddWithValue("SaleTaxPer", row.Cells("SaleTaxPer").Value.ToString)
                    End If
                Catch ex As Exception
                    MsgBox("لم يتم استيراد بيانات ضريبة الصنف / راجع ملف الاكسل طبقا للنموذج المرفق", MessageBoxIcon.Exclamation, "تنبيه")
                    Exit Sub
                End Try
                '==========================================================================================================
                Dim Cmdsellprice3 As New SqlCommand("If Exists(Select Sign From Items Where Sign=@Sign) 
                Begin Update Items Set Sellprice3=@Sellprice3 Where Sign=@Sign And @Sellprice3>0 End ", Connsql)

                Try
                    If Chk_sellprice3.Checked = True Then
                        Cmdsellprice3.Parameters.AddWithValue("Sign", row.Cells("Sign").Value.ToString)
                        Cmdsellprice3.Parameters.AddWithValue("Sellprice3", row.Cells("Sellprice3").Value.ToString)
                    End If
                Catch ex As Exception
                    MsgBox("لم يتم استيراد بيانات قائمة أسعار 3/ راجع ملف الاكسل طبقا للنموذج المرفق", MessageBoxIcon.Exclamation, "تنبيه")
                    Exit Sub
                End Try
                '===========================================================================================================
                Dim CmdPitemtype As New SqlCommand("If Exists(Select Sign From Items Where Sign=@Sign) 
                Begin Update Items Set Pitemtype=@Pitemtype Where Sign=@Sign And @Pitemtype between 0 and 2 End ", Connsql)

                Try
                    If Chk_Pitemtype.Checked = True Then
                        CmdPitemtype.Parameters.AddWithValue("Sign", row.Cells("Sign").Value.ToString)
                        CmdPitemtype.Parameters.AddWithValue("Pitemtype", row.Cells("Pitemtype").Value.ToString)
                    End If
                Catch ex As Exception
                    MsgBox("لم يتم استيراد بيانات نوع الصنف / راجع ملف الاكسل طبقا للنموذج المرفق", MessageBoxIcon.Exclamation, "تنبيه")
                    Exit Sub
                End Try
                '===========================================================================================================
                Dim CmdBarcode As New SqlCommand("If Exists(Select Sign From Items Where Sign=@Sign) 
                Begin Update Items Set Barcode=@Barcode Where Sign=@Sign And @Barcode <>'' End ", Connsql)

                Try
                    If Chk_Barcode.Checked = True Then
                        CmdBarcode.Parameters.AddWithValue("Sign", row.Cells("Sign").Value.ToString)
                        CmdBarcode.Parameters.AddWithValue("Barcode", row.Cells("Barcode").Value.ToString)
                    End If
                Catch ex As Exception
                    MsgBox("لم يتم استيراد بيانات الباركود الرئيسى / راجع ملف الاكسل طبقا للنموذج المرفق", MessageBoxIcon.Exclamation, "تنبيه")
                    Exit Sub
                End Try
                '===========================================================================================================
                Connsql.Open()

                CmdInsertSign.ExecuteNonQuery()

                Try
                    CmdUsed.ExecuteNonQuery()
                    i += 1
                    ProgressBar1.Value = i
                    If ProgressBar1.Value = ProgressBar1.Maximum Then
                        ProgressBar1.Value = 0
                    End If
                Catch ex As Exception
                End Try

                Try
                    If Chk_Name.Checked = True Then
                        CmdName.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                End Try

                Try
                    If Chk_ItemClassid.Checked = True Then
                        CmdItemclassid.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                End Try

                Try
                    If Chk_MainUnit.Checked = True Then
                        CmdMainUnit.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                End Try

                Try
                    If Chk_Subunit.Checked = True Then
                        CmdSubUnit.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                End Try

                Try
                    If Chk_MainUnitpack.Checked = True Then
                        CmdMainUnitpack.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                End Try

                Try
                    If Chk_Sellprice1.Checked = True Then
                        CmdSellprice1.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                End Try

                Try
                    If Chk_Sellprice2.Checked = True Then
                        CmdSellprice2.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                End Try

                Try
                    If Chk_Istoried.Checked = True Then
                        CmdIstoried.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                End Try


                Try
                    If Chk_Tax.Checked = True Then
                        CmdTax.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                End Try

                Try
                    If Chk_sellprice3.Checked = True Then
                        Cmdsellprice3.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                End Try

                Try
                    If Chk_Pitemtype.Checked = True Then
                        CmdPitemtype.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                End Try

                Try
                    If Chk_Barcode.Checked = True Then
                        CmdBarcode.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                End Try

                Connsql.Close()

                '========================================================================================================
            Next

            MsgBox("تم تحديث بيانات " & i & " " & "صنف", MessageBoxIcon.Information, Title:="Items Updated")
        Else
            MsgBox("تأكد  من إدخال اسم السيرفر وقاعدة البيانات واختيار الملف المطلوب", MessageBoxIcon.Information, Title:="Update Items")

        End If

    End Sub

    Private Sub BtnDowload_Click(sender As Object, e As EventArgs) Handles BtnDowload.Click
        Process.Start("https://drive.google.com/file/d/15rqPGxsELQvToqO27DMF41vdwib6vsZ5/view")
    End Sub

    Private Sub Btn_RefreshSheets_Click(sender As Object, e As EventArgs) Handles Btn_RefreshSheets.Click

        Dim path As String = TextFileName.Text
        Dim connstring As String = String.Empty

        connstring = String.Format("provider=Microsoft.ace.oledb.12.0;" &
            "data source={0};extended properties='excel 12.0 xml;Imex=1;Hdr=no' ", path)
        Dim conn As New OleDbConnection(connstring)

        If cbosheets.Text <> "" Then
            Dim cmd As New OleDbDataAdapter("select * from [" & cbosheets.Text & "" & "]", conn)
            cmd.TableMappings.Add("table", "table")
            Dim dt As New DataSet
            cmd.Fill(dt)
            DataGridView1.DataSource = dt.Tables(0)
            DelEmptyGridRows()
        Else
            MsgBox("أختر ملف اكسل أولاً", MessageBoxIcon.Information, Title:="Import Excel 97-2003")
        End If

    End Sub

    Private Sub Btn_SelectAll_Click(sender As Object, e As EventArgs) Handles Btn_SelectAll.Click
        For Each chk In GroupBox1.Controls
            If TypeOf chk Is CheckBox Then
                chk.Checked = True
            End If
        Next
    End Sub

    Private Sub Btn_UnselectAll_Click(sender As Object, e As EventArgs) Handles Btn_UnselectAll.Click
        For Each chk In GroupBox1.Controls
            If TypeOf chk Is CheckBox Then
                chk.checked = False
            End If
        Next
    End Sub

    Private Sub Btn_DeleteAllData_Click(sender As Object, e As EventArgs) Handles Btn_DeleteAllData.Click

        Dim Connsql As New SqlConnection("Data source=" & CboServer.Text & ";initial catalog=" & CboData.Text & ";user id=sa;password=togetherforever")

        If MsgBox("سيتم حذف بيانات الاصناف المعروضة من قاعدة البيانات", MessageBoxIcon.Exclamation + vbYesNo, "تنبيه") = vbYes Then

            If CboServer.Text <> "" And CboData.Text <> "" And TextFileName.Text <> "" Then

                Dim i As Integer = 0
                ProgressBar1.Maximum = DataGridView1.Rows.Count - 1

                For Each row As DataGridViewRow In DataGridView1.Rows

                    DataGridView1.AllowUserToAddRows = False

                    Dim CmdDelete As New SqlCommand("Delete From Items where sign=@sign", Connsql)

                    CmdDelete.Parameters.AddWithValue("Sign", row.Cells("Sign").Value.ToString)

                    Connsql.Open()
                    Try
                        CmdDelete.ExecuteNonQuery()
                        i += 1
                        ProgressBar1.Value = i
                        If ProgressBar1.Value = ProgressBar1.Maximum Then
                            ProgressBar1.Value = 0
                        End If
                    Catch ex As Exception
                    End Try

                    Connsql.Close()


                    '========================================================================================================
                Next

                MsgBox("تم حذف البيانات  ", MessageBoxIcon.Information, Title:="حذف البيانات")
            Else
                MsgBox("تأكد  من إدخال اسم السيرفر وقاعدة البيانات واختيار الملف المطلوب", MessageBoxIcon.Information, Title:="Update Items")

            End If
        End If
    End Sub

    Sub DelEmptyGridRows()
        Try
            Dim Empty As Boolean = True
            For i As Integer = 0 To DataGridView1.Rows.Count - 2
                Empty = True
                For j As Integer = 0 To DataGridView1.Columns.Count - 2
                    If DataGridView1.Rows(i).Cells(j).Value IsNot Nothing AndAlso DataGridView1.Rows(i).Cells(j).Value.ToString() <> "" Then
                        Empty = False
                        Exit For
                    End If
                Next
                If Empty Then
                    DataGridView1.Rows.RemoveAt(i)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Btn_Backup_Click(sender As Object, e As EventArgs) Handles Btn_Backup.Click

        con = New SqlConnection("Data Source=" & Trim(CboServer.Text) & ";Database=" & Trim(CboData.Text) & ";user id=sa;password=togetherforever;")

        If Trim(CboServer.Text) = "" Or Trim(CboData.Text) = "" Then
            MsgBox("لم يتم إختيار السيرفر وقاعدة البيانات", MessageBoxIcon.Stop, "خطأ")
            Exit Sub
        End If

        Try
            SaveFileDialog1.FileName = CboData.SelectedItem

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim Bakfolder As String = SaveFileDialog1.FileName
                Dim cmdBackup As New SqlCommand("backup database " & CboData.Text & " to disk='" & Bakfolder & "'", con)
                con.Open()
                cmdBackup.ExecuteNonQuery()
                con.Close()
                MsgBox("Backup Successfuly", MessageBoxIcon.Information, "تم التنفيذ")
            End If
        Catch ex As Exception
            MsgBox("لا توجد صلاحيات للحفظ على هذا المسار", MessageBoxIcon.Warning, "مسار خاطئ")
        End Try

    End Sub
End Class
