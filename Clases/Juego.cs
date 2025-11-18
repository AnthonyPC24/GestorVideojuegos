using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorJuegos.Clases
{
    public class Juego
    {
        public string avatar { get; set; }
        public string nombreJugador { get; set; }
        public int numPreguntas { get; set; }
        public string dificultad { get; set; }
        public int puntuacion { get; set; }
        public int errores { get; set; }   
        public string tiempoPartida { get; set; }
        public string fechaHorainicio { get; set; }
    }
}
