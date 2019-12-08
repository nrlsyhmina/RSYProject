Imports System.Data.OleDb
Imports System.Data
Public Class frmRegister
    Dim connection As New OleDbConnection(My.Settings.registernewConnectionString)
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
        frmDashboard.Show()
    End Sub

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RsydbDataSet.member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.RsydbDataSet.member)

    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        On Error GoTo saveErr
        MemberBindingSource.EndEdit()

        If txtName.Text = String.Empty Or
            txtEmail.Text = String.Empty Or
            txtAddress1.Text = String.Empty Or
            txtAddress2.Text = String.Empty Or
            txtCity.Text = String.Empty Or
            txtCourse.Text = String.Empty Or
            txtFbAcc.Text = String.Empty Or
            txtGender.Text = String.Empty Or
            txtIC.Text = String.Empty Or
            txtIgAcc.Text = String.Empty Or
            txtPhone.Text = String.Empty Or
            txtPostcode.Text = String.Empty Or
            txtUniversity.Text = String.Empty Then

            MessageBox.Show("Sila masukkan semua data")

        Else
            MemberTableAdapter.Update(RsydbDataSet.member)
            MessageBox.Show("Data berjaya disimpan")

        End If
saveErr:
        Exit Sub
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        MemberBindingSource.AddNew()
    End Sub

End Class