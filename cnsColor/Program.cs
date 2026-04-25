Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("Красный текст на зелёном фоне");
Console.ResetColor();
Console.WriteLine("Обычный текст");
Console.WriteLine();

// Q: Как распечатать все доступные цвета в столбик?
Console.WriteLine("ConsoleColor:");
foreach (var i in Enum.GetValues<ConsoleColor>())
{
    Console.Write($"{i:X} | {i,2:D} | ");
    Console.BackgroundColor = i;
    Console.WriteLine(i);
    Console.ResetColor();
}