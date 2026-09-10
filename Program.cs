using System.ComponentModel;

Rider rider;

// Rider creation
while (true)
{
    System.Console.WriteLine("Welcome to Shane's Resort! Create your Rider!");
    System.Console.Write("Choose your sport! 1. Skier 2. Snowboarder (1 or 2): ");

    string? sportInput = Console.ReadLine();

    if (!int.TryParse(sportInput, out int sport))
    {
        System.Console.WriteLine("Please input a valid number!");
        continue;
    }

    if (sport == 1)
    {
        System.Console.WriteLine("You chose Skiing!");
        rider = Skier.CreateFromInput();
        break;
    }
    else if (sport == 2)
    {
        System.Console.WriteLine("You chose Snowboarding!");
        rider = Snowboarder.CreateFromInput();
        break;
    }
    else
    {
        System.Console.WriteLine("Please input valid number!");
    }
}

System.Console.WriteLine("\nYour rider is ready!");
rider.GetStats();

// Main action loop
while (true)
{
    System.Console.WriteLine("");
    System.Console.WriteLine("What do you want to do?");
    System.Console.WriteLine("1. Do a trick");
    System.Console.WriteLine("2. Eat");
    System.Console.WriteLine("3. Show stats");

    if (rider is Skier)
    {
        System.Console.WriteLine("4. Toggle poles");
    }
    else
    {
        System.Console.WriteLine("4. Switch stance");
    }

    System.Console.WriteLine("5. Quit");
    System.Console.Write("Choose: ");

    string? choice = Console.ReadLine();

    if (choice == "1")
    {
        rider.doTrick();
    }
    else if (choice == "2")
    {
        rider.Eat();
    }
    else if (choice == "3")
    {
        rider.GetStats();
    }
    else if (choice == "4")
    {
        if (rider is Skier sk)
        {
            sk.TogglePoles();
        }
        else if (rider is Snowboarder sb)
        {
            sb.SwitchStance();
        }
    }
    else if (choice == "5")
    {
        System.Console.WriteLine("Thanks for riding at Shane's Resort!");
        break;
    }
    else
    {
        System.Console.WriteLine("Please choose 1-5.");
    }
}