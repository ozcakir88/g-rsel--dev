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
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
        }

        OrderManager _orderManager = new OrderManager(new OrderDal());
        private void Siparis_Load(object sender, EventArgs e)
        {
            getir();
            textBox1.Enabled = false;

        }
        void getir()
        {
            dataGridView1.DataSource = _orderManager.GetAll();
        }
        private void guncellebtn_Click(object sender, EventArgs e)
        {
            _orderManager.Update(new Entity.Concrete.Order
            {
                Id = Convert.ToInt32(textBox1.Text),
                Active = checkBox1.Checked

            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getir();
        }
    }
}
