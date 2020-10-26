namespace LanguageTrainerWinForms
{
    partial class PracticeForm
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
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.PracticeWordBox = new System.Windows.Forms.TextBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.FailLabel = new System.Windows.Forms.Label();
            this.TriesLabel = new System.Windows.Forms.Label();
            this.ScoreAmount = new System.Windows.Forms.Label();
            this.FailAmount = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TriesAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AnswerBox
            // 
            this.AnswerBox.BackColor = System.Drawing.Color.RosyBrown;
            this.AnswerBox.Location = new System.Drawing.Point(284, 214);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(243, 20);
            this.AnswerBox.TabIndex = 2;
            // 
            // PracticeWordBox
            // 
            this.PracticeWordBox.BackColor = System.Drawing.Color.RosyBrown;
            this.PracticeWordBox.Location = new System.Drawing.Point(284, 146);
            this.PracticeWordBox.Multiline = true;
            this.PracticeWordBox.Name = "PracticeWordBox";
            this.PracticeWordBox.Size = new System.Drawing.Size(243, 62);
            this.PracticeWordBox.TabIndex = 3;
            this.PracticeWordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(667, 34);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(85, 23);
            this.ScoreLabel.TabIndex = 36;
            this.ScoreLabel.Text = "Total Score:";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FailLabel
            // 
            this.FailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FailLabel.Location = new System.Drawing.Point(660, 57);
            this.FailLabel.Name = "FailLabel";
            this.FailLabel.Size = new System.Drawing.Size(92, 23);
            this.FailLabel.TabIndex = 38;
            this.FailLabel.Text = "Total Fails:";
            this.FailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TriesLabel
            // 
            this.TriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TriesLabel.Location = new System.Drawing.Point(663, 80);
            this.TriesLabel.Name = "TriesLabel";
            this.TriesLabel.Size = new System.Drawing.Size(89, 23);
            this.TriesLabel.TabIndex = 46;
            this.TriesLabel.Text = "Total Tries:";
            this.TriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreAmount
            // 
            this.ScoreAmount.Location = new System.Drawing.Point(756, 34);
            this.ScoreAmount.Name = "ScoreAmount";
            this.ScoreAmount.Size = new System.Drawing.Size(32, 23);
            this.ScoreAmount.TabIndex = 47;
            this.ScoreAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FailAmount
            // 
            this.FailAmount.Location = new System.Drawing.Point(756, 57);
            this.FailAmount.Name = "FailAmount";
            this.FailAmount.Size = new System.Drawing.Size(32, 23);
            this.FailAmount.TabIndex = 48;
            this.FailAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(284, 240);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(90, 30);
            this.StopButton.TabIndex = 51;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click_1);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(437, 240);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(90, 30);
            this.SubmitButton.TabIndex = 52;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(729, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 23);
            this.label1.TabIndex = 53;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TriesAmount
            // 
            this.TriesAmount.Location = new System.Drawing.Point(756, 80);
            this.TriesAmount.Name = "TriesAmount";
            this.TriesAmount.Size = new System.Drawing.Size(32, 23);
            this.TriesAmount.TabIndex = 54;
            this.TriesAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TriesAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.FailAmount);
            this.Controls.Add(this.ScoreAmount);
            this.Controls.Add(this.TriesLabel);
            this.Controls.Add(this.FailLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.PracticeWordBox);
            this.Controls.Add(this.AnswerBox);
            this.Name = "PracticeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PracticeForm";
            this.Load += new System.EventHandler(this.PracticeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.TextBox PracticeWordBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label FailLabel;
        private System.Windows.Forms.Label TriesLabel;
        private System.Windows.Forms.Label ScoreAmount;
        private System.Windows.Forms.Label FailAmount;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TriesAmount;
    }
}