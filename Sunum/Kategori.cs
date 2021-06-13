using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunum
{
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }
        CategoryManager _categoriManager = new CategoryManager(new EFCategoryDal());
        private void Kategori_Load(object sender, EventArgs e)
        {
            getir();
        }
        void getir()
        {
            dataGridView1.DataSource = _categoriManager.GetAll();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kategoriId =Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void Eklebtn_Click(object sender, EventArgs e)
        {
            _categoriManager.Add(new Entity.Concrete.Category
            {
                CategoryName = textBox1.Text,
                CreateDate=DateTime.UtcNow,
                Active=true
            });
            getir();
        }
        int kategoriId;
        private void guncellebtb_Click(object sender, EventArgs e)
        {
            _categoriManager.Uptade(new Entity.Concrete.Category
            {
                Id=kategoriId,
                CategoryName = textBox1.Text,
                CreateDate = DateTime.UtcNow,
                Active = true
            });
            getir();
        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
            _categoriManager.Delete(new Entity.Concrete.Category
            {
                Id = kategoriId,
                
            });
            getir();
        }
    }
}
