Public Class frmDashboard
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Dim result = MessageBox.Show("Adakah anda pasti untuk keluar ?", "Rakan Sahabat Yadim", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        TabControl1.SelectTab(0)
    End Sub


    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RsydbDataSet.member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.RsydbDataSet.member)


    End Sub

    Private Sub btnTable_Click(sender As Object, e As EventArgs) Handles btnTable.Click
        Me.Hide()
        frmRegister.Show()
    End Sub

    Private Sub btnMemberList_Click(sender As Object, e As EventArgs) Handles btnMemberList.Click
        TabControl1.SelectTab(1)
        DataGridView1.Columns(0).Visible = False

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.Close()
    End Sub

    Private Sub btnDeleteAhli_Click_1(sender As Object, e As EventArgs) Handles btnDeleteAhli.Click
        Me.Hide()
        frmDeleteAhli.Show()
    End Sub
End Class