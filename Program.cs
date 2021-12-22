using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_TP05_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int LIMITE_SUPERIOR = 63;
            int LIMITE_INFERIOR = 0;
            Random random = new Random();
            List<Estado> estadosIniciales = new List<Estado>
            {
                new Estado(random.Next(LIMITE_INFERIOR,LIMITE_SUPERIOR)),
                new Estado(random.Next(LIMITE_INFERIOR,LIMITE_SUPERIOR)),
                new Estado(random.Next(LIMITE_INFERIOR,LIMITE_SUPERIOR)),
                new Estado(random.Next(LIMITE_INFERIOR,LIMITE_SUPERIOR)),
                new Estado(random.Next(LIMITE_INFERIOR,LIMITE_SUPERIOR)),
                new Estado(random.Next(LIMITE_INFERIOR,LIMITE_SUPERIOR)),
                new Estado(random.Next(LIMITE_INFERIOR,LIMITE_SUPERIOR)),
                new Estado(random.Next(LIMITE_INFERIOR,LIMITE_SUPERIOR)),
                new Estado(random.Next(LIMITE_INFERIOR,LIMITE_SUPERIOR)),
                new Estado(random.Next(LIMITE_INFERIOR,LIMITE_SUPERIOR))
            };
            Estado resultado = Algoritmo.Resolver(estadosIniciales, LIMITE_INFERIOR, LIMITE_SUPERIOR);
            Console.WriteLine("Máximo en " + resultado.Punto + ". Valor: " + resultado.ObtenerValor());
            Console.ReadLine();
        }
    }
}
