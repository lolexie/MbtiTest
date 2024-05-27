namespace MbtiTest
{
    partial class CatalogForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.psychotype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.psychotype,
            this.color1,
            this.color2,
            this.color3});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(1, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DividerHeight = 5;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(667, 495);
            this.dataGridView1.TabIndex = 0;
            // 
            // psychotype
            // 
            this.psychotype.HeaderText = "Психотип";
            this.psychotype.MinimumWidth = 6;
            this.psychotype.Name = "psychotype";
            this.psychotype.ReadOnly = true;
            this.psychotype.Width = 125;
            // 
            // color1
            // 
            this.color1.HeaderText = "";
            this.color1.MinimumWidth = 6;
            this.color1.Name = "color1";
            this.color1.ReadOnly = true;
            this.color1.Width = 125;
            // 
            // color2
            // 
            this.color2.HeaderText = "";
            this.color2.MinimumWidth = 6;
            this.color2.Name = "color2";
            this.color2.ReadOnly = true;
            this.color2.Width = 125;
            // 
            // color3
            // 
            this.color3.HeaderText = "";
            this.color3.MinimumWidth = 6;
            this.color3.Name = "color3";
            this.color3.ReadOnly = true;
            this.color3.Width = 125;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 632);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CatalogForm";
            this.Text = "CatalogForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn psychotype;
        private System.Windows.Forms.DataGridViewTextBoxColumn color1;
        private System.Windows.Forms.DataGridViewTextBoxColumn color2;
        private System.Windows.Forms.DataGridViewTextBoxColumn color3;
    }
}