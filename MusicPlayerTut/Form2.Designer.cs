namespace MusicPlayerTut
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.btnSongImport = new System.Windows.Forms.Button();
            this.btnPlaySong = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.listBoxSongs.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxSongs.ForeColor = System.Drawing.SystemColors.Menu;
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 15;
            this.listBoxSongs.Location = new System.Drawing.Point(480, 0);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(188, 410);
            this.listBoxSongs.TabIndex = 1;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnSongImport
            // 
            this.btnSongImport.Location = new System.Drawing.Point(24, 60);
            this.btnSongImport.Name = "btnSongImport";
            this.btnSongImport.Size = new System.Drawing.Size(95, 28);
            this.btnSongImport.TabIndex = 2;
            this.btnSongImport.Text = "Import songs";
            this.btnSongImport.UseVisualStyleBackColor = true;
            this.btnSongImport.Click += new System.EventHandler(this.btnSongImport_Click);
            // 
            // btnPlaySong
            // 
            this.btnPlaySong.Location = new System.Drawing.Point(24, 382);
            this.btnPlaySong.Name = "btnPlaySong";
            this.btnPlaySong.Size = new System.Drawing.Size(95, 28);
            this.btnPlaySong.TabIndex = 3;
            this.btnPlaySong.Text = "Play";
            this.btnPlaySong.UseVisualStyleBackColor = true;
            this.btnPlaySong.Click += new System.EventHandler(this.btnPlaySong_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(379, 382);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(95, 28);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(199, 382);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(95, 28);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(142, 382);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(40, 28);
            this.btnPrev.TabIndex = 6;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(317, 382);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(31, 28);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(668, 410);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlaySong);
            this.Controls.Add(this.btnSongImport);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(684, 449);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private ListBox listBoxSongs;
        private Button btnSongImport;
        private Button btnPlaySong;
        private Button btnStop;
        private Button btnPause;
        private Button btnPrev;
        private Button btnNext;
    }
}