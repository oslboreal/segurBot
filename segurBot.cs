using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace GlobalHookDemo
{
    /// <summary>
    /// Clase estática segurBot, contiene toda la información que respecta a el robo en sí.
    /// Coordenadas, array de archivos, estados, etc.
    /// </summary>
    public static class segurBot
    {
        #region ATRIBUTOS ÚTILES
        private static string path = "";
        /// <summary>
        /// Flag que indica si la ruta fue asignada correctamente.
        /// </summary>
        public static bool flagPath = false;
        /// <summary>
        /// Arreglo de objetos FileInfo pertenecientes a la operación actual.
        /// </summary>
        public static List<FileInfo> files = new List<FileInfo>();
        /// <summary>
        /// Atributo empleado para almacenar temporalmente un objeto FileInfo.
        /// </summary>
        public static FileInfo temFile;
        /// <summary>
        /// Lista de archivos en cadena de caracteres.
        /// </summary>
        public static string[] fileList;
        /// <summary>
        /// Cantidad de archivos cargados.
        /// </summary>
        public static int fileCount;
        private static int coordinatesQuantity = 9;
        private static int coordinatesDone = 0;
        /// <summary>
        /// Variable empleada para indicar si todas las coordenadas fueron asignadas.
        /// </summary>
        public static bool isOk = false;
        private static List<Point> listaCoordenadas;
        // Atributos - Coordenadas.
        private static Point primera;
        private static Point segunda;
        private static Point tercera;
        private static Point cuarta;
        private static Point quinta;
        private static Point sexta;
        private static Point septima;
        private static Point octava;
        private static Point novena;
        // Estado de asignacion - Coordenadas
        private static bool estadoPrimera = false;
        private static bool estadoSegunda = false;
        private static bool estadoTercera = false;
        private static bool estadoCuarta = false;
        private static bool estadoQuinta = false;
        private static bool estadoSexta = false;
        private static bool estadoSeptima = false;
        private static bool estadoOctava = false;
        private static bool estadoNovena = false;
        // Variables para chequear asignacion.
        private static bool guardarCoordenada = false;
        private static int proximaCoordenadaGuardar;
        #endregion

        #region Métodos

        #endregion

        #region GETTERS Y SETTERS
        /// <summary>
        /// Getters y Setters de todas las coordenadas.
        /// </summary>

        public static Point Primera
        {
            get
            {
                return primera;
            }

            set
            {
                primera = value;
            }
        }

        public static Point Segunda
        {
            get
            {
                return segunda;
            }

            set
            {
                segunda = value;
            }
        }

        public static Point Tercera
        {
            get
            {
                return tercera;
            }

            set
            {
                tercera = value;
            }
        }

        public static Point Cuarta
        {
            get
            {
                return cuarta;
            }

            set
            {
                cuarta = value;
            }
        }

        public static Point Quinta
        {
            get
            {
                return quinta;
            }

            set
            {
                quinta = value;
            }
        }

        public static Point Sexta
        {
            get
            {
                return sexta;
            }

            set
            {
                sexta = value;
            }
        }

        public static Point Septima
        {
            get
            {
                return septima;
            }

            set
            {
                septima = value;
            }
        }

        public static Point Octava
        {
            get
            {
                return octava;
            }

            set
            {
                octava = value;
            }
        }

        public static Point Novena
        {
            get
            {
                return novena;
            }

            set
            {
                novena = value;
            }
        }

        public static bool EstadoPrimera
        {
            get
            {
                return estadoPrimera;
            }

            set
            {
                estadoPrimera = value;
            }
        }

        public static bool EstadoSegunda
        {
            get
            {
                return estadoSegunda;
            }

            set
            {
                estadoSegunda = value;
            }
        }

        public static bool EstadoTercera
        {
            get
            {
                return estadoTercera;
            }

            set
            {
                estadoTercera = value;
            }
        }

        public static bool EstadoCuarta
        {
            get
            {
                return estadoCuarta;
            }

            set
            {
                estadoCuarta = value;
            }
        }

        public static bool EstadoQuinta
        {
            get
            {
                return estadoQuinta;
            }

            set
            {
                estadoQuinta = value;
            }
        }

        public static bool EstadoSexta
        {
            get
            {
                return estadoSexta;
            }

            set
            {
                estadoSexta = value;
            }
        }

        public static bool EstadoOctava
        {
            get
            {
                return estadoOctava;
            }

            set
            {
                estadoOctava = value;
            }
        }

        public static bool EstadoNovena
        {
            get
            {
                return estadoNovena;
            }

            set
            {
                estadoNovena = value;
            }
        }

        public static bool GuardarCoordenada
        {
            get
            {
                return guardarCoordenada;
            }

            set
            {
                guardarCoordenada = value;
            }
        }

        public static int ProximaCoordenadaGuardar
        {
            get
            {
                return proximaCoordenadaGuardar;
            }

            set
            {
                proximaCoordenadaGuardar = value;
            }
        }

        public static bool EstadoSeptima
        {
            get
            {
                return estadoSeptima;
            }

            set
            {
                estadoSeptima = value;
            }
        }

        public static int CoordinatesDone
        {
            get
            {
                return coordinatesDone;
            }
            set
            {
                coordinatesDone = value;
            }
        }

        /// <summary>
        /// Propiedad de cantidad de Coordenadas
        /// GET: Retorna cantidad de coordenadas.
        /// SET: Setea cantidad de coordenadas.
        /// </summary>
        public static int CoordinatesQuantity
        {
            get
            {
                return coordinatesQuantity;
            }
            set
            {
                coordinatesQuantity = value;
            }
        }

        /// <summary>
        /// Propiedad encargado de devolver una lista de Coordenadas en forma de texto.
        /// </summary>
        public static string TextoListaCoordenadas
        {
            get
            {
                string retorno;
                if (isOk)
                {
                    StringBuilder texto = new StringBuilder();
                    foreach (Point elemento in ListaCoordenadas)
                    {
                        texto.AppendLine(elemento.ToString());
                    }
                    retorno = texto.ToString();
                }else
                {
                    retorno = "";
                }
                return retorno;
            }
        }

        /// <summary>
        /// Método encargado de devolver la lista de Coordenadas.
        /// </summary>
        public static List<Point> ListaCoordenadas
        {
            get
            {
                if(isOk)
                {
                    listaCoordenadas = new List<Point>();
                    listaCoordenadas.Add(primera);
                    listaCoordenadas.Add(segunda);
                    listaCoordenadas.Add(tercera);
                    listaCoordenadas.Add(cuarta);
                    listaCoordenadas.Add(quinta);
                    listaCoordenadas.Add(sexta);
                    listaCoordenadas.Add(septima);
                    listaCoordenadas.Add(octava);
                    listaCoordenadas.Add(novena);
                }else
                {
                    listaCoordenadas = null;
                }
                return listaCoordenadas;
            }
        }

        /// <summary>
        /// Método que indica si la ruta de trabajo fue específicada.
        /// </summary>
        public static bool CheckPath {
            get
            {
                if(segurBot.Path == "")
                {
                    return false;
                }else
                {
                    return true;
                }
            }    
        }

        /// <summary>
        /// Propiedad para la ruta:
        /// GET: Recibe la ruta del folder específicado.
        /// SET: Asigna valor de la ruta.
        /// </summary>
        public static string Path { get => path; set => path = value; }

        #endregion
    }
}
