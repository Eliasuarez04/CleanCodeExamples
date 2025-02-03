using System;

namespace CleanCodeExamples.Examples
{

class CodigoZombie
{
    public static void Ejecutar()
    {
        
        int victorias = 18;
        int partidosJugados = 30;
        int golesAFavor = 45;
        int golesEnContra = 25;

        
        int empates = 5;
        string equipo = "Los Tigres";
        MostrarMensaje(); 

        
        double porcentajeVictorias = (double)victorias / partidosJugados * 100;
        double promedioGoles = (double)golesAFavor / partidosJugados;
        double eficienciaEquipo = golesAFavor - golesEnContra;

        
        Console.WriteLine($"Porcentaje de victorias: {porcentajeVictorias:F2}%");
        Console.WriteLine($"Promedio de goles por partido: {promedioGoles:F2}");
        Console.WriteLine($"Eficiencia del equipo (Diferencia de goles): {eficienciaEquipo}");
    }

    
    static void MostrarMensaje()
    {
        Console.WriteLine("Este mensaje nunca se verá.");
        }
    }
}
