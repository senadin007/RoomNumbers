string affirmation;
do
{
    Console.WriteLine("--------------------------------------------------");
    Console.Write("Please enter room number: ");
    var input = Console.ReadLine();
    var digit = 0;

    while (!int.TryParse(input, out digit) || digit > 1000000 || digit < 0)
    {
        Console.WriteLine("Error invalid entry!");
        Console.WriteLine("");
        Console.Write("Please enter room number: ");
        input = Console.ReadLine();
    }

    var roomNbr = new RoomNumber.roomNumber();
    Console.WriteLine("Number of sets: {0}", roomNbr.numberOfSets(digit));
    Console.WriteLine("--------------------------------------------------");

    Console.WriteLine("Continue? (Y/N)");
    affirmation = Console.ReadLine();
} while (affirmation == "Y");
