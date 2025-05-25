using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SerpientesEscaleras
{
    public partial class Form1 : Form
    {
        Dado dado = new Dado();
        private int nJugadores;
        private int contadorTicks = 0;
        private int[] vidasActuales;

        private int dato = 0;
        private int[] casillaActual;
        private int[] casillaFinal;
        
        private int turno = -1;
        private int contAnimDado = 0;

        bool jugador3;
        bool jugador4;


        public Form1(int nJugadores)
        {
            this.nJugadores = nJugadores;
            InitializeComponent();
            iniciarJugadores();
        }
        private void dado_Click(object sender, EventArgs e)
        {
            tmrDado.Enabled = true;
            cambioTurno();
            animacionDado();
        }

        //Función para hacer ganador al último jugador en pie (si se acaban las vidas de los demás)
        private void evaluarTurno()
        {
            int jugadoresConVida = 0;
            int indice = 0;
            for (int i = 0; i < vidasActuales.Length; i++)
            {
                if (vidasActuales[i] > 0)
                {
                    jugadoresConVida++;
                    indice = i;
                }
            }

            if (jugadoresConVida == 1)
            {
                evaluarGanador(indice);
            }

        }
        
        //Para realizar la animación del dado
        private void tmrDado_Tick(object sender, EventArgs e)
        {

            dato = dado.Tirar();
            imgDado.Image = imgsDado.Images[dato - 1];
            contAnimDado++;
            if (contAnimDado == 20)
            {
                tmrDado.Enabled = false;
                tmrDado.Stop();
                contAnimDado = 0;
                imgDado.Enabled = true;
                casillaFinal[turno] = casillaActual[turno] + dato;
                tmrMovimientoJ.Start();
            }
        }

        //Función que muestra el movimiento del jugador en turno en el tablero
        private void tmrMovimientoJ_Tick(object sender, EventArgs e)
        {
            imgDado.Enabled = false;
            //Si al jugador le sale un número mayor al de las casillas faltantes, no se mueve
            if (casillaFinal[turno] > 55)
            {
                imgDado.Enabled = true;
                tmrMovimientoJ.Stop();
                mostrarTurno();
            }

            else
            {

                if (casillaActual[turno] < casillaFinal[turno])
                {
                    casillaActual[turno]++;

                    if (casillaActual[turno] > 1)
                    {
                        Control[] posicionAnterior = this.Controls.Find("cas" + (casillaActual[turno] - 1 + "j" + (turno + 1)), true);
                        if (posicionAnterior.Length > 0 && posicionAnterior[0] is Button)
                        {
                            Button posAnt = (Button)posicionAnterior[0];
                            posAnt.Visible = false;
                        }
                    }
                }

                Control[] posicionActual = this.Controls.Find("cas" + casillaActual[turno] + "j" + (turno + 1), true);
                if (posicionActual.Length > 0 && posicionActual[0] is Button)
                {
                    Button posActual = (Button)posicionActual[0];
                    posActual.Visible = true;
                }

                //Si el jugador llegó a la casilla 55 (final), gana automáticamente
                if (casillaActual[turno] == 55)
                {
                    tmrMovimientoJ.Stop();
                    tmrMovimientoJ.Enabled= false;
                    evaluarGanador(turno);
                }

                //Se finaliza la animación del jugador 
                if(casillaActual[turno] == casillaFinal[turno])
                {
                    tmrMovimientoJ.Enabled = false;
                    mostrarTurno();

                    //Se verifica si cayó en una casilla con pregunta 
                    if (evaluarPregunta(casillaActual[turno]))
                    {
                        tmrMovimientoJ.Stop();
                        tmrMovimientoJ.Enabled = false;
                        lblListos.Visible = true;
                        imgDado.Enabled = false;
                        tmrEspera.Enabled = true;
                        tmrEspera.Start();
                    }

                }

                
            }
        }
        private void animacionDado()
        {
            tmrDado.Start();
        }

       
        //Si el jugador cae en una casilla con pregunta (sola, con serpiente o con escalera)
        public bool evaluarPregunta(int casilla)
        {
            List<int> casillasEspeciales = new List<int> { 6, 9, 12, 16, 18, 19, 22, 23, 25, 26, 29, 35, 41, 47, 50, 53 };
            return casillasEspeciales.Contains(casilla);
        }

        //Si el jugador cae en una casilla de escalera
        public bool evaluarEscalera(int casilla)
        {
            List<int> casillasEspeciales = new List<int> { 6, 12, 16, 18, 23, 26, 29, 41 };
            return casillasEspeciales.Contains(casilla);
        }

        //Si el jugador cae en una casilla de serpiente
        public bool evaluarSerpiente(int casilla)
        {
            List<int> casillasEspeciales = new List<int> { 19, 22, 25, 35, 47, 50, 53 };
            return casillasEspeciales.Contains(casilla);
        }

        //Timer para activar pregunta que saldrá en pantalla
        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            contadorTicks++;
            imgDado.Enabled = false;
            if (contadorTicks == 2)
            {
                tmrEspera.Stop();
                tmrEspera.Enabled = false;

                Random rand = new Random();
                int tipo = rand.Next(1, 3);
                //SE MUESTRA EL FORMULARIO DE LA PREGUNTA
                
                
                
                lblListos.Visible = false;
                imgDado.Enabled = true;
                int vidasAntes = vidasActuales[turno];

                if (tipo == 1)
                {
                    frmPregunta pregunta = new frmPregunta(turno);
                    pregunta.ShowDialog();
                }
                else
                {
                    frmProblema problema = new frmProblema(turno);
                    problema.ShowDialog();
                }
                
                iniciarCorazones();
                //SI EL JUGADOR CAYÓ EN UNA CASILLA DE ESCALERA Y RESPONDIÓ BIEN, SUBE, SI RESPONDE MAL, NO HAY MOVIMIENTO
                if (evaluarEscalera(casillaActual[turno]) && vidasAntes == vidasActuales[turno]) { cambiarUbicacion(); }
                //SI EL JUGADOR CAYÓ EN UNA CASILLA DE SERPIENTE Y RESPONDIÓ MAL, BAJA, SI RESPONDE BIEN, NO HAY MOVIMIENTO
                else if (evaluarSerpiente(casillaActual[turno]) && vidasAntes != vidasActuales[turno]) { cambiarUbicacion(); }
                evaluarTurno();
                mostrarTurno();
                contadorTicks = 0;
                lblJugadorTurno.Visible = true;
                imgDado.Enabled = true;
                
            }
        }

        //SI EL JUGADOR CAE EN UNA CASILLA DE SERPIENTE O ESCALERA Y RESPONDE MAL O BIEN LA PREGUNTA, SE CAMBIA DE POSICIÓN
        private void cambiarUbicacion()
        {
                int casillaAnterior = casillaActual[turno];
                
                
                switch (casillaAnterior)
                {
                    //CASOS PARA LAS ESCALERAS
                    case 6: casillaActual[turno] = 20; break;
                    case 12: casillaActual[turno] = 17; break;
                    case 16: casillaActual[turno] = 37; break;
                    case 18: casillaActual[turno] = 36; break;
                    case 23: casillaActual[turno] = 32; break;
                    case 26: casillaActual[turno] = 30; break;
                    case 29: casillaActual[turno] = 44; break;
                    case 41: casillaActual[turno] = 48; break;

                    //CASOS PARA LAS SERPIENTES
                    case 19: casillaActual[turno] = 7; break;
                    case 22: casillaActual[turno] = 5; break;
                    case 25: casillaActual[turno] = 2; break;
                    case 35: casillaActual[turno] = 21; break;
                    case 47: casillaActual[turno] = 43; break;
                    case 50: casillaActual[turno] = 39; break;
                    case 53: casillaActual[turno] = 15; break;

                }
                Control[] pAct = this.Controls.Find("cas" + casillaActual[turno] + "j" + (turno + 1), true);
                if (pAct.Length > 0 && pAct[0] is Button)
                {
                    Button posActual = (Button)pAct[0];
                    posActual.Visible = true;
                }

                Control[] posicionAnterior = this.Controls.Find("cas" + casillaAnterior + "j" + (turno + 1), true);
                if (posicionAnterior.Length > 0 && posicionAnterior[0] is Button)
                {
                    Button posAnt = (Button)posicionAnterior[0];
                    posAnt.Visible = false;
                }

                mostrarTurno(); 
        }

        //ACTUALIZAR LAS VIDAS DEL JUGADOR EN LA PANTALLA
        private void iniciarCorazones()
        {
            vidasActuales[0] = Vidas.jugador1;
            vidasActuales[1] = Vidas.jugador2;
            //Jugador 1
            if (Vidas.jugador1 == 2)
            {
                c3j1.Visible = false;
            }
            if (Vidas.jugador1 == 1)
            {
                c3j1.Visible = false;
                c2j1.Visible = false;
            }

            if (Vidas.jugador1 == 0)
            {
                c3j1.Visible = false;
                c2j1.Visible = false;
                c1j1.Visible = false;
                perdidaJ1.Visible = true;
               
            }

            //Jugador 2
            if (Vidas.jugador2 == 2)
            {
                c3j2.Visible = false;
            }
            if (Vidas.jugador2 == 1)
            {
                c3j2.Visible = false;
                c2j2.Visible = false;
            }
            if (Vidas.jugador2 == 0)
            {
                c3j2.Visible = false;
                c2j2.Visible = false;
                c1j2.Visible = false;
                perdidaJ2.Visible = true;

            }

            //Jugador 3
            if (jugador3 == true)
            {
                lblJugador3.Visible = true;
                c1j3.Visible = true; c2j3.Visible = true; c3j3.Visible = true;
                if (Vidas.jugador3 == 2)
                {
                    c3j3.Visible = false;
                }
                if (Vidas.jugador3 == 1)
                {
                    c3j3.Visible = false;
                    c2j3.Visible = false;
                }

                if (Vidas.jugador3 == 0)
                {
                    c3j3.Visible = false;
                    c2j3.Visible = false;
                    c1j3.Visible = false;

                    perdidaJ3.Visible = true;

                }
                vidasActuales[2] = Vidas.jugador3;
                colorJ3.Visible = true;
            }

            //Jugador 4
            if (jugador4 == true)
            {
                lblJugador4.Visible = true;
                c1j4.Visible = true; c2j4.Visible = true; c3j4.Visible = true;
                if (Vidas.jugador4 == 2)
                {
                    c3j4.Visible = false;
                }
                if (Vidas.jugador4 == 1)
                {
                    c3j4.Visible = false;
                    c2j4.Visible = false;
                }

                if (Vidas.jugador4 == 0)
                {
                    c3j4.Visible = false;
                    c2j4.Visible = false;
                    c1j4.Visible = false;

                    perdidaJ4.Visible = true;
                }
                vidasActuales[3] = Vidas.jugador4;
                colorJ4.Visible = true;
            }
        }

        //CAMBIAR EL TURNO AL SIGUIENTE JUGADOR DISPONIBLE
        private void cambioTurno()
        {
            //SI EL TURNO ACTUAL ES EL MÁXIMO TURNO POSIBLE, REGRESAMOS AL PRIMER TURNO
            if (turno == nJugadores - 1)
            {
                turno = 0;
            }
            //SI NO, AUMENTAMOS EL TURNO EN UNO
            else
            {
                turno++;
            }

            //SI EL JUGADOR DEL SIGUIENTE TURNO NO TIENE VIDAS, CAMBIAMOS TURNO DE NUEVO
            if (vidasActuales[turno]==0)
            {
                cambioTurno();
            }
            iniciarCorazones();
        }

        
        //SITUACIÓN INICIAL
        private void iniciarJugadores()
        {

            lblJugador1.Text = Nombres.jugador1;
            lblJugador2.Text = Nombres.jugador2;
            lblJugador3.Text = Nombres.jugador3;
            lblJugador4.Text = Nombres.jugador4;
            if (nJugadores == 3)
            {
                jugador3 = true;
            }

            if (nJugadores == 4)
            {
                jugador3 = true;
                jugador4 = true;
            }
            lblJugadorTurno.Text = "Turno de " + Nombres.jugador1;
            casillaActual = new int[nJugadores];
            casillaFinal = new int[nJugadores];
            vidasActuales = new int[nJugadores];


            imgDado.Image = imgsDado.Images[0];
            iniciarCorazones();
        }

        
        //EVALUAR SI EL JUGADOR EN TURNO ES GANADOR
        private void evaluarGanador(int turno)
        {
            string nombreGanador = "";
            switch (turno)
            {
                case 0: nombreGanador = Nombres.jugador1; break;
                case 1: nombreGanador = Nombres.jugador2; break;
                case 2: nombreGanador = Nombres.jugador3; break;
                case 3: nombreGanador = Nombres.jugador4; break;
            }
            MessageBox.Show("¡FELICIDADES! GANADOR: " + nombreGanador);
            this.Close();
        }

        //MOSTRAR EL TURNO DEL JUGADOR QUE SIGUE DE TIRAR EL DADO
        private void mostrarTurno()
        {
            int siguienteTurno = (turno + 1) % nJugadores; // Calcula el índice del siguiente jugador

            // Verifica si el siguiente jugador tiene vidas restantes, si no, avanza al siguiente
            while (vidasActuales[siguienteTurno] == 0)
            {
                siguienteTurno = (siguienteTurno + 1) % nJugadores;
            }

            string jugadorTurno = "";

            // Mostrar el nombre del jugador activo
            switch (siguienteTurno)
            {
                case 0: jugadorTurno = Nombres.jugador1; break;
                case 1: jugadorTurno = Nombres.jugador2; break;
                case 2: jugadorTurno = Nombres.jugador3; break;
                case 3: jugadorTurno = Nombres.jugador4; break;
            }

            lblJugadorTurno.Text = "Turno de " + jugadorTurno;
            imgDado.Enabled = true;
        }

        //ABRIR FORMULARIO DE INSTRUCCIONES
        private void btn_Instrucciones_Click(object sender, EventArgs e)
        {
            Form formulario = new Instrucciones();
            formulario.ShowDialog();
        }

        private void lblJugadorTurno_Click(object sender, EventArgs e)
        {

        }

        private void btnInstrucciones_Click(object sender, EventArgs e)
        {
            Instrucciones instrucciones = new Instrucciones();
            instrucciones.ShowDialog();
        }
    }
}

