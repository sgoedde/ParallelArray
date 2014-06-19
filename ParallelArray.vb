'Stephanie Goedde
'IT3013 VB
'ParArray1
'2-21-13

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmParallelArray

    'class level variables
    Public arrLast(49) As String
    Public arrFirst(49) As String
    Public arrMiddle(49) As String
    Public arrSalary(49) As Double
    Public intCount As Integer = 0
    Public dblSum As Double

    'gets name and salary from text boxes
    'splits name into first, middle, and last then puts all into correct array
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'variables
        Dim strName, strLast, strFirst, strMiddle As String
        Dim dblSalary As Double

        Try
            'get values from text boxes
            strName = txtBxName.Text
            dblSalary = Convert.ToDouble(txtBxSalary.Text) 'convert value to double

            If strName.IndexOf(".") > -1 Then 'checks for period in strName
                'strLast begins 2 indices after period
                strLast = strName.Substring(strName.IndexOf(".") + 2)
                'strFirst starts at 0 and goes until first space
                strFirst = strName.Substring(0, strName.IndexOf(" "))
                'strMiddle starts after first space and goes for 2 indices
                strMiddle = strName.Substring(strName.IndexOf(" ") + 1, 2)
            Else
                'strLast begins 1 index after first space
                strLast = strName.Substring(strName.IndexOf(" ") + 1)
                'strFirst begins at 0 and goes until first space
                strFirst = strName.Substring(0, strName.IndexOf(" "))
                'strMiddle is empty
                strMiddle = ""
            End If

            'name and salary are put into index intCount in arrays
            arrLast(intCount) = strLast
            arrFirst(intCount) = strFirst
            arrMiddle(intCount) = strMiddle
            arrSalary(intCount) = dblSalary
            intCount += 1 'increase count
            dblSum += dblSalary 'running sum of salaries

            'update status labels-name and salary and the # of total records added
            lblStatus.Text = "New Record Added: " & strName & " " & dblSalary.ToString("C2")
            lblNumRecords.Text = "Total Records: " & intCount.ToString()

            'clear txtBoxes and reset for new record
            txtBxName.Clear()
            txtBxSalary.Clear()
            txtBxName.Focus()
            btnCreate.Enabled = True 'allow for report

            'after 50 records are entered give message saying no more records allowed
            'disable new record controls
            If intCount >= 50 Then
                MessageBox.Show("Record limit reached. No more than 50 records permitted.", "Record limit reached", MessageBoxButtons.OK)
                btnAdd.Enabled = False
                lblName.Enabled = False
                txtBxName.Enabled = False
                lblSalary.Enabled = False
                txtBxSalary.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid entry. Try again.", "Error")
            txtBxName.Focus()
        End Try

    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        'variables
        Dim dblAverage, dblHigh, dblLow As Double

        Try
            dblHigh = FindHigh(arrSalary) 'function to find highest salary
            dblLow = FindLow(arrSalary) 'function to find lowest salary
            dblAverage = dblSum / intCount 'calculates average salary

            'method to sort arrays alphabetically by last name
            Sort(arrLast, arrFirst, arrMiddle, arrSalary)

            'prints built strings from functions into text boxes
            txtBxHighLow.Text = OutputSalary(dblHigh, dblLow, dblAverage)
            txtBxOutput.Text = PrintOutput(arrLast, arrFirst, arrMiddle, arrSalary, dblAverage)

            'sets controls for increase salary function
            lblPercent.Enabled = True
            txtBxPercent.Enabled = True
            txtBxPercent.Focus()
            btnNewReport.Enabled = True

            lblStatus.Text = String.Empty

            btnAdd.Enabled = False
            btnCreate.Enabled = False
            lblName.Enabled = False
            txtBxName.Enabled = False
            lblSalary.Enabled = False
            txtBxSalary.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Invalid Function.", "Error")
        End Try

    End Sub

    Private Sub Sort(ByVal Last As Array, ByVal First As Array, ByVal Middle As Array, ByVal Salary As Array)
        'variables
        Dim tempLast, tempFirst, tempMiddle As String
        Dim k As Integer
        Dim tempSalary As Double

        'loop for length of entered values in array
        For i As Integer = 1 To (intCount - 1)
            'sets temp value to current array value
            tempLast = arrLast(i)
            tempFirst = arrFirst(i)
            tempMiddle = arrMiddle(i)
            tempSalary = arrSalary(i)
            k = i - 1 'k equals i minus 1
            'loop while k>= 0 and array(k) is further in alphabet then tempLast
            While k >= 0 AndAlso arrLast(k) > tempLast
                'sets array(k+1) to value of array(k)
                arrLast(k + 1) = arrLast(k)
                arrFirst(k + 1) = arrFirst(k)
                arrMiddle(k + 1) = arrMiddle(k)
                arrSalary(k + 1) = arrSalary(k)
                k -= 1 'decriment k
            End While
            'sets array(k+1) to value stored in temp
            arrLast(k + 1) = tempLast
            arrFirst(k + 1) = tempFirst
            arrMiddle(k + 1) = tempMiddle
            arrSalary(k + 1) = tempSalary
        Next

    End Sub

    Private Function FindHigh(ByRef Salary() As Double) As Double
        Dim dblHigh As Double = Salary(0)
        'loops for length of entered values in array
        'compares first value to next and sets highest as dblHigh
        'as loops, compares dblHigh to all other values and sets as necessary
        For j As Integer = 0 To (intCount - 1)
            If dblHigh < Salary(j) Then
                dblHigh = Salary(j)
            End If
        Next
        Return dblHigh
    End Function

    Private Function FindLow(ByRef Salary() As Double) As Double
        Dim dblLow As Double = Salary(0)
        'loops for length of entered values in array
        'compares first value to next and sets lowest as dblLow
        'as loops, compares dblLow to all other values and sets as necessary
        For j As Integer = 0 To (intCount - 1)
            If dblLow > Salary(j) Then
                dblLow = Salary(j)
            End If
        Next
        Return dblLow
    End Function

    Private Function PrintOutput(ByRef Last() As String, ByRef First() As String, ByRef Middle() As String,
                                 ByRef Salary() As Double, ByRef Average As Double) As String
        'builds string by adding new values as looping through array
        'returns string with all values entered into array
        Dim strOutput As String = "NAME".PadRight(25) & "SALARY".PadLeft(9) & "DEVIATION FROM AVERAGE".PadLeft(29) &
            ControlChars.NewLine & ControlChars.NewLine

        For j As Integer = 0 To (intCount - 1)
            strOutput += (Last(j) & ", " & First(j) & " " & Middle(j)).PadRight(22) &
                Salary(j).ToString("C2").PadLeft(15) & (Salary(j) - Average).ToString("C2").PadLeft(26) &
                ControlChars.NewLine
        Next
        Return strOutput
    End Function

    Private Function OutputSalary(ByRef High As Double, ByRef Low As Double, ByRef Average As Double) As String
        'builds string for high, low, and average salary; returns
        Dim strOutput As String = "High Salary:".PadRight(17) & High.ToString("C2").PadLeft(15) & ControlChars.NewLine &
            "Low Salary:".PadRight(17) & Low.ToString("C2").PadLeft(15) & ControlChars.NewLine &
            "Average Salary:".PadRight(17) & Average.ToString("C2").PadLeft(15)
        Return strOutput
    End Function

    'gets percent from text box
    'recalculates stored salary values in array with percent
    'displays new values in a different report
    Private Sub btnNewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewReport.Click
        'variables
        Dim dblPercent, dblNewSum, dblNewHigh, dblNewLow, dblNewAverage As Double
        Dim strPercent As String

        Try
            strPercent = txtBxPercent.Text 'get value from text box

            'converts to decimal and adds 1
            dblPercent = ((Convert.ToDouble(strPercent) / 100) + 1)

            'loops through salary array and recalculates values
            For j As Integer = 0 To (intCount - 1)
                arrSalary(j) = arrSalary(j) * dblPercent
                dblNewSum += arrSalary(j) 'running sum
            Next

            dblNewHigh = FindHigh(arrSalary) 'function finds highest salary
            dblNewLow = FindLow(arrSalary) 'function finds lowest salary
            dblNewAverage = dblNewSum / intCount 'calculates new average salary

            'builds strings to print in new text boxes
            txtBxNewHighLow.Text = "Salary Increase: " & strPercent & "%" & ControlChars.NewLine &
                OutputSalary(dblNewHigh, dblNewLow, dblNewAverage)
            txtBxNewOutput.Text = PrintOutput(arrLast, arrFirst, arrMiddle, arrSalary, dblNewAverage)

            'sets for option to clear or exit
            btnNewReport.Enabled = False
            lblPercent.Enabled = False
            txtBxPercent.Enabled = False
            txtBxPercent.Clear()
        Catch ex As Exception
            MessageBox.Show("Invalid entry. Try again.", "Error")
            txtBxPercent.Focus()
        End Try

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'clear arrays
        Array.Clear(arrLast, 0, 49)
        Array.Clear(arrFirst, 0, 49)
        Array.Clear(arrMiddle, 0, 49)
        Array.Clear(arrSalary, 0, 49)

        'clear class variables
        intCount = 0
        dblSum = 0

        'clear text boxes and status labels
        txtBxHighLow.Clear()
        txtBxNewHighLow.Clear()
        txtBxOutput.Clear()
        txtBxNewOutput.Clear()
        lblNumRecords.Text = String.Empty

        'enables buttons and text boxes
        'read for new values to be added
        btnAdd.Enabled = True
        lblName.Enabled = True
        txtBxName.Enabled = True
        txtBxName.Focus()
        lblSalary.Enabled = True
        txtBxSalary.Enabled = True

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close() 'exit application
    End Sub

    Private Sub txtBxName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBxName.KeyPress
        'only allows alphabet, backspace, period, and space
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBxSalary_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBxSalary.KeyPress,
        txtBxPercent.KeyPress
        'only allows numbers, backspace, and period
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
End Class
