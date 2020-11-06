using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LanguageLibrary
{
    public class WordList
    {
        private static readonly char[] CharArray = {';'};

        private readonly List<Word> _words = new List<Word>();

        public WordList(string name, params string[] languages)
        {
            Name = name.ToLower();
            Languages = languages;
        }

        private string Name { get; }
        public string[] Languages { get; }

        public static string[] GetLists()
        {
            Folder.CreateFolder();
            var files = Directory.GetFiles(Folder.SpecificFolder)
                .Select(Path.GetFileNameWithoutExtension)
                .ToArray();
            return files;
        }

        public static WordList LoadList(string name)
        {
            Folder.CreateFolder();
            if (!File.Exists(Folder.GetFilePath(name.ToLower()))) return null;
            using var sr = new StreamReader(Folder.GetFilePath(name));
            var line1 = sr.ReadLine();
            if (line1 == null) return null;
            var languages = line1.ToLower().Split(CharArray, StringSplitOptions.RemoveEmptyEntries);
            var wordList = new WordList(name, languages);
            var line = "";
            while ((line = sr.ReadLine()) != null)
                wordList.Add(line.Split(CharArray, StringSplitOptions.RemoveEmptyEntries));
            sr.Close();

            return wordList;
        }

        public void Save()
        {
            LoadList(Name);
            var file = Folder.GetFilePath(Name);
            using var fs = File.Create(file);
            fs.Close();
            foreach (var t in Languages)
                if (!string.IsNullOrWhiteSpace(t))
                    File.AppendAllText(file, $"{t};");
            foreach (var t in _words)
            {
                {
                    File.AppendAllText(file, "\n");
                }
                for (var j = 0; j < Languages.Length; j++) File.AppendAllText(file, $"{t.Translations[j]};");
            }
        }

        public void Add(params string[] translations1)
        {
            if (translations1.Length != Languages.Length) throw new ArgumentException();
            _words.Add(new Word(translations1));
        }

        public bool Remove(int translations, string word)
        {
            if (_words.All(i => i.Translations[translations] != word.ToLower()))
            {
                return false;
            }
            
            var removeAtIndex = _words.IndexOf(_words.First(i => i.Translations[translations] == word.ToLower()));          
            _words.RemoveAt(removeAtIndex);
            Save();
            return true;
            
        }

        public int Count()
        {
            return _words.Count;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            var sortedTranslations = _words.OrderBy(x => x.Translations[sortByTranslation]).ToArray();


            LoadList(Name);
            foreach (var translation in sortedTranslations) showTranslations(translation.Translations);
        }

        public Word
            GetWordToPractice()
        {
            var rnd = new Random();
            var randomWord = rnd.Next(_words.Count);
            var fromLanguage = rnd.Next(Languages.Length);
            var toLanguage = rnd.Next(Languages.Length);
            while (toLanguage == fromLanguage) toLanguage = rnd.Next(Languages.Length);

            return new Word(fromLanguage,
                toLanguage, _words[randomWord].Translations);
        }
    }
}