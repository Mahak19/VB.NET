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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        mnuNew = New ToolStripMenuItem()
        mnuOpen = New ToolStripMenuItem()
        mnuSave = New ToolStripMenuItem()
        mnuSaveAs = New ToolStripMenuItem()
        HrToolStripMenuItem = New ToolStripSeparator()
        mnuPrint = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        mnuUndo = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        mnuCut = New ToolStripMenuItem()
        mnuCopy = New ToolStripMenuItem()
        mnuPaste = New ToolStripMenuItem()
        mnuDelete = New ToolStripMenuItem()
        mnuSelect = New ToolStripMenuItem()
        mnuSelectAll = New ToolStripMenuItem()
        mnuDeselectAll = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        mnuShow = New ToolStripMenuItem()
        mnuHide = New ToolStripMenuItem()
        txtMenu = New TextBox()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuNew, mnuOpen, mnuSave, mnuSaveAs, HrToolStripMenuItem, mnuPrint})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' mnuNew
        ' 
        mnuNew.Name = "mnuNew"
        mnuNew.Size = New Size(270, 34)
        mnuNew.Text = "New"
        ' 
        ' mnuOpen
        ' 
        mnuOpen.Name = "mnuOpen"
        mnuOpen.Size = New Size(270, 34)
        mnuOpen.Text = "Open"
        ' 
        ' mnuSave
        ' 
        mnuSave.Name = "mnuSave"
        mnuSave.Size = New Size(270, 34)
        mnuSave.Text = "Save"
        ' 
        ' mnuSaveAs
        ' 
        mnuSaveAs.Name = "mnuSaveAs"
        mnuSaveAs.Size = New Size(270, 34)
        mnuSaveAs.Text = "Save As"
        ' 
        ' HrToolStripMenuItem
        ' 
        HrToolStripMenuItem.Name = "HrToolStripMenuItem"
        HrToolStripMenuItem.Size = New Size(267, 6)
        ' 
        ' mnuPrint
        ' 
        mnuPrint.Name = "mnuPrint"
        mnuPrint.Size = New Size(270, 34)
        mnuPrint.Text = "Print"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuUndo, ToolStripMenuItem1, mnuCut, mnuCopy, mnuPaste, mnuDelete, mnuSelect, mnuSelectAll, mnuDeselectAll, ToolStripMenuItem2, mnuShow, mnuHide})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(58, 29)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' mnuUndo
        ' 
        mnuUndo.Name = "mnuUndo"
        mnuUndo.Size = New Size(270, 34)
        mnuUndo.Text = "Undo"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(267, 6)
        ' 
        ' mnuCut
        ' 
        mnuCut.Name = "mnuCut"
        mnuCut.Size = New Size(270, 34)
        mnuCut.Text = "Cut"
        ' 
        ' mnuCopy
        ' 
        mnuCopy.Name = "mnuCopy"
        mnuCopy.Size = New Size(270, 34)
        mnuCopy.Text = "Copy"
        ' 
        ' mnuPaste
        ' 
        mnuPaste.Name = "mnuPaste"
        mnuPaste.Size = New Size(270, 34)
        mnuPaste.Text = "Paste"
        ' 
        ' mnuDelete
        ' 
        mnuDelete.Name = "mnuDelete"
        mnuDelete.Size = New Size(270, 34)
        mnuDelete.Text = "Delete"
        ' 
        ' mnuSelect
        ' 
        mnuSelect.Name = "mnuSelect"
        mnuSelect.Size = New Size(270, 34)
        mnuSelect.Text = "Select"
        ' 
        ' mnuSelectAll
        ' 
        mnuSelectAll.Name = "mnuSelectAll"
        mnuSelectAll.Size = New Size(270, 34)
        mnuSelectAll.Text = "Select All"
        ' 
        ' mnuDeselectAll
        ' 
        mnuDeselectAll.Name = "mnuDeselectAll"
        mnuDeselectAll.Size = New Size(270, 34)
        mnuDeselectAll.Text = "Deselect All"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(267, 6)
        ' 
        ' mnuShow
        ' 
        mnuShow.Name = "mnuShow"
        mnuShow.Size = New Size(270, 34)
        mnuShow.Text = "Show"
        ' 
        ' mnuHide
        ' 
        mnuHide.Name = "mnuHide"
        mnuHide.Size = New Size(270, 34)
        mnuHide.Text = "Hide"
        ' 
        ' txtMenu
        ' 
        txtMenu.Location = New Point(12, 56)
        txtMenu.Multiline = True
        txtMenu.Name = "txtMenu"
        txtMenu.ScrollBars = ScrollBars.Both
        txtMenu.Size = New Size(776, 382)
        txtMenu.TabIndex = 1
        txtMenu.WordWrap = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtMenu)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuNew As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuSaveAs As ToolStripMenuItem
    Friend WithEvents HrToolStripMenuItem As ToolStripSeparator
    Friend WithEvents mnuPrint As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuUndo As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuCut As ToolStripMenuItem
    Friend WithEvents mnuCopy As ToolStripMenuItem
    Friend WithEvents mnuPaste As ToolStripMenuItem
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents mnuSelect As ToolStripMenuItem
    Friend WithEvents mnuSelectAll As ToolStripMenuItem
    Friend WithEvents mnuDeselectAll As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents mnuShow As ToolStripMenuItem
    Friend WithEvents mnuHide As ToolStripMenuItem
    Friend WithEvents txtMenu As TextBox
End Class
