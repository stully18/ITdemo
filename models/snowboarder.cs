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
        System.Console.Write("First choose your stance: (Goofy or Regular)");
        response = Console.ReadLine().ToLower();
        if (response == "g")
        {
            stance = "Goofy";
        }
        else if (response == "r")
        {
            stance = "Regular";
        }
        else
        {
            System.Console.WriteLine($"{response} is not Valid. Please select correct stance!");
        }

        System.Console.Write("Enter age:  ");
        response = Console.ReadLine();
        age = int.Parse(response);

        System.Console.Write("Enter years of Experience:  ");
        response = Console.ReadLine();
        experience = int.Parse(response);

        System.Console.Write("Enter Gender:  ");
        response = Console.ReadLine();
        gender = response;

        return new Snowboarder(stance, gender, age, experience);
    }

} 