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

namespace CANCIONES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wpm.uiMode = "none";
            StreamReader sr = new StreamReader("Datos.txt");
            string linea;

            while (sr.EndOfStream == false)
            {
                linea = sr.ReadLine();
                string[] datos = linea.Split(',');
                cbCancion.Items.Add(datos[1]);
            }
            cbCancion.SelectedIndex = 0;
            sr.Close();
            sr.Dispose();
        }

        private void cbCancion_SelectedIndexChanged(object sender, EventArgs e)
        {
            wpm.URL = "tema" + (cbCancion.SelectedIndex + 1).ToString() + ".mp4";
        }
    }
}
