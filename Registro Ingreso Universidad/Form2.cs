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
            String nombre = nombreVisitante.Text;
            String id = identificacionVisitante.Text;
            String url = "\\Archivos\\" + nombre; 

            if (File.Exists(url))
            {

            }
            else
            {
                File.WriteAllText(url,id);
            }



        }
    }
}
