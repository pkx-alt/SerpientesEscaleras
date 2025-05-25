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
    public partial class Agregar_jugadores : Form
    {
        private int nJugadores;

        public Agregar_jugadores(int nJugadores)
        {
            this.nJugadores = nJugadores;
            InitializeComponent();
            inicializarTxtBox();
            txtJugador1.MaxLength = 10;
            txtJugador2.MaxLength = 10;
            txtJugador3.MaxLength = 10;
            txtJugador4.MaxLength = 10;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inicializarTxtBox()
        {
            switch (this.nJugadores)
            {
                case 2: 
                    txtJugador3.Enabled = false;
                    txtJugador4.Enabled = false;
                    break;
                case 3:
                    txtJugador4.Enabled = false;
                    break;
            }
        }

        private bool verificarTxtBox()
        {
            if (nJugadores == 2)
            {
                if (txtJugador1.Text == "")
                {
                    avisoJ1.Visible = true;
                }
                if (txtJugador2.Text == "")
                {
                    avisoJ2.Visible = true;
                }
                if (txtJugador1.Text != "" && txtJugador2.Text != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            else if (nJugadores == 3)
            {
                if (txtJugador1.Text == "")
                {
                    avisoJ1.Visible = true;
                }
                if (txtJugador2.Text == "")
                {
                    avisoJ2.Visible = true;
                }
                if (txtJugador3.Text == "")
                {
                    avisoJ3.Visible = true;
                }
                if (txtJugador1.Text != "" && txtJugador2.Text != "" && txtJugador3.Text != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            else if (nJugadores == 4)
            {
                if (txtJugador1.Text == "")
                {
                    avisoJ1.Visible = true;
                }
                if (txtJugador2.Text == "")
                {
                    avisoJ2.Visible = true;
                }
                if (txtJugador3.Text == "")
                {
                    avisoJ3.Visible = true;
                }
                if (txtJugador4.Text == "")
                {
                    avisoJ4.Visible = true;
                }

                if (txtJugador1.Text != "" && txtJugador2.Text != "" && txtJugador3.Text != "" && txtJugador4.Text != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            else { return false; } 
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Nombres.jugador1 = txtJugador1.Text;
            Nombres.jugador2 = txtJugador2.Text;
            Nombres.jugador3 = txtJugador3.Text;
            Nombres.jugador4 = txtJugador4.Text;



            if (verificarTxtBox())
            {
                Form1 form = new Form1(nJugadores);
                this.Close();
                form.ShowDialog();
            }
        }

        private void txtJugador1_Click(object sender, EventArgs e)
        {
            avisoJ1.Visible=false;
        }

        private void txtJugador2_Click(object sender, EventArgs e)
        {
            avisoJ2.Visible = false;
        }

        private void txtJugador3_Click(object sender, EventArgs e)
        {
            avisoJ3.Visible = false;
        }

        private void txtJugador4_Click(object sender, EventArgs e)
        {
            avisoJ4.Visible = false;
        }
    }
}
