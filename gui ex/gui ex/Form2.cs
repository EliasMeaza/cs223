using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            propertis p=new propertis();
            p.number = int.Parse(txt_number.Text);
            p.date = txt_number.Text;
            p.sku = int.Parse(txt_sku.Text);
            p.item_name= txt_itemname.Text;
            p.quantity = int.Parse(txt_quantity.Text);
            p.price = double.Parse(txt_price.Text);
            

            p.save();
            MessageBox.Show($"the item {p.item_name} is saved");
        }
    }
}
