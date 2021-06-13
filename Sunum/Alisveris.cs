using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
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
    public partial class Alisveris : Form
    {
        public Alisveris()
        {
            InitializeComponent();
        }
        ProductManager _productManager = new ProductManager(new EfProductDal());
        BasketManager _basketManager = new BasketManager(new EfBasketDal());

        public int id { get; set; }
        private void Alisveris_Load(object sender, EventArgs e)
        {
            label1.Text = "secilen ürün";
            label3.Text = sepettekiurunler().ToString();
            dataGridView1.DataSource = _productManager.productDTO();
         
        }
        int sepettekiurunler()
        {
            
            return _basketManager.GetAll(id).Count;

        }
        private void sepetbtn_Click(object sender, EventArgs e)
        {

            _basketManager.Add(new Basket
            {
                ProductId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                UserId =id,
                Count=1,
                CreateDate=DateTime.UtcNow,
                Active=true
            }) ;
            label3.Text = sepettekiurunler().ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
