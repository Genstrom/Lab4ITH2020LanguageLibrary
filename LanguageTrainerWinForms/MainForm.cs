using System;
using System.Windows.Forms;
using LanguageLibrary;

namespace LanguageTrainerWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int Score { get; set; }
        private Word WordForPractice { get; set; }
        private int Tries { get; set; }
        private int Fails { get; set; }
        private string FileName => listBox1.SelectedItem.ToString();


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                TranslationGrid.Show();
                AddButton.Show();
                NewListButton.Show();
                RemoveButton.Show();
                SaveButton.Show();
                PracticeButton.Show();
                AddButton.Enabled = true;
                SaveButton.Enabled = true;
                RemoveButton.Enabled = true;

                InformationBox.Hide();
                var name = listBox1.SelectedItem.ToString();
                var languageArray = WordList.LoadList(name).Languages;
                var sortBy = 0;

                CountLabel.Text = $"There are {WordList.LoadList(name).Count()} words in the list";
                TranslationGrid.Rows.Clear();
                TranslationGrid.Columns.Clear();
                TranslationGrid.Refresh();
                foreach (var languages in languageArray)
                    TranslationGrid.Columns.Add("newColumnName", languages.ToUpper());
                TranslationGrid.Rows.Clear();

                WordList.LoadList(name).List(sortBy, x => { TranslationGrid.Rows.Add(x); });
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newList = new AddNewList();
            newList.Show();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            listBox1.Show();
            ListLabel.Show();
            listBox1.Items.Clear();
            var vs = WordList.GetLists();
            foreach (var v in vs) listBox1.Items.Add(v);
        }

        private void Save()
        {
            if (FileName != null)
            {
                var modifiedList = new WordList(FileName, WordList.LoadList(FileName).Languages);
                var correctLength = true;
                for (var i = 0; i < TranslationGrid.Rows.Count; i++)
                {
                    if (correctLength == false) break;

                    var words = new string[modifiedList.Languages.Length];
                    for (var j = 0; j < words.Length; j++)
                        if (TranslationGrid.Rows[i].Cells[j].Value != null &&
                            !string.IsNullOrWhiteSpace(TranslationGrid.Rows[i].Cells[j].Value.ToString()))
                        {
                            words[j] = TranslationGrid.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            var caption = "Error Detected in Input";
                            var message =
                                "You did not add a word for every language. \nThe empty indexes will not be saved";
                            var buttons = MessageBoxButtons.OK;
                            DialogResult result;
                            result = MessageBox.Show(message, caption, buttons);
                            TranslationGrid.Rows.RemoveAt(TranslationGrid.Rows.Count - 1);
                            correctLength = false;
                            break;
                        }

                    if (correctLength)
                    {
                        modifiedList.Add(words);
                        modifiedList.Save();
                    }
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var currentRow = TranslationGrid.SelectedRows[0].Index;

            if (currentRow < TranslationGrid.RowCount)
            {
                TranslationGrid.Rows.Add("");
                TranslationGrid.Rows[++currentRow].Selected = true;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in TranslationGrid.SelectedRows) TranslationGrid.Rows.RemoveAt(item.Index);
        }

        private void NewListButton_Click(object sender, EventArgs e)
        {
            var newList = new AddNewList();
            newList.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                TranslationGrid.Hide();
                InformationBox.Text = "You need to select a list before you save";
                InformationBox.Show();
            }
            else
            {
                Save();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddButton.Enabled = false;
            SaveButton.Enabled = false;
            RemoveButton.Enabled = false;
            PracticeHider();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                TranslationGrid.Hide();
                InformationBox.Text = "You need to select a list ";
                InformationBox.Show();
            }
            else
            {
                Save();
            }
        }

        private void PracticeHider()
        {
            PracticeBox.Hide();
            TriesAmount.Hide();
            TriesLabel.Hide();
            SubmitButton.Hide();
            ScoreAmount.Hide();
            ScoreLabel.Hide();
            FailAmount.Hide();
            FailLabel.Hide();
            PracticeWordBox.Hide();
            AnswerBox.Hide();
            StopButton.Hide();
        }

        private void PracticeButton_Click(object sender, EventArgs e)
        {
            listBox1.Enabled = false;
            TranslationGrid.Hide();
            AddButton.Hide();
            SaveButton.Hide();
            NewListButton.Hide();
            RemoveButton.Hide();
            PracticeButton.Hide();
            if (listBox1.SelectedItem == null)
            {
                TranslationGrid.Hide();
                InformationBox.Text = "You need to select a list ";
                listBox1.Enabled = true;
                InformationBox.Show();
            }
            else
            {
                PracticeBox.Show();
                TriesAmount.Show();
                TriesLabel.Show();
                SubmitButton.Show();
                ScoreAmount.Show();
                ScoreLabel.Show();
                FailAmount.Show();
                FailLabel.Show();
                PracticeWordBox.Show();
                AnswerBox.Show();
                StopButton.Show();

                var languageArray = WordList.LoadList(FileName).Languages;
                var wordForPractice = PracticeGenerator();
                PracticeWordBox.Text =
                    $"Here is the {languageArray[wordForPractice.FromLanguage]} word {wordForPractice.Translations[wordForPractice.FromLanguage]}\r\n Please submit the {languageArray[wordForPractice.ToLanguage]} translation";
                ScoreAmount.Text = Score.ToString();
                FailAmount.Text = Fails.ToString();
                TriesAmount.Text = Tries.ToString();
            }
        }

        private Word PracticeGenerator()
        {
            WordForPractice = WordList.LoadList(FileName).GetWordToPractice();
            return WordForPractice;
        }

        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
            var languageArray = WordList.LoadList(FileName).Languages;
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
                var message = $"You answered wrong. Your answer was {answer} and the correct answer was {WordForPractice.Translations[WordForPractice.ToLanguage].ToLower()} ";
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

        private void StopButton_Click(object sender, EventArgs e)
        {
            PracticeHider();
            listBox1.Enabled = true;
            InformationBox.Show();
            InformationBox.Text =
                $"Out of your {Tries} tries you managed to get {Score} correct answers. You failed on {Fails} words";
        }
    }
}