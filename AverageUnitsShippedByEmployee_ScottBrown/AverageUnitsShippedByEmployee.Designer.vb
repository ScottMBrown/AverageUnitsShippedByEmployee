<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShippedByEmployee
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
        Me.components = New System.ComponentModel.Container()
        Me.lblDayDisplay = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtInputBox = New System.Windows.Forms.TextBox()
        Me.lblEmployeeOne = New System.Windows.Forms.Label()
        Me.lblEmpoyeeTwo = New System.Windows.Forms.Label()
        Me.lblEmployeeThree = New System.Windows.Forms.Label()
        Me.txtEmployeeOneResultDisplay = New System.Windows.Forms.TextBox()
        Me.txtEmployeeTwoResultDisplay = New System.Windows.Forms.TextBox()
        Me.txtEmployeeThreeResultDisplay = New System.Windows.Forms.TextBox()
        Me.lblEmployeeOneAverage = New System.Windows.Forms.Label()
        Me.lblEmployeeTwoAverage = New System.Windows.Forms.Label()
        Me.lblEmployeeThreeAverage = New System.Windows.Forms.Label()
        Me.lblEmployeeTotalAverage = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ttAverageEmployeeUnitsShipped = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblDayDisplay
        '
        Me.lblDayDisplay.Location = New System.Drawing.Point(12, 18)
        Me.lblDayDisplay.Name = "lblDayDisplay"
        Me.lblDayDisplay.Size = New System.Drawing.Size(45, 17)
        Me.lblDayDisplay.TabIndex = 0
        Me.lblDayDisplay.Text = "Day 1"
        Me.lblDayDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(12, 51)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(44, 17)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInputBox
        '
        Me.txtInputBox.Location = New System.Drawing.Point(77, 51)
        Me.txtInputBox.Name = "txtInputBox"
        Me.txtInputBox.Size = New System.Drawing.Size(69, 22)
        Me.txtInputBox.TabIndex = 2
        Me.ttAverageEmployeeUnitsShipped.SetToolTip(Me.txtInputBox, "Enter the amount of units shipped.")
        '
        'lblEmployeeOne
        '
        Me.lblEmployeeOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeOne.Location = New System.Drawing.Point(36, 98)
        Me.lblEmployeeOne.Name = "lblEmployeeOne"
        Me.lblEmployeeOne.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployeeOne.TabIndex = 3
        Me.lblEmployeeOne.Text = "Employee 1"
        Me.lblEmployeeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmpoyeeTwo
        '
        Me.lblEmpoyeeTwo.Location = New System.Drawing.Point(180, 98)
        Me.lblEmpoyeeTwo.Name = "lblEmpoyeeTwo"
        Me.lblEmpoyeeTwo.Size = New System.Drawing.Size(82, 17)
        Me.lblEmpoyeeTwo.TabIndex = 4
        Me.lblEmpoyeeTwo.Text = "Employee 2"
        Me.lblEmpoyeeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeThree
        '
        Me.lblEmployeeThree.Location = New System.Drawing.Point(327, 98)
        Me.lblEmployeeThree.Name = "lblEmployeeThree"
        Me.lblEmployeeThree.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployeeThree.TabIndex = 5
        Me.lblEmployeeThree.Text = "Employee 3"
        Me.lblEmployeeThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmployeeOneResultDisplay
        '
        Me.txtEmployeeOneResultDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtEmployeeOneResultDisplay.Location = New System.Drawing.Point(15, 130)
        Me.txtEmployeeOneResultDisplay.Multiline = True
        Me.txtEmployeeOneResultDisplay.Name = "txtEmployeeOneResultDisplay"
        Me.txtEmployeeOneResultDisplay.ReadOnly = True
        Me.txtEmployeeOneResultDisplay.Size = New System.Drawing.Size(134, 146)
        Me.txtEmployeeOneResultDisplay.TabIndex = 6
        Me.ttAverageEmployeeUnitsShipped.SetToolTip(Me.txtEmployeeOneResultDisplay, "Displays the units shipped for employee 1 during the week.")
        '
        'txtEmployeeTwoResultDisplay
        '
        Me.txtEmployeeTwoResultDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtEmployeeTwoResultDisplay.Location = New System.Drawing.Point(157, 130)
        Me.txtEmployeeTwoResultDisplay.Multiline = True
        Me.txtEmployeeTwoResultDisplay.Name = "txtEmployeeTwoResultDisplay"
        Me.txtEmployeeTwoResultDisplay.ReadOnly = True
        Me.txtEmployeeTwoResultDisplay.Size = New System.Drawing.Size(134, 146)
        Me.txtEmployeeTwoResultDisplay.TabIndex = 7
        Me.ttAverageEmployeeUnitsShipped.SetToolTip(Me.txtEmployeeTwoResultDisplay, "Displays the units shipped for employee 2 during the week.")
        '
        'txtEmployeeThreeResultDisplay
        '
        Me.txtEmployeeThreeResultDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtEmployeeThreeResultDisplay.Location = New System.Drawing.Point(300, 130)
        Me.txtEmployeeThreeResultDisplay.Multiline = True
        Me.txtEmployeeThreeResultDisplay.Name = "txtEmployeeThreeResultDisplay"
        Me.txtEmployeeThreeResultDisplay.ReadOnly = True
        Me.txtEmployeeThreeResultDisplay.Size = New System.Drawing.Size(134, 146)
        Me.txtEmployeeThreeResultDisplay.TabIndex = 8
        Me.ttAverageEmployeeUnitsShipped.SetToolTip(Me.txtEmployeeThreeResultDisplay, "Displays the units shipped for employee 3 during the week.")
        '
        'lblEmployeeOneAverage
        '
        Me.lblEmployeeOneAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeOneAverage.Location = New System.Drawing.Point(15, 279)
        Me.lblEmployeeOneAverage.Name = "lblEmployeeOneAverage"
        Me.lblEmployeeOneAverage.Size = New System.Drawing.Size(134, 29)
        Me.lblEmployeeOneAverage.TabIndex = 9
        Me.lblEmployeeOneAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttAverageEmployeeUnitsShipped.SetToolTip(Me.lblEmployeeOneAverage, "Displays the average for employee 1.")
        '
        'lblEmployeeTwoAverage
        '
        Me.lblEmployeeTwoAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeTwoAverage.Location = New System.Drawing.Point(157, 279)
        Me.lblEmployeeTwoAverage.Name = "lblEmployeeTwoAverage"
        Me.lblEmployeeTwoAverage.Size = New System.Drawing.Size(134, 29)
        Me.lblEmployeeTwoAverage.TabIndex = 10
        Me.lblEmployeeTwoAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttAverageEmployeeUnitsShipped.SetToolTip(Me.lblEmployeeTwoAverage, "Displays the average for employee 2.")
        '
        'lblEmployeeThreeAverage
        '
        Me.lblEmployeeThreeAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeThreeAverage.Location = New System.Drawing.Point(300, 279)
        Me.lblEmployeeThreeAverage.Name = "lblEmployeeThreeAverage"
        Me.lblEmployeeThreeAverage.Size = New System.Drawing.Size(134, 29)
        Me.lblEmployeeThreeAverage.TabIndex = 11
        Me.lblEmployeeThreeAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttAverageEmployeeUnitsShipped.SetToolTip(Me.lblEmployeeThreeAverage, "Displays the average for employee 3.")
        '
        'lblEmployeeTotalAverage
        '
        Me.lblEmployeeTotalAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeTotalAverage.Location = New System.Drawing.Point(12, 324)
        Me.lblEmployeeTotalAverage.Name = "lblEmployeeTotalAverage"
        Me.lblEmployeeTotalAverage.Size = New System.Drawing.Size(419, 29)
        Me.lblEmployeeTotalAverage.TabIndex = 12
        Me.lblEmployeeTotalAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttAverageEmployeeUnitsShipped.SetToolTip(Me.lblEmployeeTotalAverage, "Displays the average of the total employees.")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(15, 366)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(134, 32)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ttAverageEmployeeUnitsShipped.SetToolTip(Me.btnEnter, "Click to add a daily unit entry for the employee." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(157, 366)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(134, 32)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ttAverageEmployeeUnitsShipped.SetToolTip(Me.btnReset, "Click to reset the form." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(300, 366)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(134, 32)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ttAverageEmployeeUnitsShipped.SetToolTip(Me.btnExit, "Click to exit the form.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsShippedByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(446, 413)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblEmployeeTotalAverage)
        Me.Controls.Add(Me.lblEmployeeThreeAverage)
        Me.Controls.Add(Me.lblEmployeeTwoAverage)
        Me.Controls.Add(Me.lblEmployeeOneAverage)
        Me.Controls.Add(Me.txtEmployeeThreeResultDisplay)
        Me.Controls.Add(Me.txtEmployeeTwoResultDisplay)
        Me.Controls.Add(Me.txtEmployeeOneResultDisplay)
        Me.Controls.Add(Me.lblEmployeeThree)
        Me.Controls.Add(Me.lblEmpoyeeTwo)
        Me.Controls.Add(Me.lblEmployeeOne)
        Me.Controls.Add(Me.txtInputBox)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDayDisplay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShippedByEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDayDisplay As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtInputBox As TextBox
    Friend WithEvents lblEmployeeOne As Label
    Friend WithEvents lblEmpoyeeTwo As Label
    Friend WithEvents lblEmployeeThree As Label
    Friend WithEvents txtEmployeeOneResultDisplay As TextBox
    Friend WithEvents txtEmployeeTwoResultDisplay As TextBox
    Friend WithEvents txtEmployeeThreeResultDisplay As TextBox
    Friend WithEvents lblEmployeeOneAverage As Label
    Friend WithEvents lblEmployeeTwoAverage As Label
    Friend WithEvents lblEmployeeThreeAverage As Label
    Friend WithEvents lblEmployeeTotalAverage As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ttAverageEmployeeUnitsShipped As ToolTip
End Class
