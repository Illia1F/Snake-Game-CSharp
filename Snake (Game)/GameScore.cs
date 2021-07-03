using System;
using System.IO;
using System.Text;

namespace Snake_Game_CSharp
{
    public class GameScore
    {
        private const string FileName = "info.dat";

        public int Value { get; set; }
        public int MaxValue
        {
            get
            {
                int actualMaxScore = Value;
                if (File.Exists(FileName)
                    && Int32.TryParse(Encoding.Unicode.GetString(File.ReadAllBytes(FileName)), out actualMaxScore))
                {
                    if (Value > actualMaxScore)
                    {
                        actualMaxScore = Value;
                    }
                }

                return actualMaxScore;
            }
        }

        public void Save()
        {
            int previousMaxScore = MaxValue;
            if (previousMaxScore <= Value)
                SaveScore();
        }

        private void SaveScore()
        {
            File.WriteAllBytes(FileName, Encoding.Unicode.GetBytes(Value.ToString()));
        }
    }
}
