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
            this.SuspendLayout();
            // 
            // startTheTest
            // 
            this.startTheTest.Location = new System.Drawing.Point(311, 350);
            this.startTheTest.Name = "startTheTest";
            this.startTheTest.Size = new System.Drawing.Size(214, 37);
            this.startTheTest.TabIndex = 0;
            this.startTheTest.Text = "Start the test";
            this.startTheTest.UseVisualStyleBackColor = true;
            this.startTheTest.Click += new System.EventHandler(this.startTheTest_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startTheTest);
            this.Name = "InitialForm";
            this.Text = "InitialForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startTheTest;
    }
}