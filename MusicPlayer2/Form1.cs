using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace MusicPlayer2
{
    public partial class Music : Form
    {
        public Music()
        {
            InitializeComponent();
        }

        Form2 f = new Form2();

        //Opens browser to select a folder with songs
        private void btBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path;
                listSongs.Items.Clear();
                listAlbs.Items.Clear();
                path = folderBrowserDialog1.SelectedPath;
                string[] files = Directory.GetFiles(path);
                string[] dirs = Directory.GetDirectories(path);

                foreach (string file in files)
                {
                    if (file.EndsWith(".wav"))
                    {
                        listSongs.Items.Add(Path.GetFileName(file));
                    }

                }
            }
        }
        //Reloads albums on main page
        private void btRld_Click(object sender, EventArgs e)
        {
            Form2.ListRefresh(listAlbs.Items, @"C:\\Albums\\");
            f = new Form2();
        }
        //Plays a selected song
        private void btPlay_Click(object sender, EventArgs e)
        {
            string song;
            string path;
            string selectedSong;
            int pos;

            if ((listSongs.SelectedIndex == -1))
            {
                MessageBox.Show("Please select a song first!");
            }
            else if((listSongs.SelectedIndex > -1) && (listAlbs.SelectedIndex == -1))
            {
                song = Convert.ToString(listSongs.SelectedItem);
                path = folderBrowserDialog1.SelectedPath;
                selectedSong = (path + "\\" + song);

                try
                {
                    SoundPlayer player = new System.Media.SoundPlayer(selectedSong);
                    songName.Text = song;
                    player.Play();
                }
                catch (Exception)
                {
                    MessageBox.Show("Selected file isn't a WAV file...");
                }

            }
            else if ((listSongs.SelectedIndex > -1) && (listAlbs.SelectedIndex > -1))
            {
                song = Convert.ToString(listSongs.SelectedItem);
                pos = song.LastIndexOf("\\") + 1;
                
                try
                {
                    songName.Text = song.Substring(pos, song.Length - pos);
                    SoundPlayer player = new System.Media.SoundPlayer(song);
                    player.Play();
                }
                catch (Exception)
                {
                    MessageBox.Show("Selected file isn't a WAV file...");
                }
            }
        }
        //Stops any playing music
        private void btStop_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new System.Media.SoundPlayer();
            songName.Text = "";
            player.Stop();
        }
        //Plays previous song either from a folder or from a playlist
        private void btPrev_Click(object sender, EventArgs e)
        {
            int songCount;
            songCount = listSongs.Items.Count;

            int songIndex;
            string path;

            if ((songCount > 0) && (listSongs.SelectedIndex > 0) && (listAlbs.SelectedIndex == -1))
            {
                path = folderBrowserDialog1.SelectedPath;
                string[] files = Directory.GetFiles(path);
                PrevNextSong(songCount, out songIndex, -1, files);

            }
            else if ((songCount > 0) && (listSongs.SelectedIndex < songCount) && (listAlbs.SelectedIndex > -1))
            {
                string[] files = new string[listSongs.Items.Count];
                for (int i = 0; i < listSongs.Items.Count; i++)
                {
                    files[i] = Convert.ToString(listSongs.Items[i]);
                }
                PrevNextSong(songCount, out songIndex, -1, files);

            }
        }
        //Plays next song either from a folder or from a playlist
        private void btNext_Click(object sender, EventArgs e)
        {
            int songCount;
            songCount = listSongs.Items.Count;

            int songIndex;

            string path;

            if ((songCount > 0) && (listSongs.SelectedIndex < songCount) && (listAlbs.SelectedIndex == -1))
            {
                path = folderBrowserDialog1.SelectedPath;
                string[] files = Directory.GetFiles(path);
                PrevNextSong(songCount, out songIndex, 1, files);
            }
            else if ((songCount > 0) && (listSongs.SelectedIndex < songCount) && (listAlbs.SelectedIndex > -1))
            {
                string[] files = new string[listSongs.Items.Count];
                for (int i = 0; i < listSongs.Items.Count; i++)
                {
                    files[i] = Convert.ToString(listSongs.Items[i]);
                }
                PrevNextSong(songCount, out songIndex, 1, files);
            }
        }
        //Opens Album editor
        internal void btToAlbs_Click(object sender, EventArgs e)
        {
            f.Show();
        }
        //Opens songs from selected Album
        private void btSelect_Click(object sender, EventArgs e)
        {
            string selectedAlbum;
            if ((listAlbs.SelectedIndex == -1) && (listAlbs.SelectedIndex == -1))
            {
                MessageBox.Show("Please select an Album first!");
            }
            else
            {
                selectedAlbum = Convert.ToString(listAlbs.SelectedItem);
                IEnumerable<string> lines = File.ReadLines(selectedAlbum);
                listSongs.Items.Clear();
                foreach (string line in lines)
                {
                    listSongs.Items.Add(line);
                }
            }
        }
        /// <summary>
        /// Plays the next or previous song depending on the parameters.
        /// </summary>
        /// <param name="songCount">Counts songs in a list</param>
        /// <param name="songIndex">Gets index of a selected song</param>
        /// <param name="znamenko">Indicates if it is a next or previous song</param>
        /// <param name="files">Array of songs</param>
        private void PrevNextSong(int songCount, out int songIndex, int znamenko, string[] files)
        {
            songIndex = Convert.ToInt32(listSongs.SelectedIndex);
            int pos;

            for (int i = 0; i < songCount; i++)
            {
                if (files[i] == files[songIndex])
                {
                    try
                    {
                        pos = files[i + znamenko].LastIndexOf("\\") + 1;
                        songName.Text = files[i + znamenko].Substring(pos, files[i + znamenko].Length - pos);
                        SoundPlayer player = new System.Media.SoundPlayer(files[songIndex + znamenko]);
                        player.Play();
                        listSongs.SetSelected((songIndex + znamenko), true);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Selected file isn't a WAV file or You reached the end of the queue...");
                    }
                }
            }
        }

        private void pictureSong_Click(object sender, EventArgs e)
        {

        }
    }
}
