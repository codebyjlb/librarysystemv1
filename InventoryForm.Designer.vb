<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryForm))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statuslabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusView = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lstviewBorrowed = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnBorrowed = New System.Windows.Forms.ToolStripButton()
        Me.btnDamaged = New System.Windows.Forms.ToolStripButton()
        Me.btnAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.lstDamage = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstAll = New System.Windows.Forms.ListView()
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.statuslabel1, Me.statusView})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(780, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'statuslabel1
        '
        Me.statuslabel1.Name = "statuslabel1"
        Me.statuslabel1.Size = New System.Drawing.Size(10, 17)
        Me.statuslabel1.Text = " "
        '
        'statusView
        '
        Me.statusView.Name = "statusView"
        Me.statusView.Size = New System.Drawing.Size(0, 17)
        '
        'lstviewBorrowed
        '
        Me.lstviewBorrowed.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader25, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.lstviewBorrowed.Location = New System.Drawing.Point(3, 28)
        Me.lstviewBorrowed.Name = "lstviewBorrowed"
        Me.lstviewBorrowed.Size = New System.Drawing.Size(774, 397)
        Me.lstviewBorrowed.TabIndex = 7
        Me.lstviewBorrowed.UseCompatibleStateImageBehavior = False
        Me.lstviewBorrowed.View = System.Windows.Forms.View.Details
        Me.lstviewBorrowed.Visible = False
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ID"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Title"
        Me.ColumnHeader25.Width = 126
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Author"
        Me.ColumnHeader9.Width = 137
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Publisher"
        Me.ColumnHeader10.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "DueDate"
        Me.ColumnHeader11.Width = 133
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Borrower ID No."
        Me.ColumnHeader12.Width = 159
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Borrower Name"
        Me.ColumnHeader13.Width = 212
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBorrowed, Me.btnDamaged, Me.btnAll, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(780, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "Close"
        '
        'btnBorrowed
        '
        Me.btnBorrowed.Image = CType(resources.GetObject("btnBorrowed.Image"), System.Drawing.Image)
        Me.btnBorrowed.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBorrowed.Name = "btnBorrowed"
        Me.btnBorrowed.Size = New System.Drawing.Size(113, 22)
        Me.btnBorrowed.Text = "Borrowed Books"
        '
        'btnDamaged
        '
        Me.btnDamaged.Image = CType(resources.GetObject("btnDamaged.Image"), System.Drawing.Image)
        Me.btnDamaged.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDamaged.Name = "btnDamaged"
        Me.btnDamaged.Size = New System.Drawing.Size(113, 22)
        Me.btnDamaged.Text = "Damaged Books"
        '
        'btnAll
        '
        Me.btnAll.Image = CType(resources.GetObject("btnAll.Image"), System.Drawing.Image)
        Me.btnAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(76, 22)
        Me.btnAll.Text = "All Books"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripButton1.Text = "Close"
        '
        'lstDamage
        '
        Me.lstDamage.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader8})
        Me.lstDamage.Location = New System.Drawing.Point(3, 28)
        Me.lstDamage.Name = "lstDamage"
        Me.lstDamage.Size = New System.Drawing.Size(774, 397)
        Me.lstDamage.TabIndex = 9
        Me.lstDamage.UseCompatibleStateImageBehavior = False
        Me.lstDamage.View = System.Windows.Forms.View.Details
        Me.lstDamage.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID "
        Me.ColumnHeader1.Width = 142
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Book Title"
        Me.ColumnHeader2.Width = 229
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Author"
        Me.ColumnHeader3.Width = 186
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Borrower Name"
        Me.ColumnHeader8.Width = 215
        '
        'lstAll
        '
        Me.lstAll.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24})
        Me.lstAll.Location = New System.Drawing.Point(3, 28)
        Me.lstAll.Name = "lstAll"
        Me.lstAll.Size = New System.Drawing.Size(774, 397)
        Me.lstAll.TabIndex = 10
        Me.lstAll.UseCompatibleStateImageBehavior = False
        Me.lstAll.View = System.Windows.Forms.View.Details
        Me.lstAll.Visible = False
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Aqcuisition No."
        Me.ColumnHeader17.Width = 83
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Book Title"
        Me.ColumnHeader18.Width = 180
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Author"
        Me.ColumnHeader19.Width = 121
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Publisher"
        Me.ColumnHeader20.Width = 0
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Status"
        Me.ColumnHeader21.Width = 117
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Date Released"
        Me.ColumnHeader22.Width = 109
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Book Copy"
        Me.ColumnHeader23.Width = 71
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Shelves"
        Me.ColumnHeader24.Width = 89
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 450)
        Me.Controls.Add(Me.lstAll)
        Me.Controls.Add(Me.lstDamage)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lstviewBorrowed)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "InventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InventoryForm"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statuslabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lstviewBorrowed As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBorrowed As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDamaged As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents lstDamage As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstAll As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents statusView As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
End Class
