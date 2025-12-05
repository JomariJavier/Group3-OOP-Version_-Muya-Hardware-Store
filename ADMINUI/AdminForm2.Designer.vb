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
        btnHistory = New Button()
        PictureBox1 = New PictureBox()
        btnBannedList = New Button()
        btnStocks = New Button()
        ViewHistory = New DataGridView()
        Button1 = New Button()
        TableLayoutPanel2.SuspendLayout()
        PnlSidebar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ViewHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(Label7, 0, 0)
        TableLayoutPanel2.Location = New Point(206, 13)
        TableLayoutPanel2.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 89F))
        TableLayoutPanel2.Size = New Size(634, 89)
        TableLayoutPanel2.TabIndex = 98
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
        Label7.Size = New Size(246, 62)
        Label7.TabIndex = 98
        Label7.Text = "HISTORY"
        Label7.TextAlign = ContentAlignment.MiddleCenter
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
        PnlSidebar.Size = New Size(187, 853)
        PnlSidebar.TabIndex = 105
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
        ViewHistory.Location = New Point(206, 109)
        ViewHistory.Name = "ViewHistory"
        ViewHistory.ReadOnly = True
        ViewHistory.RowHeadersWidth = 51
        ViewHistory.RowTemplate.Height = 100
        ViewHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ViewHistory.Size = New Size(1570, 732)
        ViewHistory.TabIndex = 108
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(1399, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(350, 70)
        Button1.TabIndex = 109
        Button1.Text = "REFRESH"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' AdminForm2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1793, 853)
        Controls.Add(Button1)
        Controls.Add(ViewHistory)
        Controls.Add(PnlSidebar)
        Controls.Add(TableLayoutPanel2)
        Margin = New Padding(3, 4, 3, 4)
        Name = "AdminForm2"
        Text = "Form7"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        PnlSidebar.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ViewHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label26 As Label
    Friend WithEvents Label1 As Label
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
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PnlSidebar As Panel
    Friend WithEvents btnHistory As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBannedList As Button
    Friend WithEvents btnStocks As Button
    Friend WithEvents ViewHistory As DataGridView
End Class
