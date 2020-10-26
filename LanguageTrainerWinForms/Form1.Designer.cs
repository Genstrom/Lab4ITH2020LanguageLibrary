using System;

namespace LanguageTrainerWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {

                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ListLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountLabel = new System.Windows.Forms.Label();
            this.NewListButton = new System.Windows.Forms.Button();
            this.PracticeButton = new System.Windows.Forms.Button();
            this.TranslationGrid = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InformationBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TranslationGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.SeaShell;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(13, 71);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 304);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Location = new System.Drawing.Point(12, 46);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(46, 20);
            this.ListLabel.TabIndex = 16;
            this.ListLabel.Text = "Lists:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.addToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // CountLabel
            // 
            this.CountLabel.BackColor = System.Drawing.Color.Ivory;
            this.CountLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.CountLabel.Location = new System.Drawing.Point(203, 46);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(681, 20);
            this.CountLabel.TabIndex = 18;
            // 
            // NewListButton
            // 
            this.NewListButton.Location = new System.Drawing.Point(15, 385);
            this.NewListButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewListButton.Name = "NewListButton";
            this.NewListButton.Size = new System.Drawing.Size(76, 35);
            this.NewListButton.TabIndex = 7;
            this.NewListButton.Text = "New";
            this.NewListButton.UseVisualStyleBackColor = true;
            this.NewListButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // PracticeButton
            // 
            this.PracticeButton.Location = new System.Drawing.Point(108, 385);
            this.PracticeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PracticeButton.Name = "PracticeButton";
            this.PracticeButton.Size = new System.Drawing.Size(76, 35);
            this.PracticeButton.TabIndex = 20;
            this.PracticeButton.Text = "Practice";
            this.PracticeButton.UseVisualStyleBackColor = true;
            // 
            // TranslationGrid
            // 
            this.TranslationGrid.AllowUserToAddRows = false;
            this.TranslationGrid.AllowUserToDeleteRows = false;
            this.TranslationGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TranslationGrid.BackgroundColor = System.Drawing.Color.SeaShell;
            this.TranslationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TranslationGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.TranslationGrid.Location = new System.Drawing.Point(203, 71);
            this.TranslationGrid.Margin = new System.Windows.Forms.Padding(0);
            this.TranslationGrid.Name = "TranslationGrid";
            this.TranslationGrid.RowHeadersVisible = false;
            this.TranslationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TranslationGrid.ShowRowErrors = false;
            this.TranslationGrid.Size = new System.Drawing.Size(681, 304);
            this.TranslationGrid.TabIndex = 21;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(15, 435);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(74, 35);
            this.AddButton.TabIndex = 23;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(108, 435);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(76, 35);
            this.DeleteButton.TabIndex = 24;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // InformationBox
            // 
            this.InformationBox.Location = new System.Drawing.Point(353, 190);
            this.InformationBox.Multiline = true;
            this.InformationBox.Name = "InformationBox";
            this.InformationBox.Size = new System.Drawing.Size(321, 29);
            this.InformationBox.TabIndex = 25;
            this.InformationBox.Text = "Select a list to see the languages and words.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(911, 482);
            this.Controls.Add(this.InformationBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TranslationGrid);
            this.Controls.Add(this.PracticeButton);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.NewListButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);         
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TranslationGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void _Active(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button NewListButton;
        private System.Windows.Forms.Button PracticeButton;
        private System.Windows.Forms.DataGridView TranslationGrid;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox InformationBox;

        public EventHandler Active { get; private set; }
    }
}

