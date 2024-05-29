namespace MbtiTest
{
    partial class InstructionsForm
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
            this.instructionPreviousButton = new System.Windows.Forms.Button();
            this.instructionLabel1 = new System.Windows.Forms.Label();
            this.instructionLabel2 = new System.Windows.Forms.Label();
            this.instructionLabel3 = new System.Windows.Forms.Label();
            this.instructionLabel4 = new System.Windows.Forms.Label();
            this.instructionLabel5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionPreviousButton
            // 
            this.instructionPreviousButton.Location = new System.Drawing.Point(12, 403);
            this.instructionPreviousButton.Name = "instructionPreviousButton";
            this.instructionPreviousButton.Size = new System.Drawing.Size(165, 35);
            this.instructionPreviousButton.TabIndex = 0;
            this.instructionPreviousButton.Text = "Назад";
            this.instructionPreviousButton.UseVisualStyleBackColor = true;
            this.instructionPreviousButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // instructionLabel1
            // 
            this.instructionLabel1.AutoSize = true;
            this.instructionLabel1.Location = new System.Drawing.Point(366, 13);
            this.instructionLabel1.Name = "instructionLabel1";
            this.instructionLabel1.Size = new System.Drawing.Size(44, 16);
            this.instructionLabel1.TabIndex = 1;
            this.instructionLabel1.Text = "label1";
            // 
            // instructionLabel2
            // 
            this.instructionLabel2.Location = new System.Drawing.Point(13, 73);
            this.instructionLabel2.Name = "instructionLabel2";
            this.instructionLabel2.Size = new System.Drawing.Size(761, 47);
            this.instructionLabel2.TabIndex = 2;
            this.instructionLabel2.Text = "label2";
            // 
            // instructionLabel3
            // 
            this.instructionLabel3.AutoSize = true;
            this.instructionLabel3.Location = new System.Drawing.Point(12, 130);
            this.instructionLabel3.Name = "instructionLabel3";
            this.instructionLabel3.Size = new System.Drawing.Size(44, 16);
            this.instructionLabel3.TabIndex = 3;
            this.instructionLabel3.Text = "label3";
            // 
            // instructionLabel4
            // 
            this.instructionLabel4.AutoSize = true;
            this.instructionLabel4.Location = new System.Drawing.Point(9, 191);
            this.instructionLabel4.Name = "instructionLabel4";
            this.instructionLabel4.Size = new System.Drawing.Size(44, 16);
            this.instructionLabel4.TabIndex = 4;
            this.instructionLabel4.Text = "label4";
            // 
            // instructionLabel5
            // 
            this.instructionLabel5.AutoSize = true;
            this.instructionLabel5.Location = new System.Drawing.Point(9, 262);
            this.instructionLabel5.Name = "instructionLabel5";
            this.instructionLabel5.Size = new System.Drawing.Size(44, 16);
            this.instructionLabel5.TabIndex = 5;
            this.instructionLabel5.Text = "label5";
            // 
            // InstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.instructionLabel5);
            this.Controls.Add(this.instructionLabel4);
            this.Controls.Add(this.instructionLabel3);
            this.Controls.Add(this.instructionLabel2);
            this.Controls.Add(this.instructionLabel1);
            this.Controls.Add(this.instructionPreviousButton);
            this.Name = "InstructionsForm";
            this.Text = "InstructionsForm";
            this.Load += new System.EventHandler(this.InstructionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button instructionPreviousButton;
        private System.Windows.Forms.Label instructionLabel1;
        private System.Windows.Forms.Label instructionLabel2;
        private System.Windows.Forms.Label instructionLabel3;
        private System.Windows.Forms.Label instructionLabel4;
        private System.Windows.Forms.Label instructionLabel5;
    }
}