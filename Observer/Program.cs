using System;
using System.Collections.Generic;

namespace Observer
{

    class Program
    {

        static void Main()
        {
            // Тук се въвежда кой е футболният отбор 
            RandomFavouriteFootballTeam randomFavouriteFootballTeam = new RandomFavouriteFootballTeam("Любим футболен отбор", 00.00);

            // Тук се въвеждат феновете, които следят шанса за спечелване на първенството от този отбор
            randomFavouriteFootballTeam.AddFan(new Fan("Иван"));
            randomFavouriteFootballTeam.AddFan(new Fan("Станимир"));

            // След победа с определен резултат
            randomFavouriteFootballTeam.ChancePercentage = 73.00;
            // След загуба с определен резултат
            randomFavouriteFootballTeam.ChancePercentage = 57.00;
            // След победа с определен резултат
            randomFavouriteFootballTeam.ChancePercentage = 79.50;
            // След победа и вече сигурни точки за спечелване на първенството
            randomFavouriteFootballTeam.ChancePercentage = 104.00;

            Console.ReadKey();
        }

    }


    // Subject
    abstract class Chance
    {
        private string team;
        private double chancePercentage;
        private List<IFan> fans = new List<IFan>();

        public Chance(string team, double chancePercentage)
        {
            this.team = team;
            this.chancePercentage = chancePercentage;
        }

        public void AddFan(IFan fan)
        {
            fans.Add(fan);
        }

        public void RemoveFan(IFan fan)
        {
            fans.Remove(fan);
        }

        public void NotifyFans()
        {
            foreach (IFan fan in fans)
            {
                fan.Update(this);
            }

            Console.WriteLine("----------------");
        }

        public double ChancePercentage
        {
            get { return chancePercentage; }
            set
            {
                if (chancePercentage != value)
                {
                    chancePercentage = value;
                    NotifyFans();
                }
            }
        }

        public string Team
        {
            get { return team; }
        }
    }


    // ConcreteSubject
    class RandomFavouriteFootballTeam : Chance
    {

        public RandomFavouriteFootballTeam(string team, double chancePercentage)
          : base(team, chancePercentage)
        {
        }

    }


    // Observer
    interface IFan
    {

        void Update(Chance chancePercentage);

    }


    // ConcreteObserver
    class Fan : IFan
    {
        private string name;
        private Chance chance;

        public Fan(string name)
        {
            this.name = name;
        }

        public void Update(Chance chance)
        {
            Console.WriteLine("Известих {0} за промяна за шанса на отбор {1} " +
              "за спечеллване на първенството- {2} %", name, chance.Team, chance.ChancePercentage);
        }

        public Chance Stock
        {
            get { return chance; }
            set { chance = value; }
        }
    }
}