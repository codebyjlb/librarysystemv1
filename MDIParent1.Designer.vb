<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBorrowerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCatalogue = New System.Windows.Forms.ToolStripButton()
        Me.btnBorrowing = New System.Windows.Forms.ToolStripButton()
        Me.btnReturning = New System.Windows.Forms.ToolStripButton()
        Me.btnInventory = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnQuickRegister = New System.Windows.Forms.ToolStripButton()
        Me.btnBorrowers = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnHelp = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statuslabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusdate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.WindowToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1009, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SystemToolStripMenuItem.Text = "&System"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ExitToolStripMenuItem.Text = "Exit "
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBorrowerToolStripMenuItem, Me.AddBooksToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'AddBorrowerToolStripMenuItem
        '
        Me.AddBorrowerToolStripMenuItem.Name = "AddBorrowerToolStripMenuItem"
        Me.AddBorrowerToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AddBorrowerToolStripMenuItem.Text = "Add Borrower"
        '
        'AddBooksToolStripMenuItem
        '
        Me.AddBooksToolStripMenuItem.Name = "AddBooksToolStripMenuItem"
        Me.AddBooksToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AddBooksToolStripMenuItem.Text = "Add Books"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "&Window"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About "
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCatalogue, Me.btnBorrowing, Me.btnReturning, Me.btnInventory, Me.ToolStripSeparator1, Me.btnQuickRegister, Me.btnBorrowers, Me.btnExit, Me.btnHelp})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1009, 31)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCatalogue
        '
        Me.btnCatalogue.Image = CType(resources.GetObject("btnCatalogue.Image"), System.Drawing.Image)
        Me.btnCatalogue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCatalogue.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCatalogue.Name = "btnCatalogue"
        Me.btnCatalogue.Size = New System.Drawing.Size(89, 28)
        Me.btnCatalogue.Text = "Catalogue"
        '
        'btnBorrowing
        '
        Me.btnBorrowing.Image = CType(resources.GetObject("btnBorrowing.Image"), System.Drawing.Image)
        Me.btnBorrowing.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnBorrowing.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBorrowing.Name = "btnBorrowing"
        Me.btnBorrowing.Size = New System.Drawing.Size(90, 51)
        Me.btnBorrowing.Text = "Borrowing"
        '
        'btnReturning
        '
        Me.btnReturning.Image = CType(resources.GetObject("btnReturning.Image"), System.Drawing.Image)
        Me.btnReturning.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnReturning.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReturning.Name = "btnReturning"
        Me.btnReturning.Size = New System.Drawing.Size(87, 51)
        Me.btnReturning.Text = "Returning"
        '
        'btnInventory
        '
        Me.btnInventory.Image = CType(resources.GetObject("btnInventory.Image"), System.Drawing.Image)
        Me.btnInventory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnInventory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(85, 51)
        Me.btnInventory.Text = "Inventory"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 54)
        '
        'btnQuickRegister
        '
        Me.btnQuickRegister.Image = CType(resources.GetObject("btnQuickRegister.Image"), System.Drawing.Image)
        Me.btnQuickRegister.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnQuickRegister.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnQuickRegister.Name = "btnQuickRegister"
        Me.btnQuickRegister.Size = New System.Drawing.Size(108, 28)
        Me.btnQuickRegister.Text = "Add Borrower"
        '
        'btnBorrowers
        '
        Me.btnBorrowers.Image = CType(resources.GetObject("btnBorrowers.Image"), System.Drawing.Image)
        Me.btnBorrowers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnBorrowers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBorrowers.Name = "btnBorrowers"
        Me.btnBorrowers.Size = New System.Drawing.Size(109, 28)
        Me.btnBorrowers.Text = "Borrowers List"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(133, 28)
        Me.btnExit.Text = "Exit Library System"
        '
        'btnHelp
        '
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(60, 28)
        Me.btnHelp.Text = "Help"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabel1, Me.statusdate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 588)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1009, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statuslabel1
        '
        Me.statuslabel1.Name = "statuslabel1"
        Me.statuslabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.statuslabel1.Size = New System.Drawing.Size(0, 17)
        '
        'statusdate
        '
        Me.statusdate.Margin = New System.Windows.Forms.Padding(800, 3, 0, 2)
        Me.statusdate.Name = "statusdate"
        Me.statusdate.Size = New System.Drawing.Size(121, 17)
        Me.statusdate.Text = "ToolStripStatusLabel1"
        Me.statusdate.ToolTipText = "iljl'"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 610)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Location = New System.Drawing.Point(0, 100)
        Me.Name = "MDIParent1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library System  V1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddBorrowerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCatalogue As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBorrowing As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnReturning As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnInventory As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnQuickRegister As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBorrowers As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents statuslabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusdate As System.Windows.Forms.ToolStripStatusLabel

End Class
