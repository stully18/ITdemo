using System.Diagnostics.Tracing;

abstract class Rider
    {
        public string gender = "";
        public int age;
        public int yearsOfExperience;
        protected int health = 79;
        private int trickDamage = 1;
        private double trickModifier = 1.1;

        public Rider(string gender, int age, int experience)
        {
            this.gender = gender;
            this.age = age;
            yearsOfExperience = experience;
        }

        public virtual void doTrick()
        {
            if (willLand(health) == true)
            {
                System.Console.WriteLine("You landed the trick!");
            }
            else
            {
                health -= trickDamage;
                string message = $"You failed!  You lost {trickDamage} health :()";
                System.Console.WriteLine(message);
            }
        }

        public bool willLand(int health)
        {
            double chances = (double) health * trickModifier ;
            Random rand = new Random();

            int randomNum = rand.Next(1,101);

            if ((double)randomNum <= chances)
            {
                return true;
            }
            else
            {
                return false;

            }
            
        }
        

        public virtual void Eat()
        {
            health += 10;
            System.Console.WriteLine("You ate! +10 health!");
        }



    }