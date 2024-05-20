using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace EjercicioExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            bool continuar = true;

            while (continuar)
            {
                MostrarMenu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        EjecutarOperacion(operaciones.Sumar, "Sumar");
                        break;
                    case "2":
                        EjecutarOperacion(operaciones.Restar, "Restar");
                        break;
                    case "3":
                        EjecutarOperacion(operaciones.Multiplicar, "Multiplicar");
                        break;
                    case "4":
                        EjecutarOperacion(operaciones.Dividir, "Dividir");
                        break;
                    case "5":
                        continuar = false;
                        Console.WriteLine("Salir del programa");
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("*********Menú*********");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");
        }

        static void EjecutarOperacion(Func<double, double, double> operacion, string nombreOperacion)
        {
            try
            {
                Console.Write($"Ingrese el primer número para {nombreOperacion}: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Ingrese el segundo número para {nombreOperacion}: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = operacion(num1, num2);
                Console.WriteLine($"El resultado de {nombreOperacion} {num1} y {num2} es: {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Números inválidos");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}
