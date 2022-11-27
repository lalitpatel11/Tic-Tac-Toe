<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Multiplayer
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
        Me.Tile1 = New System.Windows.Forms.Button()
        Me.Tile2 = New System.Windows.Forms.Button()
        Me.Tile3 = New System.Windows.Forms.Button()
        Me.Tile4 = New System.Windows.Forms.Button()
        Me.Tile5 = New System.Windows.Forms.Button()
        Me.Tile6 = New System.Windows.Forms.Button()
        Me.Tile7 = New System.Windows.Forms.Button()
        Me.Tile8 = New System.Windows.Forms.Button()
        Me.Tile9 = New System.Windows.Forms.Button()
        Me.RestartButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Player1ScoreLabel = New System.Windows.Forms.Label()
        Me.Player2ScoreLabel = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GamePanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GamePanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tile1
        '
        Me.Tile1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tile1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tile1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tile1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Tile1.Location = New System.Drawing.Point(4, 4)
        Me.Tile1.Margin = New System.Windows.Forms.Padding(4)
        Me.Tile1.Name = "Tile1"
        Me.Tile1.Size = New System.Drawing.Size(100, 100)
        Me.Tile1.TabIndex = 0
        Me.Tile1.UseVisualStyleBackColor = True
        '
        'Tile2
        '
        Me.Tile2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tile2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tile2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Tile2.Location = New System.Drawing.Point(112, 4)
        Me.Tile2.Margin = New System.Windows.Forms.Padding(4)
        Me.Tile2.Name = "Tile2"
        Me.Tile2.Size = New System.Drawing.Size(100, 100)
        Me.Tile2.TabIndex = 1
        Me.Tile2.UseVisualStyleBackColor = True
        '
        'Tile3
        '
        Me.Tile3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tile3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tile3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tile3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Tile3.Location = New System.Drawing.Point(220, 4)
        Me.Tile3.Margin = New System.Windows.Forms.Padding(4)
        Me.Tile3.Name = "Tile3"
        Me.Tile3.Size = New System.Drawing.Size(100, 100)
        Me.Tile3.TabIndex = 2
        Me.Tile3.UseVisualStyleBackColor = True
        '
        'Tile4
        '
        Me.Tile4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tile4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tile4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tile4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Tile4.Location = New System.Drawing.Point(4, 112)
        Me.Tile4.Margin = New System.Windows.Forms.Padding(4)
        Me.Tile4.Name = "Tile4"
        Me.Tile4.Size = New System.Drawing.Size(100, 100)
        Me.Tile4.TabIndex = 5
        Me.Tile4.UseVisualStyleBackColor = True
        '
        'Tile5
        '
        Me.Tile5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tile5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tile5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tile5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Tile5.Location = New System.Drawing.Point(112, 112)
        Me.Tile5.Margin = New System.Windows.Forms.Padding(4)
        Me.Tile5.Name = "Tile5"
        Me.Tile5.Size = New System.Drawing.Size(100, 100)
        Me.Tile5.TabIndex = 4
        Me.Tile5.UseVisualStyleBackColor = True
        '
        'Tile6
        '
        Me.Tile6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tile6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tile6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tile6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Tile6.Location = New System.Drawing.Point(220, 112)
        Me.Tile6.Margin = New System.Windows.Forms.Padding(4)
        Me.Tile6.Name = "Tile6"
        Me.Tile6.Size = New System.Drawing.Size(100, 100)
        Me.Tile6.TabIndex = 3
        Me.Tile6.UseVisualStyleBackColor = True
        '
        'Tile7
        '
        Me.Tile7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tile7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tile7.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tile7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Tile7.Location = New System.Drawing.Point(4, 220)
        Me.Tile7.Margin = New System.Windows.Forms.Padding(4)
        Me.Tile7.Name = "Tile7"
        Me.Tile7.Size = New System.Drawing.Size(100, 100)
        Me.Tile7.TabIndex = 8
        Me.Tile7.UseVisualStyleBackColor = True
        '
        'Tile8
        '
        Me.Tile8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tile8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tile8.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tile8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Tile8.Location = New System.Drawing.Point(112, 220)
        Me.Tile8.Margin = New System.Windows.Forms.Padding(4)
        Me.Tile8.Name = "Tile8"
        Me.Tile8.Size = New System.Drawing.Size(100, 100)
        Me.Tile8.TabIndex = 7
        Me.Tile8.UseVisualStyleBackColor = True
        '
        'Tile9
        '
        Me.Tile9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tile9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tile9.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tile9.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Tile9.Location = New System.Drawing.Point(220, 220)
        Me.Tile9.Margin = New System.Windows.Forms.Padding(4)
        Me.Tile9.Name = "Tile9"
        Me.Tile9.Size = New System.Drawing.Size(100, 100)
        Me.Tile9.TabIndex = 6
        Me.Tile9.UseVisualStyleBackColor = True
        '
        'RestartButton
        '
        Me.RestartButton.BackColor = System.Drawing.Color.Transparent
        Me.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RestartButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RestartButton.Location = New System.Drawing.Point(227, 540)
        Me.RestartButton.Margin = New System.Windows.Forms.Padding(4)
        Me.RestartButton.Name = "RestartButton"
        Me.RestartButton.Size = New System.Drawing.Size(112, 28)
        Me.RestartButton.TabIndex = 14
        Me.RestartButton.Text = "Re-Start"
        Me.RestartButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Player 1 "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(174, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 24)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Player 2 "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(360, 577)
        Me.ShapeContainer1.TabIndex = 17
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Red
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 638
        Me.LineShape1.X2 = 637
        Me.LineShape1.Y1 = 74
        Me.LineShape1.Y2 = 185
        '
        'Player1ScoreLabel
        '
        Me.Player1ScoreLabel.BackColor = System.Drawing.Color.Gray
        Me.Player1ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player1ScoreLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Player1ScoreLabel.Location = New System.Drawing.Point(10, 72)
        Me.Player1ScoreLabel.Name = "Player1ScoreLabel"
        Me.Player1ScoreLabel.Size = New System.Drawing.Size(158, 55)
        Me.Player1ScoreLabel.TabIndex = 18
        Me.Player1ScoreLabel.Text = "0"
        Me.Player1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Player2ScoreLabel
        '
        Me.Player2ScoreLabel.BackColor = System.Drawing.Color.Gray
        Me.Player2ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player2ScoreLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Player2ScoreLabel.Location = New System.Drawing.Point(178, 72)
        Me.Player2ScoreLabel.Name = "Player2ScoreLabel"
        Me.Player2ScoreLabel.Size = New System.Drawing.Size(142, 55)
        Me.Player2ScoreLabel.TabIndex = 19
        Me.Player2ScoreLabel.Text = "0"
        Me.Player2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.ForeColor = System.Drawing.Color.IndianRed
        Me.Button12.Location = New System.Drawing.Point(13, 13)
        Me.Button12.Margin = New System.Windows.Forms.Padding(4)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(112, 28)
        Me.Button12.TabIndex = 20
        Me.Button12.Text = "< Main Menu"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(55, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 24)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "[ X ]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(216, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 24)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "[ O ]"
        '
        'GamePanel
        '
        Me.GamePanel.Controls.Add(Me.Tile2)
        Me.GamePanel.Controls.Add(Me.Tile1)
        Me.GamePanel.Controls.Add(Me.Tile3)
        Me.GamePanel.Controls.Add(Me.Tile6)
        Me.GamePanel.Controls.Add(Me.Tile5)
        Me.GamePanel.Controls.Add(Me.Tile4)
        Me.GamePanel.Controls.Add(Me.Tile9)
        Me.GamePanel.Controls.Add(Me.Tile8)
        Me.GamePanel.Controls.Add(Me.Tile7)
        Me.GamePanel.Location = New System.Drawing.Point(13, 200)
        Me.GamePanel.Name = "GamePanel"
        Me.GamePanel.Size = New System.Drawing.Size(326, 333)
        Me.GamePanel.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Player1ScoreLabel)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Player2ScoreLabel)
        Me.Panel1.Location = New System.Drawing.Point(13, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 136)
        Me.Panel1.TabIndex = 24
        '
        'Multiplayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(360, 577)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GamePanel)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.RestartButton)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Multiplayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tic Tac Toe - Multiplayer"
        Me.GamePanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tile1 As System.Windows.Forms.Button
    Friend WithEvents Tile2 As System.Windows.Forms.Button
    Friend WithEvents Tile3 As System.Windows.Forms.Button
    Friend WithEvents Tile4 As System.Windows.Forms.Button
    Friend WithEvents Tile5 As System.Windows.Forms.Button
    Friend WithEvents Tile6 As System.Windows.Forms.Button
    Friend WithEvents Tile7 As System.Windows.Forms.Button
    Friend WithEvents Tile8 As System.Windows.Forms.Button
    Friend WithEvents Tile9 As System.Windows.Forms.Button
    Friend WithEvents RestartButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Player1ScoreLabel As System.Windows.Forms.Label
    Friend WithEvents Player2ScoreLabel As System.Windows.Forms.Label
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GamePanel As Panel
    Friend WithEvents Panel1 As Panel
End Class
