using System;
using System.IO;
using System.Text;

namespace Snake__Game_Logic
{
    internal static class SaveManager
    {
        private static string name = "Log.dat";

        public static int GetMaxScoreOutOfFile()
        {
            return File.Exists(name) && 
                Int32.TryParse(Encoding.Unicode.GetString(File.ReadAllBytes(name)), out int max) 
                ? max : 0;
        }

        public static void SaveNewMaxScore()
        {
            File.WriteAllBytes(name, Encoding.Unicode.GetBytes(Snake.Score.ToString()));
        }
    }
}
