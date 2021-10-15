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
    public partial class cuadradomedios : Form
    {
        private String rutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "/info.csv";
        double Cuadradomedio = 0;
        double semilla, cantidad, pesoSemilla;
        String Random;
        public cuadradomedios()
        {
            InitializeComponent();
            limpiarEspacios();
        }

        private void cuadradomedios_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                pesoSemilla = int.Parse(tbx1.Text);
                if (pesoSemilla ==4) { 
                semilla = int.Parse(tbx.Text); 
                cantidad = int.Parse(tbx3.Text);
                    if (int.Parse(tbx1.Text) == 3 || int.Parse(tbx1.Text) == 4)
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            int datos = tablas.Rows.Add();
                            Cuadradomedio = semilla * semilla;
                            int res;
                            int a = Convert.ToInt32(Cuadradomedio);
                            int n = a; int cont = 0;
                            while (n > 0)
                            {
                                res = n % 10;
                                cont++;
                                n = n / 10;
                            }
                            string s = cont.ToString();
                            double equi = double.Parse(s);
                            if (equi % 2 == 0)
                            {
                                if (equi == 6)
                                { tablas.Rows[datos].Cells[0].Value = semilla;
                                    string conv = Cuadradomedio.ToString();
                                    pesoSemilla = double.Parse(conv);
                                    string num_Semillas;
                                    num_Semillas = Convert.ToString(pesoSemilla);
                                    Random = num_Semillas.Substring(1, 4);
                                    semilla = Convert.ToInt32(Random);
                                    tablas.Rows[datos].Cells[1].Value = Cuadradomedio.ToString(); ;
                                    tablas.Rows[datos].Cells[2].Value = Random;
                                    tablas.Rows[datos].Cells[3].Value = "0." + Random;
                                    StreamWriter writer = new StreamWriter(rutaArchivo, true);
                                    writer.WriteLine(tablas.Rows[datos].Cells[3].Value = "0." + Random);
                                    writer.Close();
                                }
                                else
                                {tablas.Rows[datos].Cells[0].Value = semilla;
                                    string num_Semillas;
                                    num_Semillas = Convert.ToString(Cuadradomedio);
                                    Random = num_Semillas.Substring(2, 4);
                                    semilla = Convert.ToInt32(Random);
                                    tablas.Rows[datos].Cells[1].Value = Cuadradomedio.ToString(); ;
                                    tablas.Rows[datos].Cells[2].Value = Random;
                                    tablas.Rows[datos].Cells[3].Value = "0." + Random;
                                    StreamWriter writer = new StreamWriter(rutaArchivo, true);
                                    writer.WriteLine(tablas.Rows[datos].Cells[3].Value = "0." + Random);
                                    writer.Close();
                                }
                            }
                            else if (equi % 2 > 0)
                            {
                                if (equi == 5)
                                { tablas.Rows[datos].Cells[0].Value = semilla;
                                    string conv = Cuadradomedio.ToString();
                                    pesoSemilla = double.Parse(conv);
                                    string num_Semillas;
                                    num_Semillas = Convert.ToString(pesoSemilla);
                                    Random = num_Semillas.Substring(0, 4);
                                    semilla = Convert.ToInt32(Random);                                   
                                    tablas.Rows[datos].Cells[1].Value = Cuadradomedio.ToString(); ;
                                    tablas.Rows[datos].Cells[2].Value = Random;
                                    tablas.Rows[datos].Cells[3].Value = "0." + Random;
                                    StreamWriter writer = new StreamWriter(rutaArchivo, true);
                                    writer.WriteLine(tablas.Rows[datos].Cells[3].Value = "0." + Random);
                                    writer.Close();
                                }
                                else
                                {tablas.Rows[datos].Cells[0].Value = semilla;
                                    string conv = Cuadradomedio.ToString();
                                    pesoSemilla = double.Parse(conv);
                                    string num_Semillas;
                                    num_Semillas = Convert.ToString(pesoSemilla);
                                    Random = num_Semillas.Substring(1, 4);
                                    semilla = Convert.ToInt32(Random);                                   
                                    tablas.Rows[datos].Cells[1].Value = Cuadradomedio.ToString();
                                    tablas.Rows[datos].Cells[2].Value = Random;
                                    tablas.Rows[datos].Cells[3].Value = "0." + Random;
                                    StreamWriter writer = new StreamWriter(rutaArchivo, true);
                                    writer.WriteLine(tablas.Rows[datos].Cells[3].Value = "0." + Random);
                                    writer.Close();
             //                       MessageBox.Show("Aviso" + "Semilla de 4 digitos");
                                }
                            }
                        }
                    }
                }else if(pesoSemilla == 3)
                {
                    semilla = int.Parse(tbx.Text);
                    cantidad = int.Parse(tbx3.Text);
                    if (int.Parse(tbx1.Text) == 3 || int.Parse(tbx1.Text) == 4)
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            int datos = tablas.Rows.Add();
                            Cuadradomedio = semilla * semilla;
                            int res;
                            int a = Convert.ToInt32(Cuadradomedio);
                            int n = a; int cont = 0;
                            while (n > 0)
                            {
                                res = n % 10;
                                cont++;
                                n = n / 10;
                            }
                            string s = cont.ToString();
                            double equi = double.Parse(s);
                            if (equi % 2 == 0)
                            {
                                if (equi == 6)
                                {tablas.Rows[datos].Cells[0].Value = semilla;
                                    string conv = Cuadradomedio.ToString();
                                    pesoSemilla = double.Parse(conv);
                                    string num_Semillas;
                                    num_Semillas = Convert.ToString(pesoSemilla);
                                    Random = num_Semillas.Substring(1, 3);
                                    semilla = Convert.ToInt32(Random);
                                    tablas.Rows[datos].Cells[1].Value = Cuadradomedio.ToString(); ;
                                    tablas.Rows[datos].Cells[2].Value = Random;
                                    tablas.Rows[datos].Cells[3].Value = "0." + Random;
                                    StreamWriter writer = new StreamWriter(rutaArchivo, true);
                                    writer.WriteLine(tablas.Rows[datos].Cells[3].Value = "0." + Random);
                                    writer.Close();
                                }
                                else
                                { tablas.Rows[datos].Cells[0].Value = semilla;
                                    string num_Semillas;
                                    num_Semillas = Convert.ToString(Cuadradomedio);
                                    Random = num_Semillas.Substring(0, 3);
                                    semilla = Convert.ToInt32(Random);
                                    tablas.Rows[datos].Cells[1].Value = Cuadradomedio.ToString(); ;
                                    tablas.Rows[datos].Cells[2].Value = Random;
                                    tablas.Rows[datos].Cells[3].Value = "0." + Random;
                                    StreamWriter writer = new StreamWriter(rutaArchivo, true);
                                    writer.WriteLine(tablas.Rows[datos].Cells[3].Value = "0." + Random);
                                    writer.Close();
                                }
                            }
                            else if (equi % 2 > 0)
                            {
                                if (equi == 5)
                                {tablas.Rows[datos].Cells[0].Value = semilla;
                                    string conv = Cuadradomedio.ToString();
                                    pesoSemilla = double.Parse(conv);
                                    string num_Semillas;
                                    num_Semillas = Convert.ToString(pesoSemilla);
                                    Random = num_Semillas.Substring(1, 3);
                                    semilla = Convert.ToInt32(Random);                                   
                                    tablas.Rows[datos].Cells[1].Value = Cuadradomedio.ToString(); ;
                                    tablas.Rows[datos].Cells[2].Value = Random;
                                    tablas.Rows[datos].Cells[3].Value = "0." + Random;
                                    StreamWriter writer = new StreamWriter(rutaArchivo, true);
                                    writer.WriteLine(tablas.Rows[datos].Cells[3].Value = "0." + Random);
                                    writer.Close();
               //                     MessageBox.Show("Aviso" + "Semilla de 3 digitos");
                                }                              
                            }
                        }
                    }
                }
            }
            catch
            {
                //MessageBox.Show("Error semillas no generadas, o las semillas pasan con su numero de interacion");
            } 
        }
        private void tbx_TextChanged(object sender, EventArgs e)
        {   
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete("info.csv");
                MessageBox.Show("Archivo con las semillas random eliminado!!!");
            }
            catch 
            {
                MessageBox.Show("No puedes eliminar no hay archivo!!");
            }
        }

      
        private void tbx_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnLmtablas_Click(object sender, EventArgs e)
        {
            tablas.Rows.Clear();
        }

        private void tbx1_Leave_1(object sender, EventArgs e)
        {
            try
            {
                if (tbx1.Text == "3" || tbx1.Text == "4")
                {
                    errorProvider1.SetError(tbx1, "");
                }
                else
                {
                    errorProvider1.SetError(tbx1, "T tiene que ser 3 o 4");
                    tbx1.Focus();
                }
            }
            catch
            {

            }
        }

        private void tbx_Leave_1(object sender, EventArgs e)
        {
            try
            {
                if (tbx.Text.Length < 3 || tbx.Text.Length > 4)
                {
                    errorProvider1.SetError(tbx, "La semilla tiene que tener 3 o 4 digitos");
                    tbx.Focus();
                }
                else
                {
                    errorProvider1.SetError(tbx, "");
                }

            }
            catch
            {

            }
        }

        private void limpiarEspacios()
        {
            tbx1.Text = "";
            tbx.Text = "";
            tbx3.Text = "";
          
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarEspacios();
          
        }
    }
}