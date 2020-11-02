using System;
using System.Windows.Forms;
using LanguageLibrary;

namespace LanguageTrainerWinForms
{
    public partial class MainForm : Form
    {
        public MainForm(string name)
        {
            InitializeComponent();
            FileName = name;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private int Score { get; set; }
        private Word WordForPractice { get; set; }
        private int Tries { get; set; }
        private int Fails { get; set; }
        private string FileName { get; set; }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null && WordList.LoadList(listBox1.SelectedItem.ToString()) != null)
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
                FileName = listBox1.SelectedItem.ToString();
                if (WordList.LoadList(FileName) != null)
                {
                    var languageArray = WordList.LoadList(FileName).Languages;
                    var sortBy = 0;
                    CountLabel.Text = $"There are {WordList.LoadList(FileName).Count()} words in the list";
                    TranslationGrid.Rows.Clear();
                    TranslationGrid.Columns.Clear();
                    TranslationGrid.Refresh();
                    foreach (var languages in languageArray)
                        TranslationGrid.Columns.Add("newColumnName", languages.ToUpper());
                    TranslationGrid.Rows.Clear();

                    WordList.LoadList(FileName).List(sortBy, x => { TranslationGrid.Rows.Add(x); });
                }
            }
            else
            {
                TranslationGrid.Hide();
                InformationBox.Show();
                InformationBox.Text = "this is not a valid list";
            }
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            listBox1.Show();
            listBox1.Enabled = true;
            ListLabel.Show();
            listBox1.Items.Clear();
            var vs = WordList.GetLists();

            foreach (var v in vs)
                if (WordList.LoadList(v) != null && WordList.LoadList(v).Languages.Length > 1)
                    listBox1.Items.Add(v);
        }

        private void Save()
        {
            if (listBox1.SelectedItem.ToString() != null)
            {
                FileName = listBox1.SelectedItem.ToString();
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
                            var emptySlots = TranslationGrid.Rows.Count - modifiedList.Count();
                            for (var k = 0; k < emptySlots; k++) TranslationGrid.Rows.RemoveAt(modifiedList.Count());

                            var caption = "Error Detected in Input";
                            var message =
                                "You did not add a word for every language. \nThe empty indexes will not be saved";
                            var buttons = MessageBoxButtons.OK;
                            DialogResult result;
                            result = MessageBox.Show(message, caption, buttons);
                            correctLength = false;
                            break;
                        }

                    if (correctLength)
                    {
                        modifiedList.Add(words);
                        modifiedList.Save();
                        CountLabel.Text = $"There are {WordList.LoadList(FileName).Count()} words in the list";
                    }
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            TranslationGrid.Rows.Add("");
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) FileName = listBox1.SelectedItem.ToString();

            
            if (TranslationGrid.SelectedRows.Count != 0)
            {
                var selectedRows = TranslationGrid.SelectedRows;
                var word = selectedRows[0].Cells[0].Value.ToString();
                WordList.LoadList(FileName).Remove(0, word);
                
            }
            foreach (DataGridViewRow item in TranslationGrid.SelectedRows) TranslationGrid.Rows.RemoveAt(item.Index);
            CountLabel.Text = $"There are {WordList.LoadList(FileName).Count()} words in the list";
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


        private void PracticeButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Enabled = false;
                var name = listBox1.SelectedItem.ToString();
                if (WordList.LoadList(name).Count() != 0)
                {
                    var practice = new PracticeForm(name);
                    practice.TopMost = true;
                    practice.Show();
                }
                else
                {
                    var caption = "Error Detected";
                    var message =
                        "The selected list is empty, you cant practice with an empty list";
                    var buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    
                }
            }
        }
    }
}