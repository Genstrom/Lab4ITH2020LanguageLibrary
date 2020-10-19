namespace LanguageLibrary
{
    public class Word
    {
        public Word(params string[] translations)
        {
            Translations = translations;
        }

        public Word(int fromLanguage, int toLanguage,
            params string[] translations)
        {
            Translations = translations;
            FromLanguage = fromLanguage;
            ToLanguage = toLanguage;
        }

        public string[] Translations { get; }


        public int FromLanguage { get; }

        public int ToLanguage { get; }
    }
}