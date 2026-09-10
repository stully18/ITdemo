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
        return usesPoles;
    }
}