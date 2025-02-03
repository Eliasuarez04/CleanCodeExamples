using System;

namespace CleanCodeExamples.Examples
{

class NombresReveladoresCorregido
{
    public static void Ejecutar()
    {
         int partidosGanados = 10;
            int partidosPerdidos = 5;
            int totalPartidos = partidosGanados + partidosPerdidos;

            Console.WriteLine($"Total de partidos jugados: {totalPartidos}");
        }
    }
}