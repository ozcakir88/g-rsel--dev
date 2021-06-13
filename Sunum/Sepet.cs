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
    public partial class Sepet : Form
    {
        public Sepet()
        {
            InitializeComponent();
        }
        BasketManager _basketManager = new BasketManager(new EfBasketDal());
        OrderManager _orderManager = new OrderManager(new OrderDal());
        AdressManager _adresManager = new AdressManager(new EfAdressDal());
        public int userId { get; set; }
        private void Sepet_Load(object sender, EventArgs e)
        {
            getir();
            
            foreach (var item in _adresManager.GetAll(userId))
            {
                comboBox1.Items.Add(item.AdresText);
            }

         
           
            panel1.Enabled = false;
            panel1.Visible = false;
        }
        void getir()
        {
            dataGridView1.DataSource = _basketManager.GetAll();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _orderManager.Add(new Entity.Concrete.Order
            {
                UserId = userId,
                AdressId = Convert.ToInt32(_adresManager.Get(comboBox1.Text).Id),
                OrderStatusId = 1,
                Count = 1,
                Active = true,
                CreateDate = DateTime.UtcNow
            });
            _basketManager.Delete(new Entity.Concrete.Basket
            {
                Id = Convert.ToInt32(textBox1.Text)
            });
            getir();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _adresManager.Add(new Entity.Concrete.Adress
            {
                AdresText = textBox4.Text,
                CityName = textBox3.Text,
                CountryName = textBox2.Text,
                UserId = userId,
                Active = true,
                CreateDate = DateTime.UtcNow
            });
            foreach (var item in _adresManager.GetAll(userId))
            {
                comboBox1.Items.Add(item.AdresText);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _basketManager.GetById(Convert.ToInt32(textBox1.Text));
            getir();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel1.Visible = false;
        }
    }
}
