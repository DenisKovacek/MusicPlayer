using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlaylist
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }

        //creating global variables of string type to save the titles and path of the tracks
        String[] paths, files;

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code to play selected song
            winMusicPlayer.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //code to select songs to play
            OpenFileDialog ofd = new OpenFileDialog();
            //select multiple files (songs) to play
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //saving the names of the track in the array
                paths = ofd.FileNames; //saving the path of the track in the array
                //display the song titles in the listbox
                for(int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]);
                }
            }
        }
    }
}
