<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm2
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
        TableLayoutPanel2 = New TableLayoutPanel()
        Label7 = New Label()
        PnlSidebar = New Panel()
        Button4 = New Button()
        btnHistory = New Button()
        PictureBox1 = New PictureBox()
        btnBannedList = New Button()
        btnStocks = New Button()
        ViewHistory = New DataGridView()
        LateButton = New Button()
        NotReturnedButton = New Button()
        ChangeStatusButton = New Button()
        Panel1 = New Panel()
        Button1 = New Button()
        FilterBox = New GroupBox()
        Button2 = New Button()
        SearchTextBox = New TextBox()
        TableLayoutPanel2.SuspendLayout()
        PnlSidebar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ViewHistory, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        FilterBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.Controls.Add(Label7, 1, 0)
        TableLayoutPanel2.Location = New Point(170, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(1731, 67)
        TableLayoutPanel2.TabIndex = 98
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label7.Location = New Point(683, 20)
        Label7.Margin = New Padding(0, 20, 0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(361, 47)
        Label7.TabIndex = 98
        Label7.Text = "RENTAL HISTORY"
        Label7.TextAlign = ContentAlignment.MiddleCenter
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
        PnlSidebar.Size = New Size(164, 961)
        PnlSidebar.TabIndex = 105
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
        Button4.TabIndex = 7
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
        ' ViewHistory
        ' 
        ViewHistory.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ViewHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        ViewHistory.DefaultCellStyle = DataGridViewCellStyle1
        ViewHistory.Location = New Point(180, 213)
        ViewHistory.Margin = New Padding(3, 2, 3, 2)
        ViewHistory.MaximumSize = New Size(1712, 817)
        ViewHistory.Name = "ViewHistory"
        ViewHistory.ReadOnly = True
        ViewHistory.RowHeadersWidth = 51
        ViewHistory.RowTemplate.Height = 100
        ViewHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ViewHistory.Size = New Size(1712, 737)
        ViewHistory.TabIndex = 108
        ' 
        ' LateButton
        ' 
        LateButton.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        LateButton.Location = New Point(400, 17)
        LateButton.Name = "LateButton"
        LateButton.Size = New Size(186, 70)
        LateButton.TabIndex = 113
        LateButton.Text = "Show Rentals Past Return Date"
        LateButton.UseVisualStyleBackColor = True
        ' 
        ' NotReturnedButton
        ' 
        NotReturnedButton.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        NotReturnedButton.Location = New Point(208, 17)
        NotReturnedButton.Name = "NotReturnedButton"
        NotReturnedButton.Size = New Size(186, 70)
        NotReturnedButton.TabIndex = 112
        NotReturnedButton.Text = "Show ""Not Returned"""
        NotReturnedButton.UseVisualStyleBackColor = True
        ' 
        ' ChangeStatusButton
        ' 
        ChangeStatusButton.BackColor = Color.Chartreuse
        ChangeStatusButton.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        ChangeStatusButton.Location = New Point(631, 17)
        ChangeStatusButton.Name = "ChangeStatusButton"
        ChangeStatusButton.Size = New Size(203, 70)
        ChangeStatusButton.TabIndex = 110
        ChangeStatusButton.Text = "Change Return Status"
        ChangeStatusButton.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(ChangeStatusButton)
        Panel1.Controls.Add(LateButton)
        Panel1.Controls.Add(NotReturnedButton)
        Panel1.Location = New Point(1046, 89)
        Panel1.MaximumSize = New Size(846, 102)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(846, 102)
        Panel1.TabIndex = 114
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        Button1.Location = New Point(16, 17)
        Button1.Name = "Button1"
        Button1.Size = New Size(186, 70)
        Button1.TabIndex = 114
        Button1.Text = "Show ""Returned"""
        Button1.UseVisualStyleBackColor = True
        ' 
        ' FilterBox
        ' 
        FilterBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        FilterBox.BackColor = SystemColors.GradientInactiveCaption
        FilterBox.Controls.Add(Button2)
        FilterBox.Controls.Add(SearchTextBox)
        FilterBox.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FilterBox.Location = New Point(180, 89)
        FilterBox.MaximumSize = New Size(911, 102)
        FilterBox.Name = "FilterBox"
        FilterBox.Size = New Size(846, 102)
        FilterBox.TabIndex = 115
        FilterBox.TabStop = False
        FilterBox.Text = "SEARCH BY NAME"
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Button2.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        Button2.Location = New Point(709, 17)
        Button2.Name = "Button2"
        Button2.Size = New Size(123, 74)
        Button2.TabIndex = 114
        Button2.Text = "Search"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' SearchTextBox
        ' 
        SearchTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        SearchTextBox.Font = New Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SearchTextBox.Location = New Point(15, 35)
        SearchTextBox.Name = "SearchTextBox"
        SearchTextBox.Size = New Size(674, 44)
        SearchTextBox.TabIndex = 0
        ' 
        ' AdminForm2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1904, 961)
        Controls.Add(FilterBox)
        Controls.Add(PnlSidebar)
        Controls.Add(Panel1)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(ViewHistory)
        Name = "AdminForm2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form7"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        PnlSidebar.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ViewHistory, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        FilterBox.ResumeLayout(False)
        FilterBox.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label26 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PnlSidebar As Panel
    Friend WithEvents btnHistory As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBannedList As Button
    Friend WithEvents btnStocks As Button
    Friend WithEvents ViewHistory As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents NotReturnedButton As Button
    Friend WithEvents ChangeStatusButton As Button
    Friend WithEvents LateButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FilterBox As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents SearchTextBox As TextBox
End Class
