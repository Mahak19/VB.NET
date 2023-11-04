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
        PictureBox1 = New PictureBox()
        btnLoad = New Button()
        btnUnload = New Button()
        pcbPic = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pcbPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.fries3
        PictureBox1.Location = New Point(22, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(198, 184)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnLoad
        ' 
        btnLoad.Location = New Point(267, 252)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(112, 60)
        btnLoad.TabIndex = 1
        btnLoad.Text = "Load"
        btnLoad.UseVisualStyleBackColor = True
        ' 
        ' btnUnload
        ' 
        btnUnload.Location = New Point(399, 252)
        btnUnload.Name = "btnUnload"
        btnUnload.Size = New Size(116, 60)
        btnUnload.TabIndex = 2
        btnUnload.Text = "Unload"
        btnUnload.UseVisualStyleBackColor = True
        ' 
        ' pcbPic
        ' 
        pcbPic.Location = New Point(281, 23)
        pcbPic.Name = "pcbPic"
        pcbPic.Size = New Size(195, 184)
        pcbPic.SizeMode = PictureBoxSizeMode.StretchImage
        pcbPic.TabIndex = 3
        pcbPic.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(576, 442)
        Controls.Add(pcbPic)
        Controls.Add(btnUnload)
        Controls.Add(btnLoad)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pcbPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnUnload As Button
    Friend WithEvents pcbPic As PictureBox
End Class
