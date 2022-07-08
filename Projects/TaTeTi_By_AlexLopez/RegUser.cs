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

namespace TaTeTi_By_AlexLopez
{
    public partial class RegUser : Form
    {
        public RegUser()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private bool validate()
        {
            if (string.IsNullOrEmpty(txtJugador1.Text) && string.IsNullOrEmpty(txtJugador2.Text))
            {
                MessageBox.Show("Debe completar los campos.", "COMPLETE SUS DATOS");
                return false;
            }else if(txtJugador1.Text == txtJugador2.Text)
            {
                MessageBox.Show("Disculpe, los nombres de los jugadores no deben ser iguales.", "COMPLETE SUS DATOS");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void loadNames()
        {
            using(var fileStream = new FileStream("nombreJugadores.txt", FileMode.Create))
            {
                using (var streamWritter = new StreamWriter(fileStream))
                {
                    streamWritter.Write(txtJugador1.Text+","+txtJugador2.Text);
                }
            }
        }

        private void bttOK_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                loadNames();
                ApplicationTaTeTi app = new ApplicationTaTeTi(); //Instanciamos la primer forma creada
                
                this.Hide(); //Escondemos este form
                app.ShowDialog(); //Le damos lugar a la forma de la aplicacion.
                this.Close(); //Una vez que cerramos el form de app, tambien cerramos este...
            }
        }
    }
}
