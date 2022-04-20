namespace Singleton
{
    class GameCart
    {
        private static GameCart _instance = null;

        public int Games { get; set; }

        private GameCart()
        {
            Console.WriteLine("The cart of games has been created. See the final price below.");
        }

        public static GameCart GetInstance()
        {
            if (_instance == null)
            {
                    if (_instance == null)
                        _instance = new GameCart();
            }
            return _instance;
        }
        public void GetCartPrice(string price)
        {
            Console.WriteLine($"The final price is {price} dollars.");
        }

    }
}
