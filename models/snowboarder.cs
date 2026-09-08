class Snowboarder : Rider
{
    public string stance = "";
    
    public Snowboarder(string stance, string gender, int age, int experience) : base(gender, age, experience)
    {
        this.stance = stance;
    }

    
} 