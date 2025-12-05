<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        TableLayoutPanel1 = New TableLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        txtTotalPrice = New Label()
        Label3 = New Label()
        PictureBox11 = New PictureBox()
        Label6 = New Label()
        Label5 = New Label()
        Label12 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        TableLayoutPanel6 = New TableLayoutPanel()
        Label7 = New Label()
        dtReturn = New DateTimePicker()
        dtBorrow = New DateTimePicker()
        Label13 = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        Button2 = New Button()
        btnConfirm = New Button()
        Label26 = New Label()
        Label4 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        PictureBox2 = New PictureBox()
        Label8 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        dgvConfirm = New DataGridView()
        colName = New DataGridViewTextBoxColumn()
        colPrice = New DataGridViewTextBoxColumn()
        colQty = New DataGridViewTextBoxColumn()
        TableLayoutPanel1.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel3.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        CType(dgvConfirm, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.BackColor = Color.AliceBlue
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33334F))
        TableLayoutPanel1.Controls.Add(dgvConfirm, 0, 0)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel2, 2, 3)
        TableLayoutPanel1.Controls.Add(PictureBox11, 1, 3)
        TableLayoutPanel1.Controls.Add(Label6, 1, 4)
        TableLayoutPanel1.Controls.Add(Label5, 0, 5)
        TableLayoutPanel1.Controls.Add(Label12, 1, 5)
        TableLayoutPanel1.Controls.Add(Label2, 1, 1)
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel3, 0, 3)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel4, 1, 6)
        TableLayoutPanel1.Location = New Point(0, 433)
        TableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 8
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 76.1904755F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 23.8095245F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 250F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 35F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 36F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 105F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 113F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 19F))
        TableLayoutPanel1.Size = New Size(1710, 712)
        TableLayoutPanel1.TabIndex = 67
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(TableLayoutPanel5)
        FlowLayoutPanel2.Location = New Point(1142, 176)
        FlowLayoutPanel2.Margin = New Padding(3, 4, 3, 4)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(565, 242)
        FlowLayoutPanel2.TabIndex = 82
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.Anchor = AnchorStyles.None
        TableLayoutPanel5.ColumnCount = 1
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 23F))
        TableLayoutPanel5.Controls.Add(txtTotalPrice, 0, 1)
        TableLayoutPanel5.Controls.Add(Label3, 0, 0)
        TableLayoutPanel5.Location = New Point(0, 67)
        TableLayoutPanel5.Margin = New Padding(0, 67, 3, 4)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 3
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Absolute, 52F))
        TableLayoutPanel5.Size = New Size(311, 137)
        TableLayoutPanel5.TabIndex = 77
        ' 
        ' txtTotalPrice
        ' 
        txtTotalPrice.Anchor = AnchorStyles.Top
        txtTotalPrice.AutoSize = True
        txtTotalPrice.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTotalPrice.ForeColor = Color.Maroon
        txtTotalPrice.Location = New Point(121, 47)
        txtTotalPrice.Margin = New Padding(0, 5, 3, 0)
        txtTotalPrice.Name = "txtTotalPrice"
        txtTotalPrice.Size = New Size(65, 27)
        txtTotalPrice.TabIndex = 78
        txtTotalPrice.Text = "P100"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(84, 13)
        Label3.Margin = New Padding(0, 13, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 19)
        Label3.TabIndex = 76
        Label3.Text = "TOTAL PAYMENT"
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Anchor = AnchorStyles.Top
        PictureBox11.Image = My.Resources.Resources.wood_cutting_machine_500x500_removebg_preview
        PictureBox11.Location = New Point(751, 192)
        PictureBox11.Margin = New Padding(17, 20, 3, 4)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(219, 225)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 14
        PictureBox11.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.MidnightBlue
        Label6.Location = New Point(753, 422)
        Label6.Margin = New Padding(21, 0, 3, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(219, 22)
        Label6.TabIndex = 69
        Label6.Text = "Wood Cutting Machine"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(284, 457)
        Label5.Margin = New Padding(0)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 24)
        Label5.TabIndex = 68
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(782, 457)
        Label12.Margin = New Padding(21, 0, 3, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(161, 27)
        Label12.TabIndex = 70
        Label12.Text = "P100 - per day"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(746, 131)
        Label2.Margin = New Padding(0)
        Label2.Name = "Label2"
        Label2.Size = New Size(216, 19)
        Label2.TabIndex = 65
        Label2.Text = "Note: Valid ID is Required*"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(703, 24)
        Label1.Margin = New Padding(0, 24, 0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 38)
        Label1.TabIndex = 64
        Label1.Text = "IS THIS CORRECT?"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Controls.Add(TableLayoutPanel6)
        FlowLayoutPanel3.Location = New Point(3, 176)
        FlowLayoutPanel3.Margin = New Padding(3, 4, 3, 4)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(562, 242)
        FlowLayoutPanel3.TabIndex = 85
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.Anchor = AnchorStyles.None
        TableLayoutPanel6.AutoSize = True
        TableLayoutPanel6.ColumnCount = 1
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel6.Controls.Add(Label7, 0, 0)
        TableLayoutPanel6.Controls.Add(dtReturn, 0, 3)
        TableLayoutPanel6.Controls.Add(dtBorrow, 0, 1)
        TableLayoutPanel6.Controls.Add(Label13, 0, 2)
        TableLayoutPanel6.Location = New Point(320, 4)
        TableLayoutPanel6.Margin = New Padding(320, 4, 3, 4)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 4
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 17.560976F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 21.95122F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 17.560976F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 42.92683F))
        TableLayoutPanel6.Size = New Size(235, 251)
        TableLayoutPanel6.TabIndex = 78
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(54, 20)
        Label7.Margin = New Padding(0, 20, 0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(127, 24)
        Label7.TabIndex = 70
        Label7.Text = "Date of Rent"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dtReturn
        ' 
        dtReturn.Cursor = Cursors.Hand
        dtReturn.Location = New Point(3, 163)
        dtReturn.Margin = New Padding(3, 20, 3, 4)
        dtReturn.Name = "dtReturn"
        dtReturn.Size = New Size(226, 27)
        dtReturn.TabIndex = 78
        ' 
        ' dtBorrow
        ' 
        dtBorrow.Cursor = Cursors.Hand
        dtBorrow.Location = New Point(3, 64)
        dtBorrow.Margin = New Padding(3, 20, 3, 4)
        dtBorrow.Name = "dtBorrow"
        dtBorrow.Size = New Size(229, 27)
        dtBorrow.TabIndex = 77
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top
        Label13.AutoSize = True
        Label13.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(44, 119)
        Label13.Margin = New Padding(0, 20, 0, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(147, 24)
        Label13.TabIndex = 76
        Label13.Text = "Date of Return"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(Button2, 1, 0)
        TableLayoutPanel4.Controls.Add(btnConfirm, 0, 0)
        TableLayoutPanel4.Location = New Point(712, 497)
        TableLayoutPanel4.Margin = New Padding(46, 4, 3, 4)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 69F))
        TableLayoutPanel4.Size = New Size(327, 69)
        TableLayoutPanel4.TabIndex = 86
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top
        Button2.BackColor = Color.White
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Arial Black", 11.25F, FontStyle.Bold)
        Button2.ForeColor = Color.FromArgb(CByte(12), CByte(43), CByte(78))
        Button2.Location = New Point(176, 0)
        Button2.Margin = New Padding(0)
        Button2.Name = "Button2"
        Button2.Size = New Size(138, 69)
        Button2.TabIndex = 78
        Button2.Text = "CANCEL"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnConfirm
        ' 
        btnConfirm.Anchor = AnchorStyles.Top
        btnConfirm.BackColor = Color.White
        btnConfirm.Cursor = Cursors.Hand
        btnConfirm.Font = New Font("Arial Black", 11.25F, FontStyle.Bold)
        btnConfirm.ForeColor = Color.FromArgb(CByte(12), CByte(43), CByte(78))
        btnConfirm.Location = New Point(12, 0)
        btnConfirm.Margin = New Padding(0)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(138, 69)
        btnConfirm.TabIndex = 79
        btnConfirm.Text = "CONFIRM"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' Label26
        ' 
        Label26.Anchor = AnchorStyles.Top
        Label26.AutoSize = True
        Label26.BackColor = Color.Transparent
        Label26.Font = New Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = Color.White
        Label26.Location = New Point(480, 0)
        Label26.Margin = New Padding(0)
        Label26.Name = "Label26"
        Label26.Size = New Size(745, 113)
        Label26.TabIndex = 65
        Label26.Text = "CONFIRMATION"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Black", 12.75F, FontStyle.Bold)
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(620, 113)
        Label4.Margin = New Padding(0)
        Label4.Name = "Label4"
        Label4.Size = New Size(466, 31)
        Label4.TabIndex = 68
        Label4.Text = "Please Confirm if your Tool is correct"
        Label4.TextAlign = ContentAlignment.MiddleCenter
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
        TableLayoutPanel3.Controls.Add(PictureBox2, 0, 0)
        TableLayoutPanel3.Controls.Add(Label8, 1, 0)
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 167F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 167F))
        TableLayoutPanel3.Size = New Size(1710, 167)
        TableLayoutPanel3.TabIndex = 69
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = My.Resources.Resources._578935847_1627970941508389_3020005775530561214_n_removebg_preview
        PictureBox2.Location = New Point(29, 12)
        PictureBox2.Margin = New Padding(29, 12, 0, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(147, 151)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
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
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 23F))
        TableLayoutPanel2.Controls.Add(Label26, 0, 0)
        TableLayoutPanel2.Controls.Add(Label4, 0, 1)
        TableLayoutPanel2.Location = New Point(3, 171)
        TableLayoutPanel2.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 59.8591537F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 40.1408463F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(1706, 189)
        TableLayoutPanel2.TabIndex = 74
        ' 
        ' dgvConfirm
        ' 
        dgvConfirm.AccessibleName = ""
        dgvConfirm.Anchor = AnchorStyles.None
        dgvConfirm.BackgroundColor = Color.White
        dgvConfirm.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvConfirm.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvConfirm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvConfirm.Columns.AddRange(New DataGridViewColumn() {colName, colPrice, colQty})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(16), CByte(46), CByte(80))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvConfirm.DefaultCellStyle = DataGridViewCellStyle2
        dgvConfirm.Location = New Point(22, 12)
        dgvConfirm.Name = "dgvConfirm"
        dgvConfirm.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvConfirm.RowHeadersWidth = 51
        dgvConfirm.Size = New Size(525, 107)
        dgvConfirm.TabIndex = 90
        ' 
        ' colName
        ' 
        colName.HeaderText = "ITEM"
        colName.MinimumWidth = 6
        colName.Name = "colName"
        colName.Width = 125
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
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.Resources._576825842_1335610788354022_2752363819616472036_n1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1710, 1003)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(TableLayoutPanel1)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form3"
        Text = "Form3"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        CType(dgvConfirm, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents txtTotalPrice As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents dtReturn As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents dtBorrow As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dgvConfirm As DataGridView
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
End Class
