using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace FileControllers.Controllers
{
    static class FileController
    {
        private static AssetManager assets = Android.App.Application.Context.Assets;

        public static string FileToString(string path)
        {
            string content;
            using (StreamReader sr = new StreamReader(assets.Open(path)))
            {
                content = sr.ReadToEnd();
            }
            return content;
        }

        public static Stream FileToStream(string path)
        {
            return assets.Open(path);
        }

        public static void FileToJson()
        {
            JsonConvert.DeserializeObject("");
        }
    }
}
