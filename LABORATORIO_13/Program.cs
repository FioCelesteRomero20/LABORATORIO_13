using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion = Pantallas.pantallaPrincipal();
            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = Pantallas.realizarEncuesta();
                        break;
                    case 2:
                        opcion = Pantallas.verDatosRegistrados();
                        break;
                    case 3:
                        opcion = Pantallas.eliminarUnDato();
                        break;
                    case 0:
                    default:
                        opcion = Pantallas.pantallaPrincipal();
                        break;
                }
            } while (opcion != 4);

        }
    }
}
