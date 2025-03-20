namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Friends = new string[6]
            {
                "Juan",
                "Pedro",
                "Pablo",
                "Maria",
                "Jose",
                "Jorge"
            };
            bool run = true;
            for (int i = 0; i<Friends.Length && run; i++)
            {
                Console.WriteLine(Friends[i]);
            }
        }
    }
}