using System;

namespace FutureFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\t╔═══════════════════════════════════════╗\n" +
                          "\t║                                       ║\n" +
                          "\t║                                       ║\n" +
                          "\t║         Welcome in Futur Farm         ║\n" +
                          "\t║                                       ║\n" +
                          "\t║                                       ║\n" +
                          "\t╚═══════════════════════════════════════╝\n");

            Console.WriteLine("Nous sommes en 2110, et vous allez devoir vous occuper d'une ferme ..\n" +
            "Avant de commencer nous allons personnaliser votre expérience : \n");

            Console.Write("Quel est le prénom de votre héros ? ");
            Man Man = new Man(Console.ReadLine());

            Console.Write("\n" + Man.Firstname + " est-il accompagné dans la vie ? (o/n) : ");
            if (Console.ReadLine() == "o")
            {
                Console.Write("\n Quel est le prénom de sa compagne ? ");
                Man.CreateWife(Console.ReadLine());
            }

            Console.Write("\nVous possédez un chien, comment s'appelle-t-il ? ");
            Dog Dog = new Dog(Console.ReadLine());

            Dog.MoveQueue();

            Android Pepper = new Android("Pepper");
            Clone Clone = new Clone("Marcel");

            Console.WriteLine("\nVotre androïde s'appelle " + Pepper.Name + " et votre Clone s'appelle " + Clone.Name + "\n" +
            "Ils effectueront les tâches les plus ingrates pour vous, ce sont des alliés précieux.");
            System.Threading.Thread.Sleep(1000);

            #region Histoire

            // instanciation des différentes classes utilisées par la suite
            ApricotTree ApricotTree = new ApricotTree();
            CherryTree CherryTree = new CherryTree();
            Cabbage Cabbage = new Cabbage();
            Corn Corn = new Corn();
            Goat Goat = new Goat("chèvre");
            Turkey Turkey = new Turkey("dindon");
            Virus virus = new Virus("arbres");
            Virus virus2 = new Virus("animaux");
            Bucket Bucket = new Bucket("seau");
            Knife Knife = new Knife("couteau");
            Table Table = new Table(4, "rectangulaire");

            // Enumération des jours de la semaine, utilisée pour le switch
            int day = (int)Days.Monday;

         while (day != 8)
         {
             switch (day)
             {
                 case 1: 
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine(Days.Monday);
                        Console.WriteLine("-----------------------------\n");

                        Sun.Rise();
                        Sun.Shine();

                        ApricotTree.Grow();
                        CherryTree.Grow();

                        Man.Cut(Cabbage.Name, Knife.Name);
                        Man.Cut(Corn.Name, Knife.Name);
                        Pepper.Cut(Cabbage.Name, Knife.Name);
                        Pepper.Cut(Corn.Name, Knife.Name);

                        Man.Eat(Table.Name);
                        Man.Sleep();

                        Moon.Rise();
                 break;
                 case 2:
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine(Days.Tuesday);
                        Console.WriteLine("-----------------------------\n");

                        Sun.Rise();

                        Clone.GiveWater(Cabbage.Name);
                        Clone.GiveWater(Corn.Name);
                        Pepper.GiveWater(Goat.Name);
                        ApricotTree.Flowers();
                        CherryTree.Flowers();

                        Cabbage.Grow();
                        Corn.Grow();

                        Man.Eat(Table.Name);
                        Man.Sleep();

                        Moon.Rise();
                        break;
                 case 3: 
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine(Days.Wednesday);
                        Console.WriteLine("-----------------------------\n");

                        Sun.Rise();

                        Cabbage.Flowers();
                        Corn.Flowers();
                        Pepper.GiveWater(Turkey.Name);
                        Clone.GiveWater(Goat.Name);

                        virus.Attack();

                        Man.Eat(Table.Name);

                        Moon.Rise();
                        break;

                 case 4:
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine(Days.Thursday);
                        Console.WriteLine("-----------------------------\n");

                        Sun.Rise();

                        Man.Harvest(CherryTree.Name, Bucket.Name);
                        Man.Harvest(ApricotTree.Name, Bucket.Name);
                        Pepper.Harvest(CherryTree.Name, Bucket.Name);
                        Pepper.Harvest(ApricotTree.Name, Bucket.Name);

                        Man.Eat(Table.Name);
                        Man.Kill(Turkey.Name);
                        Man.Eat(Table.Name);

                        Moon.Rise();
                        break;

                 case 5: 
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine(Days.Friday);
                        Console.WriteLine("-----------------------------\n");

                        Sun.Rise();

                        Man.Cut(CherryTree.Name, Knife.Name);
                        Man.Cut(ApricotTree.Name, Knife.Name);
                        Pepper.Cut(CherryTree.Name, Knife.Name);
                        Pepper.Cut(ApricotTree.Name, Knife.Name);

                        Man.Harvest(Cabbage.Name, Bucket.Name);
                        Man.Harvest(Corn.Name, Bucket.Name);
                        Pepper.Harvest(Cabbage.Name, Bucket.Name);
                        Pepper.Harvest(Corn.Name, Bucket.Name);
                        
                        virus.Attack();

                        Moon.Rise();
                        break;

                 case 6:
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine(Days.Saturday);
                        Console.WriteLine("-----------------------------\n");

                        Sun.Rise();

                        CherryTree.Dead();
                        ApricotTree.Dead();

                        Man.Kill(Goat.Name);
                        Moon.Rise();
                        break;

                 case 7:
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine(Days.Sunday);
                        Console.WriteLine("-----------------------------\n");

                        Sun.Rise();

                        virus2.Attack();

                        Cabbage.Dead();
                        Corn.Dead();

                        Console.WriteLine("Une météorite s'abbat sur la ferme");
                        Console.WriteLine("The end...");

                        break;

                 default:
                 break;
             }

             day++;
         }

        #endregion

        }
    }
}
