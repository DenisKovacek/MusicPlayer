namespace MusicPlaylist
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.btnSelectSongs = new System.Windows.Forms.Button();
            this.winMusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelFooter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.winMusicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 16;
            this.listBoxSongs.Location = new System.Drawing.Point(382, 8);
            this.listBoxSongs.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(145, 228);
            this.listBoxSongs.TabIndex = 0;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // btnSelectSongs
            // 
            this.btnSelectSongs.BackColor = System.Drawing.Color.DarkRed;
            this.btnSelectSongs.ForeColor = System.Drawing.Color.White;
            this.btnSelectSongs.Location = new System.Drawing.Point(382, 242);
            this.btnSelectSongs.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectSongs.Name = "btnSelectSongs";
            this.btnSelectSongs.Size = new System.Drawing.Size(145, 27);
            this.btnSelectSongs.TabIndex = 1;
            this.btnSelectSongs.Text = "Choose a song(s) to play";
            this.btnSelectSongs.UseVisualStyleBackColor = false;
            this.btnSelectSongs.Click += new System.EventHandler(this.btnSelectSongs_Click);
            // 
            // winMusicPlayer
            // 
            this.winMusicPlayer.Enabled = true;
            this.winMusicPlayer.Location = new System.Drawing.Point(12, 8);
            this.winMusicPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.winMusicPlayer.Name = "winMusicPlayer";
            this.winMusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("winMusicPlayer.OcxState")));
            this.winMusicPlayer.Size = new System.Drawing.Size(350, 261);
            this.winMusicPlayer.TabIndex = 2;
            // 
            // labelFooter
            // 
            this.labelFooter.AutoSize = true;
            this.labelFooter.ForeColor = System.Drawing.Color.DimGray;
            this.labelFooter.Location = new System.Drawing.Point(229, 274);
            this.labelFooter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(90, 13);
            this.labelFooter.TabIndex = 3;
            this.labelFooter.Text = "Developed by me";
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 507);
            this.Controls.Add(this.labelFooter);
            this.Controls.Add(this.winMusicPlayer);
            this.Controls.Add(this.btnSelectSongs);
            this.Controls.Add(this.listBoxSongs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MusicPlayer";
            this.Text = "Music Player";
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.winMusicPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Button btnSelectSongs;
        private AxWMPLib.AxWindowsMediaPlayer winMusicPlayer;
        private System.Windows.Forms.Label labelFooter;
    }
}

