<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormView
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
        Label1 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        Label2 = New Label()
        txtPhone = New TextBox()
        Label3 = New Label()
        txtGitHub = New TextBox()
        Label4 = New Label()
        txtStopwatch = New TextBox()
        Label5 = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(131, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 20)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(250, 28)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(125, 27)
        txtName.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(250, 74)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(125, 27)
        txtEmail.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(131, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 2
        Label2.Text = "Email:"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(250, 129)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(125, 27)
        txtPhone.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(103, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 20)
        Label3.TabIndex = 4
        Label3.Text = "Phone Number:"
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(250, 183)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.ReadOnly = True
        txtGitHub.Size = New Size(125, 27)
        txtGitHub.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(112, 183)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 20)
        Label4.TabIndex = 6
        Label4.Text = "GitHub Link:"
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(250, 230)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(125, 27)
        txtStopwatch.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(103, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 20)
        Label5.TabIndex = 8
        Label5.Text = "Stopwatch Time:"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(53, 325)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(226, 55)
        btnPrevious.TabIndex = 10
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(369, 325)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(226, 55)
        btnNext.TabIndex = 11
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' FormView
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtStopwatch)
        Controls.Add(Label5)
        Controls.Add(txtGitHub)
        Controls.Add(Label4)
        Controls.Add(txtPhone)
        Controls.Add(Label3)
        Controls.Add(txtEmail)
        Controls.Add(Label2)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Name = "FormView"
        Text = "FormView"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
