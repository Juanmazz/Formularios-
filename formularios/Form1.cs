using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularios
{
    public partial class Form1 : Form
    {

        Form2 formu2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {

            formu2.Show();

        }

        private void btnocultar_Click(object sender, EventArgs e)
        {

            formu2.Hide();

        }
    }
}
