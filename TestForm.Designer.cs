namespace MbtiTest
{
    partial class TestForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.firstAnswerLabel = new System.Windows.Forms.Label();
            this.secondAnswerLabel = new System.Windows.Forms.Label();
            this.thirdAnswerLabel = new System.Windows.Forms.Label();
            this.fourthAnswerLabel = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.firstAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.secondAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.thirdAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.fourthAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Location = new System.Drawing.Point(92, 29);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(111, 16);
            this.questionNumberLabel.TabIndex = 0;
            this.questionNumberLabel.Text = "Question Number";
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.Location = new System.Drawing.Point(92, 76);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(595, 54);
            this.questionTextLabel.TabIndex = 1;
            this.questionTextLabel.Text = "Question Text";
            // 
            // firstAnswerLabel
            // 
            this.firstAnswerLabel.AutoSize = true;
            this.firstAnswerLabel.Location = new System.Drawing.Point(38, 152);
            this.firstAnswerLabel.Name = "firstAnswerLabel";
            this.firstAnswerLabel.Size = new System.Drawing.Size(61, 16);
            this.firstAnswerLabel.TabIndex = 2;
            this.firstAnswerLabel.Text = "Answer 1";
            // 
            // secondAnswerLabel
            // 
            this.secondAnswerLabel.AutoSize = true;
            this.secondAnswerLabel.Location = new System.Drawing.Point(38, 197);
            this.secondAnswerLabel.Name = "secondAnswerLabel";
            this.secondAnswerLabel.Size = new System.Drawing.Size(61, 16);
            this.secondAnswerLabel.TabIndex = 3;
            this.secondAnswerLabel.Text = "Answer 2";
            // 
            // thirdAnswerLabel
            // 
            this.thirdAnswerLabel.AutoSize = true;
            this.thirdAnswerLabel.Location = new System.Drawing.Point(38, 241);
            this.thirdAnswerLabel.Name = "thirdAnswerLabel";
            this.thirdAnswerLabel.Size = new System.Drawing.Size(61, 16);
            this.thirdAnswerLabel.TabIndex = 4;
            this.thirdAnswerLabel.Text = "Answer 3";
            // 
            // fourthAnswerLabel
            // 
            this.fourthAnswerLabel.AutoSize = true;
            this.fourthAnswerLabel.Location = new System.Drawing.Point(38, 285);
            this.fourthAnswerLabel.Name = "fourthAnswerLabel";
            this.fourthAnswerLabel.Size = new System.Drawing.Size(61, 16);
            this.fourthAnswerLabel.TabIndex = 5;
            this.fourthAnswerLabel.Text = "Answer 4";
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(41, 396);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(143, 32);
            this.previousButton.TabIndex = 7;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(608, 397);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(140, 31);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // firstAnswerCheckBox
            // 
            this.firstAnswerCheckBox.AutoSize = true;
            this.firstAnswerCheckBox.Location = new System.Drawing.Point(669, 151);
            this.firstAnswerCheckBox.Name = "firstAnswerCheckBox";
            this.firstAnswerCheckBox.Size = new System.Drawing.Size(18, 17);
            this.firstAnswerCheckBox.TabIndex = 14;
            this.firstAnswerCheckBox.UseVisualStyleBackColor = true;
            this.firstAnswerCheckBox.Click += new System.EventHandler(this.CheckBoxClick);
            // 
            // secondAnswerCheckBox
            // 
            this.secondAnswerCheckBox.AutoSize = true;
            this.secondAnswerCheckBox.Location = new System.Drawing.Point(669, 196);
            this.secondAnswerCheckBox.Name = "secondAnswerCheckBox";
            this.secondAnswerCheckBox.Size = new System.Drawing.Size(18, 17);
            this.secondAnswerCheckBox.TabIndex = 15;
            this.secondAnswerCheckBox.UseVisualStyleBackColor = true;
            this.secondAnswerCheckBox.Click += new System.EventHandler(this.CheckBoxClick);
            // 
            // thirdAnswerCheckBox
            // 
            this.thirdAnswerCheckBox.AutoSize = true;
            this.thirdAnswerCheckBox.Location = new System.Drawing.Point(669, 240);
            this.thirdAnswerCheckBox.Name = "thirdAnswerCheckBox";
            this.thirdAnswerCheckBox.Size = new System.Drawing.Size(18, 17);
            this.thirdAnswerCheckBox.TabIndex = 16;
            this.thirdAnswerCheckBox.UseVisualStyleBackColor = true;
            this.thirdAnswerCheckBox.Click += new System.EventHandler(this.CheckBoxClick);
            // 
            // fourthAnswerCheckBox
            // 
            this.fourthAnswerCheckBox.AutoSize = true;
            this.fourthAnswerCheckBox.Location = new System.Drawing.Point(669, 284);
            this.fourthAnswerCheckBox.Name = "fourthAnswerCheckBox";
            this.fourthAnswerCheckBox.Size = new System.Drawing.Size(18, 17);
            this.fourthAnswerCheckBox.TabIndex = 17;
            this.fourthAnswerCheckBox.UseVisualStyleBackColor = true;
            this.fourthAnswerCheckBox.Click += new System.EventHandler(this.CheckBoxClick);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fourthAnswerCheckBox);
            this.Controls.Add(this.thirdAnswerCheckBox);
            this.Controls.Add(this.secondAnswerCheckBox);
            this.Controls.Add(this.firstAnswerCheckBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.fourthAnswerLabel);
            this.Controls.Add(this.thirdAnswerLabel);
            this.Controls.Add(this.secondAnswerLabel);
            this.Controls.Add(this.firstAnswerLabel);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Label firstAnswerLabel;
        private System.Windows.Forms.Label secondAnswerLabel;
        private System.Windows.Forms.Label thirdAnswerLabel;
        private System.Windows.Forms.Label fourthAnswerLabel;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.CheckBox firstAnswerCheckBox;
        private System.Windows.Forms.CheckBox secondAnswerCheckBox;
        private System.Windows.Forms.CheckBox thirdAnswerCheckBox;
        private System.Windows.Forms.CheckBox fourthAnswerCheckBox;
    }
}

