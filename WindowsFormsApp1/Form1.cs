using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        show_maneom myMan = new show_maneom(); 

        public Form1()
        {
            InitializeComponent();
        }

       
        public void SetTotal(int z)
        {
            total_ll.Text = z.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panl_showfod.Controls.Clear(); 

            sandosh1 a = new sandosh1(myMan);
            a.Dock = DockStyle.Fill;
            panl_showfod.Controls.Add(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panl_showfod.Controls.Clear();
            وجبات a = new وجبات();
            a.Dock = DockStyle.Fill;
            panl_showfod.Controls.Add(a);
        }

     
        private void button3_Click(object sender, EventArgs e)
        {
            panl_showfod.Controls.Clear();
            مقبلات a = new مقبلات();
            a.Dock = DockStyle.Fill;
            panl_showfod.Controls.Add(a);
        }

     
        private void button4_Click(object sender, EventArgs e)
        {
            panl_showfod.Controls.Clear();
            مشروبات a = new مشروبات();
            a.Dock = DockStyle.Fill;
            panl_showfod.Controls.Add(a);
        }

    
        private void button5_Click(object sender, EventArgs e)
        {
            panl_showfod.Controls.Clear(); 
         
            مقبلات a = new مقبلات();
            a.Dock = DockStyle.Fill;
            panl_showfod.Controls.Add(a);
        }

        private void panel_intr_food_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}       