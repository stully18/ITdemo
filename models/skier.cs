class Skier : Rider
{   
    bool usesPoles;
    public Skier(bool usesPoles, string gender, int age, int experience) : base(gender, age, experience)
    {
        this.usesPoles = usesPoles;
    }
}