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
        Me.MoreLessButton = New System.Windows.Forms.Button()
        Me.QuestionButton = New System.Windows.Forms.Button()
        Me.ServerDialogButton = New System.Windows.Forms.Button()
        Me.ServerNameTextBox = New System.Windows.Forms.TextBox()
        Me.MoreLessLabel = New System.Windows.Forms.Label()
        Me.ExceptionButton = New System.Windows.Forms.Button()
        Me.FeedbackButton = New System.Windows.Forms.Button()
        Me.StupidButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MoreLessButton
        '
        Me.MoreLessButton.Location = New System.Drawing.Point(30, 14)
        Me.MoreLessButton.Name = "MoreLessButton"
        Me.MoreLessButton.Size = New System.Drawing.Size(153, 23)
        Me.MoreLessButton.TabIndex = 0
        Me.MoreLessButton.Text = "Display more/less"
        Me.MoreLessButton.UseVisualStyleBackColor = True
        '
        'QuestionButton
        '
        Me.QuestionButton.Location = New System.Drawing.Point(30, 56)
        Me.QuestionButton.Name = "QuestionButton"
        Me.QuestionButton.Size = New System.Drawing.Size(153, 23)
        Me.QuestionButton.TabIndex = 1
        Me.QuestionButton.Text = "Question dialog"
        Me.QuestionButton.UseVisualStyleBackColor = True
        '
        'ServerDialogButton
        '
        Me.ServerDialogButton.Location = New System.Drawing.Point(30, 98)
        Me.ServerDialogButton.Name = "ServerDialogButton"
        Me.ServerDialogButton.Size = New System.Drawing.Size(153, 23)
        Me.ServerDialogButton.TabIndex = 2
        Me.ServerDialogButton.Text = "Server Dialog"
        Me.ServerDialogButton.UseVisualStyleBackColor = True
        '
        'ServerNameTextBox
        '
        Me.ServerNameTextBox.Location = New System.Drawing.Point(198, 100)
        Me.ServerNameTextBox.Name = "ServerNameTextBox"
        Me.ServerNameTextBox.Size = New System.Drawing.Size(218, 20)
        Me.ServerNameTextBox.TabIndex = 3
        '
        'MoreLessLabel
        '
        Me.MoreLessLabel.AutoSize = True
        Me.MoreLessLabel.Location = New System.Drawing.Point(208, 20)
        Me.MoreLessLabel.Name = "MoreLessLabel"
        Me.MoreLessLabel.Size = New System.Drawing.Size(37, 13)
        Me.MoreLessLabel.TabIndex = 4
        Me.MoreLessLabel.Text = "Result"
        '
        'ExceptionButton
        '
        Me.ExceptionButton.Location = New System.Drawing.Point(30, 140)
        Me.ExceptionButton.Name = "ExceptionButton"
        Me.ExceptionButton.Size = New System.Drawing.Size(153, 23)
        Me.ExceptionButton.TabIndex = 5
        Me.ExceptionButton.Text = "Exception"
        Me.ExceptionButton.UseVisualStyleBackColor = True
        '
        'FeedbackButton
        '
        Me.FeedbackButton.Location = New System.Drawing.Point(30, 181)
        Me.FeedbackButton.Name = "FeedbackButton"
        Me.FeedbackButton.Size = New System.Drawing.Size(153, 23)
        Me.FeedbackButton.TabIndex = 6
        Me.FeedbackButton.Text = "Feedback"
        Me.FeedbackButton.UseVisualStyleBackColor = True
        '
        'StupidButton
        '
        Me.StupidButton.Location = New System.Drawing.Point(30, 223)
        Me.StupidButton.Name = "StupidButton"
        Me.StupidButton.Size = New System.Drawing.Size(153, 23)
        Me.StupidButton.TabIndex = 7
        Me.StupidButton.Text = "Stupid"
        Me.StupidButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 258)
        Me.Controls.Add(Me.StupidButton)
        Me.Controls.Add(Me.FeedbackButton)
        Me.Controls.Add(Me.ExceptionButton)
        Me.Controls.Add(Me.MoreLessLabel)
        Me.Controls.Add(Me.ServerNameTextBox)
        Me.Controls.Add(Me.ServerDialogButton)
        Me.Controls.Add(Me.QuestionButton)
        Me.Controls.Add(Me.MoreLessButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dialog code sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MoreLessButton As Button
    Friend WithEvents QuestionButton As Button
    Friend WithEvents ServerDialogButton As Button
    Friend WithEvents ServerNameTextBox As TextBox
    Friend WithEvents MoreLessLabel As Label
    Friend WithEvents ExceptionButton As Button
    Friend WithEvents FeedbackButton As Button
    Friend WithEvents StupidButton As Button
End Class
