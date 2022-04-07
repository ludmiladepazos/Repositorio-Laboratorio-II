using System;
using clase_02;
using LogicaNegocio;



namespace clase_02
{
    class Program //si no le pongo modificador de visibilidad son internal por defecto
    {
        static float temperaturaCelcius; //si no pongo modificador de accesibilidad son privadas por defecto
        static float temperaturaKelvin;
        
        static void Main(string[] args) //si el metodo es statico no puedo ingresar algo no statico
        {
            llllllClass1.hola();
            temperaturaCelcius = 30;
            temperaturaKelvin = ConversorTemperatura.ConvertirCelsiusAkelvin(temperaturaCelcius);
            MostrarTemperaturas();
            
        }

        static void MostrarTemperaturas()
        {
            Console.WriteLine($"La temperatura celcius es {temperaturaCelcius}"); //$ string interpolado
            Console.WriteLine($"La temperatura kelvin es {temperaturaKelvin}");
        }
        
       
    }


}
