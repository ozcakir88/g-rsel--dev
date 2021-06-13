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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        Alisveris alisveris = new Alisveris();
        UserManager _userManager = new UserManager(new EfUserDal());
        public int id { get; set; }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            alisveris.id = id;

            label1.Text ="HosGeldin"+" "+_userManager.Get(id).UserName;
            formlar(alisveris);
        }

       
        void formlar(Form form)
        {

            bool durum = false;
            
            foreach (Form eleman in this.MdiChildren)
            {
              
                if (eleman.Text == form.Text) 
                {
                    durum = true; 
                    eleman.Activate(); 
                }
            }
            if (!durum) 
            {
                form.MdiParent = this;
                panel4.Controls.Clear();
                panel4.Controls.Add(form);
                form.Show();
                form.Dock = DockStyle.Fill;
                form.BringToFront();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunYonetimi urunYonetimi = new UrunYonetimi();

            formlar(urunYonetimi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formlar(alisveris);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            formlar(kategori);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            formlar(siparis);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet();
            sepet.userId = id;
            formlar(sepet);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
