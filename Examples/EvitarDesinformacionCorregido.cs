using System;

namespace CleanCodeExamples.Examples
{

class EvitarDesinformacionCorregido
{
    public static void Ejecutar()
    {
            int puntosAnotados = 30;
            int bonificacionPorVictoria = 10;
            int puntosTotales = puntosAnotados + bonificacionPorVictoria;

            Console.WriteLine($"Puntos totales del equipo en la temporada: {puntosTotales}");
        }
    }
}