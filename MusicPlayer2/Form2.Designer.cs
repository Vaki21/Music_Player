
namespace MusicPlayer2
{
    partial class Form2
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
            this.listCreatedAlbs = new System.Windows.Forms.ListBox();
            this.checkedListSongs = new System.Windows.Forms.CheckedListBox();
            this.textAlbName = new System.Windows.Forms.TextBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btToSongs = new System.Windows.Forms.Button();
            this.btBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btRefresh = new System.Windows.Forms.Button();
            this.labelSongs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlaylistName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listCreatedAlbs
            // 
            this.listCreatedAlbs.FormattingEnabled = true;
            this.listCreatedAlbs.ItemHeight = 15;
            this.listCreatedAlbs.Location = new System.Drawing.Point(526, 95);
            this.listCreatedAlbs.Name = "listCreatedAlbs";
            this.listCreatedAlbs.Size = new System.Drawing.Size(197, 259);
            this.listCreatedAlbs.TabIndex = 0;
            // 
            // checkedListSongs
            // 
            this.checkedListSongs.FormattingEnabled = true;
            this.checkedListSongs.Location = new System.Drawing.Point(36, 95);
            this.checkedListSongs.Name = "checkedListSongs";
            this.checkedListSongs.Size = new System.Drawing.Size(460, 238);
            this.checkedListSongs.TabIndex = 1;
            // 
            // textAlbName
            // 
            this.textAlbName.Location = new System.Drawing.Point(162, 340);
            this.textAlbName.Name = "textAlbName";
            this.textAlbName.Size = new System.Drawing.Size(202, 23);
            this.textAlbName.TabIndex = 2;
            this.textAlbName.TextChanged += new System.EventHandler(this.textAlbName_TextChanged);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(162, 401);
            this.btCreate.Name = "btCreate";
            this.btCreate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btCreate.Size = new System.Drawing.Size(202, 23);
            this.btCreate.TabIndex = 3;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(526, 369);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(197, 23);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btToSongs
            // 
            this.btToSongs.Location = new System.Drawing.Point(811, 12);
            this.btToSongs.Name = "btToSongs";
            this.btToSongs.Size = new System.Drawing.Size(75, 23);
            this.btToSongs.TabIndex = 5;
            this.btToSongs.Text = "Songs";
            this.btToSongs.UseVisualStyleBackColor = true;
            this.btToSongs.Click += new System.EventHandler(this.btToSongs_Click);
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(162, 369);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btBrowse.Size = new System.Drawing.Size(202, 23);
            this.btBrowse.TabIndex = 6;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(526, 401);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(197, 23);
            this.btRefresh.TabIndex = 7;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // labelSongs
            // 
            this.labelSongs.AutoSize = true;
            this.labelSongs.Location = new System.Drawing.Point(36, 74);
            this.labelSongs.Name = "labelSongs";
            this.labelSongs.Size = new System.Drawing.Size(39, 15);
            this.labelSongs.TabIndex = 8;
            this.labelSongs.Text = "Songs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Your playlists";
            // 
            // labelPlaylistName
            // 
            this.labelPlaylistName.AutoSize = true;
            this.labelPlaylistName.Location = new System.Drawing.Point(79, 348);
            this.labelPlaylistName.Name = "labelPlaylistName";
            this.labelPlaylistName.Size = new System.Drawing.Size(80, 15);
            this.labelPlaylistName.TabIndex = 10;
            this.labelPlaylistName.Text = "Playlist name:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 495);
            this.Controls.Add(this.labelPlaylistName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSongs);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.btToSongs);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.textAlbName);
            this.Controls.Add(this.checkedListSongs);
            this.Controls.Add(this.listCreatedAlbs);
            this.Name = "Form2";
            this.Text = "Albums";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCreatedAlbs;
        private System.Windows.Forms.CheckedListBox checkedListSongs;
        private System.Windows.Forms.TextBox textAlbName;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btToSongs;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Label labelSongs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPlaylistName;
    }
}