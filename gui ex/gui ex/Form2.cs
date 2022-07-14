using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_ex
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"[a-z]{3}$");

            if (string.IsNullOrEmpty(txt_price .Text))
            {
              
                error1.SetError(txt_itemname, "price  is required");
            }
            
             else if (reg.IsMatch(txt_itemname.Text))
            {
                error1.Clear();
                propertis p = new propertis();
                try
                {
                    p.number = int.Parse(txt_number.Text);
                    p.quantity = int.Parse(txt_quantity.Text);
                    p.sku = int.Parse(txt_sku.Text);
                    p.price = double.Parse(txt_price.Text);
                }
                catch
                {

                }
                p.date = txt_number.Text;

                p.item_name = txt_itemname.Text;



                p.save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = propertis.GetAllProp();
                MessageBox.Show($"the item {p.item_name} is saved");
                

            }
            else
            {

            }
          
        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {
            
        }

       
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
