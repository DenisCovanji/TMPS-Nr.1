namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCart.GetInstance().GetCartPrice("99");
            Console.ReadLine();
        }
    }
}