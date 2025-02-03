using System;

namespace CleanCodeEstadisticas.Ejemplos
{
    class NombresPronunciablesCorregido
    {
        public static void Ejecutar()
        {
            int partidosGanados = 10;
            int partidosPerdidos = 5;
            int totalPartidosJugados = partidosGanados + partidosPerdidos;

            Console.WriteLine($"Total de partidos jugados en la temporada: {totalPartidosJugados}");
        }
    }
}
