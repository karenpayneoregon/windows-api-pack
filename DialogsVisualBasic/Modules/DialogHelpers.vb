Imports System.IO
Imports DialogsVisualBasic.Classes
Imports Microsoft.WindowsAPICodePack.Dialogs

Namespace Modules

    Public Module DialogHelpers
        ''' <summary>
        ''' Ask to close application with user defined buttons
        ''' </summary>
        ''' <param name="stayText">Text to show for not leaving</param>
        ''' <param name="leaveText">Text to show for leaving</param>
        ''' <returns></returns>
        Public Function ExitApplication(stayText As String, leaveText As String) As TaskDialogResult
            '
            ' Defines the default button
            '
            Dim stayButton = New TaskDialogButton("StayButton", stayText) With {.Default = True}
            Dim closeButton = New TaskDialogButton("CancelButton", leaveText)

            Dim dialog = New TaskDialog With {
                        .Caption = "Question",
                        .InstructionText = $"Close '{Application.ProductName}'",
                        .Icon = TaskDialogStandardIcon.Warning,
                        .Cancelable = True,
                        .OwnerWindowHandle = Form.ActiveForm.Handle,
                        .StartupLocation = TaskDialogStartupLocation.CenterOwner
                    }

            '
            ' Place buttons in the order they should appear
            '
            dialog.Controls.Add(closeButton)
            dialog.Controls.Add(stayButton)

            '
            ' Issue that requires icon to be set here else
            ' it will not show.
            '
            AddHandler dialog.Opened,
                Sub(sender As Object, ea As EventArgs)
                    Dim taskDialog = TryCast(sender, TaskDialog)
                    taskDialog.Icon = taskDialog.Icon
                End Sub

            '
            ' Set result for when dialog closes
            '
            AddHandler stayButton.Click,
                Sub()
                    dialog.Close(TaskDialogResult.Cancel)
                End Sub

            AddHandler closeButton.Click,
                Sub()
                    dialog.Close(TaskDialogResult.Close)
                End Sub

            '
            ' Display dialog
            '
            Return dialog.Show()

        End Function
        ''' <summary>
        ''' Select server
        ''' </summary>
        ''' <returns></returns>
        Public Function SelectWebServer() As String
            Dim serverName As String = ""
            Dim server1Button = New TaskDialogButton("Server1Button", "Server 1") With {.Default = True}
            Dim server2Button = New TaskDialogButton("Server2Button", "Server 2")
            Dim cancelButton = New TaskDialogButton("CancelButton", "Cancel")

            Dim dialog = New TaskDialog With {
                        .Caption = "Question",
                        .InstructionText = $"Close '{Application.ProductName}'",
                        .Icon = TaskDialogStandardIcon.Warning,
                        .Cancelable = True,
                        .OwnerWindowHandle = Form.ActiveForm.Handle,
                        .StartupLocation = TaskDialogStartupLocation.CenterOwner
                    }

            '
            ' Place buttons in the order they should appear
            '
            dialog.Controls.Add(server2Button)
            dialog.Controls.Add(server1Button)
            dialog.Controls.Add(cancelButton)

            '
            ' Issue that requires icon to be set here else
            ' it will not show.
            '
            AddHandler dialog.Opened,
                Sub(sender As Object, ea As EventArgs)
                    Dim taskDialog = TryCast(sender, TaskDialog)
                    taskDialog.Icon = taskDialog.Icon
                End Sub

            '
            ' Set result for when dialog closes
            '
            AddHandler server1Button.Click,
                Sub()
                    serverName = "https://stackpath.bootstrapcdn.com"
                    dialog.Close(TaskDialogResult.Close)
                End Sub

            AddHandler server2Button.Click,
                Sub()
                    serverName = "https://cdn.jsdelivr.net"
                    dialog.Close(TaskDialogResult.Close)
                End Sub

            AddHandler cancelButton.Click,
                Sub()
                    serverName = ""
                    dialog.Close(TaskDialogResult.Close)
                End Sub

            dialog.Show()

            Return serverName

        End Function
        Public Function DisplayInformationalText() As String
            Dim result = ""
            Dim detailsText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum"

            Dim closeButton = New TaskDialogButton("CloseTaskDialogButton", "Not now") With {.Default = True}
            Dim proceedButton = New TaskDialogButton("ProceedTaskDialogButton", "Get going")

            Dim fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TextFile1.txt")

            Dim dialog = New TaskDialog With {
            .Caption = "Read file",
            .DetailsCollapsedLabel = "More >>",
            .DetailsExpanded = False,
            .DetailsExpandedLabel = "<< Less",
            .DetailsExpandedText = detailsText,
            .ExpansionMode = TaskDialogExpandedDetailsLocation.Hide,
            .InstructionText = $"Reading the file '{Path.GetFileName(fileName)}'",
            .Icon = TaskDialogStandardIcon.Information,
            .Cancelable = True,
            .StartupLocation = TaskDialogStartupLocation.CenterOwner}

            dialog.Controls.Add(closeButton)
            dialog.Controls.Add(proceedButton)

            dialog.OwnerWindowHandle = Form.ActiveForm.Handle

            AddHandler dialog.Opened,
            Sub(senderObject As Object, ea As EventArgs)
                Dim taskDialog As TaskDialog = TryCast(senderObject, TaskDialog)
                taskDialog.Icon = taskDialog.Icon
            End Sub

            AddHandler closeButton.Click,
            Sub()
                dialog.Close(TaskDialogResult.Cancel)
            End Sub

            AddHandler proceedButton.Click,
            Sub()
                dialog.Close(TaskDialogResult.Ok)
            End Sub

            If dialog.Show() = TaskDialogResult.Cancel Then
                result = "Canceled"
            Else
                result = "Continue"
            End If

            Return result

        End Function
        Public Sub DisplayExceptionInformational(exceptionMessage As String)

            Dim detailsText = "Something bad happened, please contact the service desk"

            If exceptionMessage.Contains("The server was not found or was not accessible") Then
                detailsText = "Please make sure there is a network connection and try again. If this fails contact the service desk"
            End If

            Dim closeButton = New TaskDialogButton("CloseTaskDialogButton", "Continue")

            Dim dialog = New TaskDialog With {
            .Caption = "Error",
            .DetailsCollapsedLabel = "More >>",
            .DetailsExpanded = False,
            .DetailsExpandedLabel = "<< Less",
            .DetailsExpandedText = detailsText,
            .ExpansionMode = TaskDialogExpandedDetailsLocation.Hide,
            .InstructionText = "Encountered a unrecoverable error!",
            .Icon = TaskDialogStandardIcon.Information,
            .Cancelable = True,
            .StartupLocation = TaskDialogStartupLocation.CenterScreen}

            dialog.Controls.Add(closeButton)

            dialog.OwnerWindowHandle = Form.ActiveForm.Handle

            AddHandler dialog.Opened,
            Sub(senderObject As Object, ea As EventArgs)
                Dim taskDialog = TryCast(senderObject, TaskDialog)
                taskDialog.Icon = taskDialog.Icon
            End Sub

            AddHandler closeButton.Click,
            Sub()
                dialog.Close(TaskDialogResult.Cancel)
            End Sub

            dialog.Show()

        End Sub
        ''' <summary>
        ''' Note here we have no X button
        ''' </summary>
        Public Sub FeedbackDemo()

            Dim closeButton = New TaskDialogButton("CloseTaskDialogButton", "Continue with no feedback") With {.Default = True}
            Dim proceedButton = New TaskDialogButton("ProceedTaskDialogButton", "Submit feedback to support")

            Dim dialog = New TaskDialog With {
            .Caption = "Crashed",
            .InstructionText = $"CRASH AND BURN{Environment.NewLine}The application performed an illegal action.",
            .Icon = TaskDialogStandardIcon.Error,
            .Cancelable = False,
            .StartupLocation = TaskDialogStartupLocation.CenterOwner}

            dialog.Controls.Add(closeButton)
            dialog.Controls.Add(proceedButton)

            dialog.OwnerWindowHandle = Form.ActiveForm.Handle

            AddHandler dialog.Opened,
            Sub(senderObject As Object, ea As EventArgs)
                Dim taskDialog = TryCast(senderObject, TaskDialog)
                taskDialog.Icon = taskDialog.Icon
            End Sub

            AddHandler closeButton.Click,
            Sub()
                dialog.Close(TaskDialogResult.Close)
            End Sub

            AddHandler proceedButton.Click,
            Sub()
                Diagnostics.CollectFeedBack()
                dialog.Close(TaskDialogResult.Close)
            End Sub

            dialog.Show()

        End Sub
        Public Sub StupidThreeButtonsDemo()

            Dim yesButton = New TaskDialogButton("YesTaskDialogButton", "YeeHaa!") With {.Default = True}
            Dim neverButton = New TaskDialogButton("NeverTaskDialogButton", "No way!!!")
            Dim dunnoButton = New TaskDialogButton("dunnoTaskDialogButton", "I donno?")

            Dim dialog = New TaskDialog With {
                    .Caption = "Stupid",
                    .InstructionText = "You are about to do something stupid",
                    .Icon = TaskDialogStandardIcon.Shield,
                    .DetailsExpandedText = "Are you sure you want to continue with this really bad idea?",
                    .DetailsExpanded = True,
                    .Cancelable = False,
                    .StartupLocation = TaskDialogStartupLocation.CenterOwner}

            dialog.FooterText = "I double dog dare you"
            dialog.FooterIcon = TaskDialogStandardIcon.Information
            dialog.Controls.Add(yesButton)
            dialog.Controls.Add(neverButton)
            dialog.Controls.Add(dunnoButton)

            dialog.OwnerWindowHandle = Form.ActiveForm.Handle

            AddHandler dialog.Opened,
                Sub(senderObject As Object, ea As EventArgs)
                    Dim taskDialog = TryCast(senderObject, TaskDialog)
                    taskDialog.Icon = taskDialog.Icon
                    taskDialog.FooterIcon = taskDialog.FooterIcon
                End Sub

            AddHandler yesButton.Click,
                Sub()
                    dialog.Close(TaskDialogResult.Close)
                End Sub

            AddHandler neverButton.Click,
                Sub()
                    dialog.Close(TaskDialogResult.Close)
                End Sub

            AddHandler dunnoButton.Click,
                Sub()
                    dialog.Close(TaskDialogResult.Close)
                End Sub

            dialog.Show()

        End Sub
    End Module
End Namespace