
namespace ShootingArcade
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonRecords = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonRules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.Color.Coral;
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.ForeColor = System.Drawing.Color.White;
            this.ButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("ButtonStart.Image")));
            this.ButtonStart.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonStart.Location = new System.Drawing.Point(470, 135);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(256, 88);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "СТАРТ";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonRecords
            // 
            this.ButtonRecords.BackColor = System.Drawing.Color.Coral;
            this.ButtonRecords.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRecords.ForeColor = System.Drawing.Color.White;
            this.ButtonRecords.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRecords.Image")));
            this.ButtonRecords.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonRecords.Location = new System.Drawing.Point(470, 430);
            this.ButtonRecords.Name = "ButtonRecords";
            this.ButtonRecords.Size = new System.Drawing.Size(256, 88);
            this.ButtonRecords.TabIndex = 1;
            this.ButtonRecords.Text = "РЕКОРДЫ";
            this.ButtonRecords.UseVisualStyleBackColor = false;
            this.ButtonRecords.Click += new System.EventHandler(this.ButtonRecords_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.Coral;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonExit.Location = new System.Drawing.Point(470, 572);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(256, 88);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "ВЫХОД";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonRules
            // 
            this.ButtonRules.BackColor = System.Drawing.Color.Coral;
            this.ButtonRules.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRules.ForeColor = System.Drawing.Color.White;
            this.ButtonRules.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRules.Image")));
            this.ButtonRules.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonRules.Location = new System.Drawing.Point(470, 283);
            this.ButtonRules.Name = "ButtonRules";
            this.ButtonRules.Size = new System.Drawing.Size(256, 88);
            this.ButtonRules.TabIndex = 3;
            this.ButtonRules.Text = "ПРАВИЛА";
            this.ButtonRules.UseVisualStyleBackColor = false;
            this.ButtonRules.Click += new System.EventHandler(this.ButtonRules_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1212, 803);
            this.Controls.Add(this.ButtonRules);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonRecords);
            this.Controls.Add(this.ButtonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonRecords;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonRules;
    }
}