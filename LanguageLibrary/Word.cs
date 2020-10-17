namespace LanguageLibrary
{
    public class Word
    {
        public Word(params string[] translations) // initaliserar Translations med data som skickas in i translations
        {
            Translations = translations;
        }

        public Word(int fromLanguage, int toLanguage,
            params string[] translations) //som ovan fast sätter även fromLanguage och ToLanguage
        {
            Translations = translations;
            FromLanguage = fromLanguage;
            ToLanguage = toLanguage;
        }

        public string[] Translations { get; }


        public int
            FromLanguage { get; } //med from och to ANGER man för övningarna från/till vilket språk som ska översättas

        public int ToLanguage { get; }
    }
}