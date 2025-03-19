namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Funcion que imprime un mensaje
            Show();
            //Funcion que imprime una suma de 2 numeros enteros
            Suma(1, 5);
            //Funcion que imprime la multiplicacion de 2 numeros enteros
            int m = Multi(5, 10);
            Console.WriteLine(m); //Para poder imprimir el resultado de la funcion Multi

        }
        //Funcion que regresa un valor int y multiplica 2 numero enteros
        static int Multi(int n1, int n2)
        {
            return (n1 * n2);
        }

        //Funcion que suma 2 numeros
        static void Suma(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }

        //Funcion que imprime un mensaje
        static void Show()
        {
            Console.WriteLine("Mensaje por medio de una funcion");
        }
    }
}