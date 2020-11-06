using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
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
            if (!string.IsNullOrWhiteSpace(NameTextBoxInput.Text))
            {
                var name = NameTextBoxInput.Text;
                var languageList = LanguageTextBoxInput.Lines.ToList();
                var languageArray = languageList.Where(i => !string.IsNullOrWhiteSpace(i)).ToArray();

                if (languageArray.Length < 2)
                {
                    var caption = "Error Detected in Input";
                    var message = "You need to add atleast 2 langauges. \nThe list will not be saved";
                    var buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
                else
                {
                    var wordList = new WordList(name, languageArray);
                    wordList.Save();
                    Close();
                }
            }
            else
            {
                var caption = "Error Detected in Input";
                var message = "You need to add a name to the list. \nThe list will not be saved";
                var buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewList_Load(object sender, EventArgs e)
        {
            LanguageTextBoxInput.Text = $"Language 1{Environment.NewLine}Language 2{Environment.NewLine}....";
        }

        private void NameTextBoxInput_TextChanged(object sender, EventArgs e)
        {
            LanguageTextBoxInput.Text = string.Empty;
        }
    }
}