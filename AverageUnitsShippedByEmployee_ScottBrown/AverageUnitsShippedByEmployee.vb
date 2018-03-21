'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'Name:                  Scott Brown
'Date:                  2018-Mar-06
'Course:                NETD-2202-01
'Program Description:   This is a windows form application.  It takes the units shipped for a 
'                       week, for 3 employees.  It will calculate the average for each 
'                       employee and output it to the user.  Once the user inputs all the units
'                       shipped for the employees, it will calculate the total average, for all the
'                       employees.
'     
'Project Description:   This is the third lab for Net Development 1.  The main purpose of the 
'                       lab is to implement 2D arrays.  The 2D array will store the units shipped
'                       for each employee.  This program also uses many other concepts learned in 
'                       the course such as looping, 1 dimension arrays, if/else statements,
'                       methods and more.  Validation will also be implemented so the user has
'                       to enter "proper" input.
'
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Option Strict On
Public Class frmAverageUnitsShippedByEmployee
    'Holds the value for the input from the user
    Dim userInput As Integer

    '2d array that holds the emloyees units shipped
    Dim employeeArray(2, 6) As Integer
    'Variable that holds the number of columns (used for looping through the array)
    Dim numberOfColumns As Integer = employeeArray.GetLength(1)
    'Variable that counts for each employee
    Dim employeeCounter As Integer = 0

    'Variable that holds the sum of the employees units
    Dim unitSum As Double = 0.00
    'Variable that holds the total for the units of all employees
    Dim totalUnitSum As Double = 0.00
    'Variable holding the value for the first employee's sum
    Dim employeeOneSum As Double = 0.0
    'Variable holding the value for the second employee's sum
    Dim employeeTwoSum As Double = 0.0
    'Variable holding the value for the third employee's sum
    Dim employeeThreeSum As Double = 0.0
    'Array that holds the values for the average
    Dim employeeSumArray(2) As Integer
    'Variable that counts the days
    Dim dayCounter As Integer = 0
    'Variable of the displayed day counter
    Dim dayCounterDisplay As Integer = 1

    ''' <summary>
    ''' This method does the main calculations for the program.  When the button is clicked it will follow through the steps of the sub.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Constant variables for the ranges and the days of the week
        Const MaximumRange As Integer = 1000
        Const MinimumRange As Integer = 0
        Const DaysOfTheWeek As Integer = 7





        'Error checking if statement making sure the value is an integer
        If (Integer.TryParse(txtInputBox.Text, userInput) = False) Then
            MessageBox.Show("Error, value must be an integer")

            'Selecting the text box 
            txtInputBox.SelectAll()
            txtInputBox.Focus()

            'Used to jump out if given a non integer value so the array doesn't include it
            Return
            ' If the user input is out of the range then give an error message
        ElseIf (userInput > MaximumRange Or userInput < MinimumRange) Then
            MessageBox.Show("Error, value must be between 0 and 1000 inclusive")
            txtInputBox.SelectAll()


            'Used to jump out if given a value not in range so the array doesn't include it
            Return

        Else
            'Selecting the text box 
            txtInputBox.Focus()
            txtInputBox.SelectAll()
            txtInputBox.Text = ""

            'if the first employee is active then it will display the units in the first read only display text box
            If (employeeCounter = 0) Then
                txtEmployeeOneResultDisplay.Text &= (userInput & vbCrLf)
                'if the second employee is active then it will display the units in the second read only display text box
            ElseIf (employeeCounter = 1) Then
                txtEmployeeTwoResultDisplay.Text &= (userInput & vbCrLf)
                'if the third employee is active then it will display the units in the third read only display text box
            Else
                txtEmployeeThreeResultDisplay.Text &= (userInput & vbCrLf)
            End If

            'Making the row the employee count (0-2) and the day counter the column (0-6) and making it equal to the user input 
            employeeArray(employeeCounter, dayCounter) = userInput
            'Adding to the day counter if the result is good
            dayCounter = dayCounter + 1
            'adding to the day counter display
            dayCounterDisplay = dayCounterDisplay + 1
            'Making the day label display = to the day counter variable
            lblDayDisplay.Text = "Day " + dayCounterDisplay.ToString()

        End If
        'Once it hits the end of the week it will go into this if
        If dayCounter = 7 Then

            'Making the day = to 7
            dayCounterDisplay = dayCounterDisplay - 1
            lblDayDisplay.Text = "Day " + dayCounterDisplay.ToString()

            'Looping through the columns (7 days)
            For index As Integer = 0 To numberOfColumns - 1
                'adding the values together ' the for loop is doing the employee counter as the row and the index 
                '(which increments by 1) as the column.
                unitSum = unitSum + employeeArray(employeeCounter, index)
            Next
            'calculate the average
            unitSum = (unitSum / DaysOfTheWeek)
            'If it is employee 1
            If (employeeCounter = 0) Then
                'allowing employeeOneSum to be equal to the unit sum
                employeeOneSum = unitSum

                'storing the average into the array and casting it to a double variable
                employeeSumArray(0) = CInt(CDbl(employeeOneSum))
                'Outputting the average to the label and showing it to 2 decimal places
                lblEmployeeOneAverage.Text = "Average: " + employeeOneSum.ToString("n2")

                'If it is employee 2
            ElseIf (employeeCounter = 1) Then
                'allowing employeeOneSum to be equal to the unit sum
                employeeTwoSum = unitSum
                'storing the average into the array and casting it to a double variable
                employeeSumArray(1) = CInt(CDbl(employeeTwoSum))

                'Outputting the average to the label and showing it to 2 decimal places
                lblEmployeeTwoAverage.Text = "Average: " + employeeTwoSum.ToString("n2")

                'Once it hits employee three
            Else
                'allowing employeeOneSum to be equal to the unit sum
                employeeThreeSum = unitSum
                'Outputting the average to the label and showing it to 2 decimal places
                lblEmployeeThreeAverage.Text = "Average: " + employeeThreeSum.ToString("n2")
                'storing the average into the array and casting it to a double variable
                employeeSumArray(2) = CInt(CDbl(employeeThreeSum))

                'Making the enter button disables and making the text box read only
                btnEnter.Enabled = False
                txtInputBox.ReadOnly = True

                'Lopping the array that holds the averages to get the total average
                For index = 0 To employeeSumArray.Length - 1

                    'adding the sum
                    totalUnitSum = totalUnitSum + employeeSumArray(index)

                Next
                'calculating the total average
                totalUnitSum = (totalUnitSum / 3)

                'Displaying the total average to the label, two decimal places
                lblEmployeeTotalAverage.Text = "Average per day: " + totalUnitSum.ToString("n2")




            End If
            'increase the emplopyee counter after the calculations finish for the previous employee
            employeeCounter = employeeCounter + 1

            'Setting the day counter back to 0
            dayCounter = 0
            'Setting the day counter display back to 1
            dayCounterDisplay = 1
            lblDayDisplay.Text = "Day 1"

            'setting the sum back to 0
            unitSum = 0
            Return

        End If

    End Sub
    ''' <summary>
    ''' Resets the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.ButtonReset()
    End Sub
    ''' <summary>
    ''' Closes the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
    ''' <summary>
    ''' Method to reset the form
    ''' </summary>
    Private Sub ButtonReset()

        'Ressetting all text boxes, labels, buttons and variables back to their orginal state
        btnEnter.Enabled = True
        txtInputBox.ReadOnly = False
        txtInputBox.Focus()
        txtInputBox.Text = ""
        employeeCounter = 0
        dayCounter = 0
        dayCounterDisplay = 1
        lblDayDisplay.Text = "Day 1"
        unitSum = 0.00
        totalUnitSum = 0.00
        employeeOneSum = 0.0
        employeeTwoSum = 0.0
        employeeThreeSum = 0.0

        txtEmployeeOneResultDisplay.Text = ""
        txtEmployeeTwoResultDisplay.Text = ""
        txtEmployeeThreeResultDisplay.Text = ""
        lblEmployeeOneAverage.Text = ""
        lblEmployeeTwoAverage.Text = ""
        lblEmployeeTotalAverage.Text = ""
        lblEmployeeThreeAverage.Text = ""
        lblEmployeeTotalAverage.Text = ""


    End Sub


End Class
