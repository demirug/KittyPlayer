using System;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AudioPlayer
{
    public partial class Main : Form
    {

        public static Main instance;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public MusicPlayer msPlayer;

        public Main()
        {
            instance = this;
            InitializeComponent();
            
            this.msPlayer = new MusicPlayer(this);
            this.msPlayer.initSounds();

            this.volumeBar.ValueChanged += valueChangeEvent;

            if (!this.msPlayer.enumerator.isEmpty())
            {
                this.mainPanel.BackgroundImage = null;
            }
        }

        /// <summary>
        /// Update current track name
        /// </summary>
        public void updateTrackName()
        {
            this.trackNameLabel.Text = this.msPlayer.enumerator.Current.name;
        }

        /// <summary>
        /// Volume bar changed value
        /// </summary>
        private void valueChangeEvent(object sender, EventArgs e)
        {
            TrackBar bar = sender as TrackBar;
            this.msPlayer.setVolume(bar.Value);
        }

        //private void panel_DragEnter(object sender, DragEventArgs e)
        //{

        //    if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
        //    {
        //        e.Effect = DragDropEffects.All;
        //    }

        //}
        //private void panel_DragDrop(object sender, DragEventArgs e)
        //{
        //    foreach (string file in (string[])e.Data.GetData(DataFormats.FileDrop, false))
        //    {
        //        Song song = new Song
        //        {
        //            name = System.IO.Path.GetFileNameWithoutExtension(file),
        //            url = file,
        //        };

        //        this.msPlayer.enumerator.addElement(song);
        //        this.addSong(song, true);
        //        this.msPlayer.addSong(song);
        //    }
        //}


        /// <summary>
        /// Next audio button click handler
        /// </summary>
        public void nextButton_Click(object sender, EventArgs e)
        {
            if (this.msPlayer.enumerator.getCount() <= 1) return;

            if(this.msPlayer.enumerator.Current != null)
            {
                this.msPlayer.enumerator.Current.panel.imagePanel.BackgroundImage = MusicPanel.idle;
            }

            this.msPlayer.enumerator.MoveNext();
            this.updateTrackName();

            if (this.msPlayer.isPlaying)
            {
                this.msPlayer.Stop();
                this.msPlayer.Play();
            }
        }

        /// <summary>
        /// Previos audio button click handler
        /// </summary>
        public void previosButton_Click(object sender, EventArgs e)
        {
            if (this.msPlayer.enumerator.getCount() <= 1) return;

            if (this.msPlayer.enumerator.Current != null)
            {
                this.msPlayer.enumerator.Current.panel.imagePanel.BackgroundImage = MusicPanel.idle;
            }

            this.msPlayer.enumerator.MovePrevious();
            this.updateTrackName();
            if (this.msPlayer.isPlaying)
            {
                this.msPlayer.Stop();
                this.msPlayer.Play();
            }
        }

        /// <summary>
        /// Add song to panel
        /// </summary>
        /// <param name="song">
        /// Song object witch will be added to panel
        /// </param>
        /// <param name="player">
        /// Is Song added by user or loaded by programm
        /// </param>
        public void addSong(Song song, bool player)
        {
            if (player)
            {
                VScrollProperties vScroll = this.mainPanel.VerticalScroll;
                vScroll.Value = 0;
            }

            this.mainPanel.Controls.Add(new MusicPanel(song, new Point(this.mainPanel.Controls.Count % 3 * 150, (this.mainPanel.Controls.Count / 3) * 50)));
            this.mainPanel.BackgroundImage = null;
        }

        /// <summary>
        /// Handler of window capture
        /// </summary>
        private void TabMoveCapture(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        /// <summary>
        /// Update Play/Pause button status
        /// </summary>
        public void setPlayButtonStatus()
        {
            if (this.msPlayer.isPlaying)
            {
                this.playButton.BackgroundImage = Properties.Resources.Stop;
            }
            else
            {
                if (this.msPlayer.Play())
                {
                    this.playButton.BackgroundImage = Properties.Resources.Play;
                }
            }
        }

        /// <summary>
        /// Handler play button click
        /// </summary>
        public void playButton_Click(object sender, EventArgs e)
        {
            if (this.msPlayer.enumerator.Current == null) return;

            if (this.msPlayer.isPlaying)
            {
                this.msPlayer.Stop();
                this.playButton.BackgroundImage = Properties.Resources.Play;
            }
            else
            {
                if (this.msPlayer.Play())
                {
                    this.playButton.BackgroundImage = Properties.Resources.Stop;
                }
            }
        }

        /// <summary>
        /// Availiable Hand cursor handler
        /// </summary>
        private void switchCursor_Enter(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (this.msPlayer.enumerator.getCount() <= 1) return;
            pictureBox.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Availiable Hand cursor handler
        /// </summary>
        private void switchCursor_Leave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Exit button click handler
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Minimize button click handler
        /// </summary>
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Add music button click handler
        /// </summary>
        private void addMusicButton_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Audio (*.mp3,*.acc,*wma)|*.acc;*.mp3;*.wma|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.Multiselect = true;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach(string filePath in openFileDialog.FileNames) {
                        Song song = new Song
                        {
                            name = System.IO.Path.GetFileNameWithoutExtension(filePath),
                            url = filePath,

                        };

                        this.msPlayer.enumerator.addElement(song);
                        this.addSong(song, true);
                        this.msPlayer.addSong(song);
                        }
                }
            }

        }


        /// <summary>
        /// Add radio button click handler
        /// </summary>
        private void addRadioButton_Click(object sender, EventArgs e)
        {
            new addSongLabel().ShowDialog();
        }

        /// <summary>
        /// Author name label click handler
        /// </summary>
        private void authorLabel_1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.demirug.dev");
        }

        /// <summary>
        /// Author name label click handler
        /// </summary>
        private void authorLabel_2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/anixmoonlight/");
        }


        private SoundPlayer effect_player = new System.Media.SoundPlayer(Properties.Resources.Varien_nyan);
       
        /// <summary>
        /// Programm logo click handler
        /// </summary>
        private void tabLogoPicture_Click(object sender, EventArgs e)
        {
            this.effect_player.Stop();
            this.effect_player.Play();
        }

        private void trackNameLabel_Click(object sender, EventArgs e)
        {
            if (this.msPlayer.enumerator.Current != null)
            {
                new RenameSongLabel().Show();
            }
        }

    }
}
