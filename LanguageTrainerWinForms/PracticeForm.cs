using System;
using System.Windows.Forms;
using LanguageLibrary;

namespace LanguageTrainerWinForms
{
    public partial class PracticeForm : Form
    {
        public PracticeForm(string listName)
        {
            InitializeComponent();
            ListName = listName;
        }

        public PracticeForm()
        {
            InitializeComponent();
        }

        public string ListName { get; }
        private Word WordForPractice { get; set; }
        public int Score { get; set; }
        public int Tries { get; set; }
        public int Fails { get; set; }

        private Word PracticeGenerator()
        {
            var _name = ListName;
            WordForPractice = WordList.LoadList(_name).GetWordToPractice();
            return WordForPractice;
        }

        private void PracticeForm_Load(object sender, EventArgs e)
        {
            PracticeGenerator();
            var _name = ListName;
            var languageArray = WordList.LoadList(_name).Languages;
            PracticeWordBox.Text =
                $"Here is the {languageArray[WordForPractice.FromLanguage]} word {WordForPractice.Translations[WordForPractice.FromLanguage]}\r\n Please submit the {languageArray[WordForPractice.ToLanguage]} translation";
        }

        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
            var _name = ListName;
            var languageArray = WordList.LoadList(_name).Languages;
            var answer = AnswerBox.Text.ToLower();
            AnswerBox.Text = string.Empty;

            if (answer == WordForPractice.Translations[WordForPractice.ToLanguage].ToLower())
            {
                Score++;
                Tries++;
            }
            else
            {
                var caption = "Wrong Answer";
                var message =
                    $"You answered wrong. Your answer was {answer} and the correct answer is {WordForPractice.Translations[WordForPractice.ToLanguage].ToLower()} ";
                var buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                Tries++;
                Fails++;
            }

            PracticeGenerator();
            PracticeWordBox.Text =
                $"Here is the {languageArray[WordForPractice.FromLanguage]} word {WordForPractice.Translations[WordForPractice.FromLanguage]}\r\n Please submit the {languageArray[WordForPractice.ToLanguage]} translation";
            ScoreAmount.Text = Score.ToString();
            FailAmount.Text = Fails.ToString();
            TriesAmount.Text = Tries.ToString();
        }

        private void StopButton_Click_1(object sender, EventArgs e)
        {
            var caption = "End of Session";
            var message =
                $"Out of your {Tries} tries you managed to get {Score} correct answers. You failed on {Fails} words";
            var buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            Close();
        }
    }
}