using System;

namespace CleanCodeExamples.Examples
{

class CodigoAutodocumentado
    {
    public static void Ejecutar()
        {
        int v = 18; // Número de victorias del equipo
        int p = 30; // Número total de partidos jugados
        int g = 45; // Goles anotados en la temporada
        int gc = 25; // Goles recibidos en la temporada

        double pv = (double)v / p * 100; // Calculamos el porcentaje de victorias
        double pg = (double)g / p; // Calculamos el promedio de goles
        double e = g - gc; // Calculamos la eficiencia del equipo

        Console.WriteLine("Estadísticas:");
        Console.WriteLine("Porcentaje de victorias: " + pv + "%");
        Console.WriteLine("Promedio de goles: " + pg);
        Console.WriteLine("Eficiencia: " + e);
        }
    }
}