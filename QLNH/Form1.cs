using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {



           monan frm2 = new monan();
            frm2.TopLevel = false;
            backgroud.Controls.Add(frm2);
            
            
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
            frm2.Dock = DockStyle.Fill;
            frm2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            trangchu frm2 = new trangchu();
            frm2.TopLevel = false;
            backgroud.Controls.Add(frm2);


            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
