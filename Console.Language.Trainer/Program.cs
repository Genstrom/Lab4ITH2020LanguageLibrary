using System;
using System.Collections.Generic;
using System.IO;
using LanguageLibrary;

namespace LanguageTeacher
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Folder.CreateFolder();
            Console.WriteLine("Use any of the following parameters: ");
            Console.WriteLine("-lists");
            Console.WriteLine("-new <list name> <language 1> <language 2> .. <language n>");
            Console.WriteLine("-add <list name>");
            Console.WriteLine("-remove <list name > <language> <word1> <word2>... ");
            Console.WriteLine("-words");
            Console.WriteLine("-count");
            Console.WriteLine("-practice");


            var userInput = Console.ReadLine().ToLower();

           
            switch (userInput)
            {
                case "-lists":
                    var files = WordList.GetLists();
                    foreach (var file in files) Console.WriteLine(file);
                    break;
                case "-new":
                    Console.WriteLine("Write the name of the list and the languages used in the list");
                    var read = Console.ReadLine().ToLower().Split(' ');
                    var name = read[0];
                    var languageArray = new string[read.Length - 1];
                    for (var i = 1; i < read.Length; i++) languageArray[i - 1] = read[i];
                    var filePath = Folder.GetFilePath(name);
                    var fs = File.Create(filePath);
                    fs.Close();
                    var wordlist = new WordList(name, languageArray);
                    wordlist.Save();
                    AddWords(name, languageArray);
                    break;
                case "-add":
                    Console.WriteLine("Write the name of the list you want to add files too");
                    name = Console.ReadLine().ToLower();
                    AddWords(name, WordList.LoadList(name).Languages);
                    break;
                case "-remove":
                    read = Console.ReadLine().ToLower().Split(' ');
                    var language = 0;
                    WordList.LoadList(read[0]);
                    for (var i = 0; i < WordList.LoadList(read[0]).Languages.Length; i++)
                    {
                        if (read[1] != WordList.LoadList(read[0]).Languages[i]) continue;
                        language = i;
                        WordList.LoadList(read[0]).Remove(language, read[2]);

                    }



                    break;
                case "-words":
                    var langugae = 0;
                    Console.WriteLine("Write the name of the list you want to print.");
                    Console.WriteLine(
                        "If you want to sort the words by a certain language please write the language after the name");
                    read = Console.ReadLine().ToLower().Split(' ');
                    var sortBy = 0;

                    languageArray = WordList.LoadList(read[0]).Languages;

                    foreach (var languages in languageArray)
                    {
                        Console.Write(languages.PadLeft(20).ToUpper());
                    }

                    Console.WriteLine();
                    WordList.LoadList(read[0]).List(sortBy, x =>
                    {
                        foreach (var t in x)
                        {
                            Console.Write(t.PadLeft(20));
                        }

                        Console.WriteLine();
                    });



                    break;
                case "-count":
                    Console.WriteLine("Write the name of the list you want the count of words from");
                    name = Console.ReadLine().ToLower();
                    Console.WriteLine(WordList.LoadList(name).Count());
                    break;
                case "-practice":
                    name = Console.ReadLine().ToLower();
                    var rnd = new Random();
                    languageArray = WordList.LoadList(name).Languages;
                    wordlist = WordList.LoadList(name);
                    Word practiceWord = wordlist.GetWordToPractice();
                    var enterNotPressed = true;
                    while (enterNotPressed)
                    {
                        Console.WriteLine(
                            $"Here is the {languageArray[practiceWord.FromLanguage]} word {practiceWord.Translations[practiceWord.FromLanguage]}");
                        Console.WriteLine($"Do you know the {languageArray[practiceWord.ToLanguage]} translation?");
                        var input = Console.ReadLine().ToLower();
                        if (input == practiceWord.Translations[practiceWord.ToLanguage].ToLower())
                        {
                            Console.WriteLine("Wow very impressive really");
                        }


                        if (string.IsNullOrWhiteSpace(input))
                        {
                            break;
                        }

                    }

                    break;
            }
        }

        private static void AddWords(string name, string[] languages)
        {
            Console.WriteLine("To stop adding words, input an empty string");
            var wordList = WordList.LoadList(name);
            var enterNotPressed = true;
            while (enterNotPressed)

            {
                var words = new string[languages.Length];
                for (var i = 0; i < languages.Length; i++)
                {
                    Console.WriteLine(i == 0
                        ? $"Please write the {languages[i]} word"
                        : $"Please write the {languages[i]} translation");
                    var input = Console.ReadLine().ToLower();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        wordList.Save();
                        enterNotPressed = false;
                        break;
                    }

                    words[i] = input;
                }

                if (enterNotPressed) wordList.Add(words);
            }
        }
    }
}