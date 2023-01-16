using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace ShootingArcade
{
    public partial class Game : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        int ObjectGameNow; //1 - Target, 2 - Shooter, 3 - Bomb, 4 - Ammo
        int Bullets, DamageShooter, DamageBomb;
        bool Pause = false;
        Random rand = new Random();
        int Score = 0;
        public Game(int Bullets, int Speed, int DamageShooter, int DamageBomb, WindowsMediaPlayer wplayer)
        {
            InitializeComponent();

            wplayer.controls.stop();

            this.Bullets = Bullets;
            timer.Interval = Speed;
            this.DamageShooter = DamageShooter;
            this.DamageBomb = DamageBomb;

            LabelBullets.Text = Bullets.ToString();
            KeyDown += new KeyEventHandler(Check);
            timer.Tick += new System.EventHandler(Update);
            pictureBoxTarget.MouseClick += new MouseEventHandler(ShootInTarget);
            pictureBoxShooter.MouseClick += new MouseEventHandler(ShootInTarget);
            pictureBoxBullet.MouseClick += new MouseEventHandler(ShootInTarget);
            pictureBoxBomb.MouseClick += new MouseEventHandler(ShootInTarget);
        }
        private void Update(object sender, EventArgs e) 
        {
            PauseVisible(Pause);
            ShootDamage();
            GameOver();
            LabelScoreUpdate.Visible = false;
            RandomProbalitySpawn();
            Invalidate();
        }
        private void Shoot(object sender, MouseEventArgs e)
        {
            WindowsPlayer("./Sounds/noHit.mp3");
            AmmoUpdate(-1);
            PauseVisible(Pause);
            ShootDamage();
            GameOver();
            RandomProbalitySpawn();
            timer.Stop();
            timer.Start();
        }
        private void ShootInTarget(object sender, MouseEventArgs e)
        {
            PauseVisible(Pause);
            if (ObjectGameNow == 4)
            {
                WindowsPlayer("./Sounds/plusBullet.mp3");
                AmmoUpdate(1);
            }
            else
            {
                WindowsPlayer("./Sounds/pistol.mp3");
                ScoreUpdate(ObjectGameNow * 10);
            }
            RandomProbalitySpawn();
            timer.Stop();
            timer.Start();
        }
        private void Check(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Pause = true;
                PauseVisible(Pause);
                Pause = false;
            }
        }
        public void PauseVisible(bool Pause)
        {
            LabelPause.Visible = Pause;
            ButtonExit.Visible = Pause;
            if (Pause == true) timer.Stop();
        }
        public int RandomFunc(Random rand, bool flagWidth)
        {
            int size;
            if (flagWidth) size = this.Size.Width - 100;
            else size = 500;
            int rnd = rand.Next(0, size);
            return rnd;
        }
        public void RandomProbalitySpawn()
        {
            int randomProbability = rand.Next(0, 10);
            if (randomProbability >= 0 && randomProbability < 4) //40%
            {
                pictureBoxTarget.Location = new Point(RandomFunc(rand, true), RandomFunc(rand, false));
                pictureBoxTarget.Visible = true;
                pictureBoxShooter.Visible = false;
                pictureBoxBullet.Visible = false;
                pictureBoxBomb.Visible = false;
                ObjectGameNow = 1;
            }
            if (randomProbability >= 4 && randomProbability < 7) //30%
            {
                pictureBoxShooter.Location = new Point(RandomFunc(rand, true), RandomFunc(rand, false));
                pictureBoxShooter.Visible = true;
                pictureBoxTarget.Visible = false;
                pictureBoxBullet.Visible = false;
                pictureBoxBomb.Visible = false;
                ObjectGameNow = 2;
            }
            if (randomProbability >= 7 && randomProbability < 9) //20%
            {
                pictureBoxBomb.Location = new Point(RandomFunc(rand, true), RandomFunc(rand, false));
                pictureBoxBomb.Visible = true;
                pictureBoxTarget.Visible = false;
                pictureBoxShooter.Visible = false;
                pictureBoxBullet.Visible = false;
                ObjectGameNow = 3;
            }
            if (randomProbability == 9) //10%
            {
                pictureBoxBullet.Location = new Point(RandomFunc(rand, true), RandomFunc(rand, false));
                pictureBoxBullet.Visible = true;
                pictureBoxTarget.Visible = false;
                pictureBoxShooter.Visible = false;
                pictureBoxBomb.Visible = false;
                ObjectGameNow = 4;
            }
        }
        public void AmmoUpdate(int ObjectGame)
        {
            Bullets += ObjectGame;
            LabelBullets.Text = Bullets.ToString();
        }
        public void ScoreUpdate(int scoreUpdate)
        {
            Score += scoreUpdate;
            LabelScore.Text = "Score: " + Score;
            LabelScoreUpdate.Visible = true;
            LabelScoreUpdate.Text = "+" + scoreUpdate.ToString();
        }
        public void WindowsPlayer(string URL)
        {
            wplayer.URL = URL;
            wplayer.controls.play();
        }
        public void HealthUpdate(int healthUpdate)
        {
            ProgressBarHp.Value -= healthUpdate;
            LabelHealth.Text = ProgressBarHp.Value.ToString();
        }
        public void GameOver()
        {
            string filename = "Records";
            bool flag = false;
            if (ProgressBarHp.Value == ProgressBarHp.Minimum || Bullets == 0)
            {
                Pause = false;
                PicBoxVisible();
                LabelGameOver.Visible = true;
                LabelGameOver.Text = "GAMEOVER\n" + "Score: " + Score + "\nclick anywhere to exit";
                LabelHealth.Text = ProgressBarHp.Minimum.ToString();
                timer.Stop();
                MouseClick += CheckGameOver;
            }
            else return;
            using (BinaryReader read = new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                int ScoreFile = read.ReadInt32();
                if (Score > ScoreFile) flag = true;
            }
            if (flag)
            {
                using (BinaryWriter write = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate)))
                {
                    write.Write(Score);
                }
            }
        }
        private void PicBoxVisible()
        {
            pictureBoxBomb.Visible = false;
            pictureBoxBullet.Visible = false;
            pictureBoxShooter.Visible = false;
            pictureBoxTarget.Visible = false;
        }
        public void ShootDamage()
        {
            if (ObjectGameNow == 2 || ObjectGameNow == 3)
            {
                int tempDamage = DamageShooter;
                if (ObjectGameNow == 3)
                {
                    WindowsPlayer("./Sounds/bomb.mp3");
                    tempDamage = DamageBomb;
                }
                else WindowsPlayer("./Sounds/minusHP.mp3");
                int tempHealth = ProgressBarHp.Value - tempDamage;
                if (tempHealth <= 0)
                {
                    ProgressBarHp.Value = ProgressBarHp.Minimum;
                    GameOver();
                }
                else HealthUpdate(tempDamage);
            }
        }
        private void CheckGameOver(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
