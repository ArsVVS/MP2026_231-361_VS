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
            game.ChangeQuestion += () => Console.WriteLine($"Вопрос: {game.QuestionLine}");
            game.ChangeStat += () => Console.WriteLine($"Статистика: Верно = {game.CountCorrect}, Неверно = {game.CountInorrect}");
            game.Restart();

            while (true)
            {
                Console.WriteLine("Ответ Y/N ?");
                var line = Console.ReadLine()?.ToUpper();

                if (line == "Y")
                    game.Answer(true);
                else if (line == "N")
                    game.Answer(false);
                else
                    break;
            }
            Console.WriteLine("Пока!");
        }
    }
}
