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
    public partial class UrunYonetimi : Form
    {
        public UrunYonetimi()
        {
            InitializeComponent();
        }

        private void urunYonetimiPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        ProductManager _productManager = new ProductManager(new EfProductDal());
        private void UrunYonetimi_Load(object sender, EventArgs e)
        {
            getir();
        }

        void getir()
        {
            dataGridView1.DataSource = _productManager.productDTO();
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productManager.GetByProductName(textBox8.Text);
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            _productManager.Add(new Entity.Concrete.Product
            {
                Name = nametxt.Text,
                CategoryId = Convert.ToInt32(kategoritxt.Text),
                BrandId = Convert.ToInt32(markatxt.Text),
                Code = urunkodutxt.Text,
                Price = Convert.ToInt32(fiyattxt.Text),
                Stock = Convert.ToInt32(stocktxt.Text),
                Active = checkBox1.Checked,
                CreateDate = DateTime.UtcNow
            });
            getir();

        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            _productManager.Update(new Entity.Concrete.Product
            {
                Id = productId,
                Name = nametxt.Text,
                CategoryId = Convert.ToInt32(kategoritxt.Text),
                BrandId = Convert.ToInt32(markatxt.Text),
                Code = urunkodutxt.Text,
                Price = Convert.ToInt32(fiyattxt.Text),
                Stock = Convert.ToInt32(stocktxt.Text),
                Active = checkBox1.Checked,
                CreateDate = DateTime.UtcNow
            }) ;
            getir();

        }

        private void Sil_Click(object sender, EventArgs e)
        {
            _productManager.Delete(new Entity.Concrete.Product
            {
                Id = productId
            }) ;
            getir();

        }
        int productId;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productId =Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value.ToString());
            kategoritxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nametxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            markatxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fiyattxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            stocktxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            urunkodutxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            checkBox1.Checked = dataGridView1.EndEdit();



        }
    }
}
