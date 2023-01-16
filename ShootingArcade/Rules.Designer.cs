
namespace ShootingArcade
{
    partial class Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            this.LabelInfoLevel1 = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelInfoLevel1
            // 
            this.LabelInfoLevel1.AutoSize = true;
            this.LabelInfoLevel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelInfoLevel1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfoLevel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LabelInfoLevel1.Image = ((System.Drawing.Image)(resources.GetObject("LabelInfoLevel1.Image")));
            this.LabelInfoLevel1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LabelInfoLevel1.Location = new System.Drawing.Point(66, 244);
            this.LabelInfoLevel1.Name = "LabelInfoLevel1";
            this.LabelInfoLevel1.Size = new System.Drawing.Size(1011, 312);
            this.LabelInfoLevel1.TabIndex = 4;
            this.LabelInfoLevel1.Text = resources.GetString("LabelInfoLevel1.Text");
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
            this.ButtonExit.TabIndex = 5;
            this.ButtonExit.Text = "Назад";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1212, 803);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.LabelInfoLevel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelInfoLevel1;
        private System.Windows.Forms.Button ButtonExit;
    }
}