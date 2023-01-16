using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootingArcade
{
    public partial class Records : Form
    {
        WMPLib.WindowsMediaPlayer wplayer2 = new WMPLib.WindowsMediaPlayer();
        public Records()
        {
            InitializeComponent();
            using (BinaryReader read = new BinaryReader(File.Open("Records", FileMode.Open)))
            {
                LabelRecords.Text = read.ReadInt32().ToString();
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            wplayer2.URL = "./Sounds/pistol.mp3";
            wplayer2.controls.play();
            this.Close();
        }
    }
}
