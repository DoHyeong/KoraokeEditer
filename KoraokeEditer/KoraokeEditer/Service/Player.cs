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

        public void SetMp3Path(string path)
        {
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



    }
}
