using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio.ClasesHijasVideo
{
    internal class JuegoDisparos : VideoJuego
    {
        public override void accion()
        {
            Console.WriteLine("Se balacea el rival");
        }
        public JuegoDisparos(string titu, string des, double cali, int año)
        {
            Titulo = titu;
            Desarrolladora = des;
            Calificacion = cali;
            AnioLanzamiento = año;
        }
        public string Mostrardis()
        {
            MostrarInformacion();
            return "";
        }
    }
}
