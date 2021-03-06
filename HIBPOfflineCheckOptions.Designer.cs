﻿namespace HIBPOfflineCheck
{
    partial class HIBPOfflineCheckOptions
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
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.textBoxWarningDialog = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxWarningDialog = new System.Windows.Forms.CheckBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.checkBoxBreachCountDetails = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInsecureText = new System.Windows.Forms.TextBox();
            this.textBoxSecureText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxColumnName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pb_BannerImage = new System.Windows.Forms.PictureBox();
            this.groupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BannerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxOptions.Controls.Add(this.textBoxWarningDialog);
            this.groupBoxOptions.Controls.Add(this.label5);
            this.groupBoxOptions.Controls.Add(this.checkBoxWarningDialog);
            this.groupBoxOptions.Controls.Add(this.buttonBrowse);
            this.groupBoxOptions.Controls.Add(this.checkBoxBreachCountDetails);
            this.groupBoxOptions.Controls.Add(this.label4);
            this.groupBoxOptions.Controls.Add(this.textBoxInsecureText);
            this.groupBoxOptions.Controls.Add(this.textBoxSecureText);
            this.groupBoxOptions.Controls.Add(this.label3);
            this.groupBoxOptions.Controls.Add(this.textBoxColumnName);
            this.groupBoxOptions.Controls.Add(this.label2);
            this.groupBoxOptions.Controls.Add(this.textBoxFileName);
            this.groupBoxOptions.Controls.Add(this.label1);
            this.groupBoxOptions.Location = new System.Drawing.Point(12, 75);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(564, 231);
            this.groupBoxOptions.TabIndex = 0;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // textBoxWarningDialog
            // 
            this.textBoxWarningDialog.AcceptsReturn = true;
            this.textBoxWarningDialog.Location = new System.Drawing.Point(27, 172);
            this.textBoxWarningDialog.Multiline = true;
            this.textBoxWarningDialog.Name = "textBoxWarningDialog";
            this.textBoxWarningDialog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxWarningDialog.Size = new System.Drawing.Size(514, 50);
            this.textBoxWarningDialog.TabIndex = 12;
            this.textBoxWarningDialog.Text = "WARNING - INSECURE PASSWORD\r\n\r\nThis password is insecure and publicly known";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "(Enable new column in: View - Configure Columns...)";
            // 
            // checkBoxWarningDialog
            // 
            this.checkBoxWarningDialog.AutoSize = true;
            this.checkBoxWarningDialog.Location = new System.Drawing.Point(6, 149);
            this.checkBoxWarningDialog.Name = "checkBoxWarningDialog";
            this.checkBoxWarningDialog.Size = new System.Drawing.Size(297, 17);
            this.checkBoxWarningDialog.TabIndex = 9;
            this.checkBoxWarningDialog.Text = "Display warning mesage after editing insecure passwords:";
            this.checkBoxWarningDialog.UseVisualStyleBackColor = true;
            this.checkBoxWarningDialog.CheckedChanged += new System.EventHandler(this.checkBoxWarningDialog_CheckedChanged);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(483, 17);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // checkBoxBreachCountDetails
            // 
            this.checkBoxBreachCountDetails.AutoSize = true;
            this.checkBoxBreachCountDetails.Checked = true;
            this.checkBoxBreachCountDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBreachCountDetails.Location = new System.Drawing.Point(6, 126);
            this.checkBoxBreachCountDetails.Name = "checkBoxBreachCountDetails";
            this.checkBoxBreachCountDetails.Size = new System.Drawing.Size(271, 17);
            this.checkBoxBreachCountDetails.TabIndex = 8;
            this.checkBoxBreachCountDetails.Text = "Include breach count details for insecure passwords";
            this.checkBoxBreachCountDetails.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Insecure text:";
            // 
            // textBoxInsecureText
            // 
            this.textBoxInsecureText.Location = new System.Drawing.Point(124, 98);
            this.textBoxInsecureText.Name = "textBoxInsecureText";
            this.textBoxInsecureText.Size = new System.Drawing.Size(111, 20);
            this.textBoxInsecureText.TabIndex = 7;
            this.textBoxInsecureText.Text = "Pwned";
            // 
            // textBoxSecureText
            // 
            this.textBoxSecureText.Location = new System.Drawing.Point(124, 71);
            this.textBoxSecureText.Name = "textBoxSecureText";
            this.textBoxSecureText.Size = new System.Drawing.Size(111, 20);
            this.textBoxSecureText.TabIndex = 6;
            this.textBoxSecureText.Text = "Secure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Secure text:";
            // 
            // textBoxColumnName
            // 
            this.textBoxColumnName.Location = new System.Drawing.Point(124, 45);
            this.textBoxColumnName.Name = "textBoxColumnName";
            this.textBoxColumnName.Size = new System.Drawing.Size(111, 20);
            this.textBoxColumnName.TabIndex = 5;
            this.textBoxColumnName.Text = "Have I been pwned?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pwned passwords file:";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(124, 19);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(353, 20);
            this.textBoxFileName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Column name:";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(419, 312);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(501, 312);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // pb_BannerImage
            // 
            this.pb_BannerImage.Location = new System.Drawing.Point(0, 0);
            this.pb_BannerImage.Name = "pb_BannerImage";
            this.pb_BannerImage.Size = new System.Drawing.Size(588, 60);
            this.pb_BannerImage.TabIndex = 3;
            this.pb_BannerImage.TabStop = false;
            // 
            // HIBPOfflineCheckOptions
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(588, 346);
            this.Controls.Add(this.pb_BannerImage);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HIBPOfflineCheckOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HIBP Offline Check Options";
            this.Load += new System.EventHandler(this.HIBPOfflineCheckOptions_Load);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BannerImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxColumnName;
        private System.Windows.Forms.TextBox textBoxSecureText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxInsecureText;
        private System.Windows.Forms.CheckBox checkBoxBreachCountDetails;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.CheckBox checkBoxWarningDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pb_BannerImage;
        private System.Windows.Forms.TextBox textBoxWarningDialog;
    }
}