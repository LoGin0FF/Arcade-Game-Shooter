using System;
using System.Windows.Forms;
using WMPLib;

namespace ShootingArcade
{
    public partial class LevelMenu : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer wplayer2 = new WMPLib.WindowsMediaPlayer();
        int Level;
        public LevelMenu(WindowsMediaPlayer wplayer)
        {
            InitializeComponent();
            wplayer2.URL = "./Sounds/pistol.mp3";
            wplayer2.controls.stop();
            this.wplayer = wplayer;
        }
        public void Init()
        {
            switch (Level)
            {
                case 1:
                    wplayer2.controls.play();
                    Game gameWindow = new Game(7, 750, 10, 20, wplayer);
                    this.Close();
                    gameWindow.Show();
                    break;
                case 2:
                    wplayer2.controls.play();
                    Game gameWindow2 = new Game(5, 700, 20, 30, wplayer);
                    this.Close();
                    gameWindow2.Show();
                    break;
                case 3:
                    wplayer2.controls.play();
                    Game gameWindow3 = new Game(3, 600, 100, 100, wplayer);
                    this.Close();
                    gameWindow3.Show();
                    break;
            }
        }
        private void ButtonLevel1_Click(object sender, EventArgs e)
        {
            wplayer2.controls.play();
            Level = 1;
            Init();
        }

        private void ButtonLevel2_Click(object sender, EventArgs e)
        {
            wplayer2.controls.play();
            Level = 2;
            Init();
        }

        private void ButtonLevel3_Click(object sender, EventArgs e)
        {
            wplayer2.controls.play();
            Level = 3;
            Init();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            wplayer2.controls.play();
            this.Close();
        }
    }
}