Public Class start

    Private Sub start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Enabled = False
        TextBox1.Enabled = False
        Label4.Enabled = False
        TextBox2.Enabled = False
        Label5.Enabled = False
        TextBox3.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label3.Enabled = True
        TextBox1.Enabled = True
        Label4.Enabled = True
        TextBox2.Enabled = True
        TextBox1.Visible = True
        TextBox2.Visible = True


        Label5.Enabled = False
        TextBox3.Enabled = False
        TextBox3.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label5.Enabled = True
        TextBox3.Enabled = True
        TextBox3.Visible = True

        Label3.Enabled = False
        TextBox1.Enabled = False
        Label4.Enabled = False
        TextBox2.Enabled = False
        TextBox1.Visible = False
        TextBox2.Visible = False


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class