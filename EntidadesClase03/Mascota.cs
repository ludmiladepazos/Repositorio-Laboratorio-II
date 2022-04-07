using System;

namespace EntidadesClase03
{
    public class Mascota //clase = plantilla o molde que me permite crear distintos objetos
    {
        //ATRIBUTOS DE LA CLASE
        public string nombre;
        public string raza;
        public int edad;
        public string especie;
        public bool hambre;

        //instancio los objetos a traves de su contructor - - - - parametrizado:
        public Mascota(string nombre,string especie,int edad) 
        {
            this.nombre = nombre;
            this.especie = especie;
            this.edad = edad;
        }

        //METODO DE INSTANCIA, ES UN METODO DEL OBJETO
        public string Saludar() //con this hago referencia a esta instancia, a esta variable (instancia = cuando creamos un objeto es una instancia de esta clase)
        {
            return $"Hola mi nombre es {this.nombre} soy un {this.especie} y mi edad es {this.edad} "; //this = hago referencia a este objeto creado
        }

        //METODO ESTATICO , ES UN METODO DE LA CLASE
        public static void Alimentar(Mascota mascota) //si la mascota tiene hambre==true la alimento y ya no tiene.
        {
            if (mascota.hambre) 
            {
                mascota.hambre = false; 
               
            }
        }

        //EL OBJETO LO CREO EN LA VISTA
        //PARA USAR LA LOGICA EN LA VISTA TENGO Q AGREGARLA, ASI EN LA VISTA ACCEDO A MI CLASE MASCOTA

        /*
         * atributos que son de la clase (estaticos) = atributos que pueden llegar a ser compartidos por todos los objetos
         * que voy a crear, atributo que va a ser el mismo para todos los objetos
         * atributos que son de instancia (del objeto) , ejemplo el nombre, cada mascota va a tener un nombre distinto
         * 
         * OBJETOS : son clases instanciadas que se crean en tiempo de ejecucion
         * son instancias de una clase, una instancia es una manifestacion concreta de algo
         * las clases son moldes o planos a partir de los cuales se crean los objetos
         * INSTANCIAR : crear un objeto a partir de una clase
         * para crear un objeto se necesita la palabra reservada new
         * para acceder a los metodos o atributos el operador punto (.)
         * 
         * Los objetos los vamos a instanciar a traves de su CONSTRUCTOR: un constructor es un metodo especial
         * cuya fx es darle un valor inicial a ls atributos de un objeto para asegurar el correcto funcionamiento del mismo
         * new mascosta() = contructor por defecto, sin parametros
         * 
         * NEW = adquiere y reserva memoria binaria sin inicializar
         * el constructor inicializa atributos con un valor (null, 0 y false, por defecto
         * los objetos son valores x referencia
         * 
         * Destruccion de un objeto : dentro del clr tenemos el garbage collector
         * Estado de un objeto : son los valores que toman sus atributos en un determinado momento
         * 
         * CREACION = INSTANCIAR
         * 
         * Una variable no almacena el objeto mismo sino su “dirección en memoria”, 
         * en otras palabras “una referencia” a él.
         * 
         */

    }
}
