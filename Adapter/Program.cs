using System;

namespace Adapter_1
{

    class Program
    {

        static void Main()
        {
            // Non-adapted headphones

            Headphones unknownHeadphonesModel = new Headphones("Неизвестен модел");

            unknownHeadphonesModel.DisplayInfo();


            // Adapted headphones

            Headphones headPhonesModelABC13 = new HeadphonesAdapter("HeadphonesModelABC13");

            headPhonesModelABC13.DisplayInfo();


            Headphones headPhonesModelDEF26 = new HeadphonesAdapter("headphonesModelDEF26");

            headPhonesModelDEF26.DisplayInfo();


            Headphones headphonesModelHIJ39 = new HeadphonesAdapter("HeadphonesModelhij39");

            headphonesModelHIJ39.DisplayInfo();


            Console.ReadKey();
        }

    }


    // Target
    class Headphones
    {

        protected string headphones;

        protected double weight;

        protected string suitableFor;


        public Headphones(string headphones)
        {
            this.headphones = headphones;
        }


        public virtual void DisplayInfo()
        {
            Console.WriteLine("\nСлушалки: {0} --- ", headphones.ToUpper());
        }

    }


    // Adapter
    class HeadphonesAdapter : Headphones
    {

        private HeadphonesData headphonesData;


        public HeadphonesAdapter(string name)
          : base(name)
        {

        }

        public override void DisplayInfo()
        {
            // The Adaptee
            headphonesData = new HeadphonesData();

            weight = headphonesData.GetWeight(headphones);

            suitableFor = headphonesData.GetSuitableFor(headphones);

            base.DisplayInfo();

            Console.WriteLine(" Подходящи за: {0}", suitableFor);

            Console.WriteLine(" Тегло : {0}", weight);
        }

    }


    // Adaptee
    class HeadphonesData
    {

        public string GetSuitableFor(string headphones)
        {
            switch (headphones.ToUpper())
            {
                case "HEADPHONESMODELABC13": return "Игри";

                case "HEADPHONESMODELDEF26": return "Спорт";

                case "HEADPHONESMODELHIJ39": return "Почивка";

                default: return "";
            }
        }

        public double GetWeight(string headphones)
        {
            switch (headphones.ToUpper())
            {
                case "HEADPHONESMODELABC13": return 0.615;

                case "HEADPHONESMODELDEF26": return 0.413;

                case "HEADPHONESMODELHIJ39": return 0.521;

                default: return 0d;
            }
        }

    }
}