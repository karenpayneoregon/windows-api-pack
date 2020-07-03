Imports DialogsVisualBasic.Classes
Imports DialogsVisualBasic.Modules
Imports Microsoft.WindowsAPICodePack.Dialogs

Public Class Form1
    Private Sub MoreLessButton_Click(sender As Object, e As EventArgs) Handles MoreLessButton.Click

        MoreLessLabel.Text = DisplayInformationalText()

    End Sub
    Private Sub QuestionButton_Click(sender As Object, e As EventArgs) Handles QuestionButton.Click

        If ExitApplication("Stay", "Leave") = TaskDialogResult.Close Then
            Close()
        End If

    End Sub
    Private Sub ServerDialogButton_Click(sender As Object, e As EventArgs) Handles ServerDialogButton.Click

        Dim serverName = SelectWebServer()

        If Not String.IsNullOrWhiteSpace(serverName) Then
            ServerNameTextBox.Text = serverName
        Else
            ServerNameTextBox.Text = "No server selected"
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>
    ''' For the dialog to function properly see the dependency in the
    ''' manifest for this to work in an async method.
    ''' </remarks>
    Private Async Sub ExceptionButton_Click(sender As Object, e As EventArgs) Handles ExceptionButton.Click
        ExceptionButton.Enabled = False
        Try
            Dim table = Await DataOperations.ReadCustomers()
        Catch ex As Exception
            DisplayExceptionInformational(ex.Message)
        Finally
            ExceptionButton.Enabled = True
        End Try
    End Sub

    Private Sub FeedbackButton_Click(sender As Object, e As EventArgs) Handles FeedbackButton.Click
        FeedbackDemo()
    End Sub

    Private Sub StupidButton_Click(sender As Object, e As EventArgs) Handles StupidButton.Click
        StupidThreeButtonsDemo()
    End Sub
End Class
