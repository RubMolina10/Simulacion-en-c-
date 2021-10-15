using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Simulacion_Proyecto
{

    public partial class LinealV1 : Form
    {
        private String rutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "/lineal.csv";

        int iN;
        public LinealV1()
        {
            InitializeComponent();
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {

        }

        private void TbX0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Favor de ingresar solo numeros mayores o iguales a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void TbA_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TbC_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TbM_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void LinealV1_Load(object sender, EventArgs e)
        {
           
        }

        private void btCalcular_Click_1(object sender, EventArgs e)
        {

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click_2(object sender, EventArgs e)
        {
            try
            {

                double X0 = int.Parse(tbX0.Text);
                double A = int.Parse(tbA.Text);
                double C = int.Parse(tbC.Text);
                double M = int.Parse(tbM.Text);
                double iteraciones = int.Parse(tbIteraciones.Text);
                if (X0 > 0 && A > 0 && C > 0 && M > X0 && M > A)
                {



                    for (int i = 0; i <= iteraciones; i++)
                    {
                        iN = tablas.Rows.Add();
                        double C2 = (X0 * A) + C;
                        double C3 = ((X0 * A) + C) % M;
                        double random = (double)C3 / M;
                        tablas.Rows[iN].Cells[0].Value = i;
                        tablas.Rows[iN].Cells[1].Value = X0;
                        tablas.Rows[iN].Cells[2].Value = C2;
                        tablas.Rows[iN].Cells[3].Value = C3;
                        tablas.Rows[iN].Cells[4].Value = random;
                        StreamWriter writer = new StreamWriter(rutaArchivo, true);
                        writer.WriteLine(tablas.Rows[iN].Cells[4].Value = random);
                        writer.Close();
                        X0 = Convert.ToInt32(C3);
                       

                    } }
                else
                {
                    estado.Text = "No se puede insertar un numero menor en M";
                }
            }
            catch
            {

            }
        }
      
        private void btLimpiar_Click_1(object sender, EventArgs e)
        {
            tbX0.Text = "";
            tbA.Text = "";
            tbC.Text = "";
            tbM.Text = "";
            tbIteraciones.Text = "";
            estado.Text = "";

        }

        private void btnLimpiarT_Click(object sender, EventArgs e)
        {
            tablas.Rows.Clear();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void tbA_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Favor de ingresar solo numeros mayores o iguales a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void tbC_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbM_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Favor de ingresar un valor mayor que: X0, A y C", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void tbC_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Favor de ingresar solo numeros mayores o iguales a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void tbX0_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Favor de ingresar solo numeros mayores o iguales a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            btCalcular.Enabled = false;
           btnAuto.Enabled = false;
            tbX0.Enabled = false;
            tbA.Enabled = false;
            tbC.Enabled = false;
            tbM.Enabled = false;
            tbIteraciones.Enabled = false;
            btnAuto.Enabled = false;
            tablas.Rows.Clear();
            MessageBox.Show("M Siempre tiene que ser mayor que Xn porque si es menor no genera");
            Random rn = new Random();
            double xo = rn.Next(1, 1000);
            double a = rn.Next(1, 1000);
            double c = 0;
            double m = rn.Next(1, 1000);
            while (true)
            {
                while (true)
                {
                    if (a % 2 != 0)
                    {
                        if (a % 3 != 0 && a % 5 != 0)
                        {
                            break;
                        }

                    }
                    a = rn.Next(1, 1000);
                }
                while (true)
                {
                    if (m > xo && m > a && m > c)
                    {
                        break;
                    }
                    m = rn.Next(1, 1000);
                }
                int n = 0;

                for (int i = 1; i < (m + 1); i++)
                {
                    if (m % i == 0)
                    {
                        n++;
                    }
                }
                if (n == 2)
                {
                    break;
                }
                m = rn.Next(1, 1000);
            }
            c = m - 1;
            while (true)
            {
                int t = 0;
                for (int i = 1; i < (c + 1); i++)
                {
                    if (c % i == 0)
                    {
                        t++;
                    }
                }
                if (t == 2)
                {
                    break;
                }
                c = c - 1;
            }

            tbX0.Text = xo.ToString();
            tbA.Text = a.ToString();
            tbC.Text = c.ToString();
            tbM.Text = m.ToString();
            double xn = xo;
            double aux = 0;
            double aux2 = 0;
            double xi;

            while (true)
            {
                tablas.Rows.Add();
                tablas.Rows[iN].Cells[0].Value = iN + 1;
                tablas.Rows[iN].Cells[1].Value = xn;
                aux = (a * xn) + c;
                tablas.Rows[iN].Cells[2].Value = aux;
                aux2 = aux % m;
                tablas.Rows[iN].Cells[3].Value = aux2;
                xi = xn / m;
                tablas.Rows[iN].Cells[4].Value = xi;
                StreamWriter writer = new StreamWriter(rutaArchivo, true);
                writer.WriteLine(tablas.Rows[iN].Cells[4].Value = xi);
                writer.Close();
                if (aux2 == xo)
                {
                    break;
                }
                xn = aux2;
                iN++;
                 
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            btCalcular.Enabled = true;
            tbX0.Enabled = true;
            tbA.Enabled = true;
            tbC.Enabled = true;
            tbM.Enabled = true;
            tbIteraciones.Enabled = true;
            btnAuto.Enabled = true;
            tablas.Rows.Clear();
            tbX0.Text = "";
            tbA.Text = "";
            tbC.Text = "";
            tbM.Text = "";
            tbIteraciones.Text = "";
            estado.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete("lineal.csv");
                MessageBox.Show("Archivo con las semillas random eliminado!!!");
            }
            catch
            {
                MessageBox.Show("No puedes eliminar no hay archivo!!");
            }
        }
    }
}
