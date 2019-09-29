namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.ScoreButton = new System.Windows.Forms.Button();
            this.VS = new System.Windows.Forms.Label();
            this.TeamTwoScoreTextbox = new System.Windows.Forms.TextBox();
            this.TeamOneScoreTextbox = new System.Windows.Forms.TextBox();
            this.TeamTwoScore = new System.Windows.Forms.Label();
            this.TeamOneScore = new System.Windows.Forms.Label();
            this.TeamTwo = new System.Windows.Forms.Label();
            this.TeamOne = new System.Windows.Forms.Label();
            this.MatchUpListBox = new System.Windows.Forms.ListBox();
            this.UnplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.RoundDropdown = new System.Windows.Forms.ComboBox();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ScoreButton
            // 
            this.ScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ScoreButton.Location = new System.Drawing.Point(791, 351);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(106, 49);
            this.ScoreButton.TabIndex = 27;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            // 
            // VS
            // 
            this.VS.AutoSize = true;
            this.VS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.VS.Location = new System.Drawing.Point(569, 363);
            this.VS.Name = "VS";
            this.VS.Size = new System.Drawing.Size(71, 38);
            this.VS.TabIndex = 26;
            this.VS.Text = "-VS-";
            // 
            // TeamTwoScoreTextbox
            // 
            this.TeamTwoScoreTextbox.Location = new System.Drawing.Point(600, 454);
            this.TeamTwoScoreTextbox.Name = "TeamTwoScoreTextbox";
            this.TeamTwoScoreTextbox.Size = new System.Drawing.Size(100, 43);
            this.TeamTwoScoreTextbox.TabIndex = 25;
            // 
            // TeamOneScoreTextbox
            // 
            this.TeamOneScoreTextbox.Location = new System.Drawing.Point(602, 300);
            this.TeamOneScoreTextbox.Name = "TeamOneScoreTextbox";
            this.TeamOneScoreTextbox.Size = new System.Drawing.Size(100, 43);
            this.TeamOneScoreTextbox.TabIndex = 24;
            // 
            // TeamTwoScore
            // 
            this.TeamTwoScore.AutoSize = true;
            this.TeamTwoScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamTwoScore.Location = new System.Drawing.Point(505, 459);
            this.TeamTwoScore.Name = "TeamTwoScore";
            this.TeamTwoScore.Size = new System.Drawing.Size(92, 38);
            this.TeamTwoScore.TabIndex = 23;
            this.TeamTwoScore.Text = "Score:";
            // 
            // TeamOneScore
            // 
            this.TeamOneScore.AutoSize = true;
            this.TeamOneScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamOneScore.Location = new System.Drawing.Point(507, 305);
            this.TeamOneScore.Name = "TeamOneScore";
            this.TeamOneScore.Size = new System.Drawing.Size(92, 38);
            this.TeamOneScore.TabIndex = 22;
            this.TeamOneScore.Text = "Score:";
            // 
            // TeamTwo
            // 
            this.TeamTwo.AutoSize = true;
            this.TeamTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamTwo.Location = new System.Drawing.Point(505, 416);
            this.TeamTwo.Name = "TeamTwo";
            this.TeamTwo.Size = new System.Drawing.Size(137, 38);
            this.TeamTwo.TabIndex = 21;
            this.TeamTwo.Text = "TeamTwo:";
            // 
            // TeamOne
            // 
            this.TeamOne.AutoSize = true;
            this.TeamOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamOne.Location = new System.Drawing.Point(505, 264);
            this.TeamOne.Name = "TeamOne";
            this.TeamOne.Size = new System.Drawing.Size(140, 38);
            this.TeamOne.TabIndex = 20;
            this.TeamOne.Text = "TeamOne:";
            // 
            // MatchUpListBox
            // 
            this.MatchUpListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchUpListBox.FormattingEnabled = true;
            this.MatchUpListBox.ItemHeight = 37;
            this.MatchUpListBox.Location = new System.Drawing.Point(33, 265);
            this.MatchUpListBox.Name = "MatchUpListBox";
            this.MatchUpListBox.Size = new System.Drawing.Size(356, 224);
            this.MatchUpListBox.TabIndex = 19;
            this.MatchUpListBox.SelectedIndexChanged += new System.EventHandler(this.MatchUpListBox_SelectedIndexChanged);
            // 
            // UnplayedOnlyCheckbox
            // 
            this.UnplayedOnlyCheckbox.AutoSize = true;
            this.UnplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlyCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.UnplayedOnlyCheckbox.Location = new System.Drawing.Point(33, 164);
            this.UnplayedOnlyCheckbox.Name = "UnplayedOnlyCheckbox";
            this.UnplayedOnlyCheckbox.Size = new System.Drawing.Size(218, 42);
            this.UnplayedOnlyCheckbox.TabIndex = 18;
            this.UnplayedOnlyCheckbox.Text = "Unplayed Only";
            this.UnplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // RoundDropdown
            // 
            this.RoundDropdown.FormattingEnabled = true;
            this.RoundDropdown.Location = new System.Drawing.Point(346, 99);
            this.RoundDropdown.Name = "RoundDropdown";
            this.RoundDropdown.Size = new System.Drawing.Size(405, 45);
            this.RoundDropdown.TabIndex = 17;
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.RoundLabel.Location = new System.Drawing.Point(26, 106);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(103, 38);
            this.RoundLabel.TabIndex = 16;
            this.RoundLabel.Text = "Round:";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentName.Location = new System.Drawing.Point(335, 24);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(332, 62);
            this.TournamentName.TabIndex = 15;
            this.TournamentName.Text = "<Yet to Enter>";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(22, 24);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(287, 62);
            this.HeaderLabel.TabIndex = 14;
            this.HeaderLabel.Text = "Tournament:";
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 534);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.VS);
            this.Controls.Add(this.TeamTwoScoreTextbox);
            this.Controls.Add(this.TeamOneScoreTextbox);
            this.Controls.Add(this.TeamTwoScore);
            this.Controls.Add(this.TeamOneScore);
            this.Controls.Add(this.TeamTwo);
            this.Controls.Add(this.TeamOne);
            this.Controls.Add(this.MatchUpListBox);
            this.Controls.Add(this.UnplayedOnlyCheckbox);
            this.Controls.Add(this.RoundDropdown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "TournamentViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ScoreButton;
        private System.Windows.Forms.Label VS;
        private System.Windows.Forms.TextBox TeamTwoScoreTextbox;
        private System.Windows.Forms.TextBox TeamOneScoreTextbox;
        private System.Windows.Forms.Label TeamTwoScore;
        private System.Windows.Forms.Label TeamOneScore;
        private System.Windows.Forms.Label TeamTwo;
        private System.Windows.Forms.Label TeamOne;
        private System.Windows.Forms.ListBox MatchUpListBox;
        private System.Windows.Forms.CheckBox UnplayedOnlyCheckbox;
        private System.Windows.Forms.ComboBox RoundDropdown;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label HeaderLabel;
    }
}