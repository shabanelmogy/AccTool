Imports System.Data.SqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'اضافة فورمات
        Dp_Start.Format = DateTimePickerFormat.Custom
        Dp_Start.CustomFormat = "dd/MM/yyyy   HH:mm:ss"
        Dp_End.Format = DateTimePickerFormat.Custom
        Dp_End.CustomFormat = "dd/MM/yyyy   HH:mm:ss"

    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click

        Dim d1 As String = Dp_Start.Value
        Dim d2 As String = Dp_End.Value

        Dim con As New SqlConnection(Configuration.ConfigurationManager.ConnectionStrings("con").ConnectionString)
        'حذف الفواتير من الحسابات والحركات المخزنية لللفواتير بين تاريخين
        Try
            con.Open()

            Dim strdelinvmaster As String = "Delete Invmaster Where lastDatetime between @Strdate and @EndDate"

            Dim strdelinvdetail As String = "Delete InvDetail Where Invid Not In (Select id from Invmaster)"
            Dim StrDelaccmovebatch As String = "Delete Accmovebatch Where Invid>0 and Invid Not In (Select id from Invmaster) "
            Dim strdelaccmoveinfo As String = "Delete AccMoveInfo Where Batchid Not In (Select id from accmovebatch)"
            Dim strdelaccmovemaster As String = "Delete AccMoveMaster Where Moveinfoid Not In (Select id from AccMoveInfo)"
            Dim strdelaccmovedetail As String = "Delete Accmovedetail  Where AccMasterID Not In (Select id from AccMoveMaster )"
            Dim strdel As String = strdelinvdetail & StrDelaccmovebatch & strdelaccmoveinfo & strdelaccmovemaster & strdelaccmovedetail

            Dim cmdmaster As New SqlCommand(strdelinvmaster, con)
            Dim cmd As New SqlCommand(strdel, con)


            cmdmaster.Parameters.AddWithValue("@Strdate", Dp_Start.Value)
            cmdmaster.Parameters.AddWithValue("@EndDate", Dp_End.Value)

            If MsgBox(" سيتم تحديث البيانات بين " & d1 & "  " & "إلى" & "  " & d2, MessageBoxIcon.Exclamation + vbYesNo, "حذف") = vbYes Then

                cmdmaster.ExecuteNonQuery()
                cmd.ExecuteNonQuery()

                MsgBox("تم التحديث ", MessageBoxIcon.Information, "تم التنفيذ")
                con.Close()
            End If
        Catch ex As Exception
            MsgBox("خطأ فى بيانات الاتصال", MessageBoxIcon.Error, "تعليمات")
        Finally
            con.Close()
        End Try


    End Sub

End Class
