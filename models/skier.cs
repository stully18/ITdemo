using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

class Skier : Rider
{   
    private bool usesPoles = true;

    public Skier(bool usesPoles, string gender, int age, int experience) : base(gender, age, experience)
    {
        this.usesPoles = usesPoles;
    }

    public override void doTrick()
    {
        string message = "";

        if (willLand(10) == true)
        {
            System.Console.WriteLine("You landed the trick!");
        }
        else
        {
            if (usesPoles == true)
            {
                health -= trickDamage;
                message = $"You failed the trick!  You lost {trickDamage} health. Current health {health}";
            }
            else if (usesPoles == false)
            {
                health -= trickDamage + 5;
                message = $"You failed!  You lost {trickDamage + 5} health. Current health {health}";
            }
            else
            {
                System.Console.WriteLine("ERROR!");
            }
            System.Console.WriteLine(message);
        }
    }

    public void TogglePoles()
    {
        if (usesPoles == true)
        {
            usesPoles = false;
            System.Console.WriteLine("Now you don't have any polls!");
        }
        else if (usesPoles == false)
        {
            usesPoles = true;
            System.Console.WriteLine("You have equipped poles!");
        }
        else
        {
            System.Console.WriteLine("ERROR!");
        }
    }

    public bool HasPolls()
    {
        System.Console.WriteLine($"{usesPoles}");
        return usesPoles;
        
    }

    public static Skier CreateFromInput()
    {
        bool usesPoles = false;
        int age;
        int experience;
        string gender = "";
        string response = "";
        
        System.Console.WriteLine("Lets Build your skier!");
        while (true)
        {
        System.Console.Write("First Question! Will your Skier have polls? y/n: ");
        response = Console.ReadLine()?.ToLower();
        if (!string.IsNullOrWhiteSpace(response) && response == "y")
        {
            usesPoles = true;
            break;
        }
        else if (!string.IsNullOrWhiteSpace(response) && response == "n")
        {
            usesPoles = false;
            break;
        }
        else
        {
            System.Console.WriteLine($"{response} is not Valid. Please select y or n!");
        }
        }


        while (true)
        {
            System.Console.Write("Enter age:  ");
            response = Console.ReadLine();
            if (int.TryParse(response, out age))
            {
                break;
            }
            else
            {
                System.Console.WriteLine("Error inegers only!");
            }   
        }


        while (true)
        {
            System.Console.Write("Enter years of Experience:  ");
            response = Console.ReadLine();
            if (int.TryParse(response, out experience))
            {
                break;
            }
            else
            {
                System.Console.WriteLine("Enter Integers Only!!");
            } 
        }


        while (true)
        {
            System.Console.Write("Enter Gender:  ");
            response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response)){
                gender = response;
                break;
            }
            else
            {
                System.Console.WriteLine("Please enter a gender!");
            }
        }

        return new Skier(usesPoles, gender, age, experience);
    }
}