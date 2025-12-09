<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm3
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
        BannedSearchBox = New TextBox()
        Label7 = New Label()
        Label3 = New Label()
        Button2 = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        SearchButton = New Button()
        PnlSidebar = New Panel()
        Button4 = New Button()
        btnHistory = New Button()
        PictureBox1 = New PictureBox()
        btnBannedList = New Button()
        btnStocks = New Button()
        ViewBanned = New DataGridView()
        Button3 = New Button()
        TableLayoutPanel2.SuspendLayout()
        PnlSidebar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ViewBanned, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BannedSearchBox
        ' 
        BannedSearchBox.Anchor = AnchorStyles.None
        BannedSearchBox.BackColor = SystemColors.HighlightText
        BannedSearchBox.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BannedSearchBox.Location = New Point(408, 80)
        BannedSearchBox.MaxLength = 100
        BannedSearchBox.Name = "BannedSearchBox"
        BannedSearchBox.PlaceholderText = "(First Name, ex: Juan)"
        BannedSearchBox.Size = New Size(574, 39)
        BannedSearchBox.TabIndex = 22
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label7.Location = New Point(565, 15)
        Label7.Margin = New Padding(0, 15, 0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(261, 45)
        Label7.TabIndex = 79
        Label7.Text = "BANNED LIST"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label3.Location = New Point(237, 81)
        Label3.Margin = New Padding(0)
        Label3.Name = "Label3"
        Label3.Size = New Size(160, 38)
        Label3.TabIndex = 80
        Label3.Text = "SEARCH :"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.FlatStyle = FlatStyle.System
        Button2.Font = New Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(1140, 74)
        Button2.Margin = New Padding(18, 0, 0, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(117, 52)
        Button2.TabIndex = 82
        Button2.Text = "ADD BAN"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 4
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 28.9540825F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 43.43949F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 9.363057F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 18.21656F))
        TableLayoutPanel2.Controls.Add(Button2, 3, 1)
        TableLayoutPanel2.Controls.Add(Label7, 1, 0)
        TableLayoutPanel2.Controls.Add(BannedSearchBox, 1, 1)
        TableLayoutPanel2.Controls.Add(SearchButton, 2, 1)
        TableLayoutPanel2.Controls.Add(Label3, 0, 1)
        TableLayoutPanel2.Location = New Point(183, 16)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 52F))
        TableLayoutPanel2.Size = New Size(1374, 126)
        TableLayoutPanel2.TabIndex = 100
        ' 
        ' SearchButton
        ' 
        SearchButton.BackColor = Color.White
        SearchButton.FlatStyle = FlatStyle.System
        SearchButton.Font = New Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SearchButton.ForeColor = Color.Red
        SearchButton.Location = New Point(994, 76)
        SearchButton.Margin = New Padding(0, 2, 0, 0)
        SearchButton.Name = "SearchButton"
        SearchButton.Size = New Size(128, 50)
        SearchButton.TabIndex = 83
        SearchButton.Text = "SEARCH"
        SearchButton.UseVisualStyleBackColor = False
        ' 
        ' PnlSidebar
        ' 
        PnlSidebar.BackColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        PnlSidebar.Controls.Add(Button4)
        PnlSidebar.Controls.Add(btnHistory)
        PnlSidebar.Controls.Add(PictureBox1)
        PnlSidebar.Controls.Add(btnBannedList)
        PnlSidebar.Controls.Add(btnStocks)
        PnlSidebar.Dock = DockStyle.Left
        PnlSidebar.ForeColor = Color.White
        PnlSidebar.Location = New Point(0, 0)
        PnlSidebar.Name = "PnlSidebar"
        PnlSidebar.Size = New Size(164, 640)
        PnlSidebar.TabIndex = 106
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top
        Button4.BackColor = Color.Transparent
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Button4.ForeColor = Color.White
        Button4.Image = My.Resources.Resources.toppng_com_login_log____imresizer
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(12, 319)
        Button4.Name = "Button4"
        Button4.Size = New Size(139, 47)
        Button4.TabIndex = 8
        Button4.Text = "Log Out"
        Button4.TextAlign = ContentAlignment.MiddleRight
        Button4.UseMnemonic = False
        Button4.UseVisualStyleBackColor = False
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
        ' ViewBanned
        ' 
        ViewBanned.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ViewBanned.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ViewBanned.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        ViewBanned.DefaultCellStyle = DataGridViewCellStyle1
        ViewBanned.Location = New Point(183, 204)
        ViewBanned.Margin = New Padding(3, 2, 3, 2)
        ViewBanned.Name = "ViewBanned"
        ViewBanned.ReadOnly = True
        ViewBanned.RowHeadersWidth = 51
        ViewBanned.RowTemplate.Height = 100
        ViewBanned.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ViewBanned.Size = New Size(1374, 427)
        ViewBanned.TabIndex = 109
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.BackColor = Color.Lime
        Button3.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.ActiveCaptionText
        Button3.Location = New Point(1250, 147)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(306, 52)
        Button3.TabIndex = 110
        Button3.Text = "REFRESH"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' AdminForm3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1569, 640)
        Controls.Add(Button3)
        Controls.Add(ViewBanned)
        Controls.Add(PnlSidebar)
        Controls.Add(TableLayoutPanel2)
        Name = "AdminForm3"
        Text = "Form6"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        PnlSidebar.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ViewBanned, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents BannedSearchBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents SearchButton As Button
    Friend WithEvents PnlSidebar As Panel
    Friend WithEvents btnHistory As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBannedList As Button
    Friend WithEvents btnStocks As Button
    Friend WithEvents ViewBanned As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
