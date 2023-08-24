public class ConsoleReader
{

    public int? GetLineIntValue(string message)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            return number;
        }
        return null;

    }

}