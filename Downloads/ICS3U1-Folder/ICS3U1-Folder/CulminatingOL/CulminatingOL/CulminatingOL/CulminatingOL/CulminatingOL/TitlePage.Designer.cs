namespace CulminatingOL
{
    partial class TitlePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitlePage));
            this.pcbTitleIcon = new System.Windows.Forms.PictureBox();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.btnSpinMonster = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnExitGame2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTitleIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbTitleIcon
            // 
            this.pcbTitleIcon.BackColor = System.Drawing.Color.Transparent;
            this.pcbTitleIcon.BackgroundImage = global::CulminatingOL.TitlePageImages.dungeonduelmonsterstitle;
            this.pcbTitleIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbTitleIcon.Location = new System.Drawing.Point(157, 31);
            this.pcbTitleIcon.Name = "pcbTitleIcon";
            this.pcbTitleIcon.Size = new System.Drawing.Size(483, 236);
            this.pcbTitleIcon.TabIndex = 0;
            this.pcbTitleIcon.TabStop = false;
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.Transparent;
            this.btnRules.BackgroundImage = global::CulminatingOL.TitlePageImages.playbuttons;
            this.btnRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRules.FlatAppearance.BorderSize = 0;
            this.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRules.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRules.Location = new System.Drawing.Point(31, 290);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(242, 83);
            this.btnRules.TabIndex = 1;
            this.btnRules.Text = "RULES";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayGame.BackgroundImage = global::CulminatingOL.TitlePageImages.playbuttons;
            this.btnPlayGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayGame.FlatAppearance.BorderSize = 0;
            this.btnPlayGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayGame.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayGame.Location = new System.Drawing.Point(279, 290);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(242, 83);
            this.btnPlayGame.TabIndex = 2;
            this.btnPlayGame.Text = "PLAY";
            this.btnPlayGame.UseVisualStyleBackColor = false;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // btnSpinMonster
            // 
            this.btnSpinMonster.BackColor = System.Drawing.Color.Transparent;
            this.btnSpinMonster.BackgroundImage = global::CulminatingOL.TitlePageImages.playbuttons;
            this.btnSpinMonster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpinMonster.FlatAppearance.BorderSize = 0;
            this.btnSpinMonster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpinMonster.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpinMonster.Location = new System.Drawing.Point(527, 290);
            this.btnSpinMonster.Name = "btnSpinMonster";
            this.btnSpinMonster.Size = new System.Drawing.Size(242, 83);
            this.btnSpinMonster.TabIndex = 3;
            this.btnSpinMonster.Text = "SPIN";
            this.btnSpinMonster.UseVisualStyleBackColor = false;
            this.btnSpinMonster.Click += new System.EventHandler(this.btnSpinMonster_Click);
            // 
            // btnExitGame
            // 
            this.btnExitGame.BackColor = System.Drawing.Color.Red;
            this.btnExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitGame.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitGame.Location = new System.Drawing.Point(707, -1);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(94, 30);
            this.btnExitGame.TabIndex = 4;
            this.btnExitGame.Text = "EXIT GAME";
            this.btnExitGame.UseVisualStyleBackColor = false;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // btnExitGame2
            // 
            this.btnExitGame2.BackColor = System.Drawing.Color.Red;
            this.btnExitGame2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitGame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitGame2.Location = new System.Drawing.Point(-1, -1);
            this.btnExitGame2.Name = "btnExitGame2";
            this.btnExitGame2.Size = new System.Drawing.Size(96, 30);
            this.btnExitGame2.TabIndex = 5;
            this.btnExitGame2.Text = "EXIT GAME";
            this.btnExitGame2.UseVisualStyleBackColor = false;
            this.btnExitGame2.Click += new System.EventHandler(this.btnExitGame2_Click);
            // 
            // TitlePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CulminatingOL.TitlePageImages.dungeonimagetitle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitGame2);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.btnSpinMonster);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.pcbTitleIcon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TitlePage";
            this.Text = " Welcome!";
            ((System.ComponentModel.ISupportInitialize)(this.pcbTitleIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbTitleIcon;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Button btnSpinMonster;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Button btnExitGame2;
    }
}