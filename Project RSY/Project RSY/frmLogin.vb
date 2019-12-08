Imports System.Data.OleDb
Imports System.Data
Public Class frmLogin
    Dim connection As New OleDbConnection(My.Settings.rsydbConnectionString)
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtPassword.Text = String.Empty Or txtNoAhli.Text = String.Empty Then
            MessageBox.Show("Masukkan No. Ahli dan Password", "Rakan Siswa Yadim", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("Select * from member where username=? and pass=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtNoAhli.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtPassword.Text

            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                Me.Hide()
                frmDashboard.Show()
            Else
                MsgBox("Salah Kata Laluan/No Ahli", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close Button
        Dim result = MessageBox.Show("Adakah anda pasti untuk keluar ?", "Rakan Sahabat Yadim", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
