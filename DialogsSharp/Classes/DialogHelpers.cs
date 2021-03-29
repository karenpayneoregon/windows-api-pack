using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace DialogsSharp.Classes
{

    public static class DialogHelpers
    {
        /// <summary>
        /// Ask to close application with user defined buttons
        /// </summary>
        /// <param name="stayText">Text to show for not leaving</param>
        /// <param name="leaveText">Text to show for leaving</param>
        /// <returns></returns>
        public static TaskDialogResult ExitApplication(string stayText, string leaveText)
        {
            //
            // Defines the default button
            //
            var stayButton = new TaskDialogButton("StayButton", stayText) { Default = true };
            var closeButton = new TaskDialogButton("CancelButton", leaveText);

            var dialog = new TaskDialog
            {
                Caption = "Question",
                InstructionText = $"Close '{Application.ProductName}'",
                Icon = TaskDialogStandardIcon.Warning,
                Cancelable = true,
                OwnerWindowHandle = Form.ActiveForm.Handle,
                StartupLocation = TaskDialogStartupLocation.CenterOwner
            };

            //
            // Place buttons in the order they should appear
            //
            dialog.Controls.Add(closeButton);
            dialog.Controls.Add(stayButton);

            //
            // Issue that requires icon to be set here else
            // it will not show.
            //
            dialog.Opened += (sender, ea) =>
            {
                var taskDialog = sender as TaskDialog;
                taskDialog.Icon = taskDialog.Icon;
            };

            //
            // Set result for when dialog closes
            //
            stayButton.Click += (e,a) =>
            {
                dialog.Close(TaskDialogResult.Cancel);
            };

            closeButton.Click += (e,a) =>
            {
                dialog.Close(TaskDialogResult.Close);
            };

            //
            // Display dialog
            //
            return dialog.Show();

        }
        /// <summary>
        /// Select server
        /// </summary>
        /// <returns></returns>
        public static string SelectWebServer()
        {
            string serverName = "";
            var server1Button = new TaskDialogButton("Server1Button", "Server 1") { Default = true };
            var server2Button = new TaskDialogButton("Server2Button", "Server 2");
            var cancelButton = new TaskDialogButton("CancelButton", "Cancel");

            var dialog = new TaskDialog
            {
                Caption = "Question",
                InstructionText = $"Close '{Application.ProductName}'",
                Icon = TaskDialogStandardIcon.Warning,
                Cancelable = true,
                OwnerWindowHandle = Form.ActiveForm.Handle,
                StartupLocation = TaskDialogStartupLocation.CenterOwner
            };

            //
            // Place buttons in the order they should appear
            //
            dialog.Controls.Add(server2Button);
            dialog.Controls.Add(server1Button);
            dialog.Controls.Add(cancelButton);

            //
            // Issue that requires icon to be set here else
            // it will not show.
            //
            dialog.Opened += (sender, ea) =>
            {
                var taskDialog = sender as TaskDialog;
                taskDialog.Icon = taskDialog.Icon;
            };

            //
            // Set result for when dialog closes
            //
            server1Button.Click += (e,a) =>
            {
                serverName = "https://stackpath.bootstrapcdn.com";
                dialog.Close(TaskDialogResult.Close);
            };

            server2Button.Click += (e, a) =>
            {
                serverName = "https://cdn.jsdelivr.net";
                dialog.Close(TaskDialogResult.Close);
            };

            cancelButton.Click += (e, a) =>
            {
                serverName = "";
                dialog.Close(TaskDialogResult.Close);
            };

            dialog.Show();

            return serverName;

        }
        public static string DisplayInformationalText()
        {
            var result = "";
            var detailsText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum";

            var closeButton = new TaskDialogButton("CloseTaskDialogButton", "Not now") { Default = true };
            var proceedButton = new TaskDialogButton("ProceedTaskDialogButton", "Get going");

            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TextFile1.txt");

            var dialog = new TaskDialog
            {
                Caption = "Read file",
                DetailsCollapsedLabel = "More >>",
                DetailsExpanded = false,
                DetailsExpandedLabel = "<< Less",
                DetailsExpandedText = detailsText,
                ExpansionMode = TaskDialogExpandedDetailsLocation.Hide,
                InstructionText = $"Reading the file '{Path.GetFileName(fileName)}'",
                Icon = TaskDialogStandardIcon.Information,
                Cancelable = true,
                StartupLocation = TaskDialogStartupLocation.CenterOwner
            };

            dialog.Controls.Add(closeButton);
            dialog.Controls.Add(proceedButton);

            dialog.OwnerWindowHandle = Form.ActiveForm.Handle;

            dialog.Opened += (senderObject, ea) =>
            {
                TaskDialog taskDialog = senderObject as TaskDialog;
                taskDialog.Icon = taskDialog.Icon;
            };

            closeButton.Click += (e, a) =>
            {
                dialog.Close(TaskDialogResult.Cancel);
            };

            proceedButton.Click += (e, a) =>
            {
                dialog.Close(TaskDialogResult.Ok);
            };

            if (dialog.Show() == TaskDialogResult.Cancel)
            {
                result = "Canceled";
            }
            else
            {
                result = "Continue";
            }

            return result;

        }
        public static void DisplayExceptionInformational(string exceptionMessage)
        {

            var detailsText = "Something bad happened, please contact the service desk";

            if (exceptionMessage.Contains("The server was not found or was not accessible"))
            {
                detailsText = "Please make sure there is a network connection and try again. If this fails contact the service desk";
            }

            var closeButton = new TaskDialogButton("CloseTaskDialogButton", "Continue");

            var dialog = new TaskDialog
            {
                Caption = "Error",
                DetailsCollapsedLabel = "More >>",
                DetailsExpanded = false,
                DetailsExpandedLabel = "<< Less",
                DetailsExpandedText = detailsText,
                ExpansionMode = TaskDialogExpandedDetailsLocation.Hide,
                InstructionText = "Encountered a unrecoverable error!",
                Icon = TaskDialogStandardIcon.Information,
                Cancelable = true,
                StartupLocation = TaskDialogStartupLocation.CenterScreen
            };

            dialog.Controls.Add(closeButton);

            dialog.OwnerWindowHandle = Form.ActiveForm.Handle;

            dialog.Opened += (senderObject, ea) =>
            {
                var taskDialog = senderObject as TaskDialog;
                taskDialog.Icon = taskDialog.Icon;
            };

            closeButton.Click += (e, a) =>
            {
                dialog.Close(TaskDialogResult.Cancel);
            };

            dialog.Show();

        }
        /// <summary>
        /// Note here we have no X button
        /// </summary>
        public static void FeedbackDemo()
        {

            var closeButton = new TaskDialogButton("CloseTaskDialogButton", "Continue with no feedback") { Default = true };
            var proceedButton = new TaskDialogButton("ProceedTaskDialogButton", "Submit feedback to support");

            var dialog = new TaskDialog
            {
                Caption = "Crashed",
                InstructionText = $"CRASH AND BURN{Environment.NewLine}The application performed an illegal action.",
                Icon = TaskDialogStandardIcon.Error,
                Cancelable = false,
                StartupLocation = TaskDialogStartupLocation.CenterOwner
            };

            dialog.Controls.Add(closeButton);
            dialog.Controls.Add(proceedButton);

            dialog.OwnerWindowHandle = Form.ActiveForm.Handle;

            dialog.Opened += (senderObject, ea) =>
            {
                var taskDialog = senderObject as TaskDialog;
                taskDialog.Icon = taskDialog.Icon;
            };

            closeButton.Click += (e, a) =>
            {
                dialog.Close(TaskDialogResult.Close);
            };

            proceedButton.Click += (e, a) =>
            {
                //Diagnostics.CollectFeedBack();
                dialog.Close(TaskDialogResult.Close);
            };

            dialog.Show();

        }

        public static void CenterOnParent()
        {
            var yesButton = new TaskDialogButton("CloseTaskDialogButton", "Yes")
            {
                Default = true
            };
            var noButton = new TaskDialogButton("ProceedTaskDialogButton", "No");

            var dialog = new TaskDialog
            {
                Caption = "Question",
                InstructionText = $"Would you like to continue?",
                Icon = TaskDialogStandardIcon.Information,
                Cancelable = false,
                StartupLocation = TaskDialogStartupLocation.CenterOwner
            };

            dialog.Controls.Add(yesButton);
            dialog.Controls.Add(noButton);

            dialog.OwnerWindowHandle = Form.ActiveForm.Handle;

            dialog.Opened += (senderObject, ea) =>
            {
                var taskDialog = senderObject as TaskDialog;
                taskDialog.Icon = taskDialog.Icon;
            };

            yesButton.Click += (e, a) =>
            {
                Console.WriteLine("Yes");
                dialog.Close(TaskDialogResult.Close);
            };

            noButton.Click += (e, a) =>
            {
                Console.WriteLine("No");
                dialog.Close(TaskDialogResult.Close);
            };

            dialog.Show();

        }

        public static void StupidThreeButtonsDemo()
        {

            var yesButton = new TaskDialogButton("YesTaskDialogButton", "YeeHaa!") { Default = true };
            var neverButton = new TaskDialogButton("NeverTaskDialogButton", "No way!!!");
            var dunnoButton = new TaskDialogButton("dunnoTaskDialogButton", "I donno?");

            var dialog = new TaskDialog
            {
                Caption = "Stupid",
                InstructionText = "You are about to do something stupid",
                Icon = TaskDialogStandardIcon.Shield,
                DetailsExpandedText = "Are you sure you want to continue with this really bad idea?",
                DetailsExpanded = true,
                Cancelable = false,
                StartupLocation = TaskDialogStartupLocation.CenterOwner
            };

            dialog.FooterText = "I double dog dare you";
            dialog.FooterIcon = TaskDialogStandardIcon.Information;
            dialog.Controls.Add(yesButton);
            dialog.Controls.Add(neverButton);
            dialog.Controls.Add(dunnoButton);

            dialog.OwnerWindowHandle = Form.ActiveForm.Handle;

            dialog.Opened += (senderObject, ea) =>
            {
                var taskDialog = senderObject as TaskDialog;
                if (taskDialog != null)
                {
                    taskDialog.Icon = taskDialog.Icon;
                    taskDialog.FooterIcon = taskDialog.FooterIcon;
                }
            };

            yesButton.Click += (e, a) =>
            {
                dialog.Close(TaskDialogResult.Close);
            };

            neverButton.Click += (e, a) =>
            {
                dialog.Close(TaskDialogResult.Close);
            };

            dunnoButton.Click += (e, a) =>
            {
                dialog.Close(TaskDialogResult.Close);
            };

            dialog.Show();

        }
    }
}
