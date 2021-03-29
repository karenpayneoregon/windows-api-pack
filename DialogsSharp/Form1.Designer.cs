namespace DialogsSharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CenterOnFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CenterOnFormButton
            // 
            this.CenterOnFormButton.Location = new System.Drawing.Point(229, 118);
            this.CenterOnFormButton.Name = "CenterOnFormButton";
            this.CenterOnFormButton.Size = new System.Drawing.Size(181, 23);
            this.CenterOnFormButton.TabIndex = 0;
            this.CenterOnFormButton.Text = "Center on this form";
            this.CenterOnFormButton.UseVisualStyleBackColor = true;
            this.CenterOnFormButton.Click += new System.EventHandler(this.CenterOnFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 294);
            this.Controls.Add(this.CenterOnFormButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CenterOnFormButton;
    }
}

