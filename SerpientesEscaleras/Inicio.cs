using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerpientesEscaleras
{
    public partial class Inicio : Form
    {
        private int nJugadores = 2;
        public Inicio()
        {
            InitializeComponent();
            lblJugadores.Text = nJugadores.ToString();
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            if (nJugadores < 4)
            {
                nJugadores++;

                lblJugadores.Text = nJugadores.ToString();

                btnDisminuir.Enabled = true;
                btnDisminuir.BackColor = Color.Moccasin;
                if (nJugadores == 4)
                {
                    btnAumentar.Enabled = false;
                    btnAumentar.BackColor = Color.Transparent;
                }
            }
        }


        private void btnDisminuir_Click_1(object sender, EventArgs e)
        {
            if (nJugadores > 2)
            {
                nJugadores--;

                lblJugadores.Text = nJugadores.ToString();


                btnAumentar.Enabled = true;
                btnAumentar.BackColor = Color.Moccasin;
                if (nJugadores == 2)
                {
                    btnDisminuir.Enabled = false;
                    btnDisminuir.BackColor = Color.Transparent;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Agregar_jugadores frm = new Agregar_jugadores(nJugadores);
                frm.ShowDialog();
            }
            else
            {
                Form1 form = new Form1(nJugadores);
                form.ShowDialog();
                this.Close();
            }

            verVidas();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void verVidas()
        {
            Vidas.jugador1 = 3;
            Vidas.jugador2 = 3;
            Vidas.jugador3 = 3;
            Vidas.jugador4 = 3;
        }

        private void btnInstrucciones_Click(object sender, EventArgs e)
        {
            Instrucciones frm = new Instrucciones();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
