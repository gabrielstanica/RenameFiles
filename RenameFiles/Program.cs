using System;
using System.IO;

namespace RenameFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\gastanica\Desktop\OCR_Chris";
            var namePattern = "TestImage";
            int count = 0;

            var filesInDir = Directory.GetFiles(path);
            foreach(var file in filesInDir)
            {
                FileInfo files = new FileInfo(file);
                files.Rename(String.Format("{0}{1}.png",namePattern,count));
                count++;
            }
        }

    }
    public static class Extension
    {
        public static void Rename(this FileInfo fileInfo, string newName)
        {
            fileInfo.MoveTo(fileInfo.Directory.FullName + "\\" + newName);
        }
    }
}
