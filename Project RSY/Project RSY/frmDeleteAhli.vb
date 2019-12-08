Public Class frmDeleteAhli
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
        frmDashboard.Show()
    End Sub

    Private Sub frmDeleteAhli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RsydbDataSet.member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.RsydbDataSet.member)

    End Sub


    Private Sub btnPadam_Click(sender As Object, e As EventArgs) Handles btnPadam.Click
        Dim result = MessageBox.Show("Adakah anda pasti untuk membuang data ?", "Rakan Sahabat Yadim", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            MemberBindingSource.RemoveCurrent()
        End If


    End Sub
End Class