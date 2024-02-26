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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNumStudents = New TextBox()
        txtNumTeachers = New TextBox()
        btnReport = New Button()
        btnClear = New Button()
        lstDisplay = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 16F)
        Label1.Location = New Point(320, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(564, 49)
        Label1.TabIndex = 0
        Label1.Text = "School Formal Management"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F)
        Label2.Location = New Point(36, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(376, 36)
        Label2.TabIndex = 1
        Label2.Text = "Number of student tickets"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F)
        Label3.Location = New Point(35, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(377, 36)
        Label3.TabIndex = 2
        Label3.Text = "Number of teacher tickets"
        ' 
        ' txtNumStudents
        ' 
        txtNumStudents.Font = New Font("Arial", 10F)
        txtNumStudents.Location = New Point(685, 125)
        txtNumStudents.Name = "txtNumStudents"
        txtNumStudents.Size = New Size(450, 38)
        txtNumStudents.TabIndex = 3
        ' 
        ' txtNumTeachers
        ' 
        txtNumTeachers.Font = New Font("Arial", 10F)
        txtNumTeachers.Location = New Point(685, 192)
        txtNumTeachers.Name = "txtNumTeachers"
        txtNumTeachers.Size = New Size(450, 38)
        txtNumTeachers.TabIndex = 4
        ' 
        ' btnReport
        ' 
        btnReport.Font = New Font("Arial", 10F)
        btnReport.Location = New Point(35, 280)
        btnReport.Name = "btnReport"
        btnReport.Size = New Size(613, 46)
        btnReport.TabIndex = 5
        btnReport.Text = "Ticket Sales Report"
        btnReport.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Arial", 10F)
        btnClear.Location = New Point(685, 280)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(450, 46)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lstDisplay
        ' 
        lstDisplay.BackColor = Color.LemonChiffon
        lstDisplay.Font = New Font("Arial", 10F)
        lstDisplay.FormattingEnabled = True
        lstDisplay.Location = New Point(35, 368)
        lstDisplay.Name = "lstDisplay"
        lstDisplay.Size = New Size(1100, 324)
        lstDisplay.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.IndianRed
        ClientSize = New Size(1174, 729)
        Controls.Add(lstDisplay)
        Controls.Add(btnClear)
        Controls.Add(btnReport)
        Controls.Add(txtNumTeachers)
        Controls.Add(txtNumStudents)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "School Formal Management"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumStudents As TextBox
    Friend WithEvents txtNumTeachers As TextBox
    Friend WithEvents btnReport As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lstDisplay As ListBox

End Class
