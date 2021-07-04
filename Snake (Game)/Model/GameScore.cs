using System;
using System.IO;
using System.Text;

namespace Snake_Game_CSharp
{
    public class GameScore
    {
        private const string FileName = "info.dat";
        private int _value;

        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                ScoreChanged?.Invoke(this, _value);
            }
        }
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

        public event EventHandler<int> ScoreChanged;

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
