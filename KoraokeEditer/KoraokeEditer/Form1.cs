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
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pl = new Player();
            pl.SetMp3Path(EditerFileManager.nowMp3Path);
            pl.Play();
            ThreadStart progressThreadStart = new ThreadStart(Threadtest1);
            progressThread = new Thread(progressThreadStart);
            progressThread.Start();
            progressBar1.Maximum = (int)pl.GetLength()/100;
        }


        void Threadtest1()
        {
            while (true)
            {
                this.Invoke(new Action(delegate ()
                {
                        if (pl.GetLength() <= pl.GetPosition() - 80)
                     {
                        progressBar1.Value = (int)pl.GetLength() / 100;
                        progressThread.Abort();

                     }
               
                    this.songTitle.Text = pl.GetPosition().ToString();
                    this.progressBar1.Value = (int)pl.GetPosition() / 100;

                }));
                Thread.Sleep(500);
               
            }
        }
    }
}
