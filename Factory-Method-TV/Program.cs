using System;
using System.Collections.Generic;

namespace Factory_Method_TV
{

    class FactoryMethodTVs
    {

        static void Main()
        {
            TV[] tvs = new TV[2];

            tvs[0] = new NormalTV();
            tvs[1] = new SmartTV();


            foreach (TV tv in tvs)
            {
                Console.WriteLine(tv.GetType().Name + " parts:");

                foreach (TVPart tvPart in tv.TVParts)
                {
                    Console.WriteLine("- " + tvPart.GetType().Name);
                }

                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }

    }


    // Product
    abstract class TVPart
    {

    }

    // ConcreteProduct
    class Screen : TVPart
    {

    }

    // ConcreteProduct
    class Speakers : TVPart
    {

    }

    // ConcreteProduct
    class EthernetPort : TVPart
    {

    }


    // Creator
    abstract class TV
    {

        private List<TVPart> tvParts = new List<TVPart>();

        public TV()
        {
            this.CreateFeaturesList();
        }

        public List<TVPart> TVParts
        {
            get { return tvParts; }
        }

        // Factory method- освен да се използва по този начин,
        // методът може и да връща обект от тип Product(в случая TVFeatures) 
        public abstract void CreateFeaturesList();

    }


    // ConcreteCreator
    class NormalTV : TV
    {

        // Implementation of Factory method
        public override void CreateFeaturesList()
        {
            TVParts.Add(new Screen());

            TVParts.Add(new Speakers());
        }

    }

    //ConcreteCreator
    class SmartTV : TV
    {

        // Implementation of Factory method
        public override void CreateFeaturesList()
        {
            TVParts.Add(new Screen());

            TVParts.Add(new Speakers());

            TVParts.Add(new EthernetPort());
        }

    }

}
