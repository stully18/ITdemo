while (true)
{   
    System.Console.WriteLine("Welcome to Shane's Resort! Create your Rider!");
    System.Console.Write("Choose your sport! 1. Skier 2. Snowboarder (1 or 2): ");

    int sport = int.Parse(Console.ReadLine());

    if (sport == 1)
    {
        System.Console.WriteLine("You chose Sking!");
        Skier user1 = Skier.CreateFromInput();
        break;
    }
    else if (sport == 2)
    {
        System.Console.WriteLine("You chose Snowboarding!");
        Snowboarder user2 = Snowboarder.CreateFromInput();
        break;
    }
    else
    {
        System.Console.WriteLine("Please input valid number!");
    }
}