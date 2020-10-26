using System;
using System.Linq;
using System.Windows.Forms;
using LanguageLibrary;

namespace LanguageTrainerWinForms
{
    public partial class AddNewList : Form
    {
        public AddNewList()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var name = NameTextBoxInput.Text;
            var languageList = LanguageTextBoxInput.Lines.ToList();
            var languageArray = languageList.Where(i => !string.IsNullOrWhiteSpace(i)).ToArray();

            if (languageArray.Length < 2)
            {
                var caption = "Error Detected in Input";
                var message = "You need to add atleast 2 langauges. \nThe list will not be saved";
                var buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                var wordList = new WordList(name, languageArray);
                wordList.Save();
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewList_Load(object sender, EventArgs e)
        {
            LanguageTextBoxInput.Text = $"Language 1{Environment.NewLine}Language2";
        }

        private void NameTextBoxInput_TextChanged(object sender, EventArgs e)
        {
            LanguageTextBoxInput.Text = string.Empty;
        }
    }
}