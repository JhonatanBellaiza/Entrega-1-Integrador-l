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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void val_Click(object sender, EventArgs e)
        {
            /*
            String nombre = nombreVisitante.Text;
            String id = identificacionVisitante.Text;
            //String url = "C:\\Users\\Juan David\\source\\repos\\Entrega-1-Integrador-l\\Archivos\\" + nombre + ".txt";
            String url = "\\Archivos\\" + nombre + ".txt";

            bool allowed = (!(nombreVisitante.Text.Equals(String.Empty))) && (!(identificacionVisitante.Text.Equals(String.Empty))) && (!(edadVisitante.Text.Equals(String.Empty))) && (!(motivoVisitante.Text.Equals(String.Empty)));

            if (allowed)
            {
                if (File.Exists(url))
                {
                    MessageBox.Show("Ya estas registrado");
                }
                else
                {
                    File.WriteAllText(url, id);
                    MessageBox.Show("Registro exitoso");
                    nombreVisitante.Text = "";
                    identificacionVisitante.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Faltan Datos");
            }
            */

            try
            {
                StreamWriter sw = new StreamWriter("..\\..\\Archivos.txt", true);

                bool allowed = (!(nombreVisitante.Text.Equals(String.Empty))) && (!(identificacionVisitante.Text.Equals(String.Empty))) && (!(edadVisitante.Text.Equals(String.Empty))) && (!(motivoVisitante.Text.Equals(String.Empty)));
                if (allowed)
                {
                    String nombre = nombreVisitante.Text;
                    String id = identificacionVisitante.Text;
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

        private void reporteVisitantes_Click(object sender, EventArgs e)
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
