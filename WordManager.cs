using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AltaWordle
{
    public class WordManager
    {
        public List<string> guessWords;
        public string percorso;

        public WordManager ()
        {
            guessWords = new List<string>();
            percorso = "";
        }

        public int LoadWords(string language)
        {
            if (language == "Italiano (IT)")
            {
                guessWords = new List<string>(File.ReadAllLines("WordList/guess_words.txt"));
                percorso = "WordList/valid_words.txt";
                return 1;
            }
            else if (language == "Inglese (EN)")
            {
                guessWords = new List<string>(File.ReadAllLines("WordList/guess_words_EN.txt"));
                percorso = "WordList/valid_words_EN.txt";
                return 2;
            }
            else if (language == "Francese (FR)")
            {
                guessWords = new List<string>(File.ReadAllLines("WordList/guess_words_FR.txt"));
                percorso = "WordList/valid_words_FR.txt";
                return 3;
            }
            return 0;
        }

        public string GetGuessWord()
        {
            if (guessWords.Count == 0)
            {
                return "PROVA";
            }
            Random random = new Random();
            int indice = random.Next(0, guessWords.Count);
            return guessWords[indice].ToUpper();
        }
    }
}
