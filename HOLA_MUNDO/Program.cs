using System; // using es parecido al include, usamos todo lo q tiene la clase system, system tambien es un namespace

namespace HOLA_MUNDO // bolsa de cosas, todo lo que esta aca adentro va a tener cierto nivel de visibilidad, entre bolsas pueden verse con el using
{
    internal class Program
    {
        static void Main(string[] args) //punto de entrada de nuestros programas en .net, primer metodo(funcion) que se ejecuta
        {
            string nombre;
            string edadString;
            int edad;
            bool resultado; //true o false
            int[] numeros = new int[5];
            int[] numeros = new int[] { 1, 2, 3, 4, 5 };
            
            Console.WriteLine("Ingrese su nombre"); //salida de datos, imprime en pantalla
            nombre = Console.ReadLine(); //entrada de datos, lee datos de pantalla, readline retorna un string, lee cadena de caracteres
            Console.WriteLine("Ingrese edad");
            edadString = Console.ReadLine();

            resultado = int.TryParse(edadString,out edad);//retorna un booleano, un true o false, si se pudo convertir o no
            string numeroTexto = edad.ToString(); //convertir ese valor en string
            
            Console.WriteLine("El nombre ingresado es {0} y mi edad es {1}",nombre,edad);
            //Console.WriteLine($"El nombre ingresado es {nombre} y mi edad es {edad}");

            Console.ReadKey(); //ponerlo por default, para cuando lo ejecutamos desde el .exe

            //ejemplo de uso do while
            do
            {
                Console.WriteLine("ingrese un numero");
                numeroTexto = Console.ReadLine();
                resultado = int.TryParse(numeroTexto, out numero);

            } while (!resultado); //mientras resultado de false va a seguir pidiendo numeros, cuando resultado de true sale del while
            
            
        }
    }
}




/*
//escalares
const int NUMERO = 10;
decimal dec = 2;
float puntoFlotante = 5.5F;

//no escalares
int[] numeros = new int[25]; //new reserva nuevo espacio de memoria
System.Collections.Generic.List<int> lista = new System.Collections.Generic.List<int>(); */

