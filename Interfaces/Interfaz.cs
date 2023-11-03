using Laboratorio11.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;  
using System.Threading.Tasks;

namespace Laboratorio11
{
    public class Interfaz
    {
        public static float[] Notas = new float[200];
        public static int elementos = 0; //Cantidad de valores en el array
        public static void Encabezado(string titulo)
        {
            Console.WriteLine($" ======================================\n {titulo}\n ======================================");
        }
        public static void Espaciado()
        {
            Console.WriteLine(" ======================================");
        }
        public static int MenuPrincipal()
        {
            Encabezado(" Casos con arreglos");
            Console.WriteLine(" 1: Registrar notas\n" +
            " 2: Hallar la nota mayor\n" +
            " 3: Hallar la nota menor\n" +
            " 4: Encontrar una nota\n" +
            " 5: Modificar una nota\n" +
            " 6: Ver notas registradas\n" +
            " 7: Salir");
            Espaciado();
            return Operaciones.getEntero(" Ingrese una opción: ");
        }
        public static int RegistrarNotas()
        {
            ConsoleKey opcion;

            do
            {
                Encabezado(" Registrar una nota");
                if (elementos == Notas.Length)
                {
                    Console.WriteLine(" La capacidad de registro de notas ha llegado a su límite. Cargue el programa nuevamente.");
                    return 0;
                }

                float nota = Operaciones.getDecimal($" Ingrese la nota Nro. {elementos + 1}: ");
                Notas[elementos] = nota;
                Espaciado();
                Console.WriteLine(" 1: Registrar otra nota\n 2: Regresar");
                opcion = Console.ReadKey().Key;
                Console.Clear();
                elementos++;
            } while (opcion == ConsoleKey.D1);

            return 0;
        }
        public static int NotaMayor()
        {
            float mayor = Notas[0];
            int l = 0; //Posición en donde están las coincidencias
            int j = 0; //Posición en donde están los números mayores
            int[] Coincidencias = new int[200];
            Encabezado(" La nota mayor");

            if (elementos == 0)
            {
                Console.WriteLine(" La base de datos está vacía. Ingrese una nota para continuar, por favor.");
                return 0;
            }
            else
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (Notas[i] >= mayor)
                    {
                        mayor = Notas[i];
                    }
                    if (i == elementos - 1)
                    {
                        Console.WriteLine($" La nota mayor es: {mayor}");
                    }
                }
                for (int i = 0; i < elementos; i++)
                {
                    if (Notas[i] == mayor)
                    {
                        Coincidencias[j] = i;
                        j++;
                    }
                }
                for (int i = 0; i < elementos; i++)
                {
                    if (i == Coincidencias[l])
                    {
                        Console.Write($" [{Notas[Coincidencias[l]]}]");
                        l++;
                    }
                    else { Console.Write($" {Notas[i]}"); }
                }
                Console.WriteLine(" ");
                Espaciado();
                Console.WriteLine(" 1: Regresar");
                Console.ReadKey();
            }
            return 0;
        }
        public static int NotaMenor()
        {
            float menor = Notas[0];
            int l = 0; //Posición en donde están las coincidencias
            int j = 0; //Posición en donde están los números menores
            int[] Coincidencias = new int[200];
            Encabezado(" La nota menor");

            if (elementos == 0)
            {
                Console.WriteLine(" La base de datos está vacía. Ingrese una nota para continuar, por favor.");
                return 0;
            }
            else
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (Notas[i] < menor)
                    {
                        menor = Notas[i];
                    }
                    if (i == elementos - 1)
                    {
                        Console.WriteLine($" La nota menor es: {menor}");
                    }
                }
                for (int i = 0; i < elementos; i++)
                {
                    if (Notas[i] == menor)
                    {
                        Coincidencias[j] = i;
                        j++;
                    }
                }
                for (int i = 0; i < elementos; i++)
                {
                    if (i == Coincidencias[l])
                    {
                        Console.Write($" [{Notas[Coincidencias[l]]}]");
                        l++;
                    }
                    else { Console.Write($" {Notas[i]}"); }
                }
                Console.WriteLine(" ");
                Espaciado();
                Console.WriteLine(" 1: Regresar");
                Console.ReadKey();
            }
            return 0;
        }
        public static int EncontrarNota()
        {
            Encabezado(" Buscar nota");
            int l = 0; //Posición en donde están las coincidencias
            int j = 0; //Posición de los números iguales al que se quiere buscar
            int[] Coincidencias = new int[200];
            float notaBuscar = float.Parse(Operaciones.getTextoPantalla(" Ingrese la nota a buscar: "));

            if (elementos == 0)
            {
                Console.WriteLine(" La base de datos está vacía. Ingrese una nota para continuar, por favor.");
                return 0;
            }
            else
            {
                for (int i = 0; i < elementos; i++)
                {
                    if (Notas[i] == notaBuscar)
                    {
                        Coincidencias[j] = i;
                        j++;
                    }
                    if (i == elementos - 1)
                    {
                        Console.Write(" La nota está en la/s posición/ones");

                        if (j == 1)
                        {
                            Console.Write($" {Coincidencias[0]}");
                        }
                        else
                        {
                            for (int k = 0; k < j; k++)
                            {
                                if (k == j - 1) { Console.Write($" {Coincidencias[k]}"); }
                                else { Console.Write($" {Coincidencias[k]},"); }
                            }
                        }
                    }
                }
                Console.WriteLine(" ");
                for (int i = 0; i < elementos; i++)
                {
                    if (i == Coincidencias[l])
                    {
                        Console.WriteLine($" {i} -> [{Notas[Coincidencias[l]]}]");
                        l++;
                    }
                    else { Console.WriteLine($" {i} -> {Notas[i]}"); }
                    
                }

                Espaciado();
                Console.WriteLine(" 1: Regresar");
                Console.ReadKey();
            }
            return 0;
        }
        public static int ModificarNota()
        {
            Encabezado(" Modificar nota");

            if (elementos == 0)
            {
                Console.WriteLine(" La base de datos está vacía. Ingrese una nota para continuar, por favor.");
                return 0;
            }
            else
            {
                int posicion = int.Parse(Operaciones.getTextoPantalla(" Ingrese la posición: "));
                float nuevoValor = float.Parse(Operaciones.getTextoPantalla(" Ingrese el nuevo valor: "));
                Espaciado();
                Console.WriteLine(" Antes: ");

                for (int i = 0; i < elementos; i++)
                {
                    if (i == posicion) { Console.Write($" [{Notas[posicion]}]"); }
                    else { Console.Write($" {Notas[i]}"); }
                }
                Console.WriteLine(" ");
                Console.WriteLine(" Después: ");

                for (int i = 0; i < elementos; i++)
                {
                    if (i == posicion)
                    {
                        Notas[posicion] = nuevoValor;
                        Console.Write($" [{Notas[posicion]}]");
                    }
                    else { Console.Write($" {Notas[i]}"); }
                }
            }
            Console.WriteLine(" ");
            Espaciado();
            Console.WriteLine(" 1: Regresar");
            Console.ReadKey();
            return 0;
        }
        public static int VerNotas()
        {
            Encabezado(" Notas registradas");

            if (elementos == 0)
            {
                Console.WriteLine(" La base de datos está vacía. Ingrese una nota para continuar, por favor.");
                return 0;
            }
            else
            {
                Console.WriteLine(" Notas actuales: \n");

                for (int i = 0; i < elementos; i++)
                {
                    Console.Write($" {Notas[i]} ");
                    if (i < (elementos - 1))
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine("\n");
                Console.WriteLine($" Siguiente posición será: {elementos}\n");
                Espaciado();
                Console.WriteLine(" 1: Regresar");
                Console.ReadKey();
                return 0;
            }
        }
    }
}
