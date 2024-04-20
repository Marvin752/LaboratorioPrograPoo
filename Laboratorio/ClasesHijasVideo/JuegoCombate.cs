using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio.ClasesHijasVideo
{
    internal class JuegoCombate : VideoJuego
    {
        public override void accion()
        {
            Console.WriteLine("Le tira un gancho al higado");
        }
        public JuegoCombate(string titu, string des, double cali, int año)
        {
            Titulo = titu;
            Desarrolladora = des;
            Calificacion = cali;
            AnioLanzamiento = año;
        }
        public string MostrarCom()
        {
            MostrarInformacion();
            return "";
        }
    }
}
