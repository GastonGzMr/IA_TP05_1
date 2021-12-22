using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_TP05_1
{
    public class Algoritmo
    {
        public static Estado Resolver(ICollection<Estado> estadosIniciales, int limiteInferior, int limiteSuperior)
        {
            List<Estado> estados = estadosIniciales.ToList();
            Estado padre1;
            Estado padre2;
            Estado hijo1;
            Estado hijo2;

            estados = estados.OrderByDescending(x => x.ObtenerValor()).ToList();
            padre1 = estados[0];
            padre2 = estados[1];
            while (padre1.Punto < limiteSuperior)
            {
                hijo1 = new Estado(padre1, padre2);
                if (estados.Where(x => x.Punto == hijo1.Punto).Count() == 0 && hijo1.Punto > limiteInferior)
                {
                    estados.Add(hijo1);
                }

                hijo2 = new Estado(padre2, padre1);
                if (estados.Where(x => x.Punto == hijo2.Punto).Count() == 0 && hijo2.Punto > limiteInferior)
                {
                    estados.Add(hijo2);
                }

                estados = estados.OrderByDescending(x => x.ObtenerValor()).ToList();
                padre1 = estados[0];
                padre2 = estados[1];
            }
            return padre1;
        }
    }
}
