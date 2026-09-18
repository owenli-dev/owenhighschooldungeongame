namespace CulminatingOL
{
    partial class Sorter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sorter));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNumber = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.pnlNumber = new System.Windows.Forms.Panel();
            this.lblGeneratedNumber = new System.Windows.Forms.Label();
            this.lblSelectedNumberTitle = new System.Windows.Forms.Label();
            this.lblLeaderboardTitle = new System.Windows.Forms.Label();
            this.lblFirstPlace = new System.Windows.Forms.Label();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.lblSecondPlace = new System.Windows.Forms.Label();
            this.lblThirdNumber = new System.Windows.Forms.Label();
            this.lblThirdPlace = new System.Windows.Forms.Label();
            this.lblFourthNumber = new System.Windows.Forms.Label();
            this.lblFourthPlace = new System.Windows.Forms.Label();
            this.lblFifthNumber = new System.Windows.Forms.Label();
            this.lblFifthPlace = new System.Windows.Forms.Label();
            this.pnlNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(524, 367);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 46);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "EXIT PAGE";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNumber
            // 
            this.btnNumber.BackColor = System.Drawing.Color.Yellow;
            this.btnNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber.Location = new System.Drawing.Point(524, -2);
            this.btnNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(137, 46);
            this.btnNumber.TabIndex = 1;
            this.btnNumber.Text = "NEW NUMBER";
            this.btnNumber.UseVisualStyleBackColor = false;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRules.Location = new System.Drawing.Point(524, 43);
            this.btnRules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(137, 327);
            this.btnRules.TabIndex = 2;
            this.btnRules.Text = "HOW TO PLAY";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // pnlNumber
            // 
            this.pnlNumber.BackColor = System.Drawing.Color.Black;
            this.pnlNumber.Controls.Add(this.lblGeneratedNumber);
            this.pnlNumber.Controls.Add(this.lblSelectedNumberTitle);
            this.pnlNumber.Location = new System.Drawing.Point(-2, 370);
            this.pnlNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlNumber.Name = "pnlNumber";
            this.pnlNumber.Size = new System.Drawing.Size(526, 41);
            this.pnlNumber.TabIndex = 3;
            // 
            // lblGeneratedNumber
            // 
            this.lblGeneratedNumber.AutoSize = true;
            this.lblGeneratedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneratedNumber.ForeColor = System.Drawing.Color.White;
            this.lblGeneratedNumber.Location = new System.Drawing.Point(163, 13);
            this.lblGeneratedNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGeneratedNumber.Name = "lblGeneratedNumber";
            this.lblGeneratedNumber.Size = new System.Drawing.Size(71, 17);
            this.lblGeneratedNumber.TabIndex = 1;
            this.lblGeneratedNumber.Text = "0000000";
            // 
            // lblSelectedNumberTitle
            // 
            this.lblSelectedNumberTitle.AutoSize = true;
            this.lblSelectedNumberTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedNumberTitle.ForeColor = System.Drawing.Color.White;
            this.lblSelectedNumberTitle.Location = new System.Drawing.Point(11, 13);
            this.lblSelectedNumberTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedNumberTitle.Name = "lblSelectedNumberTitle";
            this.lblSelectedNumberTitle.Size = new System.Drawing.Size(151, 17);
            this.lblSelectedNumberTitle.TabIndex = 0;
            this.lblSelectedNumberTitle.Text = "Generated Number:";
            // 
            // lblLeaderboardTitle
            // 
            this.lblLeaderboardTitle.AutoSize = true;
            this.lblLeaderboardTitle.BackColor = System.Drawing.Color.Black;
            this.lblLeaderboardTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaderboardTitle.ForeColor = System.Drawing.Color.White;
            this.lblLeaderboardTitle.Location = new System.Drawing.Point(158, 12);
            this.lblLeaderboardTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeaderboardTitle.Name = "lblLeaderboardTitle";
            this.lblLeaderboardTitle.Size = new System.Drawing.Size(231, 31);
            this.lblLeaderboardTitle.TabIndex = 4;
            this.lblLeaderboardTitle.Text = "LEADERBOARD";
            // 
            // lblFirstPlace
            // 
            this.lblFirstPlace.AutoSize = true;
            this.lblFirstPlace.BackColor = System.Drawing.Color.Black;
            this.lblFirstPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstPlace.ForeColor = System.Drawing.Color.White;
            this.lblFirstPlace.Location = new System.Drawing.Point(112, 56);
            this.lblFirstPlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstPlace.Name = "lblFirstPlace";
            this.lblFirstPlace.Size = new System.Drawing.Size(39, 31);
            this.lblFirstPlace.TabIndex = 5;
            this.lblFirstPlace.Text = "1.";
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.BackColor = System.Drawing.Color.Black;
            this.lblFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNumber.ForeColor = System.Drawing.Color.White;
            this.lblFirstNumber.Location = new System.Drawing.Point(325, 56);
            this.lblFirstNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(126, 31);
            this.lblFirstNumber.TabIndex = 6;
            this.lblFirstNumber.Text = "0000000";
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.BackColor = System.Drawing.Color.Black;
            this.lblSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondNumber.ForeColor = System.Drawing.Color.White;
            this.lblSecondNumber.Location = new System.Drawing.Point(325, 97);
            this.lblSecondNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(126, 31);
            this.lblSecondNumber.TabIndex = 8;
            this.lblSecondNumber.Text = "0000000";
            // 
            // lblSecondPlace
            // 
            this.lblSecondPlace.AutoSize = true;
            this.lblSecondPlace.BackColor = System.Drawing.Color.Black;
            this.lblSecondPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondPlace.ForeColor = System.Drawing.Color.White;
            this.lblSecondPlace.Location = new System.Drawing.Point(112, 97);
            this.lblSecondPlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecondPlace.Name = "lblSecondPlace";
            this.lblSecondPlace.Size = new System.Drawing.Size(39, 31);
            this.lblSecondPlace.TabIndex = 7;
            this.lblSecondPlace.Text = "2.";
            // 
            // lblThirdNumber
            // 
            this.lblThirdNumber.AutoSize = true;
            this.lblThirdNumber.BackColor = System.Drawing.Color.Black;
            this.lblThirdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdNumber.ForeColor = System.Drawing.Color.White;
            this.lblThirdNumber.Location = new System.Drawing.Point(325, 140);
            this.lblThirdNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThirdNumber.Name = "lblThirdNumber";
            this.lblThirdNumber.Size = new System.Drawing.Size(126, 31);
            this.lblThirdNumber.TabIndex = 10;
            this.lblThirdNumber.Text = "0000000";
            // 
            // lblThirdPlace
            // 
            this.lblThirdPlace.AutoSize = true;
            this.lblThirdPlace.BackColor = System.Drawing.Color.Black;
            this.lblThirdPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdPlace.ForeColor = System.Drawing.Color.White;
            this.lblThirdPlace.Location = new System.Drawing.Point(112, 140);
            this.lblThirdPlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThirdPlace.Name = "lblThirdPlace";
            this.lblThirdPlace.Size = new System.Drawing.Size(39, 31);
            this.lblThirdPlace.TabIndex = 9;
            this.lblThirdPlace.Text = "3.";
            // 
            // lblFourthNumber
            // 
            this.lblFourthNumber.AutoSize = true;
            this.lblFourthNumber.BackColor = System.Drawing.Color.Black;
            this.lblFourthNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourthNumber.ForeColor = System.Drawing.Color.White;
            this.lblFourthNumber.Location = new System.Drawing.Point(325, 184);
            this.lblFourthNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFourthNumber.Name = "lblFourthNumber";
            this.lblFourthNumber.Size = new System.Drawing.Size(126, 31);
            this.lblFourthNumber.TabIndex = 12;
            this.lblFourthNumber.Text = "0000000";
            // 
            // lblFourthPlace
            // 
            this.lblFourthPlace.AutoSize = true;
            this.lblFourthPlace.BackColor = System.Drawing.Color.Black;
            this.lblFourthPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourthPlace.ForeColor = System.Drawing.Color.White;
            this.lblFourthPlace.Location = new System.Drawing.Point(112, 184);
            this.lblFourthPlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFourthPlace.Name = "lblFourthPlace";
            this.lblFourthPlace.Size = new System.Drawing.Size(39, 31);
            this.lblFourthPlace.TabIndex = 11;
            this.lblFourthPlace.Text = "4.";
            // 
            // lblFifthNumber
            // 
            this.lblFifthNumber.AutoSize = true;
            this.lblFifthNumber.BackColor = System.Drawing.Color.Black;
            this.lblFifthNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFifthNumber.ForeColor = System.Drawing.Color.White;
            this.lblFifthNumber.Location = new System.Drawing.Point(325, 228);
            this.lblFifthNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFifthNumber.Name = "lblFifthNumber";
            this.lblFifthNumber.Size = new System.Drawing.Size(126, 31);
            this.lblFifthNumber.TabIndex = 14;
            this.lblFifthNumber.Text = "0000000";
            // 
            // lblFifthPlace
            // 
            this.lblFifthPlace.AutoSize = true;
            this.lblFifthPlace.BackColor = System.Drawing.Color.Black;
            this.lblFifthPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFifthPlace.ForeColor = System.Drawing.Color.White;
            this.lblFifthPlace.Location = new System.Drawing.Point(112, 228);
            this.lblFifthPlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFifthPlace.Name = "lblFifthPlace";
            this.lblFifthPlace.Size = new System.Drawing.Size(39, 31);
            this.lblFifthPlace.TabIndex = 13;
            this.lblFifthPlace.Text = "5.";
            // 
            // Sorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CulminatingOL.GameImages.spacebackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 411);
            this.Controls.Add(this.lblFifthNumber);
            this.Controls.Add(this.lblFifthPlace);
            this.Controls.Add(this.lblFourthNumber);
            this.Controls.Add(this.lblFourthPlace);
            this.Controls.Add(this.lblThirdNumber);
            this.Controls.Add(this.lblThirdPlace);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblSecondPlace);
            this.Controls.Add(this.lblFirstNumber);
            this.Controls.Add(this.lblFirstPlace);
            this.Controls.Add(this.lblLeaderboardTitle);
            this.Controls.Add(this.pnlNumber);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Sorter";
            this.Text = "Sorter";
            this.pnlNumber.ResumeLayout(false);
            this.pnlNumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNumber;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Panel pnlNumber;
        private System.Windows.Forms.Label lblGeneratedNumber;
        private System.Windows.Forms.Label lblSelectedNumberTitle;
        private System.Windows.Forms.Label lblLeaderboardTitle;
        private System.Windows.Forms.Label lblFirstPlace;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Label lblSecondPlace;
        private System.Windows.Forms.Label lblThirdNumber;
        private System.Windows.Forms.Label lblThirdPlace;
        private System.Windows.Forms.Label lblFourthNumber;
        private System.Windows.Forms.Label lblFourthPlace;
        private System.Windows.Forms.Label lblFifthNumber;
        private System.Windows.Forms.Label lblFifthPlace;
    }
}