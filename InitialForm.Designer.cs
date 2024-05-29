namespace MbtiTest
{
    partial class InitialForm
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
            this.startTheTest = new System.Windows.Forms.Button();
            this.instructionButton = new System.Windows.Forms.Button();
            this.catalogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startTheTest
            // 
            this.startTheTest.Location = new System.Drawing.Point(311, 350);
            this.startTheTest.Name = "startTheTest";
            this.startTheTest.Size = new System.Drawing.Size(214, 37);
            this.startTheTest.TabIndex = 0;
            this.startTheTest.Text = "Розпочати тест";
            this.startTheTest.UseVisualStyleBackColor = true;
            this.startTheTest.Click += new System.EventHandler(this.startTheTest_Click);
            // 
            // instructionButton
            // 
            this.instructionButton.Location = new System.Drawing.Point(12, 27);
            this.instructionButton.Name = "instructionButton";
            this.instructionButton.Size = new System.Drawing.Size(133, 38);
            this.instructionButton.TabIndex = 1;
            this.instructionButton.Text = "Інструкція";
            this.instructionButton.UseVisualStyleBackColor = true;
            this.instructionButton.Click += new System.EventHandler(this.instructionButton_Click);
            // 
            // catalogButton
            // 
            this.catalogButton.Location = new System.Drawing.Point(655, 27);
            this.catalogButton.Name = "catalogButton";
            this.catalogButton.Size = new System.Drawing.Size(133, 38);
            this.catalogButton.TabIndex = 2;
            this.catalogButton.Text = "Каталог";
            this.catalogButton.UseVisualStyleBackColor = true;
            this.catalogButton.Click += new System.EventHandler(this.catalogButton_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.catalogButton);
            this.Controls.Add(this.instructionButton);
            this.Controls.Add(this.startTheTest);
            this.Name = "InitialForm";
            this.Text = "InitialForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startTheTest;
        private System.Windows.Forms.Button instructionButton;
        private System.Windows.Forms.Button catalogButton;
    }
}