﻿namespace putio
{
    partial class FormPutioSettings
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
            this.groupBoxAuthentication = new System.Windows.Forms.GroupBox();
            this.buttonGetToken = new System.Windows.Forms.Button();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxDownloads = new System.Windows.Forms.GroupBox();
            this.textBoxDownloadPath = new System.Windows.Forms.TextBox();
            this.buttonDownloadPathChange = new System.Windows.Forms.Button();
            this.groupBoxAuthentication.SuspendLayout();
            this.groupBoxDownloads.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAuthentication
            // 
            this.groupBoxAuthentication.Controls.Add(this.buttonGetToken);
            this.groupBoxAuthentication.Controls.Add(this.textBoxToken);
            this.groupBoxAuthentication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAuthentication.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAuthentication.Name = "groupBoxAuthentication";
            this.groupBoxAuthentication.Size = new System.Drawing.Size(284, 82);
            this.groupBoxAuthentication.TabIndex = 0;
            this.groupBoxAuthentication.TabStop = false;
            this.groupBoxAuthentication.Text = "Authentication";
            // 
            // buttonGetToken
            // 
            this.buttonGetToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonGetToken.Location = new System.Drawing.Point(161, 23);
            this.buttonGetToken.Name = "buttonGetToken";
            this.buttonGetToken.Size = new System.Drawing.Size(90, 23);
            this.buttonGetToken.TabIndex = 1;
            this.buttonGetToken.Text = "Get Token";
            this.buttonGetToken.UseVisualStyleBackColor = true;
            this.buttonGetToken.Click += new System.EventHandler(this.buttonGetToken_Click);
            // 
            // textBoxToken
            // 
            this.textBoxToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxToken.Location = new System.Drawing.Point(6, 25);
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(149, 20);
            this.textBoxToken.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonSave.Location = new System.Drawing.Point(381, 288);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxDownloads
            // 
            this.groupBoxDownloads.Controls.Add(this.buttonDownloadPathChange);
            this.groupBoxDownloads.Controls.Add(this.textBoxDownloadPath);
            this.groupBoxDownloads.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxDownloads.Location = new System.Drawing.Point(12, 100);
            this.groupBoxDownloads.Name = "groupBoxDownloads";
            this.groupBoxDownloads.Size = new System.Drawing.Size(459, 138);
            this.groupBoxDownloads.TabIndex = 3;
            this.groupBoxDownloads.TabStop = false;
            this.groupBoxDownloads.Text = "Downloads";
            // 
            // textBoxDownloadPath
            // 
            this.textBoxDownloadPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDownloadPath.Location = new System.Drawing.Point(8, 25);
            this.textBoxDownloadPath.Name = "textBoxDownloadPath";
            this.textBoxDownloadPath.ReadOnly = true;
            this.textBoxDownloadPath.Size = new System.Drawing.Size(364, 20);
            this.textBoxDownloadPath.TabIndex = 2;
            // 
            // buttonDownloadPathChange
            // 
            this.buttonDownloadPathChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadPathChange.Location = new System.Drawing.Point(378, 23);
            this.buttonDownloadPathChange.Name = "buttonDownloadPathChange";
            this.buttonDownloadPathChange.Size = new System.Drawing.Size(75, 23);
            this.buttonDownloadPathChange.TabIndex = 3;
            this.buttonDownloadPathChange.Text = "Change...";
            this.buttonDownloadPathChange.UseVisualStyleBackColor = true;
            this.buttonDownloadPathChange.Click += new System.EventHandler(this.buttonDownloadPathChange_Click);
            // 
            // FormPutioSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 321);
            this.Controls.Add(this.groupBoxDownloads);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxAuthentication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(499, 360);
            this.MinimumSize = new System.Drawing.Size(499, 360);
            this.Name = "FormPutioSettings";
            this.Text = "Put.io Manager - Settings";
            this.Load += new System.EventHandler(this.PutioSettings_Load);
            this.groupBoxAuthentication.ResumeLayout(false);
            this.groupBoxAuthentication.PerformLayout();
            this.groupBoxDownloads.ResumeLayout(false);
            this.groupBoxDownloads.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAuthentication;
        private System.Windows.Forms.Button buttonGetToken;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxDownloads;
        private System.Windows.Forms.Button buttonDownloadPathChange;
        private System.Windows.Forms.TextBox textBoxDownloadPath;
    }
}