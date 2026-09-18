namespace CulminatingOL
{
    partial class GameDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameDisplay));
            this.pnlGameBar = new System.Windows.Forms.Panel();
            this.btnTitlePage = new System.Windows.Forms.Button();
            this.pnlLevelSelect = new System.Windows.Forms.Panel();
            this.btnLevelOne = new System.Windows.Forms.Button();
            this.btnLevelTwo = new System.Windows.Forms.Button();
            this.btnLevelThree = new System.Windows.Forms.Button();
            this.btnLevelFour = new System.Windows.Forms.Button();
            this.btnLevelFive = new System.Windows.Forms.Button();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.pnlDifficulty = new System.Windows.Forms.Panel();
            this.lblDifficultyTitle = new System.Windows.Forms.Label();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.lblCoinTitle = new System.Windows.Forms.Label();
            this.lblCoinAmount = new System.Windows.Forms.Label();
            this.pnlGameBar.SuspendLayout();
            this.pnlLevelSelect.SuspendLayout();
            this.pnlDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGameBar
            // 
            this.pnlGameBar.BackColor = System.Drawing.Color.Black;
            this.pnlGameBar.Controls.Add(this.lblCoinAmount);
            this.pnlGameBar.Controls.Add(this.lblCoinTitle);
            this.pnlGameBar.Controls.Add(this.btnTitlePage);
            this.pnlGameBar.Location = new System.Drawing.Point(0, 616);
            this.pnlGameBar.Name = "pnlGameBar";
            this.pnlGameBar.Size = new System.Drawing.Size(1056, 61);
            this.pnlGameBar.TabIndex = 6;
            // 
            // btnTitlePage
            // 
            this.btnTitlePage.BackColor = System.Drawing.Color.Red;
            this.btnTitlePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitlePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitlePage.Location = new System.Drawing.Point(821, 0);
            this.btnTitlePage.Name = "btnTitlePage";
            this.btnTitlePage.Size = new System.Drawing.Size(233, 61);
            this.btnTitlePage.TabIndex = 0;
            this.btnTitlePage.Text = "Return to Title Page";
            this.btnTitlePage.UseVisualStyleBackColor = false;
            this.btnTitlePage.Click += new System.EventHandler(this.btnTitlePage_Click);
            // 
            // pnlLevelSelect
            // 
            this.pnlLevelSelect.BackColor = System.Drawing.Color.Transparent;
            this.pnlLevelSelect.BackgroundImage = global::CulminatingOL.GameImages.dungeongame;
            this.pnlLevelSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLevelSelect.Controls.Add(this.pnlDifficulty);
            this.pnlLevelSelect.Controls.Add(this.lblGameTitle);
            this.pnlLevelSelect.Controls.Add(this.btnLevelFive);
            this.pnlLevelSelect.Controls.Add(this.btnLevelFour);
            this.pnlLevelSelect.Controls.Add(this.btnLevelThree);
            this.pnlLevelSelect.Controls.Add(this.btnLevelTwo);
            this.pnlLevelSelect.Controls.Add(this.btnLevelOne);
            this.pnlLevelSelect.Location = new System.Drawing.Point(0, -5);
            this.pnlLevelSelect.Name = "pnlLevelSelect";
            this.pnlLevelSelect.Size = new System.Drawing.Size(1054, 627);
            this.pnlLevelSelect.TabIndex = 6;
            // 
            // btnLevelOne
            // 
            this.btnLevelOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLevelOne.BackgroundImage")));
            this.btnLevelOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevelOne.Location = new System.Drawing.Point(101, 275);
            this.btnLevelOne.Name = "btnLevelOne";
            this.btnLevelOne.Size = new System.Drawing.Size(145, 127);
            this.btnLevelOne.TabIndex = 0;
            this.btnLevelOne.UseVisualStyleBackColor = true;
            this.btnLevelOne.Click += new System.EventHandler(this.btnLevelOne_Click);
            // 
            // btnLevelTwo
            // 
            this.btnLevelTwo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLevelTwo.BackgroundImage")));
            this.btnLevelTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevelTwo.Location = new System.Drawing.Point(275, 275);
            this.btnLevelTwo.Name = "btnLevelTwo";
            this.btnLevelTwo.Size = new System.Drawing.Size(145, 127);
            this.btnLevelTwo.TabIndex = 1;
            this.btnLevelTwo.UseVisualStyleBackColor = true;
            this.btnLevelTwo.Click += new System.EventHandler(this.btnLevelTwo_Click);
            // 
            // btnLevelThree
            // 
            this.btnLevelThree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLevelThree.BackgroundImage")));
            this.btnLevelThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevelThree.Location = new System.Drawing.Point(452, 275);
            this.btnLevelThree.Name = "btnLevelThree";
            this.btnLevelThree.Size = new System.Drawing.Size(145, 127);
            this.btnLevelThree.TabIndex = 2;
            this.btnLevelThree.UseVisualStyleBackColor = true;
            this.btnLevelThree.Click += new System.EventHandler(this.btnLevelThree_Click);
            // 
            // btnLevelFour
            // 
            this.btnLevelFour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLevelFour.BackgroundImage")));
            this.btnLevelFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevelFour.Location = new System.Drawing.Point(621, 275);
            this.btnLevelFour.Name = "btnLevelFour";
            this.btnLevelFour.Size = new System.Drawing.Size(145, 127);
            this.btnLevelFour.TabIndex = 3;
            this.btnLevelFour.UseVisualStyleBackColor = true;
            this.btnLevelFour.Click += new System.EventHandler(this.btnLevelFour_Click);
            // 
            // btnLevelFive
            // 
            this.btnLevelFive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLevelFive.BackgroundImage")));
            this.btnLevelFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevelFive.Location = new System.Drawing.Point(800, 275);
            this.btnLevelFive.Name = "btnLevelFive";
            this.btnLevelFive.Size = new System.Drawing.Size(145, 127);
            this.btnLevelFive.TabIndex = 4;
            this.btnLevelFive.UseVisualStyleBackColor = true;
            this.btnLevelFive.Click += new System.EventHandler(this.btnLevelFive_Click);
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.ForeColor = System.Drawing.Color.White;
            this.lblGameTitle.Location = new System.Drawing.Point(179, 187);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(696, 69);
            this.lblGameTitle.TabIndex = 5;
            this.lblGameTitle.Text = "Please select your level!";
            // 
            // pnlDifficulty
            // 
            this.pnlDifficulty.BackgroundImage = global::CulminatingOL.GameImages.dungeongame;
            this.pnlDifficulty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDifficulty.Controls.Add(this.btnHard);
            this.pnlDifficulty.Controls.Add(this.btnMedium);
            this.pnlDifficulty.Controls.Add(this.btnEasy);
            this.pnlDifficulty.Controls.Add(this.lblDifficultyTitle);
            this.pnlDifficulty.Location = new System.Drawing.Point(1, 6);
            this.pnlDifficulty.Name = "pnlDifficulty";
            this.pnlDifficulty.Size = new System.Drawing.Size(1050, 621);
            this.pnlDifficulty.TabIndex = 7;
            // 
            // lblDifficultyTitle
            // 
            this.lblDifficultyTitle.AutoSize = true;
            this.lblDifficultyTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDifficultyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficultyTitle.ForeColor = System.Drawing.Color.White;
            this.lblDifficultyTitle.Location = new System.Drawing.Point(147, 49);
            this.lblDifficultyTitle.Name = "lblDifficultyTitle";
            this.lblDifficultyTitle.Size = new System.Drawing.Size(749, 54);
            this.lblDifficultyTitle.TabIndex = 0;
            this.lblDifficultyTitle.Text = "Select your difficulty for this level:";
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.Transparent;
            this.btnEasy.BackgroundImage = global::CulminatingOL.TitlePageImages.playbuttons;
            this.btnEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEasy.FlatAppearance.BorderSize = 0;
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.ForeColor = System.Drawing.Color.Green;
            this.btnEasy.Location = new System.Drawing.Point(345, 152);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(360, 112);
            this.btnEasy.TabIndex = 1;
            this.btnEasy.Text = "EASY";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.Color.Transparent;
            this.btnMedium.BackgroundImage = global::CulminatingOL.TitlePageImages.playbuttons;
            this.btnMedium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedium.FlatAppearance.BorderSize = 0;
            this.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMedium.Location = new System.Drawing.Point(345, 278);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(360, 112);
            this.btnMedium.TabIndex = 2;
            this.btnMedium.Text = "MEDIUM";
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.Transparent;
            this.btnHard.BackgroundImage = global::CulminatingOL.TitlePageImages.playbuttons;
            this.btnHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHard.FlatAppearance.BorderSize = 0;
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHard.Location = new System.Drawing.Point(345, 409);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(360, 112);
            this.btnHard.TabIndex = 3;
            this.btnHard.Text = "HARD";
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // lblCoinTitle
            // 
            this.lblCoinTitle.AutoSize = true;
            this.lblCoinTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoinTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCoinTitle.Location = new System.Drawing.Point(12, 18);
            this.lblCoinTitle.Name = "lblCoinTitle";
            this.lblCoinTitle.Size = new System.Drawing.Size(107, 20);
            this.lblCoinTitle.TabIndex = 1;
            this.lblCoinTitle.Text = "Your Coins:";
            // 
            // lblCoinAmount
            // 
            this.lblCoinAmount.AutoSize = true;
            this.lblCoinAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoinAmount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCoinAmount.Location = new System.Drawing.Point(187, 18);
            this.lblCoinAmount.Name = "lblCoinAmount";
            this.lblCoinAmount.Size = new System.Drawing.Size(19, 20);
            this.lblCoinAmount.TabIndex = 2;
            this.lblCoinAmount.Text = "0";
            // 
            // GameDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 678);
            this.Controls.Add(this.pnlLevelSelect);
            this.Controls.Add(this.pnlGameBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameDisplay";
            this.Text = "GameDisplay";
            this.pnlGameBar.ResumeLayout(false);
            this.pnlGameBar.PerformLayout();
            this.pnlLevelSelect.ResumeLayout(false);
            this.pnlLevelSelect.PerformLayout();
            this.pnlDifficulty.ResumeLayout(false);
            this.pnlDifficulty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlGameBar;
        private System.Windows.Forms.Button btnTitlePage;
        private System.Windows.Forms.Panel pnlLevelSelect;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Button btnLevelFive;
        private System.Windows.Forms.Button btnLevelFour;
        private System.Windows.Forms.Button btnLevelThree;
        private System.Windows.Forms.Button btnLevelTwo;
        private System.Windows.Forms.Button btnLevelOne;
        private System.Windows.Forms.Panel pnlDifficulty;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Label lblDifficultyTitle;
        private System.Windows.Forms.Label lblCoinTitle;
        private System.Windows.Forms.Label lblCoinAmount;
    }
}