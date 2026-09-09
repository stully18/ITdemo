class Skier : Rider
{   
    bool usesPoles = true;

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
                message = $"You failed!  You lost {trickDamage} health :()";
            }
            else if (usesPoles == false)
            {
                health -= trickDamage - 5;
                message = $"You failed!  You lost {trickDamage + 5} health :()";
            }
            else
            {
                System.Console.WriteLine("ERROR!");
            }
            System.Console.WriteLine(message);
        }
    }
}