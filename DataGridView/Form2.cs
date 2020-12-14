using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Conexion.create(nom.Text, Convert.ToDouble(pre.Text), Convert.ToInt32(cant.Text), desc.Text) == true)
            {
                MessageBox.Show("Se ha creado el producto");
            }
            else {
                MessageBox.Show("No se ha creado el producto");

            }

        }
    }
}
