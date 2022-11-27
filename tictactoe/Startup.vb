Public Class Startup
    Public SoloGame As Boolean = True
    Public ReadOnly MoveColor As Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InfosMultiplayerPanel.Visible = False
        InfosSoloPanel.Visible = False
        Me.ErrorLabel.Visible = False
    End Sub

    Private Sub MultiplayerButton_Click(sender As Object, e As EventArgs) Handles MultiplayerButton.Click
        InfosMultiplayerPanel.Visible = True
        InfosSoloPanel.Visible = False
        SoloGame = False
    End Sub

    Private Sub SoloButton_Click(sender As Object, e As EventArgs) Handles SoloButton.Click
        InfosMultiplayerPanel.Visible = False
        InfosSoloPanel.Visible = True
        SoloGame = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If SoloGame = True Then
            If SoloPlayerNameTextBox.Text.Length > 0 Then
                Solo.Show()
                Me.Hide()
            Else
                ShowError("Player name cannot be empty!")
            End If
        Else
            If PlayerOneNameTextbox.Text.Length > 0 Then
                If PlayerTwoNameTextBox.Text.Length > 0 Then
                    Multiplayer.Show()
                    Me.Hide()
                Else
                    ShowError("Player 2 name cannot be empty!")
                End If
            Else
                ShowError("Player 1 name cannot be empty!")
            End If
        End If
    End Sub

    Private Function ShowError(text As String) As Boolean
        ErrorLabel.Visible = True
        ErrorLabel.Text = text
        Return True
    End Function

#Region "Design"
    Private Sub SoloButton_MouseMove(sender As Object, e As MouseEventArgs) Handles SoloButton.MouseMove
        SoloButton.BackColor = MoveColor
    End Sub
    Private Sub SoloButton_MouseLeave(sender As Object, e As EventArgs) Handles SoloButton.MouseLeave
        SoloButton.BackColor = Color.Transparent
    End Sub

    Private Sub MultiplayerButton_MouseMove(sender As Object, e As MouseEventArgs) Handles MultiplayerButton.MouseMove
        MultiplayerButton.BackColor = MoveColor
    End Sub

    Private Sub MultiplayerButton_MouseLeave(sender As Object, e As EventArgs) Handles MultiplayerButton.MouseLeave
        MultiplayerButton.BackColor = Color.Transparent
    End Sub

    Private Sub StartButton_MouseMove(sender As Object, e As MouseEventArgs) Handles StartButton.MouseMove
        StartButton.BackColor = MoveColor
    End Sub

    Private Sub StartButton_MouseLeave(sender As Object, e As EventArgs) Handles StartButton.MouseLeave
        StartButton.BackColor = Color.Transparent
    End Sub
#End Region

End Class