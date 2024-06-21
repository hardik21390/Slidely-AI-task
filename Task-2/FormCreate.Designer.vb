<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCreate
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
        txtGitHub = New TextBox()
        Label4 = New Label()
        txtPhone = New TextBox()
        Label3 = New Label()
        txtEmail = New TextBox()
        Label2 = New Label()
        txtName = New TextBox()
        Label1 = New Label()
        lblStopwatch = New Label()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(254, 206)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(125, 27)
        txtGitHub.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(116, 206)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 20)
        Label4.TabIndex = 14
        Label4.Text = "GitHub Link:"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(254, 152)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(125, 27)
        txtPhone.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(107, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 20)
        Label3.TabIndex = 12
        Label3.Text = "Phone Number:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(254, 97)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(125, 27)
        txtEmail.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(135, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 10
        Label2.Text = "Email:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(254, 51)
        txtName.Name = "txtName"
        txtName.Size = New Size(125, 27)
        txtName.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(135, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 20)
        Label1.TabIndex = 8
        Label1.Text = "Name:"
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(316, 289)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(63, 20)
        lblStopwatch.TabIndex = 16
        lblStopwatch.Text = "00:00:00"
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.Location = New Point(135, 278)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(131, 52)
        btnToggleStopwatch.TabIndex = 17
        btnToggleStopwatch.Text = "Toggle Stopwatch"
        btnToggleStopwatch.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(167, 346)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(212, 75)
        btnSubmit.TabIndex = 18
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' FormCreate
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(lblStopwatch)
        Controls.Add(txtGitHub)
        Controls.Add(Label4)
        Controls.Add(txtPhone)
        Controls.Add(Label3)
        Controls.Add(txtEmail)
        Controls.Add(Label2)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Name = "FormCreate"
        Text = "FormCreate"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
End Class
