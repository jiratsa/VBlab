<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab3
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblFBlack = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFViolet = New System.Windows.Forms.Label()
        Me.lblFGreen = New System.Windows.Forms.Label()
        Me.lblFBlue = New System.Windows.Forms.Label()
        Me.lblFSky = New System.Windows.Forms.Label()
        Me.lblFWhite = New System.Windows.Forms.Label()
        Me.lblFBrown = New System.Windows.Forms.Label()
        Me.lblFYellow = New System.Windows.Forms.Label()
        Me.lblFOrange = New System.Windows.Forms.Label()
        Me.lblFRed = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblBRed = New System.Windows.Forms.Label()
        Me.lblBBlue = New System.Windows.Forms.Label()
        Me.lblBOrange = New System.Windows.Forms.Label()
        Me.lblBYellow = New System.Windows.Forms.Label()
        Me.lblBBrown = New System.Windows.Forms.Label()
        Me.lblBWhite = New System.Windows.Forms.Label()
        Me.lblBGreen = New System.Windows.Forms.Label()
        Me.lblBViolet = New System.Windows.Forms.Label()
        Me.lblBBlack = New System.Windows.Forms.Label()
        Me.lblBSky = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtInput.Location = New System.Drawing.Point(248, 77)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(220, 76)
        Me.txtInput.TabIndex = 0
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUp.Location = New System.Drawing.Point(474, 77)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(38, 35)
        Me.btnUp.TabIndex = 1
        Me.btnUp.Text = "+"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDown.Location = New System.Drawing.Point(474, 118)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(38, 35)
        Me.btnDown.TabIndex = 1
        Me.btnDown.Text = "-"
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'cboSize
        '
        Me.cboSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"12", "14", "16", "18", "20", "22", "24", "26", "28", "30", "32", "34", "36", "38", "40", "42", "44", "46", "48", "50"})
        Me.cboSize.Location = New System.Drawing.Point(389, 175)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(106, 21)
        Me.cboSize.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(109, 225)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 142)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 38)
        Me.Label1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.lblFBlack)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblFViolet)
        Me.GroupBox2.Controls.Add(Me.lblFGreen)
        Me.GroupBox2.Controls.Add(Me.lblFBlue)
        Me.GroupBox2.Controls.Add(Me.lblFSky)
        Me.GroupBox2.Controls.Add(Me.lblFWhite)
        Me.GroupBox2.Controls.Add(Me.lblFBrown)
        Me.GroupBox2.Controls.Add(Me.lblFYellow)
        Me.GroupBox2.Controls.Add(Me.lblFOrange)
        Me.GroupBox2.Controls.Add(Me.lblFRed)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(109, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 142)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ForeColor"
        '
        'lblFBlack
        '
        Me.lblFBlack.BackColor = System.Drawing.Color.Black
        Me.lblFBlack.Location = New System.Drawing.Point(200, 27)
        Me.lblFBlack.Name = "lblFBlack"
        Me.lblFBlack.Size = New System.Drawing.Size(40, 38)
        Me.lblFBlack.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(200, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 38)
        Me.Label6.TabIndex = 0
        '
        'lblFViolet
        '
        Me.lblFViolet.BackColor = System.Drawing.Color.Magenta
        Me.lblFViolet.Location = New System.Drawing.Point(154, 27)
        Me.lblFViolet.Name = "lblFViolet"
        Me.lblFViolet.Size = New System.Drawing.Size(40, 38)
        Me.lblFViolet.TabIndex = 0
        '
        'lblFGreen
        '
        Me.lblFGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFGreen.Location = New System.Drawing.Point(108, 27)
        Me.lblFGreen.Name = "lblFGreen"
        Me.lblFGreen.Size = New System.Drawing.Size(40, 38)
        Me.lblFGreen.TabIndex = 0
        '
        'lblFBlue
        '
        Me.lblFBlue.BackColor = System.Drawing.Color.Blue
        Me.lblFBlue.Location = New System.Drawing.Point(62, 27)
        Me.lblFBlue.Name = "lblFBlue"
        Me.lblFBlue.Size = New System.Drawing.Size(40, 38)
        Me.lblFBlue.TabIndex = 0
        '
        'lblFSky
        '
        Me.lblFSky.BackColor = System.Drawing.Color.Aqua
        Me.lblFSky.Location = New System.Drawing.Point(200, 78)
        Me.lblFSky.Name = "lblFSky"
        Me.lblFSky.Size = New System.Drawing.Size(40, 38)
        Me.lblFSky.TabIndex = 0
        '
        'lblFWhite
        '
        Me.lblFWhite.BackColor = System.Drawing.Color.White
        Me.lblFWhite.Location = New System.Drawing.Point(154, 78)
        Me.lblFWhite.Name = "lblFWhite"
        Me.lblFWhite.Size = New System.Drawing.Size(40, 38)
        Me.lblFWhite.TabIndex = 0
        '
        'lblFBrown
        '
        Me.lblFBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFBrown.Location = New System.Drawing.Point(108, 78)
        Me.lblFBrown.Name = "lblFBrown"
        Me.lblFBrown.Size = New System.Drawing.Size(40, 38)
        Me.lblFBrown.TabIndex = 0
        '
        'lblFYellow
        '
        Me.lblFYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFYellow.Location = New System.Drawing.Point(62, 78)
        Me.lblFYellow.Name = "lblFYellow"
        Me.lblFYellow.Size = New System.Drawing.Size(40, 38)
        Me.lblFYellow.TabIndex = 0
        '
        'lblFOrange
        '
        Me.lblFOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFOrange.Location = New System.Drawing.Point(16, 78)
        Me.lblFOrange.Name = "lblFOrange"
        Me.lblFOrange.Size = New System.Drawing.Size(40, 38)
        Me.lblFOrange.TabIndex = 0
        '
        'lblFRed
        '
        Me.lblFRed.BackColor = System.Drawing.Color.Red
        Me.lblFRed.Location = New System.Drawing.Point(16, 27)
        Me.lblFRed.Name = "lblFRed"
        Me.lblFRed.Size = New System.Drawing.Size(40, 38)
        Me.lblFRed.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(16, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 38)
        Me.Label2.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.Location = New System.Drawing.Point(150, 98)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(91, 23)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "กำหนดตัวเลข"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label25.Location = New System.Drawing.Point(308, 173)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(79, 23)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "ขนาดฟอนด์"
        '
        'lblBRed
        '
        Me.lblBRed.BackColor = System.Drawing.Color.Red
        Me.lblBRed.Location = New System.Drawing.Point(16, 27)
        Me.lblBRed.Name = "lblBRed"
        Me.lblBRed.Size = New System.Drawing.Size(40, 38)
        Me.lblBRed.TabIndex = 0
        '
        'lblBBlue
        '
        Me.lblBBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBBlue.Location = New System.Drawing.Point(62, 27)
        Me.lblBBlue.Name = "lblBBlue"
        Me.lblBBlue.Size = New System.Drawing.Size(40, 38)
        Me.lblBBlue.TabIndex = 0
        '
        'lblBOrange
        '
        Me.lblBOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBOrange.Location = New System.Drawing.Point(16, 78)
        Me.lblBOrange.Name = "lblBOrange"
        Me.lblBOrange.Size = New System.Drawing.Size(40, 38)
        Me.lblBOrange.TabIndex = 0
        '
        'lblBYellow
        '
        Me.lblBYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblBYellow.Location = New System.Drawing.Point(62, 78)
        Me.lblBYellow.Name = "lblBYellow"
        Me.lblBYellow.Size = New System.Drawing.Size(40, 38)
        Me.lblBYellow.TabIndex = 0
        '
        'lblBBrown
        '
        Me.lblBBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBBrown.Location = New System.Drawing.Point(108, 78)
        Me.lblBBrown.Name = "lblBBrown"
        Me.lblBBrown.Size = New System.Drawing.Size(40, 38)
        Me.lblBBrown.TabIndex = 0
        '
        'lblBWhite
        '
        Me.lblBWhite.BackColor = System.Drawing.Color.White
        Me.lblBWhite.Location = New System.Drawing.Point(154, 78)
        Me.lblBWhite.Name = "lblBWhite"
        Me.lblBWhite.Size = New System.Drawing.Size(40, 38)
        Me.lblBWhite.TabIndex = 0
        '
        'lblBGreen
        '
        Me.lblBGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBGreen.Location = New System.Drawing.Point(108, 27)
        Me.lblBGreen.Name = "lblBGreen"
        Me.lblBGreen.Size = New System.Drawing.Size(40, 38)
        Me.lblBGreen.TabIndex = 0
        '
        'lblBViolet
        '
        Me.lblBViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblBViolet.Location = New System.Drawing.Point(154, 27)
        Me.lblBViolet.Name = "lblBViolet"
        Me.lblBViolet.Size = New System.Drawing.Size(40, 38)
        Me.lblBViolet.TabIndex = 0
        '
        'lblBBlack
        '
        Me.lblBBlack.BackColor = System.Drawing.Color.Black
        Me.lblBBlack.Location = New System.Drawing.Point(200, 27)
        Me.lblBBlack.Name = "lblBBlack"
        Me.lblBBlack.Size = New System.Drawing.Size(40, 38)
        Me.lblBBlack.TabIndex = 0
        '
        'lblBSky
        '
        Me.lblBSky.BackColor = System.Drawing.Color.Aqua
        Me.lblBSky.Location = New System.Drawing.Point(200, 78)
        Me.lblBSky.Name = "lblBSky"
        Me.lblBSky.Size = New System.Drawing.Size(40, 38)
        Me.lblBSky.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.lblBSky)
        Me.GroupBox3.Controls.Add(Me.lblBBlack)
        Me.GroupBox3.Controls.Add(Me.lblBViolet)
        Me.GroupBox3.Controls.Add(Me.lblBGreen)
        Me.GroupBox3.Controls.Add(Me.lblBWhite)
        Me.GroupBox3.Controls.Add(Me.lblBBrown)
        Me.GroupBox3.Controls.Add(Me.lblBYellow)
        Me.GroupBox3.Controls.Add(Me.lblBOrange)
        Me.GroupBox3.Controls.Add(Me.lblBBlue)
        Me.GroupBox3.Controls.Add(Me.lblBRed)
        Me.GroupBox3.Location = New System.Drawing.Point(370, 225)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(260, 142)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "BgColor"
        '
        'frmLab3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(695, 393)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "frmLab3"
        Me.Text = "frmColor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnUp As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents cboSize As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblFBlack As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFViolet As Label
    Friend WithEvents lblFGreen As Label
    Friend WithEvents lblFBlue As Label
    Friend WithEvents lblFSky As Label
    Friend WithEvents lblFWhite As Label
    Friend WithEvents lblFBrown As Label
    Friend WithEvents lblFYellow As Label
    Friend WithEvents lblFOrange As Label
    Friend WithEvents lblFRed As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lblBRed As Label
    Friend WithEvents lblBBlue As Label
    Friend WithEvents lblBOrange As Label
    Friend WithEvents lblBYellow As Label
    Friend WithEvents lblBBrown As Label
    Friend WithEvents lblBWhite As Label
    Friend WithEvents lblBGreen As Label
    Friend WithEvents lblBViolet As Label
    Friend WithEvents lblBBlack As Label
    Friend WithEvents lblBSky As Label
    Friend WithEvents GroupBox3 As GroupBox
End Class
