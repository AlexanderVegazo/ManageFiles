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

namespace ManageFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           


        }

        private void btnCrearArchivo_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@txtRuta.Text + @"\Template.txt");

            sw.WriteLine(txtContent.Text);
            sw.Close();

            MessageBox.Show("Archivo creado satisfactoriamente");



        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {


               // this.txtRuta.Text = saveFileDialog1.InitialDirectory;
;

            }
        }
    }
}
