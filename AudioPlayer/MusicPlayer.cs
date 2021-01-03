using System;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using AudioPlayer;
using WMPLib;

public class MusicPlayer
{
    private Main main;
    private WindowsMediaPlayer wplayer;
    private XmlDocument document;
    public CircledDoubleEnumerator<Song> enumerator = new CircledDoubleEnumerator<Song>(null);

    private Timer timer = new Timer();

    public MusicPlayer(Main main)
    {
        this.main = main;
        this.wplayer = new WindowsMediaPlayer();
        this.wplayer.settings.autoStart = false;
        this.wplayer.PlayStateChange += stopHandler;
        this.document = new XmlDocument();
    }


    public bool isPlaying { get; private set; }

    /// <summary>
    /// Music audio ended handler for state event
    /// </summary>
    /// <param name="state">
    /// State code
    /// type <see cref="int"/> 
    /// Special for "state"
    /// </param>
    private void stopHandler(int state)
    {
        if (state == 8)
        {
            this.isPlaying = false;
            Main.instance.setPlayButtonStatus();
            this.enumerator.Current.panel.imagePanel.BackgroundImage = MusicPanel.idle;
        }
    }

    /// <summary>
    /// Change Audio volume
    /// </summary>
    /// <param name="volume">
    /// Volume varalible
    /// type <see cref="int"/> 
    /// Special for "volume"
    /// </param>
    public void setVolume(int volume)
    {
        this.wplayer.settings.volume = volume;
    }

    /// <summary>
    /// Disable audio playing
    /// </summary>
    /// <exception cref="Exception">
    /// If can't play Audio
    /// </exception>
    public bool Play()
    {
        if (this.enumerator.isEmpty()) return false;
        
        try
        {
            this.wplayer.URL = this.enumerator.Current.url;
            this.wplayer.controls.play();
            if (this.enumerator.Current != null)
            {
                this.enumerator.Current.panel.imagePanel.BackgroundImage = MusicPanel.pause;
            }
        }
        catch (Exception e)
        {
            MessageBox.Show("Error while trying play track\nException: " + e.Message, "WAV Audio Player | Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        this.isPlaying = true;
        return true;
    }

    /// <summary>
    /// Disable audio playing
    /// </summary>
    public void Stop()
    {
        if (!this.isPlaying) return;
        this.wplayer.controls.stop();
        this.enumerator.Current.panel.imagePanel.BackgroundImage = MusicPanel.idle;
        this.isPlaying = false;
    }


    /// <summary>
    /// Load sounds from "music.xml"
    /// </summary>
    /// <param name="secondTry">
    /// Is this second try to load Sounds.
    /// type <see cref="bool"/> 
    /// Special for "secondTry"
    /// </param>
    /// <exception cref="Exception">
    /// If error while reading "music.xml"
    /// </exception>
    public void initSounds(bool secondTry=false)
    {
        try
        {
            this.document.Load("music.xml");

            foreach (XmlNode item in this.document.DocumentElement.ChildNodes)
            {

                Song song = new Song() {
                    Xmlnode = item,
                    url = item.SelectNodes("url")[0].InnerText,
                    name = item.SelectNodes("name")[0].InnerText,
                };

                this.main.addSong(song, false);
                this.enumerator.addElement(song);
            }


        } catch(Exception)
        {
            XmlTextWriter xtr = new XmlTextWriter("music.xml", Encoding.Unicode);
            xtr.Formatting = Formatting.Indented;
            xtr.WriteStartDocument();
            xtr.WriteStartElement("Music");
            xtr.WriteEndDocument();
            xtr.Close();
            if(!secondTry)
                this.initSounds(true);

        }
    }

    /// <summary>
    /// Remove song from "music.xml"
    /// </summary>
    /// <param name="song">
    /// The song need be deleted from "music.xml"
    /// type <see cref="Song"/> 
    /// Special for "song"
    /// </param>
    public void removeSong(Song song)
    {
        if (song.Xmlnode == null) return;
        XmlNode root = this.document.DocumentElement;
        root.RemoveChild(song.Xmlnode);
        this.document.Save("music.xml");
    }

    /// <summary>
    /// Add song to "music.xml"
    /// </summary>
    /// <param name="song">
    /// The song need be added to "music.xml"
    /// type <see cref="Song"/> 
    /// Special for "song"
    /// </param>
    public void addSong(Song song)
    {
        XmlNode root = this.document.DocumentElement;
        XmlNode songNode = this.document.CreateElement("Song");

        XmlNode url = this.document.CreateElement("url");
        XmlNode name = this.document.CreateElement("name");

        url.AppendChild(this.document.CreateTextNode(song.url));
        name.AppendChild(this.document.CreateTextNode(song.name));

        songNode.AppendChild(url);
        songNode.AppendChild(name);

        root.AppendChild(songNode);

        song.Xmlnode = songNode;

        this.document.Save("music.xml");

    }

}