using System;
using EntidadesClase03;

namespace VistaClase03
{
     internal class Program
    {
        static void Main(string[] args)
        {
            /*Mascota perro = new Mascota(); 
            *genero una instancia, genero un objeto de tipo mascota ,new mascota () constructor por defecto
            perro.raza = "cocker";
            perro.edad = 4;
            perro.nombre = "perrito malvado";
            perro.especie = "perro";

            Mascota perro = new Mascota("perrito malvado","perro",4);

            Mascota gato = new Mascota();
            gato.raza = "persa";
            gato.edad = 5;
            gato.nombre = "bola de nieve";
            gato.especie = "gato";

            //acceder metodo instancia
            Console.WriteLine(perro.Saludar());

            //acceder metodo estatico de clase
            Mascota.Alimentar(perro);*/


            Auto autoUno = new Auto("AAA000", "FORD", "FALCON");
            Auto autoDos = new Auto("AAA001", "Fiat", "duna");

            Console.WriteLine(autoUno.GetPatente());
            Console.WriteLine(autoDos.GetPatente());
            autoUno.SetPatente("CAMBIE LA PATENTE DE AUTO UNO");
            Console.WriteLine(autoUno.GetPatente());

            autoUno.SetCantidadHoras(5);
            autoDos.SetCantidadHoras(1);
            Console.WriteLine($"El precio de la hora es {Auto.GetPrecioHora()}");

            Console.WriteLine($"El importe a pagar de auto A1 es {autoUno.CalcularCostoEstadia()}");
            Console.WriteLine($"El importe a pagar de auto A2 es {autoDos.CalcularCostoEstadia()}");

            Console.ReadKey();


            

        }
    }
}

/*como mis atributos son publicos puedo designarlos desde aca, puedo acceder a mis atributos con operador (.)
si fuesen private deberia hacer getters y setters
>  < 
los atributos de la clase (estaticos) impactan en todos los objetos
la primera vez que empiezo a hacer uso de mi clase, lo primero es inicializar los atributos estaticos a traves
de mi constructor estatico

¿Qué son los MÉTODOS DE ACCESO?
Los métodos de acceso permiten consultar o modificar el valor los atributos de un objeto de forma segura
(sin romper el encapsulamiento).
Si el método es para consultar se dice que es un método getter.
Si el método es para modificar o asignar un nuevo valor, se dice que es un método setter.*/