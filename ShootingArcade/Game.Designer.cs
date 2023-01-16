
namespace ShootingArcade
{
    partial class Game
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.LabelScore = new System.Windows.Forms.Label();
            this.LabelScoreUpdate = new System.Windows.Forms.Label();
            this.LabelPause = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.LabelBullets = new System.Windows.Forms.Label();
            this.ProgressBarHp = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelGameOver = new System.Windows.Forms.Label();
            this.pictureBoxBomb = new System.Windows.Forms.PictureBox();
            this.pictureBoxBullet = new System.Windows.Forms.PictureBox();
            this.PictureBoxLine = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxShooter = new System.Windows.Forms.PictureBox();
            this.pictureBoxTarget = new System.Windows.Forms.PictureBox();
            this.LabelHealth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 3000;
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(137)))));
            this.LabelScore.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScore.ForeColor = System.Drawing.Color.Black;
            this.LabelScore.Location = new System.Drawing.Point(268, 789);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(170, 51);
            this.LabelScore.TabIndex = 0;
            this.LabelScore.Text = "Score: 0";
            // 
            // LabelScoreUpdate
            // 
            this.LabelScoreUpdate.AutoSize = true;
            this.LabelScoreUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(137)))));
            this.LabelScoreUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScoreUpdate.ForeColor = System.Drawing.Color.Black;
            this.LabelScoreUpdate.Location = new System.Drawing.Point(348, 772);
            this.LabelScoreUpdate.Name = "LabelScoreUpdate";
            this.LabelScoreUpdate.Size = new System.Drawing.Size(44, 26);
            this.LabelScoreUpdate.TabIndex = 2;
            this.LabelScoreUpdate.Text = "-10";
            this.LabelScoreUpdate.Visible = false;
            // 
            // LabelPause
            // 
            this.LabelPause.AutoSize = true;
            this.LabelPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(137)))));
            this.LabelPause.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPause.ForeColor = System.Drawing.Color.Red;
            this.LabelPause.Location = new System.Drawing.Point(298, 329);
            this.LabelPause.Name = "LabelPause";
            this.LabelPause.Size = new System.Drawing.Size(635, 122);
            this.LabelPause.TabIndex = 3;
            this.LabelPause.Text = "Pause\r\nсlick anywhere to continue\r\n";
            this.LabelPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelPause.Visible = false;
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(137)))));
            this.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(590, 454);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(90, 35);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Visible = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // LabelBullets
            // 
            this.LabelBullets.AutoSize = true;
            this.LabelBullets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(137)))));
            this.LabelBullets.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBullets.ForeColor = System.Drawing.Color.Black;
            this.LabelBullets.Location = new System.Drawing.Point(57, 789);
            this.LabelBullets.Name = "LabelBullets";
            this.LabelBullets.Size = new System.Drawing.Size(68, 51);
            this.LabelBullets.TabIndex = 7;
            this.LabelBullets.Text = "10";
            // 
            // ProgressBarHp
            // 
            this.ProgressBarHp.ForeColor = System.Drawing.Color.White;
            this.ProgressBarHp.Location = new System.Drawing.Point(935, 781);
            this.ProgressBarHp.Name = "ProgressBarHp";
            this.ProgressBarHp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProgressBarHp.Size = new System.Drawing.Size(283, 59);
            this.ProgressBarHp.TabIndex = 8;
            this.ProgressBarHp.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(137)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1031, 743);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Health\r\n";
            // 
            // LabelGameOver
            // 
            this.LabelGameOver.AutoSize = true;
            this.LabelGameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(137)))));
            this.LabelGameOver.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGameOver.ForeColor = System.Drawing.Color.Red;
            this.LabelGameOver.Location = new System.Drawing.Point(367, 268);
            this.LabelGameOver.Name = "LabelGameOver";
            this.LabelGameOver.Size = new System.Drawing.Size(523, 183);
            this.LabelGameOver.TabIndex = 13;
            this.LabelGameOver.Text = "GAMEOVER\r\nScore: \r\nсlick anywhere to exit";
            this.LabelGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelGameOver.Visible = false;
            // 
            // pictureBoxBomb
            // 
            this.pictureBoxBomb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(137)))));
            this.pictureBoxBomb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBomb.BackgroundImage")));
            this.pictureBoxBomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBomb.Location = new System.Drawing.Point(213, 12);
            this.pictureBoxBomb.Name = "pictureBoxBomb";
            this.pictureBoxBomb.Size = new System.Drawing.Size(100, 110);
            this.pictureBoxBomb.TabIndex = 12;
            this.pictureBoxBomb.TabStop = false;
            this.pictureBoxBomb.Visible = false;
            // 
            // pictureBoxBullet
            // 
            this.pictureBoxBullet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(137)))));
            this.pictureBoxBullet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBullet.BackgroundImage")));
            this.pictureBoxBullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBullet.Location = new System.Drawing.Point(104, 12);
            this.pictureBoxBullet.Name = "pictureBoxBullet";
            this.pictureBoxBullet.Size = new System.Drawing.Size(90, 110);
            this.pictureBoxBullet.TabIndex = 11;
            this.pictureBoxBullet.TabStop = false;
            this.pictureBoxBullet.Visible = false;
            // 
            // PictureBoxLine
            // 
            this.PictureBoxLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(137)))));
            this.PictureBoxLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxLine.BackgroundImage")));
            this.PictureBoxLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxLine.Location = new System.Drawing.Point(-48, 720);
            this.PictureBoxLine.Name = "PictureBoxLine";
            this.PictureBoxLine.Size = new System.Drawing.Size(1476, 20);
            this.PictureBoxLine.TabIndex = 10;
            this.PictureBoxLine.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(137)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 761);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 90);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxShooter
            // 
            this.pictureBoxShooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(137)))));
            this.pictureBoxShooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxShooter.BackgroundImage")));
            this.pictureBoxShooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxShooter.Location = new System.Drawing.Point(3, 12);
            this.pictureBoxShooter.Name = "pictureBoxShooter";
            this.pictureBoxShooter.Size = new System.Drawing.Size(84, 90);
            this.pictureBoxShooter.TabIndex = 5;
            this.pictureBoxShooter.TabStop = false;
            this.pictureBoxShooter.Visible = false;
            // 
            // pictureBoxTarget
            // 
            this.pictureBoxTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(137)))));
            this.pictureBoxTarget.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTarget.BackgroundImage")));
            this.pictureBoxTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTarget.Location = new System.Drawing.Point(459, 348);
            this.pictureBoxTarget.Name = "pictureBoxTarget";
            this.pictureBoxTarget.Size = new System.Drawing.Size(90, 78);
            this.pictureBoxTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTarget.TabIndex = 1;
            this.pictureBoxTarget.TabStop = false;
            // 
            // LabelHealth
            // 
            this.LabelHealth.AutoSize = true;
            this.LabelHealth.BackColor = System.Drawing.Color.Red;
            this.LabelHealth.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHealth.ForeColor = System.Drawing.Color.Black;
            this.LabelHealth.Location = new System.Drawing.Point(1061, 805);
            this.LabelHealth.Name = "LabelHealth";
            this.LabelHealth.Size = new System.Drawing.Size(52, 29);
            this.LabelHealth.TabIndex = 14;
            this.LabelHealth.Text = "100";
            this.LabelHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(137)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1230, 850);
            this.Controls.Add(this.LabelHealth);
            this.Controls.Add(this.LabelGameOver);
            this.Controls.Add(this.pictureBoxBomb);
            this.Controls.Add(this.pictureBoxBullet);
            this.Controls.Add(this.PictureBoxLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgressBarHp);
            this.Controls.Add(this.LabelBullets);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxShooter);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.LabelPause);
            this.Controls.Add(this.LabelScoreUpdate);
            this.Controls.Add(this.pictureBoxTarget);
            this.Controls.Add(this.LabelScore);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shooting";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Shoot);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.PictureBox pictureBoxTarget;
        private System.Windows.Forms.Label LabelScoreUpdate;
        private System.Windows.Forms.Label LabelPause;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.PictureBox pictureBoxShooter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelBullets;
        private System.Windows.Forms.ProgressBar ProgressBarHp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PictureBoxLine;
        private System.Windows.Forms.PictureBox pictureBoxBullet;
        private System.Windows.Forms.PictureBox pictureBoxBomb;
        private System.Windows.Forms.Label LabelGameOver;
        private System.Windows.Forms.Label LabelHealth;
    }
}

