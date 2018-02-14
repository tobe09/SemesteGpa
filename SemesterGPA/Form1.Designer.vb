<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.lblMsgLogin = New System.Windows.Forms.Label()
        Me.tbxYearLogin = New System.Windows.Forms.TextBox()
        Me.tbxOtherNameLogin = New System.Windows.Forms.TextBox()
        Me.tbxFacultyLogin = New System.Windows.Forms.TextBox()
        Me.tbxMatNoLogin = New System.Windows.Forms.TextBox()
        Me.tbxDeptLogin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSubmitLogin = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxSurnameLogin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.lblMsgMain = New System.Windows.Forms.Label()
        Me.btnCalcMain = New System.Windows.Forms.Button()
        Me.btnLogoutMain = New System.Windows.Forms.Button()
        Me.btnRemoveMain = New System.Windows.Forms.Button()
        Me.btnAddMain = New System.Windows.Forms.Button()
        Me.PanelResult = New System.Windows.Forms.Panel()
        Me.lblClassDivResult = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblGpaResult = New System.Windows.Forms.Label()
        Me.lblUnitsResult = New System.Windows.Forms.Label()
        Me.lblGradeUnitsResult = New System.Windows.Forms.Label()
        Me.btnOkResult = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lvwCourses = New System.Windows.Forms.ListView()
        Me.sn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.units = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.score = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grades = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblCoursesMain = New System.Windows.Forms.Label()
        Me.lblYearMain = New System.Windows.Forms.Label()
        Me.lblFacultyMain = New System.Windows.Forms.Label()
        Me.lblDeptMain = New System.Windows.Forms.Label()
        Me.lblMatNoMain = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNameMain = New System.Windows.Forms.Label()
        Me.PanelAdd = New System.Windows.Forms.Panel()
        Me.btnCancelAdd = New System.Windows.Forms.Button()
        Me.lblMsgAdd = New System.Windows.Forms.Label()
        Me.btnAddCourseAdd = New System.Windows.Forms.Button()
        Me.tbxScoreAdd = New System.Windows.Forms.TextBox()
        Me.tbxUnitsAdd = New System.Windows.Forms.TextBox()
        Me.tbxCourseTitleAdd = New System.Windows.Forms.TextBox()
        Me.tbxCourseCodeAdd = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PanelParent = New System.Windows.Forms.Panel()
        Me.PanelLogin.SuspendLayout()
        Me.PanelMain.SuspendLayout()
        Me.PanelResult.SuspendLayout()
        Me.PanelAdd.SuspendLayout()
        Me.PanelParent.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLogin
        '
        Me.PanelLogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelLogin.Controls.Add(Me.lblMsgLogin)
        Me.PanelLogin.Controls.Add(Me.tbxYearLogin)
        Me.PanelLogin.Controls.Add(Me.tbxOtherNameLogin)
        Me.PanelLogin.Controls.Add(Me.tbxFacultyLogin)
        Me.PanelLogin.Controls.Add(Me.tbxMatNoLogin)
        Me.PanelLogin.Controls.Add(Me.tbxDeptLogin)
        Me.PanelLogin.Controls.Add(Me.Label7)
        Me.PanelLogin.Controls.Add(Me.btnSubmitLogin)
        Me.PanelLogin.Controls.Add(Me.Label6)
        Me.PanelLogin.Controls.Add(Me.Label5)
        Me.PanelLogin.Controls.Add(Me.Label4)
        Me.PanelLogin.Controls.Add(Me.Label3)
        Me.PanelLogin.Controls.Add(Me.Label2)
        Me.PanelLogin.Controls.Add(Me.tbxSurnameLogin)
        Me.PanelLogin.Controls.Add(Me.Label1)
        Me.PanelLogin.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(596, 476)
        Me.PanelLogin.TabIndex = 0
        '
        'lblMsgLogin
        '
        Me.lblMsgLogin.AutoSize = True
        Me.lblMsgLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgLogin.ForeColor = System.Drawing.Color.DarkRed
        Me.lblMsgLogin.Location = New System.Drawing.Point(265, 41)
        Me.lblMsgLogin.Name = "lblMsgLogin"
        Me.lblMsgLogin.Size = New System.Drawing.Size(0, 20)
        Me.lblMsgLogin.TabIndex = 14
        '
        'tbxYearLogin
        '
        Me.tbxYearLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxYearLogin.Location = New System.Drawing.Point(267, 325)
        Me.tbxYearLogin.Name = "tbxYearLogin"
        Me.tbxYearLogin.Size = New System.Drawing.Size(243, 26)
        Me.tbxYearLogin.TabIndex = 13
        '
        'tbxOtherNameLogin
        '
        Me.tbxOtherNameLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOtherNameLogin.Location = New System.Drawing.Point(267, 155)
        Me.tbxOtherNameLogin.Name = "tbxOtherNameLogin"
        Me.tbxOtherNameLogin.Size = New System.Drawing.Size(243, 26)
        Me.tbxOtherNameLogin.TabIndex = 12
        '
        'tbxFacultyLogin
        '
        Me.tbxFacultyLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxFacultyLogin.Location = New System.Drawing.Point(267, 201)
        Me.tbxFacultyLogin.Name = "tbxFacultyLogin"
        Me.tbxFacultyLogin.Size = New System.Drawing.Size(243, 26)
        Me.tbxFacultyLogin.TabIndex = 11
        '
        'tbxMatNoLogin
        '
        Me.tbxMatNoLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMatNoLogin.Location = New System.Drawing.Point(267, 284)
        Me.tbxMatNoLogin.Name = "tbxMatNoLogin"
        Me.tbxMatNoLogin.Size = New System.Drawing.Size(243, 26)
        Me.tbxMatNoLogin.TabIndex = 10
        '
        'tbxDeptLogin
        '
        Me.tbxDeptLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxDeptLogin.Location = New System.Drawing.Point(267, 240)
        Me.tbxDeptLogin.Name = "tbxDeptLogin"
        Me.tbxDeptLogin.Size = New System.Drawing.Size(243, 26)
        Me.tbxDeptLogin.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(57, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(10)
        Me.Label7.Size = New System.Drawing.Size(164, 45)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "LOGIN FORM"
        '
        'btnSubmitLogin
        '
        Me.btnSubmitLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSubmitLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSubmitLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitLogin.ForeColor = System.Drawing.Color.Black
        Me.btnSubmitLogin.Location = New System.Drawing.Point(334, 385)
        Me.btnSubmitLogin.Name = "btnSubmitLogin"
        Me.btnSubmitLogin.Size = New System.Drawing.Size(120, 39)
        Me.btnSubmitLogin.TabIndex = 7
        Me.btnSubmitLogin.Text = "Submit"
        Me.btnSubmitLogin.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Matric. Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Faculty"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Other Name(s)"
        '
        'tbxSurnameLogin
        '
        Me.tbxSurnameLogin.BackColor = System.Drawing.SystemColors.Window
        Me.tbxSurnameLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSurnameLogin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbxSurnameLogin.Location = New System.Drawing.Point(267, 110)
        Me.tbxSurnameLogin.Name = "tbxSurnameLogin"
        Me.tbxSurnameLogin.Size = New System.Drawing.Size(243, 26)
        Me.tbxSurnameLogin.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Surname"
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelMain.Controls.Add(Me.lblMsgMain)
        Me.PanelMain.Controls.Add(Me.btnCalcMain)
        Me.PanelMain.Controls.Add(Me.btnLogoutMain)
        Me.PanelMain.Controls.Add(Me.btnRemoveMain)
        Me.PanelMain.Controls.Add(Me.btnAddMain)
        Me.PanelMain.Controls.Add(Me.PanelResult)
        Me.PanelMain.Controls.Add(Me.Label8)
        Me.PanelMain.Controls.Add(Me.lvwCourses)
        Me.PanelMain.Controls.Add(Me.lblCoursesMain)
        Me.PanelMain.Controls.Add(Me.lblYearMain)
        Me.PanelMain.Controls.Add(Me.lblFacultyMain)
        Me.PanelMain.Controls.Add(Me.lblDeptMain)
        Me.PanelMain.Controls.Add(Me.lblMatNoMain)
        Me.PanelMain.Controls.Add(Me.Label12)
        Me.PanelMain.Controls.Add(Me.Label11)
        Me.PanelMain.Controls.Add(Me.Label10)
        Me.PanelMain.Controls.Add(Me.Label9)
        Me.PanelMain.Controls.Add(Me.lblNameMain)
        Me.PanelMain.Location = New System.Drawing.Point(8, 3)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(571, 730)
        Me.PanelMain.TabIndex = 1
        Me.PanelMain.Visible = False
        '
        'lblMsgMain
        '
        Me.lblMsgMain.AutoSize = True
        Me.lblMsgMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgMain.ForeColor = System.Drawing.Color.Maroon
        Me.lblMsgMain.Location = New System.Drawing.Point(255, 185)
        Me.lblMsgMain.Name = "lblMsgMain"
        Me.lblMsgMain.Size = New System.Drawing.Size(0, 16)
        Me.lblMsgMain.TabIndex = 17
        '
        'btnCalcMain
        '
        Me.btnCalcMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCalcMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcMain.ForeColor = System.Drawing.Color.Black
        Me.btnCalcMain.Location = New System.Drawing.Point(237, 479)
        Me.btnCalcMain.Name = "btnCalcMain"
        Me.btnCalcMain.Size = New System.Drawing.Size(154, 37)
        Me.btnCalcMain.TabIndex = 16
        Me.btnCalcMain.Text = "Calculate"
        Me.btnCalcMain.UseVisualStyleBackColor = False
        '
        'btnLogoutMain
        '
        Me.btnLogoutMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnLogoutMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLogoutMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogoutMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogoutMain.Location = New System.Drawing.Point(482, 12)
        Me.btnLogoutMain.Name = "btnLogoutMain"
        Me.btnLogoutMain.Size = New System.Drawing.Size(75, 26)
        Me.btnLogoutMain.TabIndex = 15
        Me.btnLogoutMain.Text = "LogOut"
        Me.btnLogoutMain.UseVisualStyleBackColor = False
        '
        'btnRemoveMain
        '
        Me.btnRemoveMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveMain.Location = New System.Drawing.Point(470, 431)
        Me.btnRemoveMain.Name = "btnRemoveMain"
        Me.btnRemoveMain.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveMain.TabIndex = 14
        Me.btnRemoveMain.Text = "Remove"
        Me.btnRemoveMain.UseVisualStyleBackColor = True
        Me.btnRemoveMain.Visible = False
        '
        'btnAddMain
        '
        Me.btnAddMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMain.Location = New System.Drawing.Point(36, 431)
        Me.btnAddMain.Name = "btnAddMain"
        Me.btnAddMain.Size = New System.Drawing.Size(75, 23)
        Me.btnAddMain.TabIndex = 13
        Me.btnAddMain.Text = "Add"
        Me.btnAddMain.UseVisualStyleBackColor = True
        '
        'PanelResult
        '
        Me.PanelResult.Controls.Add(Me.lblClassDivResult)
        Me.PanelResult.Controls.Add(Me.Label16)
        Me.PanelResult.Controls.Add(Me.Label15)
        Me.PanelResult.Controls.Add(Me.Label14)
        Me.PanelResult.Controls.Add(Me.lblGpaResult)
        Me.PanelResult.Controls.Add(Me.lblUnitsResult)
        Me.PanelResult.Controls.Add(Me.lblGradeUnitsResult)
        Me.PanelResult.Controls.Add(Me.btnOkResult)
        Me.PanelResult.Controls.Add(Me.Label13)
        Me.PanelResult.Location = New System.Drawing.Point(33, 544)
        Me.PanelResult.Name = "PanelResult"
        Me.PanelResult.Size = New System.Drawing.Size(512, 184)
        Me.PanelResult.TabIndex = 12
        Me.PanelResult.Visible = False
        '
        'lblClassDivResult
        '
        Me.lblClassDivResult.AutoSize = True
        Me.lblClassDivResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassDivResult.ForeColor = System.Drawing.Color.Blue
        Me.lblClassDivResult.Location = New System.Drawing.Point(22, 141)
        Me.lblClassDivResult.Name = "lblClassDivResult"
        Me.lblClassDivResult.Size = New System.Drawing.Size(179, 24)
        Me.lblClassDivResult.TabIndex = 18
        Me.lblClassDivResult.Text = "Class Division Value"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(22, 108)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(158, 24)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Semester GPA: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(23, 77)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 18)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Total Units: "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(23, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(151, 18)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Total Grade Units: "
        '
        'lblGpaResult
        '
        Me.lblGpaResult.AutoSize = True
        Me.lblGpaResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGpaResult.Location = New System.Drawing.Point(249, 106)
        Me.lblGpaResult.Name = "lblGpaResult"
        Me.lblGpaResult.Size = New System.Drawing.Size(64, 24)
        Me.lblGpaResult.TabIndex = 14
        Me.lblGpaResult.Text = "Value"
        '
        'lblUnitsResult
        '
        Me.lblUnitsResult.AutoSize = True
        Me.lblUnitsResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitsResult.Location = New System.Drawing.Point(250, 77)
        Me.lblUnitsResult.Name = "lblUnitsResult"
        Me.lblUnitsResult.Size = New System.Drawing.Size(49, 18)
        Me.lblUnitsResult.TabIndex = 13
        Me.lblUnitsResult.Text = "Value"
        '
        'lblGradeUnitsResult
        '
        Me.lblGradeUnitsResult.AutoSize = True
        Me.lblGradeUnitsResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeUnitsResult.Location = New System.Drawing.Point(250, 53)
        Me.lblGradeUnitsResult.Name = "lblGradeUnitsResult"
        Me.lblGradeUnitsResult.Size = New System.Drawing.Size(49, 18)
        Me.lblGradeUnitsResult.TabIndex = 12
        Me.lblGradeUnitsResult.Text = "Value"
        '
        'btnOkResult
        '
        Me.btnOkResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkResult.Location = New System.Drawing.Point(419, 144)
        Me.btnOkResult.Name = "btnOkResult"
        Me.btnOkResult.Size = New System.Drawing.Size(75, 23)
        Me.btnOkResult.TabIndex = 11
        Me.btnOkResult.Text = "OK"
        Me.btnOkResult.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(24, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.Label13.Size = New System.Drawing.Size(119, 34)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "RESULT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(215, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(204, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "(Add Registered Courses Below)"
        '
        'lvwCourses
        '
        Me.lvwCourses.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.sn, Me.code, Me.title, Me.units, Me.score, Me.grades})
        Me.lvwCourses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwCourses.FullRowSelect = True
        Me.lvwCourses.GridLines = True
        Me.lvwCourses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCourses.Location = New System.Drawing.Point(33, 231)
        Me.lvwCourses.Name = "lvwCourses"
        Me.lvwCourses.Size = New System.Drawing.Size(524, 189)
        Me.lvwCourses.TabIndex = 10
        Me.lvwCourses.UseCompatibleStateImageBehavior = False
        Me.lvwCourses.View = System.Windows.Forms.View.Details
        '
        'sn
        '
        Me.sn.Text = "S/N"
        Me.sn.Width = 40
        '
        'code
        '
        Me.code.Text = "Code"
        Me.code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.code.Width = 72
        '
        'title
        '
        Me.title.Text = "Title"
        Me.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.title.Width = 248
        '
        'units
        '
        Me.units.Text = "Unit(s)"
        Me.units.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.units.Width = 52
        '
        'score
        '
        Me.score.Text = "Score"
        Me.score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.score.Width = 53
        '
        'grades
        '
        Me.grades.Text = "Grade"
        Me.grades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.grades.Width = 54
        '
        'lblCoursesMain
        '
        Me.lblCoursesMain.AutoSize = True
        Me.lblCoursesMain.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lblCoursesMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoursesMain.ForeColor = System.Drawing.Color.White
        Me.lblCoursesMain.Location = New System.Drawing.Point(31, 194)
        Me.lblCoursesMain.Name = "lblCoursesMain"
        Me.lblCoursesMain.Padding = New System.Windows.Forms.Padding(5)
        Me.lblCoursesMain.Size = New System.Drawing.Size(89, 30)
        Me.lblCoursesMain.TabIndex = 9
        Me.lblCoursesMain.Text = "Courses"
        '
        'lblYearMain
        '
        Me.lblYearMain.AutoSize = True
        Me.lblYearMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearMain.Location = New System.Drawing.Point(479, 70)
        Me.lblYearMain.Name = "lblYearMain"
        Me.lblYearMain.Size = New System.Drawing.Size(56, 16)
        Me.lblYearMain.TabIndex = 8
        Me.lblYearMain.Text = "Label13"
        '
        'lblFacultyMain
        '
        Me.lblFacultyMain.AutoSize = True
        Me.lblFacultyMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacultyMain.Location = New System.Drawing.Point(141, 90)
        Me.lblFacultyMain.Name = "lblFacultyMain"
        Me.lblFacultyMain.Size = New System.Drawing.Size(56, 16)
        Me.lblFacultyMain.TabIndex = 7
        Me.lblFacultyMain.Text = "Label13"
        '
        'lblDeptMain
        '
        Me.lblDeptMain.AutoSize = True
        Me.lblDeptMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeptMain.Location = New System.Drawing.Point(141, 110)
        Me.lblDeptMain.Name = "lblDeptMain"
        Me.lblDeptMain.Size = New System.Drawing.Size(56, 16)
        Me.lblDeptMain.TabIndex = 6
        Me.lblDeptMain.Text = "Label13"
        '
        'lblMatNoMain
        '
        Me.lblMatNoMain.AutoSize = True
        Me.lblMatNoMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatNoMain.Location = New System.Drawing.Point(141, 70)
        Me.lblMatNoMain.Name = "lblMatNoMain"
        Me.lblMatNoMain.Size = New System.Drawing.Size(56, 16)
        Me.lblMatNoMain.TabIndex = 5
        Me.lblMatNoMain.Text = "Label13"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(30, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Department: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(399, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 16)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Year: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 16)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Faculty: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 16)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Matric. No: "
        '
        'lblNameMain
        '
        Me.lblNameMain.AutoSize = True
        Me.lblNameMain.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lblNameMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameMain.ForeColor = System.Drawing.Color.White
        Me.lblNameMain.Location = New System.Drawing.Point(32, 9)
        Me.lblNameMain.Name = "lblNameMain"
        Me.lblNameMain.Padding = New System.Windows.Forms.Padding(5)
        Me.lblNameMain.Size = New System.Drawing.Size(101, 34)
        Me.lblNameMain.TabIndex = 0
        Me.lblNameMain.Text = "Welcome"
        '
        'PanelAdd
        '
        Me.PanelAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelAdd.Controls.Add(Me.btnCancelAdd)
        Me.PanelAdd.Controls.Add(Me.lblMsgAdd)
        Me.PanelAdd.Controls.Add(Me.btnAddCourseAdd)
        Me.PanelAdd.Controls.Add(Me.tbxScoreAdd)
        Me.PanelAdd.Controls.Add(Me.tbxUnitsAdd)
        Me.PanelAdd.Controls.Add(Me.tbxCourseTitleAdd)
        Me.PanelAdd.Controls.Add(Me.tbxCourseCodeAdd)
        Me.PanelAdd.Controls.Add(Me.Label21)
        Me.PanelAdd.Controls.Add(Me.Label20)
        Me.PanelAdd.Controls.Add(Me.Label19)
        Me.PanelAdd.Controls.Add(Me.Label18)
        Me.PanelAdd.Controls.Add(Me.Label17)
        Me.PanelAdd.Location = New System.Drawing.Point(0, 0)
        Me.PanelAdd.Name = "PanelAdd"
        Me.PanelAdd.Size = New System.Drawing.Size(593, 283)
        Me.PanelAdd.TabIndex = 2
        Me.PanelAdd.Visible = False
        '
        'btnCancelAdd
        '
        Me.btnCancelAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelAdd.Location = New System.Drawing.Point(55, 237)
        Me.btnCancelAdd.Name = "btnCancelAdd"
        Me.btnCancelAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelAdd.TabIndex = 26
        Me.btnCancelAdd.Text = "Cancel"
        Me.btnCancelAdd.UseVisualStyleBackColor = True
        '
        'lblMsgAdd
        '
        Me.lblMsgAdd.AutoSize = True
        Me.lblMsgAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgAdd.ForeColor = System.Drawing.Color.Maroon
        Me.lblMsgAdd.Location = New System.Drawing.Point(307, 42)
        Me.lblMsgAdd.Name = "lblMsgAdd"
        Me.lblMsgAdd.Size = New System.Drawing.Size(0, 16)
        Me.lblMsgAdd.TabIndex = 25
        '
        'btnAddCourseAdd
        '
        Me.btnAddCourseAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCourseAdd.Location = New System.Drawing.Point(296, 233)
        Me.btnAddCourseAdd.Name = "btnAddCourseAdd"
        Me.btnAddCourseAdd.Size = New System.Drawing.Size(149, 30)
        Me.btnAddCourseAdd.TabIndex = 24
        Me.btnAddCourseAdd.Text = "Add Course"
        Me.btnAddCourseAdd.UseVisualStyleBackColor = True
        '
        'tbxScoreAdd
        '
        Me.tbxScoreAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxScoreAdd.Location = New System.Drawing.Point(252, 180)
        Me.tbxScoreAdd.Name = "tbxScoreAdd"
        Me.tbxScoreAdd.Size = New System.Drawing.Size(243, 26)
        Me.tbxScoreAdd.TabIndex = 23
        '
        'tbxUnitsAdd
        '
        Me.tbxUnitsAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUnitsAdd.Location = New System.Drawing.Point(252, 147)
        Me.tbxUnitsAdd.Name = "tbxUnitsAdd"
        Me.tbxUnitsAdd.Size = New System.Drawing.Size(243, 26)
        Me.tbxUnitsAdd.TabIndex = 22
        '
        'tbxCourseTitleAdd
        '
        Me.tbxCourseTitleAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCourseTitleAdd.Location = New System.Drawing.Point(252, 115)
        Me.tbxCourseTitleAdd.Name = "tbxCourseTitleAdd"
        Me.tbxCourseTitleAdd.Size = New System.Drawing.Size(243, 26)
        Me.tbxCourseTitleAdd.TabIndex = 21
        '
        'tbxCourseCodeAdd
        '
        Me.tbxCourseCodeAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCourseCodeAdd.Location = New System.Drawing.Point(252, 82)
        Me.tbxCourseCodeAdd.Name = "tbxCourseCodeAdd"
        Me.tbxCourseCodeAdd.Size = New System.Drawing.Size(243, 26)
        Me.tbxCourseCodeAdd.TabIndex = 20
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(35, 188)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(143, 18)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "Percentage Score"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(35, 123)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 18)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Course Title"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(35, 155)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(143, 18)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Number of Unit(s)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(35, 90)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(108, 18)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Course Code"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(35, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Padding = New System.Windows.Forms.Padding(5)
        Me.Label17.Size = New System.Drawing.Size(230, 30)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Enter Course Information"
        '
        'PanelParent
        '
        Me.PanelParent.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelParent.Controls.Add(Me.PanelAdd)
        Me.PanelParent.Controls.Add(Me.PanelLogin)
        Me.PanelParent.Controls.Add(Me.PanelMain)
        Me.PanelParent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelParent.Location = New System.Drawing.Point(0, 0)
        Me.PanelParent.Name = "PanelParent"
        Me.PanelParent.Size = New System.Drawing.Size(599, 752)
        Me.PanelParent.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 752)
        Me.Controls.Add(Me.PanelParent)
        Me.Name = "Form1"
        Me.Text = "Semester GPA"
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.PanelResult.ResumeLayout(False)
        Me.PanelResult.PerformLayout()
        Me.PanelAdd.ResumeLayout(False)
        Me.PanelAdd.PerformLayout()
        Me.PanelParent.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLogin As Panel
    Friend WithEvents PanelMain As Panel
    Friend WithEvents PanelAdd As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxSurnameLogin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxYearLogin As TextBox
    Friend WithEvents tbxOtherNameLogin As TextBox
    Friend WithEvents tbxFacultyLogin As TextBox
    Friend WithEvents tbxMatNoLogin As TextBox
    Friend WithEvents tbxDeptLogin As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSubmitLogin As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalcMain As Button
    Friend WithEvents btnLogoutMain As Button
    Friend WithEvents btnRemoveMain As Button
    Friend WithEvents btnAddMain As Button
    Friend WithEvents PanelResult As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblGpaResult As Label
    Friend WithEvents lblUnitsResult As Label
    Friend WithEvents lblGradeUnitsResult As Label
    Friend WithEvents btnOkResult As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lvwCourses As ListView
    Friend WithEvents lblCoursesMain As Label
    Friend WithEvents lblYearMain As Label
    Friend WithEvents lblFacultyMain As Label
    Friend WithEvents lblDeptMain As Label
    Friend WithEvents lblMatNoMain As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblNameMain As Label
    Friend WithEvents lblClassDivResult As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnAddCourseAdd As Button
    Friend WithEvents tbxScoreAdd As TextBox
    Friend WithEvents tbxUnitsAdd As TextBox
    Friend WithEvents tbxCourseTitleAdd As TextBox
    Friend WithEvents tbxCourseCodeAdd As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblMsgLogin As Label
    Friend WithEvents lblMsgMain As Label
    Friend WithEvents lblMsgAdd As Label
    Friend WithEvents sn As ColumnHeader
    Friend WithEvents code As ColumnHeader
    Friend WithEvents title As ColumnHeader
    Friend WithEvents units As ColumnHeader
    Friend WithEvents score As ColumnHeader
    Friend WithEvents grades As ColumnHeader
    Friend WithEvents btnCancelAdd As Button
    Friend WithEvents PanelParent As Panel
End Class
