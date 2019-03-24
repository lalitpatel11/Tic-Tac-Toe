Public Class Form1
    Dim flag As Boolean = True
    Dim counter As Integer = 0

  
    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click



        Dim player1 = start.TextBox1.Text
        Dim player2 = start.TextBox2.Text
       
        Button10.Enabled = False



        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If flag Then
            Button1.Text = "X"
            flag = False
            Button1.ForeColor = Color.Blue
            counter = counter + 1

        Else
            Button1.Text = "O"
            flag = True
            Button1.ForeColor = Color.Green
            counter = counter + 1

        End If
        Button1.Enabled = False
        checkWinner()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If flag Then
            Button2.Text = "X"
            flag = False
            Button2.ForeColor = Color.Blue
            counter = counter + 1
        Else
            Button2.Text = "O"
            flag = True
            Button2.ForeColor = Color.Green
            counter = counter + 1
        End If
        Button2.Enabled = False
        checkWinner()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If flag Then
            Button3.Text = "X"
            flag = False
            Button3.ForeColor = Color.Blue
            counter = counter + 1
        Else
            Button3.Text = "O"
            flag = True
            Button3.ForeColor = Color.Green
            counter = counter + 1
        End If
        Button3.Enabled = False
        checkWinner()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If flag Then
            Button4.Text = "X"
            flag = False
            Button4.ForeColor = Color.Blue
            counter = counter + 1
        Else
            Button4.Text = "O"
            flag = True
            Button4.ForeColor = Color.Green
            counter = counter + 1
        End If
        Button4.Enabled = False
        checkWinner()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If flag Then
            Button5.Text = "X"
            flag = False
            Button5.ForeColor = Color.Blue
            counter = counter + 1
        Else
            Button5.Text = "O"
            flag = True
            Button5.ForeColor = Color.Green
            counter = counter + 1
        End If
        Button5.Enabled = False
        checkWinner()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If flag Then
            Button6.Text = "X"
            flag = False
            Button6.ForeColor = Color.Blue
            counter = counter + 1
        Else
            Button6.Text = "O"
            flag = True
            Button6.ForeColor = Color.Green
            counter = counter + 1
        End If
        Button6.Enabled = False
        checkWinner()
    End Sub



    Private Sub checkWinner()


        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Label3.Text = Label3.Text + 1
            MsgBox("Player " + start.TextBox1.Text + " Won", MsgBoxStyle.Information)
            disable_buttons()

        ElseIf Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Label4.Text = Label4.Text + 1
            MsgBox("Player " + start.TextBox2.Text + " Won", MsgBoxStyle.Information)
            disable_buttons()

        ElseIf Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Label3.Text = Label3.Text + 1
            MsgBox("Player " + start.TextBox1.Text + " Won", MsgBoxStyle.Information)
            disable_buttons()

        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Label4.Text = Label4.Text + 1
            MsgBox("Player " + start.TextBox2.Text + " Won", MsgBoxStyle.Information)
            disable_buttons()

        ElseIf Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            Button7.BackColor = Color.Red
            Button8.BackColor = Color.Red
            Button9.BackColor = Color.Red
            Label3.Text = Label3.Text + 1
            MsgBox("Player " + start.TextBox1.Text + " Won", MsgBoxStyle.Information)
            disable_buttons()

        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            Button7.BackColor = Color.Red
            Button8.BackColor = Color.Red
            Button9.BackColor = Color.Red
            Label4.Text = Label4.Text + 1
            MsgBox("Player " + start.TextBox2.Text + " Won", MsgBoxStyle.Information)
            disable_buttons()

        ElseIf Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            Button1.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button7.BackColor = Color.Red
            Label3.Text = Label3.Text + 1
            MsgBox("Player " + start.TextBox1.Text + " Won", MsgBoxStyle.Information)
            disable_buttons()

        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            Button1.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button7.BackColor = Color.Red
            Label4.Text = Label4.Text + 1
            MsgBox("Player " + start.TextBox2.Text + " Won", MsgBoxStyle.Information)
            disable_buttons()


        ElseIf Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            Button2.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button8.BackColor = Color.Red
            Label3.Text = Label3.Text + 1
            MsgBox("Player " + start.TextBox1.Text + " Won", MsgBoxStyle.Information)
            disable_buttons()

        ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            Button2.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button8.BackColor = Color.Red
            Label4.Text = Label4.Text + 1
            MsgBox("Player " + start.TextBox2.Text + " Won", MsgBoxStyle.Information)
            disable_buttons()


        ElseIf Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            Button3.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button9.BackColor = Color.Red
            Label3.Text = Label3.Text + 1
            MsgBox("Player " + start.TextBox1.Text + " Won", MsgBoxStyle.Information)
            disable_buttons()

        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            Button3.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button9.BackColor = Color.Red
            Label4.Text = Label4.Text + 1
            MsgBox("Player " + start.TextBox2.Text + " Won", MsgBoxStyle.Information)
            disable_buttons()


        ElseIf Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            Button1.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button9.BackColor = Color.Red
            Label3.Text = Label3.Text + 1
            MsgBox("Player " + start.TextBox1.Text + " Won", MsgBoxStyle.Information)
            disable_buttons()

        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            Button1.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button9.BackColor = Color.Red
            Label4.Text = Label4.Text + 1
            MsgBox("Player " + start.TextBox2.Text + " Won", MsgBoxStyle.Information)
            disable_buttons()

        ElseIf Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            Button3.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button7.BackColor = Color.Red
            Label3.Text = Label3.Text + 1
            MsgBox("Player " + start.TextBox1.Text + " Won", MsgBoxStyle.Information)
            disable_buttons()

        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            Button3.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button7.BackColor = Color.Red
            Label4.Text = Label4.Text + 1
            MsgBox("Player " + start.TextBox2.Text + " Won", MsgBoxStyle.Information)
            disable_buttons()

        ElseIf counter = 9 Then
            MsgBox("Match Drawn")

        End If


    End Sub
    Private Sub disable_buttons()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = start.TextBox1.Text
        Label2.Text = start.TextBox2.Text

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If flag Then
            Button7.Text = "X"
            flag = False
            Button7.ForeColor = Color.Blue
            counter = counter + 1
        Else
            Button7.Text = "O"
            flag = True
            Button7.ForeColor = Color.Green
            counter = counter + 1
        End If
        Button7.Enabled = False
        checkWinner()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If flag Then
            Button8.Text = "X"
            flag = False
            Button8.ForeColor = Color.Blue
            counter = counter + 1
        Else
            Button8.Text = "O"
            flag = True
            Button8.ForeColor = Color.Green
            counter = counter + 1
        End If
        Button8.Enabled = False
        checkWinner()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If flag Then
            Button9.Text = "X"
            flag = False
            Button9.ForeColor = Color.Blue
            counter = counter + 1
        Else
            Button9.Text = "O"
            flag = True
            Button9.ForeColor = Color.Green
            counter = counter + 1
        End If
        Button9.Enabled = False
        checkWinner()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        disable_buttons()
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""

        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""


        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

        Button1.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        Button5.BackColor = Color.White
        Button6.BackColor = Color.White
        Button7.BackColor = Color.White
        Button8.BackColor = Color.White
        Button9.BackColor = Color.White

        If counter = 9 Then
            MsgBox("Match Drawn")
        End If


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Hide()
        start.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
