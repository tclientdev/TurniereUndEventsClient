namespace Turniere_und_Events_Client
{
    partial class changelog_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changelog_window));
            this.change1_label = new System.Windows.Forms.Label();
            this.change2_label = new System.Windows.Forms.Label();
            this.update_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // change1_label
            // 
            this.change1_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.change1_label.AutoSize = true;
            this.change1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change1_label.Location = new System.Drawing.Point(280, 63);
            this.change1_label.Name = "change1_label";
            this.change1_label.Size = new System.Drawing.Size(223, 17);
            this.change1_label.TabIndex = 0;
            this.change1_label.Text = "Update auf .NET Framework 4.7.2";
            // 
            // change2_label
            // 
            this.change2_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.change2_label.AutoSize = true;
            this.change2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change2_label.Location = new System.Drawing.Point(280, 91);
            this.change2_label.Name = "change2_label";
            this.change2_label.Size = new System.Drawing.Size(205, 17);
            this.change2_label.TabIndex = 1;
            this.change2_label.Text = "Changelog-System hinzugefügt";
            // 
            // update_label
            // 
            this.update_label.AutoSize = true;
            this.update_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_label.Location = new System.Drawing.Point(3, 9);
            this.update_label.Name = "update_label";
            this.update_label.Size = new System.Drawing.Size(203, 25);
            this.update_label.TabIndex = 2;
            this.update_label.Text = "Update 0.1.1.0_BETA";
            // 
            // changelog_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.update_label);
            this.Controls.Add(this.change2_label);
            this.Controls.Add(this.change1_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "changelog_window";
            this.Text = "Changelog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.changelog_window_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label change1_label;
        private System.Windows.Forms.Label change2_label;
        private System.Windows.Forms.Label update_label;
    }
}