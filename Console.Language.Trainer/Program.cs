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
                Console.WriteLine("Use any of the following parameters: ");
                Console.WriteLine("-lists");
                Console.WriteLine("-new <list name> <language 1> <language 2> .. <language n>");
                Console.WriteLine("-add <list name>");
                Console.WriteLine("-remove <list name > <language> <word1> <word2>... ");
                Console.WriteLine("-words <listname> <sortByLanguage>");
                Console.WriteLine("-count <listname>");
                Console.WriteLine("-practice <listname>");
            }

            else
            {
                switch (argsToLower(args)[0])
                {
                    case "-lists":
                        var files = WordList.GetLists();
                        foreach (var file in files)
                            if (WordList.LoadList(file) != null)
                                Console.WriteLine(file);
                        break;
                    case "-new":

                        var name = args[1];
                        if (args.Length < 4)
                        {
                            Console.WriteLine($"You need to add at least 2 languages you added {args.Length - 2} languages");
                            break;
                        }

                        var languageArray = new string[args.Length - 2];
                        for (var i = 2; i < args.Length; i++) languageArray[i - 2] = args[i];
                        var wordlist = new WordList(name, languageArray);
                        wordlist.Save();
                        AddWords(name, languageArray);
                        break;
                    case "-add":
                        name = args[1];
                        AddWords(name, WordList.LoadList(name).Languages);
                        break;
                    case "-remove":
                        var language = 0;
                        WordList.LoadList(args[1]);
                        for (var i = 0; i < WordList.LoadList(args[1]).Languages.Length; i++)
                        {
                            if (args[2] != WordList.LoadList(args[1]).Languages[i]) continue;
                            language = i;
                        }

                        for (var i = 3; i < args.Length; i++)
                        {
                            WordList.LoadList(args[1]).Remove(language, args[i]);
                            Console.WriteLine();
                             var wasRemoved = WordList.LoadList(args[1]).Remove(language, args[i]);
                            Console.WriteLine(wasRemoved
                                ? $"The {WordList.LoadList(args[1]).Languages[language]} word {args[i]} was removed"
                                : "No Word were removed");                            
                        }
                        break;
                    case "-words":
                        var sortBy = 0;
                        languageArray = WordList.LoadList(args[1]).Languages;
                        if (args.Length > 2)
                        {
                            for (var i = 0; i < languageArray.Length; i++)
                                if (args.Length > 1 && args[2] == languageArray[i])
                                    sortBy = i;
                        }
                        
                        foreach (var languages in languageArray) Console.Write(languages.PadLeft(20).ToUpper());
                        Console.WriteLine();
                        WordList.LoadList(args[1]).List(sortBy, x =>
                        {
                            foreach (var t in x) Console.Write(t.PadLeft(20));

                            Console.WriteLine();
                        });

                        break;
                    case "-count":
                        name = args[1];
                        Console.WriteLine($"There are {WordList.LoadList(name).Count()} words in the list");
                        break;
                    case "-practice":
                        name = args[1];
                        if (WordList.LoadList(name) != null)
                        {
                            languageArray = WordList.LoadList(name).Languages;
                            wordlist = WordList.LoadList(name);
                            if (wordlist.Count() != 0)
                            {
                                var enterNotPressed = true;
                                var points = 0;
                                var tries = 0;
                                while (enterNotPressed)
                                {
                                    var practiceWord = wordlist.GetWordToPractice();
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

                                    if (!string.IsNullOrWhiteSpace(input)) continue;
                                    Console.WriteLine($"You got {points} right answers out of {tries}");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("The selected list is empty, you cant practice with an empty list");
                            }
                        }
                        else
                        {
                            Console.WriteLine("That is not a valid list on your computer.");
                        }
                        
                        break;
                }
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

        private static string[] argsToLower(string[] args)
        {
            var userInput = args;
            for (var i = 0; i < args.Length; i++) userInput[i] = args[i].ToLower();
            return userInput;
        }
    }
}