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

    public partial class show_maneom : UserControl
    {
   
        public Form1 PF { get; set; }
        int count_id;
        int total = 0; 
        public show_maneom()
        {
            InitializeComponent();
        }

        private void show_maneom_Load(object sender, EventArgs e)
        {
        }

        public void GetTotal()
        {
            int total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells["Name_"].Value != null)
                {
                    total += Convert.ToInt32(dataGridView1.Rows[i].Cells["price_"].Value) +
                             Convert.ToInt32(dataGridView1.Rows[i].Cells["quantity_"].Value);
                }
            }
            if (PF != null)
            {
                PF.SetTotal(total);
            }
        }

        public void add2(string name, int price)
        {
            
            dataGridView1.Rows.Add(count_id++, name, price, 1);
            GetTotal(); 
        }

    } 
}
