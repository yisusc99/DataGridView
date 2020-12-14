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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private int ids, cants;
        double pres;
        string noms, descs;
        public void Info(int id, string name, double precio, string descripcion, int cant) {
            lid.Text = "ID: " + id.ToString();
            
            nom.Text = name;
            pre.Text = precio.ToString();
            desc.Text = descripcion;
            can.Text = cant.ToString();

            ids = id;
            cants = cant;
            pres = precio;
            noms = name;
            descs = descripcion;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool salio = false;
            salio = Conexion.update(ids, noms, pres, cants, descs);
            if (salio == false)
            {
                MessageBox.Show("No se ha actualizado");
            }
            else {
                MessageBox.Show("Se ha actualizado el registro");
            }
        }
    }
}
