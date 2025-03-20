namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 6;

            switch(op)
            {
                case 1:
                    Console.WriteLine("Caso 1");
                    break;
                case 2:
                    Console.WriteLine("Caso 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Seleccionaste el caso 3 o 4");
                    break;
                case < 0:
                case > 20:
                    Console.WriteLine("Fuera de rango");
                    break;
                case > 5 and < 10:
                    Console.WriteLine("Estas en el rango de > 5 y < 10");
                    break;
                default:
                    Console.WriteLine("No hay mas datos...");
                    break;
            }
        }
    }
}