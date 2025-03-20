using System.Collections.Concurrent;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una forma de guardas elementos en un Array
            string[] friends = new string[7];
            friends[0] = "Jim";
            friends[1] = "Kelly";
            friends[2] = "Kevin";
            friends[3] = "John";
            friends[4] = "Dwight";
            friends[5] = "Michael";
            friends[6] = "Pam";
            //Podemos definir los elementos desde un inicio
            string[] friends2 =
            {
                "Jim",
                "Kelly",
                "Kevin",
                "John",
                "Dwight",
                "Michael",
                null //Podemos definir un elemento nulo. Sirve para inicializar un array con un tamaño fijo y luego asignar valores
            
            };

            Console.WriteLine(friends2[0]);
            Console.WriteLine(friends2[1]);
            Console.WriteLine(friends2[2]);
            Console.WriteLine(friends2[3]);
            Console.WriteLine(friends2[4]);
            Console.WriteLine(friends2[5]);
            Console.WriteLine(friends2[6]); //No imprime nada porque el elemento 6 es nulo

            friends2[6] = "Pam"; //Asignamos un valor al elemento 6
            Console.WriteLine(friends2[6]); //Imprime Pam
        }
    }
}