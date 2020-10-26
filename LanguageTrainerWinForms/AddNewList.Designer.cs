namespace LanguageTrainerWinForms
{
    partial class AddNewList
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
            this.NameTextBoxInput = new System.Windows.Forms.TextBox();
            this.LanguageTextBoxInput = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextBoxInput
            // 
            this.NameTextBoxInput.Location = new System.Drawing.Point(39, 26);
            this.NameTextBoxInput.Name = "NameTextBoxInput";
            this.NameTextBoxInput.Size = new System.Drawing.Size(304, 20);
            this.NameTextBoxInput.TabIndex = 0;
            this.NameTextBoxInput.TextChanged += new System.EventHandler(this.NameTextBoxInput_TextChanged);
            // 
            // LanguageTextBoxInput
            // 
            this.LanguageTextBoxInput.Location = new System.Drawing.Point(39, 77);
            this.LanguageTextBoxInput.Multiline = true;
            this.LanguageTextBoxInput.Name = "LanguageTextBoxInput";
            this.LanguageTextBoxInput.Size = new System.Drawing.Size(304, 252);
            this.LanguageTextBoxInput.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(39, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(39, 61);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(60, 13);
            this.LanguageLabel.TabIndex = 3;
            this.LanguageLabel.Text = "Languages";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(264, 347);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(42, 347);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddNewList
            // 
            this.AcceptButton = this.CreateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 399);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LanguageTextBoxInput);
            this.Controls.Add(this.NameTextBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNewList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewList";
            this.Load += new System.EventHandler(this.AddNewList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBoxInput;
        private System.Windows.Forms.TextBox LanguageTextBoxInput;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.Button CreateButton;
        private new System.Windows.Forms.Button CancelButton;
    }
}