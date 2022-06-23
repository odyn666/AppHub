using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerTut
{
    public partial class Form2 : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        String[] paths, files;
        private void btnSongImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]);
                }

            }

        }
        private void btnPlaySong_Click(object sender, EventArgs e)
        {
            try
            {
                player.URL = paths[listBoxSongs.SelectedIndex];

            }
            catch (Exception b)
            {

                throw;
            }
            player.controls.play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.previous();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            player.controls.next();
        }

    }
}
