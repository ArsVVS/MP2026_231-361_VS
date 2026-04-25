using libCore;

namespace cnaGameCounter
{
    internal class Program
    {
        private static Game game;

        static void Main(string[] args)
        {
            Console.WriteLine("Игра 'Устный счет'");

            game = new Game();
        }
    }
}
