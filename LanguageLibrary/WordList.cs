using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace LanguageLibrary
{
    public class WordList
    {
        private static readonly char[] CharArray = {';'};

        private readonly List<Word> _words = new List<Word>();

        private WordList(string name, params string[] languages)
        {
            Name = name.ToLower();
            Languages = languages;
        }

        public string Name { get; } //namnet på listan
        public string[] Languages { get; } //Språken i listan

        public static string[] GetLists()
        {
            var files = Directory.GetFiles(Folder.SpecificFolder)
                .Select(Path.GetFileNameWithoutExtension)
                .ToArray();
            return files;
        }

        public static WordList LoadList(string name)
        {
            if (!File.Exists(Folder.GetFilePath(name.ToLower())))
            {
                var file = Folder.GetFilePath(name);
                using var fs = File.Create(file);
                fs.Close();
            } 
            using var sr = new StreamReader(Folder.GetFilePath(name));
            var line1 = sr.ReadLine();
            if (line1 == null) return null;
             var languages = line1.Split(CharArray, StringSplitOptions.RemoveEmptyEntries);

            var wordList = new WordList(name, languages);
            var line="";
            while ((line = sr.ReadLine()) != null)
                wordList.Add(line.Split(CharArray, StringSplitOptions.RemoveEmptyEntries));
            sr.Close();
            
            return wordList;
        }

        public void Save() // sparar listan till en fil med samma namn som ARRAYEN och filändelse .dat
        {
            var file = Folder.GetFilePath(Name);
            using var fs = File.Create(file);
            fs.Close();
            LoadList(Name);
            foreach (var t in Languages)
            {
                File.AppendAllText(file, $"{t};");
            }
            foreach (var t in _words)
            {
                {
                    File.AppendAllText(file, "\n");
                }
                for (var j = 0; j < Languages.Length; j++)
                {
                    File.AppendAllText(file, $"{t.Translations[j]};");

                }
            }
        }

        public void Add(params string[] translations1) //Lägger till ord i en lista, Throw ArgumentException om det är fel antal translations. Om listan har 3 språk men man försöker lägga till 4a ord ska den whina.
        {
            if (translations1.Length != Languages.Length) throw new ArgumentException();
            
            _words.Add(new Word(translations1));
        }

        public bool Remove(int translations, string word) //translation motsvarar INDEX i Languages. Sök igenom språket och ta bort ordet.
            //Så man väljer språk med "translations" och sen matchar man ordet med de ord man skrivit och tar bort det
        {
            var removeAtIndex = 0;
            if (_words.Any(i => i.Translations[translations] == word)) 
            {
               removeAtIndex = _words.IndexOf(_words.First(i => i.Translations[translations] == word));

            }

            _words.RemoveAt(removeAtIndex);
            Save();
            return true;
        }

        public int Count() 
        {
            return _words.Count;

        }

        public void List(int sortByTranslation, Action<string[]> showTranslations) //sortByTranslation = är en int som representerar Vilket Språk i listan som ska sorteras efter.
            //showTranslation = är en delegate där man skickar in en METOD som är en "CallBack" som anropas för varje ord i listan. En callback är bara en metod som anropas tillbax//Man skickar in en metod här och då kommer den här listan sortera alla orden på ett valt språk och//loopa igenom orden och för varje ord så anropar den den metod som vi valt
        {
            // Ni kommer behöva skicka in olika metoder. I consol appen kommer ni förmodligen skicka in en Console.WriteLine
            // Medans in winforms appen kommer ni behöva skicka in en annan metod. Som printar ut på de sättet som behövs i winforms
            
            var sortedTranslations = _words.OrderBy(x => x.Translations[sortByTranslation]).ToArray();
                

            LoadList(Name);
            foreach (var translation in sortedTranslations)
            {
                showTranslations(translation.Translations);
            }


        }

        public Word
            GetWordToPractice() // returnerar ett random ord från listan med RANDOM FRÅN SPRÅK och random TILL SPRÅK DOCK SJÄLVKLART INTE SAMMA SPRÅK.
        {
            
            var rnd = new Random();
            var randomWord = rnd.Next(_words.Count);
            var fromLanguage = rnd.Next(Languages.Length);
            var toLanguage = rnd.Next(Languages.Length);
            while (toLanguage == fromLanguage)
            {
                toLanguage = rnd.Next(Languages.Length);
            }
            var word = new Word( rnd.Next(Languages.Length),
                rnd.Next(Languages.Length), _words[randomWord].Translations);
            return word;

        }
    }
}