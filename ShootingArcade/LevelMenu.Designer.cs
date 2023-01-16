
namespace ShootingArcade
{
    partial class LevelMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelMenu));
            this.ButtonLevel1 = new System.Windows.Forms.Button();
            this.ButtonLevel2 = new System.Windows.Forms.Button();
            this.LabelInfoLevel1 = new System.Windows.Forms.Label();
            this.LabelInfoLevel2 = new System.Windows.Forms.Label();
            this.ButtonLevel3 = new System.Windows.Forms.Button();
            this.LabelInfoLevel3 = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLevel1
            // 
            this.ButtonLevel1.BackColor = System.Drawing.Color.Coral;
            this.ButtonLevel1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLevel1.ForeColor = System.Drawing.Color.White;
            this.ButtonLevel1.Image = ((System.Drawing.Image)(resources.GetObject("ButtonLevel1.Image")));
            this.ButtonLevel1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonLevel1.Location = new System.Drawing.Point(470, 135);
            this.ButtonLevel1.Name = "ButtonLevel1";
            this.ButtonLevel1.Size = new System.Drawing.Size(256, 88);
            this.ButtonLevel1.TabIndex = 1;
            this.ButtonLevel1.Text = "Легко";
            this.ButtonLevel1.UseVisualStyleBackColor = false;
            this.ButtonLevel1.Click += new System.EventHandler(this.ButtonLevel1_Click);
            // 
            // ButtonLevel2
            // 
            this.ButtonLevel2.BackColor = System.Drawing.Color.Coral;
            this.ButtonLevel2.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLevel2.ForeColor = System.Drawing.Color.White;
            this.ButtonLevel2.Image = ((System.Drawing.Image)(resources.GetObject("ButtonLevel2.Image")));
            this.ButtonLevel2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonLevel2.Location = new System.Drawing.Point(470, 324);
            this.ButtonLevel2.Name = "ButtonLevel2";
            this.ButtonLevel2.Size = new System.Drawing.Size(256, 88);
            this.ButtonLevel2.TabIndex = 2;
            this.ButtonLevel2.Text = "Средне";
            this.ButtonLevel2.UseVisualStyleBackColor = false;
            this.ButtonLevel2.Click += new System.EventHandler(this.ButtonLevel2_Click);
            // 
            // LabelInfoLevel1
            // 
            this.LabelInfoLevel1.AutoSize = true;
            this.LabelInfoLevel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelInfoLevel1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfoLevel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LabelInfoLevel1.Image = ((System.Drawing.Image)(resources.GetObject("LabelInfoLevel1.Image")));
            this.LabelInfoLevel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelInfoLevel1.Location = new System.Drawing.Point(750, 135);
            this.LabelInfoLevel1.Name = "LabelInfoLevel1";
            this.LabelInfoLevel1.Size = new System.Drawing.Size(329, 90);
            this.LabelInfoLevel1.TabIndex = 3;
            this.LabelInfoLevel1.Text = "Настройки:\r\nПатроны: 7\r\nЗдоровье: 100\r\nСкорость: 750мс\r\nУрон от врагов (террорист" +
    ", бомба): -10, -20;";
            // 
            // LabelInfoLevel2
            // 
            this.LabelInfoLevel2.AutoSize = true;
            this.LabelInfoLevel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelInfoLevel2.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfoLevel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LabelInfoLevel2.Image = ((System.Drawing.Image)(resources.GetObject("LabelInfoLevel2.Image")));
            this.LabelInfoLevel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelInfoLevel2.Location = new System.Drawing.Point(750, 324);
            this.LabelInfoLevel2.Name = "LabelInfoLevel2";
            this.LabelInfoLevel2.Size = new System.Drawing.Size(329, 90);
            this.LabelInfoLevel2.TabIndex = 4;
            this.LabelInfoLevel2.Text = "Настройки:\r\nПатроны: 5\r\nЗдоровье: 100\r\nСкорость: 700мс\r\nУрон от врагов (террорист" +
    ", бомба): -20, -30;";
            // 
            // ButtonLevel3
            // 
            this.ButtonLevel3.BackColor = System.Drawing.Color.Coral;
            this.ButtonLevel3.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLevel3.ForeColor = System.Drawing.Color.White;
            this.ButtonLevel3.Image = ((System.Drawing.Image)(resources.GetObject("ButtonLevel3.Image")));
            this.ButtonLevel3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonLevel3.Location = new System.Drawing.Point(470, 498);
            this.ButtonLevel3.Name = "ButtonLevel3";
            this.ButtonLevel3.Size = new System.Drawing.Size(256, 88);
            this.ButtonLevel3.TabIndex = 5;
            this.ButtonLevel3.Text = "Хардкор";
            this.ButtonLevel3.UseVisualStyleBackColor = false;
            this.ButtonLevel3.Click += new System.EventHandler(this.ButtonLevel3_Click);
            // 
            // LabelInfoLevel3
            // 
            this.LabelInfoLevel3.AutoSize = true;
            this.LabelInfoLevel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelInfoLevel3.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfoLevel3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LabelInfoLevel3.Image = ((System.Drawing.Image)(resources.GetObject("LabelInfoLevel3.Image")));
            this.LabelInfoLevel3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelInfoLevel3.Location = new System.Drawing.Point(750, 498);
            this.LabelInfoLevel3.Name = "LabelInfoLevel3";
            this.LabelInfoLevel3.Size = new System.Drawing.Size(210, 90);
            this.LabelInfoLevel3.TabIndex = 6;
            this.LabelInfoLevel3.Text = "Настройки:\r\nПатроны: 3\r\nЗдоровье: 100\r\nСкорость: 600мс\r\nУрон от любого врага: -10" +
    "0;";
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.Coral;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonExit.Location = new System.Drawing.Point(473, 635);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(256, 88);
            this.ButtonExit.TabIndex = 7;
            this.ButtonExit.Text = "Назад";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // LevelMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1212, 803);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.LabelInfoLevel3);
            this.Controls.Add(this.ButtonLevel3);
            this.Controls.Add(this.LabelInfoLevel2);
            this.Controls.Add(this.LabelInfoLevel1);
            this.Controls.Add(this.ButtonLevel2);
            this.Controls.Add(this.ButtonLevel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LevelMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LevelMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLevel1;
        private System.Windows.Forms.Button ButtonLevel2;
        private System.Windows.Forms.Label LabelInfoLevel1;
        private System.Windows.Forms.Label LabelInfoLevel2;
        private System.Windows.Forms.Button ButtonLevel3;
        private System.Windows.Forms.Label LabelInfoLevel3;
        private System.Windows.Forms.Button ButtonExit;
    }
}