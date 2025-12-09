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
        Button2 = New Button()
        btnHistory = New Button()
        PictureBox1 = New PictureBox()
        btnBannedList = New Button()
        btnStocks = New Button()
        TableLayoutPanel5 = New TableLayoutPanel()
        Label7 = New Label()
        Button1 = New Button()
        AddTool = New Button()
        ProductImage1 = New PictureBox()
        Price1 = New Label()
        Label8 = New Label()
        ToolNameBox1 = New TextBox()
        AvailabilityBox1 = New ComboBox()
        Label11 = New Label()
        UpdatePriceBox1 = New TextBox()
        UpdateStocksBox1 = New ComboBox()
        Label1 = New Label()
        Label13 = New Label()
        Label4 = New Label()
        Cancel = New Button()
        Update = New Button()
        Delete = New Button()
        ViewTools = New DataGridView()
        Panel1 = New Panel()
        ToolID = New Label()
        Button3 = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label3 = New Label()
        CurrentStocks = New Label()
        PnlSidebar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel5.SuspendLayout()
        CType(ProductImage1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ViewTools, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PnlSidebar
        ' 
        PnlSidebar.BackColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        PnlSidebar.Controls.Add(Button2)
        PnlSidebar.Controls.Add(btnHistory)
        PnlSidebar.Controls.Add(PictureBox1)
        PnlSidebar.Controls.Add(btnBannedList)
        PnlSidebar.Controls.Add(btnStocks)
        PnlSidebar.Dock = DockStyle.Left
        PnlSidebar.ForeColor = Color.White
        PnlSidebar.Location = New Point(0, 0)
        PnlSidebar.Name = "PnlSidebar"
        PnlSidebar.Size = New Size(164, 1041)
        PnlSidebar.TabIndex = 104
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top
        Button2.BackColor = Color.Transparent
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Image = My.Resources.Resources.toppng_com_login_log____imresizer
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(12, 319)
        Button2.Name = "Button2"
        Button2.Size = New Size(139, 47)
        Button2.TabIndex = 6
        Button2.Text = "Log Out"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseMnemonic = False
        Button2.UseVisualStyleBackColor = False
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
        btnHistory.Location = New Point(12, 213)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(139, 47)
        btnHistory.TabIndex = 5
        btnHistory.Text = "Rent History"
        btnHistory.TextAlign = ContentAlignment.MiddleRight
        btnHistory.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources._578935847_1627970941508389_3020005775530561214_n_removebg_preview
        PictureBox1.Location = New Point(17, 16)
        PictureBox1.Margin = New Padding(25, 9, 0, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(122, 113)
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
        btnBannedList.Location = New Point(12, 266)
        btnBannedList.Name = "btnBannedList"
        btnBannedList.Size = New Size(139, 47)
        btnBannedList.TabIndex = 6
        btnBannedList.Text = "Banned List"
        btnBannedList.TextAlign = ContentAlignment.MiddleRight
        btnBannedList.UseMnemonic = False
        btnBannedList.UseVisualStyleBackColor = False
        ' 
        ' btnStocks
        ' 
        btnStocks.Anchor = AnchorStyles.Right
        btnStocks.BackColor = Color.Transparent
        btnStocks.BackgroundImageLayout = ImageLayout.None
        btnStocks.Cursor = Cursors.Hand
        btnStocks.FlatStyle = FlatStyle.Flat
        btnStocks.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        btnStocks.ForeColor = Color.White
        btnStocks.Image = My.Resources.Resources.in_stock__2_
        btnStocks.ImageAlign = ContentAlignment.MiddleLeft
        btnStocks.Location = New Point(12, 160)
        btnStocks.Name = "btnStocks"
        btnStocks.Size = New Size(139, 47)
        btnStocks.TabIndex = 4
        btnStocks.Text = "Inventory"
        btnStocks.TextAlign = ContentAlignment.MiddleRight
        btnStocks.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.BackColor = Color.Transparent
        TableLayoutPanel5.ColumnCount = 3
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel5.Controls.Add(Label7, 1, 0)
        TableLayoutPanel5.Controls.Add(Button1, 2, 0)
        TableLayoutPanel5.Dock = DockStyle.Top
        TableLayoutPanel5.Location = New Point(164, 0)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.Size = New Size(1740, 67)
        TableLayoutPanel5.TabIndex = 105
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label7.Location = New Point(743, 20)
        Label7.Margin = New Padding(0, 20, 0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(251, 47)
        Label7.TabIndex = 98
        Label7.Text = "INVENTORY"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Right
        Button1.Font = New Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(1429, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(308, 61)
        Button1.TabIndex = 99
        Button1.Text = "CHECK CONNECTION"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' AddTool
        ' 
        AddTool.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        AddTool.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        AddTool.FlatStyle = FlatStyle.System
        AddTool.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        AddTool.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        AddTool.Location = New Point(372, 98)
        AddTool.Margin = New Padding(0)
        AddTool.Name = "AddTool"
        AddTool.Size = New Size(228, 70)
        AddTool.TabIndex = 95
        AddTool.Text = "Add Tool"
        AddTool.UseVisualStyleBackColor = False
        ' 
        ' ProductImage1
        ' 
        ProductImage1.BackColor = Color.White
        ProductImage1.BackgroundImage = CType(resources.GetObject("ProductImage1.BackgroundImage"), Image)
        ProductImage1.BackgroundImageLayout = ImageLayout.Stretch
        ProductImage1.Location = New Point(29, 58)
        ProductImage1.Margin = New Padding(18, 2, 3, 2)
        ProductImage1.Name = "ProductImage1"
        ProductImage1.Size = New Size(320, 318)
        ProductImage1.SizeMode = PictureBoxSizeMode.StretchImage
        ProductImage1.TabIndex = 97
        ProductImage1.TabStop = False
        ' 
        ' Price1
        ' 
        Price1.Anchor = AnchorStyles.Left
        Price1.AutoSize = True
        Price1.BackColor = Color.FloralWhite
        Price1.Font = New Font("Microsoft Sans Serif", 14.25F)
        Price1.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Price1.Location = New Point(208, 219)
        Price1.Margin = New Padding(3, 8, 3, 0)
        Price1.Name = "Price1"
        Price1.Size = New Size(20, 24)
        Price1.TabIndex = 14
        Price1.Text = "#"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Narrow", 15.75F, FontStyle.Bold)
        Label8.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label8.Location = New Point(90, 22)
        Label8.Margin = New Padding(0, 4, 0, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(115, 25)
        Label8.TabIndex = 1
        Label8.Text = "TOOL NAME"
        ' 
        ' ToolNameBox1
        ' 
        ToolNameBox1.Anchor = AnchorStyles.Left
        ToolNameBox1.Font = New Font("Microsoft Sans Serif", 14.25F)
        ToolNameBox1.Location = New Point(212, 18)
        ToolNameBox1.Margin = New Padding(7, 2, 3, 2)
        ToolNameBox1.Name = "ToolNameBox1"
        ToolNameBox1.Size = New Size(285, 29)
        ToolNameBox1.TabIndex = 4
        ' 
        ' AvailabilityBox1
        ' 
        AvailabilityBox1.Anchor = AnchorStyles.Left
        AvailabilityBox1.Font = New Font("Microsoft Sans Serif", 14.25F)
        AvailabilityBox1.FormattingEnabled = True
        AvailabilityBox1.Items.AddRange(New Object() {"AVAILABLE", "NOT AVAILABLE"})
        AvailabilityBox1.Location = New Point(214, 81)
        AvailabilityBox1.Margin = New Padding(9, 2, 3, 2)
        AvailabilityBox1.Name = "AvailabilityBox1"
        AvailabilityBox1.Size = New Size(285, 32)
        AvailabilityBox1.TabIndex = 6
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Font = New Font("Arial Narrow", 15.75F, FontStyle.Bold)
        Label11.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label11.Location = New Point(75, 87)
        Label11.Margin = New Padding(0, 4, 0, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(130, 25)
        Label11.TabIndex = 5
        Label11.Text = "AVAILABILITY"
        ' 
        ' UpdatePriceBox1
        ' 
        UpdatePriceBox1.Anchor = AnchorStyles.Left
        UpdatePriceBox1.Font = New Font("Microsoft Sans Serif", 14.25F)
        UpdatePriceBox1.Location = New Point(212, 148)
        UpdatePriceBox1.Margin = New Padding(7, 2, 3, 2)
        UpdatePriceBox1.Name = "UpdatePriceBox1"
        UpdatePriceBox1.Size = New Size(285, 29)
        UpdatePriceBox1.TabIndex = 12
        ' 
        ' UpdateStocksBox1
        ' 
        UpdateStocksBox1.Anchor = AnchorStyles.Left
        UpdateStocksBox1.Font = New Font("Microsoft Sans Serif", 14.25F)
        UpdateStocksBox1.FormattingEnabled = True
        UpdateStocksBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        UpdateStocksBox1.Location = New Point(214, 276)
        UpdateStocksBox1.Margin = New Padding(9, 2, 3, 2)
        UpdateStocksBox1.Name = "UpdateStocksBox1"
        UpdateStocksBox1.Size = New Size(285, 32)
        UpdateStocksBox1.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 15.75F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label1.Location = New Point(49, 282)
        Label1.Margin = New Padding(0, 4, 0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 25)
        Label1.TabIndex = 9
        Label1.Text = "UPDATE STOCKS"
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Right
        Label13.AutoSize = True
        Label13.Font = New Font("Arial Narrow", 15.75F, FontStyle.Bold)
        Label13.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label13.Location = New Point(68, 152)
        Label13.Margin = New Padding(0, 4, 0, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(137, 25)
        Label13.TabIndex = 13
        Label13.Text = "UPDATE PRICE"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 15.75F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label4.Location = New Point(55, 219)
        Label4.Margin = New Padding(0, 8, 0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(150, 25)
        Label4.TabIndex = 11
        Label4.Text = "CURRENT PRICE"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Cancel
        ' 
        Cancel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Cancel.BackColor = Color.Transparent
        Cancel.FlatStyle = FlatStyle.System
        Cancel.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        Cancel.ForeColor = Color.White
        Cancel.Location = New Point(372, 346)
        Cancel.Margin = New Padding(0)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(228, 70)
        Cancel.TabIndex = 96
        Cancel.Text = "Clear Entries"
        Cancel.UseVisualStyleBackColor = False
        ' 
        ' Update
        ' 
        Update.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Update.BackColor = Color.Transparent
        Update.FlatStyle = FlatStyle.System
        Update.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        Update.ForeColor = Color.White
        Update.Location = New Point(372, 179)
        Update.Margin = New Padding(0)
        Update.Name = "Update"
        Update.Size = New Size(228, 70)
        Update.TabIndex = 113
        Update.Text = "Update"
        Update.UseVisualStyleBackColor = False
        ' 
        ' Delete
        ' 
        Delete.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Delete.BackColor = Color.Transparent
        Delete.FlatStyle = FlatStyle.System
        Delete.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        Delete.ForeColor = Color.White
        Delete.Location = New Point(372, 264)
        Delete.Margin = New Padding(0)
        Delete.Name = "Delete"
        Delete.Size = New Size(228, 70)
        Delete.TabIndex = 114
        Delete.Text = "Delete Tool"
        Delete.UseVisualStyleBackColor = False
        ' 
        ' ViewTools
        ' 
        ViewTools.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
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
        ViewTools.Location = New Point(846, 87)
        ViewTools.Margin = New Padding(3, 2, 3, 2)
        ViewTools.Name = "ViewTools"
        ViewTools.ReadOnly = True
        ViewTools.RowHeadersWidth = 51
        ViewTools.RowTemplate.Height = 100
        ViewTools.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ViewTools.Size = New Size(1046, 943)
        ViewTools.TabIndex = 107
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(ToolID)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Controls.Add(ProductImage1)
        Panel1.Controls.Add(Cancel)
        Panel1.Controls.Add(AddTool)
        Panel1.Controls.Add(Update)
        Panel1.Controls.Add(Delete)
        Panel1.Location = New Point(192, 87)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(632, 943)
        Panel1.TabIndex = 115
        ' 
        ' ToolID
        ' 
        ToolID.AutoSize = True
        ToolID.Location = New Point(167, 387)
        ToolID.Name = "ToolID"
        ToolID.Size = New Size(41, 15)
        ToolID.TabIndex = 117
        ToolID.Text = "Label2"
        ToolID.Visible = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button3.FlatStyle = FlatStyle.System
        Button3.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        Button3.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button3.Location = New Point(372, 19)
        Button3.Margin = New Padding(0)
        Button3.Name = "Button3"
        Button3.Size = New Size(228, 70)
        Button3.TabIndex = 116
        Button3.Text = "Show all Tools"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.29412F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 64.70588F))
        TableLayoutPanel1.Controls.Add(Label3, 0, 5)
        TableLayoutPanel1.Controls.Add(Label8, 0, 0)
        TableLayoutPanel1.Controls.Add(Price1, 1, 3)
        TableLayoutPanel1.Controls.Add(UpdateStocksBox1, 1, 4)
        TableLayoutPanel1.Controls.Add(Label1, 0, 4)
        TableLayoutPanel1.Controls.Add(Label11, 0, 1)
        TableLayoutPanel1.Controls.Add(AvailabilityBox1, 1, 1)
        TableLayoutPanel1.Controls.Add(UpdatePriceBox1, 1, 2)
        TableLayoutPanel1.Controls.Add(ToolNameBox1, 1, 0)
        TableLayoutPanel1.Controls.Add(Label4, 0, 3)
        TableLayoutPanel1.Controls.Add(Label13, 0, 2)
        TableLayoutPanel1.Controls.Add(CurrentStocks, 1, 5)
        TableLayoutPanel1.Location = New Point(18, 451)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.Size = New Size(582, 392)
        TableLayoutPanel1.TabIndex = 115
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 15.75F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label3.Location = New Point(36, 348)
        Label3.Margin = New Padding(0, 4, 0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(169, 25)
        Label3.TabIndex = 16
        Label3.Text = "CURRENT STOCKS"
        ' 
        ' CurrentStocks
        ' 
        CurrentStocks.Anchor = AnchorStyles.Left
        CurrentStocks.AutoSize = True
        CurrentStocks.BackColor = Color.FloralWhite
        CurrentStocks.Font = New Font("Microsoft Sans Serif", 14.25F)
        CurrentStocks.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        CurrentStocks.Location = New Point(208, 350)
        CurrentStocks.Margin = New Padding(3, 8, 3, 0)
        CurrentStocks.Name = "CurrentStocks"
        CurrentStocks.Size = New Size(20, 24)
        CurrentStocks.TabIndex = 15
        CurrentStocks.Text = "#"
        ' 
        ' AdminForm1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1904, 1041)
        Controls.Add(Panel1)
        Controls.Add(ViewTools)
        Controls.Add(TableLayoutPanel5)
        Controls.Add(PnlSidebar)
        DoubleBuffered = True
        ForeColor = SystemColors.ControlLightLight
        Margin = New Padding(3, 2, 3, 2)
        Name = "AdminForm1"
        StartPosition = FormStartPosition.WindowsDefaultBounds
        WindowState = FormWindowState.Maximized
        PnlSidebar.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        CType(ProductImage1, ComponentModel.ISupportInitialize).EndInit()
        CType(ViewTools, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PnlSidebar As Panel
    Friend WithEvents btnBannedList As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnStocks As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents AddTool As Button
    Friend WithEvents ProductImage1 As PictureBox
    Friend WithEvents Price1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ToolNameBox1 As TextBox
    Friend WithEvents AvailabilityBox1 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UpdatePriceBox1 As TextBox
    Friend WithEvents UpdateStocksBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents Update As Button
    Friend WithEvents Delete As Button
    Protected WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Public WithEvents ViewTools As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents CurrentStocks As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ToolID As Label
End Class
