Public Class Form1

    Private Sub HideAllPanels()
        PanelLogin.Visible = False
        PanelMain.Visible = False
        PanelAdd.Visible = False
        PanelResult.Visible = False
    End Sub

    Public Sub ClearAll()
        ClearLogin()
        ClearMain()
        ClearAdd()
        ClearResult()
    End Sub

    Public Sub ClearLogin()
        lblMsgLogin.Text = ""
        tbxSurnameLogin.Clear()
        tbxOtherNameLogin.Clear()
        tbxFacultyLogin.Clear()
        tbxDeptLogin.Clear()
        tbxMatNoLogin.Clear()
        tbxYearLogin.Clear()
    End Sub

    Public Sub ClearMain()
        lblNameMain.Text = ""
        lblFacultyMain.Text = ""
        lblDeptMain.Text = ""
        lblMatNoMain.Text = ""
        lblYearMain.Text = ""
    End Sub

    Public Sub ClearAdd()
        tbxCourseCodeAdd.Clear()
        tbxCourseTitleAdd.Clear()
        tbxUnitsAdd.Clear()
        tbxScoreAdd.Clear()
    End Sub

    Public Sub ClearResult()
        lblGradeUnitsResult.Text = ""
        lblUnitsResult.Text = ""
        lblGpaResult.Text = ""
        lblClassDivResult.Text = ""
    End Sub

    Private Sub btnOkResult_Click(sender As Object, e As EventArgs) Handles btnOkResult.Click
        ClearResult()
        PanelResult.Visible = False
    End Sub

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
        'display user's information on main page
        lblNameMain.Text = "Welcome: " & tbxSurnameLogin.Text.Trim() & ", " & tbxOtherNameLogin.Text.Trim()
        lblMatNoMain.Text = tbxMatNoLogin.Text.Trim().ToUpper()
        lblFacultyMain.Text = tbxFacultyLogin.Text.Trim()
        lblDeptMain.Text = tbxDeptLogin.Text.Trim()
        lblYearMain.Text = year & ""
    End Sub

    Private Sub btnLogoutMain_Click(sender As Object, e As EventArgs) Handles btnLogoutMain.Click
        HideAllPanels()
        ClearAll()
        PanelLogin.Visible = True
    End Sub

    Private Sub btnAddMain_Click(sender As Object, e As EventArgs) Handles btnAddMain.Click
        If lvwCourses.Items.Count >= 8 Then
            lblMsgMain.Text = "Course limit reached (8)"
            Return
        Else
            lblMsgLogin.Text = ""
        End If

        HideAllPanels()
        ClearAdd()
        PanelAdd.Visible = True
    End Sub

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
        PanelMain.Visible = True
        btnRemoveMain.Visible = False
        Dim itemInfo(5) As String
        itemInfo(0) = (lvwCourses.Items.Count + 1) & ""
        itemInfo(1) = tbxCourseCodeAdd.Text.ToUpper()
        itemInfo(2) = tbxCourseTitleAdd.Text
        itemInfo(3) = tbxUnitsAdd.Text
        itemInfo(4) = tbxScoreAdd.Text
        itemInfo(5) = Grade(tbxScoreAdd.Text)
        Dim item As ListViewItem = New ListViewItem(itemInfo)
        lvwCourses.Items.Add(item)
    End Sub

    Private Sub btnCancelAdd_Click(sender As Object, e As EventArgs) Handles btnCancelAdd.Click
        PanelAdd.Visible = False
        PanelMain.Visible = True
        btnRemoveMain.Visible = False
    End Sub

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

    Private Sub lvwCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCourses.SelectedIndexChanged
        btnRemoveMain.Visible = True
    End Sub

    Private Sub btnRemoveMain_Click(sender As Object, e As EventArgs) Handles btnRemoveMain.Click
        If lvwCourses.SelectedItems IsNot Nothing Then
            For Each selectedItem As ListViewItem In lvwCourses.SelectedItems
                lvwCourses.Items.Remove(selectedItem)
            Next
        End If

        btnRemoveMain.Visible = False
    End Sub

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
            PanelResult.Visible = True
            lblUnitsResult.Text = totalUnits & ""
            lblGradeUnitsResult.Text = totalGradeUnit & ""
            lblGpaResult.Text = String.Format("{0:F2}", (totalGradeUnit / totalUnits))
            lblClassDivResult.Text = ClassDivision(lblGpaResult.Text)
        End If

        btnRemoveMain.Visible = False
    End Sub

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
