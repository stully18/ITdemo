//Snowboarder shane = new Snowboarder("Goofy", "Male", 31,4);

/*shane.GetHealth();
shane.Eat();
shane.GetHealth();
shane.GetStance();
shane.SwitchStance();
shane.GetStance();*/

System.Console.WriteLine("Welcome to Shane's Resort! Create your Rider!");
System.Console.Write("Choose your sport! 1. Skier 2. Snowboarder (1 or 2): ");

int sport = int.Parse(Console.ReadLine());

if (sport == 1)
{
    System.Console.WriteLine("You chose Sking!");
}
else if (sport == 2)
{
    System.Console.WriteLine("You chose Snowboarding!");
}
else
{
    System.Console.WriteLine("Please input valid number!");
}