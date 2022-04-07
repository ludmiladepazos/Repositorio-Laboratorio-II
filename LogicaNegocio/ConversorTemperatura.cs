using System;

namespace LogicaNegocio
{
    public class ConversorTemperatura
    {
        private const float ceroAbsoluto = 273.15f;
        public static float ConvertirCelsiusAkelvin(float temperaturaCelsius) 
        {
            return temperaturaCelsius + ceroAbsoluto;
        }

        public static float ConvertirKelvinACelsius(float temperaturaKelvin)
        {
            return temperaturaKelvin - ceroAbsoluto;
        }


    }
}


/*las constantes son tratadas como static
 * si la clase tiene el modificador static, todo lo q contenga tiene q ser static
 * salvo que sea una constante
 * 
