Public Class Multiplayer
    Dim flag As Boolean = True
    Dim counter As Integer = 0

    Private Sub Tile1_Click(sender As Object, e As EventArgs) Handles Tile1.Click
        If flag Then
            Tile1.Text = "X"
            flag = False
            Tile1.ForeColor = Color.Blue
            counter += 1
        Else
            Tile1.Text = "O"
            flag = True
            Tile1.ForeColor = Color.Red
            counter += 1
        End If
        Tile1.Enabled = False
        CheckWinner()
    End Sub

    Private Sub Tile2_Click(sender As Object, e As EventArgs) Handles Tile2.Click
        If flag Then
            Tile2.Text = "X"
            flag = False
            Tile2.ForeColor = Color.Blue
            counter += 1
        Else
            Tile2.Text = "O"
            flag = True
            Tile2.ForeColor = Color.Red
            counter += 1
        End If
        Tile2.Enabled = False
        CheckWinner()
    End Sub

    Private Sub Tile3_Click(sender As Object, e As EventArgs) Handles Tile3.Click
        If flag Then
            Tile3.Text = "X"
            flag = False
            Tile3.ForeColor = Color.Blue
            counter += +1
        Else
            Tile3.Text = "O"
            flag = True
            Tile3.ForeColor = Color.Red
            counter += 1
        End If
        Tile3.Enabled = False
        CheckWinner()
    End Sub

    Private Sub Tile4_Click(sender As Object, e As EventArgs) Handles Tile4.Click
        If flag Then
            Tile4.Text = "X"
            flag = False
            Tile4.ForeColor = Color.Blue
            counter += 1
        Else
            Tile4.Text = "O"
            flag = True
            Tile4.ForeColor = Color.Red
            counter += 1
        End If
        Tile4.Enabled = False
        CheckWinner()
    End Sub

    Private Sub Tile5_Click(sender As Object, e As EventArgs) Handles Tile5.Click
        If flag Then
            Tile5.Text = "X"
            flag = False
            Tile5.ForeColor = Color.Blue
            counter += 1
        Else
            Tile5.Text = "O"
            flag = True
            Tile5.ForeColor = Color.Red
            counter += 1
        End If
        Tile5.Enabled = False
        CheckWinner()
    End Sub

    Private Sub Tile6_Click(sender As Object, e As EventArgs) Handles Tile6.Click
        If flag Then
            Tile6.Text = "X"
            flag = False
            Tile6.ForeColor = Color.Blue
            counter += 1
        Else
            Tile6.Text = "O"
            flag = True
            Tile6.ForeColor = Color.Red
            counter += 1
        End If
        Tile6.Enabled = False
        CheckWinner()
    End Sub

    Private Sub CheckWinner()
        If Tile1.Text = "X" And Tile2.Text = "X" And Tile3.Text = "X" Then
            Tile1.BackColor = Color.IndianRed
            Tile2.BackColor = Color.IndianRed
            Tile3.BackColor = Color.IndianRed
            Player1ScoreLabel.Text = Player1ScoreLabel.Text + 1
            MsgBox("Player " + Startup.PlayerOneNameTextbox.Text + " Won", MsgBoxStyle.Information)
            Disable_buttons()
        ElseIf Tile1.Text = "O" And Tile2.Text = "O" And Tile3.Text = "O" Then
            Tile1.BackColor = Color.IndianRed
            Tile2.BackColor = Color.IndianRed
            Tile3.BackColor = Color.IndianRed
            Player2ScoreLabel.Text = Player2ScoreLabel.Text + 1
            MsgBox("Player " + Startup.PlayerTwoNameTextBox.Text + " Won", MsgBoxStyle.Information)
            Disable_buttons()
        ElseIf Tile4.Text = "X" And Tile5.Text = "X" And Tile6.Text = "X" Then
            Tile4.BackColor = Color.IndianRed
            Tile5.BackColor = Color.IndianRed
            Tile6.BackColor = Color.IndianRed
            Player1ScoreLabel.Text = Player1ScoreLabel.Text + 1
            MsgBox("Player " + Startup.PlayerOneNameTextbox.Text + " Won", MsgBoxStyle.Information)
            Disable_buttons()
        ElseIf Tile4.Text = "O" And Tile5.Text = "O" And Tile6.Text = "O" Then
            Tile4.BackColor = Color.IndianRed
            Tile5.BackColor = Color.IndianRed
            Tile6.BackColor = Color.IndianRed
            Player2ScoreLabel.Text = Player2ScoreLabel.Text + 1
            MsgBox("Player " + Startup.PlayerTwoNameTextBox.Text + " Won", MsgBoxStyle.Information)
            Disable_buttons()
        ElseIf Tile7.Text = "X" And Tile8.Text = "X" And Tile9.Text = "X" Then
            Tile7.BackColor = Color.IndianRed
            Tile8.BackColor = Color.IndianRed
            Tile9.BackColor = Color.IndianRed
            Player1ScoreLabel.Text = Player1ScoreLabel.Text + 1
            MsgBox("Player " + Startup.PlayerOneNameTextbox.Text + " Won", MsgBoxStyle.Information)
            Disable_buttons()
        ElseIf Tile7.Text = "O" And Tile8.Text = "O" And Tile9.Text = "O" Then
            Tile7.BackColor = Color.IndianRed
            Tile8.BackColor = Color.IndianRed
            Tile9.BackColor = Color.IndianRed
            Player2ScoreLabel.Text = Player2ScoreLabel.Text + 1
            MsgBox("Player " + Startup.PlayerTwoNameTextBox.Text + " Won", MsgBoxStyle.Information)
            Disable_buttons()
        ElseIf Tile1.Text = "X" And Tile4.Text = "X" And Tile7.Text = "X" Then
            Tile1.BackColor = Color.IndianRed
            Tile4.BackColor = Color.IndianRed
            Tile7.BackColor = Color.IndianRed
            Player1ScoreLabel.Text = Player1ScoreLabel.Text + 1
            MsgBox("Player " + Startup.PlayerOneNameTextbox.Text + " Won", MsgBoxStyle.Information)
            Disable_buttons()
        ElseIf Tile1.Text = "O" And Tile4.Text = "O" And Tile7.Text = "O" Then
            Tile1.BackColor = Color.IndianRed
            Tile4.BackColor = Color.IndianRed
            Tile7.BackColor = Color.IndianRed
            Player2ScoreLabel.Text = Player2ScoreLabel.Text + 1
            MsgBox("Player " + Startup.PlayerTwoNameTextBox.Text + " Won", MsgBoxStyle.Information)
            Disable_buttons()
        ElseIf Tile2.Text = "X" And Tile5.Text = "X" And Tile8.Text = "X" Then
            Tile2.BackColor = Color.IndianRed
            Tile5.BackColor = Color.IndianRed
            Tile8.BackColor = Color.IndianRed
            Player1ScoreLabel.Text = Player1ScoreLabel.Text + 1
            MsgBox("Player " + Startup.PlayerOneNameTextbox.Text + " Won", MsgBoxStyle.Information)
            Disable_buttons()
        ElseIf Tile2.Text = "O" And Tile5.Text = "O" And Tile8.Text = "O" Then
            Tile2.BackColor = Color.IndianRed
            Tile5.BackColor = Color.IndianRed
            Tile8.BackColor = Color.IndianRed
            Player2ScoreLabel.Text = Player2ScoreLabel.Text + 1
            MsgBox("Player " + Startup.PlayerTwoNameTextBox.Text + " Won", MsgBoxStyle.Information)
            Disable_buttons()
        ElseIf Tile3.Text = "X" And Tile6.Text = "X" And Tile9.Text = "X" Then
            Tile3.BackColor = Color.IndianRed
            Tile6.BackColor = Color.IndianRed
            Tile9.BackColor = Color.IndianRed
            Player1ScoreLabel.Text = Player1ScoreLabel.Text + 1
            MsgBox("Player " + Startup.PlayerOneNameTextbox.Text + " Won", MsgBoxStyle.Information)
            Disable_buttons()
        ElseIf Tile3.Text = "O" And Tile6.Text = "O" And Tile9.Text = "O" Then
            Tile3.BackColor = Color.IndianRed
            Tile6.BackColor = Color.IndianRed
            Tile9.BackColor = Color.IndianRed
            Player2ScoreLabel.Text = Player2ScoreLabel.Text + 1
            MsgBox("Player " + Startup.PlayerTwoNameTextBox.Text + " Won", MsgBoxStyle.Information)
            Disable_buttons()
        ElseIf Tile1.Text = "X" And Tile5.Text = "X" And Tile9.Text = "X" Then
            Tile1.BackColor = Color.IndianRed
            Tile5.BackColor = Color.IndianRed
            Tile9.BackColor = Color.IndianRed
            Player1ScoreLabel.Text = Player1ScoreLabel.Text + 1
            MsgBox("Player " + Startup.PlayerOneNameTextbox.Text + " Won", MsgBoxStyle.Information)
            Disable_buttons()
        ElseIf Tile1.Text = "O" And Tile5.Text = "O" And Tile9.Text = "O" Then
            Tile1.BackColor = Color.IndianRed
            Tile5.BackColor = Color.IndianRed
            Tile9.BackColor = Color.IndianRed
            Player2ScoreLabel.Text = Player2ScoreLabel.Text + 1
            MsgBox("Player " + Startup.PlayerTwoNameTextBox.Text + " Won", MsgBoxStyle.Information)
            Disable_buttons()
        ElseIf Tile3.Text = "X" And Tile5.Text = "X" And Tile7.Text = "X" Then
            Tile3.BackColor = Color.IndianRed
            Tile5.BackColor = Color.IndianRed
            Tile7.BackColor = Color.IndianRed
            Player1ScoreLabel.Text = Player1ScoreLabel.Text + 1
            MsgBox("Player " + Startup.PlayerOneNameTextbox.Text + " Won", MsgBoxStyle.Information)
            Disable_buttons()
        ElseIf Tile3.Text = "O" And Tile5.Text = "O" And Tile7.Text = "O" Then
            Tile3.BackColor = Color.IndianRed
            Tile5.BackColor = Color.IndianRed
            Tile7.BackColor = Color.IndianRed
            Player2ScoreLabel.Text = Player2ScoreLabel.Text + 1
            MsgBox("Player " + Startup.PlayerTwoNameTextBox.Text + " Won", MsgBoxStyle.Information)
            Disable_buttons()
        ElseIf counter = 9 Then
            MsgBox("Match Drawn")
        End If
    End Sub
    Private Sub Disable_buttons()
        Tile1.Enabled = False
        Tile2.Enabled = False
        Tile3.Enabled = False
        Tile4.Enabled = False
        Tile5.Enabled = False
        Tile6.Enabled = False
        Tile7.Enabled = False
        Tile8.Enabled = False
        Tile9.Enabled = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Startup.PlayerOneNameTextbox.Text
        Label2.Text = Startup.PlayerTwoNameTextBox.Text
    End Sub

    Private Sub Tile7_Click(sender As Object, e As EventArgs) Handles Tile7.Click
        If flag Then
            Tile7.Text = "X"
            flag = False
            Tile7.ForeColor = Color.Blue
            counter += 1
        Else
            Tile7.Text = "O"
            flag = True
            Tile7.ForeColor = Color.Red
            counter += 1
        End If
        Tile7.Enabled = False
        CheckWinner()
    End Sub

    Private Sub Tile8_Click(sender As Object, e As EventArgs) Handles Tile8.Click
        If flag Then
            Tile8.Text = "X"
            flag = False
            Tile8.ForeColor = Color.Blue
            counter += 1
        Else
            Tile8.Text = "O"
            flag = True
            Tile8.ForeColor = Color.Red
            counter += 1
        End If
        Tile8.Enabled = False
        CheckWinner()
    End Sub

    Private Sub Tile9_Click(sender As Object, e As EventArgs) Handles Tile9.Click
        If flag Then
            Tile9.Text = "X"
            flag = False
            Tile9.ForeColor = Color.Blue
            counter += 1
        Else
            Tile9.Text = "O"
            flag = True
            Tile9.ForeColor = Color.Red
            counter += 1
        End If
        Tile9.Enabled = False
        CheckWinner()
    End Sub

    Private Sub RestartButton_Click(sender As Object, e As EventArgs) Handles RestartButton.Click
        Disable_buttons()
        Tile1.Text = ""
        Tile2.Text = ""
        Tile3.Text = ""

        Tile4.Text = ""
        Tile5.Text = ""
        Tile6.Text = ""

        Tile7.Text = ""
        Tile8.Text = ""
        Tile9.Text = ""

        Tile1.Enabled = True
        Tile2.Enabled = True
        Tile3.Enabled = True
        Tile4.Enabled = True
        Tile5.Enabled = True
        Tile6.Enabled = True
        Tile7.Enabled = True
        Tile8.Enabled = True
        Tile9.Enabled = True

        Tile1.BackColor = Color.White
        Tile2.BackColor = Color.White
        Tile3.BackColor = Color.White
        Tile4.BackColor = Color.White
        Tile5.BackColor = Color.White
        Tile6.BackColor = Color.White
        Tile7.BackColor = Color.White
        Tile8.BackColor = Color.White
        Tile9.BackColor = Color.White

        counter = 0
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Hide()
        Startup.Show()
    End Sub

#Region "Design"
    Private Sub Tile1_MouseMove(sender As Object, e As MouseEventArgs) Handles Tile1.MouseMove
        Tile1.BackColor = Startup.MoveColor
    End Sub

    Private Sub Tile1_MouseLeave(sender As Object, e As EventArgs) Handles Tile1.MouseLeave
        Tile1.BackColor = Color.Transparent
    End Sub

    Private Sub Tile2_MouseMove(sender As Object, e As MouseEventArgs) Handles Tile2.MouseMove
        Tile2.BackColor = Startup.MoveColor
    End Sub

    Private Sub Tile2_MouseLeave(sender As Object, e As EventArgs) Handles Tile2.MouseLeave
        Tile2.BackColor = Color.Transparent
    End Sub

    Private Sub Tile3_MouseMove(sender As Object, e As MouseEventArgs) Handles Tile3.MouseMove
        Tile3.BackColor = Startup.MoveColor
    End Sub

    Private Sub Tile3_MouseLeave(sender As Object, e As EventArgs) Handles Tile3.MouseLeave
        Tile3.BackColor = Color.Transparent
    End Sub

    Private Sub Tile4_MouseMove(sender As Object, e As MouseEventArgs) Handles Tile4.MouseMove
        Tile4.BackColor = Startup.MoveColor
    End Sub

    Private Sub Tile4_MouseLeave(sender As Object, e As EventArgs) Handles Tile4.MouseLeave
        Tile4.BackColor = Color.Transparent
    End Sub

    Private Sub Tile5_MouseMove(sender As Object, e As MouseEventArgs) Handles Tile5.MouseMove
        Tile5.BackColor = Startup.MoveColor
    End Sub

    Private Sub Tile5_MouseLeave(sender As Object, e As EventArgs) Handles Tile5.MouseLeave
        Tile5.BackColor = Color.Transparent
    End Sub

    Private Sub Tile6_MouseMove(sender As Object, e As MouseEventArgs) Handles Tile6.MouseMove
        Tile6.BackColor = Startup.MoveColor
    End Sub

    Private Sub Tile6_MouseLeave(sender As Object, e As EventArgs) Handles Tile6.MouseLeave
        Tile6.BackColor = Color.Transparent
    End Sub

    Private Sub Tile7_MouseMove(sender As Object, e As MouseEventArgs) Handles Tile7.MouseMove
        Tile7.BackColor = Startup.MoveColor
    End Sub

    Private Sub Tile7_MouseLeave(sender As Object, e As EventArgs) Handles Tile7.MouseLeave
        Tile7.BackColor = Color.Transparent
    End Sub

    Private Sub Tile8_MouseMove(sender As Object, e As MouseEventArgs) Handles Tile8.MouseMove
        Tile8.BackColor = Startup.MoveColor
    End Sub

    Private Sub Tile8_MouseLeave(sender As Object, e As EventArgs) Handles Tile8.MouseLeave
        Tile8.BackColor = Color.Transparent
    End Sub

    Private Sub Tile9_MouseMove(sender As Object, e As MouseEventArgs) Handles Tile9.MouseMove
        Tile9.BackColor = Startup.MoveColor
    End Sub

    Private Sub Tile9_MouseLeave(sender As Object, e As EventArgs) Handles Tile9.MouseLeave
        Tile9.BackColor = Color.Transparent
    End Sub
#End Region

End Class