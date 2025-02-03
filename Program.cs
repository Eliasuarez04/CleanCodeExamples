using System;
using CleanCodeEstadisticas.Ejemplos;
using CleanCodeExamples.Examples;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(" Ejemplos de Clean Code en C#");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("0. Salir");
            Console.WriteLine("1. Código Zombie");
            Console.WriteLine("2. Código Zombie Arreglado");
            Console.WriteLine("3. Código Autodocumentado");
            Console.WriteLine("4. Código Autodocumentado Corregido");
            Console.WriteLine("5. Nombres Reveladores");
            Console.WriteLine("6. Nombres Reveladores Corregido");
            Console.WriteLine("7. Evitar Desinformación");
            Console.WriteLine("8. Evitar Desinformación Corregido");
            Console.WriteLine("9. Nombres Pronunciables");
            Console.WriteLine("10. Nombres Pronunciables Corregido");
            Console.Write("\nSelecciona un número: ");
            
            string opcion = Console.ReadLine();
            Console.Clear();

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    CodigoZombie.Ejecutar();
                    break;
                case "2":
                    CodigoZombieArreglado.Ejecutar();
                    break;
                case "3":
                    CodigoAutodocumentado.Ejecutar();
                    break;
                case "4":
                    CodigoAutodocumentadoCorregido.Ejecutar();
                    break;
                case "5":
                    CodigoNombresReveladores.Ejecutar();
                    break;
                case "6":
                    NombresReveladoresCorregido.Ejecutar();
                    break;
                case "7":
                    EvitarDesinformacion.Ejecutar();
                    break;
                case "8":
                    EvitarDesinformacionCorregido.Ejecutar();
                    break; 
                case "9":
                    NombresPronunciables.Ejecutar();
                    break;
                case "10":
                    NombresPronunciablesCorregido.Ejecutar();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("❌ Opción no válida. Inténtalo de nuevo.");
                    break;
            }

            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
