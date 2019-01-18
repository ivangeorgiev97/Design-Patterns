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
                Console.WriteLine(tv.GetType().Name + " features:");

                foreach (TVFeatures tvFeature in tv.TVFeatures)
                {
                    Console.WriteLine("- " + tvFeature.GetType().Name);
                }

                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }

    }


    // Product
    abstract class TVFeatures
    {

    }

    // ConcreteProduct
    class Screen : TVFeatures
    {

    }

    // ConcreteProduct
    class Speakers : TVFeatures
    {

    }

    // ConcreteProduct
    class Internet : TVFeatures
    {

    }


    // Creator
    abstract class TV
    {

        private List<TVFeatures> tvFeatures = new List<TVFeatures>();

        public TV()
        {
            this.CreateFeaturesList();
        }

        public List<TVFeatures> TVFeatures
        {
            get { return tvFeatures; }
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
            TVFeatures.Add(new Screen());

            TVFeatures.Add(new Speakers());
        }

    }

    //ConcreteCreator
    class SmartTV : TV
    {

        // Implementation of Factory method
        public override void CreateFeaturesList()
        {
            TVFeatures.Add(new Screen());

            TVFeatures.Add(new Speakers());

            TVFeatures.Add(new Internet());
        }

    }
}
