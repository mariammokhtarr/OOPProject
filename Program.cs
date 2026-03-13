namespace OOPProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // BaseHero w = new Warrior("warr", 60, 80);
           // BaseHero M = new Mage("maag", 70, 90);
           // BaseHero A = new Archer("arch", 50, 50);


            BaseHero[] heroes = new BaseHero[3];
            heroes[0] = new Warrior("warrior", 60, 80);
            heroes[1] = new Mage("mage", 60, 90);
            heroes[2] = new Archer("archer", 50, 50);

            heroes[1].Health -= 80;

            for (int i = 0; i < heroes.Length; i++)
            {
                heroes[i].Introduce();
                heroes[i].Attack();
                
            
             if (heroes[i].Health <=0)

             {
                Console.WriteLine("Hero is died");

             }
             else
             {
                 Console.WriteLine("Hero is still alive");
             }
                heroes[i].Heal ();
            }

        }



        public abstract class BaseHero
        {
            private int health;
            public string Name { get; set; }
            private int power;
            public int Health
            {
                get { return health; }
                set { health = value; }

            }
            public abstract void Attack();
            public void Introduce()
            {
              Console.WriteLine($"Iam A {Name}");

            }  
            public BaseHero(string Name , int health,int power)
            {
                this.Name = Name;
                this.Health = health;
                this.power = power;
                
            }
            public void Heal()
            {
                Health += 20;
                Console.WriteLine($"{Name} Healed 20 HP  my Health {Health}");
            }
            public void Heal(int Amount)
            {
                Health += Amount;
                Console.WriteLine(Name + " Healed" + Amount);
            }
        }
         class Warrior: BaseHero
        {
            public Warrior(string Name, int health, int power) : base(Name, health, power)
            {
            }

            public override void Attack()
            {
                Console.WriteLine($"{Name} Swings Sword");
            }


        }

        public class Mage : BaseHero
        {
            public Mage(string Name, int health, int power) : base(Name, health, power)
            {
            }

            public override void Attack()
            {
                Console.WriteLine($"{Name} Attacks with Magic");
               
            }


        }
        public class Archer : BaseHero
        {
            public Archer(string Name, int health, int power) : base(Name, health, power)
            {
            }

            public override void Attack()
            {
                Console.WriteLine($"{Name} shots a Row");
            }

        }

    }
}
