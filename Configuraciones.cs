using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using gma.System.Windows;

namespace GlobalHookDemo
{
    public partial class Configuraciones : Form, IConfiguraciones
    {
        public Configuraciones()
        {
            InitializeComponent();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        UserActivityHook actHook;
        private void Configuraciones_Load(object sender, EventArgs e)
        {
            cargarEstados();
            actHook = new UserActivityHook();
            actHook.OnMouseActivity += new MouseEventHandler(CapturaCoordenadas);
            actHook.Start();
        }

        private void cargarEstados()
        {
            if (segurBot.EstadoPrimera)
            {
                label1.Text = segurBot.Primera.ToString();
                label1.BackColor = Color.LimeGreen;
            }
            if (segurBot.EstadoSegunda)
            {
                label2.Text = segurBot.Segunda.ToString();
                label2.BackColor = Color.LimeGreen;
            }
            if (segurBot.EstadoTercera)
            {
                label3.Text = segurBot.Tercera.ToString();
                label3.BackColor = Color.LimeGreen;
            }
            if (segurBot.EstadoCuarta)
            {
                label4.Text = segurBot.Cuarta.ToString();
                label4.BackColor = Color.LimeGreen;
            }
            if (segurBot.EstadoQuinta)
            {
                label5.Text = segurBot.Quinta.ToString();
                label5.BackColor = Color.LimeGreen;
            }
            if (segurBot.EstadoSexta)
            {
                label6.Text = segurBot.Sexta.ToString();
                label6.BackColor = Color.LimeGreen;
            }
            if (segurBot.EstadoSeptima)
            {
                label7.Text = segurBot.Septima.ToString();
                label7.BackColor = Color.LimeGreen;
            }
            if (segurBot.EstadoOctava)
            {
                label8.Text = segurBot.Octava.ToString();
                label8.BackColor = Color.LimeGreen;
            }
            if (segurBot.EstadoNovena)
            {
                label9.Text = segurBot.Novena.ToString();
                label9.BackColor = Color.LimeGreen;
            }
            barra.Value = (segurBot.CoordinatesDone * 100) / 9;
        }

        public void coordenadaCapturada()
        {
            estadoActual.Text = "Coordenada seleccionada correctamente.";
            estadoActual.BackColor = Color.LimeGreen;
            if(!segurBot.isOk)
            {
                barra.Value = (segurBot.CoordinatesDone * 100) / 9;
                if (segurBot.CoordinatesDone == segurBot.CoordinatesQuantity)
                {
                    segurBot.isOk = true;
                    estadoActual.Text = "Listo para trabajar.";
                    MessageBox.Show(segurBot.TextoListaCoordenadas);
                }
            }
            else
            {
                barra.Value = 100;
                estadoActual.Text = "Listo para trabajar.";
            }
        }

        public void CapturaCoordenadas(object sender, MouseEventArgs e)
        {
            if (e.Clicks > 0 && e.Button.ToString() == "Left")
            {
                if(segurBot.GuardarCoordenada)
                {
                    switch (segurBot.ProximaCoordenadaGuardar)
                    {
                        case 1:
                            if(!segurBot.EstadoPrimera)
                            {
                                segurBot.CoordinatesDone++;
                            }
                            segurBot.Primera = e.Location;
                            label1.Text = segurBot.Primera.ToString();
                            label1.BackColor = Color.LimeGreen;
                            segurBot.GuardarCoordenada = false;
                            segurBot.EstadoPrimera = true;
                            coordenadaCapturada();
                            break;
                        case 2:
                            if (!segurBot.EstadoSegunda)
                            {
                                segurBot.CoordinatesDone++;
                            }
                            segurBot.Segunda = e.Location;
                            label2.Text = segurBot.Segunda.ToString();
                            label2.BackColor = Color.LimeGreen;
                            segurBot.GuardarCoordenada = false;
                            segurBot.EstadoSegunda = true;
                            coordenadaCapturada();
                            break;
                        case 3:
                            if (!segurBot.EstadoTercera)
                            {
                                segurBot.CoordinatesDone++;
                            }
                            segurBot.Tercera = e.Location;
                            label3.Text = segurBot.Tercera.ToString();
                            label3.BackColor = Color.LimeGreen;
                            segurBot.GuardarCoordenada = false;
                            segurBot.EstadoTercera = true;
                            coordenadaCapturada();
                            break;
                        case 4:
                            if (!segurBot.EstadoCuarta)
                            {
                                segurBot.CoordinatesDone++;
                            }
                            segurBot.Cuarta = e.Location;
                            label4.Text = segurBot.Cuarta.ToString();
                            label4.BackColor = Color.LimeGreen;
                            segurBot.GuardarCoordenada = false;
                            segurBot.EstadoCuarta = true;
                            coordenadaCapturada();
                            break;
                        case 5:
                            if (!segurBot.EstadoQuinta)
                            {
                                segurBot.CoordinatesDone++;
                            }
                            segurBot.Quinta = e.Location;
                            label5.Text = segurBot.Quinta.ToString();
                            label5.BackColor = Color.LimeGreen;
                            segurBot.GuardarCoordenada = false;
                            segurBot.EstadoQuinta = true;
                            coordenadaCapturada();
                            break;
                        case 6:
                            if (!segurBot.EstadoSexta)
                            {
                                segurBot.CoordinatesDone++;
                            }
                            segurBot.Sexta = e.Location;
                            label6.Text = segurBot.Sexta.ToString();
                            label6.BackColor = Color.LimeGreen;
                            segurBot.GuardarCoordenada = false;
                            segurBot.EstadoSexta = true;
                            coordenadaCapturada();
                            break;
                        case 7:
                            if (!segurBot.EstadoSeptima)
                            {
                                segurBot.CoordinatesDone++;
                            }
                            segurBot.Septima = e.Location;
                            label7.Text = segurBot.Septima.ToString();
                            label7.BackColor = Color.LimeGreen;
                            segurBot.GuardarCoordenada = false;
                            segurBot.EstadoSeptima = true;
                            coordenadaCapturada();
                            break;
                        case 8:
                            if (!segurBot.EstadoOctava)
                            {
                                segurBot.CoordinatesDone++;
                            }
                            segurBot.Octava = e.Location;
                            label8.Text = segurBot.Octava.ToString();
                            label8.BackColor = Color.LimeGreen;
                            segurBot.GuardarCoordenada = false;
                            segurBot.EstadoOctava = true;
                            coordenadaCapturada();
                            break;
                        case 9:
                            if (!segurBot.EstadoNovena)
                            {
                                segurBot.CoordinatesDone++;
                            }
                            segurBot.Novena = e.Location;
                            label9.Text = segurBot.Novena.ToString();
                            label9.BackColor = Color.LimeGreen;
                            segurBot.GuardarCoordenada = false;
                            segurBot.EstadoNovena = true;
                            coordenadaCapturada();
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Al cerrar la ventana cerramos el Thread actual de ActHook
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Configuraciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            actHook.Stop();
        }

        private void prepararCaptura(int x)
        {
            estadoActual.BackColor = Color.Red;
            estadoActual.Text = "Seleccionando nueva coordenada.";
            segurBot.GuardarCoordenada = true;
            segurBot.ProximaCoordenadaGuardar = x;
        }

        /// <summary>
        /// Capturamos la primer coordenada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            prepararCaptura(1);
        }
        /// <summary>
        /// Capturamos la segunda coordenada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            prepararCaptura(2);
        }
        /// <summary>
        /// Capturamos la tercer coordenada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            prepararCaptura(3);
        }
        /// <summary>
        /// Capturamos la cuarta coordenada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            prepararCaptura(4);
        }
        /// <summary>
        /// Capturamos la quinta coordenada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            prepararCaptura(5);
        }
        /// <summary>
        /// Capturamos la sexta coordenada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            prepararCaptura(6);
        }
        /// <summary>
        /// Capturamos la septima coordenada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            prepararCaptura(7);
        }
        /// <summary>
        /// Capturamos la octava coordenada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            prepararCaptura(8);
        }
        /// <summary>
        /// Capturamos la novena coordenada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            prepararCaptura(9);
        }
    }
}
