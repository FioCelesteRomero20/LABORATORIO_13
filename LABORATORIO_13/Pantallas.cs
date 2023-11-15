using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_13
{
    public class Pantallas
    {
        public static int[] arreglo = new int[100];
        public static int contador = 0;
        public static int pantallaPrincipal()
        {
            string texto = "================================\n" +
                "Encuestas de Calidad\n" +
                "================================\n" +
                "1: Realizar encuesta\n" +
                "2: Ver datos registrados\n" +
                "3: Eliminar un dato\n" +
                "4: Salir\n" +
                "================================\n";
            Console.Write(texto);
            return Operaciones.getEntero("Ingrese una opción:", texto);
        }
        public static int realizarEncuesta()
        {
            string texto = "================================\n" +
                "Nivel de Satisfacción\n" +
                "================================\n" +
                "¿Qué tan satisfecho está con la\n" +
                "atención de nuestra tienda?\n" +
                "1: Nada satisfecho\n" +
                "2: No muy satisfecho\n" +
                "3: Tolerable\n" +
                "4: Satisfecho\n" +
                "5: Muy satisfecho\n" +
                "================================\n";
            Console.Write(texto);
            int nivel = Operaciones.getEntero("Ingrese una opción:", texto);

            if (contador == 100)
            {
                Console.WriteLine("La lista ya esta llena");
            }
            arreglo[contador] = nivel;
            contador++;

            string texto2 = "================================\n" +
                "1: Registrar otra encuesta\n" +
                "2: Regresar\n";


            Console.Write(texto2);
            int opcion = Operaciones.getEntero("Ingrese una opción:", texto);
            if (opcion == 2) return 0;
            return opcion;
        }
        public static int verDatosRegistrados()
        {
            string texto = "================================\n" +
                "Ver datos registrados\n" +
                "================================\n";
            Console.Write(texto);

            if (contador == 0)
            {
                Console.WriteLine("No hay datos");
            }
            for (int i = 0; i < contador; i++)
            {
                if (i == contador)
                {
                    Console.Write(arreglo[i] + " [] ");
                }
                else
                {
                    Console.Write("[" + arreglo[i] + "] ");
                }

            }
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0;

            for (int i = 0; i < contador; i++)
            {
                if (arreglo[i] == 1)
                {
                    c1++;
                }
                else if (arreglo[i] == 2)
                {
                    c2++;
                }
                else if (arreglo[i] == 3)
                {
                    c3++;
                }
                else if (arreglo[i] == 4)
                {
                    c4++;
                }
                else
                {
                    c5++;
                }
            }


            Console.Write("\n" + "0" + c1 + " personas: Nada satisfecho" +
                "\n" + "0" + c2 + " personas: No muy satisfecho" +
                "\n" + "0" + c3 + " personas: Tolerable" +
                "\n" + "0" + c4 + " personas: Satisfecho" +
                "\n" + "0" + c5 + " personas: Muy satisfecho");



            string texto2 = "\n================================" +
                "\n1: Regresar\n";


            Console.Write(texto2);
            int opcion = Operaciones.getEntero("\nIngrese una opción: ", texto);
            if (opcion == 1) return 0;
            return opcion;


        }
        public static int eliminarUnDato()
        {
            string texto = "================================\n" +
                "Eliminar un dato\n" +
                "================================\n";
            Console.Write(texto);

            for (int i = 0; i < contador; i++)
            {
                Console.Write("00" + i + ":[" + arreglo[i] + "] ");
            }

            string texto1 = "\n================================" +
                "\nIngrese la posición a eliminar:";
            Console.Write(texto1);
            int posicion = int.Parse(Console.ReadLine());

            string texto2 = "\n================================\n";

            Console.Write(texto2);

            int[] nuevoArreglo = new int[contador - 1];

            for (int i = 0; i < contador - 1; i++)
            {
                if (posicion > i)
                {
                    nuevoArreglo[i] = arreglo[i];
                }
                else
                {
                    nuevoArreglo[i] = arreglo[i + 1];
                }

            }

            arreglo = nuevoArreglo;


            for (int i = 0; 1 < contador - 1; i++)
            {
                Console.Write("00" + i + ":[" + arreglo[i] + "] ");
            }


            string texto3 = "\n================================" +
                "\n1: Regresar\n";


            Console.Write(texto3);
            int opcion = Operaciones.getEntero("\nIngrese una opción: ", texto);
            if (opcion == 1) return 0;
            return opcion;
        }

    }
}
