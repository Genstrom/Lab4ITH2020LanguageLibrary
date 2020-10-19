using System;
using System.IO;
using LanguageLibrary;

namespace LanguageTeacher
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            
            Console.WriteLine("Use any of the following parameters: ");
            Console.WriteLine("-lists");
            Console.WriteLine("-new <list name> <language 1> <language 2> .. <language n>");
            Console.WriteLine("-add <list name>");
            Console.WriteLine("-remove <list name > <language> <word1> <word2>... ");
            Console.WriteLine("-words <listname> <sortByLanguage>");
            Console.WriteLine("-count <listname>");
            Console.WriteLine("-practice <listname>");

            var inputArray = argsToLower(args);

            switch (inputArray[0])
            {
                case "-lists":
                    var files = WordList.GetLists();
                    foreach (var file in files) Console.WriteLine(file);
                    break;
                case "-new":

                    var name = inputArray[1];
                    var languageArray = new string[inputArray.Length - 1];
                    for (var i = 1; i < inputArray.Length; i++) languageArray[i - 1] = inputArray[i];
                    var filePath = Folder.GetFilePath(name);
                    var fs = File.Create(filePath);
                    fs.Close();
                    var wordlist = new WordList(name, languageArray);
                    wordlist.Save();
                    AddWords(name, languageArray);
                    break;
                case "-add":                  
                    name = inputArray[1];
                    AddWords(name, WordList.LoadList(name).Languages);
                    break;
                case "-remove":
                    var language = 0;
                    WordList.LoadList(inputArray[1]);
                    for (var i = 0; i < WordList.LoadList(inputArray[1]).Languages.Length; i++)
                    {
                        if (inputArray[2] != WordList.LoadList(inputArray[1]).Languages[i]) continue;
                        language = i;
                    }
                    for (var i = 3; i < inputArray.Length; i++)
                    {

                        WordList.LoadList(inputArray[1]).Remove(language, inputArray[i]);

                    }
                    Console.ReadLine();


                    break;
                case "-words":
                    var sortBy = 0;
                    languageArray = WordList.LoadList(inputArray[1]).Languages;
                    for (int i = 0; i < languageArray.Length; i++)
                    {
                        if (inputArray.Length > 1 && inputArray[2] == languageArray[i])
                        {
                            sortBy = i;
                        }
                    }

                    foreach (var languages in languageArray) Console.Write(languages.PadLeft(20).ToUpper());

                    Console.WriteLine();
                    WordList.LoadList(inputArray[1]).List(sortBy, x =>
                    {
                        foreach (var t in x) Console.Write(t.PadLeft(20));

                        Console.WriteLine();
                    });


                    break;
                case "-count":
                    name = inputArray[1];
                    Console.WriteLine($"There are {WordList.LoadList(name).Count()} words in the list");
                    break;
                case "-practice":
                    name = inputArray[1];
                    var rnd = new Random();
                    languageArray = WordList.LoadList(name).Languages;
                    wordlist = WordList.LoadList(name);
                    var enterNotPressed = true;
                    var points = 0;
                    while (enterNotPressed)
                    {
                        var practiceWord = wordlist.GetWordToPractice();
                        Console.WriteLine(
                            $"Here is the {languageArray[practiceWord.FromLanguage]} word {practiceWord.Translations[practiceWord.FromLanguage]}");
                        Console.WriteLine($"Do you know the {languageArray[practiceWord.ToLanguage]} translation?");
                        var input = Console.ReadLine().ToLower();
                        if (input == practiceWord.Translations[practiceWord.ToLanguage].ToLower())
                        {
                            Console.WriteLine("Good job that is the correct answer");
                            points++;
                        }


                        else if (!string.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine("Sorry that is not the correct answer");
                        }

                        if (string.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine($"You got {points} right answers");
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

        private static string[] argsToLower (string[] args)
        {
            var userInput = new string[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                userInput[i] = args[i].ToLower();
            }


            return userInput;
                

          }


    }
}