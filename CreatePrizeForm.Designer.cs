namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.PlaceNumberTextbox = new System.Windows.Forms.TextBox();
            this.PlaceNumberLabel = new System.Windows.Forms.Label();
            this.PlaceNameTextBox = new System.Windows.Forms.TextBox();
            this.PlaceNameLabel = new System.Windows.Forms.Label();
            this.PrizeAmountTextBox = new System.Windows.Forms.TextBox();
            this.PrizeAmountLabel = new System.Windows.Forms.Label();
            this.PrizePercentageTextBox = new System.Windows.Forms.TextBox();
            this.PrizePercentageLabel = new System.Windows.Forms.Label();
            this.OrLabel = new System.Windows.Forms.Label();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(274, 62);
            this.HeaderLabel.TabIndex = 14;
            this.HeaderLabel.Text = "Create Prize";
            // 
            // PlaceNumberTextbox
            // 
            this.PlaceNumberTextbox.Location = new System.Drawing.Point(260, 96);
            this.PlaceNumberTextbox.Name = "PlaceNumberTextbox";
            this.PlaceNumberTextbox.Size = new System.Drawing.Size(208, 43);
            this.PlaceNumberTextbox.TabIndex = 16;
            // 
            // PlaceNumberLabel
            // 
            this.PlaceNumberLabel.AutoSize = true;
            this.PlaceNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PlaceNumberLabel.Location = new System.Drawing.Point(16, 101);
            this.PlaceNumberLabel.Name = "PlaceNumberLabel";
            this.PlaceNumberLabel.Size = new System.Drawing.Size(192, 38);
            this.PlaceNumberLabel.TabIndex = 15;
            this.PlaceNumberLabel.Text = "Place Number";
            // 
            // PlaceNameTextBox
            // 
            this.PlaceNameTextBox.Location = new System.Drawing.Point(260, 166);
            this.PlaceNameTextBox.Name = "PlaceNameTextBox";
            this.PlaceNameTextBox.Size = new System.Drawing.Size(208, 43);
            this.PlaceNameTextBox.TabIndex = 18;
            // 
            // PlaceNameLabel
            // 
            this.PlaceNameLabel.AutoSize = true;
            this.PlaceNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PlaceNameLabel.Location = new System.Drawing.Point(16, 171);
            this.PlaceNameLabel.Name = "PlaceNameLabel";
            this.PlaceNameLabel.Size = new System.Drawing.Size(164, 38);
            this.PlaceNameLabel.TabIndex = 17;
            this.PlaceNameLabel.Text = "Place Name";
            // 
            // PrizeAmountTextBox
            // 
            this.PrizeAmountTextBox.Location = new System.Drawing.Point(260, 240);
            this.PrizeAmountTextBox.Name = "PrizeAmountTextBox";
            this.PrizeAmountTextBox.Size = new System.Drawing.Size(208, 43);
            this.PrizeAmountTextBox.TabIndex = 20;
            this.PrizeAmountTextBox.Text = "0";
            // 
            // PrizeAmountLabel
            // 
            this.PrizeAmountLabel.AutoSize = true;
            this.PrizeAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PrizeAmountLabel.Location = new System.Drawing.Point(16, 245);
            this.PrizeAmountLabel.Name = "PrizeAmountLabel";
            this.PrizeAmountLabel.Size = new System.Drawing.Size(189, 38);
            this.PrizeAmountLabel.TabIndex = 19;
            this.PrizeAmountLabel.Text = "Place Amount";
            // 
            // PrizePercentageTextBox
            // 
            this.PrizePercentageTextBox.Location = new System.Drawing.Point(260, 396);
            this.PrizePercentageTextBox.Name = "PrizePercentageTextBox";
            this.PrizePercentageTextBox.Size = new System.Drawing.Size(208, 43);
            this.PrizePercentageTextBox.TabIndex = 22;
            this.PrizePercentageTextBox.Text = "0";
            // 
            // PrizePercentageLabel
            // 
            this.PrizePercentageLabel.AutoSize = true;
            this.PrizePercentageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PrizePercentageLabel.Location = new System.Drawing.Point(16, 401);
            this.PrizePercentageLabel.Name = "PrizePercentageLabel";
            this.PrizePercentageLabel.Size = new System.Drawing.Size(224, 38);
            this.PrizePercentageLabel.TabIndex = 21;
            this.PrizePercentageLabel.Text = "Prize Percentage";
            // 
            // OrLabel
            // 
            this.OrLabel.AutoSize = true;
            this.OrLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.OrLabel.Location = new System.Drawing.Point(221, 323);
            this.OrLabel.Name = "OrLabel";
            this.OrLabel.Size = new System.Drawing.Size(65, 38);
            this.OrLabel.TabIndex = 23;
            this.OrLabel.Text = "-or-";
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreatePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreatePrizeButton.Location = new System.Drawing.Point(127, 486);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(265, 54);
            this.CreatePrizeButton.TabIndex = 27;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            this.CreatePrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 635);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.OrLabel);
            this.Controls.Add(this.PrizePercentageTextBox);
            this.Controls.Add(this.PrizePercentageLabel);
            this.Controls.Add(this.PrizeAmountTextBox);
            this.Controls.Add(this.PrizeAmountLabel);
            this.Controls.Add(this.PlaceNameTextBox);
            this.Controls.Add(this.PlaceNameLabel);
            this.Controls.Add(this.PlaceNumberTextbox);
            this.Controls.Add(this.PlaceNumberLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePrizeForm";
            this.Text = "   ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox PlaceNumberTextbox;
        private System.Windows.Forms.Label PlaceNumberLabel;
        private System.Windows.Forms.TextBox PlaceNameTextBox;
        private System.Windows.Forms.Label PlaceNameLabel;
        private System.Windows.Forms.TextBox PrizeAmountTextBox;
        private System.Windows.Forms.Label PrizeAmountLabel;
        private System.Windows.Forms.TextBox PrizePercentageTextBox;
        private System.Windows.Forms.Label PrizePercentageLabel;
        private System.Windows.Forms.Label OrLabel;
        private System.Windows.Forms.Button CreatePrizeButton;
    }
}