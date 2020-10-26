using System;
using System.Windows.Forms;
using LanguageLibrary;

namespace LanguageTrainerWinForms
{
    public partial class Form1 : Form
    {
        public Form1(string name)
        {
            InitializeComponent();
            Name = name;
        }
        
        public string Name { get; }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            if (listBox1.SelectedItem != null)
            {
                InformationBox.Hide();
                var name = listBox1.SelectedItem.ToString();
                new Form1(name);
                var languageArray = WordList.LoadList(name).Languages;                
                var sortBy = 0;

                CountLabel.Text = $"There are {WordList.LoadList(name).Count()} words in the list";
                TranslationGrid.Rows.Clear();
                TranslationGrid.Columns.Clear();
                TranslationGrid.Refresh();
                foreach (var languages in languageArray) TranslationGrid.Columns.Add("newColumnName", languages.ToUpper());
                TranslationGrid.Rows.Clear();

                WordList.LoadList(name).List(sortBy, x => { TranslationGrid.Rows.Add(x); });

            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            var newList = new AddNewList();
            newList.Show();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            var name = "";
            if (listBox1.SelectedItem != null) name = listBox1.SelectedItem.ToString();
          
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newList = new AddNewList();
            newList.Show();
        }

        public void RefreshListbox()
        {
            listBox1.Items.Clear();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            var addnewlist = new AddNewList();
            listBox1.Show();
            ListLabel.Show();
            listBox1.Items.Clear();
            var vs = WordList.GetLists();
            foreach (var v in vs) listBox1.Items.Add(v);
     
        }

        private void Save()
        {
            var modifiedList = new WordList(Name, WordList.LoadList(Name).Languages);
            var counter = 0;
            for (var i = 0; i < TranslationGrid.Rows.Count; i++)
            {
                var words = new string[modifiedList.Languages.Length];
                for (var j = 0; j < words.Length; j++)
                {
                    if (!string.IsNullOrWhiteSpace(TranslationGrid.Rows[i].Cells[j].Value.ToString()))
                    { 
                        words[j] = TranslationGrid.Rows[i].Cells[j].Value.ToString();
                        counter++;
                    }
                    
                    
                }   
                if (counter == words.Length)
                {
                    modifiedList.Add(words);
                    modifiedList.Save();
                }
               
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            TranslationGrid.Rows.Add("");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var modifiedList = new WordList(Name, WordList.LoadList(Name).Languages);

            for (var i = 0; i < TranslationGrid.Rows.Count; i++)
            {
                var words = new string[modifiedList.Languages.Length];
                for (var j = 0; j < words.Length; j++) words[j] = TranslationGrid.Rows[i].Cells[j].Value.ToString();
                modifiedList.Add(words);
                modifiedList.Save();
            }

        }
    }
}