namespace JiraApiConsumer.Views
{
    partial class Config
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnApplyConfig = new System.Windows.Forms.Button();
            this.txtJiraUrl = new System.Windows.Forms.TextBox();
            this.txtJiraUsername = new System.Windows.Forms.TextBox();
            this.txtJiraPwd = new System.Windows.Forms.TextBox();
            this.txtVsoUrl = new System.Windows.Forms.TextBox();
            this.txtVsoUsername = new System.Windows.Forms.TextBox();
            this.txtVsoPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jira Url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "vso Url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Jira Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jira Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "vso Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "vso Password";
            // 
            // btnApplyConfig
            // 
            this.btnApplyConfig.Location = new System.Drawing.Point(313, 195);
            this.btnApplyConfig.Name = "btnApplyConfig";
            this.btnApplyConfig.Size = new System.Drawing.Size(75, 23);
            this.btnApplyConfig.TabIndex = 5;
            this.btnApplyConfig.Text = "Apply";
            this.btnApplyConfig.UseVisualStyleBackColor = true;
            this.btnApplyConfig.Click += new System.EventHandler(this.btnApplyConfig_Click);
            // 
            // txtJiraUrl
            // 
            this.txtJiraUrl.Location = new System.Drawing.Point(112, 35);
            this.txtJiraUrl.Name = "txtJiraUrl";
            this.txtJiraUrl.Size = new System.Drawing.Size(276, 20);
            this.txtJiraUrl.TabIndex = 6;
            // 
            // txtJiraUsername
            // 
            this.txtJiraUsername.Location = new System.Drawing.Point(112, 61);
            this.txtJiraUsername.Name = "txtJiraUsername";
            this.txtJiraUsername.Size = new System.Drawing.Size(276, 20);
            this.txtJiraUsername.TabIndex = 7;
            // 
            // txtJiraPwd
            // 
            this.txtJiraPwd.Location = new System.Drawing.Point(112, 88);
            this.txtJiraPwd.Name = "txtJiraPwd";
            this.txtJiraPwd.PasswordChar = '*';
            this.txtJiraPwd.Size = new System.Drawing.Size(276, 20);
            this.txtJiraPwd.TabIndex = 8;
            // 
            // txtVsoUrl
            // 
            this.txtVsoUrl.Location = new System.Drawing.Point(112, 113);
            this.txtVsoUrl.Name = "txtVsoUrl";
            this.txtVsoUrl.Size = new System.Drawing.Size(276, 20);
            this.txtVsoUrl.TabIndex = 9;
            // 
            // txtVsoUsername
            // 
            this.txtVsoUsername.Location = new System.Drawing.Point(112, 142);
            this.txtVsoUsername.Name = "txtVsoUsername";
            this.txtVsoUsername.Size = new System.Drawing.Size(276, 20);
            this.txtVsoUsername.TabIndex = 10;
            // 
            // txtVsoPwd
            // 
            this.txtVsoPwd.Location = new System.Drawing.Point(112, 169);
            this.txtVsoPwd.Name = "txtVsoPwd";
            this.txtVsoPwd.PasswordChar = '*';
            this.txtVsoPwd.Size = new System.Drawing.Size(276, 20);
            this.txtVsoPwd.TabIndex = 11;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 251);
            this.Controls.Add(this.txtVsoPwd);
            this.Controls.Add(this.txtVsoUsername);
            this.Controls.Add(this.txtVsoUrl);
            this.Controls.Add(this.txtJiraPwd);
            this.Controls.Add(this.txtJiraUsername);
            this.Controls.Add(this.txtJiraUrl);
            this.Controls.Add(this.btnApplyConfig);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnApplyConfig;
        private System.Windows.Forms.TextBox txtJiraUrl;
        private System.Windows.Forms.TextBox txtJiraUsername;
        private System.Windows.Forms.TextBox txtJiraPwd;
        private System.Windows.Forms.TextBox txtVsoUrl;
        private System.Windows.Forms.TextBox txtVsoUsername;
        private System.Windows.Forms.TextBox txtVsoPwd;
    }
}