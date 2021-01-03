using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AudioPlayer
{
    public partial class RenameSongLabel : Form
    {

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public RenameSongLabel()
        {
            InitializeComponent();
            this.newSongNameBox.Text = Main.instance.msPlayer.enumerator.Current.name;
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
        /// Click exit button handler
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Apply button handler
        /// </summary>
        private void applyButton_Click(object sender, EventArgs e)
        {

            if (this.newSongNameBox.Text != "")
            {
                Main.instance.msPlayer.removeSong(Main.instance.msPlayer.enumerator.Current);
                Main.instance.msPlayer.enumerator.Current.name = this.newSongNameBox.Text;
                Main.instance.msPlayer.addSong(Main.instance.msPlayer.enumerator.Current);

                Main.instance.msPlayer.enumerator.Current.panel.label.Text = this.newSongNameBox.Text;
                Main.instance.updateTrackName();

            }

            this.Close();
        }
    }
}
