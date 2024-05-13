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
            this.fifthAnswerLabel = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.firstAnswerRadio = new System.Windows.Forms.RadioButton();
            this.secondAnswerRadio = new System.Windows.Forms.RadioButton();
            this.thirdAnswerRadio = new System.Windows.Forms.RadioButton();
            this.fourthAnswerRadio = new System.Windows.Forms.RadioButton();
            this.fifthAnswerRadio = new System.Windows.Forms.RadioButton();
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
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Location = new System.Drawing.Point(92, 82);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(89, 16);
            this.questionTextLabel.TabIndex = 1;
            this.questionTextLabel.Text = "Question Text";
            // 
            // firstAnswerLabel
            // 
            this.firstAnswerLabel.AutoSize = true;
            this.firstAnswerLabel.Location = new System.Drawing.Point(38, 152);
            this.firstAnswerLabel.Name = "firstAnswerLabel";
            this.firstAnswerLabel.Size = new System.Drawing.Size(70, 16);
            this.firstAnswerLabel.TabIndex = 2;
            this.firstAnswerLabel.Text = "Question 1";
            // 
            // secondAnswerLabel
            // 
            this.secondAnswerLabel.AutoSize = true;
            this.secondAnswerLabel.Location = new System.Drawing.Point(38, 197);
            this.secondAnswerLabel.Name = "secondAnswerLabel";
            this.secondAnswerLabel.Size = new System.Drawing.Size(70, 16);
            this.secondAnswerLabel.TabIndex = 3;
            this.secondAnswerLabel.Text = "Question 2";
            // 
            // thirdAnswerLabel
            // 
            this.thirdAnswerLabel.AutoSize = true;
            this.thirdAnswerLabel.Location = new System.Drawing.Point(38, 241);
            this.thirdAnswerLabel.Name = "thirdAnswerLabel";
            this.thirdAnswerLabel.Size = new System.Drawing.Size(70, 16);
            this.thirdAnswerLabel.TabIndex = 4;
            this.thirdAnswerLabel.Text = "Question 3";
            // 
            // fourthAnswerLabel
            // 
            this.fourthAnswerLabel.AutoSize = true;
            this.fourthAnswerLabel.Location = new System.Drawing.Point(38, 285);
            this.fourthAnswerLabel.Name = "fourthAnswerLabel";
            this.fourthAnswerLabel.Size = new System.Drawing.Size(70, 16);
            this.fourthAnswerLabel.TabIndex = 5;
            this.fourthAnswerLabel.Text = "Question 4";
            // 
            // fifthAnswerLabel
            // 
            this.fifthAnswerLabel.AutoSize = true;
            this.fifthAnswerLabel.Location = new System.Drawing.Point(38, 329);
            this.fifthAnswerLabel.Name = "fifthAnswerLabel";
            this.fifthAnswerLabel.Size = new System.Drawing.Size(70, 16);
            this.fifthAnswerLabel.TabIndex = 6;
            this.fifthAnswerLabel.Text = "Question 5";
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
            // firstAnswerRadio
            // 
            this.firstAnswerRadio.AutoSize = true;
            this.firstAnswerRadio.Location = new System.Drawing.Point(644, 147);
            this.firstAnswerRadio.Name = "firstAnswerRadio";
            this.firstAnswerRadio.Size = new System.Drawing.Size(17, 16);
            this.firstAnswerRadio.TabIndex = 9;
            this.firstAnswerRadio.TabStop = true;
            this.firstAnswerRadio.UseVisualStyleBackColor = true;
            // 
            // secondAnswerRadio
            // 
            this.secondAnswerRadio.AutoSize = true;
            this.secondAnswerRadio.Location = new System.Drawing.Point(644, 192);
            this.secondAnswerRadio.Name = "secondAnswerRadio";
            this.secondAnswerRadio.Size = new System.Drawing.Size(17, 16);
            this.secondAnswerRadio.TabIndex = 10;
            this.secondAnswerRadio.TabStop = true;
            this.secondAnswerRadio.UseVisualStyleBackColor = true;
            // 
            // thirdAnswerRadio
            // 
            this.thirdAnswerRadio.AutoSize = true;
            this.thirdAnswerRadio.Location = new System.Drawing.Point(644, 236);
            this.thirdAnswerRadio.Name = "thirdAnswerRadio";
            this.thirdAnswerRadio.Size = new System.Drawing.Size(17, 16);
            this.thirdAnswerRadio.TabIndex = 11;
            this.thirdAnswerRadio.TabStop = true;
            this.thirdAnswerRadio.UseVisualStyleBackColor = true;
            // 
            // fourthAnswerRadio
            // 
            this.fourthAnswerRadio.AutoSize = true;
            this.fourthAnswerRadio.Location = new System.Drawing.Point(644, 280);
            this.fourthAnswerRadio.Name = "fourthAnswerRadio";
            this.fourthAnswerRadio.Size = new System.Drawing.Size(17, 16);
            this.fourthAnswerRadio.TabIndex = 12;
            this.fourthAnswerRadio.TabStop = true;
            this.fourthAnswerRadio.UseVisualStyleBackColor = true;
            // 
            // fifthAnswerRadio
            // 
            this.fifthAnswerRadio.AutoSize = true;
            this.fifthAnswerRadio.Location = new System.Drawing.Point(644, 324);
            this.fifthAnswerRadio.Name = "fifthAnswerRadio";
            this.fifthAnswerRadio.Size = new System.Drawing.Size(17, 16);
            this.fifthAnswerRadio.TabIndex = 13;
            this.fifthAnswerRadio.TabStop = true;
            this.fifthAnswerRadio.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fifthAnswerRadio);
            this.Controls.Add(this.fourthAnswerRadio);
            this.Controls.Add(this.thirdAnswerRadio);
            this.Controls.Add(this.secondAnswerRadio);
            this.Controls.Add(this.firstAnswerRadio);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.fifthAnswerLabel);
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
        private System.Windows.Forms.Label fifthAnswerLabel;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.RadioButton firstAnswerRadio;
        private System.Windows.Forms.RadioButton secondAnswerRadio;
        private System.Windows.Forms.RadioButton thirdAnswerRadio;
        private System.Windows.Forms.RadioButton fourthAnswerRadio;
        private System.Windows.Forms.RadioButton fifthAnswerRadio;
    }
}

