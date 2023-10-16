
namespace MusicPlayer2
{
    partial class Music
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btSelect = new System.Windows.Forms.Button();
            this.listAlbs = new System.Windows.Forms.ListBox();
            this.listSongs = new System.Windows.Forms.ListBox();
            this.btRld = new System.Windows.Forms.Button();
            this.btBrowse = new System.Windows.Forms.Button();
            this.songName = new System.Windows.Forms.Label();
            this.btStop = new System.Windows.Forms.Button();
            this.pictureSong = new System.Windows.Forms.PictureBox();
            this.btToAlbs = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btPrev = new System.Windows.Forms.Button();
            this.btPlay = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSong)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btSelect);
            this.splitContainer1.Panel1.Controls.Add(this.listAlbs);
            this.splitContainer1.Panel1.Controls.Add(this.listSongs);
            this.splitContainer1.Panel1.Controls.Add(this.btRld);
            this.splitContainer1.Panel1.Controls.Add(this.btBrowse);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.songName);
            this.splitContainer1.Panel2.Controls.Add(this.btStop);
            this.splitContainer1.Panel2.Controls.Add(this.pictureSong);
            this.splitContainer1.Panel2.Controls.Add(this.btToAlbs);
            this.splitContainer1.Panel2.Controls.Add(this.btNext);
            this.splitContainer1.Panel2.Controls.Add(this.btPrev);
            this.splitContainer1.Panel2.Controls.Add(this.btPlay);
            this.splitContainer1.Size = new System.Drawing.Size(904, 506);
            this.splitContainer1.SplitterDistance = 198;
            this.splitContainer1.TabIndex = 0;
            // 
            // btSelect
            // 
            this.btSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btSelect.Location = new System.Drawing.Point(0, 306);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(198, 23);
            this.btSelect.TabIndex = 4;
            this.btSelect.Text = "Select Album";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // listAlbs
            // 
            this.listAlbs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listAlbs.FormattingEnabled = true;
            this.listAlbs.ItemHeight = 15;
            this.listAlbs.Location = new System.Drawing.Point(0, 329);
            this.listAlbs.Name = "listAlbs";
            this.listAlbs.Size = new System.Drawing.Size(198, 154);
            this.listAlbs.TabIndex = 3;
            // 
            // listSongs
            // 
            this.listSongs.Dock = System.Windows.Forms.DockStyle.Top;
            this.listSongs.FormattingEnabled = true;
            this.listSongs.ItemHeight = 15;
            this.listSongs.Location = new System.Drawing.Point(0, 23);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(198, 274);
            this.listSongs.TabIndex = 2;
            // 
            // btRld
            // 
            this.btRld.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btRld.Location = new System.Drawing.Point(0, 483);
            this.btRld.Name = "btRld";
            this.btRld.Size = new System.Drawing.Size(198, 23);
            this.btRld.TabIndex = 1;
            this.btRld.Text = "Reload Albums";
            this.btRld.UseVisualStyleBackColor = true;
            this.btRld.Click += new System.EventHandler(this.btRld_Click);
            // 
            // btBrowse
            // 
            this.btBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btBrowse.Location = new System.Drawing.Point(0, 0);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(198, 23);
            this.btBrowse.TabIndex = 0;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // songName
            // 
            this.songName.AutoSize = true;
            this.songName.Location = new System.Drawing.Point(317, 300);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(0, 15);
            this.songName.TabIndex = 6;
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(363, 448);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 5;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // pictureSong
            // 
            this.pictureSong.Image = ((System.Drawing.Image)(resources.GetObject("pictureSong.Image")));
            this.pictureSong.Location = new System.Drawing.Point(282, 141);
            this.pictureSong.Name = "pictureSong";
            this.pictureSong.Size = new System.Drawing.Size(156, 156);
            this.pictureSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSong.TabIndex = 4;
            this.pictureSong.TabStop = false;
            this.pictureSong.Click += new System.EventHandler(this.pictureSong_Click);
            // 
            // btToAlbs
            // 
            this.btToAlbs.Location = new System.Drawing.Point(614, 12);
            this.btToAlbs.Name = "btToAlbs";
            this.btToAlbs.Size = new System.Drawing.Size(75, 23);
            this.btToAlbs.TabIndex = 3;
            this.btToAlbs.Text = "Albums";
            this.btToAlbs.UseVisualStyleBackColor = true;
            this.btToAlbs.Click += new System.EventHandler(this.btToAlbs_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(444, 448);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 2;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btPrev
            // 
            this.btPrev.Location = new System.Drawing.Point(201, 448);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(75, 23);
            this.btPrev.TabIndex = 1;
            this.btPrev.Text = "Previous";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // btPlay
            // 
            this.btPlay.Location = new System.Drawing.Point(282, 448);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(75, 23);
            this.btPlay.TabIndex = 0;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 506);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Music";
            this.Text = "Music";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listAlbs;
        private System.Windows.Forms.ListBox listSongs;
        private System.Windows.Forms.Button btRld;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btToAlbs;
        private System.Windows.Forms.PictureBox pictureSong;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Label songName;
    }
}

