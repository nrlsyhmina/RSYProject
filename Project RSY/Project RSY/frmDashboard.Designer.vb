<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDeleteAhli = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApproveidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RsydbDataSet = New Project_RSY.rsydbDataSet()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnTable = New System.Windows.Forms.Button()
        Me.btnMemberList = New System.Windows.Forms.Button()
        Me.imgLogoRSY = New System.Windows.Forms.PictureBox()
        Me.lblRSY = New System.Windows.Forms.Label()
        Me.imgBoxShadow = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MemberTableAdapter = New Project_RSY.rsydbDataSetTableAdapters.memberTableAdapter()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RsydbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.imgLogoRSY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBoxShadow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(627, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(688, 37)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Selamat Datang Ke Sistem Rakan Siswa Yadim"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnUpdate)
        Me.TabPage2.Controls.Add(Me.btnDeleteAhli)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(982, 586)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Senarai Ahli"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdate.Location = New System.Drawing.Point(741, 536)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(220, 44)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "Kemaskini"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDeleteAhli
        '
        Me.btnDeleteAhli.BackColor = System.Drawing.Color.Red
        Me.btnDeleteAhli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDeleteAhli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnDeleteAhli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnDeleteAhli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAhli.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAhli.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDeleteAhli.Location = New System.Drawing.Point(502, 536)
        Me.btnDeleteAhli.Name = "btnDeleteAhli"
        Me.btnDeleteAhli.Size = New System.Drawing.Size(220, 44)
        Me.btnDeleteAhli.TabIndex = 22
        Me.btnDeleteAhli.Text = "Padam Ahli"
        Me.btnDeleteAhli.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.ApproveidDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.PhoneDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.PositionDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PassDataGridViewTextBoxColumn, Me.AccessidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MemberBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(982, 526)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "memberID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "memberID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "memberName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NAMA"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 400
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "memberIC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IC NO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'ApproveidDataGridViewTextBoxColumn
        '
        Me.ApproveidDataGridViewTextBoxColumn.DataPropertyName = "approveid"
        Me.ApproveidDataGridViewTextBoxColumn.HeaderText = "APPROVE ID"
        Me.ApproveidDataGridViewTextBoxColumn.Name = "ApproveidDataGridViewTextBoxColumn"
        Me.ApproveidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "address1"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ALAMAT 1"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 400
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "address2"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ALAMAT 2"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 400
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "postcode"
        Me.DataGridViewTextBoxColumn6.HeaderText = "POSKOD"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "city"
        Me.DataGridViewTextBoxColumn7.HeaderText = "BANDAR"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "gender"
        Me.DataGridViewTextBoxColumn8.HeaderText = "JANTINA"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "NO TELEFON"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "course"
        Me.DataGridViewTextBoxColumn9.HeaderText = "KOS"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 300
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "university"
        Me.DataGridViewTextBoxColumn10.HeaderText = "UNIVERSITI"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 400
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn11.HeaderText = "E-MEL"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 300
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "accIG"
        Me.DataGridViewTextBoxColumn12.HeaderText = "accIG"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "accFB"
        Me.DataGridViewTextBoxColumn13.HeaderText = "accFB"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PassDataGridViewTextBoxColumn
        '
        Me.PassDataGridViewTextBoxColumn.DataPropertyName = "pass"
        Me.PassDataGridViewTextBoxColumn.HeaderText = "pass"
        Me.PassDataGridViewTextBoxColumn.Name = "PassDataGridViewTextBoxColumn"
        Me.PassDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessidDataGridViewTextBoxColumn
        '
        Me.AccessidDataGridViewTextBoxColumn.DataPropertyName = "accessid"
        Me.AccessidDataGridViewTextBoxColumn.HeaderText = "accessid"
        Me.AccessidDataGridViewTextBoxColumn.Name = "AccessidDataGridViewTextBoxColumn"
        Me.AccessidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MemberBindingSource
        '
        Me.MemberBindingSource.DataMember = "member"
        Me.MemberBindingSource.DataSource = Me.RsydbDataSet
        '
        'RsydbDataSet
        '
        Me.RsydbDataSet.DataSetName = "rsydbDataSet"
        Me.RsydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(982, 586)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Laman Utama"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(509, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(990, 54)
        Me.Panel1.TabIndex = 19
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(505, 191)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(990, 615)
        Me.TabControl1.TabIndex = 17
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDashboard.Location = New System.Drawing.Point(98, 400)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(270, 62)
        Me.btnDashboard.TabIndex = 16
        Me.btnDashboard.Text = "Laman Utama"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Red
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSettings.Location = New System.Drawing.Point(98, 668)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(270, 62)
        Me.btnSettings.TabIndex = 15
        Me.btnSettings.Text = "Keluar"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnTable
        '
        Me.btnTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTable.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnTable.Location = New System.Drawing.Point(98, 581)
        Me.btnTable.Name = "btnTable"
        Me.btnTable.Size = New System.Drawing.Size(270, 62)
        Me.btnTable.TabIndex = 14
        Me.btnTable.Text = "Tambah Ahli"
        Me.btnTable.UseVisualStyleBackColor = False
        '
        'btnMemberList
        '
        Me.btnMemberList.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnMemberList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnMemberList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnMemberList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMemberList.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemberList.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMemberList.Location = New System.Drawing.Point(98, 489)
        Me.btnMemberList.Name = "btnMemberList"
        Me.btnMemberList.Size = New System.Drawing.Size(270, 62)
        Me.btnMemberList.TabIndex = 13
        Me.btnMemberList.Text = "Senarai Ahli"
        Me.btnMemberList.UseVisualStyleBackColor = False
        '
        'imgLogoRSY
        '
        Me.imgLogoRSY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.imgLogoRSY.Image = CType(resources.GetObject("imgLogoRSY.Image"), System.Drawing.Image)
        Me.imgLogoRSY.Location = New System.Drawing.Point(132, 149)
        Me.imgLogoRSY.Name = "imgLogoRSY"
        Me.imgLogoRSY.Size = New System.Drawing.Size(196, 160)
        Me.imgLogoRSY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgLogoRSY.TabIndex = 12
        Me.imgLogoRSY.TabStop = False
        '
        'lblRSY
        '
        Me.lblRSY.AutoSize = True
        Me.lblRSY.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRSY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lblRSY.Location = New System.Drawing.Point(92, 59)
        Me.lblRSY.Name = "lblRSY"
        Me.lblRSY.Size = New System.Drawing.Size(276, 34)
        Me.lblRSY.TabIndex = 11
        Me.lblRSY.Text = "Rakan Siswa Yadim"
        '
        'imgBoxShadow
        '
        Me.imgBoxShadow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.imgBoxShadow.Dock = System.Windows.Forms.DockStyle.Left
        Me.imgBoxShadow.Location = New System.Drawing.Point(0, 0)
        Me.imgBoxShadow.Name = "imgBoxShadow"
        Me.imgBoxShadow.Size = New System.Drawing.Size(476, 952)
        Me.imgBoxShadow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBoxShadow.TabIndex = 10
        Me.imgBoxShadow.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(684, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(597, 34)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = """Melakar Generasi Penerus Nastia Ummah"""
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1561, 952)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnTable)
        Me.Controls.Add(Me.btnMemberList)
        Me.Controls.Add(Me.imgLogoRSY)
        Me.Controls.Add(Me.lblRSY)
        Me.Controls.Add(Me.imgBoxShadow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDashboard"
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RsydbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.imgLogoRSY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBoxShadow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnTable As Button
    Friend WithEvents btnMemberList As Button
    Friend WithEvents imgLogoRSY As PictureBox
    Friend WithEvents lblRSY As Label
    Friend WithEvents imgBoxShadow As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDeleteAhli As Button
    Friend WithEvents btnUpdate As Button

    Friend WithEvents MemberIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberICDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Address1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Address2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PostcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UniversityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccIGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccFBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RsydbDataSet As rsydbDataSet
    Friend WithEvents MemberBindingSource As BindingSource
    Friend WithEvents MemberTableAdapter As rsydbDataSetTableAdapters.memberTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ApproveidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccessidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
