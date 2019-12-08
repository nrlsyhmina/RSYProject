<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDeleteAhli
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
        Me.components = New System.ComponentModel.Container()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtUniversity = New System.Windows.Forms.TextBox()
        Me.txtFbAcc = New System.Windows.Forms.TextBox()
        Me.txtIgAcc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPadam = New System.Windows.Forms.Button()
        Me.RsydbDataSet = New Project_RSY.rsydbDataSet()
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemberTableAdapter = New Project_RSY.rsydbDataSetTableAdapters.memberTableAdapter()
        CType(Me.RsydbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.White
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "city", True))
        Me.txtCity.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtCity.Location = New System.Drawing.Point(369, 508)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(369, 32)
        Me.txtCity.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.Label1.Location = New System.Drawing.Point(100, 469)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 22)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "POSKOD :"
        '
        'txtPostcode
        '
        Me.txtPostcode.BackColor = System.Drawing.Color.White
        Me.txtPostcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "postcode", True))
        Me.txtPostcode.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtPostcode.Location = New System.Drawing.Point(369, 465)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(369, 32)
        Me.txtPostcode.TabIndex = 84
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.Label14.Location = New System.Drawing.Point(100, 512)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 22)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "BANDAR :"
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.DarkGray
        Me.btnBatal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnBatal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ForeColor = System.Drawing.Color.Black
        Me.btnBatal.Location = New System.Drawing.Point(411, 751)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(109, 47)
        Me.btnBatal.TabIndex = 83
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(349, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(186, 34)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = "PADAM AHLI"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "memberName", True))
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(369, 166)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(369, 32)
        Me.txtName.TabIndex = 80
        '
        'txtIC
        '
        Me.txtIC.BackColor = System.Drawing.Color.White
        Me.txtIC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "memberIC", True))
        Me.txtIC.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIC.Location = New System.Drawing.Point(369, 212)
        Me.txtIC.Name = "txtIC"
        Me.txtIC.Size = New System.Drawing.Size(369, 32)
        Me.txtIC.TabIndex = 79
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "email", True))
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtEmail.Location = New System.Drawing.Point(369, 255)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(369, 32)
        Me.txtEmail.TabIndex = 78
        '
        'txtGender
        '
        Me.txtGender.BackColor = System.Drawing.Color.White
        Me.txtGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "gender", True))
        Me.txtGender.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtGender.Location = New System.Drawing.Point(369, 296)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(369, 32)
        Me.txtGender.TabIndex = 77
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.White
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "phone", True))
        Me.txtPhone.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(369, 337)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(369, 32)
        Me.txtPhone.TabIndex = 76
        '
        'txtAddress1
        '
        Me.txtAddress1.BackColor = System.Drawing.Color.White
        Me.txtAddress1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "address1", True))
        Me.txtAddress1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtAddress1.Location = New System.Drawing.Point(369, 384)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(369, 32)
        Me.txtAddress1.TabIndex = 75
        '
        'txtAddress2
        '
        Me.txtAddress2.BackColor = System.Drawing.Color.White
        Me.txtAddress2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "address2", True))
        Me.txtAddress2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtAddress2.Location = New System.Drawing.Point(369, 424)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(369, 32)
        Me.txtAddress2.TabIndex = 74
        '
        'txtCourse
        '
        Me.txtCourse.BackColor = System.Drawing.Color.White
        Me.txtCourse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "course", True))
        Me.txtCourse.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtCourse.Location = New System.Drawing.Point(369, 553)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(369, 32)
        Me.txtCourse.TabIndex = 73
        '
        'txtUniversity
        '
        Me.txtUniversity.BackColor = System.Drawing.Color.White
        Me.txtUniversity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "university", True))
        Me.txtUniversity.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtUniversity.Location = New System.Drawing.Point(369, 594)
        Me.txtUniversity.Name = "txtUniversity"
        Me.txtUniversity.Size = New System.Drawing.Size(369, 32)
        Me.txtUniversity.TabIndex = 72
        '
        'txtFbAcc
        '
        Me.txtFbAcc.BackColor = System.Drawing.Color.White
        Me.txtFbAcc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "accFB", True))
        Me.txtFbAcc.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtFbAcc.Location = New System.Drawing.Point(369, 634)
        Me.txtFbAcc.Name = "txtFbAcc"
        Me.txtFbAcc.Size = New System.Drawing.Size(369, 32)
        Me.txtFbAcc.TabIndex = 71
        '
        'txtIgAcc
        '
        Me.txtIgAcc.BackColor = System.Drawing.Color.White
        Me.txtIgAcc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "accIG", True))
        Me.txtIgAcc.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtIgAcc.Location = New System.Drawing.Point(369, 676)
        Me.txtIgAcc.Name = "txtIgAcc"
        Me.txtIgAcc.Size = New System.Drawing.Size(369, 32)
        Me.txtIgAcc.TabIndex = 70
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.Label12.Location = New System.Drawing.Point(100, 676)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(204, 22)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "AKAUN INSTAGRAM :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.Label11.Location = New System.Drawing.Point(100, 633)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(197, 22)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "AKAUN FACEBOOK :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.Label10.Location = New System.Drawing.Point(100, 594)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 22)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "UNIVERSITI :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.Label9.Location = New System.Drawing.Point(100, 557)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 22)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "KOS :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.Label7.Location = New System.Drawing.Point(100, 339)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 22)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "NO TELEFON :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.Label6.Location = New System.Drawing.Point(100, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 22)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "JANTINA :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.Label4.Location = New System.Drawing.Point(99, 384)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 22)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "ALAMAT 1 :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 22)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "IC NO :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 22)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "NAMA :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.Label8.Location = New System.Drawing.Point(100, 424)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 22)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "ALAMAT 2 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.Label5.Location = New System.Drawing.Point(100, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 22)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "E-MEL"
        '
        'btnPadam
        '
        Me.btnPadam.BackColor = System.Drawing.Color.Red
        Me.btnPadam.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnPadam.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPadam.Location = New System.Drawing.Point(558, 751)
        Me.btnPadam.Name = "btnPadam"
        Me.btnPadam.Size = New System.Drawing.Size(180, 47)
        Me.btnPadam.TabIndex = 88
        Me.btnPadam.Text = "Padam"
        Me.btnPadam.UseVisualStyleBackColor = False
        '
        'RsydbDataSet
        '
        Me.RsydbDataSet.DataSetName = "rsydbDataSet"
        Me.RsydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemberBindingSource
        '
        Me.MemberBindingSource.DataMember = "member"
        Me.MemberBindingSource.DataSource = Me.RsydbDataSet
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'frmDeleteAhli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 926)
        Me.Controls.Add(Me.btnPadam)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPostcode)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtIC)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.txtUniversity)
        Me.Controls.Add(Me.txtFbAcc)
        Me.Controls.Add(Me.txtIgAcc)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDeleteAhli"
        Me.Text = "frmDeleteAhli"
        CType(Me.RsydbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPostcode As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtIC As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtAddress1 As TextBox
    Friend WithEvents txtAddress2 As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtUniversity As TextBox
    Friend WithEvents txtFbAcc As TextBox
    Friend WithEvents txtIgAcc As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label

    Friend WithEvents btnPadam As Button
    Friend WithEvents RsydbDataSet As rsydbDataSet
    Friend WithEvents MemberBindingSource As BindingSource
    Friend WithEvents MemberTableAdapter As rsydbDataSetTableAdapters.memberTableAdapter
End Class
