namespace LanguageTrainerWinForms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TranslationGrid = new System.Windows.Forms.DataGridView();
            this.CountLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.NewListButton = new System.Windows.Forms.Button();
            this.PracticeButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ListLabel = new System.Windows.Forms.Label();
            this.InformationBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.PracticeBox = new System.Windows.Forms.RichTextBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.TriesLabel = new System.Windows.Forms.Label();
            this.FailLabel = new System.Windows.Forms.Label();
            this.PracticeWordBox = new System.Windows.Forms.TextBox();
            this.TriesAmount = new System.Windows.Forms.Label();
            this.ScoreAmount = new System.Windows.Forms.Label();
            this.FailAmount = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TranslationGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TranslationGrid
            // 
            this.TranslationGrid.AllowUserToAddRows = false;
            this.TranslationGrid.AllowUserToDeleteRows = false;
            this.TranslationGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TranslationGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TranslationGrid.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.TranslationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TranslationGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.TranslationGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.TranslationGrid.GridColor = System.Drawing.Color.DodgerBlue;
            this.TranslationGrid.Location = new System.Drawing.Point(206, 55);
            this.TranslationGrid.Margin = new System.Windows.Forms.Padding(0);
            this.TranslationGrid.MultiSelect = false;
            this.TranslationGrid.Name = "TranslationGrid";
            this.TranslationGrid.RowHeadersVisible = false;
            this.TranslationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TranslationGrid.ShowRowErrors = false;
            this.TranslationGrid.Size = new System.Drawing.Size(702, 306);
            this.TranslationGrid.TabIndex = 22;
            // 
            // CountLabel
            // 
            this.CountLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.CountLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.CountLabel.Location = new System.Drawing.Point(241, 31);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(681, 20);
            this.CountLabel.TabIndex = 23;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(3, 56);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 304);
            this.listBox1.TabIndex = 24;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // NewListButton
            // 
            this.NewListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewListButton.Location = new System.Drawing.Point(3, 369);
            this.NewListButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewListButton.Name = "NewListButton";
            this.NewListButton.Size = new System.Drawing.Size(59, 37);
            this.NewListButton.TabIndex = 25;
            this.NewListButton.Text = "New";
            this.NewListButton.UseVisualStyleBackColor = true;
            this.NewListButton.Click += new System.EventHandler(this.NewListButton_Click);
            // 
            // PracticeButton
            // 
            this.PracticeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PracticeButton.Location = new System.Drawing.Point(103, 369);
            this.PracticeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PracticeButton.Name = "PracticeButton";
            this.PracticeButton.Size = new System.Drawing.Size(76, 35);
            this.PracticeButton.TabIndex = 26;
            this.PracticeButton.Text = "Practice";
            this.PracticeButton.UseVisualStyleBackColor = true;
            this.PracticeButton.Click += new System.EventHandler(this.PracticeButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(206, 369);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(74, 35);
            this.AddButton.TabIndex = 27;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListLabel.Location = new System.Drawing.Point(-1, 31);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(46, 20);
            this.ListLabel.TabIndex = 29;
            this.ListLabel.Text = "Lists:";
            // 
            // InformationBox
            // 
            this.InformationBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.InformationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationBox.Location = new System.Drawing.Point(373, 150);
            this.InformationBox.Margin = new System.Windows.Forms.Padding(0);
            this.InformationBox.Multiline = true;
            this.InformationBox.Name = "InformationBox";
            this.InformationBox.ReadOnly = true;
            this.InformationBox.Size = new System.Drawing.Size(349, 47);
            this.InformationBox.TabIndex = 31;
            this.InformationBox.Text = "Select a list to see the languages and words.";
            this.InformationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(849, 369);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(59, 37);
            this.SaveButton.TabIndex = 32;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(305, 369);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(74, 35);
            this.RemoveButton.TabIndex = 33;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // PracticeBox
            // 
            this.PracticeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PracticeBox.BackColor = System.Drawing.Color.RosyBrown;
            this.PracticeBox.Location = new System.Drawing.Point(205, 54);
            this.PracticeBox.Name = "PracticeBox";
            this.PracticeBox.Size = new System.Drawing.Size(703, 306);
            this.PracticeBox.TabIndex = 34;
            this.PracticeBox.Text = "";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(760, 74);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(100, 23);
            this.ScoreLabel.TabIndex = 35;
            this.ScoreLabel.Text = "Total Score:";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TriesLabel
            // 
            this.TriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TriesLabel.Location = new System.Drawing.Point(760, 153);
            this.TriesLabel.Name = "TriesLabel";
            this.TriesLabel.Size = new System.Drawing.Size(100, 23);
            this.TriesLabel.TabIndex = 36;
            this.TriesLabel.Text = "Total Tries:";
            this.TriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FailLabel
            // 
            this.FailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FailLabel.Location = new System.Drawing.Point(760, 115);
            this.FailLabel.Name = "FailLabel";
            this.FailLabel.Size = new System.Drawing.Size(100, 23);
            this.FailLabel.TabIndex = 37;
            this.FailLabel.Text = "Total Fails:";
            this.FailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PracticeWordBox
            // 
            this.PracticeWordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PracticeWordBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.PracticeWordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PracticeWordBox.Location = new System.Drawing.Point(450, 150);
            this.PracticeWordBox.Multiline = true;
            this.PracticeWordBox.Name = "PracticeWordBox";
            this.PracticeWordBox.ReadOnly = true;
            this.PracticeWordBox.Size = new System.Drawing.Size(201, 58);
            this.PracticeWordBox.TabIndex = 38;
            this.PracticeWordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TriesAmount
            // 
            this.TriesAmount.Location = new System.Drawing.Point(866, 153);
            this.TriesAmount.Name = "TriesAmount";
            this.TriesAmount.Size = new System.Drawing.Size(32, 23);
            this.TriesAmount.TabIndex = 40;
            this.TriesAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreAmount
            // 
            this.ScoreAmount.Location = new System.Drawing.Point(866, 74);
            this.ScoreAmount.Name = "ScoreAmount";
            this.ScoreAmount.Size = new System.Drawing.Size(32, 23);
            this.ScoreAmount.TabIndex = 41;
            this.ScoreAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FailAmount
            // 
            this.FailAmount.Location = new System.Drawing.Point(866, 115);
            this.FailAmount.Name = "FailAmount";
            this.FailAmount.Size = new System.Drawing.Size(32, 23);
            this.FailAmount.TabIndex = 42;
            this.FailAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(561, 248);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(90, 30);
            this.SubmitButton.TabIndex = 43;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click_1);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(450, 248);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(90, 30);
            this.StopButton.TabIndex = 44;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // AnswerBox
            // 
            this.AnswerBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.AnswerBox.Location = new System.Drawing.Point(450, 214);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(201, 20);
            this.AnswerBox.TabIndex = 45;
            // 
            // MainForm
            // 
            this.AcceptButton = this.AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(988, 457);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.FailAmount);
            this.Controls.Add(this.ScoreAmount);
            this.Controls.Add(this.TriesAmount);
            this.Controls.Add(this.PracticeWordBox);
            this.Controls.Add(this.FailLabel);
            this.Controls.Add(this.TriesLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.PracticeBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.InformationBox);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PracticeButton);
            this.Controls.Add(this.NewListButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.TranslationGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TranslationGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox AnswerBox;

        private System.Windows.Forms.TextBox PracticeWordBox;

        private System.Windows.Forms.Button SubmitButton;

        private System.Windows.Forms.Button StopButton;

        private System.Windows.Forms.RichTextBox PracticeBox;

        private System.Windows.Forms.Label FailAmount;
        private System.Windows.Forms.Label FailLabel;
        private System.Windows.Forms.Label ScoreAmount;
        private System.Windows.Forms.Label TriesAmount;
        private System.Windows.Forms.Label TriesLabel;

        private System.Windows.Forms.Label ScoreLabel;

        #endregion

        private System.Windows.Forms.DataGridView TranslationGrid;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button NewListButton;
        private System.Windows.Forms.Button PracticeButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.TextBox InformationBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button RemoveButton;
    }
}