namespace CulminatingOL
{
    partial class FunBall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunBall));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStartBall = new System.Windows.Forms.Button();
            this.pcbBall = new System.Windows.Forms.PictureBox();
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBall)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(0, 476);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(459, 43);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "EXIT TO TITLE PAGE";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStartBall
            // 
            this.btnStartBall.BackColor = System.Drawing.Color.Lime;
            this.btnStartBall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartBall.Location = new System.Drawing.Point(457, 476);
            this.btnStartBall.Name = "btnStartBall";
            this.btnStartBall.Size = new System.Drawing.Size(464, 43);
            this.btnStartBall.TabIndex = 1;
            this.btnStartBall.Text = "START BALL";
            this.btnStartBall.UseVisualStyleBackColor = false;
            this.btnStartBall.Click += new System.EventHandler(this.btnStartBall_Click);
            // 
            // pcbBall
            // 
            this.pcbBall.BackColor = System.Drawing.Color.Transparent;
            this.pcbBall.BackgroundImage = global::CulminatingOL.GameImages.ball;
            this.pcbBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbBall.Location = new System.Drawing.Point(135, 108);
            this.pcbBall.Name = "pcbBall";
            this.pcbBall.Size = new System.Drawing.Size(65, 59);
            this.pcbBall.TabIndex = 2;
            this.pcbBall.TabStop = false;
            // 
            // tmrMove
            // 
            this.tmrMove.Interval = 1;
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // FunBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CulminatingOL.GameImages.backgroundgambling;
            this.ClientSize = new System.Drawing.Size(919, 517);
            this.Controls.Add(this.pcbBall);
            this.Controls.Add(this.btnStartBall);
            this.Controls.Add(this.btnExit);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FunBall";
            this.Text = "FunBall";
            ((System.ComponentModel.ISupportInitialize)(this.pcbBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStartBall;
        private System.Windows.Forms.PictureBox pcbBall;
        private System.Windows.Forms.Timer tmrMove;
    }
}