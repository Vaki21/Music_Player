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

namespace MusicPlayer2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //Opens browser dialog to choose a folder with songs
        private void btBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path;
                checkedListSongs.Items.Clear();
                path = folderBrowserDialog1.SelectedPath;
                string[] files = Directory.GetFiles(path);
                string[] dirs = Directory.GetDirectories(path);

                foreach (string file in files)
                {
                    if (file.EndsWith(".wav"))
                    {
                        checkedListSongs.Items.Add(Path.GetFullPath(file));
                    }

                }
                ListRefresh(listCreatedAlbs.Items, @"C:\\Albums\\");
            }
        }
        //Creates an album with user selected nameb
        private void btCreate_Click(object sender, EventArgs e)
        {
            int selectedCount;
            selectedCount = checkedListSongs.CheckedItems.Count;
            if (!(string.IsNullOrEmpty(textAlbName.Text)))
            {
                if (Directory.Exists(@"C:\Albums\"))
                {
                    string fileName = @"C:\Albums\" + textAlbName.Text + ".txt";
                    using (var sw = new StreamWriter(fileName, false))
                    {
                        foreach (object o in checkedListSongs.CheckedItems)
                        {
                            sw.WriteLine(o);
                        }
                    }
                }
                else
                {
                    System.IO.Directory.CreateDirectory(@"C:\Albums\");
                    string fileName = @"C:\Albums\" + textAlbName.Text + ".txt";
                    using (var sw = new StreamWriter(fileName, false))
                    {
                        foreach (object o in checkedListSongs.CheckedItems)
                        {
                            sw.WriteLine(o);
                        }
                    }
                }

                ListRefresh(listCreatedAlbs.Items, @"C:\\Albums\\");
            }
            else
            {
                MessageBox.Show("Please fill the name first!");
            }
        }
        //Deletes selected album
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (listCreatedAlbs.SelectedIndex != -1)
            {
                File.Delete(Convert.ToString(listCreatedAlbs.SelectedItem));
            }
            else
            {
                MessageBox.Show("Please select an album first!");
            }

            ListRefresh(listCreatedAlbs.Items, @"C:\\Albums\\");
        }
        //Hides Album editor
        private void btToSongs_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textAlbName_TextChanged(object sender, EventArgs e)
        {

        }
        //Reloads albums in album editor
        private void btRefresh_Click(object sender, EventArgs e)
        {
            ListRefresh(listCreatedAlbs.Items, @"C:\\Albums\\");
        }

        /// <summary>
        /// Refreshes listbox of albums.
        /// </summary>
        /// <param name="items">selected listbox</param>
        /// <param name="cesta">path to albums</param>
        public static void ListRefresh(ListBox.ObjectCollection items, string cesta)
        {
            items.Clear();
            string[] files = Directory.GetFiles(cesta);

            foreach (string file in files)
            {
                if (file.EndsWith(".txt"))
                {
                    items.Add(Path.GetFullPath(file));
                }

            }
        }
    }
}
