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
    public partial class frmPregunta : Form
    {
        private int turno;
        private string indiceRespuesta = "0";
        public frmPregunta(int turno)
        {
            this.turno = turno;
            InitializeComponent();
            MostrarDiagramas();
        }

        //CRONÓMETRO PARA RESPONDER PREGUNTA
        private void tmr1_Tick(object sender, EventArgs e)
        {
            int valor = int.Parse(lblContador.Text);
            valor--;
            lblContador.Text = valor.ToString();

            //SI EL CRONÓMETRO LLEGA A CERO, LAS VIDAS DEL JUGADOR ACTUAL SE RESTAN
            if (valor ==0)
            {
                tmr1.Enabled=false;
                this.Close();
                restarVidas();
            }
        }

        //MOSTRAR DIAGRAMAS DE MANERA ALEATORIA
        public void MostrarDiagramas()
        {
            Random random = new Random();
            tmr1.Enabled = true;
            //GENERAR UN NÚMERO ALEATORIO DEL 1 AL 32 (QUE ES EL NÚMERO DE DIAGRAMAS)
            int aleatorio1 = random.Next(1, 33);
            int aleatorio2 = random.Next(1, 33);

            while (aleatorio2 == aleatorio1)
            {
                aleatorio2 = random.Next(1, 33);
            }

            //PARA EVITAR QUE SE MUESTREN DIAGRAMAS IGUALES


            //TEXTO ALEATORIO QUE INDICARÁ EL DIAGRAMA QUE SE MOSTRARÁ
            string[] arrayTextos = new string[]
            {
                " de Interpolación Lineal?",
                " de Newton hacia adelante?",
                " de Newton hacia atrás?",
                " de Lagrange?",
                " de Newton con diferencias divididas?",

                " Gráfico?",
                " de La Bisectriz?",
                " del Punto Fijo o sustituciones sucesivas?",
                " de Newton Raphson?",
                " de Falsa posición o regula-falsi?",
                " de la Secante?",

                " de Montante?",
                " de Gauss Jordan?",
                " de Eliminación Gaussiana?",
                " de Gauss-Seidel?",
                " de Jacobi?",

                " de Línea recta?",
                " Cuadrática?",
                " Cúbica?",
                " Lineal con Función?",
                " Cuadrática con Función?",

                " de Regla trapezoidal?",
                " de Regla de 1/3 Simpson?",
                " de Regla de 3/8 Simpson?",
                " de Newton – Cotes Cerradas?",
                " de Newton – Cotes Abiertas?",

                " de Euler modificada?",
                " de RK 2 orden?",
                " de RK 3 orden?",
                " de RK 4 orden 1/3 S?",
                " de RK 4 orden 3/8 S?",
                " de RK orden superior?"
            };

            //ELIGE UNO DE LOS DOS DIAGRAMAS ALEATORIAMENTE QUE SERÁ EL CORRECTO
            int indiceAleatorio = random.Next(0, 2); // 0 o 1

            int indiceSeleccionado = indiceAleatorio == 0 ? aleatorio1 : aleatorio2;

            lblPregunta.Text += arrayTextos[indiceSeleccionado-1];

            pcBoxOpc1.Image = elegirImagen(aleatorio1);
            pcBoxOpc2.Image = elegirImagen(aleatorio2);

            pcBoxOpc1.Tag = aleatorio1;
            pcBoxOpc2.Tag = aleatorio2;

            indiceRespuesta = indiceSeleccionado.ToString();


        }

        //EVALUAR SI COINCIDE EL DIAGRAMA SELECCIONADO CON LA RESPUESTA CORRECTA
        private void pcBoxOpc1_Click(object sender, EventArgs e)
        {
            tmr1.Stop();
            //SI LA ETIQUETA DE LA IMAGEN COINCIDE CON EL ÍNDICE DE LA RESPUESTA CORRECTA
            if (pcBoxOpc1.Tag.ToString() == indiceRespuesta)
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

        private void pcBoxOpc2_Click(object sender, EventArgs e)
        {
            tmr1.Stop();
            if (pcBoxOpc2.Tag.ToString() == indiceRespuesta)
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

        //SI HAY ERROR, SE RESTAN VIDAS AL JUGADOR EN TURNO
        private void restarVidas()
        {
            if (turno == 0)
            {
                Vidas.jugador1--;
            }
            else if(turno == 1)
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

        //ELEGIR UNA IMAGEN ALEATORIA DE Imagenes.resx
        private Bitmap elegirImagen(int aleatorio)
        {
            Bitmap imagen = null;
            switch (aleatorio)
            {
                case 1: imagen = Imagenes._1; break;
                case 2: imagen = Imagenes._2; break;
                case 3: imagen = Imagenes._3; break;
                case 4: imagen = Imagenes._4; break;
                case 5: imagen = Imagenes._5; break;
                case 6: imagen = Imagenes._6; break;
                case 7: imagen = Imagenes._7; break;
                case 8: imagen = Imagenes._8; break;
                case 9: imagen = Imagenes._9; break;
                case 10: imagen = Imagenes._10; break;
                case 11: imagen = Imagenes._11; break;
                case 12: imagen = Imagenes._12; break;
                case 13: imagen = Imagenes._13; break;
                case 14: imagen = Imagenes._14; break;
                case 15: imagen = Imagenes._15; break;
                case 16: imagen = Imagenes._16; break;
                case 17: imagen = Imagenes._17; break;
                case 18: imagen = Imagenes._18; break;
                case 19: imagen = Imagenes._19; break;
                case 20: imagen = Imagenes._20; break;
                case 21: imagen = Imagenes._21; break;
                case 22: imagen = Imagenes._22; break;
                case 23: imagen = Imagenes._23; break;
                case 24: imagen = Imagenes._24; break;
                case 25: imagen = Imagenes._25; break;
                case 26: imagen = Imagenes._26; break;
                case 27: imagen = Imagenes._27; break;
                case 28: imagen = Imagenes._28; break;
                case 29: imagen = Imagenes._29; break;
                case 30: imagen = Imagenes._30; break;
                case 31: imagen = Imagenes._31; break;
                case 32: imagen = Imagenes._32; break;
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

       

        private void lblContador_Click(object sender, EventArgs e)
        {

        }
    }
}
