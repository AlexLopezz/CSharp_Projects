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

namespace Generador_Lorem_Ipsum
{
    public partial class Form1 : Form
    {
        const int minimoPalabras = 5, maximoPalabras = 200; //Parametros internos de palabras.
        const int minimoParrafos = 1, maximoParrafos = 15; //Parametros internos de parrafos. 
        int aux,contPalabras=0, contParrafos=0, contOraciones=0, letrasTotales=0;
        string lblOriginalContainer, palabras = "";
        private string myGit= "https://github.com/AlexLopezz/CSharp_Projects";
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private void InitializeForm()
        {
            txtPizarra.Text = String.Empty;
            txtContainer.Text = String.Empty;
            lblLetrasTotales.Text = String.Empty;
            lblOriginalContainer = lblContainer.Text;
            txtContainer.Enabled = false;
            lblContainer.Enabled = false;
            bttGenerar.Enabled = false;
            letrasTotales = 0;
            contParrafos = 0;
            contPalabras = 0;
            contOraciones = 0;
            
            lblContParrafos.Text = contParrafos.ToString();
            lblContOracioness.Text = contPalabras.ToString();
            lblContPalabras.Text = contPalabras.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeForm();
            load_files();
        }
        private void load_files()
        {
            string aux;
            FileStream fs = new FileStream("palabras.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while ((aux = sr.ReadLine()) != null) palabras += aux;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void generateLoremIpsum(int parameter, string type)
        {
            if (type.Equals("palabras") && parameter >= minimoPalabras && parameter <= maximoPalabras)
            {
                
                for (int i = 0; i < parameter; i++)
                {
                    if (palabras[i] == '.')
                    {
                        contOraciones++;
                        txtPizarra.Text += palabras[i];
                        parameter++;
                    }else if (palabras[i] != ' ')
                    {
                        letrasTotales++;
                        txtPizarra.Text += palabras[i];
                        parameter++;
                    } 
                    else
                    {
                        letrasTotales++;
                        contPalabras++;
                        txtPizarra.Text += ' ';
                    }
                }
                lblContPalabras.Text = contPalabras.ToString();
                lblContOracioness.Text = contOraciones.ToString();
                lblContParrafos.Text = contParrafos.ToString();
                lblLetrasTotales.Text = letrasTotales.ToString();
            }
            else if(type.Equals("parrafos") && parameter >= minimoParrafos && parameter <= maximoParrafos)
            {
                for (int i = 0; i < parameter;)
                {
                    if (palabras[i] != '*') 
                    {
                        txtPizarra.Text += palabras[i];
                        contPalabras++;
                        letrasTotales++;
                        i++;
                        parameter++;
                    }
                    else
                    {
                        contPalabras++;
                        i++;
                        contParrafos++;
                        txtPizarra.Text += Environment.NewLine;
                    }

                    if (palabras[i] == '.')
                    {
                        letrasTotales++;
                        contOraciones++;
                    }
                    else if (palabras[i] == ',') letrasTotales++;
                }
                lblContOracioness.Text = contOraciones.ToString();
                lblContPalabras.Text = contPalabras.ToString();
                lblContParrafos.Text = contParrafos.ToString();
                letrasTotales += contPalabras;
                lblLetrasTotales.Text = letrasTotales.ToString();
            }
            else MessageBox.Show($"USTED NO CUMPLIO CON LOS PARAMETROS ESTABLECIDOS.\nPARRAFOS: MIN: {minimoParrafos}, MAX: {maximoParrafos}\nPALABRAS: MIN: {minimoPalabras}, MAX: {maximoPalabras}", "ERROR");
        } //Generamos lorem para mostrar el en textBox.

        private void rdoParrafos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoParrafos.Checked) activateParrafo();
            else disabledChanges();
        }
        private void rdoPalabras_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPalabras.Checked) activatePalabra();
            else disabledChanges();
        }
        private void activateParrafo()
        {
            lblContainer.Enabled = true;
            txtContainer.Enabled = true;
            lblContainer.Text = "Cantidad de Parrafos: ";
        } //Activamos el lbl de Parrafo.
        private void activatePalabra()
        {
            lblContainer.Enabled = true;
            txtContainer.Enabled = true;
            lblContainer.Text = "Cantidad de Palabras: ";
        } //Activamos el lbl de Palabra.

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void acercaDeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Creado por Alex Lopez.\n¿Quiere ver mi codigo en Github?", "Coyright", MessageBoxButtons.YesNo) == DialogResult.Yes) System.Diagnostics.Process.Start(myGit);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void disabledChanges()
        {
            lblContainer.Enabled = false;
            lblContainer.Text = lblOriginalContainer;
            txtContainer.Text = string.Empty;
            txtContainer.Enabled = false;
        } //Deshabilitamos los cambios en lbl y txt Container.




        
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPizarra.Text))
            {
                saveFileDialog1.FileName = "sin titulo.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writerTextBox = new StreamWriter(saveFileDialog1.FileName))
                    {
                        writerTextBox.WriteLine(txtPizarra.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("NO PUEDE GUARDAR UN ARCHIVO VACIO.", "ERROR");
            }
        } //Guardar txt
        private void bttGenerar_Click(object sender, EventArgs e) => checkedContainer(); //Si los campos estan vacios, el boton "Generar" no esta habilitado.
        
        void checkedContainer()
        {
            if (rdoParrafos.Checked)
            {
                if (int.TryParse(txtContainer.Text, out aux)) generateLoremIpsum(aux, "parrafos");
                else
                {
                    MessageBox.Show("DEBE INGRESAR NUMEROS, NO LETRAS!", "ERROR");
                    txtContainer.Text = String.Empty;
                }
            }
            if (rdoPalabras.Checked)
            {
                if (int.TryParse(txtContainer.Text, out aux)) generateLoremIpsum(aux, "palabras");
                else
                {
                    MessageBox.Show("DEBE INGRESAR NUMEROS, NO LETRAS!", "ERROR");
                    txtContainer.Text = String.Empty;
                }
            }
        } //Chequea si el radioButton de palabras o parrafos esta activo, para escribir en el textbox.
        private void checkTxt()
        {
            var var = !string.IsNullOrEmpty(txtContainer.Text);
            bttGenerar.Enabled = var;
        } //VALIDAR BOTON DE GENERAR, SI EL USUARIO INGRESA DATOS EN LOS TEXTBOX.
        private void txtContainer_TextChanged(object sender, EventArgs e) => checkTxt();
    }
}
