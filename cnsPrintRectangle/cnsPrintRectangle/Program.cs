namespace cnsPrintRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ширина фигуры?");
            int w = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Высота фигуры?");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Символ фигуры?");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Заполнить фигуру? (y/n)");
        }
    }
}
