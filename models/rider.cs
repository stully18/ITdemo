abstract class Rider
{
    public string gender = "";
    public int age;
    public int yearsOfExperience;
    protected int health = 100;

    public Rider(string gender, int age, int experience)
    {
        this.gender = gender;
        this.age = age;
        yearsOfExperience = experience;
    }



}