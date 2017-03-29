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
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.cmdDisplay = New System.Windows.Forms.Button()
        Me.txtSave = New System.Windows.Forms.RichTextBox()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(84, 21)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(100, 20)
        Me.txtFName.TabIndex = 0
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(84, 47)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(100, 20)
        Me.txtLName.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(84, 73)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 2
        '
        'dtpDOB
        '
        Me.dtpDOB.Location = New System.Drawing.Point(84, 99)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(200, 20)
        Me.dtpDOB.TabIndex = 5
        Me.dtpDOB.Value = New Date(2017, 3, 29, 0, 0, 0, 0)
        '
        'cmdDisplay
        '
        Me.cmdDisplay.Location = New System.Drawing.Point(96, 151)
        Me.cmdDisplay.Name = "cmdDisplay"
        Me.cmdDisplay.Size = New System.Drawing.Size(75, 23)
        Me.cmdDisplay.TabIndex = 6
        Me.cmdDisplay.Text = "Check"
        Me.cmdDisplay.UseVisualStyleBackColor = True
        '
        'txtSave
        '
        Me.txtSave.Location = New System.Drawing.Point(324, 12)
        Me.txtSave.Name = "txtSave"
        Me.txtSave.Size = New System.Drawing.Size(409, 227)
        Me.txtSave.TabIndex = 7
        Me.txtSave.Text = ""
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(24, 21)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(60, 13)
        Me.lblFirst.TabIndex = 8
        Me.lblFirst.Text = "First Name:"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(24, 47)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(52, 13)
        Me.lblLast.TabIndex = 9
        Me.lblLast.Text = "Surname:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(24, 76)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email:"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(7, 99)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(71, 13)
        Me.lblDOB.TabIndex = 11
        Me.lblDOB.Text = "Date Of Birth:"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(96, 180)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 13
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(177, 165)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 14
        Me.cmdDelete.Text = "Delete Check"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(96, 220)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(75, 30)
        Me.cmdLoad.TabIndex = 15
        Me.cmdLoad.Text = "Load"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(177, 224)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdReset.TabIndex = 16
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 262)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.txtSave)
        Me.Controls.Add(Me.cmdDisplay)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdDisplay As System.Windows.Forms.Button
    Friend WithEvents txtSave As System.Windows.Forms.RichTextBox
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblLast As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents cmdReset As System.Windows.Forms.Button

End Class
