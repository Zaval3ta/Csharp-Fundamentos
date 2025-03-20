namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Iteracion de i: " + i);
                i++;
            }

            int j = 0;
            while (j < 100)
            {
                {
                    if (j > 20) { break; }
                }
                Console.WriteLine("Iteracion de J: " + j);
                j++;
            }
            Console.WriteLine("Array de amigos");
            string[] amigos = new string[6] 
            { 
                "Juan", 
                "Pedro", 
                "Pablo", 
                "Maria", 
                "Jose",
                null 
            };
            int index = 0;
            while (index < amigos.Length)
            {
                Console.WriteLine(amigos[index]);
                index++;
            }
            bool run = false;
            do
            {
                Show();
            } while (run);
        }

        static void Show()
        { 
            Console.WriteLine("Entro una vez y ya"); 
        }
    }
}