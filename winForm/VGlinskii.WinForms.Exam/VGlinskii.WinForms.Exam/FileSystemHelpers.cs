using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGlinskii.WinForms.Exam
{
    internal class FileSystemHelpers
    {

        public static string[] picturesNamesArray = Directory.GetFiles(getLocalPathToPictures());

        private static string getLocalPathToPictures()
        {
            String sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = Path.Combine(sCurrentDirectory, @"..\..\kartinker_src");
            string picturesFolderpath = Path.GetFullPath(sFile);
            return picturesFolderpath;
        }

        public static int getRandomPictureIndex()
        {

            Random random = new Random();
            int index = random.Next(picturesNamesArray.Length);
            return index;
        }

        public static string getFileName(string path)
        {
            return Path.GetFileName(path);
        }

    }
}
