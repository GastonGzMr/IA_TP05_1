using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_TP05_1
{
    public class Estado
    {
        public double Punto { get; set; }

        public Estado(Estado padre1, Estado padre2)
        {
            Punto = padre1.Punto + (padre1.Punto - padre2.Punto);
            Mutar();
        }

        public Estado(double punto)
        {
            Punto = punto;
        }

        public double ObtenerValor()
        {
            return Math.Pow(Punto, 5) - Math.Pow(Punto, 3) - 2 * Math.Pow(Punto, 2);
        }

        public void Mutar()
        {
            Random random = new Random();
            Punto += random.Next(-5, 5);
        }
    }
}
