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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jira Url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "vso Url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Jira Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jira Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "vso Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "vso Password";
            // 
            // btnApplyConfig
            // 
            this.btnApplyConfig.Location = new System.Drawing.Point(325, 255);
            this.btnApplyConfig.Name = "btnApplyConfig";
            this.btnApplyConfig.Size = new System.Drawing.Size(75, 23);
            this.btnApplyConfig.TabIndex = 5;
            this.btnApplyConfig.Text = "Apply";
            this.btnApplyConfig.UseVisualStyleBackColor = true;
            this.btnApplyConfig.Click += new System.EventHandler(this.btnApplyConfig_Click);
            // 
            // txtJiraUrl
            // 
            this.txtJiraUrl.Location = new System.Drawing.Point(113, 53);
            this.txtJiraUrl.Name = "txtJiraUrl";
            this.txtJiraUrl.Size = new System.Drawing.Size(276, 20);
            this.txtJiraUrl.TabIndex = 6;
            // 
            // txtJiraUsername
            // 
            this.txtJiraUsername.Location = new System.Drawing.Point(113, 79);
            this.txtJiraUsername.Name = "txtJiraUsername";
            this.txtJiraUsername.Size = new System.Drawing.Size(276, 20);
            this.txtJiraUsername.TabIndex = 7;
            // 
            // txtJiraPwd
            // 
            this.txtJiraPwd.Location = new System.Drawing.Point(113, 106);
            this.txtJiraPwd.Name = "txtJiraPwd";
            this.txtJiraPwd.PasswordChar = '*';
            this.txtJiraPwd.Size = new System.Drawing.Size(276, 20);
            this.txtJiraPwd.TabIndex = 8;
            // 
            // txtVsoUrl
            // 
            this.txtVsoUrl.Location = new System.Drawing.Point(95, 22);
            this.txtVsoUrl.Name = "txtVsoUrl";
            this.txtVsoUrl.Size = new System.Drawing.Size(276, 23);
            this.txtVsoUrl.TabIndex = 9;
            // 
            // txtVsoUsername
            // 
            this.txtVsoUsername.Location = new System.Drawing.Point(95, 51);
            this.txtVsoUsername.Name = "txtVsoUsername";
            this.txtVsoUsername.Size = new System.Drawing.Size(276, 23);
            this.txtVsoUsername.TabIndex = 10;
            // 
            // txtVsoPwd
            // 
            this.txtVsoPwd.Location = new System.Drawing.Point(95, 80);
            this.txtVsoPwd.Name = "txtVsoPwd";
            this.txtVsoPwd.PasswordChar = '*';
            this.txtVsoPwd.Size = new System.Drawing.Size(276, 23);
            this.txtVsoPwd.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 102);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jira";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVsoPwd);
            this.groupBox2.Controls.Add(this.txtVsoUsername);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtVsoUrl);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 111);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visual Studio Online";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Configuration";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 287);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtJiraPwd);
            this.Controls.Add(this.txtJiraUsername);
            this.Controls.Add(this.txtJiraUrl);
            this.Controls.Add(this.btnApplyConfig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
    }
}