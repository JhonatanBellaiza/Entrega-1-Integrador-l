using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Ingreso_Universidad
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void validar_Click(object sender, EventArgs e)
        {
            /*
            String nombre = nombreComunidad.Text;
            String id = codigoComunidad.Text;
            String url = "C:\\Users\\Juan David\\source\\repos\\Entrega-1-Integrador-l\\Archivos\\" + nombre + ".txt";
            bool allow = (!(nombreComunidad.Text).Equals(String.Empty)) && (!(codigoComunidad.Text).Equals(String.Empty)) && (!(cargoComunidad.Text.Equals(String.Empty)));

            if (allow)
            {
                if (File.Exists(url))
                {
                    MessageBox.Show("Ya se encuentra registradol");
           
                }
                else
                {
                    File.WriteAllText(url, id);
                    MessageBox.Show("Registro exitoso");
                    nombreComunidad.Text = "";
                    codigoComunidad.Text = "";
                    cargoComunidad.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por completar");
            }
            */

            try
            {
                StreamWriter sw = new StreamWriter("..\\..\\Archivos.txt", true);
                bool allow = (!(nombreComunidad.Text).Equals(String.Empty)) && (!(codigoComunidad.Text).Equals(String.Empty)) && (!(cargoComunidad.Text.Equals(String.Empty)));

                if (allow)
                {
                    String nombre = nombreComunidad.Text;
                    String id = codigoComunidad.Text;
                    sw.WriteLine("Nombre: " + nombre);
                    sw.WriteLine("Codigo: " + id);
                    sw.WriteLine();
                    sw.Close();
                }
                else
                {
                    MessageBox.Show("Faltan datos por llenar");
                }
            }
            catch (Exception m)
            {
                Console.WriteLine("Exception: " + m.Message);
            }


        }

        private void reporteComunidad_Click(object sender, EventArgs e)
        {

            String line;
            try
            {
                StreamReader sr = new StreamReader("..\\..\\Archivos.txt");
                line = "";
                String acomul = "";

                while ((line = sr.ReadLine()) != null)
                {
                    acomul += line;
                }

                sr.Close();

                MessageBox.Show(acomul);
            }
            catch (Exception m)
            {
                Console.WriteLine("Exception: " + m.Message);
            }

        }
    }
}
