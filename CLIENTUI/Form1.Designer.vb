<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label2 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox2 = New PictureBox()
        Login = New Button()
        Passwordtxt = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Usernametxt = New TextBox()
        Label1 = New Label()
        TableLayoutPanel14 = New TableLayoutPanel()
        PictureBox5 = New PictureBox()
        Label4 = New Label()
        LoginPanel = New TableLayoutPanel()
        chkShowPassword = New CheckBox()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel14.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        LoginPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(1087, 431)
        Label2.Margin = New Padding(800, 79, 200, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 25)
        Label2.TabIndex = 1
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = Color.White
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 32.1022072F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.7955856F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 32.1022072F))
        TableLayoutPanel1.Controls.Add(PictureBox2, 0, 0)
        TableLayoutPanel1.Location = New Point(0, 805)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 39.5348854F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 30.2325573F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.1782942F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15.5038757F))
        TableLayoutPanel1.Size = New Size(1905, 158)
        TableLayoutPanel1.TabIndex = 24
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 36)
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' Login
        ' 
        Login.BackgroundImageLayout = ImageLayout.Stretch
        Login.Dock = DockStyle.Fill
        Login.Font = New Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Login.Location = New Point(103, 373)
        Login.Name = "Login"
        Login.Size = New Size(294, 68)
        Login.TabIndex = 3
        Login.Text = "Log In"
        Login.UseVisualStyleBackColor = True
        ' 
        ' Passwordtxt
        ' 
        Passwordtxt.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Passwordtxt.Font = New Font("Arial", 20.25F)
        Passwordtxt.Location = New Point(103, 269)
        Passwordtxt.Name = "Passwordtxt"
        Passwordtxt.PasswordChar = "*"c
        Passwordtxt.Size = New Size(294, 39)
        Passwordtxt.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Bottom
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 20.25F)
        Label5.Location = New Point(184, 234)
        Label5.Name = "Label5"
        Label5.Size = New Size(132, 32)
        Label5.TabIndex = 3
        Label5.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 20.25F)
        Label3.Location = New Point(181, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 32)
        Label3.TabIndex = 2
        Label3.Text = "Username"
        ' 
        ' Usernametxt
        ' 
        Usernametxt.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Usernametxt.Font = New Font("Arial", 20.25F)
        Usernametxt.Location = New Point(103, 151)
        Usernametxt.Name = "Usernametxt"
        Usernametxt.Size = New Size(294, 39)
        Usernametxt.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(169, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 41)
        Label1.TabIndex = 0
        Label1.Text = "Welcome"
        ' 
        ' TableLayoutPanel14
        ' 
        TableLayoutPanel14.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel14.AutoSize = True
        TableLayoutPanel14.BackColor = Color.FromArgb(CByte(12), CByte(43), CByte(78))
        TableLayoutPanel14.ColumnCount = 3
        TableLayoutPanel14.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel14.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel14.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel14.Controls.Add(PictureBox5, 0, 0)
        TableLayoutPanel14.Controls.Add(Label4, 1, 0)
        TableLayoutPanel14.Location = New Point(0, 0)
        TableLayoutPanel14.Name = "TableLayoutPanel14"
        TableLayoutPanel14.RowCount = 1
        TableLayoutPanel14.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel14.Size = New Size(1905, 142)
        TableLayoutPanel14.TabIndex = 85
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Cursor = Cursors.Hand
        PictureBox5.Image = My.Resources.Resources._578935847_1627970941508389_3020005775530561214_n_removebg_preview
        PictureBox5.Location = New Point(25, 10)
        PictureBox5.Margin = New Padding(25, 10, 0, 3)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(129, 128)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 3
        PictureBox5.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom
        Label4.AutoSize = True
        Label4.Cursor = Cursors.Hand
        Label4.Font = New Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.ImageAlign = ContentAlignment.TopCenter
        Label4.Location = New Point(898, 101)
        Label4.Margin = New Padding(3)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 38)
        Label4.TabIndex = 4
        Label4.Text = "HOME"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LoginPanel
        ' 
        LoginPanel.ColumnCount = 3
        LoginPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        LoginPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60F))
        LoginPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        LoginPanel.Controls.Add(Label1, 1, 0)
        LoginPanel.Controls.Add(Login, 1, 5)
        LoginPanel.Controls.Add(Label3, 1, 1)
        LoginPanel.Controls.Add(Label5, 1, 3)
        LoginPanel.Controls.Add(Passwordtxt, 1, 4)
        LoginPanel.Controls.Add(Usernametxt, 1, 2)
        LoginPanel.Controls.Add(chkShowPassword, 2, 4)
        LoginPanel.Location = New Point(710, 240)
        LoginPanel.Name = "LoginPanel"
        LoginPanel.RowCount = 7
        LoginPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 14.3093F))
        LoginPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 14.3093F))
        LoginPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10.209136F))
        LoginPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5206385F))
        LoginPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20.03302F))
        LoginPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 14.3093F))
        LoginPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 14.3093F))
        LoginPanel.Size = New Size(501, 520)
        LoginPanel.TabIndex = 0
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(403, 269)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(95, 23)
        chkShowPassword.TabIndex = 4
        chkShowPassword.Text = "CheckBox1"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._576825842_1335610788354022_2752363819616472036_n1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1904, 961)
        Controls.Add(LoginPanel)
        Controls.Add(TableLayoutPanel14)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Label2)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 10F)
        Name = "Form1"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel14.ResumeLayout(False)
        TableLayoutPanel14.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        LoginPanel.ResumeLayout(False)
        LoginPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Usernametxt As TextBox
    Friend WithEvents Passwordtxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Login As Button
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LoginPanel As TableLayoutPanel
    Friend WithEvents chkShowPassword As CheckBox

End Class
