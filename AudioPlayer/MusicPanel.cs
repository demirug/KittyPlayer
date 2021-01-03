using System;
using System.Drawing;
using System.Windows.Forms;

namespace AudioPlayer
{
    public class MusicPanel : Panel
    {

        public static readonly Image idle = Properties.Resources.Idle_Music, play = Properties.Resources.Start_Music, pause = Properties.Resources.Stop_Music;
        private static readonly Image not_selected = Properties.Resources.Not_Selected, selected = Properties.Resources.Selected;

        public Song song;
        public Label label;
        public Panel imagePanel;

        public MusicPanel(Song song, Point location)
        {
            this.song = song;
            this.Location = location;
            song.panel = this;
            this.init();
        }

        /// <summary>
        /// Load panel elements
        /// </summary>
        private void init()
        {

            this.BackColor = Color.Transparent;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.BackgroundImage = not_selected;

            this.Size = new Size(130, 40);

            this.imagePanel = new Panel();
            this.imagePanel.Size = new Size(40, 40);
            this.imagePanel.BackgroundImage = idle;
            this.imagePanel.BackgroundImageLayout = ImageLayout.Zoom;
            this.imagePanel.Cursor = Cursors.Hand;

            this.label = new Label();
            this.label.TextAlign = ContentAlignment.TopCenter;
            this.label.Font = new Font("Microsoft YaHei UI", 6, FontStyle.Regular);
            this.label.AutoSize = false;
            this.label.Size = new Size(84, 30);
            this.label.Location = new Point(43, 5);
            this.label.Text = this.song.name;

            this.Controls.Add(this.label);
            this.Controls.Add(this.imagePanel);


            this.MouseEnter += mouseEnter;
            this.label.MouseEnter += mouseEnter;
            this.imagePanel.MouseEnter += mouseEnter;


            this.MouseLeave += mouseLeave;

            this.label.MouseLeave += mouseLeave;
            this.label.DoubleClick += doubleClick;
            
            this.imagePanel.MouseLeave += mouseLeave;
            this.imagePanel.Click += onClick;
        }

        /// <summary>
        /// Panel label click handler
        /// </summary>
        private void doubleClick(object sender, EventArgs e)
        {
            new addSongLabel().Show();
        }

        /// <summary>
        /// Panel click handler
        /// </summary>
        /// <param name="sender">
        /// Image Panel object
        /// </param>
        private void onClick(object sender, EventArgs e)
        {
            if(Main.instance.msPlayer.enumerator.Current == this.song)
            {
                Main.instance.playButton_Click(null, null);
                Main.instance.msPlayer.enumerator.Current.panel.imagePanel.BackgroundImage = play;
                return;
            }

            if (Main.instance.msPlayer.enumerator.Current != null)
            {
                Main.instance.msPlayer.enumerator.Current.panel.imagePanel.BackgroundImage = idle;
            }

            while (Main.instance.msPlayer.enumerator.Current != this.song)
            {
                Main.instance.msPlayer.enumerator.MoveNext();
            }

            this.imagePanel.BackgroundImage = pause;
            
            Main.instance.msPlayer.Play();
            Main.instance.updateTrackName();
            Main.instance.setPlayButtonStatus();
        }


        /// <summary>
        /// Mouse position leave object position
        /// </summary>
        private void mouseLeave(object sender, EventArgs e)
        {
            //TODO Memory leak  FIX
            if (this.imagePanel.BackgroundImage != pause)
            {
                this.imagePanel.BackgroundImage = null;
                this.imagePanel.BackgroundImage = idle;
            }

            this.BackgroundImage = not_selected;

        }

        /// <summary>
        /// Mouse position enter to object position
        /// </summary>
        private void mouseEnter(object sender, EventArgs e)
        {

            if (this.imagePanel.BackgroundImage != pause)
            {
                this.imagePanel.BackgroundImage = null;
                this.imagePanel.BackgroundImage = play;
            }
            this.BackgroundImage = selected;
        }
    }
}
