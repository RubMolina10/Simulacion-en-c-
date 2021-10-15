using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion_Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnMedios_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Hide();
            this.Hide();
            this.Hide();
            cuadradomedios cm = new cuadradomedios();
            cm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Doble_Semilla ds = new Doble_Semilla();
            ds.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LinealV1 v = new LinealV1();
            v.Show();
            /*this.Hide();
            Lineal m = new Lineal();
            m.Show();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Multiplicativo ml = new Multiplicativo();
            ml.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chi_Cudrada ch = new Chi_Cudrada();
                ch.Show();

        }
    }
}
