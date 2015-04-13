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
    public partial class UI_DataType : Form
    {
        public UI_DataType()
        {
            InitializeComponent();
        }

        private void lblHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frmHome = new UI_Main();
            frmHome.Show();
            Hide();
        }
    }
}
