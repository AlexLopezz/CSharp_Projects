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

namespace Block_De_Notas.Alex_Lopez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (fontDialog1.ShowDialog() == DialogResult.OK)
        //    {

        //    }
        //}

        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.Yes)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    string path = openFileDialog.FileName;
                    TextReader leerArchivo = new StreamReader(path);
                    txtPizarra.Text = leerArchivo.ReadToEnd();
                    leerArchivo.Close();
                }
            }
        }
        private void saveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos txt (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter escribirArchivo = new StreamWriter(saveFileDialog.FileName))
                {
                    escribirArchivo.WriteLine(txtPizarra.Text);
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!txtPizarra.Text.Equals(""))
            {
                if (MessageBox.Show("El archivo contiene texto.\n¿Desea guardarlo?", "Peticion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveFile();
                }
                else txtPizarra.Text = "";
            }
        }
        bool checkTxtPizarra()
        {
            if (!txtPizarra.Text.Equals("")) return true;
            else return false;
        } //Retorna true si hay texto en el txt, false de lo contrario.


        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkTxtPizarra()) saveFile();
            else MessageBox.Show("No se puede guardar un archivo vacio.", "ERROR");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e) => openFile();
    }
}
