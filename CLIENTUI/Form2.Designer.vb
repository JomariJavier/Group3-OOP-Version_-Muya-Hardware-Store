<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnRefresh = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel10 = New TableLayoutPanel()
        Label9 = New Label()
        TableLayoutPanel11 = New TableLayoutPanel()
        Label12 = New Label()
        PictureBox4 = New PictureBox()
        Label14 = New Label()
        Label27 = New Label()
        Label19 = New Label()
        Label7 = New Label()
        TableLayoutPanel9 = New TableLayoutPanel()
        btnRemove3 = New Button()
        btnAdd3 = New Button()
        TableLayoutPanel4 = New TableLayoutPanel()
        Label3 = New Label()
        TableLayoutPanel5 = New TableLayoutPanel()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        Label11 = New Label()
        Label20 = New Label()
        Label17 = New Label()
        Label1 = New Label()
        TableLayoutPanel6 = New TableLayoutPanel()
        btnRemove2 = New Button()
        btnAdd2 = New Button()
        TableLayoutPanel7 = New TableLayoutPanel()
        lblInfo = New Label()
        TableLayoutPanel8 = New TableLayoutPanel()
        Label15 = New Label()
        PictureBox3 = New PictureBox()
        Label5 = New Label()
        TableLayoutPanel13 = New TableLayoutPanel()
        btnAdd1 = New Button()
        btnRemove1 = New Button()
        avail = New Label()
        presyo = New Label()
        Label6 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        Button2 = New Button()
        Button1 = New Button()
        dgvCart = New DataGridView()
        TableLayoutPanel2 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        Label8 = New Label()
        ColName = New DataGridViewTextBoxColumn()
        colPrice = New DataGridViewTextBoxColumn()
        colQty = New DataGridViewTextBoxColumn()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel10.SuspendLayout()
        TableLayoutPanel11.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel9.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel6.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel13.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(dgvCart, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.None
        btnRefresh.BackColor = Color.AliceBlue
        btnRefresh.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.FromArgb(CByte(16), CByte(46), CByte(80))
        btnRefresh.Location = New Point(1577, 240)
        btnRefresh.Margin = New Padding(3, 4, 3, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(119, 61)
        btnRefresh.TabIndex = 81
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = Color.AliceBlue
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel10, 2, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel4, 1, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel7, 0, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 1, 1)
        TableLayoutPanel1.Location = New Point(0, 308)
        TableLayoutPanel1.Margin = New Padding(2, 3, 2, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 88.55508F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.4449215F))
        TableLayoutPanel1.Size = New Size(1710, 699)
        TableLayoutPanel1.TabIndex = 12
        ' 
        ' TableLayoutPanel10
        ' 
        TableLayoutPanel10.ColumnCount = 1
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.Controls.Add(Label9, 0, 0)
        TableLayoutPanel10.Controls.Add(TableLayoutPanel11, 0, 1)
        TableLayoutPanel10.Controls.Add(Label27, 0, 2)
        TableLayoutPanel10.Controls.Add(Label19, 0, 3)
        TableLayoutPanel10.Controls.Add(Label7, 0, 4)
        TableLayoutPanel10.Controls.Add(TableLayoutPanel9, 0, 5)
        TableLayoutPanel10.Dock = DockStyle.Fill
        TableLayoutPanel10.Location = New Point(1141, 3)
        TableLayoutPanel10.Name = "TableLayoutPanel10"
        TableLayoutPanel10.RowCount = 6
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Absolute, 340F))
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Absolute, 32F))
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Absolute, 41F))
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Absolute, 32F))
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Absolute, 83F))
        TableLayoutPanel10.Size = New Size(566, 613)
        TableLayoutPanel10.TabIndex = 85
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Black", 11.25F, FontStyle.Bold)
        Label9.Location = New Point(213, 29)
        Label9.Name = "Label9"
        Label9.Size = New Size(139, 27)
        Label9.TabIndex = 1
        Label9.Text = "TOOL NAME"
        ' 
        ' TableLayoutPanel11
        ' 
        TableLayoutPanel11.ColumnCount = 1
        TableLayoutPanel11.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel11.Controls.Add(Label12, 0, 1)
        TableLayoutPanel11.Controls.Add(PictureBox4, 0, 0)
        TableLayoutPanel11.Controls.Add(Label14, 0, 2)
        TableLayoutPanel11.Dock = DockStyle.Fill
        TableLayoutPanel11.Location = New Point(3, 88)
        TableLayoutPanel11.Name = "TableLayoutPanel11"
        TableLayoutPanel11.RowCount = 3
        TableLayoutPanel11.RowStyles.Add(New RowStyle(SizeType.Percent, 78.57143F))
        TableLayoutPanel11.RowStyles.Add(New RowStyle(SizeType.Absolute, 45F))
        TableLayoutPanel11.RowStyles.Add(New RowStyle(SizeType.Percent, 21.4285717F))
        TableLayoutPanel11.Size = New Size(560, 334)
        TableLayoutPanel11.TabIndex = 4
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label12.Location = New Point(243, 240)
        Label12.Name = "Label12"
        Label12.Size = New Size(73, 19)
        Label12.TabIndex = 4
        Label12.Text = "STOCK:"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.None
        PictureBox4.Location = New Point(188, 25)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(184, 177)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.None
        Label14.AutoSize = True
        Label14.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label14.Location = New Point(269, 291)
        Label14.Name = "Label14"
        Label14.Size = New Size(21, 24)
        Label14.TabIndex = 3
        Label14.Text = "1"
        ' 
        ' Label27
        ' 
        Label27.Anchor = AnchorStyles.None
        Label27.AutoSize = True
        Label27.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label27.Location = New Point(225, 431)
        Label27.Name = "Label27"
        Label27.Size = New Size(115, 19)
        Label27.TabIndex = 84
        Label27.Text = "AVAILABILITY"
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.None
        Label19.AutoSize = True
        Label19.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label19.Location = New Point(216, 468)
        Label19.Name = "Label19"
        Label19.Size = New Size(134, 19)
        Label19.TabIndex = 2
        Label19.Text = "PRICE PER DAY"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(272, 502)
        Label7.Name = "Label7"
        Label7.Size = New Size(21, 24)
        Label7.TabIndex = 8
        Label7.Text = "0"
        ' 
        ' TableLayoutPanel9
        ' 
        TableLayoutPanel9.ColumnCount = 2
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.Controls.Add(btnRemove3, 1, 0)
        TableLayoutPanel9.Controls.Add(btnAdd3, 0, 0)
        TableLayoutPanel9.Location = New Point(3, 533)
        TableLayoutPanel9.Name = "TableLayoutPanel9"
        TableLayoutPanel9.RowCount = 1
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.Size = New Size(560, 77)
        TableLayoutPanel9.TabIndex = 85
        ' 
        ' btnRemove3
        ' 
        btnRemove3.Anchor = AnchorStyles.None
        btnRemove3.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        btnRemove3.Location = New Point(367, 14)
        btnRemove3.Name = "btnRemove3"
        btnRemove3.Size = New Size(106, 48)
        btnRemove3.TabIndex = 0
        btnRemove3.Text = "REMOVE"
        btnRemove3.UseVisualStyleBackColor = True
        ' 
        ' btnAdd3
        ' 
        btnAdd3.Anchor = AnchorStyles.None
        btnAdd3.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        btnAdd3.Location = New Point(87, 14)
        btnAdd3.Name = "btnAdd3"
        btnAdd3.Size = New Size(106, 48)
        btnAdd3.TabIndex = 81
        btnAdd3.Text = "ADD"
        btnAdd3.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(Label3, 0, 0)
        TableLayoutPanel4.Controls.Add(TableLayoutPanel5, 0, 1)
        TableLayoutPanel4.Controls.Add(Label20, 0, 2)
        TableLayoutPanel4.Controls.Add(Label17, 0, 3)
        TableLayoutPanel4.Controls.Add(Label1, 0, 4)
        TableLayoutPanel4.Controls.Add(TableLayoutPanel6, 0, 5)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        TableLayoutPanel4.Location = New Point(572, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 6
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 340F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 33F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 41F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 32F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 83F))
        TableLayoutPanel4.Size = New Size(563, 613)
        TableLayoutPanel4.TabIndex = 84
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Black", 11.25F, FontStyle.Bold)
        Label3.Location = New Point(212, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 27)
        Label3.TabIndex = 1
        Label3.Text = "TOOL NAME"
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 1
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(Label4, 0, 1)
        TableLayoutPanel5.Controls.Add(PictureBox2, 0, 0)
        TableLayoutPanel5.Controls.Add(Label11, 0, 2)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(3, 87)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 3
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 78.57143F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Absolute, 43F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 21.4285717F))
        TableLayoutPanel5.Size = New Size(557, 334)
        TableLayoutPanel5.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(242, 240)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 19)
        Label4.TabIndex = 4
        Label4.Text = "STOCK:"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Location = New Point(184, 24)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(189, 179)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label11.Location = New Point(268, 290)
        Label11.Name = "Label11"
        Label11.Size = New Size(21, 24)
        Label11.TabIndex = 3
        Label11.Text = "1"
        ' 
        ' Label20
        ' 
        Label20.Anchor = AnchorStyles.None
        Label20.AutoSize = True
        Label20.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label20.Location = New Point(224, 431)
        Label20.Name = "Label20"
        Label20.Size = New Size(115, 19)
        Label20.TabIndex = 84
        Label20.Text = "AVAILABILITY"
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.None
        Label17.AutoSize = True
        Label17.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label17.Location = New Point(209, 468)
        Label17.Name = "Label17"
        Label17.Size = New Size(145, 19)
        Label17.TabIndex = 2
        Label17.Text = "PRICE PER DAY :"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(271, 502)
        Label1.Name = "Label1"
        Label1.Size = New Size(21, 24)
        Label1.TabIndex = 8
        Label1.Text = "0"
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Controls.Add(btnRemove2, 1, 0)
        TableLayoutPanel6.Controls.Add(btnAdd2, 0, 0)
        TableLayoutPanel6.Location = New Point(3, 533)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 1
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Size = New Size(557, 77)
        TableLayoutPanel6.TabIndex = 85
        ' 
        ' btnRemove2
        ' 
        btnRemove2.Anchor = AnchorStyles.None
        btnRemove2.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        btnRemove2.Location = New Point(364, 14)
        btnRemove2.Name = "btnRemove2"
        btnRemove2.Size = New Size(106, 48)
        btnRemove2.TabIndex = 0
        btnRemove2.Text = "REMOVE"
        btnRemove2.UseVisualStyleBackColor = True
        ' 
        ' btnAdd2
        ' 
        btnAdd2.Anchor = AnchorStyles.None
        btnAdd2.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        btnAdd2.Location = New Point(86, 14)
        btnAdd2.Name = "btnAdd2"
        btnAdd2.Size = New Size(106, 48)
        btnAdd2.TabIndex = 81
        btnAdd2.Text = "ADD"
        btnAdd2.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 1
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Controls.Add(lblInfo, 0, 0)
        TableLayoutPanel7.Controls.Add(TableLayoutPanel8, 0, 1)
        TableLayoutPanel7.Controls.Add(TableLayoutPanel13, 0, 5)
        TableLayoutPanel7.Controls.Add(avail, 0, 2)
        TableLayoutPanel7.Controls.Add(presyo, 0, 4)
        TableLayoutPanel7.Controls.Add(Label6, 0, 3)
        TableLayoutPanel7.Dock = DockStyle.Fill
        TableLayoutPanel7.Location = New Point(3, 3)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 6
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Absolute, 339F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Absolute, 35F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Absolute, 32F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Absolute, 83F))
        TableLayoutPanel7.Size = New Size(563, 613)
        TableLayoutPanel7.TabIndex = 81
        ' 
        ' lblInfo
        ' 
        lblInfo.Anchor = AnchorStyles.None
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Arial Black", 11.25F, FontStyle.Bold)
        lblInfo.Location = New Point(212, 28)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(139, 27)
        lblInfo.TabIndex = 1
        lblInfo.Text = "TOOL NAME"
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.ColumnCount = 1
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Controls.Add(Label15, 0, 1)
        TableLayoutPanel8.Controls.Add(PictureBox3, 0, 0)
        TableLayoutPanel8.Controls.Add(Label5, 0, 2)
        TableLayoutPanel8.Dock = DockStyle.Fill
        TableLayoutPanel8.Location = New Point(3, 87)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 3
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 78.57143F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Absolute, 44F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 21.4285717F))
        TableLayoutPanel8.Size = New Size(557, 333)
        TableLayoutPanel8.TabIndex = 4
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.None
        Label15.AutoSize = True
        Label15.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label15.Location = New Point(242, 239)
        Label15.Name = "Label15"
        Label15.Size = New Size(73, 19)
        Label15.TabIndex = 4
        Label15.Text = "STOCK:"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(181, 25)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(194, 177)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(268, 290)
        Label5.Name = "Label5"
        Label5.Size = New Size(21, 24)
        Label5.TabIndex = 3
        Label5.Text = "1"
        ' 
        ' TableLayoutPanel13
        ' 
        TableLayoutPanel13.ColumnCount = 2
        TableLayoutPanel13.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel13.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel13.Controls.Add(btnAdd1, 0, 0)
        TableLayoutPanel13.Controls.Add(btnRemove1, 1, 0)
        TableLayoutPanel13.Location = New Point(3, 533)
        TableLayoutPanel13.Name = "TableLayoutPanel13"
        TableLayoutPanel13.RowCount = 1
        TableLayoutPanel13.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel13.Size = New Size(557, 77)
        TableLayoutPanel13.TabIndex = 83
        ' 
        ' btnAdd1
        ' 
        btnAdd1.Anchor = AnchorStyles.None
        btnAdd1.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        btnAdd1.Location = New Point(86, 14)
        btnAdd1.Name = "btnAdd1"
        btnAdd1.Size = New Size(106, 48)
        btnAdd1.TabIndex = 81
        btnAdd1.Text = "ADD"
        btnAdd1.UseVisualStyleBackColor = True
        ' 
        ' btnRemove1
        ' 
        btnRemove1.Anchor = AnchorStyles.None
        btnRemove1.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        btnRemove1.Location = New Point(364, 14)
        btnRemove1.Name = "btnRemove1"
        btnRemove1.Size = New Size(106, 48)
        btnRemove1.TabIndex = 0
        btnRemove1.Text = "REMOVE"
        btnRemove1.UseVisualStyleBackColor = True
        ' 
        ' avail
        ' 
        avail.Anchor = AnchorStyles.None
        avail.AutoSize = True
        avail.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        avail.Location = New Point(224, 431)
        avail.Name = "avail"
        avail.Size = New Size(115, 19)
        avail.TabIndex = 83
        avail.Text = "AVAILABILITY"
        ' 
        ' presyo
        ' 
        presyo.Anchor = AnchorStyles.None
        presyo.AutoSize = True
        presyo.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        presyo.Location = New Point(271, 502)
        presyo.Name = "presyo"
        presyo.Size = New Size(21, 24)
        presyo.TabIndex = 8
        presyo.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(209, 468)
        Label6.Name = "Label6"
        Label6.Size = New Size(145, 19)
        Label6.TabIndex = 2
        Label6.Text = "PRICE PER DAY :"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(Button2, 1, 0)
        TableLayoutPanel3.Controls.Add(Button1, 0, 0)
        TableLayoutPanel3.Location = New Point(717, 623)
        TableLayoutPanel3.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 72F))
        TableLayoutPanel3.Size = New Size(273, 72)
        TableLayoutPanel3.TabIndex = 79
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top
        Button2.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Button2.ForeColor = Color.FromArgb(CByte(16), CByte(46), CByte(80))
        Button2.Location = New Point(145, 4)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 61)
        Button2.TabIndex = 81
        Button2.Text = "BACK"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Button1.ForeColor = Color.FromArgb(CByte(16), CByte(46), CByte(80))
        Button1.Location = New Point(8, 4)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(119, 61)
        Button1.TabIndex = 80
        Button1.Text = "CONFIRM"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' dgvCart
        ' 
        dgvCart.Anchor = AnchorStyles.None
        dgvCart.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCart.Columns.AddRange(New DataGridViewColumn() {ColName, colPrice, colQty})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(16), CByte(46), CByte(80))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvCart.DefaultCellStyle = DataGridViewCellStyle2
        dgvCart.Location = New Point(6, 171)
        dgvCart.Name = "dgvCart"
        dgvCart.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvCart.RowHeadersWidth = 51
        dgvCart.Size = New Size(439, 131)
        dgvCart.TabIndex = 13
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.AutoSize = True
        TableLayoutPanel2.BackColor = Color.FromArgb(CByte(12), CByte(43), CByte(78))
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 44.0508F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 23.930481F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 31.9518719F))
        TableLayoutPanel2.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel2.Controls.Add(Label8, 1, 0)
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 167F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 167F))
        TableLayoutPanel2.Size = New Size(1710, 167)
        TableLayoutPanel2.TabIndex = 82
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources._578935847_1627970941508389_3020005775530561214_n_removebg_preview
        PictureBox1.Location = New Point(29, 12)
        PictureBox1.Margin = New Padding(29, 12, 0, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(147, 151)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Cursor = Cursors.Hand
        Label8.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.ImageAlign = ContentAlignment.TopCenter
        Label8.Location = New Point(799, 107)
        Label8.Margin = New Padding(0, 107, 251, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 24)
        Label8.TabIndex = 4
        Label8.Text = "HOME"
        Label8.TextAlign = ContentAlignment.TopCenter
        ' 
        ' ColName
        ' 
        ColName.HeaderText = "ITEM"
        ColName.MinimumWidth = 6
        ColName.Name = "ColName"
        ColName.Width = 125
        ' 
        ' colPrice
        ' 
        colPrice.HeaderText = "PRICE"
        colPrice.MinimumWidth = 6
        colPrice.Name = "colPrice"
        colPrice.Width = 125
        ' 
        ' colQty
        ' 
        colQty.HeaderText = "QUANTITY"
        colQty.MinimumWidth = 6
        colQty.Name = "colQty"
        colQty.Width = 125
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources._576825842_1335610788354022_2752363819616472036_n1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1710, 1003)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(btnRefresh)
        Controls.Add(dgvCart)
        Controls.Add(TableLayoutPanel1)
        DoubleBuffered = True
        ForeColor = Color.FromArgb(CByte(16), CByte(46), CByte(80))
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form2"
        Text = "Form2"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel10.ResumeLayout(False)
        TableLayoutPanel10.PerformLayout()
        TableLayoutPanel11.ResumeLayout(False)
        TableLayoutPanel11.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel9.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        TableLayoutPanel8.ResumeLayout(False)
        TableLayoutPanel8.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel13.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        CType(dgvCart, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnRemove2 As Button
    Friend WithEvents btnAdd2 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnRemove3 As Button
    Friend WithEvents btnAdd3 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents lblInfo As Label
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents presyo As Label
    Friend WithEvents avail As Label
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents btnAdd1 As Button
    Friend WithEvents btnRemove1 As Button
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents ColName As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
End Class
