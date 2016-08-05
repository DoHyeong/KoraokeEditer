using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using NAudio.Wave;
namespace KoraokeEditer
{

    class Player
    {
        Mp3FileReader reader = null;
        WaveOut waveOut = new WaveOut();
        private string path;
        public void SetMp3Path(string path)
        {
            this.path = path;
            reader = new Mp3FileReader(path);
            waveOut.Init(reader);

        }

        public bool Play()
        {
            if(reader == null)  return false;
            waveOut.Init(reader);
            waveOut.Play();
            return true;
        }

        public void Stop()
        {
            waveOut.Stop();
        }

        public TimeSpan GetPlayTime()
        {
            return reader.CurrentTime;
           
        }

        public long GetPosition()
        {
            return waveOut.GetPosition();
        }

        public long GetLength()
        {
            return reader.Length;

        }

        public string GetSongName()

        {
            string[] pathArray = path.Split('\\');
            int length = pathArray.Length;

            string[] fileArray = pathArray[length - 1].Split('.');
            return fileArray[0];
        }



    }
}
