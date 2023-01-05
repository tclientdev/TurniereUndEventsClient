using System.Windows.Forms;

namespace Turniere_und_Events_Client
{
    partial class settings_window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings_window));
            this.clientversion_label = new System.Windows.Forms.Label();
            this.debugversion_label = new System.Windows.Forms.Label();
            this.frameworkversion_label = new System.Windows.Forms.Label();
            this.winforms2version_label = new System.Windows.Forms.Label();
            this.changelog_button = new System.Windows.Forms.Button();
            this.copyright_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientversion_label
            // 
            this.clientversion_label.AutoSize = true;
            this.clientversion_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientversion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientversion_label.Location = new System.Drawing.Point(0, 0);
            this.clientversion_label.Name = "clientversion_label";
            this.clientversion_label.Size = new System.Drawing.Size(191, 17);
            this.clientversion_label.TabIndex = 0;
            this.clientversion_label.Text = "Client Version: 0.1.1.0_BETA";
            this.clientversion_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // debugversion_label
            // 
            this.debugversion_label.AutoSize = true;
            this.debugversion_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.debugversion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugversion_label.Location = new System.Drawing.Point(0, 17);
            this.debugversion_label.Name = "debugversion_label";
            this.debugversion_label.Size = new System.Drawing.Size(220, 17);
            this.debugversion_label.TabIndex = 1;
            this.debugversion_label.Text = "Debug-Version: 0.1.0.12_DEBUG";
            this.debugversion_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frameworkversion_label
            // 
            this.frameworkversion_label.AutoSize = true;
            this.frameworkversion_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.frameworkversion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameworkversion_label.Location = new System.Drawing.Point(0, 34);
            this.frameworkversion_label.Name = "frameworkversion_label";
            this.frameworkversion_label.Size = new System.Drawing.Size(279, 17);
            this.frameworkversion_label.TabIndex = 2;
            this.frameworkversion_label.Text = "Framework-Version: .NET Framework 4.7.2";
            // 
            // winforms2version_label
            // 
            this.winforms2version_label.AutoSize = true;
            this.winforms2version_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.winforms2version_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winforms2version_label.Location = new System.Drawing.Point(0, 51);
            this.winforms2version_label.Name = "winforms2version_label";
            this.winforms2version_label.Size = new System.Drawing.Size(216, 17);
            this.winforms2version_label.TabIndex = 3;
            this.winforms2version_label.Text = "WinForms2-Version: 1.0.1462.37";
            // 
            // changelog_button
            // 
            this.changelog_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changelog_button.AutoSize = true;
            this.changelog_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changelog_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changelog_button.Location = new System.Drawing.Point(3, 426);
            this.changelog_button.Name = "changelog_button";
            this.changelog_button.Size = new System.Drawing.Size(68, 23);
            this.changelog_button.TabIndex = 4;
            this.changelog_button.Text = "Changelog";
            this.changelog_button.UseVisualStyleBackColor = true;
            this.changelog_button.Click += new System.EventHandler(this.changelog_button_Click);
            // 
            // copyright_label
            // 
            this.copyright_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyright_label.AutoSize = true;
            this.copyright_label.Location = new System.Drawing.Point(623, 431);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(165, 13);
            this.copyright_label.TabIndex = 5;
            this.copyright_label.Text = "Copyright © 2023 Adrian Albrecht";
            // 
            // settings_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.copyright_label);
            this.Controls.Add(this.changelog_button);
            this.Controls.Add(this.winforms2version_label);
            this.Controls.Add(this.frameworkversion_label);
            this.Controls.Add(this.debugversion_label);
            this.Controls.Add(this.clientversion_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settings_window";
            this.Text = "Clientinformationen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settings_window_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label clientversion_label;
        private Label debugversion_label;
        private Label frameworkversion_label;
        private Label winforms2version_label;
        private Button changelog_button;
        private Label copyright_label;
    }
}