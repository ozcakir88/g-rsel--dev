
namespace Sunum
{
    partial class Kategori
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Eklebtn = new System.Windows.Forms.Button();
            this.guncellebtb = new System.Windows.Forms.Button();
            this.Silbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(658, 207);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "kategori adı";
            // 
            // Eklebtn
            // 
            this.Eklebtn.Location = new System.Drawing.Point(239, 242);
            this.Eklebtn.Name = "Eklebtn";
            this.Eklebtn.Size = new System.Drawing.Size(93, 23);
            this.Eklebtn.TabIndex = 3;
            this.Eklebtn.Text = "Ekle";
            this.Eklebtn.UseVisualStyleBackColor = true;
            this.Eklebtn.Click += new System.EventHandler(this.Eklebtn_Click);
            // 
            // guncellebtb
            // 
            this.guncellebtb.Location = new System.Drawing.Point(359, 241);
            this.guncellebtb.Name = "guncellebtb";
            this.guncellebtb.Size = new System.Drawing.Size(93, 23);
            this.guncellebtb.TabIndex = 4;
            this.guncellebtb.Text = "güncelle";
            this.guncellebtb.UseVisualStyleBackColor = true;
            this.guncellebtb.Click += new System.EventHandler(this.guncellebtb_Click);
            // 
            // Silbtn
            // 
            this.Silbtn.Location = new System.Drawing.Point(468, 241);
            this.Silbtn.Name = "Silbtn";
            this.Silbtn.Size = new System.Drawing.Size(93, 23);
            this.Silbtn.TabIndex = 5;
            this.Silbtn.Text = "Sil";
            this.Silbtn.UseVisualStyleBackColor = true;
            this.Silbtn.Click += new System.EventHandler(this.Silbtn_Click);
            // 
            // Kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 318);
            this.Controls.Add(this.Silbtn);
            this.Controls.Add(this.guncellebtb);
            this.Controls.Add(this.Eklebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kategori";
            this.Text = "Kategori";
            this.Load += new System.EventHandler(this.Kategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Eklebtn;
        private System.Windows.Forms.Button guncellebtb;
        private System.Windows.Forms.Button Silbtn;
    }
}