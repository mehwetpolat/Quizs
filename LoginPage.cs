using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizcim
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin")
            {
                if (textBox2.Text == "0000")
                {
                    this.Hide();

                    CreateQuizPage cq1 = new CreateQuizPage();
                    cq1.Show();
                }

            }

            



            
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {

        }

        private void Login_Page_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
