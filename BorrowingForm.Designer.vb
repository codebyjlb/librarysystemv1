<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowingForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BorrowingForm))
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusborrower = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusid = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lstviewBorrowers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuForms = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstviewInventory = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBook = New System.Windows.Forms.TextBox()
        Me.txtSearch2 = New System.Windows.Forms.Button()
        Me.btnBrw = New System.Windows.Forms.Button()
        Me.pnlBorrow = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnComfirm = New System.Windows.Forms.Button()
        Me.btnComPrint = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.txtAcq = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBal = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtYr = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuForms.SuspendLayout()
        Me.pnlBorrow.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(154, 31)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(189, 22)
        Me.txtSearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Borrower ID No."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.statusborrower, Me.statusid})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 434)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(786, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'statusborrower
        '
        Me.statusborrower.Name = "statusborrower"
        Me.statusborrower.Size = New System.Drawing.Size(10, 17)
        Me.statusborrower.Text = " "
        '
        'statusid
        '
        Me.statusid.Name = "statusid"
        Me.statusid.Size = New System.Drawing.Size(10, 17)
        Me.statusid.Text = " "
        '
        'lstviewBorrowers
        '
        Me.lstviewBorrowers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader7, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lstviewBorrowers.FullRowSelect = True
        Me.lstviewBorrowers.Location = New System.Drawing.Point(3, 60)
        Me.lstviewBorrowers.Name = "lstviewBorrowers"
        Me.lstviewBorrowers.Size = New System.Drawing.Size(783, 371)
        Me.lstviewBorrowers.TabIndex = 6
        Me.lstviewBorrowers.UseCompatibleStateImageBehavior = False
        Me.lstviewBorrowers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ID No."
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Borrower Name"
        Me.ColumnHeader2.Width = 148
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Year/Section"
        Me.ColumnHeader3.Width = 160
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Address"
        Me.ColumnHeader4.Width = 186
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Contact No."
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Balance"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(349, 30)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 24)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(106, 26)
        '
        'SelectToolStripMenuItem
        '
        Me.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        Me.SelectToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.SelectToolStripMenuItem.Text = "Select"
        '
        'MenuForms
        '
        Me.MenuForms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuForms.Location = New System.Drawing.Point(0, 0)
        Me.MenuForms.Name = "MenuForms"
        Me.MenuForms.Size = New System.Drawing.Size(786, 24)
        Me.MenuForms.TabIndex = 9
        Me.MenuForms.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = CType(resources.GetObject("CloseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Enter Borrower ID No."
        '
        'lstviewInventory
        '
        Me.lstviewInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15})
        Me.lstviewInventory.FullRowSelect = True
        Me.lstviewInventory.Location = New System.Drawing.Point(3, 233)
        Me.lstviewInventory.Name = "lstviewInventory"
        Me.lstviewInventory.Size = New System.Drawing.Size(783, 165)
        Me.lstviewInventory.TabIndex = 20
        Me.lstviewInventory.UseCompatibleStateImageBehavior = False
        Me.lstviewInventory.View = System.Windows.Forms.View.Details
        Me.lstviewInventory.Visible = False
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Aqcuisition No."
        Me.ColumnHeader8.Width = 83
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Book Title"
        Me.ColumnHeader9.Width = 137
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Author"
        Me.ColumnHeader10.Width = 125
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Publisher"
        Me.ColumnHeader11.Width = 106
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Status"
        Me.ColumnHeader12.Width = 59
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Date Released"
        Me.ColumnHeader13.Width = 90
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Book Copy"
        Me.ColumnHeader14.Width = 71
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Shelve"
        Me.ColumnHeader15.Width = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 407)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Enter Book Acq No. / Title"
        Me.Label3.Visible = False
        '
        'txtBook
        '
        Me.txtBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBook.Location = New System.Drawing.Point(173, 404)
        Me.txtBook.Name = "txtBook"
        Me.txtBook.Size = New System.Drawing.Size(170, 22)
        Me.txtBook.TabIndex = 22
        Me.txtBook.Visible = False
        '
        'txtSearch2
        '
        Me.txtSearch2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch2.Location = New System.Drawing.Point(349, 403)
        Me.txtSearch2.Name = "txtSearch2"
        Me.txtSearch2.Size = New System.Drawing.Size(87, 24)
        Me.txtSearch2.TabIndex = 23
        Me.txtSearch2.Text = "Search"
        Me.txtSearch2.UseVisualStyleBackColor = True
        Me.txtSearch2.Visible = False
        '
        'btnBrw
        '
        Me.btnBrw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrw.Location = New System.Drawing.Point(654, 403)
        Me.btnBrw.Name = "btnBrw"
        Me.btnBrw.Size = New System.Drawing.Size(120, 24)
        Me.btnBrw.TabIndex = 24
        Me.btnBrw.Text = "Borrow Book"
        Me.btnBrw.UseVisualStyleBackColor = True
        Me.btnBrw.Visible = False
        '
        'pnlBorrow
        '
        Me.pnlBorrow.BackColor = System.Drawing.SystemColors.Control
        Me.pnlBorrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBorrow.Controls.Add(Me.btnCancel)
        Me.pnlBorrow.Controls.Add(Me.btnComfirm)
        Me.pnlBorrow.Controls.Add(Me.btnComPrint)
        Me.pnlBorrow.Controls.Add(Me.Label16)
        Me.pnlBorrow.Controls.Add(Me.txtDate)
        Me.pnlBorrow.Controls.Add(Me.txtPublisher)
        Me.pnlBorrow.Controls.Add(Me.txtAuthor)
        Me.pnlBorrow.Controls.Add(Me.txtBookTitle)
        Me.pnlBorrow.Controls.Add(Me.txtAcq)
        Me.pnlBorrow.Controls.Add(Me.Label15)
        Me.pnlBorrow.Controls.Add(Me.Label14)
        Me.pnlBorrow.Controls.Add(Me.Label13)
        Me.pnlBorrow.Controls.Add(Me.Label12)
        Me.pnlBorrow.Controls.Add(Me.Label11)
        Me.pnlBorrow.Controls.Add(Me.txtBal)
        Me.pnlBorrow.Controls.Add(Me.txtContact)
        Me.pnlBorrow.Controls.Add(Me.txtAddress)
        Me.pnlBorrow.Controls.Add(Me.txtYr)
        Me.pnlBorrow.Controls.Add(Me.txtName)
        Me.pnlBorrow.Controls.Add(Me.txtId)
        Me.pnlBorrow.Controls.Add(Me.Label10)
        Me.pnlBorrow.Controls.Add(Me.Label9)
        Me.pnlBorrow.Controls.Add(Me.Label8)
        Me.pnlBorrow.Controls.Add(Me.Label7)
        Me.pnlBorrow.Controls.Add(Me.Label6)
        Me.pnlBorrow.Controls.Add(Me.Label5)
        Me.pnlBorrow.Controls.Add(Me.Label4)
        Me.pnlBorrow.Location = New System.Drawing.Point(131, 35)
        Me.pnlBorrow.Name = "pnlBorrow"
        Me.pnlBorrow.Size = New System.Drawing.Size(532, 359)
        Me.pnlBorrow.TabIndex = 25
        Me.pnlBorrow.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCancel.Location = New System.Drawing.Point(357, 325)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(152, 25)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnComfirm
        '
        Me.btnComfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnComfirm.Location = New System.Drawing.Point(191, 325)
        Me.btnComfirm.Name = "btnComfirm"
        Me.btnComfirm.Size = New System.Drawing.Size(152, 25)
        Me.btnComfirm.TabIndex = 26
        Me.btnComfirm.Text = "Comfirm"
        Me.btnComfirm.UseVisualStyleBackColor = True
        '
        'btnComPrint
        '
        Me.btnComPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnComPrint.Location = New System.Drawing.Point(22, 325)
        Me.btnComPrint.Name = "btnComPrint"
        Me.btnComPrint.Size = New System.Drawing.Size(152, 25)
        Me.btnComPrint.TabIndex = 25
        Me.btnComPrint.Text = "Comfirm And Print"
        Me.btnComPrint.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(199, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(131, 16)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Library System v1"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(105, 299)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(404, 20)
        Me.txtDate.TabIndex = 23
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(105, 275)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(404, 20)
        Me.txtPublisher.TabIndex = 21
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(105, 251)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(404, 20)
        Me.txtAuthor.TabIndex = 20
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Location = New System.Drawing.Point(105, 227)
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(404, 20)
        Me.txtBookTitle.TabIndex = 19
        '
        'txtAcq
        '
        Me.txtAcq.Location = New System.Drawing.Point(105, 204)
        Me.txtAcq.Name = "txtAcq"
        Me.txtAcq.Size = New System.Drawing.Size(404, 20)
        Me.txtAcq.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(16, 305)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "DueDate"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.Location = New System.Drawing.Point(17, 278)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Publisher"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(16, 207)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Acquisition No."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(17, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Book Title"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(17, 254)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Author"
        '
        'txtBal
        '
        Me.txtBal.Location = New System.Drawing.Point(105, 168)
        Me.txtBal.Name = "txtBal"
        Me.txtBal.Size = New System.Drawing.Size(404, 20)
        Me.txtBal.TabIndex = 12
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(105, 143)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(404, 20)
        Me.txtContact.TabIndex = 11
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(105, 118)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(404, 20)
        Me.txtAddress.TabIndex = 10
        '
        'txtYr
        '
        Me.txtYr.Location = New System.Drawing.Point(105, 95)
        Me.txtYr.Name = "txtYr"
        Me.txtYr.Size = New System.Drawing.Size(404, 20)
        Me.txtYr.TabIndex = 9
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(105, 73)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(404, 20)
        Me.txtName.TabIndex = 8
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(105, 50)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(404, 20)
        Me.txtId.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(17, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Balance"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(16, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Contact No."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(17, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(15, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Year/Section"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(16, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Borrower Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(16, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Borrower ID No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(188, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Book Borrowing Report"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'BorrowingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 456)
        Me.Controls.Add(Me.pnlBorrow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBrw)
        Me.Controls.Add(Me.txtSearch2)
        Me.Controls.Add(Me.txtBook)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstviewInventory)
        Me.Controls.Add(Me.MenuForms)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lstviewBorrowers)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "BorrowingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BorrowingForm"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuForms.ResumeLayout(False)
        Me.MenuForms.PerformLayout()
        Me.pnlBorrow.ResumeLayout(False)
        Me.pnlBorrow.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusborrower As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lstviewBorrowers As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuForms As System.Windows.Forms.MenuStrip
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstviewInventory As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBook As System.Windows.Forms.TextBox
    Friend WithEvents txtSearch2 As System.Windows.Forms.Button
    Friend WithEvents btnBrw As System.Windows.Forms.Button
    Friend WithEvents pnlBorrow As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPublisher As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtBookTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtAcq As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBal As System.Windows.Forms.TextBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtYr As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnComfirm As System.Windows.Forms.Button
    Friend WithEvents btnComPrint As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents statusid As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
End Class
