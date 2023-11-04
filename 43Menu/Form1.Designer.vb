<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        PrintToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        DeleToolStripMenuItem = New ToolStripMenuItem()
        DeleteAllToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        SelectToolStripMenuItem = New ToolStripMenuItem()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripSeparator()
        ShowToolStripMenuItem = New ToolStripMenuItem()
        HideToolStripMenuItem = New ToolStripMenuItem()
        WordWrapToolStripMenuItem = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        ZoomToolStripMenuItem = New ToolStripMenuItem()
        ZoomInToolStripMenuItem = New ToolStripMenuItem()
        ZoomOutToolStripMenuItem = New ToolStripMenuItem()
        FormatToolStripMenuItem = New ToolStripMenuItem()
        BackColorToolStripMenuItem = New ToolStripMenuItem()
        ForeColorToolStripMenuItem = New ToolStripMenuItem()
        txtMenu = New TextBox()
        cmsDemo = New ContextMenuStrip(components)
        CutToolStripMenuItem1 = New ToolStripMenuItem()
        CopyToolStripMenuItem1 = New ToolStripMenuItem()
        PasteToolStripMenuItem1 = New ToolStripMenuItem()
        ColorDialog1 = New ColorDialog()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        BackgroundToolStripMenuItem = New ToolStripMenuItem()
        OpenFileDialog1 = New OpenFileDialog()
        PrintDialog1 = New PrintDialog()
        FontDialog1 = New FontDialog()
        MenuStrip1.SuspendLayout()
        cmsDemo.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, ViewToolStripMenuItem, FormatToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(515, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem, ToolStripMenuItem1, ExitToolStripMenuItem, PrintToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.N
        NewToolStripMenuItem.Size = New Size(223, 34)
        NewToolStripMenuItem.Text = "New"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        OpenToolStripMenuItem.Size = New Size(223, 34)
        OpenToolStripMenuItem.Text = "Open"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        SaveToolStripMenuItem.Size = New Size(223, 34)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(220, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(223, 34)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' PrintToolStripMenuItem
        ' 
        PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        PrintToolStripMenuItem.Size = New Size(223, 34)
        PrintToolStripMenuItem.Text = "Print"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, DeleToolStripMenuItem, DeleteAllToolStripMenuItem, ToolStripMenuItem2, SelectToolStripMenuItem, SelectAllToolStripMenuItem, ToolStripMenuItem3, ShowToolStripMenuItem, HideToolStripMenuItem, WordWrapToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(58, 29)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.X
        CutToolStripMenuItem.Size = New Size(248, 34)
        CutToolStripMenuItem.Text = "Cut"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.C
        CopyToolStripMenuItem.Size = New Size(248, 34)
        CopyToolStripMenuItem.Text = "Copy"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.V
        PasteToolStripMenuItem.Size = New Size(248, 34)
        PasteToolStripMenuItem.Text = "Paste"
        ' 
        ' DeleToolStripMenuItem
        ' 
        DeleToolStripMenuItem.Name = "DeleToolStripMenuItem"
        DeleToolStripMenuItem.ShortcutKeys = Keys.Delete
        DeleToolStripMenuItem.Size = New Size(248, 34)
        DeleToolStripMenuItem.Text = "Delete"
        ' 
        ' DeleteAllToolStripMenuItem
        ' 
        DeleteAllToolStripMenuItem.Name = "DeleteAllToolStripMenuItem"
        DeleteAllToolStripMenuItem.Size = New Size(248, 34)
        DeleteAllToolStripMenuItem.Text = "Delete All"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(245, 6)
        ' 
        ' SelectToolStripMenuItem
        ' 
        SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        SelectToolStripMenuItem.Size = New Size(248, 34)
        SelectToolStripMenuItem.Text = "Select"
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.A
        SelectAllToolStripMenuItem.Size = New Size(248, 34)
        SelectAllToolStripMenuItem.Text = "Select All"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(245, 6)
        ' 
        ' ShowToolStripMenuItem
        ' 
        ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        ShowToolStripMenuItem.Size = New Size(248, 34)
        ShowToolStripMenuItem.Text = "Show"
        ' 
        ' HideToolStripMenuItem
        ' 
        HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        HideToolStripMenuItem.Size = New Size(248, 34)
        HideToolStripMenuItem.Text = "Hide"
        ' 
        ' WordWrapToolStripMenuItem
        ' 
        WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
        WordWrapToolStripMenuItem.Size = New Size(248, 34)
        WordWrapToolStripMenuItem.Text = "Word Wrap"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ZoomToolStripMenuItem})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(65, 29)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' ZoomToolStripMenuItem
        ' 
        ZoomToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ZoomInToolStripMenuItem, ZoomOutToolStripMenuItem})
        ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        ZoomToolStripMenuItem.Size = New Size(162, 34)
        ZoomToolStripMenuItem.Text = "Zoom"
        ' 
        ' ZoomInToolStripMenuItem
        ' 
        ZoomInToolStripMenuItem.Name = "ZoomInToolStripMenuItem"
        ZoomInToolStripMenuItem.Size = New Size(197, 34)
        ZoomInToolStripMenuItem.Text = "Zoom In"
        ' 
        ' ZoomOutToolStripMenuItem
        ' 
        ZoomOutToolStripMenuItem.Name = "ZoomOutToolStripMenuItem"
        ZoomOutToolStripMenuItem.Size = New Size(197, 34)
        ZoomOutToolStripMenuItem.Text = "Zoom Out"
        ' 
        ' FormatToolStripMenuItem
        ' 
        FormatToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BackColorToolStripMenuItem, ForeColorToolStripMenuItem})
        FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        FormatToolStripMenuItem.Size = New Size(85, 29)
        FormatToolStripMenuItem.Text = "Format"
        ' 
        ' BackColorToolStripMenuItem
        ' 
        BackColorToolStripMenuItem.Name = "BackColorToolStripMenuItem"
        BackColorToolStripMenuItem.Size = New Size(193, 34)
        BackColorToolStripMenuItem.Text = "BackColor"
        ' 
        ' ForeColorToolStripMenuItem
        ' 
        ForeColorToolStripMenuItem.Name = "ForeColorToolStripMenuItem"
        ForeColorToolStripMenuItem.Size = New Size(193, 34)
        ForeColorToolStripMenuItem.Text = "ForeColor"
        ' 
        ' txtMenu
        ' 
        txtMenu.ContextMenuStrip = cmsDemo
        txtMenu.Location = New Point(12, 36)
        txtMenu.Multiline = True
        txtMenu.Name = "txtMenu"
        txtMenu.ScrollBars = ScrollBars.Both
        txtMenu.Size = New Size(490, 320)
        txtMenu.TabIndex = 1
        txtMenu.WordWrap = False
        ' 
        ' cmsDemo
        ' 
        cmsDemo.BackColor = Color.White
        cmsDemo.ImageScalingSize = New Size(24, 24)
        cmsDemo.Items.AddRange(New ToolStripItem() {CutToolStripMenuItem1, CopyToolStripMenuItem1, PasteToolStripMenuItem1})
        cmsDemo.Name = "ContextMenuStrip1"
        cmsDemo.Size = New Size(127, 100)
        ' 
        ' CutToolStripMenuItem1
        ' 
        CutToolStripMenuItem1.Name = "CutToolStripMenuItem1"
        CutToolStripMenuItem1.Size = New Size(126, 32)
        CutToolStripMenuItem1.Text = "Cut"
        ' 
        ' CopyToolStripMenuItem1
        ' 
        CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1"
        CopyToolStripMenuItem1.Size = New Size(126, 32)
        CopyToolStripMenuItem1.Text = "Copy"
        ' 
        ' PasteToolStripMenuItem1
        ' 
        PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1"
        PasteToolStripMenuItem1.Size = New Size(126, 32)
        PasteToolStripMenuItem1.Text = "Paste"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {BackgroundToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(180, 36)
        ' 
        ' BackgroundToolStripMenuItem
        ' 
        BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem"
        BackgroundToolStripMenuItem.Size = New Size(179, 32)
        BackgroundToolStripMenuItem.Text = "Background"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "text |*.txt|All File(*.*)|(*.*)"
        OpenFileDialog1.InitialDirectory = "C:/Users/hp/Desktop"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(515, 366)
        ContextMenuStrip = ContextMenuStrip1
        Controls.Add(txtMenu)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        cmsDemo.ResumeLayout(False)
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents SelectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordWrapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtMenu As TextBox
    Friend WithEvents cmsDemo As ContextMenuStrip
    Friend WithEvents CutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BackgroundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForeColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents FontDialog1 As FontDialog
End Class
