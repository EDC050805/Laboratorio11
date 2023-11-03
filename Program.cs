using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t   Registro de notas");
            Console.WriteLine("\t   *****************\n");
            int opcion = Interfaz.MenuPrincipal();

            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 0:
                        opcion = Interfaz.MenuPrincipal();
                        break;
                    case 1:
                        opcion = Interfaz.RegistrarNotas();
                        break;
                    case 2:
                        opcion = Interfaz.NotaMayor();
                        break;
                    case 3:
                        opcion = Interfaz.NotaMenor();
                        break;
                    case 4:
                        opcion = Interfaz.EncontrarNota();
                        break;
                    case 5:
                        opcion = Interfaz.ModificarNota();
                        break;
                    case 6:
                        opcion = Interfaz.VerNotas();
                        break;
                }
            } while (opcion != 7);

            Console.Clear();
            Console.WriteLine(" Gracias por usar el programa.\n");
            Console.WriteLine(" Hecho por: Elías Díaz.");
        }
    }
}
