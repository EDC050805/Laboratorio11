using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio11.Interfaces
{
    public class Operaciones
    {
        public static int getEntero(string prefijo)
        {
            int respuesta;
            bool correcto;

            string numeroTexto = getTextoPantalla(prefijo);
            correcto = int.TryParse(numeroTexto, out respuesta);
            if (!correcto)
            {
                Console.WriteLine("\n Ingresa un número válido");
                Console.ReadKey();
                Console.Clear();
                Interfaz.MenuPrincipal();
            }

            return respuesta;
        }

        public static float getDecimal(string prefijo)
        {
            float respuesta;
            bool correcto;

            do
            {
                string numeroTexto = getTextoPantalla(prefijo);
                correcto = float.TryParse(numeroTexto, out respuesta);

                if (!correcto)
                {
                    Console.WriteLine("Ingresa un número válido");
                }

            } while (!correcto);

            return respuesta;
        }

        public static string getTextoPantalla(string prefijo)
        {
            Console.Write(prefijo);
            return Console.ReadLine();
        }
    }
}
