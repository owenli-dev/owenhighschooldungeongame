namespace CulminatingOL
{
    partial class MainGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.pnlMonsterSelect = new System.Windows.Forms.Panel();
            this.btnSania = new System.Windows.Forms.Button();
            this.btnDoveria = new System.Windows.Forms.Button();
            this.btnTellaria = new System.Windows.Forms.Button();
            this.btnFalacia = new System.Windows.Forms.Button();
            this.btnExparia = new System.Windows.Forms.Button();
            this.lblDisclaimer = new System.Windows.Forms.Label();
            this.lblMonsterSelect = new System.Windows.Forms.Label();
            this.pcbUserMonster = new System.Windows.Forms.PictureBox();
            this.pcbComputerMonster = new System.Windows.Forms.PictureBox();
            this.pcbUserInfo = new System.Windows.Forms.PictureBox();
            this.pcbUserHP = new System.Windows.Forms.PictureBox();
            this.lblUserMonsterName = new System.Windows.Forms.Label();
            this.lblCompMonsterName = new System.Windows.Forms.Label();
            this.pcbCompHP = new System.Windows.Forms.PictureBox();
            this.pcbComputerInfo = new System.Windows.Forms.PictureBox();
            this.pnlGameBar = new System.Windows.Forms.Panel();
            this.pcbStaminaBar = new System.Windows.Forms.PictureBox();
            this.pcbStaminaLost = new System.Windows.Forms.PictureBox();
            this.lblStaminaTitle = new System.Windows.Forms.Label();
            this.btnAttack3 = new System.Windows.Forms.Button();
            this.btnAttack2 = new System.Windows.Forms.Button();
            this.btnAttack1 = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnAttackInfo = new System.Windows.Forms.Button();
            this.btnSkipTurn = new System.Windows.Forms.Button();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.pcbUserLostHealth = new System.Windows.Forms.PictureBox();
            this.pcbUserLost = new System.Windows.Forms.PictureBox();
            this.pcbComputerLost = new System.Windows.Forms.PictureBox();
            this.pnlMonsterSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserMonster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbComputerMonster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCompHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbComputerInfo)).BeginInit();
            this.pnlGameBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStaminaBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStaminaLost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserLostHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserLost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbComputerLost)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMonsterSelect
            // 
            this.pnlMonsterSelect.BackColor = System.Drawing.Color.Transparent;
            this.pnlMonsterSelect.BackgroundImage = global::CulminatingOL.GameImages.grassybackground;
            this.pnlMonsterSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMonsterSelect.Controls.Add(this.btnSania);
            this.pnlMonsterSelect.Controls.Add(this.btnDoveria);
            this.pnlMonsterSelect.Controls.Add(this.btnTellaria);
            this.pnlMonsterSelect.Controls.Add(this.btnFalacia);
            this.pnlMonsterSelect.Controls.Add(this.btnExparia);
            this.pnlMonsterSelect.Controls.Add(this.lblDisclaimer);
            this.pnlMonsterSelect.Controls.Add(this.lblMonsterSelect);
            this.pnlMonsterSelect.Location = new System.Drawing.Point(0, -2);
            this.pnlMonsterSelect.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMonsterSelect.Name = "pnlMonsterSelect";
            this.pnlMonsterSelect.Size = new System.Drawing.Size(656, 518);
            this.pnlMonsterSelect.TabIndex = 0;
            // 
            // btnSania
            // 
            this.btnSania.BackgroundImage = global::CulminatingOL.TitlePageImages.playbuttons;
            this.btnSania.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSania.FlatAppearance.BorderSize = 0;
            this.btnSania.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSania.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSania.Location = new System.Drawing.Point(141, 395);
            this.btnSania.Margin = new System.Windows.Forms.Padding(2);
            this.btnSania.Name = "btnSania";
            this.btnSania.Size = new System.Drawing.Size(385, 71);
            this.btnSania.TabIndex = 6;
            this.btnSania.Text = "SANIA";
            this.btnSania.UseVisualStyleBackColor = true;
            this.btnSania.Click += new System.EventHandler(this.btnSania_Click);
            // 
            // btnDoveria
            // 
            this.btnDoveria.BackgroundImage = global::CulminatingOL.TitlePageImages.playbuttons;
            this.btnDoveria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoveria.FlatAppearance.BorderSize = 0;
            this.btnDoveria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoveria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoveria.Location = new System.Drawing.Point(141, 319);
            this.btnDoveria.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoveria.Name = "btnDoveria";
            this.btnDoveria.Size = new System.Drawing.Size(385, 71);
            this.btnDoveria.TabIndex = 5;
            this.btnDoveria.Text = "DOVERIA";
            this.btnDoveria.UseVisualStyleBackColor = true;
            this.btnDoveria.Click += new System.EventHandler(this.btnDoveria_Click);
            // 
            // btnTellaria
            // 
            this.btnTellaria.BackgroundImage = global::CulminatingOL.TitlePageImages.playbuttons;
            this.btnTellaria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTellaria.FlatAppearance.BorderSize = 0;
            this.btnTellaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTellaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTellaria.Location = new System.Drawing.Point(141, 244);
            this.btnTellaria.Margin = new System.Windows.Forms.Padding(2);
            this.btnTellaria.Name = "btnTellaria";
            this.btnTellaria.Size = new System.Drawing.Size(385, 71);
            this.btnTellaria.TabIndex = 4;
            this.btnTellaria.Text = "TELLARIA";
            this.btnTellaria.UseVisualStyleBackColor = true;
            this.btnTellaria.Click += new System.EventHandler(this.btnTellaria_Click);
            // 
            // btnFalacia
            // 
            this.btnFalacia.BackgroundImage = global::CulminatingOL.TitlePageImages.playbuttons;
            this.btnFalacia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFalacia.FlatAppearance.BorderSize = 0;
            this.btnFalacia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFalacia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFalacia.Location = new System.Drawing.Point(141, 168);
            this.btnFalacia.Margin = new System.Windows.Forms.Padding(2);
            this.btnFalacia.Name = "btnFalacia";
            this.btnFalacia.Size = new System.Drawing.Size(385, 71);
            this.btnFalacia.TabIndex = 3;
            this.btnFalacia.Text = "FALACIA";
            this.btnFalacia.UseVisualStyleBackColor = true;
            this.btnFalacia.Click += new System.EventHandler(this.btnFalacia_Click);
            // 
            // btnExparia
            // 
            this.btnExparia.BackgroundImage = global::CulminatingOL.TitlePageImages.playbuttons;
            this.btnExparia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExparia.FlatAppearance.BorderSize = 0;
            this.btnExparia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExparia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExparia.Location = new System.Drawing.Point(141, 100);
            this.btnExparia.Margin = new System.Windows.Forms.Padding(2);
            this.btnExparia.Name = "btnExparia";
            this.btnExparia.Size = new System.Drawing.Size(385, 71);
            this.btnExparia.TabIndex = 2;
            this.btnExparia.Text = "EXPARIA";
            this.btnExparia.UseVisualStyleBackColor = true;
            this.btnExparia.Click += new System.EventHandler(this.btnExparia_Click);
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.AutoSize = true;
            this.lblDisclaimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisclaimer.ForeColor = System.Drawing.Color.White;
            this.lblDisclaimer.Location = new System.Drawing.Point(197, 77);
            this.lblDisclaimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.Size = new System.Drawing.Size(305, 13);
            this.lblDisclaimer.TabIndex = 1;
            this.lblDisclaimer.Text = "If you do not have the monster, you cannot select it!";
            // 
            // lblMonsterSelect
            // 
            this.lblMonsterSelect.AutoSize = true;
            this.lblMonsterSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonsterSelect.ForeColor = System.Drawing.Color.White;
            this.lblMonsterSelect.Location = new System.Drawing.Point(157, 33);
            this.lblMonsterSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonsterSelect.Name = "lblMonsterSelect";
            this.lblMonsterSelect.Size = new System.Drawing.Size(389, 44);
            this.lblMonsterSelect.TabIndex = 0;
            this.lblMonsterSelect.Text = "Select your monster:";
            // 
            // pcbUserMonster
            // 
            this.pcbUserMonster.BackColor = System.Drawing.Color.Transparent;
            this.pcbUserMonster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbUserMonster.Location = new System.Drawing.Point(17, 254);
            this.pcbUserMonster.Margin = new System.Windows.Forms.Padding(2);
            this.pcbUserMonster.Name = "pcbUserMonster";
            this.pcbUserMonster.Size = new System.Drawing.Size(166, 155);
            this.pcbUserMonster.TabIndex = 1;
            this.pcbUserMonster.TabStop = false;
            // 
            // pcbComputerMonster
            // 
            this.pcbComputerMonster.BackColor = System.Drawing.Color.Transparent;
            this.pcbComputerMonster.BackgroundImage = global::CulminatingOL.MonsterImages.computermonster;
            this.pcbComputerMonster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbComputerMonster.Location = new System.Drawing.Point(468, 24);
            this.pcbComputerMonster.Margin = new System.Windows.Forms.Padding(2);
            this.pcbComputerMonster.Name = "pcbComputerMonster";
            this.pcbComputerMonster.Size = new System.Drawing.Size(166, 155);
            this.pcbComputerMonster.TabIndex = 2;
            this.pcbComputerMonster.TabStop = false;
            // 
            // pcbUserInfo
            // 
            this.pcbUserInfo.BackColor = System.Drawing.Color.LightGray;
            this.pcbUserInfo.Location = new System.Drawing.Point(205, 338);
            this.pcbUserInfo.Margin = new System.Windows.Forms.Padding(2);
            this.pcbUserInfo.Name = "pcbUserInfo";
            this.pcbUserInfo.Size = new System.Drawing.Size(223, 68);
            this.pcbUserInfo.TabIndex = 3;
            this.pcbUserInfo.TabStop = false;
            // 
            // pcbUserHP
            // 
            this.pcbUserHP.BackColor = System.Drawing.Color.Lime;
            this.pcbUserHP.Location = new System.Drawing.Point(215, 373);
            this.pcbUserHP.Margin = new System.Windows.Forms.Padding(2);
            this.pcbUserHP.Name = "pcbUserHP";
            this.pcbUserHP.Size = new System.Drawing.Size(200, 20);
            this.pcbUserHP.TabIndex = 4;
            this.pcbUserHP.TabStop = false;
            // 
            // lblUserMonsterName
            // 
            this.lblUserMonsterName.AutoSize = true;
            this.lblUserMonsterName.BackColor = System.Drawing.Color.LightGray;
            this.lblUserMonsterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMonsterName.Location = new System.Drawing.Point(218, 347);
            this.lblUserMonsterName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserMonsterName.Name = "lblUserMonsterName";
            this.lblUserMonsterName.Size = new System.Drawing.Size(111, 18);
            this.lblUserMonsterName.TabIndex = 5;
            this.lblUserMonsterName.Text = "User Monster";
            // 
            // lblCompMonsterName
            // 
            this.lblCompMonsterName.AutoSize = true;
            this.lblCompMonsterName.BackColor = System.Drawing.Color.LightGray;
            this.lblCompMonsterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompMonsterName.Location = new System.Drawing.Point(229, 33);
            this.lblCompMonsterName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompMonsterName.Name = "lblCompMonsterName";
            this.lblCompMonsterName.Size = new System.Drawing.Size(149, 18);
            this.lblCompMonsterName.TabIndex = 8;
            this.lblCompMonsterName.Text = "CoMpUtEr LeGiOn";
            // 
            // pcbCompHP
            // 
            this.pcbCompHP.BackColor = System.Drawing.Color.Lime;
            this.pcbCompHP.Location = new System.Drawing.Point(232, 58);
            this.pcbCompHP.Margin = new System.Windows.Forms.Padding(2);
            this.pcbCompHP.Name = "pcbCompHP";
            this.pcbCompHP.Size = new System.Drawing.Size(200, 20);
            this.pcbCompHP.TabIndex = 7;
            this.pcbCompHP.TabStop = false;
            // 
            // pcbComputerInfo
            // 
            this.pcbComputerInfo.BackColor = System.Drawing.Color.LightGray;
            this.pcbComputerInfo.Location = new System.Drawing.Point(221, 24);
            this.pcbComputerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.pcbComputerInfo.Name = "pcbComputerInfo";
            this.pcbComputerInfo.Size = new System.Drawing.Size(222, 68);
            this.pcbComputerInfo.TabIndex = 6;
            this.pcbComputerInfo.TabStop = false;
            // 
            // pnlGameBar
            // 
            this.pnlGameBar.BackColor = System.Drawing.Color.Black;
            this.pnlGameBar.Controls.Add(this.pcbStaminaBar);
            this.pnlGameBar.Controls.Add(this.pcbStaminaLost);
            this.pnlGameBar.Controls.Add(this.lblStaminaTitle);
            this.pnlGameBar.Controls.Add(this.btnAttack3);
            this.pnlGameBar.Controls.Add(this.btnAttack2);
            this.pnlGameBar.Controls.Add(this.btnAttack1);
            this.pnlGameBar.Location = new System.Drawing.Point(0, 429);
            this.pnlGameBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGameBar.Name = "pnlGameBar";
            this.pnlGameBar.Size = new System.Drawing.Size(652, 87);
            this.pnlGameBar.TabIndex = 9;
            // 
            // pcbStaminaBar
            // 
            this.pcbStaminaBar.BackColor = System.Drawing.Color.Blue;
            this.pcbStaminaBar.Location = new System.Drawing.Point(447, 38);
            this.pcbStaminaBar.Margin = new System.Windows.Forms.Padding(2);
            this.pcbStaminaBar.Name = "pcbStaminaBar";
            this.pcbStaminaBar.Size = new System.Drawing.Size(200, 20);
            this.pcbStaminaBar.TabIndex = 10;
            this.pcbStaminaBar.TabStop = false;
            // 
            // pcbStaminaLost
            // 
            this.pcbStaminaLost.BackColor = System.Drawing.Color.Red;
            this.pcbStaminaLost.Location = new System.Drawing.Point(447, 38);
            this.pcbStaminaLost.Margin = new System.Windows.Forms.Padding(2);
            this.pcbStaminaLost.Name = "pcbStaminaLost";
            this.pcbStaminaLost.Size = new System.Drawing.Size(200, 20);
            this.pcbStaminaLost.TabIndex = 11;
            this.pcbStaminaLost.TabStop = false;
            // 
            // lblStaminaTitle
            // 
            this.lblStaminaTitle.AutoSize = true;
            this.lblStaminaTitle.BackColor = System.Drawing.Color.Black;
            this.lblStaminaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaminaTitle.ForeColor = System.Drawing.Color.White;
            this.lblStaminaTitle.Location = new System.Drawing.Point(504, 18);
            this.lblStaminaTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaminaTitle.Name = "lblStaminaTitle";
            this.lblStaminaTitle.Size = new System.Drawing.Size(84, 18);
            this.lblStaminaTitle.TabIndex = 10;
            this.lblStaminaTitle.Text = "STAMINA:";
            // 
            // btnAttack3
            // 
            this.btnAttack3.BackColor = System.Drawing.Color.Transparent;
            this.btnAttack3.BackgroundImage = global::CulminatingOL.TitlePageImages.playbuttons;
            this.btnAttack3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttack3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttack3.Location = new System.Drawing.Point(261, 15);
            this.btnAttack3.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttack3.Name = "btnAttack3";
            this.btnAttack3.Size = new System.Drawing.Size(125, 45);
            this.btnAttack3.TabIndex = 2;
            this.btnAttack3.Text = "Attack 3";
            this.btnAttack3.UseVisualStyleBackColor = false;
            this.btnAttack3.Click += new System.EventHandler(this.btnAttack3_Click);
            // 
            // btnAttack2
            // 
            this.btnAttack2.BackColor = System.Drawing.Color.Transparent;
            this.btnAttack2.BackgroundImage = global::CulminatingOL.TitlePageImages.playbuttons;
            this.btnAttack2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttack2.Location = new System.Drawing.Point(134, 15);
            this.btnAttack2.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttack2.Name = "btnAttack2";
            this.btnAttack2.Size = new System.Drawing.Size(124, 45);
            this.btnAttack2.TabIndex = 1;
            this.btnAttack2.Text = "Attack 2";
            this.btnAttack2.UseVisualStyleBackColor = false;
            this.btnAttack2.Click += new System.EventHandler(this.btnAttack2_Click);
            // 
            // btnAttack1
            // 
            this.btnAttack1.BackColor = System.Drawing.Color.Transparent;
            this.btnAttack1.BackgroundImage = global::CulminatingOL.TitlePageImages.playbuttons;
            this.btnAttack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttack1.FlatAppearance.BorderSize = 3;
            this.btnAttack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttack1.Location = new System.Drawing.Point(4, 15);
            this.btnAttack1.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttack1.Name = "btnAttack1";
            this.btnAttack1.Size = new System.Drawing.Size(124, 45);
            this.btnAttack1.TabIndex = 0;
            this.btnAttack1.Text = "Attack 1";
            this.btnAttack1.UseVisualStyleBackColor = false;
            this.btnAttack1.Click += new System.EventHandler(this.btnAttack1_Click);
            // 
            // btnExitGame
            // 
            this.btnExitGame.BackColor = System.Drawing.Color.Red;
            this.btnExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitGame.Location = new System.Drawing.Point(0, -3);
            this.btnExitGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(94, 54);
            this.btnExitGame.TabIndex = 10;
            this.btnExitGame.Text = "EXIT GAME";
            this.btnExitGame.UseVisualStyleBackColor = false;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // btnAttackInfo
            // 
            this.btnAttackInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAttackInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttackInfo.Location = new System.Drawing.Point(89, -2);
            this.btnAttackInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttackInfo.Name = "btnAttackInfo";
            this.btnAttackInfo.Size = new System.Drawing.Size(94, 53);
            this.btnAttackInfo.TabIndex = 11;
            this.btnAttackInfo.Text = "ATTACK INFO";
            this.btnAttackInfo.UseVisualStyleBackColor = false;
            this.btnAttackInfo.Click += new System.EventHandler(this.btnAttackInfo_Click);
            // 
            // btnSkipTurn
            // 
            this.btnSkipTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSkipTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkipTurn.Location = new System.Drawing.Point(0, 48);
            this.btnSkipTurn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSkipTurn.Name = "btnSkipTurn";
            this.btnSkipTurn.Size = new System.Drawing.Size(183, 30);
            this.btnSkipTurn.TabIndex = 12;
            this.btnSkipTurn.Text = "SKIP TURN";
            this.btnSkipTurn.UseVisualStyleBackColor = false;
            this.btnSkipTurn.Click += new System.EventHandler(this.btnSkipTurn_Click);
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 1;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // pcbUserLostHealth
            // 
            this.pcbUserLostHealth.BackColor = System.Drawing.Color.Red;
            this.pcbUserLostHealth.Location = new System.Drawing.Point(215, 373);
            this.pcbUserLostHealth.Margin = new System.Windows.Forms.Padding(2);
            this.pcbUserLostHealth.Name = "pcbUserLostHealth";
            this.pcbUserLostHealth.Size = new System.Drawing.Size(150, 20);
            this.pcbUserLostHealth.TabIndex = 13;
            this.pcbUserLostHealth.TabStop = false;
            // 
            // pcbUserLost
            // 
            this.pcbUserLost.BackColor = System.Drawing.Color.Red;
            this.pcbUserLost.Location = new System.Drawing.Point(215, 373);
            this.pcbUserLost.Margin = new System.Windows.Forms.Padding(2);
            this.pcbUserLost.Name = "pcbUserLost";
            this.pcbUserLost.Size = new System.Drawing.Size(200, 20);
            this.pcbUserLost.TabIndex = 14;
            this.pcbUserLost.TabStop = false;
            // 
            // pcbComputerLost
            // 
            this.pcbComputerLost.BackColor = System.Drawing.Color.Red;
            this.pcbComputerLost.Location = new System.Drawing.Point(232, 58);
            this.pcbComputerLost.Margin = new System.Windows.Forms.Padding(2);
            this.pcbComputerLost.Name = "pcbComputerLost";
            this.pcbComputerLost.Size = new System.Drawing.Size(200, 20);
            this.pcbComputerLost.TabIndex = 15;
            this.pcbComputerLost.TabStop = false;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CulminatingOL.GameImages.grassybackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 509);
            this.Controls.Add(this.pnlMonsterSelect);
            this.Controls.Add(this.pcbCompHP);
            this.Controls.Add(this.pcbComputerLost);
            this.Controls.Add(this.pcbUserHP);
            this.Controls.Add(this.pcbUserLost);
            this.Controls.Add(this.btnSkipTurn);
            this.Controls.Add(this.btnAttackInfo);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.pnlGameBar);
            this.Controls.Add(this.lblCompMonsterName);
            this.Controls.Add(this.pcbComputerInfo);
            this.Controls.Add(this.lblUserMonsterName);
            this.Controls.Add(this.pcbUserInfo);
            this.Controls.Add(this.pcbComputerMonster);
            this.Controls.Add(this.pcbUserMonster);
            this.Controls.Add(this.pcbUserLostHealth);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.pnlMonsterSelect.ResumeLayout(false);
            this.pnlMonsterSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserMonster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbComputerMonster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCompHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbComputerInfo)).EndInit();
            this.pnlGameBar.ResumeLayout(false);
            this.pnlGameBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStaminaBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStaminaLost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserLostHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserLost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbComputerLost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMonsterSelect;
        private System.Windows.Forms.Button btnTellaria;
        private System.Windows.Forms.Button btnFalacia;
        private System.Windows.Forms.Button btnExparia;
        private System.Windows.Forms.Label lblDisclaimer;
        private System.Windows.Forms.Label lblMonsterSelect;
        private System.Windows.Forms.Button btnDoveria;
        private System.Windows.Forms.Button btnSania;
        private System.Windows.Forms.PictureBox pcbUserMonster;
        private System.Windows.Forms.PictureBox pcbComputerMonster;
        private System.Windows.Forms.PictureBox pcbUserInfo;
        private System.Windows.Forms.PictureBox pcbUserHP;
        private System.Windows.Forms.Label lblUserMonsterName;
        private System.Windows.Forms.Label lblCompMonsterName;
        private System.Windows.Forms.PictureBox pcbCompHP;
        private System.Windows.Forms.PictureBox pcbComputerInfo;
        private System.Windows.Forms.Panel pnlGameBar;
        private System.Windows.Forms.PictureBox pcbStaminaBar;
        private System.Windows.Forms.Label lblStaminaTitle;
        private System.Windows.Forms.Button btnAttack3;
        private System.Windows.Forms.Button btnAttack2;
        private System.Windows.Forms.Button btnAttack1;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Button btnAttackInfo;
        private System.Windows.Forms.Button btnSkipTurn;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.PictureBox pcbUserLostHealth;
        private System.Windows.Forms.PictureBox pcbUserLost;
        private System.Windows.Forms.PictureBox pcbComputerLost;
        private System.Windows.Forms.PictureBox pcbStaminaLost;
    }
}