<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Startup
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
        Me.GameTitleLabel = New System.Windows.Forms.Label()
        Me.SubTitleLabel = New System.Windows.Forms.Label()
        Me.SoloButton = New System.Windows.Forms.Button()
        Me.MultiplayerButton = New System.Windows.Forms.Button()
        Me.PlayerOneNameTextbox = New System.Windows.Forms.TextBox()
        Me.Player1NameLabel = New System.Windows.Forms.Label()
        Me.Player2NameLabel = New System.Windows.Forms.Label()
        Me.PlayerTwoNameTextBox = New System.Windows.Forms.TextBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.SoloPlayerNameLabel = New System.Windows.Forms.Label()
        Me.SoloPlayerNameTextBox = New System.Windows.Forms.TextBox()
        Me.InfosSoloPanel = New System.Windows.Forms.Panel()
        Me.InfosMultiplayerPanel = New System.Windows.Forms.Panel()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.InfosSoloPanel.SuspendLayout()
        Me.InfosMultiplayerPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GameTitleLabel
        '
        Me.GameTitleLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.GameTitleLabel.Font = New System.Drawing.Font("Magneto", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameTitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GameTitleLabel.Location = New System.Drawing.Point(0, 0)
        Me.GameTitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GameTitleLabel.Name = "GameTitleLabel"
        Me.GameTitleLabel.Size = New System.Drawing.Size(896, 76)
        Me.GameTitleLabel.TabIndex = 0
        Me.GameTitleLabel.Text = "Tic Tac Toe"
        Me.GameTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SubTitleLabel
        '
        Me.SubTitleLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTitleLabel.ForeColor = System.Drawing.Color.Silver
        Me.SubTitleLabel.Location = New System.Drawing.Point(0, 76)
        Me.SubTitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SubTitleLabel.Name = "SubTitleLabel"
        Me.SubTitleLabel.Size = New System.Drawing.Size(896, 37)
        Me.SubTitleLabel.TabIndex = 1
        Me.SubTitleLabel.Text = "Start a game..."
        Me.SubTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SoloButton
        '
        Me.SoloButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SoloButton.BackColor = System.Drawing.Color.Transparent
        Me.SoloButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SoloButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SoloButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoloButton.ForeColor = System.Drawing.Color.DodgerBlue
        Me.SoloButton.Location = New System.Drawing.Point(205, 150)
        Me.SoloButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SoloButton.MaximumSize = New System.Drawing.Size(235, 41)
        Me.SoloButton.MinimumSize = New System.Drawing.Size(235, 41)
        Me.SoloButton.Name = "SoloButton"
        Me.SoloButton.Size = New System.Drawing.Size(235, 41)
        Me.SoloButton.TabIndex = 2
        Me.SoloButton.Text = "Single Mode"
        Me.SoloButton.UseVisualStyleBackColor = False
        '
        'MultiplayerButton
        '
        Me.MultiplayerButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MultiplayerButton.BackColor = System.Drawing.Color.Transparent
        Me.MultiplayerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MultiplayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MultiplayerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiplayerButton.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MultiplayerButton.Location = New System.Drawing.Point(457, 150)
        Me.MultiplayerButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MultiplayerButton.MaximumSize = New System.Drawing.Size(235, 41)
        Me.MultiplayerButton.MinimumSize = New System.Drawing.Size(235, 41)
        Me.MultiplayerButton.Name = "MultiplayerButton"
        Me.MultiplayerButton.Size = New System.Drawing.Size(235, 41)
        Me.MultiplayerButton.TabIndex = 3
        Me.MultiplayerButton.Text = "Multiplayer"
        Me.MultiplayerButton.UseVisualStyleBackColor = False
        '
        'PlayerOneNameTextbox
        '
        Me.PlayerOneNameTextbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PlayerOneNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PlayerOneNameTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerOneNameTextbox.ForeColor = System.Drawing.Color.Silver
        Me.PlayerOneNameTextbox.Location = New System.Drawing.Point(148, 6)
        Me.PlayerOneNameTextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayerOneNameTextbox.Multiline = True
        Me.PlayerOneNameTextbox.Name = "PlayerOneNameTextbox"
        Me.PlayerOneNameTextbox.Size = New System.Drawing.Size(253, 24)
        Me.PlayerOneNameTextbox.TabIndex = 4
        '
        'Player1NameLabel
        '
        Me.Player1NameLabel.AutoSize = True
        Me.Player1NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player1NameLabel.ForeColor = System.Drawing.Color.White
        Me.Player1NameLabel.Location = New System.Drawing.Point(16, 6)
        Me.Player1NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Player1NameLabel.Name = "Player1NameLabel"
        Me.Player1NameLabel.Size = New System.Drawing.Size(124, 24)
        Me.Player1NameLabel.TabIndex = 5
        Me.Player1NameLabel.Text = "Player 1 [X]:"
        '
        'Player2NameLabel
        '
        Me.Player2NameLabel.AutoSize = True
        Me.Player2NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player2NameLabel.ForeColor = System.Drawing.Color.White
        Me.Player2NameLabel.Location = New System.Drawing.Point(15, 38)
        Me.Player2NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Player2NameLabel.Name = "Player2NameLabel"
        Me.Player2NameLabel.Size = New System.Drawing.Size(125, 24)
        Me.Player2NameLabel.TabIndex = 6
        Me.Player2NameLabel.Text = "Player 2 [O]:"
        '
        'PlayerTwoNameTextBox
        '
        Me.PlayerTwoNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PlayerTwoNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PlayerTwoNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerTwoNameTextBox.ForeColor = System.Drawing.Color.Silver
        Me.PlayerTwoNameTextBox.Location = New System.Drawing.Point(148, 38)
        Me.PlayerTwoNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayerTwoNameTextBox.Multiline = True
        Me.PlayerTwoNameTextBox.Name = "PlayerTwoNameTextBox"
        Me.PlayerTwoNameTextBox.Size = New System.Drawing.Size(253, 24)
        Me.PlayerTwoNameTextBox.TabIndex = 7
        '
        'StartButton
        '
        Me.StartButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartButton.BackColor = System.Drawing.Color.Transparent
        Me.StartButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.ForeColor = System.Drawing.Color.LimeGreen
        Me.StartButton.Location = New System.Drawing.Point(648, 333)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(235, 57)
        Me.StartButton.TabIndex = 8
        Me.StartButton.Text = "Start now !"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'SoloPlayerNameLabel
        '
        Me.SoloPlayerNameLabel.AutoSize = True
        Me.SoloPlayerNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoloPlayerNameLabel.ForeColor = System.Drawing.Color.White
        Me.SoloPlayerNameLabel.Location = New System.Drawing.Point(5, 6)
        Me.SoloPlayerNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SoloPlayerNameLabel.Name = "SoloPlayerNameLabel"
        Me.SoloPlayerNameLabel.Size = New System.Drawing.Size(135, 24)
        Me.SoloPlayerNameLabel.TabIndex = 9
        Me.SoloPlayerNameLabel.Text = "Player Name:"
        '
        'SoloPlayerNameTextBox
        '
        Me.SoloPlayerNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SoloPlayerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SoloPlayerNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoloPlayerNameTextBox.ForeColor = System.Drawing.Color.Silver
        Me.SoloPlayerNameTextBox.Location = New System.Drawing.Point(148, 6)
        Me.SoloPlayerNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SoloPlayerNameTextBox.Multiline = True
        Me.SoloPlayerNameTextBox.Name = "SoloPlayerNameTextBox"
        Me.SoloPlayerNameTextBox.Size = New System.Drawing.Size(253, 24)
        Me.SoloPlayerNameTextBox.TabIndex = 10
        '
        'InfosSoloPanel
        '
        Me.InfosSoloPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfosSoloPanel.Controls.Add(Me.SoloPlayerNameTextBox)
        Me.InfosSoloPanel.Controls.Add(Me.SoloPlayerNameLabel)
        Me.InfosSoloPanel.Location = New System.Drawing.Point(244, 209)
        Me.InfosSoloPanel.Name = "InfosSoloPanel"
        Me.InfosSoloPanel.Size = New System.Drawing.Size(408, 37)
        Me.InfosSoloPanel.TabIndex = 11
        '
        'InfosMultiplayerPanel
        '
        Me.InfosMultiplayerPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfosMultiplayerPanel.Controls.Add(Me.Player1NameLabel)
        Me.InfosMultiplayerPanel.Controls.Add(Me.PlayerOneNameTextbox)
        Me.InfosMultiplayerPanel.Controls.Add(Me.Player2NameLabel)
        Me.InfosMultiplayerPanel.Controls.Add(Me.PlayerTwoNameTextBox)
        Me.InfosMultiplayerPanel.Location = New System.Drawing.Point(244, 209)
        Me.InfosMultiplayerPanel.Name = "InfosMultiplayerPanel"
        Me.InfosMultiplayerPanel.Size = New System.Drawing.Size(408, 73)
        Me.InfosMultiplayerPanel.TabIndex = 12
        '
        'ErrorLabel
        '
        Me.ErrorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorLabel.ForeColor = System.Drawing.Color.IndianRed
        Me.ErrorLabel.Location = New System.Drawing.Point(648, 297)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(235, 29)
        Me.ErrorLabel.TabIndex = 13
        Me.ErrorLabel.Text = "{ERROR}"
        Me.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Startup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(896, 401)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.InfosMultiplayerPanel)
        Me.Controls.Add(Me.InfosSoloPanel)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.MultiplayerButton)
        Me.Controls.Add(Me.SoloButton)
        Me.Controls.Add(Me.SubTitleLabel)
        Me.Controls.Add(Me.GameTitleLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Startup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tic Tac Toe"
        Me.InfosSoloPanel.ResumeLayout(False)
        Me.InfosSoloPanel.PerformLayout()
        Me.InfosMultiplayerPanel.ResumeLayout(False)
        Me.InfosMultiplayerPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GameTitleLabel As System.Windows.Forms.Label
    Friend WithEvents SubTitleLabel As System.Windows.Forms.Label
    Friend WithEvents SoloButton As System.Windows.Forms.Button
    Friend WithEvents MultiplayerButton As System.Windows.Forms.Button
    Friend WithEvents PlayerOneNameTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Player1NameLabel As System.Windows.Forms.Label
    Friend WithEvents Player2NameLabel As System.Windows.Forms.Label
    Friend WithEvents PlayerTwoNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents SoloPlayerNameLabel As System.Windows.Forms.Label
    Friend WithEvents SoloPlayerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InfosSoloPanel As Panel
    Friend WithEvents InfosMultiplayerPanel As Panel
    Friend WithEvents ErrorLabel As Label
End Class
