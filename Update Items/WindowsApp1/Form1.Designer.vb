<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbosheets = New System.Windows.Forms.ComboBox()
        Me.CboData = New System.Windows.Forms.ComboBox()
        Me.CboServer = New System.Windows.Forms.ComboBox()
        Me.Chk_Name = New System.Windows.Forms.CheckBox()
        Me.Chk_ItemClassid = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_Backup = New System.Windows.Forms.Button()
        Me.Btn_DeleteAllData = New System.Windows.Forms.Button()
        Me.Btn_UnselectAll = New System.Windows.Forms.Button()
        Me.Btn_SelectAll = New System.Windows.Forms.Button()
        Me.Chk_Tax = New System.Windows.Forms.CheckBox()
        Me.Chk_sellprice3 = New System.Windows.Forms.CheckBox()
        Me.Chk_Pitemtype = New System.Windows.Forms.CheckBox()
        Me.Chk_Barcode = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chk_Sellprice2 = New System.Windows.Forms.CheckBox()
        Me.Chk_Istoried = New System.Windows.Forms.CheckBox()
        Me.Chk_Sellprice1 = New System.Windows.Forms.CheckBox()
        Me.Chk_MainUnitpack = New System.Windows.Forms.CheckBox()
        Me.Chk_Subunit = New System.Windows.Forms.CheckBox()
        Me.Chk_MainUnit = New System.Windows.Forms.CheckBox()
        Me.BtnSaveSql = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TextFileName = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LblCountGrdview = New System.Windows.Forms.Label()
        Me.Lbl_Countitem = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_RefreshSheets = New System.Windows.Forms.Button()
        Me.BtnDowload = New System.Windows.Forms.Button()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "اسم السيرفر"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(623, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "قاعدة البيانات"
        '
        'cbosheets
        '
        Me.cbosheets.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cbosheets.FormattingEnabled = True
        Me.cbosheets.ItemHeight = 14
        Me.cbosheets.Location = New System.Drawing.Point(5, 373)
        Me.cbosheets.Name = "cbosheets"
        Me.cbosheets.Size = New System.Drawing.Size(192, 22)
        Me.cbosheets.TabIndex = 9
        '
        'CboData
        '
        Me.CboData.FormattingEnabled = True
        Me.CboData.Location = New System.Drawing.Point(726, 8)
        Me.CboData.Name = "CboData"
        Me.CboData.Size = New System.Drawing.Size(247, 21)
        Me.CboData.TabIndex = 11
        '
        'CboServer
        '
        Me.CboServer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboServer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.CboServer.FormattingEnabled = True
        Me.CboServer.Location = New System.Drawing.Point(140, 8)
        Me.CboServer.Name = "CboServer"
        Me.CboServer.Size = New System.Drawing.Size(234, 21)
        Me.CboServer.TabIndex = 12
        '
        'Chk_Name
        '
        Me.Chk_Name.AutoSize = True
        Me.Chk_Name.Checked = True
        Me.Chk_Name.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_Name.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Chk_Name.Location = New System.Drawing.Point(672, 53)
        Me.Chk_Name.Name = "Chk_Name"
        Me.Chk_Name.Size = New System.Drawing.Size(94, 18)
        Me.Chk_Name.TabIndex = 15
        Me.Chk_Name.Text = "إسم الصنف"
        Me.Chk_Name.UseVisualStyleBackColor = True
        '
        'Chk_ItemClassid
        '
        Me.Chk_ItemClassid.AutoSize = True
        Me.Chk_ItemClassid.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Chk_ItemClassid.Location = New System.Drawing.Point(619, 81)
        Me.Chk_ItemClassid.Name = "Chk_ItemClassid"
        Me.Chk_ItemClassid.Size = New System.Drawing.Size(147, 18)
        Me.Chk_ItemClassid.TabIndex = 16
        Me.Chk_ItemClassid.Text = "رقم مجموعة الأصناف"
        Me.Chk_ItemClassid.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_Backup)
        Me.GroupBox1.Controls.Add(Me.Btn_DeleteAllData)
        Me.GroupBox1.Controls.Add(Me.Btn_UnselectAll)
        Me.GroupBox1.Controls.Add(Me.Btn_SelectAll)
        Me.GroupBox1.Controls.Add(Me.Chk_Tax)
        Me.GroupBox1.Controls.Add(Me.Chk_sellprice3)
        Me.GroupBox1.Controls.Add(Me.Chk_Pitemtype)
        Me.GroupBox1.Controls.Add(Me.Chk_Barcode)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Chk_Sellprice2)
        Me.GroupBox1.Controls.Add(Me.Chk_Istoried)
        Me.GroupBox1.Controls.Add(Me.Chk_Sellprice1)
        Me.GroupBox1.Controls.Add(Me.Chk_MainUnitpack)
        Me.GroupBox1.Controls.Add(Me.Chk_Subunit)
        Me.GroupBox1.Controls.Add(Me.Chk_MainUnit)
        Me.GroupBox1.Controls.Add(Me.BtnSaveSql)
        Me.GroupBox1.Controls.Add(Me.Chk_ItemClassid)
        Me.GroupBox1.Controls.Add(Me.Chk_Name)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(200, 366)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(772, 133)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  تحديث بيانات الأصناف  "
        '
        'Btn_Backup
        '
        Me.Btn_Backup.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Backup.ForeColor = System.Drawing.Color.White
        Me.Btn_Backup.Image = Global.WindowsApp1.My.Resources.Resources._2613299_backup_cloud_storage_google_googledrive_online_icon__1_
        Me.Btn_Backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Backup.Location = New System.Drawing.Point(6, 99)
        Me.Btn_Backup.Name = "Btn_Backup"
        Me.Btn_Backup.Size = New System.Drawing.Size(184, 33)
        Me.Btn_Backup.TabIndex = 26
        Me.Btn_Backup.Text = "    Backup Database"
        Me.Btn_Backup.UseVisualStyleBackColor = False
        '
        'Btn_DeleteAllData
        '
        Me.Btn_DeleteAllData.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_DeleteAllData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_DeleteAllData.ForeColor = System.Drawing.Color.White
        Me.Btn_DeleteAllData.Image = Global.WindowsApp1.My.Resources.Resources._34217_close_delete_remove_icon
        Me.Btn_DeleteAllData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_DeleteAllData.Location = New System.Drawing.Point(6, 58)
        Me.Btn_DeleteAllData.Name = "Btn_DeleteAllData"
        Me.Btn_DeleteAllData.Size = New System.Drawing.Size(184, 33)
        Me.Btn_DeleteAllData.TabIndex = 25
        Me.Btn_DeleteAllData.Text = "    حذف البيانات المعروضة"
        Me.Btn_DeleteAllData.UseVisualStyleBackColor = False
        '
        'Btn_UnselectAll
        '
        Me.Btn_UnselectAll.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Btn_UnselectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_UnselectAll.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_UnselectAll.Image = Global.WindowsApp1.My.Resources.Resources._211838_undo_icon
        Me.Btn_UnselectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_UnselectAll.Location = New System.Drawing.Point(197, 18)
        Me.Btn_UnselectAll.Name = "Btn_UnselectAll"
        Me.Btn_UnselectAll.Size = New System.Drawing.Size(121, 27)
        Me.Btn_UnselectAll.TabIndex = 24
        Me.Btn_UnselectAll.Text = "     عدم اختيار الكل"
        Me.Btn_UnselectAll.UseVisualStyleBackColor = False
        '
        'Btn_SelectAll
        '
        Me.Btn_SelectAll.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Btn_SelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SelectAll.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_SelectAll.ForeColor = System.Drawing.Color.Black
        Me.Btn_SelectAll.Image = Global.WindowsApp1.My.Resources.Resources._532258_click_cloud_finger_gesture_hand_icon
        Me.Btn_SelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_SelectAll.Location = New System.Drawing.Point(645, 20)
        Me.Btn_SelectAll.Name = "Btn_SelectAll"
        Me.Btn_SelectAll.Size = New System.Drawing.Size(121, 27)
        Me.Btn_SelectAll.TabIndex = 23
        Me.Btn_SelectAll.Text = "    اختيار الكل"
        Me.Btn_SelectAll.UseVisualStyleBackColor = False
        '
        'Chk_Tax
        '
        Me.Chk_Tax.AutoSize = True
        Me.Chk_Tax.Location = New System.Drawing.Point(213, 53)
        Me.Chk_Tax.Name = "Chk_Tax"
        Me.Chk_Tax.Size = New System.Drawing.Size(104, 18)
        Me.Chk_Tax.TabIndex = 19
        Me.Chk_Tax.Text = "نسبة الضريية"
        Me.Chk_Tax.UseVisualStyleBackColor = True
        '
        'Chk_sellprice3
        '
        Me.Chk_sellprice3.AutoSize = True
        Me.Chk_sellprice3.Location = New System.Drawing.Point(328, 109)
        Me.Chk_sellprice3.Name = "Chk_sellprice3"
        Me.Chk_sellprice3.Size = New System.Drawing.Size(111, 18)
        Me.Chk_sellprice3.TabIndex = 20
        Me.Chk_sellprice3.Text = "قائمة أسعار 3 "
        Me.Chk_sellprice3.UseVisualStyleBackColor = True
        '
        'Chk_Pitemtype
        '
        Me.Chk_Pitemtype.AutoSize = True
        Me.Chk_Pitemtype.Location = New System.Drawing.Point(618, 109)
        Me.Chk_Pitemtype.Name = "Chk_Pitemtype"
        Me.Chk_Pitemtype.Size = New System.Drawing.Size(148, 18)
        Me.Chk_Pitemtype.TabIndex = 21
        Me.Chk_Pitemtype.Text = "نوع الصنف فى الإنتاج"
        Me.Chk_Pitemtype.UseVisualStyleBackColor = True
        '
        'Chk_Barcode
        '
        Me.Chk_Barcode.AutoSize = True
        Me.Chk_Barcode.Location = New System.Drawing.Point(193, 109)
        Me.Chk_Barcode.Name = "Chk_Barcode"
        Me.Chk_Barcode.Size = New System.Drawing.Size(125, 18)
        Me.Chk_Barcode.TabIndex = 22
        Me.Chk_Barcode.Text = "الباركود الرئيسي"
        Me.Chk_Barcode.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(363, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 21)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "قم بإختيار البيانات المطلوب تحديثها "
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Chk_Sellprice2
        '
        Me.Chk_Sellprice2.AutoSize = True
        Me.Chk_Sellprice2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Chk_Sellprice2.Location = New System.Drawing.Point(333, 81)
        Me.Chk_Sellprice2.Name = "Chk_Sellprice2"
        Me.Chk_Sellprice2.Size = New System.Drawing.Size(106, 18)
        Me.Chk_Sellprice2.TabIndex = 18
        Me.Chk_Sellprice2.Text = "قائمة أسعار 2"
        Me.Chk_Sellprice2.UseVisualStyleBackColor = True
        '
        'Chk_Istoried
        '
        Me.Chk_Istoried.AutoSize = True
        Me.Chk_Istoried.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Chk_Istoried.Location = New System.Drawing.Point(218, 81)
        Me.Chk_Istoried.Name = "Chk_Istoried"
        Me.Chk_Istoried.Size = New System.Drawing.Size(99, 18)
        Me.Chk_Istoried.TabIndex = 19
        Me.Chk_Istoried.Text = "مخزن الصنف"
        Me.Chk_Istoried.UseVisualStyleBackColor = True
        '
        'Chk_Sellprice1
        '
        Me.Chk_Sellprice1.AutoSize = True
        Me.Chk_Sellprice1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Chk_Sellprice1.Location = New System.Drawing.Point(333, 53)
        Me.Chk_Sellprice1.Name = "Chk_Sellprice1"
        Me.Chk_Sellprice1.Size = New System.Drawing.Size(106, 18)
        Me.Chk_Sellprice1.TabIndex = 20
        Me.Chk_Sellprice1.Text = "قائمة أسعار 1"
        Me.Chk_Sellprice1.UseVisualStyleBackColor = True
        '
        'Chk_MainUnitpack
        '
        Me.Chk_MainUnitpack.AutoSize = True
        Me.Chk_MainUnitpack.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Chk_MainUnitpack.Location = New System.Drawing.Point(457, 109)
        Me.Chk_MainUnitpack.Name = "Chk_MainUnitpack"
        Me.Chk_MainUnitpack.Size = New System.Drawing.Size(142, 18)
        Me.Chk_MainUnitpack.TabIndex = 19
        Me.Chk_MainUnitpack.Text = "كمية الوحدة الفرعية"
        Me.Chk_MainUnitpack.UseVisualStyleBackColor = True
        '
        'Chk_Subunit
        '
        Me.Chk_Subunit.AutoSize = True
        Me.Chk_Subunit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Chk_Subunit.Location = New System.Drawing.Point(489, 81)
        Me.Chk_Subunit.Name = "Chk_Subunit"
        Me.Chk_Subunit.Size = New System.Drawing.Size(110, 18)
        Me.Chk_Subunit.TabIndex = 18
        Me.Chk_Subunit.Text = "الوحدة الفرعية"
        Me.Chk_Subunit.UseVisualStyleBackColor = True
        '
        'Chk_MainUnit
        '
        Me.Chk_MainUnit.AutoSize = True
        Me.Chk_MainUnit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Chk_MainUnit.Location = New System.Drawing.Point(481, 53)
        Me.Chk_MainUnit.Name = "Chk_MainUnit"
        Me.Chk_MainUnit.Size = New System.Drawing.Size(118, 18)
        Me.Chk_MainUnit.TabIndex = 17
        Me.Chk_MainUnit.Text = "الوحدة الرئيسية"
        Me.Chk_MainUnit.UseVisualStyleBackColor = True
        '
        'BtnSaveSql
        '
        Me.BtnSaveSql.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnSaveSql.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSaveSql.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveSql.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSaveSql.ForeColor = System.Drawing.Color.White
        Me.BtnSaveSql.Image = Global.WindowsApp1.My.Resources.Resources._79920_gtk_guardar_save_icon
        Me.BtnSaveSql.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSaveSql.Location = New System.Drawing.Point(6, 16)
        Me.BtnSaveSql.Name = "BtnSaveSql"
        Me.BtnSaveSql.Size = New System.Drawing.Size(184, 33)
        Me.BtnSaveSql.TabIndex = 6
        Me.BtnSaveSql.TabStop = False
        Me.BtnSaveSql.Text = "  تحديث بيانات الاصناف"
        Me.BtnSaveSql.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(4, 505)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(969, 23)
        Me.ProgressBar1.TabIndex = 18
        '
        'TextFileName
        '
        Me.TextFileName.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextFileName.Location = New System.Drawing.Point(200, 340)
        Me.TextFileName.Name = "TextFileName"
        Me.TextFileName.ReadOnly = True
        Me.TextFileName.Size = New System.Drawing.Size(772, 24)
        Me.TextFileName.TabIndex = 18
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Lavender
        Me.DataGridView1.CausesValidation = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(5, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(968, 290)
        Me.DataGridView1.TabIndex = 0
        '
        'LblCountGrdview
        '
        Me.LblCountGrdview.AutoSize = True
        Me.LblCountGrdview.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LblCountGrdview.ForeColor = System.Drawing.Color.Red
        Me.LblCountGrdview.Location = New System.Drawing.Point(500, 11)
        Me.LblCountGrdview.Name = "LblCountGrdview"
        Me.LblCountGrdview.Size = New System.Drawing.Size(0, 17)
        Me.LblCountGrdview.TabIndex = 19
        '
        'Lbl_Countitem
        '
        Me.Lbl_Countitem.AutoSize = True
        Me.Lbl_Countitem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Countitem.Location = New System.Drawing.Point(412, 12)
        Me.Lbl_Countitem.Name = "Lbl_Countitem"
        Me.Lbl_Countitem.Size = New System.Drawing.Size(77, 14)
        Me.Lbl_Countitem.TabIndex = 20
        Me.Lbl_Countitem.Text = "عدد الاصناف"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(585, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 34)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 34)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Btn_RefreshSheets
        '
        Me.Btn_RefreshSheets.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_RefreshSheets.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_RefreshSheets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_RefreshSheets.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_RefreshSheets.ForeColor = System.Drawing.Color.White
        Me.Btn_RefreshSheets.Image = Global.WindowsApp1.My.Resources.Resources._10514_red_refresh_icon
        Me.Btn_RefreshSheets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_RefreshSheets.Location = New System.Drawing.Point(4, 418)
        Me.Btn_RefreshSheets.Name = "Btn_RefreshSheets"
        Me.Btn_RefreshSheets.Size = New System.Drawing.Size(193, 32)
        Me.Btn_RefreshSheets.TabIndex = 10
        Me.Btn_RefreshSheets.Text = "تحديث ملف الاكسل"
        Me.Btn_RefreshSheets.UseVisualStyleBackColor = False
        '
        'BtnDowload
        '
        Me.BtnDowload.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnDowload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDowload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDowload.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDowload.ForeColor = System.Drawing.Color.White
        Me.BtnDowload.Image = CType(resources.GetObject("BtnDowload.Image"), System.Drawing.Image)
        Me.BtnDowload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDowload.Location = New System.Drawing.Point(3, 465)
        Me.BtnDowload.Name = "BtnDowload"
        Me.BtnDowload.Size = New System.Drawing.Size(194, 32)
        Me.BtnDowload.TabIndex = 7
        Me.BtnDowload.Text = "تحميل نموذج رفع البيانات"
        Me.BtnDowload.UseVisualStyleBackColor = False
        '
        'BtnBrowse
        '
        Me.BtnBrowse.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrowse.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBrowse.ForeColor = System.Drawing.Color.White
        Me.BtnBrowse.Image = CType(resources.GetObject("BtnBrowse.Image"), System.Drawing.Image)
        Me.BtnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBrowse.Location = New System.Drawing.Point(4, 339)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(193, 27)
        Me.BtnBrowse.TabIndex = 3
        Me.BtnBrowse.Text = "اختر ملف الاكسل"
        Me.BtnBrowse.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(979, 531)
        Me.Controls.Add(Me.Lbl_Countitem)
        Me.Controls.Add(Me.LblCountGrdview)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TextFileName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CboServer)
        Me.Controls.Add(Me.CboData)
        Me.Controls.Add(Me.Btn_RefreshSheets)
        Me.Controls.Add(Me.cbosheets)
        Me.Controls.Add(Me.BtnDowload)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تحديث بيانات الاصناف"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSaveSql As Button
    Friend WithEvents BtnDowload As Button
    Friend WithEvents cbosheets As ComboBox
    Friend WithEvents Btn_RefreshSheets As Button
    Friend WithEvents CboData As ComboBox
    Friend WithEvents CboServer As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Chk_Name As CheckBox
    Friend WithEvents Chk_ItemClassid As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Chk_Sellprice2 As CheckBox
    Friend WithEvents Chk_Istoried As CheckBox
    Friend WithEvents Chk_Sellprice1 As CheckBox
    Friend WithEvents Chk_MainUnitpack As CheckBox
    Friend WithEvents Chk_Subunit As CheckBox
    Friend WithEvents Chk_MainUnit As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TextFileName As TextBox
    Friend WithEvents Chk_Tax As CheckBox
    Friend WithEvents Chk_sellprice3 As CheckBox
    Friend WithEvents Chk_Pitemtype As CheckBox
    Friend WithEvents Chk_Barcode As CheckBox
    Friend WithEvents Btn_SelectAll As Button
    Friend WithEvents Btn_UnselectAll As Button
    Friend WithEvents Btn_DeleteAllData As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LblCountGrdview As Label
    Friend WithEvents Lbl_Countitem As Label
    Friend WithEvents Btn_Backup As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
