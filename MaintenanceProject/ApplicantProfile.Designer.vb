﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ApplicantProfile
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ApplicantProfile))
        Me.PersonalTabPage = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.ApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectS1747DataSet1 = New MaintenanceProject.PROJECTS1747DataSet()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbYears = New System.Windows.Forms.TextBox()
        Me.tbEmployer = New System.Windows.Forms.TextBox()
        Me.tbEthnicity = New System.Windows.Forms.TextBox()
        Me.tbGender = New System.Windows.Forms.TextBox()
        Me.tbAge = New System.Windows.Forms.TextBox()
        Me.tbStuID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tbGDDegree = New System.Windows.Forms.TextBox()
        Me.tbGDInst = New System.Windows.Forms.TextBox()
        Me.tbUGDMajor = New System.Windows.Forms.TextBox()
        Me.tbUGDDegree = New System.Windows.Forms.TextBox()
        Me.tbUDGGPA = New System.Windows.Forms.TextBox()
        Me.tbUDGInst = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.tbUAEmail = New System.Windows.Forms.TextBox()
        Me.tbAppId = New System.Windows.Forms.TextBox()
        Me.tbStudentID = New System.Windows.Forms.TextBox()
        Me.tbAppDate = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.tbTOEFL = New System.Windows.Forms.TextBox()
        Me.tbWR = New System.Windows.Forms.TextBox()
        Me.tbVQPct = New System.Windows.Forms.TextBox()
        Me.tbQuanPct = New System.Windows.Forms.TextBox()
        Me.tbQuan = New System.Windows.Forms.TextBox()
        Me.tbVerbPct = New System.Windows.Forms.TextBox()
        Me.tbVerb = New System.Windows.Forms.TextBox()
        Me.tbGMAT = New System.Windows.Forms.TextBox()
        Me.tbEval = New System.Windows.Forms.TextBox()
        Me.tbElac = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabAdmissions = New System.Windows.Forms.TabPage()
        Me.tbConcentration = New System.Windows.Forms.TextBox()
        Me.ProgramRequirementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbProgram = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.tbResponse = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.cbDecision = New System.Windows.Forms.ComboBox()
        Me.lblStuName = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label_ProgramType = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditRecommendation = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditInterview = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuViewRecommendations = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuViewInterview = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ApplicationTableAdapter = New MaintenanceProject.PROJECTS1747DataSetTableAdapters.ApplicationTableAdapter()
        Me.Program_RequirementTableAdapter = New MaintenanceProject.PROJECTS1747DataSetTableAdapters.Program_RequirementTableAdapter()
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.PersonalTabPage.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectS1747DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.tabAdmissions.SuspendLayout()
        CType(Me.ProgramRequirementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'PersonalTabPage
        '
        Me.PersonalTabPage.Controls.Add(Me.TabPage1)
        Me.PersonalTabPage.Controls.Add(Me.TabPage2)
        Me.PersonalTabPage.Controls.Add(Me.TabPage3)
        Me.PersonalTabPage.Controls.Add(Me.TabPage4)
        Me.PersonalTabPage.Controls.Add(Me.tabAdmissions)
        Me.PersonalTabPage.Location = New System.Drawing.Point(6, 56)
        Me.PersonalTabPage.Name = "PersonalTabPage"
        Me.PersonalTabPage.SelectedIndex = 0
        Me.PersonalTabPage.Size = New System.Drawing.Size(463, 349)
        Me.PersonalTabPage.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(455, 323)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Personal"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tbAddress
        '
        Me.tbAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Address", True))
        Me.tbAddress.Location = New System.Drawing.Point(77, 73)
        Me.tbAddress.Margin = New System.Windows.Forms.Padding(1)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.ReadOnly = True
        Me.tbAddress.Size = New System.Drawing.Size(130, 20)
        Me.tbAddress.TabIndex = 27
        '
        'ApplicationBindingSource
        '
        Me.ApplicationBindingSource.DataMember = "Application"
        Me.ApplicationBindingSource.DataSource = Me.ProjectS1747DataSet1
        '
        'ProjectS1747DataSet1
        '
        Me.ProjectS1747DataSet1.DataSetName = "PROJECTS1747DataSet"
        Me.ProjectS1747DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbPhone
        '
        Me.tbPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Phone", True))
        Me.tbPhone.Location = New System.Drawing.Point(77, 45)
        Me.tbPhone.Margin = New System.Windows.Forms.Padding(1)
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.ReadOnly = True
        Me.tbPhone.Size = New System.Drawing.Size(130, 20)
        Me.tbPhone.TabIndex = 26
        '
        'tbEmail
        '
        Me.tbEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Non_UA_Email", True))
        Me.tbEmail.Location = New System.Drawing.Point(77, 17)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(1)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.ReadOnly = True
        Me.tbEmail.Size = New System.Drawing.Size(130, 20)
        Me.tbEmail.TabIndex = 25
        '
        'tbYears
        '
        Me.tbYears.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "TWE", True))
        Me.tbYears.Location = New System.Drawing.Point(72, 45)
        Me.tbYears.Margin = New System.Windows.Forms.Padding(1)
        Me.tbYears.Name = "tbYears"
        Me.tbYears.ReadOnly = True
        Me.tbYears.Size = New System.Drawing.Size(130, 20)
        Me.tbYears.TabIndex = 24
        Me.tbYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbEmployer
        '
        Me.tbEmployer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Current_Employer", True))
        Me.tbEmployer.Location = New System.Drawing.Point(72, 17)
        Me.tbEmployer.Margin = New System.Windows.Forms.Padding(1)
        Me.tbEmployer.Name = "tbEmployer"
        Me.tbEmployer.ReadOnly = True
        Me.tbEmployer.Size = New System.Drawing.Size(130, 20)
        Me.tbEmployer.TabIndex = 23
        '
        'tbEthnicity
        '
        Me.tbEthnicity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Ethnicity", True))
        Me.tbEthnicity.Location = New System.Drawing.Point(72, 101)
        Me.tbEthnicity.Margin = New System.Windows.Forms.Padding(1)
        Me.tbEthnicity.Name = "tbEthnicity"
        Me.tbEthnicity.ReadOnly = True
        Me.tbEthnicity.Size = New System.Drawing.Size(130, 20)
        Me.tbEthnicity.TabIndex = 22
        '
        'tbGender
        '
        Me.tbGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Gender", True))
        Me.tbGender.Location = New System.Drawing.Point(72, 73)
        Me.tbGender.Margin = New System.Windows.Forms.Padding(1)
        Me.tbGender.Name = "tbGender"
        Me.tbGender.ReadOnly = True
        Me.tbGender.Size = New System.Drawing.Size(130, 20)
        Me.tbGender.TabIndex = 21
        '
        'tbAge
        '
        Me.tbAge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Age", True))
        Me.tbAge.Location = New System.Drawing.Point(72, 45)
        Me.tbAge.Margin = New System.Windows.Forms.Padding(1)
        Me.tbAge.Name = "tbAge"
        Me.tbAge.ReadOnly = True
        Me.tbAge.Size = New System.Drawing.Size(130, 20)
        Me.tbAge.TabIndex = 20
        Me.tbAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbStuID
        '
        Me.tbStuID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Student_ID", True))
        Me.tbStuID.Location = New System.Drawing.Point(72, 17)
        Me.tbStuID.Margin = New System.Windows.Forms.Padding(1)
        Me.tbStuID.Name = "tbStuID"
        Me.tbStuID.ReadOnly = True
        Me.tbStuID.Size = New System.Drawing.Size(130, 20)
        Me.tbStuID.TabIndex = 19
        Me.tbStuID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Address: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Phone: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Email: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Age:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Years: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Employer: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-1, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Ethnicity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-1, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Gender: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-1, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student ID:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(455, 323)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Academics"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tbGDDegree
        '
        Me.tbGDDegree.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "G_Degree", True))
        Me.tbGDDegree.Location = New System.Drawing.Point(121, 45)
        Me.tbGDDegree.Margin = New System.Windows.Forms.Padding(1)
        Me.tbGDDegree.Name = "tbGDDegree"
        Me.tbGDDegree.ReadOnly = True
        Me.tbGDDegree.Size = New System.Drawing.Size(142, 20)
        Me.tbGDDegree.TabIndex = 27
        '
        'tbGDInst
        '
        Me.tbGDInst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "GRAD", True))
        Me.tbGDInst.Location = New System.Drawing.Point(121, 17)
        Me.tbGDInst.Margin = New System.Windows.Forms.Padding(1)
        Me.tbGDInst.Name = "tbGDInst"
        Me.tbGDInst.ReadOnly = True
        Me.tbGDInst.Size = New System.Drawing.Size(142, 20)
        Me.tbGDInst.TabIndex = 26
        '
        'tbUGDMajor
        '
        Me.tbUGDMajor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "UDRG_Major", True))
        Me.tbUGDMajor.Location = New System.Drawing.Point(121, 110)
        Me.tbUGDMajor.Margin = New System.Windows.Forms.Padding(1)
        Me.tbUGDMajor.Name = "tbUGDMajor"
        Me.tbUGDMajor.ReadOnly = True
        Me.tbUGDMajor.Size = New System.Drawing.Size(142, 20)
        Me.tbUGDMajor.TabIndex = 25
        '
        'tbUGDDegree
        '
        Me.tbUGDDegree.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "U_Deg", True))
        Me.tbUGDDegree.Location = New System.Drawing.Point(121, 79)
        Me.tbUGDDegree.Margin = New System.Windows.Forms.Padding(1)
        Me.tbUGDDegree.Name = "tbUGDDegree"
        Me.tbUGDDegree.ReadOnly = True
        Me.tbUGDDegree.Size = New System.Drawing.Size(142, 20)
        Me.tbUGDDegree.TabIndex = 24
        '
        'tbUDGGPA
        '
        Me.tbUDGGPA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "U_GPA", True))
        Me.tbUDGGPA.Location = New System.Drawing.Point(121, 46)
        Me.tbUDGGPA.Margin = New System.Windows.Forms.Padding(1)
        Me.tbUDGGPA.Name = "tbUDGGPA"
        Me.tbUDGGPA.ReadOnly = True
        Me.tbUDGGPA.Size = New System.Drawing.Size(142, 20)
        Me.tbUDGGPA.TabIndex = 23
        '
        'tbUDGInst
        '
        Me.tbUDGInst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "U_Inst", True))
        Me.tbUDGInst.Location = New System.Drawing.Point(121, 17)
        Me.tbUDGInst.Margin = New System.Windows.Forms.Padding(1)
        Me.tbUDGInst.Name = "tbUDGInst"
        Me.tbUDGInst.ReadOnly = True
        Me.tbUDGInst.Size = New System.Drawing.Size(142, 20)
        Me.tbUDGInst.TabIndex = 22
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(1, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Graduate Institution: "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(1, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Graduate Degree: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1, 113)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Undergrad Major: "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Undergrad Degree: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Undergrad Institution: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Undergrad GPA: "
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox7)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(455, 323)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Application"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'tbUAEmail
        '
        Me.tbUAEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "UA_Email", True))
        Me.tbUAEmail.Location = New System.Drawing.Point(114, 52)
        Me.tbUAEmail.Margin = New System.Windows.Forms.Padding(1)
        Me.tbUAEmail.Name = "tbUAEmail"
        Me.tbUAEmail.ReadOnly = True
        Me.tbUAEmail.Size = New System.Drawing.Size(142, 20)
        Me.tbUAEmail.TabIndex = 26
        '
        'tbAppId
        '
        Me.tbAppId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Application_ID", True))
        Me.tbAppId.Location = New System.Drawing.Point(114, 20)
        Me.tbAppId.Margin = New System.Windows.Forms.Padding(1)
        Me.tbAppId.Name = "tbAppId"
        Me.tbAppId.ReadOnly = True
        Me.tbAppId.Size = New System.Drawing.Size(142, 20)
        Me.tbAppId.TabIndex = 25
        '
        'tbStudentID
        '
        Me.tbStudentID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Student_ID", True))
        Me.tbStudentID.Location = New System.Drawing.Point(114, 23)
        Me.tbStudentID.Margin = New System.Windows.Forms.Padding(1)
        Me.tbStudentID.Name = "tbStudentID"
        Me.tbStudentID.ReadOnly = True
        Me.tbStudentID.Size = New System.Drawing.Size(142, 20)
        Me.tbStudentID.TabIndex = 24
        '
        'tbAppDate
        '
        Me.tbAppDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "App_Date", True))
        Me.tbAppDate.Location = New System.Drawing.Point(114, 51)
        Me.tbAppDate.Margin = New System.Windows.Forms.Padding(1)
        Me.tbAppDate.Name = "tbAppDate"
        Me.tbAppDate.ReadOnly = True
        Me.tbAppDate.Size = New System.Drawing.Size(142, 20)
        Me.tbAppDate.TabIndex = 23
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(5, 23)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 13)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Application ID: "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(5, 55)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "U of A Email: "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(5, 51)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 13)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Application Date: "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(4, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Student ID:  "
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.tbTOEFL)
        Me.TabPage4.Controls.Add(Me.tbWR)
        Me.TabPage4.Controls.Add(Me.tbVQPct)
        Me.TabPage4.Controls.Add(Me.tbQuanPct)
        Me.TabPage4.Controls.Add(Me.tbQuan)
        Me.TabPage4.Controls.Add(Me.tbVerbPct)
        Me.TabPage4.Controls.Add(Me.tbVerb)
        Me.TabPage4.Controls.Add(Me.tbGMAT)
        Me.TabPage4.Controls.Add(Me.tbEval)
        Me.TabPage4.Controls.Add(Me.tbElac)
        Me.TabPage4.Controls.Add(Me.Label30)
        Me.TabPage4.Controls.Add(Me.Label29)
        Me.TabPage4.Controls.Add(Me.Label28)
        Me.TabPage4.Controls.Add(Me.Label27)
        Me.TabPage4.Controls.Add(Me.Label26)
        Me.TabPage4.Controls.Add(Me.Label25)
        Me.TabPage4.Controls.Add(Me.Label24)
        Me.TabPage4.Controls.Add(Me.Label23)
        Me.TabPage4.Controls.Add(Me.Label22)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(455, 323)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Test Scores"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'tbTOEFL
        '
        Me.tbTOEFL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Toefl", True))
        Me.tbTOEFL.Location = New System.Drawing.Point(72, 234)
        Me.tbTOEFL.Margin = New System.Windows.Forms.Padding(1)
        Me.tbTOEFL.Name = "tbTOEFL"
        Me.tbTOEFL.ReadOnly = True
        Me.tbTOEFL.Size = New System.Drawing.Size(142, 20)
        Me.tbTOEFL.TabIndex = 32
        '
        'tbWR
        '
        Me.tbWR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "WR", True))
        Me.tbWR.Location = New System.Drawing.Point(72, 209)
        Me.tbWR.Margin = New System.Windows.Forms.Padding(1)
        Me.tbWR.Name = "tbWR"
        Me.tbWR.ReadOnly = True
        Me.tbWR.Size = New System.Drawing.Size(142, 20)
        Me.tbWR.TabIndex = 31
        '
        'tbVQPct
        '
        Me.tbVQPct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "V_Q_percent", True))
        Me.tbVQPct.Location = New System.Drawing.Point(72, 184)
        Me.tbVQPct.Margin = New System.Windows.Forms.Padding(1)
        Me.tbVQPct.Name = "tbVQPct"
        Me.tbVQPct.ReadOnly = True
        Me.tbVQPct.Size = New System.Drawing.Size(142, 20)
        Me.tbVQPct.TabIndex = 30
        '
        'tbQuanPct
        '
        Me.tbQuanPct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "GMAT_Q_Percentage", True))
        Me.tbQuanPct.Location = New System.Drawing.Point(72, 159)
        Me.tbQuanPct.Margin = New System.Windows.Forms.Padding(1)
        Me.tbQuanPct.Name = "tbQuanPct"
        Me.tbQuanPct.ReadOnly = True
        Me.tbQuanPct.Size = New System.Drawing.Size(142, 20)
        Me.tbQuanPct.TabIndex = 29
        '
        'tbQuan
        '
        Me.tbQuan.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "GMAT_Quan", True))
        Me.tbQuan.Location = New System.Drawing.Point(72, 134)
        Me.tbQuan.Margin = New System.Windows.Forms.Padding(1)
        Me.tbQuan.Name = "tbQuan"
        Me.tbQuan.ReadOnly = True
        Me.tbQuan.Size = New System.Drawing.Size(142, 20)
        Me.tbQuan.TabIndex = 28
        '
        'tbVerbPct
        '
        Me.tbVerbPct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "GMAT_V_Percentage", True))
        Me.tbVerbPct.Location = New System.Drawing.Point(72, 109)
        Me.tbVerbPct.Margin = New System.Windows.Forms.Padding(1)
        Me.tbVerbPct.Name = "tbVerbPct"
        Me.tbVerbPct.ReadOnly = True
        Me.tbVerbPct.Size = New System.Drawing.Size(142, 20)
        Me.tbVerbPct.TabIndex = 27
        '
        'tbVerb
        '
        Me.tbVerb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "GMAT_Verb", True))
        Me.tbVerb.Location = New System.Drawing.Point(72, 83)
        Me.tbVerb.Margin = New System.Windows.Forms.Padding(1)
        Me.tbVerb.Name = "tbVerb"
        Me.tbVerb.ReadOnly = True
        Me.tbVerb.Size = New System.Drawing.Size(142, 20)
        Me.tbVerb.TabIndex = 26
        '
        'tbGMAT
        '
        Me.tbGMAT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "GMAT", True))
        Me.tbGMAT.Location = New System.Drawing.Point(72, 58)
        Me.tbGMAT.Margin = New System.Windows.Forms.Padding(1)
        Me.tbGMAT.Name = "tbGMAT"
        Me.tbGMAT.ReadOnly = True
        Me.tbGMAT.Size = New System.Drawing.Size(142, 20)
        Me.tbGMAT.TabIndex = 25
        '
        'tbEval
        '
        Me.tbEval.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "Eval_I20", True))
        Me.tbEval.Location = New System.Drawing.Point(72, 8)
        Me.tbEval.Margin = New System.Windows.Forms.Padding(1)
        Me.tbEval.Name = "tbEval"
        Me.tbEval.ReadOnly = True
        Me.tbEval.Size = New System.Drawing.Size(142, 20)
        Me.tbEval.TabIndex = 24
        '
        'tbElac
        '
        Me.tbElac.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApplicationBindingSource, "ELAC_Reg", True))
        Me.tbElac.Location = New System.Drawing.Point(72, 33)
        Me.tbElac.Margin = New System.Windows.Forms.Padding(1)
        Me.tbElac.Name = "tbElac"
        Me.tbElac.ReadOnly = True
        Me.tbElac.Size = New System.Drawing.Size(142, 20)
        Me.tbElac.TabIndex = 23
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(6, 236)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(47, 13)
        Me.Label30.TabIndex = 9
        Me.Label30.Text = "TOEFL: "
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 211)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(32, 13)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "WR: "
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 185)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(36, 13)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "V-Q%:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 160)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(29, 13)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Q%: "
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 110)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(28, 13)
        Me.Label26.TabIndex = 5
        Me.Label26.Text = "V%: "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 135)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(39, 13)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Quan: "
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 85)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(35, 13)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "Verb: "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 60)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 13)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "GMAT: "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 34)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(63, 13)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "ELAC Req: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Eval/ I-20: "
        '
        'tabAdmissions
        '
        Me.tabAdmissions.Controls.Add(Me.GroupBox8)
        Me.tabAdmissions.Controls.Add(Me.btnSubmit)
        Me.tabAdmissions.Location = New System.Drawing.Point(4, 22)
        Me.tabAdmissions.Margin = New System.Windows.Forms.Padding(1)
        Me.tabAdmissions.Name = "tabAdmissions"
        Me.tabAdmissions.Padding = New System.Windows.Forms.Padding(1)
        Me.tabAdmissions.Size = New System.Drawing.Size(455, 323)
        Me.tabAdmissions.TabIndex = 4
        Me.tabAdmissions.Text = "Admissions"
        Me.tabAdmissions.UseVisualStyleBackColor = True
        '
        'tbConcentration
        '
        Me.tbConcentration.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProgramRequirementBindingSource, "Concentration", True))
        Me.tbConcentration.Location = New System.Drawing.Point(106, 38)
        Me.tbConcentration.Margin = New System.Windows.Forms.Padding(1)
        Me.tbConcentration.Name = "tbConcentration"
        Me.tbConcentration.ReadOnly = True
        Me.tbConcentration.Size = New System.Drawing.Size(117, 20)
        Me.tbConcentration.TabIndex = 27
        '
        'ProgramRequirementBindingSource
        '
        Me.ProgramRequirementBindingSource.DataMember = "Program_Requirement"
        Me.ProgramRequirementBindingSource.DataSource = Me.ProjectS1747DataSet1
        '
        'tbProgram
        '
        Me.tbProgram.Location = New System.Drawing.Point(106, 9)
        Me.tbProgram.Margin = New System.Windows.Forms.Padding(1)
        Me.tbProgram.Name = "tbProgram"
        Me.tbProgram.ReadOnly = True
        Me.tbProgram.Size = New System.Drawing.Size(117, 20)
        Me.tbProgram.TabIndex = 26
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(1, 39)
        Me.Label31.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(76, 13)
        Me.Label31.TabIndex = 6
        Me.Label31.Text = "Concentration:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1, 9)
        Me.Label12.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Program:"
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.Location = New System.Drawing.Point(1, 101)
        Me.lblResponse.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(58, 13)
        Me.lblResponse.TabIndex = 4
        Me.lblResponse.Text = "Response:"
        '
        'tbResponse
        '
        Me.tbResponse.Location = New System.Drawing.Point(106, 99)
        Me.tbResponse.Margin = New System.Windows.Forms.Padding(1)
        Me.tbResponse.Name = "tbResponse"
        Me.tbResponse.ReadOnly = True
        Me.tbResponse.Size = New System.Drawing.Size(117, 20)
        Me.tbResponse.TabIndex = 3
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(269, 123)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(50, 20)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(1, 70)
        Me.Label42.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(101, 13)
        Me.Label42.TabIndex = 1
        Me.Label42.Text = "Admission Decision:"
        '
        'cbDecision
        '
        Me.cbDecision.FormattingEnabled = True
        Me.cbDecision.Location = New System.Drawing.Point(106, 69)
        Me.cbDecision.Margin = New System.Windows.Forms.Padding(1)
        Me.cbDecision.Name = "cbDecision"
        Me.cbDecision.Size = New System.Drawing.Size(117, 21)
        Me.cbDecision.TabIndex = 0
        '
        'lblStuName
        '
        Me.lblStuName.AutoSize = True
        Me.lblStuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStuName.Location = New System.Drawing.Point(93, 32)
        Me.lblStuName.Name = "lblStuName"
        Me.lblStuName.Size = New System.Drawing.Size(96, 13)
        Me.lblStuName.TabIndex = 2
        Me.lblStuName.Text = "Applicant Name"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(3, 32)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(88, 13)
        Me.Label41.TabIndex = 5
        Me.Label41.Text = "Applicant Name: "
        '
        'Label_ProgramType
        '
        Me.Label_ProgramType.AutoSize = True
        Me.Label_ProgramType.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ProgramType.Location = New System.Drawing.Point(307, 21)
        Me.Label_ProgramType.Name = "Label_ProgramType"
        Me.Label_ProgramType.Size = New System.Drawing.Size(0, 16)
        Me.Label_ProgramType.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(2, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(481, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuEditRecommendation, Me.menuEditInterview})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'menuEditRecommendation
        '
        Me.menuEditRecommendation.Name = "menuEditRecommendation"
        Me.menuEditRecommendation.Size = New System.Drawing.Size(237, 22)
        Me.menuEditRecommendation.Text = "Add/Update Recommendation"
        '
        'menuEditInterview
        '
        Me.menuEditInterview.Name = "menuEditInterview"
        Me.menuEditInterview.Size = New System.Drawing.Size(237, 22)
        Me.menuEditInterview.Text = "Add/Update Interview"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuViewRecommendations, Me.menuViewInterview})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'menuViewRecommendations
        '
        Me.menuViewRecommendations.Name = "menuViewRecommendations"
        Me.menuViewRecommendations.Size = New System.Drawing.Size(174, 22)
        Me.menuViewRecommendations.Text = "Recommendations"
        '
        'menuViewInterview
        '
        Me.menuViewInterview.Name = "menuViewInterview"
        Me.menuViewInterview.Size = New System.Drawing.Size(174, 22)
        Me.menuViewInterview.Text = "Interview"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(381, 417)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(51, 21)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ApplicationTableAdapter
        '
        Me.ApplicationTableAdapter.ClearBeforeFill = True
        '
        'Program_RequirementTableAdapter
        '
        Me.Program_RequirementTableAdapter.ClearBeforeFill = True
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram.Location = New System.Drawing.Point(276, 32)
        Me.lblProgram.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(0, 13)
        Me.lblProgram.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbEthnicity)
        Me.GroupBox1.Controls.Add(Me.tbGender)
        Me.GroupBox1.Controls.Add(Me.tbAge)
        Me.GroupBox1.Controls.Add(Me.tbStuID)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 137)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbYears)
        Me.GroupBox2.Controls.Add(Me.tbEmployer)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 162)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 76)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Experience"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbAddress)
        Me.GroupBox3.Controls.Add(Me.tbPhone)
        Me.GroupBox3.Controls.Add(Me.tbEmail)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(238, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(211, 117)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contact"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbUGDMajor)
        Me.GroupBox4.Controls.Add(Me.tbUGDDegree)
        Me.GroupBox4.Controls.Add(Me.tbUDGGPA)
        Me.GroupBox4.Controls.Add(Me.tbUDGInst)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(279, 145)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Undergrad"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.tbGDDegree)
        Me.GroupBox5.Controls.Add(Me.tbGDInst)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Location = New System.Drawing.Point(5, 162)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(278, 81)
        Me.GroupBox5.TabIndex = 29
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Graduate"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.tbAppId)
        Me.GroupBox6.Controls.Add(Me.tbAppDate)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Location = New System.Drawing.Point(10, 15)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(269, 88)
        Me.GroupBox6.TabIndex = 27
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Application"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.tbUAEmail)
        Me.GroupBox7.Controls.Add(Me.tbStudentID)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Location = New System.Drawing.Point(10, 118)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(269, 86)
        Me.GroupBox7.TabIndex = 28
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Student"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.tbConcentration)
        Me.GroupBox8.Controls.Add(Me.tbProgram)
        Me.GroupBox8.Controls.Add(Me.Label31)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Controls.Add(Me.lblResponse)
        Me.GroupBox8.Controls.Add(Me.tbResponse)
        Me.GroupBox8.Controls.Add(Me.Label42)
        Me.GroupBox8.Controls.Add(Me.cbDecision)
        Me.GroupBox8.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(242, 133)
        Me.GroupBox8.TabIndex = 28
        Me.GroupBox8.TabStop = False
        '
        'ApplicantProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(481, 448)
        Me.Controls.Add(Me.lblProgram)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label_ProgramType)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.lblStuName)
        Me.Controls.Add(Me.PersonalTabPage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ApplicantProfile"
        Me.Text = "Applicant Profile"
        Me.PersonalTabPage.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.ApplicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectS1747DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.tabAdmissions.ResumeLayout(False)
        CType(Me.ProgramRequirementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PersonalTabPage As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents lblStuName As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label_ProgramType As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuEditRecommendation As ToolStripMenuItem
    Friend WithEvents menuEditInterview As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuViewRecommendations As ToolStripMenuItem
    Friend WithEvents menuViewInterview As ToolStripMenuItem
    Friend WithEvents tabAdmissions As TabPage
    Friend WithEvents Label42 As Label
    Friend WithEvents cbDecision As ComboBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblResponse As Label
    Friend WithEvents tbResponse As TextBox
    Friend WithEvents tbStuID As TextBox
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents tbPhone As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents tbYears As TextBox
    Friend WithEvents tbEmployer As TextBox
    Friend WithEvents tbEthnicity As TextBox
    Friend WithEvents tbGender As TextBox
    Friend WithEvents tbAge As TextBox
    Friend WithEvents tbGDDegree As TextBox
    Friend WithEvents tbGDInst As TextBox
    Friend WithEvents tbUGDMajor As TextBox
    Friend WithEvents tbUGDDegree As TextBox
    Friend WithEvents tbUDGGPA As TextBox
    Friend WithEvents tbUDGInst As TextBox
    Friend WithEvents tbUAEmail As TextBox
    Friend WithEvents tbAppId As TextBox
    Friend WithEvents tbStudentID As TextBox
    Friend WithEvents tbAppDate As TextBox
    Friend WithEvents tbTOEFL As TextBox
    Friend WithEvents tbWR As TextBox
    Friend WithEvents tbVQPct As TextBox
    Friend WithEvents tbQuanPct As TextBox
    Friend WithEvents tbQuan As TextBox
    Friend WithEvents tbVerbPct As TextBox
    Friend WithEvents tbVerb As TextBox
    Friend WithEvents tbGMAT As TextBox
    Friend WithEvents tbEval As TextBox
    Friend WithEvents tbElac As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents ProjectS1747DataSet1 As PROJECTS1747DataSet
    Friend WithEvents ApplicationBindingSource As BindingSource
    Friend WithEvents ApplicationTableAdapter As PROJECTS1747DataSetTableAdapters.ApplicationTableAdapter
    Friend WithEvents tbConcentration As TextBox
    Friend WithEvents tbProgram As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ProgramRequirementBindingSource As BindingSource
    Friend WithEvents Program_RequirementTableAdapter As PROJECTS1747DataSetTableAdapters.Program_RequirementTableAdapter
    Friend WithEvents lblProgram As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
End Class
