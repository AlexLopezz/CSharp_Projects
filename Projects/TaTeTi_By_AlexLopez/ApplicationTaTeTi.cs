using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaTeTi_By_AlexLopez
{
    public partial class ApplicationTaTeTi : Form
    {
        private List<string> listJugadores = new List<string>();
        private int index = 0, movimientos= 0;
        private string myGit = "https://github.com/AlexLopezz/Projects_CSharp/tree/master/TaTeTi_By_AlexLopez";
        public ApplicationTaTeTi()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private void loadNamesReg_User()
        {
            string[] nombresJugadores;
            string aux;
            using (var fs = new FileStream("nombreJugadores.txt", FileMode.Open))
            {
                using (var sr = new StreamReader(fs))
                {
                    aux = (string)sr.ReadToEnd();
                    nombresJugadores = aux.Split(',');
                    for (int i = 0; i < nombresJugadores.Length; i++)
                    {
                        listJugadores.Add(nombresJugadores[i].ToUpper());
                    }
                }
            }
        }
        void InitializeButtons()
        {
            button1.Text = string.Empty;
            button2.Text = string.Empty;
            button3.Text = string.Empty;
            button4.Text = string.Empty;
            button5.Text = string.Empty;
            button6.Text = string.Empty;
            button7.Text = string.Empty;
            button8.Text = string.Empty;
            button9.Text = string.Empty;
        }
        void changeLabelTurn(int index)=> label1.Text = listJugadores[index];
        private void newGame()
        {
            RegUser regUser = new RegUser();
            this.Hide();
            regUser.ShowDialog();
        }
        private void click_boton(object sender, EventArgs e)
        {
            movimientos++;
            Button button = sender as Button;
            if (button != null)
            {
                if (string.IsNullOrEmpty(button.Text))
                {
                    button.Text = index == 0 ? "X" : "O";
                    if (checkWinner())
                    {
                        MessageBox.Show($"EL GANADOR ES: {label1.Text}", "TENEMOS UN GANADOR!");
                        listGanadores.Items.Add($"GANO {label1.Text}");
                        againOrNot();
                    }
                    else
                    {
                        if (movimientos < 9)
                        {
                            index = index == 0 ? 1 : 0;
                            changeLabelTurn(index);
                        }
                        else
                        {
                            MessageBox.Show($"LOS JUGADORES {listJugadores[0]} y {listJugadores[1]} SE LE TERMINARON LOS MOVIMIENTOS!", "EMPATE");
                            listGanadores.Items.Add($"EMPATE - {listJugadores[0]}, {listJugadores[1]}");
                            againOrNot();
                        }
                    }
                }
            }
        }
        private void againOrNot()
        {
            if (MessageBox.Show("¿Desea volver a jugar?", "Tome una decision", MessageBoxButtons.YesNo) == DialogResult.Yes) reset();
            else creditos();
        }
        private void reset()
        {
            InitializeButtons();
            movimientos = 0;
        }
        private void creditos()
        {
            MessageBox.Show("Proyecto creado por Alex Lopez. Gracias por jugar!", "SALUDOS VUELVA PRONTOS");
            this.Close();
        }
        private bool checkWinner()
        {
            if ((!string.IsNullOrEmpty(button1.Text))&& button1.Text == button2.Text && button2.Text == button3.Text ||
                (!string.IsNullOrEmpty(button4.Text)) && button4.Text == button5.Text && button5.Text == button6.Text ||
                (!string.IsNullOrEmpty(button7.Text)) && button7.Text == button8.Text && button8.Text == button9.Text ||
                (!string.IsNullOrEmpty(button1.Text)) && button1.Text == button4.Text && button4.Text == button7.Text ||
                (!string.IsNullOrEmpty(button2.Text)) && button2.Text == button5.Text && button5.Text == button8.Text ||
                (!string.IsNullOrEmpty(button3.Text)) && button3.Text == button6.Text && button6.Text == button9.Text ||
                (!string.IsNullOrEmpty(button1.Text)) && button1.Text == button5.Text && button5.Text == button9.Text ||
                (!string.IsNullOrEmpty(button3.Text)) && button3.Text == button5.Text && button5.Text == button7.Text)
            {
                return true;
            }
            else return false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();
        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)=> newGame();

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Programa creado por Alex Lopez. Use y distribuye sin problemas legales mi pana.\n¿Desea ver el codigo en mi github?", "TaTeTi",MessageBoxButtons.YesNo) == DialogResult.Yes){
                Process.Start(myGit);
            }
        }

        

        private void ApplicationTaTeTi_Load(object sender, EventArgs e)
        {
            InitializeButtons();
            loadNamesReg_User();
            changeLabelTurn(this.index);
        }
    }
}
