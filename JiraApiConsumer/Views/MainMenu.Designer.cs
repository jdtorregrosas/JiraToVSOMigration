namespace JiraApiConsumer.Views
{
    partial class Mainmenu
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
            this.btnStartMigration = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBarMigration = new System.Windows.Forms.ProgressBar();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cbSprints = new System.Windows.Forms.CheckBox();
            this.cbProjects = new System.Windows.Forms.CheckBox();
            this.gpMigrationSettings = new System.Windows.Forms.GroupBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartMigration
            // 
            this.btnStartMigration.Location = new System.Drawing.Point(12, 213);
            this.btnStartMigration.Name = "btnStartMigration";
            this.btnStartMigration.Size = new System.Drawing.Size(402, 23);
            this.btnStartMigration.TabIndex = 1;
            this.btnStartMigration.Text = "Start Migration";
            this.btnStartMigration.UseVisualStyleBackColor = true;
            this.btnStartMigration.Click += new System.EventHandler(this.btnStartMigration_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackgroundImage = global::JiraApiConsumer.Properties.Resources.Settings;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(12, 12);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(36, 36);
            this.btnConfig.TabIndex = 0;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::JiraApiConsumer.Properties.Resources.jiraToVso;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 153);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // progressBarMigration
            // 
            this.progressBarMigration.Location = new System.Drawing.Point(12, 242);
            this.progressBarMigration.Name = "progressBarMigration";
            this.progressBarMigration.Size = new System.Drawing.Size(402, 23);
            this.progressBarMigration.TabIndex = 3;
            this.progressBarMigration.Visible = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(23, 363);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(52, 17);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "Epics";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(23, 340);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(55, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Tasks";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // cbSprints
            // 
            this.cbSprints.AutoSize = true;
            this.cbSprints.Location = new System.Drawing.Point(23, 317);
            this.cbSprints.Name = "cbSprints";
            this.cbSprints.Size = new System.Drawing.Size(58, 17);
            this.cbSprints.TabIndex = 7;
            this.cbSprints.Text = "Sprints";
            this.cbSprints.UseVisualStyleBackColor = true;
            // 
            // cbProjects
            // 
            this.cbProjects.AutoSize = true;
            this.cbProjects.Location = new System.Drawing.Point(23, 294);
            this.cbProjects.Name = "cbProjects";
            this.cbProjects.Size = new System.Drawing.Size(64, 17);
            this.cbProjects.TabIndex = 6;
            this.cbProjects.Text = "Projects";
            this.cbProjects.UseVisualStyleBackColor = true;
            this.cbProjects.CheckedChanged += new System.EventHandler(this.cbProjects_CheckedChanged);
            // 
            // gpMigrationSettings
            // 
            this.gpMigrationSettings.Location = new System.Drawing.Point(12, 269);
            this.gpMigrationSettings.Name = "gpMigrationSettings";
            this.gpMigrationSettings.Size = new System.Drawing.Size(402, 125);
            this.gpMigrationSettings.TabIndex = 10;
            this.gpMigrationSettings.TabStop = false;
            this.gpMigrationSettings.Text = "Elements to Migrate:";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(441, 41);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(380, 339);
            this.txtDetails.TabIndex = 12;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDetails.Location = new System.Drawing.Point(342, 12);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(82, 13);
            this.lblDetails.TabIndex = 13;
            this.lblDetails.Text = "Show details >>";
            this.lblDetails.Visible = false;
            this.lblDetails.Click += new System.EventHandler(this.lblDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Migration Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Message:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(71, 401);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(24, 13);
            this.lblInfo.TabIndex = 16;
            this.lblInfo.Text = "info";
            this.lblInfo.Visible = false;
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 422);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.cbSprints);
            this.Controls.Add(this.cbProjects);
            this.Controls.Add(this.gpMigrationSettings);
            this.Controls.Add(this.progressBarMigration);
            this.Controls.Add(this.btnStartMigration);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Mainmenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.Mainmenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnStartMigration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBarMigration;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox cbSprints;
        private System.Windows.Forms.CheckBox cbProjects;
        private System.Windows.Forms.GroupBox gpMigrationSettings;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInfo;
    }
}