﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentProfile))
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.lblConcentration = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramConcentrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DegreeProgressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tpProfile = New System.Windows.Forms.TabPage()
        Me.tbStudentProfile = New System.Windows.Forms.TabControl()
        Me.lblStuID = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.tbStudentProfile.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(56, 67)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(126, 39)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Label1"
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram.Location = New System.Drawing.Point(1044, 67)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(120, 39)
        Me.lblProgram.TabIndex = 1
        Me.lblProgram.Text = "Label1"
        '
        'lblConcentration
        '
        Me.lblConcentration.AutoSize = True
        Me.lblConcentration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcentration.Location = New System.Drawing.Point(1059, 117)
        Me.lblConcentration.Name = "lblConcentration"
        Me.lblConcentration.Size = New System.Drawing.Size(105, 36)
        Me.lblConcentration.TabIndex = 2
        Me.lblConcentration.Text = "Label1"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1020, 686)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(155, 50)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1204, 49)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(75, 45)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramConcentrationToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(80, 45)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ProgramConcentrationToolStripMenuItem
        '
        Me.ProgramConcentrationToolStripMenuItem.Name = "ProgramConcentrationToolStripMenuItem"
        Me.ProgramConcentrationToolStripMenuItem.Size = New System.Drawing.Size(447, 46)
        Me.ProgramConcentrationToolStripMenuItem.Text = "Program/Concentration"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DegreeProgressToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(94, 45)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'DegreeProgressToolStripMenuItem
        '
        Me.DegreeProgressToolStripMenuItem.Name = "DegreeProgressToolStripMenuItem"
        Me.DegreeProgressToolStripMenuItem.Size = New System.Drawing.Size(353, 46)
        Me.DegreeProgressToolStripMenuItem.Text = "Degree Progress"
        '
        'tpProfile
        '
        Me.tpProfile.Location = New System.Drawing.Point(10, 48)
        Me.tpProfile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpProfile.Name = "tpProfile"
        Me.tpProfile.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpProfile.Size = New System.Drawing.Size(1143, 457)
        Me.tpProfile.TabIndex = 0
        Me.tpProfile.Text = "Information"
        Me.tpProfile.UseVisualStyleBackColor = True
        '
        'tbStudentProfile
        '
        Me.tbStudentProfile.Controls.Add(Me.tpProfile)
        Me.tbStudentProfile.Location = New System.Drawing.Point(12, 167)
        Me.tbStudentProfile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbStudentProfile.Name = "tbStudentProfile"
        Me.tbStudentProfile.SelectedIndex = 0
        Me.tbStudentProfile.Size = New System.Drawing.Size(1163, 515)
        Me.tbStudentProfile.TabIndex = 3
        '
        'lblStuID
        '
        Me.lblStuID.AutoSize = True
        Me.lblStuID.Location = New System.Drawing.Point(57, 120)
        Me.lblStuID.Name = "lblStuID"
        Me.lblStuID.Size = New System.Drawing.Size(102, 32)
        Me.lblStuID.TabIndex = 12
        Me.lblStuID.Text = "Label1"
        '
        'StudentProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1204, 750)
        Me.Controls.Add(Me.lblStuID)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tbStudentProfile)
        Me.Controls.Add(Me.lblConcentration)
        Me.Controls.Add(Me.lblProgram)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "StudentProfile"
        Me.Text = "StudentProfile"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tbStudentProfile.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblProgram As Label
    Friend WithEvents lblConcentration As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DegreeProgressToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tpProfile As TabPage
    Friend WithEvents tbStudentProfile As TabControl
    Friend WithEvents lblStuID As Label
    Friend WithEvents ProgramConcentrationToolStripMenuItem As ToolStripMenuItem
End Class
