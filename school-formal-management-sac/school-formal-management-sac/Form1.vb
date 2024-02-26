' PROGRAM NAME: Folio 1
' PURPOSE: To calculate the total value of tickets sold, applying discounts if applicable, and determine whether the student/teacher ratio meets a specified threshold.
' AUTHOR: Ihsaan Ifzal
' DATE CREATED: 26/02/2024
Imports System.Text.RegularExpressions

Public Class Form1
    ' Constant variables are declared
    Private Const TicketPricePerStudent As Integer = 100
    Private Const TicketPricePerTeacher As Integer = 50
    Private Const DiscountThreshold As Integer = 150
    Private Const DiscountRate As Double = 0.05

    ' Event handler for the Ticket Sales Report button click.
    ' Calculates the total value of tickets sold, applies discounts, and displays the results.
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ' lstDisplay list box is cleared every time the Ticket Sales Report button is clicked
        lstDisplay.Items.Clear()

        Dim intNumStudents As Integer
        Dim intNumTeachers As Integer
        Dim intTotal As Integer

        ' Validate input for number of students
        If Not ValidateInput(txtNumStudents, "number of students", intNumStudents) Then Return
        ' Validate input for number of teachers
        If Not ValidateInput(txtNumTeachers, "number of teachers", intNumTeachers) Then Return

        ' Calculate total value of tickets sold
        Try
            intTotal = (intNumStudents * TicketPricePerStudent) + (intNumTeachers * TicketPricePerTeacher)
        Catch ex As System.OverflowException
            ' If the numbers are too large an error message is displayed
            MessageBox.Show($"The numbers you entered for the number of students and teachers are too large.", "Input Error")
            txtNumStudents.Clear()
            txtNumTeachers.Clear()
            txtNumStudents.Focus()
            Return
        End Try

        ' Calculate discount value
        Dim dblDiscount As Double = If(intNumStudents + intNumTeachers >= DiscountThreshold, intTotal * DiscountRate, 0)
        ' Calculate student/teacher ratio
        Dim dblStudTeachRatio As Double = If(intNumTeachers <> 0, intNumStudents / intNumTeachers, 0)

        ' Determine if the student/teacher ratio meets the threshold
        Dim strStudTeachRatio As String = If(dblStudTeachRatio <= 20, "The Student/Teacher ratio has been met.", "The Student/Teacher ratio has not been met.")

        ' Display results
        lstDisplay.Items.Add($"{intNumStudents} student tickets and {intNumTeachers} teacher tickets have been sold.")
        lstDisplay.Items.Add($"The total value of the tickets sold is ${intTotal}.")
        lstDisplay.Items.Add($"The discount value is ${dblDiscount}.")
        lstDisplay.Items.Add(strStudTeachRatio)
    End Sub

    ' Validates input for a TextBox, ensuring it is not empty and contains only whole numbers.
    ' If validation fails, displays an error message and sets focus to the TextBox.
    ' textBox Parameter: The TextBox to validate.
    ' strFieldName Parameter: The name of the field being validated.
    ' intOutput Parameter: The output variable to store the parsed integer value.
    ' Returns True if validation succeeds, otherwise False.
    Private Function ValidateInput(textBox As TextBox, strFieldName As String, ByRef intOutput As Integer) As Boolean
        Dim strInput As String = textBox.Text.Trim()

        ' Check if input is empty
        If String.IsNullOrWhiteSpace(strInput) Then
            MessageBox.Show($"Please provide input for the {strFieldName}.", "Input Error")
            textBox.Clear()
            textBox.Focus()
            Return False
        End If

        ' Check if input contains only whole numbers
        If Not Regex.IsMatch(strInput, "^\d+$") Then
            MessageBox.Show($"Please enter whole numbers for the {strFieldName}.", "Input Error")
            textBox.Clear()
            textBox.Focus()
            Return False
        End If

        ' Parse input string to integer
        Try
            intOutput = Val(strInput)
        Catch ex As System.OverflowException
            ' If the numbers are too large an error message is displayed
            MessageBox.Show($"The number you entered for the {strFieldName} is too large.", "Input Error")
            textBox.Clear()
            textBox.Focus()
            Return False
        End Try

        Return True
    End Function

    ' Event handler for the Clear button click.
    ' Clears the display and input fields.
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstDisplay.Items.Clear()
        txtNumStudents.Clear()
        txtNumTeachers.Clear()
    End Sub
End Class
