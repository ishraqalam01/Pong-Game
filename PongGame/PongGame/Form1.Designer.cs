namespace MovingGamePractice
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.pcbBall = new System.Windows.Forms.PictureBox();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.pcbPaddle = new System.Windows.Forms.PictureBox();
            this.pcbComputerPaddle = new System.Windows.Forms.PictureBox();
            this.pcbInvisibleComputerPaddle = new System.Windows.Forms.PictureBox();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblHighScoreValue = new System.Windows.Forms.Label();
            this.lblCurrentScore = new System.Windows.Forms.Label();
            this.lblCurrentScoreValue = new System.Windows.Forms.Label();
            this.lblUserWins = new System.Windows.Forms.Label();
            this.lblUserWinsValue = new System.Windows.Forms.Label();
            this.lblComputerWins = new System.Windows.Forms.Label();
            this.lblCompWinsValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbComputerPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInvisibleComputerPaddle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(441, 455);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(192, 66);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pcbBall
            // 
            this.pcbBall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pcbBall.Location = new System.Drawing.Point(501, 328);
            this.pcbBall.Margin = new System.Windows.Forms.Padding(4);
            this.pcbBall.Name = "pcbBall";
            this.pcbBall.Size = new System.Drawing.Size(40, 38);
            this.pcbBall.TabIndex = 1;
            this.pcbBall.TabStop = false;
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 1;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(954, 501);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 41);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pcbPaddle
            // 
            this.pcbPaddle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pcbPaddle.Location = new System.Drawing.Point(428, 388);
            this.pcbPaddle.Name = "pcbPaddle";
            this.pcbPaddle.Size = new System.Drawing.Size(215, 22);
            this.pcbPaddle.TabIndex = 10;
            this.pcbPaddle.TabStop = false;
            // 
            // pcbComputerPaddle
            // 
            this.pcbComputerPaddle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pcbComputerPaddle.Location = new System.Drawing.Point(428, 34);
            this.pcbComputerPaddle.Name = "pcbComputerPaddle";
            this.pcbComputerPaddle.Size = new System.Drawing.Size(215, 22);
            this.pcbComputerPaddle.TabIndex = 16;
            this.pcbComputerPaddle.TabStop = false;
            // 
            // pcbInvisibleComputerPaddle
            // 
            this.pcbInvisibleComputerPaddle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pcbInvisibleComputerPaddle.Location = new System.Drawing.Point(428, 55);
            this.pcbInvisibleComputerPaddle.Name = "pcbInvisibleComputerPaddle";
            this.pcbInvisibleComputerPaddle.Size = new System.Drawing.Size(215, 10);
            this.pcbInvisibleComputerPaddle.TabIndex = 17;
            this.pcbInvisibleComputerPaddle.TabStop = false;
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHighScore.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.Black;
            this.lblHighScore.Location = new System.Drawing.Point(12, 507);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(223, 35);
            this.lblHighScore.TabIndex = 18;
            this.lblHighScore.Text = "HIGH SCORE: ";
            // 
            // lblHighScoreValue
            // 
            this.lblHighScoreValue.AutoSize = true;
            this.lblHighScoreValue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHighScoreValue.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScoreValue.ForeColor = System.Drawing.Color.Black;
            this.lblHighScoreValue.Location = new System.Drawing.Point(220, 507);
            this.lblHighScoreValue.Name = "lblHighScoreValue";
            this.lblHighScoreValue.Size = new System.Drawing.Size(33, 35);
            this.lblHighScoreValue.TabIndex = 19;
            this.lblHighScoreValue.Text = "0";
            // 
            // lblCurrentScore
            // 
            this.lblCurrentScore.AutoSize = true;
            this.lblCurrentScore.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCurrentScore.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScore.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentScore.Location = new System.Drawing.Point(12, 455);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(271, 35);
            this.lblCurrentScore.TabIndex = 20;
            this.lblCurrentScore.Text = "CURRENT SCORE:";
            // 
            // lblCurrentScoreValue
            // 
            this.lblCurrentScoreValue.AutoSize = true;
            this.lblCurrentScoreValue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCurrentScoreValue.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScoreValue.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentScoreValue.Location = new System.Drawing.Point(279, 455);
            this.lblCurrentScoreValue.Name = "lblCurrentScoreValue";
            this.lblCurrentScoreValue.Size = new System.Drawing.Size(33, 35);
            this.lblCurrentScoreValue.TabIndex = 21;
            this.lblCurrentScoreValue.Text = "0";
            // 
            // lblUserWins
            // 
            this.lblUserWins.AutoSize = true;
            this.lblUserWins.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserWins.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserWins.ForeColor = System.Drawing.Color.Black;
            this.lblUserWins.Location = new System.Drawing.Point(12, 21);
            this.lblUserWins.Name = "lblUserWins";
            this.lblUserWins.Size = new System.Drawing.Size(173, 35);
            this.lblUserWins.TabIndex = 22;
            this.lblUserWins.Text = "User Wins:";
            // 
            // lblUserWinsValue
            // 
            this.lblUserWinsValue.AutoSize = true;
            this.lblUserWinsValue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserWinsValue.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserWinsValue.ForeColor = System.Drawing.Color.Black;
            this.lblUserWinsValue.Location = new System.Drawing.Point(182, 21);
            this.lblUserWinsValue.Name = "lblUserWinsValue";
            this.lblUserWinsValue.Size = new System.Drawing.Size(33, 35);
            this.lblUserWinsValue.TabIndex = 23;
            this.lblUserWinsValue.Text = "0";
            // 
            // lblComputerWins
            // 
            this.lblComputerWins.AutoSize = true;
            this.lblComputerWins.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblComputerWins.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerWins.ForeColor = System.Drawing.Color.Black;
            this.lblComputerWins.Location = new System.Drawing.Point(12, 74);
            this.lblComputerWins.Name = "lblComputerWins";
            this.lblComputerWins.Size = new System.Drawing.Size(140, 35);
            this.lblComputerWins.TabIndex = 24;
            this.lblComputerWins.Text = "AI Wins:";
            // 
            // lblCompWinsValue
            // 
            this.lblCompWinsValue.AutoSize = true;
            this.lblCompWinsValue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCompWinsValue.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompWinsValue.ForeColor = System.Drawing.Color.Black;
            this.lblCompWinsValue.Location = new System.Drawing.Point(152, 74);
            this.lblCompWinsValue.Name = "lblCompWinsValue";
            this.lblCompWinsValue.Size = new System.Drawing.Size(33, 35);
            this.lblCompWinsValue.TabIndex = 25;
            this.lblCompWinsValue.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MovingGamePractice.Properties.Resources.flippedpongbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1161, 554);
            this.Controls.Add(this.lblCompWinsValue);
            this.Controls.Add(this.lblComputerWins);
            this.Controls.Add(this.lblUserWinsValue);
            this.Controls.Add(this.lblUserWins);
            this.Controls.Add(this.lblCurrentScoreValue);
            this.Controls.Add(this.lblCurrentScore);
            this.Controls.Add(this.lblHighScoreValue);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.pcbInvisibleComputerPaddle);
            this.Controls.Add(this.pcbComputerPaddle);
            this.Controls.Add(this.pcbPaddle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pcbBall);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Brown;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbComputerPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInvisibleComputerPaddle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pcbBall;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pcbPaddle;
        private System.Windows.Forms.PictureBox pcbComputerPaddle;
        private System.Windows.Forms.PictureBox pcbInvisibleComputerPaddle;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblHighScoreValue;
        private System.Windows.Forms.Label lblCurrentScore;
        private System.Windows.Forms.Label lblCurrentScoreValue;
        private System.Windows.Forms.Label lblUserWins;
        private System.Windows.Forms.Label lblUserWinsValue;
        private System.Windows.Forms.Label lblComputerWins;
        private System.Windows.Forms.Label lblCompWinsValue;
    }
}

