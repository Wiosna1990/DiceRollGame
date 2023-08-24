public class GeneratorRandomNumber
{

    public void GenerateNumber()
    {
        Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
        Random rnd = new Random();
        bool validChoice = true;
        int sum = 0;

        do
        {

            var generatedNumber = rnd.Next(1, 6);
            var input = new ConsoleReader().GetLineIntValue("Enter a number:");

            if (input == generatedNumber)
            {
                Console.WriteLine("Youw win!");
                validChoice = false;
            }
            else if (input == null)
            {
                Console.WriteLine("Incorrect input");

            }
            else
            {
                Console.WriteLine("Wrong number");
                sum++;

                if (sum == 3)
                {
                    Console.WriteLine("You lose");
                    validChoice = false;
                }


            }


        } while (validChoice);

    }
}
