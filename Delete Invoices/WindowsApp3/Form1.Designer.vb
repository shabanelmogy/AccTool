<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Dp_End = New System.Windows.Forms.DateTimePicker()
        Me.Dp_Start = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Dp_End
        '
        Me.Dp_End.Location = New System.Drawing.Point(12, 48)
        Me.Dp_End.Name = "Dp_End"
        Me.Dp_End.RightToLeftLayout = True
        Me.Dp_End.Size = New System.Drawing.Size(165, 20)
        Me.Dp_End.TabIndex = 0
        '
        'Dp_Start
        '
        Me.Dp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dp_Start.Location = New System.Drawing.Point(12, 12)
        Me.Dp_Start.Name = "Dp_Start"
        Me.Dp_Start.RightToLeftLayout = True
        Me.Dp_Start.Size = New System.Drawing.Size(165, 20)
        Me.Dp_Start.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(182, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "إلى"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(184, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "من"
        '
        'Btn_Delete
        '
        Me.Btn_Delete.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Delete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Delete.ForeColor = System.Drawing.Color.White
        Me.Btn_Delete.Image = Global.WindowsApp3.My.Resources.Resources._52655_check_firewall_on_security_shield_icon
        Me.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Delete.Location = New System.Drawing.Point(57, 89)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(100, 33)
        Me.Btn_Delete.TabIndex = 6
        Me.Btn_Delete.Text = "Update "
        Me.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Delete.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(225, 135)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Dp_Start)
        Me.Controls.Add(Me.Dp_End)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Update"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dp_End As DateTimePicker
    Friend WithEvents Dp_Start As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_Delete As Button
End Class
