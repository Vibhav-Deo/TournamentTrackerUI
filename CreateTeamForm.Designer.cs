namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.TournamentNameTextbox = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.AddTeamMemberButton = new System.Windows.Forms.Button();
            this.SelectTeamMemberDropdown = new System.Windows.Forms.ComboBox();
            this.SeletTeamMemberLabel = new System.Windows.Forms.Label();
            this.AddNewMemberBox = new System.Windows.Forms.GroupBox();
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.MobileNumberTextBox = new System.Windows.Forms.TextBox();
            this.MobileNumberLabel = new System.Windows.Forms.Label();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.AddNewMemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TournamentNameTextbox
            // 
            this.TournamentNameTextbox.Location = new System.Drawing.Point(296, 74);
            this.TournamentNameTextbox.Name = "TournamentNameTextbox";
            this.TournamentNameTextbox.Size = new System.Drawing.Size(353, 42);
            this.TournamentNameTextbox.TabIndex = 15;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamNameLabel.Location = new System.Drawing.Point(16, 80);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(157, 37);
            this.TeamNameLabel.TabIndex = 14;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(284, 62);
            this.HeaderLabel.TabIndex = 13;
            this.HeaderLabel.Text = "Create Team";
            // 
            // AddTeamMemberButton
            // 
            this.AddTeamMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddTeamMemberButton.Location = new System.Drawing.Point(205, 232);
            this.AddTeamMemberButton.Name = "AddTeamMemberButton";
            this.AddTeamMemberButton.Size = new System.Drawing.Size(274, 50);
            this.AddTeamMemberButton.TabIndex = 22;
            this.AddTeamMemberButton.Text = "Add Team Member";
            this.AddTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // SelectTeamMemberDropdown
            // 
            this.SelectTeamMemberDropdown.FormattingEnabled = true;
            this.SelectTeamMemberDropdown.Location = new System.Drawing.Point(296, 145);
            this.SelectTeamMemberDropdown.Name = "SelectTeamMemberDropdown";
            this.SelectTeamMemberDropdown.Size = new System.Drawing.Size(353, 44);
            this.SelectTeamMemberDropdown.TabIndex = 21;
            // 
            // SeletTeamMemberLabel
            // 
            this.SeletTeamMemberLabel.AutoSize = true;
            this.SeletTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SeletTeamMemberLabel.Location = new System.Drawing.Point(17, 152);
            this.SeletTeamMemberLabel.Name = "SeletTeamMemberLabel";
            this.SeletTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
            this.SeletTeamMemberLabel.TabIndex = 20;
            this.SeletTeamMemberLabel.Text = "Select Team Member";
            // 
            // AddNewMemberBox
            // 
            this.AddNewMemberBox.Controls.Add(this.CreateMemberButton);
            this.AddNewMemberBox.Controls.Add(this.MobileNumberTextBox);
            this.AddNewMemberBox.Controls.Add(this.MobileNumberLabel);
            this.AddNewMemberBox.Controls.Add(this.EmailTextBox);
            this.AddNewMemberBox.Controls.Add(this.EmailLabel);
            this.AddNewMemberBox.Controls.Add(this.LastNameTextBox);
            this.AddNewMemberBox.Controls.Add(this.LastNameLabel);
            this.AddNewMemberBox.Controls.Add(this.FirstNameTextbox);
            this.AddNewMemberBox.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddNewMemberBox.Location = new System.Drawing.Point(24, 323);
            this.AddNewMemberBox.Name = "AddNewMemberBox";
            this.AddNewMemberBox.Size = new System.Drawing.Size(625, 463);
            this.AddNewMemberBox.TabIndex = 23;
            this.AddNewMemberBox.TabStop = false;
            this.AddNewMemberBox.Text = "Add New Member";
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Location = new System.Drawing.Point(233, 57);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(208, 42);
            this.FirstNameTextbox.TabIndex = 12;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.FirstNameLabel.Location = new System.Drawing.Point(22, 62);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(144, 37);
            this.FirstNameLabel.TabIndex = 11;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(233, 125);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(208, 42);
            this.LastNameTextBox.TabIndex = 14;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LastNameLabel.Location = new System.Drawing.Point(22, 130);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(142, 37);
            this.LastNameLabel.TabIndex = 13;
            this.LastNameLabel.Text = "Last Name";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(233, 194);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(208, 42);
            this.EmailTextBox.TabIndex = 16;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.EmailLabel.Location = new System.Drawing.Point(22, 199);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(82, 37);
            this.EmailLabel.TabIndex = 15;
            this.EmailLabel.Text = "Email";
            // 
            // MobileNumberTextBox
            // 
            this.MobileNumberTextBox.Location = new System.Drawing.Point(233, 261);
            this.MobileNumberTextBox.Name = "MobileNumberTextBox";
            this.MobileNumberTextBox.Size = new System.Drawing.Size(208, 42);
            this.MobileNumberTextBox.TabIndex = 18;
            // 
            // MobileNumberLabel
            // 
            this.MobileNumberLabel.AutoSize = true;
            this.MobileNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MobileNumberLabel.Location = new System.Drawing.Point(22, 266);
            this.MobileNumberLabel.Name = "MobileNumberLabel";
            this.MobileNumberLabel.Size = new System.Drawing.Size(205, 37);
            this.MobileNumberLabel.TabIndex = 17;
            this.MobileNumberLabel.Text = "Mobile Number";
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateMemberButton.Location = new System.Drawing.Point(181, 373);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(241, 54);
            this.CreateMemberButton.TabIndex = 20;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.ItemHeight = 36;
            this.TeamMembersListBox.Location = new System.Drawing.Point(746, 64);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(371, 722);
            this.TeamMembersListBox.TabIndex = 24;
            // 
            // DeleteSelectedMemberButton
            // 
            this.DeleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DeleteSelectedMemberButton.Location = new System.Drawing.Point(1148, 380);
            this.DeleteSelectedMemberButton.Name = "DeleteSelectedMemberButton";
            this.DeleteSelectedMemberButton.Size = new System.Drawing.Size(144, 85);
            this.DeleteSelectedMemberButton.TabIndex = 25;
            this.DeleteSelectedMemberButton.Text = "Delete Selected";
            this.DeleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamentButton.Location = new System.Drawing.Point(559, 822);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(265, 54);
            this.CreateTournamentButton.TabIndex = 26;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1317, 898);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.DeleteSelectedMemberButton);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.AddNewMemberBox);
            this.Controls.Add(this.AddTeamMemberButton);
            this.Controls.Add(this.SelectTeamMemberDropdown);
            this.Controls.Add(this.SeletTeamMemberLabel);
            this.Controls.Add(this.TournamentNameTextbox);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeam";
            this.AddNewMemberBox.ResumeLayout(false);
            this.AddNewMemberBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TournamentNameTextbox;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button AddTeamMemberButton;
        private System.Windows.Forms.ComboBox SelectTeamMemberDropdown;
        private System.Windows.Forms.Label SeletTeamMemberLabel;
        private System.Windows.Forms.GroupBox AddNewMemberBox;
        private System.Windows.Forms.TextBox FirstNameTextbox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox MobileNumberTextBox;
        private System.Windows.Forms.Label MobileNumberLabel;
        private System.Windows.Forms.Button CreateMemberButton;
        private System.Windows.Forms.ListBox TeamMembersListBox;
        private System.Windows.Forms.Button DeleteSelectedMemberButton;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}