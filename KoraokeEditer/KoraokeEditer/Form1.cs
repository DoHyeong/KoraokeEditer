using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace KoraokeEditer
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        Player pl;
        Thread progressThread;
        string lyricsPath;

        int nowLine = 0;
        int nowCharAt = 0;

        bool endLyrics = false;

        List<string> lyrics = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Open_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }


        void ProgressThreadFunc()
        {
            while (true)
            {
                this.Invoke(new Action(delegate ()
                {

                    try
                    {
                        this.nowSongPosition.Text = pl.GetPosition().ToString();
                        int now = (int)pl.GetPosition() / 100;
                        this.progressBar1.Value = now;
                        this.progressNow.Text = now.ToString();
                    }
                    catch (ArgumentOutOfRangeException exception)
                    {
                        progressBar1.Value = (int)pl.GetLength() / 100;
                        pl.Stop();
                        BtnOpen.Enabled = true;
                        BtnPlay.Enabled = true;
                        progressThread.Abort();
                    }



                }));
                Thread.Sleep(500);

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            label1.Focus();

        }

        //string lineStratFormat = "<line number=\"{0}\">";
        //string lineEndFormat = "</line>";

        //string gasaStartFormat = "<gasa start=\"{0}\">{1}</gasa>";

        string gasaJson = "{{\"time\":\"{0}\", \"gasa\":\"{1}\"}}";


        string ibun = null;

        string xml = "[";

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space && endLyrics == false)
            {
                ibun = null;
                
               
                char[] temp = lyrics[nowLine].ToCharArray();
                int tempLength = temp.Length;

                if(nowCharAt == 0)
                {
                    // xml += String.Format(lineStratFormat, nowLine);
                    xml += "[";
                }else
                {
                    xml += ",";
                }


                label2.Text = nowCharAt+"/"+tempLength.ToString();

                try
                {
                    label3.Text = temp[nowCharAt].ToString();

                    ibun += temp[nowCharAt].ToString();

                    if ((tempLength - 1 > nowCharAt) && (temp[nowCharAt + 1] == ' ' || temp[nowCharAt + 1] == '!' || temp[nowCharAt + 1] == '~'))
                    {
                        ibun += temp[nowCharAt + 1];
                        nowCharAt++;
                    }
                    nowCharAt++;

                    // xml += String.Format(gasaStartFormat, pl.GetPosition(), ibun);
                    xml += String.Format(gasaJson, pl.GetPosition(), ibun);
                }
                catch(IndexOutOfRangeException exception)
                {
                    endLyrics = true;
                }

                if (tempLength-1 < nowCharAt)
                {
                    // xml += lineEndFormat;
                    xml += "]";
                    nowLine++;
                    nowCharAt = 0;

                    if (!(nowLine > lyrics.Count - 1))
                    {
                        xml += ",";
                    }

                }

                if (nowLine > lyrics.Count-1)
                {
                    xml += "]";
                    endLyrics = true;   
                }
               
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "mp3File(*.mp3)|*.mp3";
            open.Title = "plz select file";

            if (open.ShowDialog() == DialogResult.OK)
            {
                EditerFileManager.nowMp3Path = open.FileName;
                this.songTitle.Text = EditerFileManager.nowMp3Path;
                string lyricsFolder = EditerFileManager.getfileFolder(open.FileName);
                string filename = EditerFileManager.GetFileName(EditerFileManager.nowMp3Path);
                this.lyricsPath = lyricsFolder + filename + ".txt";

                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(lyricsPath);
                while ((line = file.ReadLine()) != null)
                {
                    lyrics.Add(line);
                }
                file.Close();


            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            pl = new Player();
            pl.SetMp3Path(EditerFileManager.nowMp3Path);
            BtnOpen.Enabled = false;
            BtnPlay.Enabled = false;

            pl.Play();
            ThreadStart progressThreadStart = new ThreadStart(ProgressThreadFunc);
            progressThread = new Thread(progressThreadStart);
            progressThread.Start();
            int max = (int)pl.GetLength() / 100;
            progressBar1.Maximum = max;
            this.progressMax.Text = max.ToString();


            this.label1.Text = this.lyrics[0];
            this.label2.Text = this.lyrics[1];
        }
    }
}
