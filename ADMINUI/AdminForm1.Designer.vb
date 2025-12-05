<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm1))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        OpenFileDialog1 = New OpenFileDialog()
        PnlSidebar = New Panel()
        btnHistory = New Button()
        PictureBox1 = New PictureBox()
        btnBannedList = New Button()
        btnStocks = New Button()
        TableLayoutPanel5 = New TableLayoutPanel()
        Label7 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        Price3 = New Label()
        Label18 = New Label()
        LabelBox3 = New TextBox()
        AvailabilityBox3 = New ComboBox()
        Label19 = New Label()
        UpdatePriceBox3 = New TextBox()
        CurrentStocks3 = New Label()
        Label22 = New Label()
        UpdateStocksBox3 = New ComboBox()
        Label23 = New Label()
        Label20 = New Label()
        Label17 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Price2 = New Label()
        Label5 = New Label()
        LabelBox2 = New TextBox()
        AvailabilityBox2 = New ComboBox()
        Label6 = New Label()
        UpdatePriceBox2 = New TextBox()
        CurrentStocks2 = New Label()
        Label14 = New Label()
        UpdateStocksBox2 = New ComboBox()
        Label15 = New Label()
        Label3 = New Label()
        Label9 = New Label()
        Enter = New Button()
        ProductImage1 = New PictureBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        Price1 = New Label()
        Label8 = New Label()
        LabelBox1 = New TextBox()
        AvailabilityBox1 = New ComboBox()
        Label11 = New Label()
        UpdatePriceBox1 = New TextBox()
        CurrentStocks1 = New Label()
        Label10 = New Label()
        UpdateStocksBox1 = New ComboBox()
        Label1 = New Label()
        Label13 = New Label()
        Label4 = New Label()
        ProductImage3 = New PictureBox()
        ProductImage2 = New PictureBox()
        Cancel = New Button()
        TableLayoutPanel6 = New TableLayoutPanel()
        Update = New Button()
        Delete = New Button()
        ViewTools = New DataGridView()
        Button1 = New Button()
        PnlSidebar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(ProductImage1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        CType(ProductImage3, ComponentModel.ISupportInitialize).BeginInit()
        CType(ProductImage2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel6.SuspendLayout()
        CType(ViewTools, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PnlSidebar
        ' 
        PnlSidebar.BackColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        PnlSidebar.Controls.Add(btnHistory)
        PnlSidebar.Controls.Add(PictureBox1)
        PnlSidebar.Controls.Add(btnBannedList)
        PnlSidebar.Controls.Add(btnStocks)
        PnlSidebar.Dock = DockStyle.Left
        PnlSidebar.ForeColor = Color.White
        PnlSidebar.Location = New Point(0, 0)
        PnlSidebar.Margin = New Padding(3, 4, 3, 4)
        PnlSidebar.Name = "PnlSidebar"
        PnlSidebar.Size = New Size(187, 1033)
        PnlSidebar.TabIndex = 104
        ' 
        ' btnHistory
        ' 
        btnHistory.BackColor = Color.Transparent
        btnHistory.Cursor = Cursors.Hand
        btnHistory.FlatStyle = FlatStyle.Flat
        btnHistory.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        btnHistory.ForeColor = Color.White
        btnHistory.Image = My.Resources.Resources.file__2_
        btnHistory.ImageAlign = ContentAlignment.MiddleLeft
        btnHistory.Location = New Point(14, 284)
        btnHistory.Margin = New Padding(3, 4, 3, 4)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(159, 63)
        btnHistory.TabIndex = 5
        btnHistory.Text = "History"
        btnHistory.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources._578935847_1627970941508389_3020005775530561214_n_removebg_preview
        PictureBox1.Location = New Point(19, 21)
        PictureBox1.Margin = New Padding(29, 12, 0, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(139, 151)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' btnBannedList
        ' 
        btnBannedList.Anchor = AnchorStyles.Top
        btnBannedList.BackColor = Color.Transparent
        btnBannedList.Cursor = Cursors.Hand
        btnBannedList.FlatStyle = FlatStyle.Flat
        btnBannedList.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        btnBannedList.ForeColor = Color.White
        btnBannedList.Image = My.Resources.Resources.banned__3_
        btnBannedList.ImageAlign = ContentAlignment.MiddleLeft
        btnBannedList.Location = New Point(14, 355)
        btnBannedList.Margin = New Padding(3, 4, 3, 4)
        btnBannedList.Name = "btnBannedList"
        btnBannedList.Size = New Size(159, 63)
        btnBannedList.TabIndex = 6
        btnBannedList.Text = "Banned List"
        btnBannedList.TextAlign = ContentAlignment.MiddleRight
        btnBannedList.UseMnemonic = False
        btnBannedList.UseVisualStyleBackColor = False
        ' 
        ' btnStocks
        ' 
        btnStocks.BackColor = Color.Transparent
        btnStocks.BackgroundImageLayout = ImageLayout.None
        btnStocks.Cursor = Cursors.Hand
        btnStocks.FlatStyle = FlatStyle.Flat
        btnStocks.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        btnStocks.ForeColor = Color.White
        btnStocks.Image = My.Resources.Resources.in_stock__2_
        btnStocks.ImageAlign = ContentAlignment.MiddleLeft
        btnStocks.Location = New Point(14, 213)
        btnStocks.Margin = New Padding(3, 4, 3, 4)
        btnStocks.Name = "btnStocks"
        btnStocks.Size = New Size(159, 63)
        btnStocks.TabIndex = 4
        btnStocks.Text = "Stocks"
        btnStocks.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.BackColor = Color.Transparent
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(Label7, 0, 0)
        TableLayoutPanel5.Location = New Point(193, 0)
        TableLayoutPanel5.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Absolute, 89F))
        TableLayoutPanel5.Size = New Size(1567, 89)
        TableLayoutPanel5.TabIndex = 105
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label7.Location = New Point(0, 27)
        Label7.Margin = New Padding(0, 27, 0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(229, 62)
        Label7.TabIndex = 98
        Label7.Text = "STOCKS"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        TableLayoutPanel3.AutoSize = True
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(Price3, 0, 7)
        TableLayoutPanel3.Controls.Add(Label18, 0, 0)
        TableLayoutPanel3.Controls.Add(LabelBox3, 0, 1)
        TableLayoutPanel3.Controls.Add(AvailabilityBox3, 0, 3)
        TableLayoutPanel3.Controls.Add(Label19, 0, 2)
        TableLayoutPanel3.Controls.Add(UpdatePriceBox3, 0, 5)
        TableLayoutPanel3.Controls.Add(CurrentStocks3, 0, 11)
        TableLayoutPanel3.Controls.Add(Label22, 0, 10)
        TableLayoutPanel3.Controls.Add(UpdateStocksBox3, 0, 9)
        TableLayoutPanel3.Controls.Add(Label23, 0, 8)
        TableLayoutPanel3.Controls.Add(Label20, 0, 6)
        TableLayoutPanel3.Controls.Add(Label17, 0, 4)
        TableLayoutPanel3.Location = New Point(1319, 41)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 12
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.Size = New Size(181, 423)
        TableLayoutPanel3.TabIndex = 112
        ' 
        ' Price3
        ' 
        Price3.Anchor = AnchorStyles.Top
        Price3.AutoSize = True
        Price3.BackColor = Color.FloralWhite
        Price3.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Price3.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Price3.Location = New Point(83, 256)
        Price3.Margin = New Padding(3, 11, 3, 0)
        Price3.Name = "Price3"
        Price3.Size = New Size(14, 16)
        Price3.TabIndex = 14
        Price3.Text = "#"
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Top
        Label18.AutoSize = True
        Label18.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label18.Location = New Point(65, 5)
        Label18.Margin = New Padding(0, 5, 0, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(51, 20)
        Label18.TabIndex = 1
        Label18.Text = "LABEL"
        ' 
        ' LabelBox3
        ' 
        LabelBox3.Location = New Point(8, 38)
        LabelBox3.Margin = New Padding(8, 3, 3, 3)
        LabelBox3.Name = "LabelBox3"
        LabelBox3.Size = New Size(170, 27)
        LabelBox3.TabIndex = 4
        ' 
        ' AvailabilityBox3
        ' 
        AvailabilityBox3.FormattingEnabled = True
        AvailabilityBox3.Items.AddRange(New Object() {"AVAILABLE", "NOT AVAILABLE"})
        AvailabilityBox3.Location = New Point(10, 108)
        AvailabilityBox3.Margin = New Padding(10, 3, 3, 3)
        AvailabilityBox3.Name = "AvailabilityBox3"
        AvailabilityBox3.Size = New Size(163, 28)
        AvailabilityBox3.TabIndex = 6
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Top
        Label19.AutoSize = True
        Label19.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label19.Location = New Point(42, 75)
        Label19.Margin = New Padding(0, 5, 0, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(96, 20)
        Label19.TabIndex = 5
        Label19.Text = "AVAILABILITY"
        ' 
        ' UpdatePriceBox3
        ' 
        UpdatePriceBox3.Location = New Point(8, 178)
        UpdatePriceBox3.Margin = New Padding(8, 3, 3, 3)
        UpdatePriceBox3.Name = "UpdatePriceBox3"
        UpdatePriceBox3.Size = New Size(170, 27)
        UpdatePriceBox3.TabIndex = 12
        ' 
        ' CurrentStocks3
        ' 
        CurrentStocks3.Anchor = AnchorStyles.Top
        CurrentStocks3.AutoSize = True
        CurrentStocks3.BackColor = Color.FloralWhite
        CurrentStocks3.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CurrentStocks3.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        CurrentStocks3.Location = New Point(83, 396)
        CurrentStocks3.Margin = New Padding(3, 11, 3, 0)
        CurrentStocks3.Name = "CurrentStocks3"
        CurrentStocks3.Size = New Size(14, 16)
        CurrentStocks3.TabIndex = 7
        CurrentStocks3.Text = "#"
        ' 
        ' Label22
        ' 
        Label22.Anchor = AnchorStyles.Top
        Label22.AutoSize = True
        Label22.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label22.Location = New Point(28, 361)
        Label22.Margin = New Padding(0, 11, 0, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(125, 20)
        Label22.TabIndex = 3
        Label22.Text = "CURRENT STOCKS"
        Label22.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' UpdateStocksBox3
        ' 
        UpdateStocksBox3.FormattingEnabled = True
        UpdateStocksBox3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        UpdateStocksBox3.Location = New Point(10, 318)
        UpdateStocksBox3.Margin = New Padding(10, 3, 3, 3)
        UpdateStocksBox3.Name = "UpdateStocksBox3"
        UpdateStocksBox3.Size = New Size(163, 28)
        UpdateStocksBox3.TabIndex = 10
        ' 
        ' Label23
        ' 
        Label23.Anchor = AnchorStyles.Top
        Label23.AutoSize = True
        Label23.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label23.Location = New Point(33, 285)
        Label23.Margin = New Padding(0, 5, 0, 0)
        Label23.Name = "Label23"
        Label23.Size = New Size(115, 20)
        Label23.TabIndex = 9
        Label23.Text = "UPDATE STOCKS"
        ' 
        ' Label20
        ' 
        Label20.Anchor = AnchorStyles.Top
        Label20.AutoSize = True
        Label20.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label20.Location = New Point(67, 221)
        Label20.Margin = New Padding(0, 11, 0, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(47, 20)
        Label20.TabIndex = 11
        Label20.Text = "PRICE"
        Label20.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Top
        Label17.AutoSize = True
        Label17.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label17.Location = New Point(35, 145)
        Label17.Margin = New Padding(0, 5, 0, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(110, 20)
        Label17.TabIndex = 13
        Label17.Text = "UPDATED PRICE"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(Price2, 0, 7)
        TableLayoutPanel1.Controls.Add(Label5, 0, 0)
        TableLayoutPanel1.Controls.Add(LabelBox2, 0, 1)
        TableLayoutPanel1.Controls.Add(AvailabilityBox2, 0, 3)
        TableLayoutPanel1.Controls.Add(Label6, 0, 2)
        TableLayoutPanel1.Controls.Add(UpdatePriceBox2, 0, 5)
        TableLayoutPanel1.Controls.Add(CurrentStocks2, 0, 11)
        TableLayoutPanel1.Controls.Add(Label14, 0, 10)
        TableLayoutPanel1.Controls.Add(UpdateStocksBox2, 0, 9)
        TableLayoutPanel1.Controls.Add(Label15, 0, 8)
        TableLayoutPanel1.Controls.Add(Label3, 0, 4)
        TableLayoutPanel1.Controls.Add(Label9, 0, 6)
        TableLayoutPanel1.Location = New Point(805, 41)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 12
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.Size = New Size(181, 423)
        TableLayoutPanel1.TabIndex = 111
        ' 
        ' Price2
        ' 
        Price2.Anchor = AnchorStyles.Top
        Price2.AutoSize = True
        Price2.BackColor = Color.FloralWhite
        Price2.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Price2.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Price2.Location = New Point(83, 256)
        Price2.Margin = New Padding(3, 11, 3, 0)
        Price2.Name = "Price2"
        Price2.Size = New Size(14, 16)
        Price2.TabIndex = 14
        Price2.Text = "#"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label5.Location = New Point(65, 5)
        Label5.Margin = New Padding(0, 5, 0, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 20)
        Label5.TabIndex = 1
        Label5.Text = "LABEL"
        ' 
        ' LabelBox2
        ' 
        LabelBox2.Location = New Point(8, 38)
        LabelBox2.Margin = New Padding(8, 3, 3, 3)
        LabelBox2.Name = "LabelBox2"
        LabelBox2.Size = New Size(170, 27)
        LabelBox2.TabIndex = 4
        ' 
        ' AvailabilityBox2
        ' 
        AvailabilityBox2.FormattingEnabled = True
        AvailabilityBox2.Items.AddRange(New Object() {"AVAILABLE", "NOT AVAILABLE"})
        AvailabilityBox2.Location = New Point(10, 108)
        AvailabilityBox2.Margin = New Padding(10, 3, 3, 3)
        AvailabilityBox2.Name = "AvailabilityBox2"
        AvailabilityBox2.Size = New Size(163, 28)
        AvailabilityBox2.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label6.Location = New Point(42, 75)
        Label6.Margin = New Padding(0, 5, 0, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 20)
        Label6.TabIndex = 5
        Label6.Text = "AVAILABILITY"
        ' 
        ' UpdatePriceBox2
        ' 
        UpdatePriceBox2.Location = New Point(8, 178)
        UpdatePriceBox2.Margin = New Padding(8, 3, 3, 3)
        UpdatePriceBox2.Name = "UpdatePriceBox2"
        UpdatePriceBox2.Size = New Size(170, 27)
        UpdatePriceBox2.TabIndex = 12
        ' 
        ' CurrentStocks2
        ' 
        CurrentStocks2.Anchor = AnchorStyles.Top
        CurrentStocks2.AutoSize = True
        CurrentStocks2.BackColor = Color.FloralWhite
        CurrentStocks2.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CurrentStocks2.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        CurrentStocks2.Location = New Point(83, 396)
        CurrentStocks2.Margin = New Padding(3, 11, 3, 0)
        CurrentStocks2.Name = "CurrentStocks2"
        CurrentStocks2.Size = New Size(14, 16)
        CurrentStocks2.TabIndex = 7
        CurrentStocks2.Text = "#"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top
        Label14.AutoSize = True
        Label14.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label14.Location = New Point(28, 361)
        Label14.Margin = New Padding(0, 11, 0, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(125, 20)
        Label14.TabIndex = 3
        Label14.Text = "CURRENT STOCKS"
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' UpdateStocksBox2
        ' 
        UpdateStocksBox2.FormattingEnabled = True
        UpdateStocksBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        UpdateStocksBox2.Location = New Point(10, 318)
        UpdateStocksBox2.Margin = New Padding(10, 3, 3, 3)
        UpdateStocksBox2.Name = "UpdateStocksBox2"
        UpdateStocksBox2.Size = New Size(163, 28)
        UpdateStocksBox2.TabIndex = 10
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top
        Label15.AutoSize = True
        Label15.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label15.Location = New Point(33, 285)
        Label15.Margin = New Padding(0, 5, 0, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(115, 20)
        Label15.TabIndex = 9
        Label15.Text = "UPDATE STOCKS"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label3.Location = New Point(35, 145)
        Label3.Margin = New Padding(0, 5, 0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 20)
        Label3.TabIndex = 13
        Label3.Text = "UPDATED PRICE"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label9.Location = New Point(67, 221)
        Label9.Margin = New Padding(0, 11, 0, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(47, 20)
        Label9.TabIndex = 11
        Label9.Text = "PRICE"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Enter
        ' 
        Enter.Anchor = AnchorStyles.Top
        Enter.BackColor = Color.Transparent
        Enter.FlatStyle = FlatStyle.System
        Enter.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Enter.ForeColor = Color.White
        Enter.Location = New Point(313, 467)
        Enter.Margin = New Padding(0)
        Enter.Name = "Enter"
        Enter.Size = New Size(142, 53)
        Enter.TabIndex = 95
        Enter.Text = "Enter"
        Enter.UseVisualStyleBackColor = False
        ' 
        ' ProductImage1
        ' 
        ProductImage1.Anchor = AnchorStyles.None
        ProductImage1.BackColor = Color.White
        ProductImage1.BackgroundImage = CType(resources.GetObject("ProductImage1.BackgroundImage"), Image)
        ProductImage1.BackgroundImageLayout = ImageLayout.Stretch
        ProductImage1.Location = New Point(37, 130)
        ProductImage1.Margin = New Padding(21, 3, 3, 3)
        ProductImage1.Name = "ProductImage1"
        ProductImage1.Size = New Size(199, 245)
        ProductImage1.SizeMode = PictureBoxSizeMode.StretchImage
        ProductImage1.TabIndex = 97
        ProductImage1.TabStop = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        TableLayoutPanel2.AutoSize = True
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(Price1, 0, 7)
        TableLayoutPanel2.Controls.Add(Label8, 0, 0)
        TableLayoutPanel2.Controls.Add(LabelBox1, 0, 1)
        TableLayoutPanel2.Controls.Add(AvailabilityBox1, 0, 3)
        TableLayoutPanel2.Controls.Add(Label11, 0, 2)
        TableLayoutPanel2.Controls.Add(UpdatePriceBox1, 0, 5)
        TableLayoutPanel2.Controls.Add(CurrentStocks1, 0, 11)
        TableLayoutPanel2.Controls.Add(Label10, 0, 10)
        TableLayoutPanel2.Controls.Add(UpdateStocksBox1, 0, 9)
        TableLayoutPanel2.Controls.Add(Label1, 0, 8)
        TableLayoutPanel2.Controls.Add(Label13, 0, 4)
        TableLayoutPanel2.Controls.Add(Label4, 0, 6)
        TableLayoutPanel2.Location = New Point(293, 41)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 12
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.Size = New Size(181, 423)
        TableLayoutPanel2.TabIndex = 102
        ' 
        ' Price1
        ' 
        Price1.Anchor = AnchorStyles.Top
        Price1.AutoSize = True
        Price1.BackColor = Color.FloralWhite
        Price1.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Price1.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Price1.Location = New Point(83, 256)
        Price1.Margin = New Padding(3, 11, 3, 0)
        Price1.Name = "Price1"
        Price1.Size = New Size(14, 16)
        Price1.TabIndex = 14
        Price1.Text = "#"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label8.Location = New Point(65, 5)
        Label8.Margin = New Padding(0, 5, 0, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(51, 20)
        Label8.TabIndex = 1
        Label8.Text = "LABEL"
        ' 
        ' LabelBox1
        ' 
        LabelBox1.Location = New Point(8, 38)
        LabelBox1.Margin = New Padding(8, 3, 3, 3)
        LabelBox1.Name = "LabelBox1"
        LabelBox1.Size = New Size(170, 27)
        LabelBox1.TabIndex = 4
        ' 
        ' AvailabilityBox1
        ' 
        AvailabilityBox1.FormattingEnabled = True
        AvailabilityBox1.Items.AddRange(New Object() {"AVAILABLE", "NOT AVAILABLE"})
        AvailabilityBox1.Location = New Point(10, 108)
        AvailabilityBox1.Margin = New Padding(10, 3, 3, 3)
        AvailabilityBox1.Name = "AvailabilityBox1"
        AvailabilityBox1.Size = New Size(163, 28)
        AvailabilityBox1.TabIndex = 6
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label11.Location = New Point(42, 75)
        Label11.Margin = New Padding(0, 5, 0, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(96, 20)
        Label11.TabIndex = 5
        Label11.Text = "AVAILABILITY"
        ' 
        ' UpdatePriceBox1
        ' 
        UpdatePriceBox1.Location = New Point(8, 178)
        UpdatePriceBox1.Margin = New Padding(8, 3, 3, 3)
        UpdatePriceBox1.Name = "UpdatePriceBox1"
        UpdatePriceBox1.Size = New Size(170, 27)
        UpdatePriceBox1.TabIndex = 12
        ' 
        ' CurrentStocks1
        ' 
        CurrentStocks1.Anchor = AnchorStyles.Top
        CurrentStocks1.AutoSize = True
        CurrentStocks1.BackColor = Color.FloralWhite
        CurrentStocks1.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CurrentStocks1.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        CurrentStocks1.Location = New Point(83, 396)
        CurrentStocks1.Margin = New Padding(3, 11, 3, 0)
        CurrentStocks1.Name = "CurrentStocks1"
        CurrentStocks1.Size = New Size(14, 16)
        CurrentStocks1.TabIndex = 7
        CurrentStocks1.Text = "#"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label10.Location = New Point(28, 361)
        Label10.Margin = New Padding(0, 11, 0, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(125, 20)
        Label10.TabIndex = 3
        Label10.Text = "CURRENT STOCKS"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' UpdateStocksBox1
        ' 
        UpdateStocksBox1.FormattingEnabled = True
        UpdateStocksBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        UpdateStocksBox1.Location = New Point(10, 318)
        UpdateStocksBox1.Margin = New Padding(10, 3, 3, 3)
        UpdateStocksBox1.Name = "UpdateStocksBox1"
        UpdateStocksBox1.Size = New Size(163, 28)
        UpdateStocksBox1.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label1.Location = New Point(33, 285)
        Label1.Margin = New Padding(0, 5, 0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 20)
        Label1.TabIndex = 9
        Label1.Text = "UPDATE STOCKS"
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top
        Label13.AutoSize = True
        Label13.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label13.Location = New Point(35, 145)
        Label13.Margin = New Padding(0, 5, 0, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(110, 20)
        Label13.TabIndex = 13
        Label13.Text = "UPDATED PRICE"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label4.Location = New Point(67, 221)
        Label4.Margin = New Padding(0, 11, 0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 20)
        Label4.TabIndex = 11
        Label4.Text = "PRICE"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ProductImage3
        ' 
        ProductImage3.Anchor = AnchorStyles.None
        ProductImage3.BackColor = Color.White
        ProductImage3.BackgroundImage = CType(resources.GetObject("ProductImage3.BackgroundImage"), Image)
        ProductImage3.BackgroundImageLayout = ImageLayout.Stretch
        ProductImage3.Location = New Point(1044, 130)
        ProductImage3.Name = "ProductImage3"
        ProductImage3.Size = New Size(215, 245)
        ProductImage3.SizeMode = PictureBoxSizeMode.StretchImage
        ProductImage3.TabIndex = 110
        ProductImage3.TabStop = False
        ' 
        ' ProductImage2
        ' 
        ProductImage2.Anchor = AnchorStyles.None
        ProductImage2.BackColor = Color.White
        ProductImage2.BackgroundImage = CType(resources.GetObject("ProductImage2.BackgroundImage"), Image)
        ProductImage2.BackgroundImageLayout = ImageLayout.Stretch
        ProductImage2.Location = New Point(532, 130)
        ProductImage2.Name = "ProductImage2"
        ProductImage2.Size = New Size(215, 245)
        ProductImage2.SizeMode = PictureBoxSizeMode.StretchImage
        ProductImage2.TabIndex = 98
        ProductImage2.TabStop = False
        ' 
        ' Cancel
        ' 
        Cancel.Anchor = AnchorStyles.Top
        Cancel.BackColor = Color.Transparent
        Cancel.FlatStyle = FlatStyle.System
        Cancel.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Cancel.ForeColor = Color.White
        Cancel.Location = New Point(1079, 467)
        Cancel.Margin = New Padding(0)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(146, 53)
        Cancel.TabIndex = 96
        Cancel.Text = "Cancel"
        Cancel.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.BackColor = Color.AliceBlue
        TableLayoutPanel6.ColumnCount = 6
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel6.Controls.Add(ProductImage2, 2, 1)
        TableLayoutPanel6.Controls.Add(ProductImage3, 4, 1)
        TableLayoutPanel6.Controls.Add(TableLayoutPanel2, 1, 1)
        TableLayoutPanel6.Controls.Add(ProductImage1, 0, 1)
        TableLayoutPanel6.Controls.Add(TableLayoutPanel1, 3, 1)
        TableLayoutPanel6.Controls.Add(TableLayoutPanel3, 5, 1)
        TableLayoutPanel6.Controls.Add(Enter, 1, 2)
        TableLayoutPanel6.Controls.Add(Update, 2, 2)
        TableLayoutPanel6.Controls.Add(Cancel, 4, 2)
        TableLayoutPanel6.Controls.Add(Delete, 3, 2)
        TableLayoutPanel6.Location = New Point(207, 97)
        TableLayoutPanel6.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 3
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 7.03125F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 77.92969F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 14.84375F))
        TableLayoutPanel6.Size = New Size(1540, 550)
        TableLayoutPanel6.TabIndex = 106
        ' 
        ' Update
        ' 
        Update.Anchor = AnchorStyles.Top
        Update.BackColor = Color.Transparent
        Update.FlatStyle = FlatStyle.System
        Update.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Update.ForeColor = Color.White
        Update.Location = New Point(569, 467)
        Update.Margin = New Padding(0)
        Update.Name = "Update"
        Update.Size = New Size(142, 53)
        Update.TabIndex = 113
        Update.Text = "Update"
        Update.UseVisualStyleBackColor = False
        ' 
        ' Delete
        ' 
        Delete.Anchor = AnchorStyles.Top
        Delete.BackColor = Color.Transparent
        Delete.FlatStyle = FlatStyle.System
        Delete.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Delete.ForeColor = Color.White
        Delete.Location = New Point(825, 467)
        Delete.Margin = New Padding(0)
        Delete.Name = "Delete"
        Delete.Size = New Size(142, 53)
        Delete.TabIndex = 114
        Delete.Text = "Delete"
        Delete.UseVisualStyleBackColor = False
        ' 
        ' ViewTools
        ' 
        ViewTools.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ViewTools.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        ViewTools.DefaultCellStyle = DataGridViewCellStyle1
        ViewTools.Location = New Point(207, 759)
        ViewTools.Name = "ViewTools"
        ViewTools.ReadOnly = True
        ViewTools.RowHeadersWidth = 51
        ViewTools.RowTemplate.Height = 100
        ViewTools.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ViewTools.Size = New Size(1541, 424)
        ViewTools.TabIndex = 107
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(1398, 683)
        Button1.Name = "Button1"
        Button1.Size = New Size(350, 70)
        Button1.TabIndex = 108
        Button1.Text = "REFRESH"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' AdminForm1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1874, 1033)
        Controls.Add(Button1)
        Controls.Add(ViewTools)
        Controls.Add(TableLayoutPanel6)
        Controls.Add(TableLayoutPanel5)
        Controls.Add(PnlSidebar)
        DoubleBuffered = True
        ForeColor = SystemColors.ControlLightLight
        Name = "AdminForm1"
        StartPosition = FormStartPosition.WindowsDefaultBounds
        WindowState = FormWindowState.Maximized
        PnlSidebar.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(ProductImage1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        CType(ProductImage3, ComponentModel.ISupportInitialize).EndInit()
        CType(ProductImage2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        CType(ViewTools, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PnlSidebar As Panel
    Friend WithEvents btnBannedList As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnStocks As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Price3 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents LabelBox3 As TextBox
    Friend WithEvents AvailabilityBox3 As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents UpdatePriceBox3 As TextBox
    Friend WithEvents CurrentStocks3 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents UpdateStocksBox3 As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Price2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelBox2 As TextBox
    Friend WithEvents AvailabilityBox2 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents UpdatePriceBox2 As TextBox
    Friend WithEvents CurrentStocks2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents UpdateStocksBox2 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Enter As Button
    Friend WithEvents ProductImage1 As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Price1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelBox1 As TextBox
    Friend WithEvents AvailabilityBox1 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UpdatePriceBox1 As TextBox
    Friend WithEvents CurrentStocks1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents UpdateStocksBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ProductImage3 As PictureBox
    Friend WithEvents ProductImage2 As PictureBox
    Friend WithEvents Cancel As Button
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Update As Button
    Friend WithEvents Delete As Button
    Friend WithEvents ViewTools As DataGridView
    Friend WithEvents Button1 As Button
    Protected WithEvents PictureBox1 As PictureBox
End Class
