using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class UI_Main : Form
    {
        public UI_Main()
        {
            InitializeComponent();
        }

        private void btnDataType_Click(object sender, EventArgs e)
        {
            var frmDataType = new UI_DataType();
            frmDataType.Show();
            Hide();

        }

        private void btnControlFlow_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerics_Click(object sender, EventArgs e)
        {

        }

        private void btnInterface_Click(object sender, EventArgs e)
        {

        }

        private void btnEncapsulation_Click(object sender, EventArgs e)
        {

        }

        private void btnPolymorphism_Click(object sender, EventArgs e)
        {

        }
    }
}
