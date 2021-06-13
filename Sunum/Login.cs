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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }




       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        UserManager _userManager = new UserManager(new EfUserDal());
        
        private void button1_Click(object sender, EventArgs e)
        {
            var result=_userManager.Login(textBox1.Text, textBox2.Text);
            if (result)
            {
                AnaForm ana = new AnaForm();
                ana.id= _userManager.get(textBox1.Text).Id;
                ana.Show();
                this.Hide();
                

            }
            else
            {
                MessageBox.Show("kullanıcı adı ve ya şifre hatalı");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
}
