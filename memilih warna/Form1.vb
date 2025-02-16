Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        lblwarnapilihan.BackColor = Color.Pink
        lblketerangan.Text = "warna yang dipilih pink"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        lblwarnapilihan.BackColor = Color.Yellow
        lblketerangan.Text = "warna yang dipilih yellow"
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        lblwarnapilihan.BackColor = Color.Blue
        lblketerangan.Text = "warna yang dipilih blue"
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        lblwarnapilihan.BackColor = Color.Red
        lblketerangan.Text = "warna yang dipilih red"
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        lblwarnapilihan.BackColor = Color.Black
        lblketerangan.Text = "warna yang dipilih black"
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        lblwarnapilihan.BackColor = Color.Lime
        lblketerangan.Text = "warna yang dipilih lime"
    End Sub
End Class
