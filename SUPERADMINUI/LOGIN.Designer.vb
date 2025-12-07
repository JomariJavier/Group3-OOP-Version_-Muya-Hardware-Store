<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        PictureBox1 = New PictureBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label8 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.White
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources._578935847_1627970941508389_3020005775530561214_n_removebg_preview
        PictureBox1.Location = New Point(187, 56)
        PictureBox1.Margin = New Padding(9, 7, 0, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(170, 170)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.None
        TableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.BackgroundImage = My.Resources.Resources.RENT_NOW_removebg_preview
        TableLayoutPanel2.BackgroundImageLayout = ImageLayout.Stretch
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.81955F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.3634071F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 26.5664158F))
        TableLayoutPanel2.Controls.Add(Label1, 1, 3)
        TableLayoutPanel2.Controls.Add(PictureBox1, 1, 0)
        TableLayoutPanel2.Controls.Add(TextBox2, 1, 4)
        TableLayoutPanel2.Controls.Add(Label8, 1, 1)
        TableLayoutPanel2.Controls.Add(Button1, 1, 5)
        TableLayoutPanel2.Controls.Add(TextBox1, 1, 2)
        TableLayoutPanel2.Location = New Point(555, 108)
        TableLayoutPanel2.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 6
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 40.68768F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.44985676F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 12.0343838F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.309456F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.595988F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 22.6361027F))
        TableLayoutPanel2.Size = New Size(530, 685)
        TableLayoutPanel2.TabIndex = 85
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(202, 425)
        Label1.Margin = New Padding(6, 13, 0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 32)
        Label1.TabIndex = 89
        Label1.Text = "Password"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.None
        TextBox2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(170, 479)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(194, 38)
        TextBox2.TabIndex = 86
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.ImageAlign = ContentAlignment.TopCenter
        Label8.Location = New Point(200, 292)
        Label8.Margin = New Padding(6, 13, 0, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(141, 32)
        Label8.TabIndex = 88
        Label8.Text = "Username"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Button1.FlatStyle = FlatStyle.System
        Button1.Font = New Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(202, 555)
        Button1.Margin = New Padding(6, 27, 0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 60)
        Button1.TabIndex = 96
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.None
        TextBox1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(170, 352)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(194, 38)
        TextBox1.TabIndex = 4
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' LOGIN
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1582, 853)
        Controls.Add(TableLayoutPanel2)
        Margin = New Padding(3, 4, 3, 4)
        Name = "LOGIN"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
End Class
