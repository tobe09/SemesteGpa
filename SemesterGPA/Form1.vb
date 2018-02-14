Public Class Form1

    'function resize the form when form loads loads to fit the login panel
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetFormSize("login")            'resize to fit login panel
    End Sub

    'function to set the size of the form according to the panel size
    Private Sub SetFormSize(panelName As String)
        Select Case panelName.ToLower()
            Case "login"
                Size = New Size(600, 500)
            Case "main"
                Size = New Size(620, 600)
            Case "add"
                Size = New Size(550, 330)
            Case "result"
                Size = New Size(620, 780)
            Case Else
                Size = New Size(620, 780)
        End Select
    End Sub

    'function to hide all panels in the form
    Private Sub HideAllPanels()
        PanelLogin.Visible = False      'panel that holds the login information
        PanelMain.Visible = False       'panel that holds the main information
        PanelAdd.Visible = False        'panel that holds controls for adding courses
        PanelResult.Visible = False     'panels that displays results of GPA computation
    End Sub

    'to clear all information in all panels
    Public Sub ClearAll()
        ClearLogin()            'to clear login panel 
        ClearMain()             'to clear main panel 
        ClearAdd()              'to clear add course panel 
        ClearResult()           'to clear result panel 
    End Sub

    'function to clear the login panel input controls
    Public Sub ClearLogin()
        lblMsgLogin.Text = ""
        tbxSurnameLogin.Clear()
        tbxOtherNameLogin.Clear()
        tbxFacultyLogin.Clear()
        tbxDeptLogin.Clear()
        tbxMatNoLogin.Clear()
        tbxYearLogin.Clear()
    End Sub

    'function to clear the main panel input controls
    Public Sub ClearMain()
        lblMsgMain.Text = ""
        lblNameMain.Text = ""
        lblFacultyMain.Text = ""
        lblDeptMain.Text = ""
        lblMatNoMain.Text = ""
        lblYearMain.Text = ""
    End Sub

    'function to clear the add course panel input controls
    Public Sub ClearAdd()
        lblMsgAdd.Text = ""
        tbxCourseCodeAdd.Clear()
        tbxCourseTitleAdd.Clear()
        tbxUnitsAdd.Clear()
        tbxScoreAdd.Clear()
    End Sub

    'function to clear the result panel input controls
    Public Sub ClearResult()
        lblGradeUnitsResult.Text = ""
        lblUnitsResult.Text = ""
        lblGpaResult.Text = ""
        lblClassDivResult.Text = ""
    End Sub

    'executes when the user login in
    Private Sub btnSubmitLogin_Click(sender As Object, e As EventArgs) Handles btnSubmitLogin.Click
        Dim year As Integer
        'validate supplied details
        If tbxSurnameLogin.Text.Length = 0 OrElse tbxOtherNameLogin.Text.Length = 0 OrElse tbxFacultyLogin.Text.Length = 0 OrElse
                tbxDeptLogin.Text.Length = 0 OrElse tbxMatNoLogin.Text.Length = 0 OrElse Not Integer.TryParse(tbxYearLogin.Text, year) Then
            If tbxSurnameLogin.Text.Length = 0 Then
                lblMsgLogin.Text = "Please enter your surname"
            ElseIf tbxOtherNameLogin.Text.Length = 0 Then
                lblMsgLogin.Text = "Please enter your other name(s)"
            ElseIf tbxFacultyLogin.Text.Length = 0 Then
                lblMsgLogin.Text = "Please enter your faculty"
            ElseIf tbxDeptLogin.Text.Length = 0 Then
                lblMsgLogin.Text = "Please enter your department"
            ElseIf tbxMatNoLogin.Text.Length = 0 Then
                lblMsgLogin.Text = "Please enter your matriculation number"
            Else
                lblMsgLogin.Text = "Please enter a number for year"
            End If
            Return      'exit function
        Else
            lblMsgLogin.Text = ""
        End If

        'log user into the system
        HideAllPanels()
        PanelMain.Visible = True
        SetFormSize("main")         'resize to fit main panel

        'display user's information on main page
        lblNameMain.Text = "Welcome: " & PascalCase(tbxSurnameLogin.Text.Trim()) & ", " & PascalCase(tbxOtherNameLogin.Text.Trim())
        lblMatNoMain.Text = tbxMatNoLogin.Text.Trim().ToUpper()
        lblFacultyMain.Text = PascalCase(tbxFacultyLogin.Text.Trim())
        lblDeptMain.Text = PascalCase(tbxDeptLogin.Text.Trim())
        lblYearMain.Text = year & ""
    End Sub

    'converts a string input to pascal case
    Private Function PascalCase(value As String) As String
        Dim output As String = ""
        Dim subValues() = value.Split(" ")

        For Each innerValue In subValues
            If value.Length <= 1 Then
                output = innerValue.ToUpper()
            Else
                output += innerValue.Substring(0, 1).ToUpper() & innerValue.Substring(1) & " "  'convert to pascal case for each value
            End If
        Next

        If output.Length <= 1 Then Return output

        PascalCase = output.Substring(0, output.Length - 1)         'to remove the trailing space
    End Function

    'logs a user out of the system
    Private Sub btnLogoutMain_Click(sender As Object, e As EventArgs) Handles btnLogoutMain.Click
        HideAllPanels()
        ClearAll()
        SetFormSize("login")
        PanelLogin.Visible = True
    End Sub

    'executes when a user decides to add a course
    Private Sub btnAddMain_Click(sender As Object, e As EventArgs) Handles btnAddMain.Click
        If lvwCourses.Items.Count >= 8 Then
            lblMsgMain.Text = "Course limit reached (8)"
            Return
        Else
            lblMsgLogin.Text = ""
        End If

        PanelMain.Visible = False
        ClearAdd()
        SetFormSize("add")                  'resize to fit add course panel
        PanelAdd.Visible = True
    End Sub

    'function to handle addition of course information
    Private Sub btnAddCourseAdd_Click(sender As Object, e As EventArgs) Handles btnAddCourseAdd.Click
        Dim unit, score As Integer
        'validate supplied details
        If tbxCourseCodeAdd.Text.Length = 0 OrElse tbxCourseTitleAdd.Text.Length = 0 OrElse Not Integer.TryParse(tbxUnitsAdd.Text, unit) OrElse
            Not Integer.TryParse(tbxScoreAdd.Text, score) OrElse Integer.Parse(tbxScoreAdd.Text) > 100 OrElse Integer.Parse(tbxScoreAdd.Text) < 0 Then
            If tbxCourseCodeAdd.Text.Length = 0 Then
                lblMsgAdd.Text = "Please enter the course code"
            ElseIf tbxCourseTitleAdd.Text.Length = 0 Then
                lblMsgAdd.Text = "Please enter the course code"
            ElseIf Not Integer.TryParse(tbxUnitsAdd.Text, unit) Then
                lblMsgAdd.Text = "Please enter number for course units"
            ElseIf Not Integer.TryParse(tbxScoreAdd.Text, score) Then
                lblMsgAdd.Text = "Please enter a number for score"
            Else
                lblMsgAdd.Text = "Score must be between 0 - 100 (inclusive)"
            End If
            Return      'exit function
        Else
            lblMsgAdd.Text = ""
        End If

        HideAllPanels()
        SetFormSize("main")
        PanelMain.Visible = True
        btnRemoveMain.Visible = False

        Dim itemInfo(5) As String
        itemInfo(0) = (lvwCourses.Items.Count + 1) & ""
        itemInfo(1) = tbxCourseCodeAdd.Text.ToUpper()
        itemInfo(2) = tbxCourseTitleAdd.Text
        itemInfo(3) = tbxUnitsAdd.Text
        itemInfo(4) = tbxScoreAdd.Text
        itemInfo(5) = Grade(tbxScoreAdd.Text)
        Dim item As ListViewItem = New ListViewItem(itemInfo)           'add course information to the listview
        lvwCourses.Items.Add(item)
    End Sub

    'executes when a user decides not to add a course
    Private Sub btnCancelAdd_Click(sender As Object, e As EventArgs) Handles btnCancelAdd.Click
        PanelAdd.Visible = False
        SetFormSize("main")
        PanelMain.Visible = True
        btnRemoveMain.Visible = False               'hide the button to remove courses
    End Sub

    'generates the correct grade for a score
    Private Function Grade(ByVal scoreText As String) As String
        Dim score As Integer = Integer.Parse(scoreText)
        'generate the appropraite grade for a score
        If score < 40 Then
            Return "F (0)"
        ElseIf score < 45 Then
            Return "E (1)"
        ElseIf score < 50 Then
            Return "D (2)"
        ElseIf score < 60 Then
            Return "C (3)"
        ElseIf score < 70 Then
            Return "B (4)"
        Else
            Return "A (5)"
        End If
    End Function

    'executes when a course is selected from the listview
    Private Sub lvwCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCourses.SelectedIndexChanged
        btnRemoveMain.Visible = True        'display the button to remove courses
    End Sub

    'function to remove courses from the listview
    Private Sub btnRemoveMain_Click(sender As Object, e As EventArgs) Handles btnRemoveMain.Click
        If lvwCourses.SelectedItems IsNot Nothing Then
            For Each selectedItem As ListViewItem In lvwCourses.SelectedItems
                lvwCourses.Items.Remove(selectedItem)           'remove all selected courses
            Next
            Dim count As Integer = 1
            For Each item As ListViewItem In lvwCourses.Items       'readjust the count
                item.SubItems(0).Text = count & ""
                count += 1
            Next
        End If

        btnRemoveMain.Visible = False
    End Sub

    'function to clear the results calculated
    Private Sub btnOkResult_Click(sender As Object, e As EventArgs) Handles btnOkResult.Click
        ClearResult()
        SetFormSize("main")
        PanelResult.Visible = False
    End Sub

    'function to calculate the semester GPA of student
    Private Sub btnCalcMain_Click(sender As Object, e As EventArgs) Handles btnCalcMain.Click
        Dim totalUnits = 0.0, totalGradeUnit = 0.0

        For Each item As ListViewItem In lvwCourses.Items
            Dim unit As String = Integer.Parse(item.SubItems(3).Text)
            Dim grade As String = item.SubItems(5).Text
            Dim gradeValue As Integer = Integer.Parse(grade.Substring(3, 1))    'get the actual unit for grade
            totalUnits += unit
            totalGradeUnit += (unit * gradeValue)
        Next

        If lvwCourses.Items.Count > 0 Then
            SetFormSize("result")                   'set form size to the result panel
            PanelResult.Visible = True
            lblUnitsResult.Text = totalUnits & ""
            lblGradeUnitsResult.Text = totalGradeUnit & ""
            lblGpaResult.Text = String.Format("{0:F2}", (totalGradeUnit / totalUnits))
            lblClassDivResult.Text = ClassDivision(lblGpaResult.Text)       'select appropraite class division for gpa
        End If

        btnRemoveMain.Visible = False
    End Sub

    'function to generate the class division for calculated GPA
    Private Function ClassDivision(ByVal gpaStr As String) As String
        Dim gpa As Double = Double.Parse(gpaStr)
        'generate appropraite class for gpa
        If gpa < 1.0 Then
            Return "Fail"
        ElseIf gpa < 1.5 Then
            Return "Pass"
        ElseIf gpa < 2.5 Then
            Return "Third Class"
        ElseIf gpa < 3.5 Then
            Return "Second Class, Lower Division"
        ElseIf gpa < 4.5 Then
            Return "Second Class, Upper Division"
        Else
            Return "First Class"
        End If
    End Function

End Class
