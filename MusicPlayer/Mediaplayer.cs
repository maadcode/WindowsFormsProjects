namespace MusicPlayer;

public partial class Mediaplayer : Form
{
    private readonly string FolderMusic;
    private CancellationTokenSource cancellationTokenScrollTitle;
    private CancellationTokenSource cancellationTokenProgressSong;

    public Mediaplayer()
    {
        InitializeComponent();
        player.uiMode = "none";
        FolderMusic = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Songs");
        if(!Directory.Exists(FolderMusic))
            Directory.CreateDirectory(FolderMusic);
        fileSysWatcher.Path = FolderMusic;
        ResetProgressSong();
        RefreshSongs();
    }

    private void ResetProgressSong()
    {
        progressSong.RangeMax = 100;
        progressSong.Value = 0;
    }

    private void PlaySong(string name)
    {
        lblTitleSong.Text = name;
        player.URL = Path.Combine(FolderMusic, name);
        btnPlay.Image = Properties.Resources.pause;

        StartScrollTitle(name);
        StartProgressSong();
    }

    private void StopSong()
    {
        lblTitleSong.Text = "Ninguna canción reproduciendo";
        player.URL = string.Empty;
        btnPlay.Image = Properties.Resources.play;

        StopScrollTitle();
        StopProgressStatus();
        ResetProgressSong();
    }

    private void StartProgressSong()
    {
        cancellationTokenProgressSong = new CancellationTokenSource();
        var token = cancellationTokenProgressSong.Token;

        Task.Run(async () =>
        {
            progressSong.Value = 0;
            while (!token.IsCancellationRequested)
            {
                double duration = player.Ctlcontrols.currentItem.duration;
                double currentPosition = player.Ctlcontrols.currentPosition;
                if (duration > 0 && currentPosition >= 0 && currentPosition <= duration)
                {
                    progressSong.Invoke(() =>
                    {
                        progressSong.RangeMax = (int)duration;
                        progressSong.Value = (int)currentPosition;
                    });
                }
                await Task.Delay(1000);
            }
        }, token);
    }

    private void StartScrollTitle(string songTitle)
    {
        StopScrollTitle();
        cancellationTokenScrollTitle = new CancellationTokenSource();
        var token = cancellationTokenScrollTitle.Token;

        Task.Run(async () =>
        {
            while (!token.IsCancellationRequested)
            {
                for (int i = 0; i < songTitle.Length; i++)
                {
                    if (token.IsCancellationRequested)
                        break;

                    lblTitleSong.Invoke(() =>
                    {
                        lblTitleSong.Text = songTitle.Substring(i) + " " + songTitle.Substring(0, i);
                    });
                    await Task.Delay(200);
                }
            }
        }, token);
    }

    private void StopScrollTitle()
    {
        if (cancellationTokenScrollTitle != null)
        {
            cancellationTokenScrollTitle.Cancel();
            cancellationTokenScrollTitle.Dispose();
            cancellationTokenScrollTitle = null;
        }
    }

    private void StopProgressStatus()
    {
        if (cancellationTokenProgressSong != null)
        {
            cancellationTokenProgressSong.Cancel();
            cancellationTokenProgressSong.Dispose();
            cancellationTokenProgressSong = null;
        }
    }

    private void AddMusicFile(string filePath)
    {
        if (Path.GetExtension(filePath).Equals(".mp3", StringComparison.OrdinalIgnoreCase))
        {
            string fileName = Path.GetFileName(filePath);
            string destFile = Path.Combine(FolderMusic, fileName);
            if(!File.Exists(destFile))
                File.Copy(filePath, destFile, overwrite: true);
        }
    }

    private void RefreshSongs()
    {
        listSongs.Items.Clear();
        string[] list = Directory.GetFiles(FolderMusic, "*.mp3");
        foreach (string file in list)
        {
            var directories = file.Split('\\');
            var filename = directories.LastOrDefault();
            listSongs.Items.Add(filename + Environment.NewLine);
        }
    }

    private void btnAdjuntar_Click(object sender, EventArgs e)
    {
        try
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in ofd.FileNames)
                    AddMusicFile(filePath);
                
                RefreshSongs();
                if (listSongs.Items.Count > 0)
                    listSongs.SelectedIndex = 0;
            }
        }
        catch (Exception)
        {
            MessageBox.Show($"Ocurrió un error al agregar las canciones");
        }
    }

    private void listSongs_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            StopSong();

        if(listSongs.SelectedItem != null)
            PlaySong(listSongs.SelectedItem.ToString());
    }

    private void btnPlay_Click(object sender, EventArgs e)
    {
        if(listSongs.SelectedItem == null)
        {
            MessageBox.Show("No hay canción seleccionada");
            return;
        }

        if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
        {
            player.Ctlcontrols.pause();
            btnPlay.Image = Properties.Resources.play;
        }
        else if (player.playState == WMPLib.WMPPlayState.wmppsReady)
        {
            PlaySong(listSongs.SelectedItem.ToString());
        }
        else
        {
            player.Ctlcontrols.play();
            btnPlay.Image = Properties.Resources.pause;
        }
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
        player.Ctlcontrols?.stop();
        StopSong();
    }

    private void scrollVolumen_onValueChanged(object sender, int newValue)
    {
        player.settings.volume = newValue;
    }

    private void progressSong_onValueChanged(object sender, int newValue)
    {
        player.Ctlcontrols.currentPosition = newValue;
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        if (listSongs.SelectedIndex > 0)
            listSongs.SelectedIndex--;
        else
            MessageBox.Show("No hay canciones más arriba.");
    }

    private void btnSkip_Click(object sender, EventArgs e)
    {
        if (listSongs.SelectedIndex < listSongs.Items.Count - 1)
            listSongs.SelectedIndex++;
        else
            MessageBox.Show("No hay canciones más abajo.");
    }

    private void fileSysWatcher_Changed(object sender, FileSystemEventArgs e)
    {
        if (player.URL == e.FullPath)
        {
            StopSong();
            RefreshSongs();
            listSongs.SelectedIndex = -1;
        } else if (listSongs.Items.Contains(e.Name))
        {
            listSongs.Items.Remove(e.Name);
            listSongs.Items.Add(e.Name);
        }
    }

    private void fileSysWatcher_Created(object sender, FileSystemEventArgs e)
    {
        if (!listSongs.Items.Contains(e.Name))
            listSongs.Items.Add(e.Name);
    }

    private void fileSysWatcher_Deleted(object sender, FileSystemEventArgs e)
    {
        if(player.URL == e.FullPath)
        {
            StopSong();
            RefreshSongs();
            listSongs.SelectedIndex = -1;
        }
        else if (listSongs.Items.Contains(e.Name))
        {
            listSongs.Items.Remove(e.Name);
        }
    }
}