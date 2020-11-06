using System;
using LanguageLibrary;

namespace LanguageTeacher
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                PrintInfo();
                return;
            }

            var inputArray = ArgsToLower(args);
            switch (inputArray[0])
            {
                case "-lists":
                    ListCommand();
                    break;
                case "-new":
                    NewCommand(inputArray);
                    break;
                case "-add":
                    if (inputArray.Length > 1)
                    {
                        AddCommand(inputArray[1]);
                    }
                    else
                    {
                        Console.WriteLine("that list does not exist");
                        Console.WriteLine();
                        PrintInfo();
                    }

                    break;
                case "-remove":
                    RemoveCommand(inputArray);
                    break;
                case "-words":
                    WordsCommand(inputArray);
                    break;
                case "-count":
                    if (inputArray.Length > 1)
                    {
                        CountCommand(inputArray[1]);
                    }
                    else
                    {
                        Console.WriteLine("that list does not exist");
                        Console.WriteLine();
                        PrintInfo();
                    }
                    break;
                case "-practice":
                    if (inputArray.Length > 1)
                    {
                        PracticeCommand(inputArray[1]);
                    }
                    else
                    {
                        Console.WriteLine("that list does not exist");
                        Console.WriteLine();
                        PrintInfo();
                    }
                    break;
            }
        }

        private static void PracticeCommand(string name)
        {


            var wordList = WordList.LoadList(name);
            if (wordList == null)
            {
                Console.WriteLine("That is not a valid list on your computer.");
                return;
            }

            if (wordList.Count() == 0)
            {
                Console.WriteLine("The selected list is empty, you cant practice with an empty list");
                return;
            }

            var languageArray = wordList.Languages;
            var points = 0;
            var tries = 0;
            while (true)
            {
                var practiceWord = wordList.GetWordToPractice();
                Console.WriteLine(
                    $"Here is the {languageArray[practiceWord.FromLanguage]} word {practiceWord.Translations[practiceWord.FromLanguage]}");
                Console.WriteLine(
                    $"Do you know the {languageArray[practiceWord.ToLanguage]} translation?");
                var input = Console.ReadLine().ToLower();
                if (input == practiceWord.Translations[practiceWord.ToLanguage].ToLower())
                {
                    Console.WriteLine("Good job that is the correct answer");
                    points++;
                    tries++;
                }
                else if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Sorry that is not the correct answer");
                    tries++;
                }

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($"You got {points} right answers out of {tries}");
                    break;
                }
            }

        }
        private static void CountCommand(string name)
        {
            var wordList = WordList.LoadList(name);
            if (wordList == null)
            {
                Console.WriteLine("That is not a valid list on your computer.");
                return;
            }

            Console.WriteLine($"There are {wordList.Count()} words in the list");
        }

        private static void WordsCommand(string[] args)
        {
            var name = args[1];
            var wordList = WordList.LoadList(name);
            if (wordList == null)
            {
                Console.WriteLine("That is not a valid list on your computer.");
                return;
            }
            
            var languageArray = wordList.Languages;
            var sortBy = GetLanguageIndex(args, languageArray);

            foreach (var languages in languageArray)
            {
                Console.Write(languages.PadLeft(20).ToUpper());
            }
                
            Console.WriteLine();
            wordList.List(sortBy, x =>
            {
                foreach (var t in x)
                {
                    Console.Write(t.PadLeft(20));
                }

                Console.WriteLine();
            });
        }

        private static int GetLanguageIndex(string[] args, string[] languageArray)
        {
            if (args.Length < 3) return 0;
            
            for (var i = 0; i < languageArray.Length; i++)
            {
                if (args[2] == languageArray[i])
                {
                    return i;
                }
            }

            return 0;
        }

        private static void RemoveCommand(string[] args)
        {
            var name = args[1];
            var wordList = WordList.LoadList(name);
            
            if (wordList == null)
            {
                Console.WriteLine("That is not a valid list on your computer.");
                return;
            }
            
            var language = GetLanguageIndex(args,wordList.Languages);

            for (var i = 3; i < args.Length; i++)
            {             
                Console.WriteLine();
                var wasRemoved = wordList.Remove(language, args[i]);
                Console.WriteLine(wasRemoved
                    ? $"The {wordList.Languages[language]} word {args[i]} was removed"
                    : "No Word were removed");
            }
        }

        private static void AddCommand(string name)
        {
            var wordList = WordList.LoadList(name);

            if (wordList == null)
            {
                Console.WriteLine("That is not a valid list on your computer.");
                return;
            }

            AddWords(name, wordList.Languages);
        }

        private static void NewCommand(string[] args)
        {
            var name = args[1];
            if (args.Length < 4)
            {
                Console.WriteLine($"You need to add at least 2 languages you added {args.Length - 2} languages");
                return;
            }

            var languageArray = new string[args.Length - 2];
            for (var i = 2; i < args.Length; i++) languageArray[i - 2] = args[i];
            var wordlist = new WordList(name, languageArray);
            wordlist.Save();
            AddWords(name, languageArray);
        }

        private static void PrintInfo()
        {
            Console.WriteLine("Use any of the following parameters: ");
            Console.WriteLine("-lists");
            Console.WriteLine("-new <list name> <language 1> <language 2> .. <language n>");
            Console.WriteLine("-add <list name>");
            Console.WriteLine("-remove <list name > <language> <word1> <word2>... ");
            Console.WriteLine("-words <listname> <sortByLanguage>");
            Console.WriteLine("-count <listname>");
            Console.WriteLine("-practice <listname>");
        }

        private static void ListCommand()
        {
            var files = WordList.GetLists();
            if (files.Length > 1)
            {
                foreach (var file in files)
                    if (WordList.LoadList(file) != null)
                        Console.WriteLine(file);
            }
            else
            {
                Console.WriteLine("you dont have any lists make a list and then you can see it.");
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

        private static string[] ArgsToLower(string[] args)
        {
            var userInput = args;
            for (var i = 0; i < args.Length; i++) userInput[i] = args[i].ToLower();
            return userInput;
        }
    }
}