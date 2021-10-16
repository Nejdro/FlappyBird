using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
