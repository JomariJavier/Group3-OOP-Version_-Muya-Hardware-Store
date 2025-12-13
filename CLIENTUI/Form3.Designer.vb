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
        Label26 = New Label()
        Label4 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel6 = New TableLayoutPanel()
        Label7 = New Label()
        dtReturn = New DateTimePicker()
        dtBorrow = New DateTimePicker()
        Label13 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        txtTotalPrice = New Label()
        Label3 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        dgvConfirm = New DataGridView()
        ColName = New DataGridViewTextBoxColumn()
        colPrice = New DataGridViewTextBoxColumn()
        colQty = New DataGridViewTextBoxColumn()
        Label2 = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        Button2 = New Button()
        btnConfirm = New Button()
        TableLayoutPanel14 = New TableLayoutPanel()
        PictureBox5 = New PictureBox()
        Label8 = New Label()
        TableLayoutPanel12 = New TableLayoutPanel()
        Logout = New Button()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(dgvConfirm, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel14.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel12.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label26
        ' 
        Label26.Anchor = AnchorStyles.Top
        Label26.AutoSize = True
        Label26.BackColor = Color.Transparent
        Label26.Font = New Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = Color.White
        Label26.Location = New Point(373, 0)
        Label26.Margin = New Padding(0)
        Label26.Name = "Label26"
        Label26.Size = New Size(447, 54)
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
        Label4.Location = New Point(417, 54)
        Label4.Margin = New Padding(0)
        Label4.Name = "Label4"
        Label4.Size = New Size(359, 24)
        Label4.TabIndex = 68
        Label4.Text = "Please Confirm if your Tool is correct"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Controls.Add(Label26, 0, 0)
        TableLayoutPanel2.Controls.Add(Label4, 0, 1)
        TableLayoutPanel2.Location = New Point(355, 148)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 68.35443F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 31.6455688F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 15F))
        TableLayoutPanel2.Size = New Size(1193, 79)
        TableLayoutPanel2.TabIndex = 74
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
        TableLayoutPanel6.Location = New Point(139, 91)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 4
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 22.0779228F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 16.8831177F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 21.6450214F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 39.39394F))
        TableLayoutPanel6.Size = New Size(355, 197)
        TableLayoutPanel6.TabIndex = 78
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Black", 15.75F, FontStyle.Bold)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(100, 15)
        Label7.Margin = New Padding(0, 15, 0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(155, 28)
        Label7.TabIndex = 70
        Label7.Text = "Date of Rent"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dtReturn
        ' 
        dtReturn.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtReturn.Cursor = Cursors.Hand
        dtReturn.Font = New Font("Segoe UI", 14.25F)
        dtReturn.Location = New Point(3, 121)
        dtReturn.Name = "dtReturn"
        dtReturn.Size = New Size(349, 33)
        dtReturn.TabIndex = 78
        ' 
        ' dtBorrow
        ' 
        dtBorrow.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtBorrow.Cursor = Cursors.Hand
        dtBorrow.Font = New Font("Segoe UI", 14.25F)
        dtBorrow.Location = New Point(3, 46)
        dtBorrow.Name = "dtBorrow"
        dtBorrow.Size = New Size(349, 33)
        dtBorrow.TabIndex = 77
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.None
        Label13.AutoSize = True
        Label13.Font = New Font("Arial Black", 15.75F, FontStyle.Bold)
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(88, 91)
        Label13.Margin = New Padding(0, 15, 0, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(179, 27)
        Label13.TabIndex = 76
        Label13.Text = "Date of Return"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(772, 18)
        Label1.Margin = New Padding(0, 18, 0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(355, 45)
        Label1.TabIndex = 64
        Label1.Text = "IS THIS CORRECT?"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(316, 299)
        Label5.Margin = New Padding(0)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 18)
        Label5.TabIndex = 68
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(TableLayoutPanel5)
        FlowLayoutPanel2.Location = New Point(1269, 91)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(394, 173)
        FlowLayoutPanel2.TabIndex = 82
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.Anchor = AnchorStyles.None
        TableLayoutPanel5.ColumnCount = 1
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.Controls.Add(txtTotalPrice, 0, 1)
        TableLayoutPanel5.Controls.Add(Label3, 0, 0)
        TableLayoutPanel5.Location = New Point(61, 20)
        TableLayoutPanel5.Margin = New Padding(61, 20, 0, 0)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 3
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Absolute, 39F))
        TableLayoutPanel5.Size = New Size(272, 126)
        TableLayoutPanel5.TabIndex = 77
        ' 
        ' txtTotalPrice
        ' 
        txtTotalPrice.Anchor = AnchorStyles.Top
        txtTotalPrice.AutoSize = True
        txtTotalPrice.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTotalPrice.ForeColor = Color.Maroon
        txtTotalPrice.Location = New Point(134, 47)
        txtTotalPrice.Margin = New Padding(0, 4, 3, 0)
        txtTotalPrice.Name = "txtTotalPrice"
        txtTotalPrice.Size = New Size(0, 37)
        txtTotalPrice.TabIndex = 78
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(31, 10)
        Label3.Margin = New Padding(0, 10, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(206, 30)
        Label3.TabIndex = 76
        Label3.Text = "TOTAL PAYMENT"
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
        TableLayoutPanel1.Controls.Add(dgvConfirm, 1, 3)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel2, 2, 3)
        TableLayoutPanel1.Controls.Add(Label5, 0, 5)
        TableLayoutPanel1.Controls.Add(Label2, 1, 1)
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel4, 1, 6)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel6, 0, 3)
        TableLayoutPanel1.Location = New Point(0, 556)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 7
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 76.1904755F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 23.8095226F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 203F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 8F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 27F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 79F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(1901, 406)
        TableLayoutPanel1.TabIndex = 67
        ' 
        ' dgvConfirm
        ' 
        dgvConfirm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvConfirm.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvConfirm.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvConfirm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvConfirm.Columns.AddRange(New DataGridViewColumn() {ColName, colPrice, colQty})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(16), CByte(46), CByte(80))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvConfirm.DefaultCellStyle = DataGridViewCellStyle2
        dgvConfirm.Dock = DockStyle.Fill
        dgvConfirm.Location = New Point(633, 88)
        dgvConfirm.Margin = New Padding(0)
        dgvConfirm.Name = "dgvConfirm"
        dgvConfirm.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvConfirm.RowHeadersWidth = 51
        dgvConfirm.Size = New Size(633, 203)
        dgvConfirm.TabIndex = 13
        ' 
        ' ColName
        ' 
        ColName.HeaderText = "ITEM"
        ColName.MinimumWidth = 6
        ColName.Name = "ColName"
        ' 
        ' colPrice
        ' 
        colPrice.HeaderText = "PRICE"
        colPrice.MinimumWidth = 6
        colPrice.Name = "colPrice"
        ' 
        ' colQty
        ' 
        colQty.HeaderText = "QUANTITY"
        colQty.MinimumWidth = 6
        colQty.Name = "colQty"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(845, 67)
        Label2.Margin = New Padding(0)
        Label2.Name = "Label2"
        Label2.Size = New Size(209, 19)
        Label2.TabIndex = 65
        Label2.Text = "Note: Valid ID is Required*"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(Button2, 1, 0)
        TableLayoutPanel4.Controls.Add(btnConfirm, 0, 0)
        TableLayoutPanel4.Location = New Point(793, 329)
        TableLayoutPanel4.Margin = New Padding(40, 3, 3, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 52F))
        TableLayoutPanel4.Size = New Size(350, 52)
        TableLayoutPanel4.TabIndex = 86
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top
        Button2.BackColor = Color.White
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Arial Black", 14.25F, FontStyle.Bold)
        Button2.ForeColor = Color.FromArgb(CByte(12), CByte(43), CByte(78))
        Button2.Location = New Point(202, 0)
        Button2.Margin = New Padding(0)
        Button2.Name = "Button2"
        Button2.Size = New Size(121, 52)
        Button2.TabIndex = 78
        Button2.Text = "CANCEL"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnConfirm
        ' 
        btnConfirm.Anchor = AnchorStyles.Top
        btnConfirm.BackColor = Color.White
        btnConfirm.Cursor = Cursors.Hand
        btnConfirm.Font = New Font("Arial Black", 14.25F, FontStyle.Bold)
        btnConfirm.ForeColor = Color.FromArgb(CByte(12), CByte(43), CByte(78))
        btnConfirm.Location = New Point(27, 0)
        btnConfirm.Margin = New Padding(0)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(121, 52)
        btnConfirm.TabIndex = 79
        btnConfirm.Text = "CONFIRM"
        btnConfirm.UseVisualStyleBackColor = False
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
        TableLayoutPanel14.Size = New Size(1905, 142)
        TableLayoutPanel14.TabIndex = 92
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
        Label8.Location = New Point(898, 102)
        Label8.Margin = New Padding(3, 2, 3, 2)
        Label8.Name = "Label8"
        Label8.Size = New Size(106, 38)
        Label8.TabIndex = 4
        Label8.Text = "HOME"
        Label8.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TableLayoutPanel12
        ' 
        TableLayoutPanel12.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel12.BackColor = Color.Transparent
        TableLayoutPanel12.ColumnCount = 4
        TableLayoutPanel12.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 39.1485825F))
        TableLayoutPanel12.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 36.39399F))
        TableLayoutPanel12.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.6026707F))
        TableLayoutPanel12.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.6878128F))
        TableLayoutPanel12.Controls.Add(Logout, 3, 0)
        TableLayoutPanel12.Location = New Point(0, 446)
        TableLayoutPanel12.Name = "TableLayoutPanel12"
        TableLayoutPanel12.RowCount = 1
        TableLayoutPanel12.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel12.Size = New Size(1902, 104)
        TableLayoutPanel12.TabIndex = 93
        ' 
        ' Logout
        ' 
        Logout.Anchor = AnchorStyles.Right
        Logout.BackColor = Color.AliceBlue
        Logout.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Logout.Location = New Point(1715, 50)
        Logout.Margin = New Padding(0, 50, 50, 0)
        Logout.Name = "Logout"
        Logout.Size = New Size(137, 54)
        Logout.TabIndex = 5
        Logout.Text = "LOGOUT"
        Logout.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.Resources._576825842_1335610788354022_2752363819616472036_n1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1904, 961)
        Controls.Add(TableLayoutPanel12)
        Controls.Add(TableLayoutPanel14)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        DoubleBuffered = True
        Name = "Form3"
        Text = "Form3"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(dgvConfirm, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel14.ResumeLayout(False)
        TableLayoutPanel14.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel12.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents dtReturn As DateTimePicker
    Friend WithEvents dtBorrow As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents txtTotalPrice As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents dgvConfirm As DataGridView
    Friend WithEvents ColName As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents Logout As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Label2 As Label
End Class
