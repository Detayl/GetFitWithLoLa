namespace LeagueWorkoutProgram
{
    partial class frmWorkoutProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkoutProgram));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblYourKills = new System.Windows.Forms.Label();
            this.lblYourDeaths = new System.Windows.Forms.Label();
            this.lblYourAssists = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radPushups = new System.Windows.Forms.RadioButton();
            this.radSitups = new System.Windows.Forms.RadioButton();
            this.radSquats = new System.Windows.Forms.RadioButton();
            this.lblSelector = new System.Windows.Forms.Label();
            this.lblYours = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTeamAssistHigh = new System.Windows.Forms.Label();
            this.lblTeamDeathLow = new System.Windows.Forms.Label();
            this.lblTeamKillHigh = new System.Windows.Forms.Label();
            this.picBraum = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBraum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerate.Image")));
            this.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerate.Location = new System.Drawing.Point(339, 32);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(129, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(101, 33);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(232, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(13, 37);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(83, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Your Username:";
            // 
            // lblYourKills
            // 
            this.lblYourKills.AutoSize = true;
            this.lblYourKills.Location = new System.Drawing.Point(14, 148);
            this.lblYourKills.Name = "lblYourKills";
            this.lblYourKills.Size = new System.Drawing.Size(37, 13);
            this.lblYourKills.TabIndex = 3;
            this.lblYourKills.Text = "Kills: 0";
            // 
            // lblYourDeaths
            // 
            this.lblYourDeaths.AutoSize = true;
            this.lblYourDeaths.Location = new System.Drawing.Point(120, 148);
            this.lblYourDeaths.Name = "lblYourDeaths";
            this.lblYourDeaths.Size = new System.Drawing.Size(53, 13);
            this.lblYourDeaths.TabIndex = 4;
            this.lblYourDeaths.Text = "Deaths: 0";
            // 
            // lblYourAssists
            // 
            this.lblYourAssists.AutoSize = true;
            this.lblYourAssists.Location = new System.Drawing.Point(242, 148);
            this.lblYourAssists.Name = "lblYourAssists";
            this.lblYourAssists.Size = new System.Drawing.Size(51, 13);
            this.lblYourAssists.TabIndex = 5;
            this.lblYourAssists.Text = "Assists: 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // radPushups
            // 
            this.radPushups.AutoSize = true;
            this.radPushups.Location = new System.Drawing.Point(17, 90);
            this.radPushups.Name = "radPushups";
            this.radPushups.Size = new System.Drawing.Size(66, 17);
            this.radPushups.TabIndex = 7;
            this.radPushups.TabStop = true;
            this.radPushups.Text = "Pushups";
            this.radPushups.UseVisualStyleBackColor = true;
            this.radPushups.CheckedChanged += new System.EventHandler(this.radPushups_CheckedChanged);
            // 
            // radSitups
            // 
            this.radSitups.AutoSize = true;
            this.radSitups.Location = new System.Drawing.Point(120, 90);
            this.radSitups.Name = "radSitups";
            this.radSitups.Size = new System.Drawing.Size(54, 17);
            this.radSitups.TabIndex = 8;
            this.radSitups.TabStop = true;
            this.radSitups.Text = "Situps";
            this.radSitups.UseVisualStyleBackColor = true;
            this.radSitups.CheckedChanged += new System.EventHandler(this.radSitups_CheckedChanged);
            // 
            // radSquats
            // 
            this.radSquats.AutoSize = true;
            this.radSquats.Location = new System.Drawing.Point(242, 90);
            this.radSquats.Name = "radSquats";
            this.radSquats.Size = new System.Drawing.Size(58, 17);
            this.radSquats.TabIndex = 9;
            this.radSquats.TabStop = true;
            this.radSquats.Text = "Squats";
            this.radSquats.UseVisualStyleBackColor = true;
            this.radSquats.CheckedChanged += new System.EventHandler(this.radSquats_CheckedChanged);
            // 
            // lblSelector
            // 
            this.lblSelector.AutoSize = true;
            this.lblSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelector.Location = new System.Drawing.Point(12, 66);
            this.lblSelector.Name = "lblSelector";
            this.lblSelector.Size = new System.Drawing.Size(95, 13);
            this.lblSelector.TabIndex = 10;
            this.lblSelector.Text = "Workout Selection";
            // 
            // lblYours
            // 
            this.lblYours.AutoSize = true;
            this.lblYours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYours.Location = new System.Drawing.Point(12, 125);
            this.lblYours.Name = "lblYours";
            this.lblYours.Size = new System.Drawing.Size(34, 13);
            this.lblYours.TabIndex = 11;
            this.lblYours.Text = "Yours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Team Highest";
            // 
            // lblTeamAssistHigh
            // 
            this.lblTeamAssistHigh.AutoSize = true;
            this.lblTeamAssistHigh.Location = new System.Drawing.Point(242, 213);
            this.lblTeamAssistHigh.Name = "lblTeamAssistHigh";
            this.lblTeamAssistHigh.Size = new System.Drawing.Size(51, 13);
            this.lblTeamAssistHigh.TabIndex = 15;
            this.lblTeamAssistHigh.Text = "Assists: 0";
            // 
            // lblTeamDeathLow
            // 
            this.lblTeamDeathLow.AutoSize = true;
            this.lblTeamDeathLow.Location = new System.Drawing.Point(120, 213);
            this.lblTeamDeathLow.Name = "lblTeamDeathLow";
            this.lblTeamDeathLow.Size = new System.Drawing.Size(53, 13);
            this.lblTeamDeathLow.TabIndex = 14;
            this.lblTeamDeathLow.Text = "Deaths: 0";
            // 
            // lblTeamKillHigh
            // 
            this.lblTeamKillHigh.AutoSize = true;
            this.lblTeamKillHigh.Location = new System.Drawing.Point(14, 213);
            this.lblTeamKillHigh.Name = "lblTeamKillHigh";
            this.lblTeamKillHigh.Size = new System.Drawing.Size(37, 13);
            this.lblTeamKillHigh.TabIndex = 13;
            this.lblTeamKillHigh.Text = "Kills: 0";
            // 
            // picBraum
            // 
            this.picBraum.Image = ((System.Drawing.Image)(resources.GetObject("picBraum.Image")));
            this.picBraum.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBraum.InitialImage")));
            this.picBraum.Location = new System.Drawing.Point(327, 66);
            this.picBraum.Name = "picBraum";
            this.picBraum.Size = new System.Drawing.Size(141, 131);
            this.picBraum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBraum.TabIndex = 16;
            this.picBraum.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(324, 213);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 16);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Total: 0";
            // 
            // frmWorkoutProgram
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 238);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.picBraum);
            this.Controls.Add(this.lblTeamAssistHigh);
            this.Controls.Add(this.lblTeamDeathLow);
            this.Controls.Add(this.lblTeamKillHigh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblYours);
            this.Controls.Add(this.lblSelector);
            this.Controls.Add(this.radSquats);
            this.Controls.Add(this.radSitups);
            this.Controls.Add(this.radPushups);
            this.Controls.Add(this.lblYourAssists);
            this.Controls.Add(this.lblYourDeaths);
            this.Controls.Add(this.lblYourKills);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmWorkoutProgram";
            this.Text = "GFWL - Get Fit With LoL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBraum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblYourKills;
        private System.Windows.Forms.Label lblYourDeaths;
        private System.Windows.Forms.Label lblYourAssists;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RadioButton radPushups;
        private System.Windows.Forms.RadioButton radSitups;
        private System.Windows.Forms.RadioButton radSquats;
        private System.Windows.Forms.Label lblSelector;
        private System.Windows.Forms.Label lblYours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTeamAssistHigh;
        private System.Windows.Forms.Label lblTeamDeathLow;
        private System.Windows.Forms.Label lblTeamKillHigh;
        private System.Windows.Forms.PictureBox picBraum;
        private System.Windows.Forms.Label lblTotal;
    }
}

