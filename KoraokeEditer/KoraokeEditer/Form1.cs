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
    public partial class Form1 : Form
    {
        Player pl;
        Thread progressThread;
        string lyricsPath;

        int nowLine = 0;
        int nowCharAt = 0;

        List<string> lyrics = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "mp3File(*.mp3)|*.mp3";
            open.Title = "plz select file";

            if(open.ShowDialog() == DialogResult.OK)
            {
                EditerFileManager.nowMp3Path = open.FileName;
                this.songTitle.Text = EditerFileManager.nowMp3Path;
                string lyricsFolder= EditerFileManager.getfileFolder(open.FileName);
                string filename = EditerFileManager.GetFileName(EditerFileManager.nowMp3Path);
                this.lyricsPath = lyricsFolder + filename+".txt";

                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(lyricsPath);
                while((line = file.ReadLine())!= null)
                {
                    lyrics.Add(line);
                }
                file.Close();

                   
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pl = new Player();
            pl.SetMp3Path(EditerFileManager.nowMp3Path);
            button1.Enabled = false;
            button2.Enabled = false;

            pl.Play();
            ThreadStart progressThreadStart = new ThreadStart(ProgressThreadFunc);
            progressThread = new Thread(progressThreadStart);
            progressThread.Start();
            progressBar1.Maximum = (int)pl.GetLength()/100;

            this.label1.Text = this.lyrics[0];
            this.label2.Text = this.lyrics[1];

        }


        void ProgressThreadFunc()
        {
            while (true)
            {
                this.Invoke(new Action(delegate ()
                {
                     
                    try
                    {
                        this.songTitle.Text = pl.GetPosition().ToString();
                        this.progressBar1.Value = (int)pl.GetPosition() / 100;
                    }
                    catch(ArgumentOutOfRangeException exception)
                    {
                        progressBar1.Value = (int)pl.GetLength() / 100;
                        pl.Stop();
                        button1.Enabled = true;
                        button2.Enabled = true;
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                char[] temp = lyrics[nowLine].ToCharArray();
                int tempLength = temp.Length;

                label2.Text = nowCharAt+"/"+tempLength.ToString();


                label3.Text = temp[nowCharAt].ToString();
                nowCharAt++;
                if(tempLength-1 < nowCharAt)
                {
                    nowLine++;
                    nowCharAt = 0;
                }
               
            }

        }

     
    }
}
