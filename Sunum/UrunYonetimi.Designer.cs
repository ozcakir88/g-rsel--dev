
namespace Sunum
{
    partial class UrunYonetimi
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
            this.urunYonetimiPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.arabtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.fiyattxt = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.urunkodutxt = new System.Windows.Forms.TextBox();
            this.markatxt = new System.Windows.Forms.TextBox();
            this.stocktxt = new System.Windows.Forms.TextBox();
            this.kategoritxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eklebtn = new System.Windows.Forms.Button();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.urunYonetimiPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // urunYonetimiPanel
            // 
            this.urunYonetimiPanel.Controls.Add(this.panel5);
            this.urunYonetimiPanel.Controls.Add(this.dataGridView1);
            this.urunYonetimiPanel.Location = new System.Drawing.Point(12, 4);
            this.urunYonetimiPanel.Name = "urunYonetimiPanel";
            this.urunYonetimiPanel.Size = new System.Drawing.Size(683, 434);
            this.urunYonetimiPanel.TabIndex = 3;
            this.urunYonetimiPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.urunYonetimiPanel_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox8);
            this.panel5.Controls.Add(this.Sil);
            this.panel5.Controls.Add(this.guncellebtn);
            this.panel5.Controls.Add(this.eklebtn);
            this.panel5.Controls.Add(this.arabtn);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.checkBox1);
            this.panel5.Controls.Add(this.fiyattxt);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.urunkodutxt);
            this.panel5.Controls.Add(this.markatxt);
            this.panel5.Controls.Add(this.stocktxt);
            this.panel5.Controls.Add(this.kategoritxt);
            this.panel5.Controls.Add(this.nametxt);
            this.panel5.Location = new System.Drawing.Point(0, 219);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(683, 205);
            this.panel5.TabIndex = 3;
            // 
            // arabtn
            // 
            this.arabtn.Location = new System.Drawing.Point(11, 115);
            this.arabtn.Name = "arabtn";
            this.arabtn.Size = new System.Drawing.Size(75, 23);
            this.arabtn.TabIndex = 35;
            this.arabtn.Text = "ürün ara";
            this.arabtn.UseVisualStyleBackColor = true;
            this.arabtn.Click += new System.EventHandler(this.arabtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Stock Adedi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ürün kodu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Marka Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Kategori Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ürün adı";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(571, 119);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(51, 19);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Aktif";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // fiyattxt
            // 
            this.fiyattxt.Location = new System.Drawing.Point(350, 64);
            this.fiyattxt.Name = "fiyattxt";
            this.fiyattxt.Size = new System.Drawing.Size(100, 23);
            this.fiyattxt.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(350, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 20;
            // 
            // urunkodutxt
            // 
            this.urunkodutxt.Location = new System.Drawing.Point(571, 72);
            this.urunkodutxt.Name = "urunkodutxt";
            this.urunkodutxt.Size = new System.Drawing.Size(100, 23);
            this.urunkodutxt.TabIndex = 22;
            // 
            // markatxt
            // 
            this.markatxt.Location = new System.Drawing.Point(353, 24);
            this.markatxt.Name = "markatxt";
            this.markatxt.Size = new System.Drawing.Size(100, 23);
            this.markatxt.TabIndex = 23;
            // 
            // stocktxt
            // 
            this.stocktxt.Location = new System.Drawing.Point(571, 24);
            this.stocktxt.Name = "stocktxt";
            this.stocktxt.Size = new System.Drawing.Size(100, 23);
            this.stocktxt.TabIndex = 24;
            // 
            // kategoritxt
            // 
            this.kategoritxt.Location = new System.Drawing.Point(117, 64);
            this.kategoritxt.Name = "kategoritxt";
            this.kategoritxt.Size = new System.Drawing.Size(100, 23);
            this.kategoritxt.TabIndex = 25;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(117, 24);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 23);
            this.nametxt.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(683, 194);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eklebtn
            // 
            this.eklebtn.Location = new System.Drawing.Point(233, 119);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(75, 23);
            this.eklebtn.TabIndex = 36;
            this.eklebtn.Text = "ekle";
            this.eklebtn.UseVisualStyleBackColor = true;
            this.eklebtn.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // guncellebtn
            // 
            this.guncellebtn.Location = new System.Drawing.Point(351, 119);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(75, 23);
            this.guncellebtn.TabIndex = 37;
            this.guncellebtn.Text = "Güncelle";
            this.guncellebtn.UseVisualStyleBackColor = true;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(466, 119);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(75, 23);
            this.Sil.TabIndex = 38;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(117, 115);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 23);
            this.textBox8.TabIndex = 39;
            // 
            // UrunYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.urunYonetimiPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrunYonetimi";
            this.Text = "UrunYonetimi";
            this.Load += new System.EventHandler(this.UrunYonetimi_Load);
            this.urunYonetimiPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel urunYonetimiPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button arabtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox fiyattxt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox urunkodutxt;
        private System.Windows.Forms.TextBox markatxt;
        private System.Windows.Forms.TextBox stocktxt;
        private System.Windows.Forms.TextBox kategoritxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button guncellebtn;
        private System.Windows.Forms.Button eklebtn;
    }
}