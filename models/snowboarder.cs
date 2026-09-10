class Snowboarder : Rider
{
    public string stance = "";
    
    public Snowboarder(string stance, string gender, int age, int experience) : base(gender, age, experience)
    {
        this.stance = stance;
    }

    public void GetStance()
    {
        System.Console.WriteLine($"Stance: {stance}");
    }

    public void SwitchStance()
    {
        string letter = stance[0].ToString().ToLower();
        string oldStance = stance;

        if (letter == "g")
        {
            stance = "Regular";
            System.Console.WriteLine($"Rider switched stances! {oldStance} --> {stance}");
        }
        else if (letter == "r")
        {
            stance = "Goofy";
            System.Console.WriteLine($"Rider switched stances! {oldStance} --> {stance}");

        }
        else
        {
            System.Console.WriteLine($"Stance: {stance} is not valid!");
        }
    }

    public static Snowboarder CreateFromInput()
    {
        string stance = "Goofy";
        int age;
        int experience;
        string gender;
        string response = "";
        
        System.Console.WriteLine("Lets Build your snowboarder!");
        
        while (true)
        {
            System.Console.Write("First choose your stance: (Goofy or Regular)");
            response = Console.ReadLine()?.ToLower();
            if (!string.IsNullOrWhiteSpace(response) && response[0].ToString() == "g")
            {
                stance = "Goofy";
                break;
            }
            else if (!string.IsNullOrWhiteSpace(response) && response[0].ToString() == "r")
            {
                stance = "Regular";
                break;
            }
            else
            {
                System.Console.WriteLine($"{response} is not Valid. Please select correct stance!");
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
                System.Console.WriteLine("Please enter an integer for age!");
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
                System.Console.WriteLine("Please enter a valid integer!");
            }
                        
        }


        while (true)
        {
            System.Console.Write("Enter Gender:  ");
            response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                gender = response;
                break;
            }
            else
            {
                System.Console.WriteLine("Please enter a valid string for gender!");
            }
        }


        return new Snowboarder(stance, gender, age, experience);
    }

} 