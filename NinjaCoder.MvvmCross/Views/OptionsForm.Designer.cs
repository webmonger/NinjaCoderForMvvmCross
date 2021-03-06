﻿namespace NinjaCoder.MvvmCross.Views
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.chkCreateLogFile = new System.Windows.Forms.CheckBox();
            this.lblLogFile = new System.Windows.Forms.Label();
            this.textBoxLogFile = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.logo1 = new NinjaCoder.MvvmCross.UserControls.Logo();
            this.checkBoxIncludeLibFolders = new System.Windows.Forms.CheckBox();
            this.checkBoxDisplayErrors = new System.Windows.Forms.CheckBox();
            this.checkBoxTrace = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkCreateLogFile
            // 
            this.chkCreateLogFile.AutoSize = true;
            this.chkCreateLogFile.Location = new System.Drawing.Point(372, 61);
            this.chkCreateLogFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkCreateLogFile.Name = "chkCreateLogFile";
            this.chkCreateLogFile.Size = new System.Drawing.Size(126, 21);
            this.chkCreateLogFile.TabIndex = 0;
            this.chkCreateLogFile.Text = "Create Log File";
            this.chkCreateLogFile.UseVisualStyleBackColor = true;
            // 
            // lblLogFile
            // 
            this.lblLogFile.Location = new System.Drawing.Point(303, 95);
            this.lblLogFile.Name = "lblLogFile";
            this.lblLogFile.Size = new System.Drawing.Size(81, 16);
            this.lblLogFile.TabIndex = 1;
            this.lblLogFile.Text = "Log File";
            // 
            // textBoxLogFile
            // 
            this.textBoxLogFile.Location = new System.Drawing.Point(372, 88);
            this.textBoxLogFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLogFile.Name = "textBoxLogFile";
            this.textBoxLogFile.Size = new System.Drawing.Size(389, 22);
            this.textBoxLogFile.TabIndex = 2;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.Location = new System.Drawing.Point(552, 338);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 27);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "&OK";
            this.buttonOK.Click += new System.EventHandler(this.ButtonOKClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(660, 338);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 27);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // logo1
            // 
            this.logo1.BackColor = System.Drawing.Color.White;
            this.logo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logo1.Location = new System.Drawing.Point(16, 16);
            this.logo1.Margin = new System.Windows.Forms.Padding(5);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(274, 376);
            this.logo1.TabIndex = 5;
            // 
            // checkBoxIncludeLibFolders
            // 
            this.checkBoxIncludeLibFolders.AutoSize = true;
            this.checkBoxIncludeLibFolders.Location = new System.Drawing.Point(372, 151);
            this.checkBoxIncludeLibFolders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxIncludeLibFolders.Name = "checkBoxIncludeLibFolders";
            this.checkBoxIncludeLibFolders.Size = new System.Drawing.Size(214, 21);
            this.checkBoxIncludeLibFolders.TabIndex = 6;
            this.checkBoxIncludeLibFolders.Text = "Include Lib folders in projects";
            this.checkBoxIncludeLibFolders.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisplayErrors
            // 
            this.checkBoxDisplayErrors.AutoSize = true;
            this.checkBoxDisplayErrors.Location = new System.Drawing.Point(372, 191);
            this.checkBoxDisplayErrors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxDisplayErrors.Name = "checkBoxDisplayErrors";
            this.checkBoxDisplayErrors.Size = new System.Drawing.Size(119, 21);
            this.checkBoxDisplayErrors.TabIndex = 8;
            this.checkBoxDisplayErrors.Text = "Display Errors";
            this.checkBoxDisplayErrors.UseVisualStyleBackColor = true;
            // 
            // checkBoxTrace
            // 
            this.checkBoxTrace.AutoSize = true;
            this.checkBoxTrace.Location = new System.Drawing.Point(372, 36);
            this.checkBoxTrace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxTrace.Name = "checkBoxTrace";
            this.checkBoxTrace.Size = new System.Drawing.Size(169, 21);
            this.checkBoxTrace.TabIndex = 9;
            this.checkBoxTrace.Text = "Trace Output enabled";
            this.checkBoxTrace.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 404);
            this.Controls.Add(this.checkBoxTrace);
            this.Controls.Add(this.checkBoxDisplayErrors);
            this.Controls.Add(this.checkBoxIncludeLibFolders);
            this.Controls.Add(this.logo1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxLogFile);
            this.Controls.Add(this.lblLogFile);
            this.Controls.Add(this.chkCreateLogFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.Text = "Ninja Coder for MvvmCross - Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCreateLogFile;
        private System.Windows.Forms.Label lblLogFile;
        private System.Windows.Forms.TextBox textBoxLogFile;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private UserControls.Logo logo1;
        private System.Windows.Forms.CheckBox checkBoxIncludeLibFolders;
        private System.Windows.Forms.CheckBox checkBoxDisplayErrors;
        private System.Windows.Forms.CheckBox checkBoxTrace;
    }
}