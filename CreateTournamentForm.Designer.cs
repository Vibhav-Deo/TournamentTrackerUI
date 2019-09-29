namespace TRackerUI
{
    partial class CreateTournamentForm
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentNameTextbox = new System.Windows.Forms.TextBox();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.EntryFeeTextbox = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.SelectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.SeletTeamLabel = new System.Windows.Forms.Label();
            this.CreateTeamLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.TournamenPlayersListBox = new System.Windows.Forms.ListBox();
            this.TournamentPlayersListLabel = new System.Windows.Forms.Label();
            this.DeleteSelectedPlayersButton = new System.Windows.Forms.Button();
            this.DeleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.PrizesLabel = new System.Windows.Forms.Label();
            this.PrizesListBox = new System.Windows.Forms.ListBox();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(425, 62);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Create Tournament";
            this.HeaderLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // TournamentNameTextbox
            // 
            this.TournamentNameTextbox.Location = new System.Drawing.Point(208, 75);
            this.TournamentNameTextbox.Name = "TournamentNameTextbox";
            this.TournamentNameTextbox.Size = new System.Drawing.Size(353, 42);
            this.TournamentNameTextbox.TabIndex = 12;
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentNameLabel.Location = new System.Drawing.Point(16, 80);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(236, 37);
            this.TournamentNameLabel.TabIndex = 11;
            this.TournamentNameLabel.Text = "Tournament Name";
            // 
            // EntryFeeTextbox
            // 
            this.EntryFeeTextbox.Location = new System.Drawing.Point(208, 128);
            this.EntryFeeTextbox.Name = "EntryFeeTextbox";
            this.EntryFeeTextbox.Size = new System.Drawing.Size(100, 42);
            this.EntryFeeTextbox.TabIndex = 14;
            this.EntryFeeTextbox.Text = "0";
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.EntryFeeLabel.Location = new System.Drawing.Point(16, 133);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(125, 37);
            this.EntryFeeLabel.TabIndex = 13;
            this.EntryFeeLabel.Text = "Entry Fee";
            // 
            // SelectTeamDropdown
            // 
            this.SelectTeamDropdown.FormattingEnabled = true;
            this.SelectTeamDropdown.Location = new System.Drawing.Point(208, 177);
            this.SelectTeamDropdown.Name = "SelectTeamDropdown";
            this.SelectTeamDropdown.Size = new System.Drawing.Size(353, 44);
            this.SelectTeamDropdown.TabIndex = 16;
            // 
            // SeletTeamLabel
            // 
            this.SeletTeamLabel.AutoSize = true;
            this.SeletTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SeletTeamLabel.Location = new System.Drawing.Point(16, 185);
            this.SeletTeamLabel.Name = "SeletTeamLabel";
            this.SeletTeamLabel.Size = new System.Drawing.Size(156, 37);
            this.SeletTeamLabel.TabIndex = 15;
            this.SeletTeamLabel.Text = "Select Team";
            // 
            // CreateTeamLinkLabel
            // 
            this.CreateTeamLinkLabel.AutoSize = true;
            this.CreateTeamLinkLabel.Location = new System.Drawing.Point(405, 137);
            this.CreateTeamLinkLabel.Name = "CreateTeamLinkLabel";
            this.CreateTeamLinkLabel.Size = new System.Drawing.Size(156, 37);
            this.CreateTeamLinkLabel.TabIndex = 18;
            this.CreateTeamLinkLabel.TabStop = true;
            this.CreateTeamLinkLabel.Text = "CreateTeam";
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddTeamButton.Location = new System.Drawing.Point(326, 260);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(144, 49);
            this.AddTeamButton.TabIndex = 19;
            this.AddTeamButton.Text = "AddTeam";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreatePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreatePrizeButton.Location = new System.Drawing.Point(326, 331);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(144, 49);
            this.CreatePrizeButton.TabIndex = 20;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // TournamenPlayersListBox
            // 
            this.TournamenPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamenPlayersListBox.FormattingEnabled = true;
            this.TournamenPlayersListBox.ItemHeight = 36;
            this.TournamenPlayersListBox.Location = new System.Drawing.Point(644, 75);
            this.TournamenPlayersListBox.Name = "TournamenPlayersListBox";
            this.TournamenPlayersListBox.Size = new System.Drawing.Size(314, 182);
            this.TournamenPlayersListBox.TabIndex = 21;
            // 
            // TournamentPlayersListLabel
            // 
            this.TournamentPlayersListLabel.AutoSize = true;
            this.TournamentPlayersListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentPlayersListLabel.Location = new System.Drawing.Point(639, 25);
            this.TournamentPlayersListLabel.Name = "TournamentPlayersListLabel";
            this.TournamentPlayersListLabel.Size = new System.Drawing.Size(266, 37);
            this.TournamentPlayersListLabel.TabIndex = 22;
            this.TournamentPlayersListLabel.Text = "Tournament / Players";
            // 
            // DeleteSelectedPlayersButton
            // 
            this.DeleteSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPlayersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedPlayersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DeleteSelectedPlayersButton.Location = new System.Drawing.Point(985, 172);
            this.DeleteSelectedPlayersButton.Name = "DeleteSelectedPlayersButton";
            this.DeleteSelectedPlayersButton.Size = new System.Drawing.Size(144, 85);
            this.DeleteSelectedPlayersButton.TabIndex = 23;
            this.DeleteSelectedPlayersButton.Text = "Delete Selected";
            this.DeleteSelectedPlayersButton.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedPrizeButton
            // 
            this.DeleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DeleteSelectedPrizeButton.Location = new System.Drawing.Point(985, 452);
            this.DeleteSelectedPrizeButton.Name = "DeleteSelectedPrizeButton";
            this.DeleteSelectedPrizeButton.Size = new System.Drawing.Size(144, 84);
            this.DeleteSelectedPrizeButton.TabIndex = 26;
            this.DeleteSelectedPrizeButton.Text = "Delete Selected";
            this.DeleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // PrizesLabel
            // 
            this.PrizesLabel.AutoSize = true;
            this.PrizesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PrizesLabel.Location = new System.Drawing.Point(639, 304);
            this.PrizesLabel.Name = "PrizesLabel";
            this.PrizesLabel.Size = new System.Drawing.Size(85, 37);
            this.PrizesLabel.TabIndex = 25;
            this.PrizesLabel.Text = "Prizes";
            // 
            // PrizesListBox
            // 
            this.PrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizesListBox.FormattingEnabled = true;
            this.PrizesListBox.ItemHeight = 36;
            this.PrizesListBox.Location = new System.Drawing.Point(644, 354);
            this.PrizesListBox.Name = "PrizesListBox";
            this.PrizesListBox.Size = new System.Drawing.Size(314, 182);
            this.PrizesListBox.TabIndex = 24;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamentButton.Location = new System.Drawing.Point(456, 586);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(220, 51);
            this.CreateTournamentButton.TabIndex = 27;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 663);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.DeleteSelectedPrizeButton);
            this.Controls.Add(this.PrizesLabel);
            this.Controls.Add(this.PrizesListBox);
            this.Controls.Add(this.DeleteSelectedPlayersButton);
            this.Controls.Add(this.TournamentPlayersListLabel);
            this.Controls.Add(this.TournamenPlayersListBox);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreateTeamLinkLabel);
            this.Controls.Add(this.SelectTeamDropdown);
            this.Controls.Add(this.SeletTeamLabel);
            this.Controls.Add(this.EntryFeeTextbox);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameTextbox);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox TournamentNameTextbox;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.TextBox EntryFeeTextbox;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.ComboBox SelectTeamDropdown;
        private System.Windows.Forms.Label SeletTeamLabel;
        private System.Windows.Forms.LinkLabel CreateTeamLinkLabel;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button CreatePrizeButton;
        private System.Windows.Forms.ListBox TournamenPlayersListBox;
        private System.Windows.Forms.Label TournamentPlayersListLabel;
        private System.Windows.Forms.Button DeleteSelectedPlayersButton;
        private System.Windows.Forms.Button DeleteSelectedPrizeButton;
        private System.Windows.Forms.Label PrizesLabel;
        private System.Windows.Forms.ListBox PrizesListBox;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}