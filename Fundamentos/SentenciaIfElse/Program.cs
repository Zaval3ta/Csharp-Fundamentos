namespace SentenciaIfElse
{
    class Program
    {
        static void Main(string[]args)
        {
            bool areYouHungry = true;
            bool youHaveMoney = true;

            if(areYouHungry && youHaveMoney && IsOpenRestaurant("McDonalds", 9))
            {
                System.Console.WriteLine("Puedes comer");
            }
            else
            {
                System.Console.WriteLine("No puedes comer");
            }
        }

        static bool IsOpenRestaurant(string name, int hour = 0)
        {
            if(name == "McDonalds" && hour > 8 && hour < 23)
            {
                return true;
            }
            else if(name == "Restaurante 24 horas")
            {
                return true;
            }else
            { return false; }
        }
    }
}