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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void OpenForm(object formhijo)
        {
            if (this.Dock.Controls.Count > 0)
            {
                this.Dock.Controls.RemoveAt(0);
            }
            Form fhj = formhijo as Form;
            fhj.TopLevel = false;
            fhj.Dock = DockStyle.Fill;
            this.Dock.Controls.Add(fhj);
            this.Dock.Tag = fhj;
            fhj.Show();


        }

        private void Cre_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            OpenForm(a);
        }

        private void Re_Click(object sender, EventArgs e)
        {
           
            ActualizarTabla();
        }
        public delegate void Envia(int id, string name, double precio, string descripcion, int cant);
        public event Envia recibe;
        private void Upd_Click(object sender, EventArgs e)
        {
            int ids = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string desc = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            double precio = Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value);
            int can = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            

            Form3 a = new Form3();
            recibe += new Form1.Envia(a.Info);
            OpenForm(a);
            recibe(ids, name, precio, desc, can);
        }
        public void ActualizarTabla() {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = Conexion.Read();
        }
        private void Del_Click(object sender, EventArgs e)
        {
            bool del = false;
            del = Conexion.delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            if (del == true)
            {
                MessageBox.Show("Se borro el registro");
                ActualizarTabla();
            }
            else {
                MessageBox.Show("No se ha borrado el registro");
            }
        }
    }
}
