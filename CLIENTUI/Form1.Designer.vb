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
        TableLayoutPanel3 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Panel1 = New Panel()
        Login = New Button()
        Passwordtxt = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Usernametxt = New TextBox()
        Label1 = New Label()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(735, 431)
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
        TableLayoutPanel1.Location = New Point(0, 593)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 39.5348854F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 30.2325573F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.1782942F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15.5038757F))
        TableLayoutPanel1.Size = New Size(1370, 158)
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
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.AutoSize = True
        TableLayoutPanel3.BackColor = Color.FromArgb(CByte(12), CByte(43), CByte(78))
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 44.0508F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 23.930481F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 31.9518719F))
        TableLayoutPanel3.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel3.Controls.Add(Label4, 1, 0)
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 142.0F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 142.0F))
        TableLayoutPanel3.Size = New Size(1370, 142)
        TableLayoutPanel3.TabIndex = 70
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources._578935847_1627970941508389_3020005775530561214_n_removebg_preview
        PictureBox1.Location = New Point(25, 10)
        PictureBox1.Margin = New Padding(25, 10, 0, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(129, 128)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Cursor = Cursors.Hand
        Label4.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.ImageAlign = ContentAlignment.TopCenter
        Label4.Location = New Point(631, 91)
        Label4.Margin = New Padding(0, 91, 220, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 18)
        Label4.TabIndex = 4
        Label4.Text = "HOME"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Login)
        Panel1.Controls.Add(Passwordtxt)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Usernametxt)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(527, 241)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(278, 305)
        Panel1.TabIndex = 71
        ' 
        ' Login
        ' 
        Login.Location = New Point(81, 241)
        Login.Name = "Login"
        Login.Size = New Size(108, 38)
        Login.TabIndex = 5
        Login.Text = "Log In"
        Login.UseVisualStyleBackColor = True
        ' 
        ' Passwordtxt
        ' 
        Passwordtxt.Location = New Point(104, 126)
        Passwordtxt.Name = "Passwordtxt"
        Passwordtxt.Size = New Size(151, 25)
        Passwordtxt.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(27, 132)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 19)
        Label5.TabIndex = 3
        Label5.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 19)
        Label3.TabIndex = 2
        Label3.Text = "Username"
        ' 
        ' Usernametxt
        ' 
        Usernametxt.Location = New Point(104, 75)
        Usernametxt.Name = "Usernametxt"
        Usernametxt.Size = New Size(151, 25)
        Usernametxt.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(91, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 28)
        Label1.TabIndex = 0
        Label1.Text = "Log In"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 17.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._576825842_1335610788354022_2752363819616472036_n1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1200, 749)
        Controls.Add(Panel1)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Label2)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 10.0F)
        Name = "Form1"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Usernametxt As TextBox
    Friend WithEvents Passwordtxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Login As Button

End Class
