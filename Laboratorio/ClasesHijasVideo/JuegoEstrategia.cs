using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio.ClasesHijasVideo
{
    internal class JuegoEstrategia : VideoJuego
    {
        public override void accion()
        {
            Console.WriteLine("Mueve las tropas");
        }
        public JuegoEstrategia(string titu, string des, double cali, int año)
        {
            Titulo = titu;
            Desarrolladora = des;
            Calificacion = cali;
            AnioLanzamiento = año; 
        }
        public string MostrarEs()
        {
            MostrarInformacion();
            return "";
        }
    }
}
