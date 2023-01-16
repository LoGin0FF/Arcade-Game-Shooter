using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootingArcade
{
    public partial class Menu : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer wplayer2 = new WMPLib.WindowsMediaPlayer();
        public Menu()
        {
            InitializeComponent();
            wplayer.URL = "./Sounds/Menu.mp3";
            wplayer2.URL = "./Sounds/pistol.mp3";
            wplayer2.controls.stop();
            wplayer.controls.play();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            wplayer2.controls.play();
            Application.Exit();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            wplayer2.controls.play();
            LevelMenu gameWindow = new LevelMenu(wplayer);
            gameWindow.Show();
        }

        private void ButtonRecords_Click(object sender, EventArgs e)
        {
            wplayer2.controls.play();
            Records gameWindow = new Records();
            gameWindow.Show();
        }

        private void ButtonRules_Click(object sender, EventArgs e)
        {
            wplayer2.controls.play();
            Rules gameWindow = new Rules();
            gameWindow.Show();
        }
    }
}
