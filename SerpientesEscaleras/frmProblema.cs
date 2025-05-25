using System;
using System.Drawing;
using System.Windows.Forms;

namespace SerpientesEscaleras
{
    public partial class frmProblema : Form
    {
        private int minutos = 15;
        private int turno;
        private int segundos = 0;
        string[] resultados;
        private int indice;
        public frmProblema(int turno)
        {
            this.turno = turno;
            InitializeComponent();
            mostrarOpciones();
        }

        private void mostrarOpciones()
        {
            resultados = new string[]
            {
                "18.66666667",
                "1.029183673",
                "2.676460905",
                "-0.657813",
                "0.5671407819",
                "1.368808108",
                "0.567143306",
                "1.217859143",
                "3.000000352,-2.500000036,6.999999989",
                "3.000015844,-2.500001424,6.999985592",
                "-2.875,0.5,-1.625",
                "3,-3,-2",
                "1,2,3",
                "2.008443615,0.633695283",
                "0.65625",
                "0.666666666",
                "0.705",
                "1.2,2.08",
                "1.98,2.4132",
                "1.999333333,2.463099554",
                "1.996483333,2.457719869",
                "1.991958024,2.437676903",
                "4.11328125,6.11328125"
            };
            cronometro.Start();
            Random rnd = new Random();
            int aleatorio = rnd.Next(1,24);
            indice = aleatorio - 1;
            pcBoxOpc.Tag = aleatorio;
            pcBoxOpc.Image = elegirImagen(aleatorio);
        }

        private Bitmap elegirImagen(int aleatorio)
        {
            Bitmap imagen = null;
            switch (aleatorio)
            {
                case 1: imagen = Preguntas.Diapositiva1; break;
                case 2: imagen = Preguntas.Diapositiva2; break;
                case 3: imagen = Preguntas.Diapositiva3; break;
                case 4: imagen = Preguntas.Diapositiva4; break;
                case 5: imagen = Preguntas.Diapositiva5; break;
                case 6: imagen = Preguntas.Diapositiva6; break;
                case 7: imagen = Preguntas.Diapositiva7; break;
                case 8: imagen = Preguntas.Diapositiva8; break;
                case 9: imagen = Preguntas.Diapositiva9; break;
                case 10: imagen = Preguntas.Diapositiva10; break;
                case 11: imagen = Preguntas.Diapositiva11; break;
                case 12: imagen = Preguntas.Diapositiva12; break;
                case 13: imagen = Preguntas.Diapositiva13; break;
                case 14: imagen = Preguntas.Diapositiva14; break;
                case 15: imagen = Preguntas.Diapositiva15; break;
                case 16: imagen = Preguntas.Diapositiva16; break;
                case 17: imagen = Preguntas.Diapositiva17; break;
                case 18: imagen = Preguntas.Diapositiva18; break;
                case 19: imagen = Preguntas.Diapositiva19; break;
                case 20: imagen = Preguntas.Diapositiva20; break;
                case 21: imagen = Preguntas.Diapositiva21; break;
                case 22: imagen = Preguntas.Diapositiva22; break;
                case 23: imagen = Preguntas.Diapositiva23; break;
                default:
                    MessageBox.Show("Número aleatorio fuera de rango.");
                    break;
            }
            if (imagen != null)
            {
                return imagen;
            }

            return null;
        }
        private void cronometro_Tick(object sender, EventArgs e)
        {
            if (segundos > 0)
            {
                segundos--;
            }
            else
            {
                if (minutos > 0)
                {
                    minutos--;
                    segundos = 59;
                }
            }
            lblContador.Text = minutos.ToString("00") + ":" + segundos.ToString("00");

            if (minutos == 0)
            {
                cronometro.Stop();
                this.Close();
                restarVidas();
            }
        }

        private void lblPregunta_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cronometro.Stop();
            if (txtRespuesta.Text == resultados[indice])
            {
                MessageBox.Show("CORRECTO");
            }
            else
            {
                MessageBox.Show("INCORRECTO");
                restarVidas();
            }
            this.Close();
        }

        private void restarVidas()
        {
            if (turno == 0)
            {
                Vidas.jugador1--;
            }
            else if (turno == 1)
            {
                Vidas.jugador2--;
            }
            else if (turno == 2)
            {
                Vidas.jugador3--;
            }
            else
            {
                Vidas.jugador4--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarOpciones();
        }
    }
}
