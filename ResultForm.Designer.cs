namespace MbtiTest
{
    partial class ResultForm
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
            this.abbreviatureLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.colorBox1 = new System.Windows.Forms.PictureBox();
            this.colorBox2 = new System.Windows.Forms.PictureBox();
            this.colorBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // abbreviatureLabel
            // 
            this.abbreviatureLabel.AutoSize = true;
            this.abbreviatureLabel.Location = new System.Drawing.Point(127, 99);
            this.abbreviatureLabel.Name = "abbreviatureLabel";
            this.abbreviatureLabel.Size = new System.Drawing.Size(121, 16);
            this.abbreviatureLabel.TabIndex = 0;
            this.abbreviatureLabel.Text = "Abbreviature Label";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Location = new System.Drawing.Point(130, 169);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(569, 83);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description Label";
            // 
            // colorBox1
            // 
            this.colorBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.colorBox1.Location = new System.Drawing.Point(86, 335);
            this.colorBox1.Name = "colorBox1";
            this.colorBox1.Size = new System.Drawing.Size(100, 50);
            this.colorBox1.TabIndex = 2;
            this.colorBox1.TabStop = false;
            // 
            // colorBox2
            // 
            this.colorBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.colorBox2.Location = new System.Drawing.Point(353, 334);
            this.colorBox2.Name = "colorBox2";
            this.colorBox2.Size = new System.Drawing.Size(100, 50);
            this.colorBox2.TabIndex = 3;
            this.colorBox2.TabStop = false;
            // 
            // colorBox3
            // 
            this.colorBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.colorBox3.Location = new System.Drawing.Point(640, 334);
            this.colorBox3.Name = "colorBox3";
            this.colorBox3.Size = new System.Drawing.Size(100, 50);
            this.colorBox3.TabIndex = 4;
            this.colorBox3.TabStop = false;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorBox3);
            this.Controls.Add(this.colorBox2);
            this.Controls.Add(this.colorBox1);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.abbreviatureLabel);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label abbreviatureLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.PictureBox colorBox1;
        private System.Windows.Forms.PictureBox colorBox2;
        private System.Windows.Forms.PictureBox colorBox3;
    }
}