using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoraokeEditer
{
    class EditerFileManager
    {
        public static string nowMp3Path{get;set;} = null;

        public static string getfileFolder(string path)
        {
            string[] pathArray = path.Split('\\');
            int length = pathArray.Length;

            string folderPath = null;
            for(int i = 0; i<length-1; i++)
            {
               folderPath += pathArray[i]+"\\";
            }
            return folderPath;
        }

        public static string GetFileName(string path)

        {
            string[] pathArray = path.Split('\\');
            int length = pathArray.Length;

            string[] fileArray = pathArray[length - 1].Split('.');
            return fileArray[0];
        }

    }
}
