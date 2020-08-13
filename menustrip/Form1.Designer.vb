<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHomeExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUserLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUserStaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMovie = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaymentReceipt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaymentRefund = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromotionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHome, Me.mnuUser, Me.mnuMovie, Me.BookingToolStripMenuItem, Me.PromotionToolStripMenuItem, Me.mnuPayment, Me.mnuUpdate, Me.mnuDelete, Me.mnuDisplay, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuHome
        '
        Me.mnuHome.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHomeExit})
        Me.mnuHome.Name = "mnuHome"
        Me.mnuHome.Size = New System.Drawing.Size(52, 20)
        Me.mnuHome.Text = "&Home"
        '
        'mnuHomeExit
        '
        Me.mnuHomeExit.Name = "mnuHomeExit"
        Me.mnuHomeExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuHomeExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuHomeExit.Text = "E&xit"
        '
        'mnuUser
        '
        Me.mnuUser.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUserLogin, Me.mnuUserStaff})
        Me.mnuUser.Name = "mnuUser"
        Me.mnuUser.Size = New System.Drawing.Size(42, 20)
        Me.mnuUser.Text = "&User"
        '
        'mnuUserLogin
        '
        Me.mnuUserLogin.Name = "mnuUserLogin"
        Me.mnuUserLogin.Size = New System.Drawing.Size(180, 22)
        Me.mnuUserLogin.Text = "&Login"
        '
        'mnuUserStaff
        '
        Me.mnuUserStaff.Name = "mnuUserStaff"
        Me.mnuUserStaff.Size = New System.Drawing.Size(180, 22)
        Me.mnuUserStaff.Text = "&Staff"
        '
        'mnuMovie
        '
        Me.mnuMovie.Name = "mnuMovie"
        Me.mnuMovie.Size = New System.Drawing.Size(52, 20)
        Me.mnuMovie.Text = "&Movie"
        '
        'mnuPayment
        '
        Me.mnuPayment.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPaymentReceipt, Me.mnuPaymentRefund})
        Me.mnuPayment.Name = "mnuPayment"
        Me.mnuPayment.Size = New System.Drawing.Size(66, 20)
        Me.mnuPayment.Text = "&Payment"
        '
        'mnuPaymentReceipt
        '
        Me.mnuPaymentReceipt.Name = "mnuPaymentReceipt"
        Me.mnuPaymentReceipt.Size = New System.Drawing.Size(180, 22)
        Me.mnuPaymentReceipt.Text = "Re&ceipt"
        '
        'mnuPaymentRefund
        '
        Me.mnuPaymentRefund.Name = "mnuPaymentRefund"
        Me.mnuPaymentRefund.Size = New System.Drawing.Size(180, 22)
        Me.mnuPaymentRefund.Text = "Re&fund"
        '
        'mnuUpdate
        '
        Me.mnuUpdate.Name = "mnuUpdate"
        Me.mnuUpdate.Size = New System.Drawing.Size(57, 20)
        Me.mnuUpdate.Text = "&Update"
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(52, 20)
        Me.mnuDelete.Text = "&Delete"
        '
        'mnuDisplay
        '
        Me.mnuDisplay.Name = "mnuDisplay"
        Me.mnuDisplay.Size = New System.Drawing.Size(57, 20)
        Me.mnuDisplay.Text = "D&isplay"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.mnuHelpAbout.Size = New System.Drawing.Size(180, 22)
        Me.mnuHelpAbout.Text = "&About"
        '
        'BookingToolStripMenuItem
        '
        Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
        Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.BookingToolStripMenuItem.Text = "&Booking Ticket"
        '
        'PromotionToolStripMenuItem
        '
        Me.PromotionToolStripMenuItem.Name = "PromotionToolStripMenuItem"
        Me.PromotionToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.PromotionToolStripMenuItem.Text = "&Promotion"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form2"
        Me.Text = "MenuStrip"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents mnuHome As ToolStripMenuItem
    Friend WithEvents mnuHomeExit As ToolStripMenuItem
    Friend WithEvents mnuUser As ToolStripMenuItem
    Friend WithEvents mnuUserLogin As ToolStripMenuItem
    Friend WithEvents mnuUserStaff As ToolStripMenuItem
    Friend WithEvents mnuMovie As ToolStripMenuItem
    Friend WithEvents mnuPayment As ToolStripMenuItem
    Friend WithEvents mnuPaymentReceipt As ToolStripMenuItem
    Friend WithEvents mnuPaymentRefund As ToolStripMenuItem
    Friend WithEvents mnuUpdate As ToolStripMenuItem
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents mnuDisplay As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PromotionToolStripMenuItem As ToolStripMenuItem
End Class
