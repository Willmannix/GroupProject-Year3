using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_interface
{
    public partial class formEQuantity : Form
    {
        public string qty { get; set; }
        public formEQuantity()
        {
            InitializeComponent();
        }



        private void formEQuantity_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.qty = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
