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
    public partial class Chi_Cudrada : Form
    {
        public Chi_Cudrada()
        {
            InitializeComponent();
        }
        int x = 1;
        double ValDeE, lie;
        double chi1, chi2, chi3, chi4, chi5, chi6, chi7, chi8, chi9, chi10, chiCal = 0;
        string ValValidado = "";
        int cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0, cont5 = 0, cont6 = 0, cont7 = 0, cont8 = 0, cont9 = 0, cont10 = 0;
        int i = 0;
        private String rutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "/Multiplicativo.csv";
        private String Archivo = AppDomain.CurrentDomain.BaseDirectory + "/Multiplicativo2.csv";
        char validacion;
        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Multiplicativo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random aleartorio = new Random();
                int m = 0, x = 0;
                double a = 0, k = 0;
                m = aleartorio.Next(1, 1000);
                a = aleartorio.Next(1, 1000);
                k = aleartorio.Next(1, 1000);
                x = aleartorio.Next(1, 1000);
                textBox3.Text = m.ToString();
                int l, d = 0, t;
                bool en = true;
                while (en)
                {
                    if (k % 2 == 0)
                    {
                        break;
                    }
                    else
                    {
                        k = aleartorio.Next(1, 1000);
                    }
                }
                textBox1.Text = k.ToString();
                if (a % 2 == 0)
                {
                    a = 3;
                }
                else
                {
                    a = 5;
                }
                textBox4.Text = a.ToString();
                if (a == 3)
                {
                    a = 3 + (8 * k);
                }
                else
                {
                    a = 5 + (8 * k);
                }
                string q = a.ToString();
                bool hol = true;
                while (hol)
                {
                    for (l = 1; l <= m; l++)
                    {
                        if (m % l == 0)
                        {
                            d = d + 1;
                        }
                    }
                    if (d > 2)
                    {
                        m = aleartorio.Next(1, 1000);
                        d = 0;
                    }
                    else
                    {
                        textBox3.Text = m.ToString();
                        break;
                    }
                }
                t = m;
                t--;
                for (int u = 1; u <= m; u++)
                {
                    if (t % 2 == 0 || t % 3 == 0 || t % 4 == 0 || t % 5 == 0 || t % 6 == 0 || t % 7 == 0 || t % 8 == 0 || t % 9 == 0 || t % 10 == 0)
                    {
                        u = 1;
                        if (t == 2 || t == 3 || t == 5 || t == 7)
                        {
                            break;
                        }
                        else
                        {
                            u = 1;
                        }
                    }
                    else
                    {
                        break;
                    }
                    if (t == 2)
                    {
                        break;
                    }
                    else
                    {
                        t--;
                    }
                }
                x = t;
                textBox2.Text = x.ToString();
                m = m - 1;
                double r = 1001, n;
                double g = 0;
                bool enc = true;
                i = 0;

                while (enc)
                {
                    int z = tablas.Rows.Add();
                    double p;
                    tablas.Rows[z].Cells[0].Value = i;
                    tablas.Rows[z].Cells[1].Value = q;
                    tablas.Rows[z].Cells[2].Value = x;
                    double w = a * x;
                    tablas.Rows[z].Cells[3].Value = w;
                    p = w % m;
                    tablas.Rows[z].Cells[4].Value = p;
                    tablas.Rows[z].Cells[5].Value = m;
                    x = Convert.ToInt32(p);
                    n = p / m;
                    tablas.Rows[z].Cells[6].Value = n;
                    StreamWriter writer = new StreamWriter(rutaArchivo, true);
                    writer.WriteLine(tablas.Rows[z].Cells[3].Value = +n);
                    writer.Close();
                    if (p == g)
                    {
                        MessageBox.Show("el valor de X(0) se a repetido");
                        break;
                    }
                    else
                    {
                        if (i == 1)
                        {
                            g = x;
                        }
                        r = x;
                    }
                    i++;
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int m = 0, x = 0;
            double a = 0, k = 0;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Igresa todos los valores para obtener resultados");
            }
            else
            {
                m = int.Parse(textBox3.Text);
                a = double.Parse(textBox4.Text);
                x = int.Parse(textBox2.Text);
                k = double.Parse(textBox1.Text);
                if (k % 2 == 0)
                {
                    int l, d = 0, t;
                    t = m;
                    textBox3.Text = m.ToString();
                    textBox1.Text = k.ToString();
                    textBox2.Text = x.ToString();
                    textBox4.Text = a.ToString();
                    if (a == 3)
                    {
                        a = 3 + (8 * k);
                    }
                    else
                    {
                        a = 5 + (8 * k);
                    }
                    string q = a.ToString();
                    for (l = 1; l <= m; l++)
                    {
                        if (m % l == 0)
                        {
                            d = d + 1;
                        }

                    }
                    if (d > 2)
                    {
                        string no = m.ToString();
                        lblms.Text = "m = " + no + " no es primo";
                    }
                    else
                    {
                        t = m;
                        t--;
                        for (int u = 1; u <= m; u++)
                        {
                            if (t % 2 == 0 || t % 3 == 0 || t % 4 == 0 || t % 5 == 0 || t % 6 == 0 || t % 7 == 0 || t % 8 == 0 || t % 9 == 0 || t % 10 == 0)
                            {
                                if (t % 2 == 0 || t % 3 == 0 || t % 4 == 0 || t % 5 == 0 || t % 6 == 0 || t % 7 == 0 || t % 8 == 0 || t % 9 == 0 || t % 10 == 0)
                                {
                                    u = 1;
                                    if (t == 2 || t == 3 || t == 5 || t == 7)
                                    {
                                        x = t;
                                        textBox2.Text = t.ToString();
                                        break;
                                    }
                                    else
                                    {
                                        u = 1;
                                    }
                                }
                                else if (t == 2 || t == 3 || t == 5 || t == 7)
                                {
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                break;
                            }
                            if (t == 2)
                            {
                                break;
                            }
                            t--;
                        }
                        if (x == t)
                        {
                            m = m - 1;
                            double r = 1001, n;
                            double g = 0;
                            bool enc = true;
                            i = 0;
                            while (enc)
                            {
                                int z = tablas.Rows.Add();
                                double p;
                                tablas.Rows[z].Cells[0].Value = i;
                                tablas.Rows[z].Cells[1].Value = q;
                                tablas.Rows[z].Cells[2].Value = x;
                                double w = a * x;
                                tablas.Rows[z].Cells[3].Value = w;
                                p = w % m;
                                tablas.Rows[z].Cells[4].Value = p;
                                tablas.Rows[z].Cells[5].Value = m;
                                x = Convert.ToInt32(p);
                                n = p / m;
                                tablas.Rows[z].Cells[6].Value = n;
                                StreamWriter writer = new StreamWriter(Archivo, true);
                                writer.WriteLine(tablas.Rows[z].Cells[3].Value = +n);
                                writer.Close();
                                if (p == g)
                                {
                                    MessageBox.Show("el valor de X(0) se a repetido");
                                    break;
                                }
                                else
                                {
                                    if (i == 1)
                                    {
                                        g = x;
                                    }
                                    r = x;
                                }
                                i++;
                            }

                        }
                        else
                        {
                            lblms.Text = "El valor que es  = " + x + " no es relativamente primo de m para que sea relativamente primo debe de ser " + t;
                        }
                    }
                }
                else
                {
                    lblms.Text = "el valor de k debe de ser numero par";
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete("Multiplicativo.csv");

                MessageBox.Show("Archivo Eliminado");
            }
            catch
            {
                MessageBox.Show("No puedes eliminar no hay archivo!!");
            }
        }

        private void btnCalcularChi_Click(object sender, EventArgs e)
        {
           
           ValDeE = Math.Sqrt(x);
            StreamReader lier = new StreamReader(rutaArchivo, true);
            StreamReader end = new StreamReader(Archivo,true);
            lier.ReadToEnd();
            while ((ValValidado = lier.ReadLine()) != null)
            {
                lie = Convert.ToDouble(ValValidado);
                if (lie >= 0.00 && lie <= 0.10)
                {
                    cont1 = cont1 + 1;
                }
                else if (lie >= 0.10 && lie <= 0.20)
                {
                    cont2 = cont2 + 1;
                }
                else if (lie >= 0.20 && lie <= 0.30)
                {
                    cont3 = cont3 + 1;
                }
                else if (lie >= 0.30 && lie <= 0.40)
                {
                    cont4 = cont4 + 1;
                }
                else if (lie >= 0.40 && lie <= 0.50)
                {
                    cont5 = cont5 + 1;
                }
                else if (lie >= 0.50 && lie <= 0.60)
                {
                    cont6 = cont6 + 1;
                }
                else if (lie >= 0.60 && lie <= 0.70)
                {
                    cont7 = cont7 + 1;
                }
                else if (lie >= 0.70 && lie <= 0.80)
                {
                    cont8 = cont8 + 1;
                }
                else if (lie >= 0.80 && lie <= 0.90)
                {
                    cont9 = cont9 + 1;
                }
                else if (lie >= 0.90 && lie <= 1)
                {
                    cont10 = cont10 + 1;
                }
            }
            chi1 = (Math.Pow((ValDeE - cont1), 2)) /ValDeE;
            chi2 = (Math.Pow((ValDeE - cont2), 2)) /ValDeE;
            chi3 = (Math.Pow((ValDeE - cont3), 2)) /ValDeE;
            chi4 = (Math.Pow((ValDeE - cont4), 2)) /ValDeE;
            chi5 = (Math.Pow((ValDeE - cont5), 2)) /ValDeE;
            chi6 = (Math.Pow((ValDeE - cont6), 2)) /ValDeE;
            chi7 = (Math.Pow((ValDeE - cont7), 2)) /ValDeE;
            chi8 = (Math.Pow((ValDeE - cont8), 2)) /ValDeE;
            chi9 = (Math.Pow((ValDeE - cont9), 2)) /ValDeE;
            chi10 = (Math.Pow((ValDeE - cont10), 2)) /ValDeE;

            chiCal = chi1 + chi2 + chi3 + chi4 + chi5 + chi6 + chi7 + chi8 + chi9 + chi10;
            if (chiCal == x)
            {
                MessageBox.Show("Hipotesis Aceptada");
            }
            else
            {
                MessageBox.Show("Hipotesis Rechazada");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tablas.Rows.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            lblms.Text = "";
        }
    }
}
