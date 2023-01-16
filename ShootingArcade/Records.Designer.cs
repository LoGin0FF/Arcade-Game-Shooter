
namespace ShootingArcade
{
    partial class Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records));
            this.LabelScore = new System.Windows.Forms.Label();
            this.LabelRecords = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(137)))));
            this.LabelScore.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScore.ForeColor = System.Drawing.Color.Black;
            this.LabelScore.Image = ((System.Drawing.Image)(resources.GetObject("LabelScore.Image")));
            this.LabelScore.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LabelScore.Location = new System.Drawing.Point(508, 127);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(183, 51);
            this.LabelScore.TabIndex = 1;
            this.LabelScore.Text = "Records:";
            // 
            // LabelRecords
            // 
            this.LabelRecords.AutoSize = true;
            this.LabelRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(137)))));
            this.LabelRecords.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRecords.ForeColor = System.Drawing.Color.Black;
            this.LabelRecords.Image = ((System.Drawing.Image)(resources.GetObject("LabelRecords.Image")));
            this.LabelRecords.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LabelRecords.Location = new System.Drawing.Point(548, 200);
            this.LabelRecords.Name = "LabelRecords";
            this.LabelRecords.Size = new System.Drawing.Size(114, 51);
            this.LabelRecords.TabIndex = 8;
            this.LabelRecords.Text = "1000";
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
            this.ButtonExit.TabIndex = 9;
            this.ButtonExit.Text = "НАЗАД";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1212, 803);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.LabelRecords);
            this.Controls.Add(this.LabelScore);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Label LabelRecords;
        private System.Windows.Forms.Button ButtonExit;
    }
}