using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AudioPlayer
{
    public partial class addSongLabel : Form
    {

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public addSongLabel()
        {
            InitializeComponent();
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

        private void panelDrag(object sender, DragEventArgs e)
        {
            foreach(string fileName in (string[])e.Data.GetData(DataFormats.FileDrop, false))
            {

            }
        }

        /// <summary>
        /// Apply button handler
        /// </summary>
        private void applyButton_Click(object sender, EventArgs e)
        {

            if (this.importURLtextBox.Text != "")
            {

                Song song = new Song
                {
                    name = System.IO.Path.GetFileNameWithoutExtension(this.importURLtextBox.Text),
                    url = this.importURLtextBox.Text,
                };

                Main.instance.msPlayer.enumerator.addElement(song);
                Main.instance.addSong(song, true);
                Main.instance.msPlayer.addSong(song);
            }

            this.Close();
        }
    }
}
