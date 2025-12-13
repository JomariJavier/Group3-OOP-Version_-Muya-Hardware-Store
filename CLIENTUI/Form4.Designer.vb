<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        PictureBox11 = New PictureBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label5 = New Label()
        TextBox2 = New TextBox()
        Label7 = New Label()
        TextBox3 = New TextBox()
        Label2 = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        Label9 = New Label()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        Label18 = New Label()
        TextBox5 = New TextBox()
        OpenFileDialog1 = New OpenFileDialog()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel7 = New TableLayoutPanel()
        Label16 = New Label()
        Label17 = New Label()
        Label19 = New Label()
        TextBox4 = New TextBox()
        TextBox8 = New TextBox()
        TableLayoutPanel9 = New TableLayoutPanel()
        TableLayoutPanel6 = New TableLayoutPanel()
        Label26 = New Label()
        Label4 = New Label()
        TableLayoutPanel14 = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox5 = New PictureBox()
        Label8 = New Label()
        colQty = New DataGridViewTextBoxColumn()
        colPrice = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        dgvFinal = New DataGridView()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        TableLayoutPanel9.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        TableLayoutPanel14.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvFinal, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(8, 10)
        Label1.Margin = New Padding(0, 10, 3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 15)
        Label1.TabIndex = 71
        Label1.Text = "UPLOAD PHOTO OF RENTER"
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Anchor = AnchorStyles.Top
        PictureBox11.BackColor = Color.White
        PictureBox11.Cursor = Cursors.Hand
        PictureBox11.Location = New Point(8, 38)
        PictureBox11.Margin = New Padding(3, 4, 3, 3)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(184, 141)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 14
        PictureBox11.TabStop = False
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top
        TableLayoutPanel3.ColumnCount = 6
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 18.200407F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 48.4662552F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 131F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 178F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 83F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel3.Controls.Add(Label3, 0, 1)
        TableLayoutPanel3.Controls.Add(TextBox1, 1, 1)
        TableLayoutPanel3.Controls.Add(Label5, 2, 1)
        TableLayoutPanel3.Controls.Add(TextBox2, 3, 1)
        TableLayoutPanel3.Controls.Add(Label7, 4, 1)
        TableLayoutPanel3.Controls.Add(TextBox3, 5, 1)
        TableLayoutPanel3.Controls.Add(Label2, 1, 0)
        TableLayoutPanel3.Location = New Point(119, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 49.35065F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50.64935F))
        TableLayoutPanel3.Size = New Size(962, 76)
        TableLayoutPanel3.TabIndex = 73
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(14, 52)
        Label3.Margin = New Padding(0, 15, 0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 16)
        Label3.TabIndex = 73
        Label3.Text = "First Name"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.Cursor = Cursors.Hand
        TextBox1.Location = New Point(106, 47)
        TextBox1.Margin = New Padding(3, 10, 3, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(182, 23)
        TextBox1.TabIndex = 78
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(399, 52)
        Label5.Margin = New Padding(0, 15, 0, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 16)
        Label5.TabIndex = 74
        Label5.Text = "Middle Name"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox2
        ' 
        TextBox2.Cursor = Cursors.Hand
        TextBox2.Location = New Point(513, 47)
        TextBox2.Margin = New Padding(3, 10, 3, 3)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(172, 23)
        TextBox2.TabIndex = 79
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(689, 49)
        Label7.Margin = New Padding(0, 12, 15, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 16)
        Label7.TabIndex = 75
        Label7.Text = "Surname"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox3
        ' 
        TextBox3.Cursor = Cursors.Hand
        TextBox3.Location = New Point(774, 45)
        TextBox3.Margin = New Padding(3, 8, 3, 3)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(182, 23)
        TextBox3.TabIndex = 80
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(103, 15)
        Label2.Margin = New Padding(0, 15, 105, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 18)
        Label2.TabIndex = 70
        Label2.Text = "Full Name"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top
        TableLayoutPanel4.ColumnCount = 6
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.89041F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 64.10959F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 177F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 212F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 80F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 194F))
        TableLayoutPanel4.Controls.Add(Label9, 1, 0)
        TableLayoutPanel4.Controls.Add(Label10, 0, 1)
        TableLayoutPanel4.Controls.Add(TextBox5, 1, 1)
        TableLayoutPanel4.Controls.Add(Label11, 2, 1)
        TableLayoutPanel4.Controls.Add(TextBox6, 3, 1)
        TableLayoutPanel4.Controls.Add(Label18, 4, 1)
        TableLayoutPanel4.Controls.Add(TextBox7, 5, 1)
        TableLayoutPanel4.Location = New Point(96, 157)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 36.8421059F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 34.2105255F))
        TableLayoutPanel4.Size = New Size(1009, 65)
        TableLayoutPanel4.TabIndex = 74
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(154, 15)
        Label9.Margin = New Padding(0, 15, 94, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(67, 18)
        Label9.TabIndex = 70
        Label9.Text = "Address"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox6
        ' 
        TextBox6.Cursor = Cursors.Hand
        TextBox6.Location = New Point(525, 38)
        TextBox6.Margin = New Padding(3, 5, 3, 3)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(182, 23)
        TextBox6.TabIndex = 81
        ' 
        ' TextBox7
        ' 
        TextBox7.Cursor = Cursors.Hand
        TextBox7.Location = New Point(817, 38)
        TextBox7.Margin = New Padding(3, 5, 3, 3)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(182, 23)
        TextBox7.TabIndex = 82
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(13, 43)
        Label10.Margin = New Padding(0, 10, 0, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(98, 16)
        Label10.TabIndex = 74
        Label10.Text = "Street address"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(400, 43)
        Label11.Margin = New Padding(0, 10, 25, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(42, 16)
        Label11.TabIndex = 75
        Label11.Text = "Block"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Top
        Label18.AutoSize = True
        Label18.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label18.ForeColor = Color.Black
        Label18.Location = New Point(743, 38)
        Label18.Margin = New Padding(0, 5, 35, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(27, 16)
        Label18.TabIndex = 76
        Label18.Text = "Lot"
        Label18.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox5
        ' 
        TextBox5.Cursor = Cursors.Hand
        TextBox5.Location = New Point(127, 38)
        TextBox5.Margin = New Padding(3, 5, 3, 3)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(182, 23)
        TextBox5.TabIndex = 80
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = Color.AliceBlue
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel5, 0, 3)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel4, 0, 2)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 0, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel7, 0, 1)
        TableLayoutPanel1.Location = New Point(0, 452)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 49.3055573F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.6944427F))
        TableLayoutPanel1.Size = New Size(1201, 298)
        TableLayoutPanel1.TabIndex = 78
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.Anchor = AnchorStyles.Top
        TableLayoutPanel7.ColumnCount = 4
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel7.Controls.Add(Label16, 0, 1)
        TableLayoutPanel7.Controls.Add(TextBox4, 1, 1)
        TableLayoutPanel7.Controls.Add(Label17, 2, 1)
        TableLayoutPanel7.Controls.Add(TextBox8, 3, 1)
        TableLayoutPanel7.Controls.Add(Label19, 0, 0)
        TableLayoutPanel7.Location = New Point(200, 85)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 2
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 54.1944847F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 45.8055153F))
        TableLayoutPanel7.Size = New Size(801, 66)
        TableLayoutPanel7.TabIndex = 80
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top
        Label16.AutoSize = True
        Label16.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(50, 45)
        Label16.Margin = New Padding(16, 10, 0, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(115, 16)
        Label16.TabIndex = 74
        Label16.Text = "Mobile Number 1"
        Label16.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Top
        Label17.AutoSize = True
        Label17.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label17.ForeColor = Color.Black
        Label17.Location = New Point(432, 45)
        Label17.Margin = New Padding(5, 10, 25, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(115, 16)
        Label17.TabIndex = 75
        Label17.Text = "Mobile Number 2"
        Label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Top
        Label19.AutoSize = True
        Label19.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.Black
        Label19.Location = New Point(20, 15)
        Label19.Margin = New Padding(0, 15, 94, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(66, 18)
        Label19.TabIndex = 70
        Label19.Text = "Contact"
        Label19.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox4
        ' 
        TextBox4.Cursor = Cursors.Hand
        TextBox4.Location = New Point(203, 40)
        TextBox4.Margin = New Padding(3, 5, 3, 3)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(166, 23)
        TextBox4.TabIndex = 80
        ' 
        ' TextBox8
        ' 
        TextBox8.Cursor = Cursors.Hand
        TextBox8.Location = New Point(603, 40)
        TextBox8.Margin = New Padding(3, 5, 3, 3)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(166, 23)
        TextBox8.TabIndex = 81
        ' 
        ' TableLayoutPanel9
        ' 
        TableLayoutPanel9.Anchor = AnchorStyles.Bottom
        TableLayoutPanel9.BackColor = Color.AliceBlue
        TableLayoutPanel9.ColumnCount = 1
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel9.Controls.Add(Label1, 0, 0)
        TableLayoutPanel9.Controls.Add(PictureBox11, 0, 1)
        TableLayoutPanel9.Location = New Point(496, 259)
        TableLayoutPanel9.Name = "TableLayoutPanel9"
        TableLayoutPanel9.RowCount = 2
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 18.5185184F))
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 81.48148F))
        TableLayoutPanel9.Size = New Size(200, 187)
        TableLayoutPanel9.TabIndex = 81
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.Anchor = AnchorStyles.Top
        TableLayoutPanel6.BackColor = Color.Transparent
        TableLayoutPanel6.ColumnCount = 1
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel6.Controls.Add(Label26, 0, 0)
        TableLayoutPanel6.Controls.Add(Label4, 0, 1)
        TableLayoutPanel6.Location = New Point(1, 131)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 2
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 59.8591537F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 40.1408463F))
        TableLayoutPanel6.Size = New Size(1200, 122)
        TableLayoutPanel6.TabIndex = 73
        ' 
        ' Label26
        ' 
        Label26.Anchor = AnchorStyles.Top
        Label26.AutoSize = True
        Label26.BackColor = Color.Transparent
        Label26.Font = New Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = Color.White
        Label26.ImageAlign = ContentAlignment.TopCenter
        Label26.Location = New Point(304, 0)
        Label26.Margin = New Padding(0)
        Label26.Name = "Label26"
        Label26.Size = New Size(591, 73)
        Label26.TabIndex = 69
        Label26.Text = "RENTING FORM"
        Label26.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Transparent
        Label4.ImageAlign = ContentAlignment.TopCenter
        Label4.Location = New Point(443, 73)
        Label4.Margin = New Padding(0)
        Label4.Name = "Label4"
        Label4.Size = New Size(314, 44)
        Label4.TabIndex = 72
        Label4.Text = "For your Accountability " & vbCrLf & "please fill-up some basic information"
        Label4.TextAlign = ContentAlignment.TopCenter
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
        TableLayoutPanel14.Controls.Add(Label8, 1, 0)
        TableLayoutPanel14.Location = New Point(0, 0)
        TableLayoutPanel14.Name = "TableLayoutPanel14"
        TableLayoutPanel14.RowCount = 1
        TableLayoutPanel14.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel14.Size = New Size(1201, 142)
        TableLayoutPanel14.TabIndex = 95
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.Anchor = AnchorStyles.Top
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(Button2, 1, 0)
        TableLayoutPanel5.Controls.Add(Button1, 0, 0)
        TableLayoutPanel5.Location = New Point(481, 228)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Absolute, 61F))
        TableLayoutPanel5.Size = New Size(239, 61)
        TableLayoutPanel5.TabIndex = 81
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top
        Button2.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(127, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(104, 46)
        Button2.TabIndex = 81
        Button2.Text = "BACK"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(5, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 46)
        Button1.TabIndex = 80
        Button1.Text = "CONFIRM"
        Button1.UseVisualStyleBackColor = True
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
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Bottom
        Label8.AutoSize = True
        Label8.Cursor = Cursors.Hand
        Label8.Font = New Font("Arial Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.ImageAlign = ContentAlignment.TopCenter
        Label8.Location = New Point(547, 104)
        Label8.Margin = New Padding(0)
        Label8.Name = "Label8"
        Label8.Size = New Size(106, 38)
        Label8.TabIndex = 4
        Label8.Text = "HOME"
        Label8.TextAlign = ContentAlignment.TopCenter
        ' 
        ' colQty
        ' 
        colQty.HeaderText = "QUANTITY"
        colQty.MinimumWidth = 6
        colQty.Name = "colQty"
        colQty.Width = 125
        ' 
        ' colPrice
        ' 
        colPrice.HeaderText = "PRICE"
        colPrice.MinimumWidth = 6
        colPrice.Name = "colPrice"
        colPrice.Width = 125
        ' 
        ' colName
        ' 
        colName.HeaderText = "ITEM"
        colName.MinimumWidth = 6
        colName.Name = "colName"
        colName.Width = 125
        ' 
        ' dgvFinal
        ' 
        dgvFinal.AccessibleName = ""
        dgvFinal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        dgvFinal.BackgroundColor = Color.White
        dgvFinal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvFinal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvFinal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFinal.Columns.AddRange(New DataGridViewColumn() {colName, colPrice, colQty})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.BackColor = SystemColors.Window
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(16), CByte(46), CByte(80))
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgvFinal.DefaultCellStyle = DataGridViewCellStyle6
        dgvFinal.Location = New Point(25, 258)
        dgvFinal.Margin = New Padding(3, 2, 3, 2)
        dgvFinal.Name = "dgvFinal"
        dgvFinal.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvFinal.RowHeadersWidth = 51
        dgvFinal.Size = New Size(428, 85)
        dgvFinal.TabIndex = 91
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._576825842_1335610788354022_2752363819616472036_n1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1200, 749)
        Controls.Add(TableLayoutPanel14)
        Controls.Add(dgvFinal)
        Controls.Add(TableLayoutPanel9)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(TableLayoutPanel6)
        DoubleBuffered = True
        Name = "Form4"
        Text = "Form4"
        WindowState = FormWindowState.Maximized
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        TableLayoutPanel9.ResumeLayout(False)
        TableLayoutPanel9.PerformLayout()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        TableLayoutPanel14.ResumeLayout(False)
        TableLayoutPanel14.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvFinal, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents dgvFinal As DataGridView
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
