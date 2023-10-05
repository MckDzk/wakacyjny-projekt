class Program
{
    static void Main(string[] args)
    {
        Game game = new Game("gracz", 100, 100);

        while (true)
        {
            game.GenerateRoom(); 
            game.Start();

            break;
            
        }
    }
}