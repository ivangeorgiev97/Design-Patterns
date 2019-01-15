using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            FavouriteNumbers favouriteNumbers = new FavouriteNumbers(3, 6, 13);
            FavouriteNumbers favouriteNumbersCloned = (FavouriteNumbers)favouriteNumbers.Clone();
            Console.WriteLine("Cloned numbers: {0}, {1}, {2}", favouriteNumbersCloned.Num0, favouriteNumbersCloned.Num1, favouriteNumbersCloned.Num2);
        }
    }

    // Prototype
    abstract class FavouriteNumbersPrototype
    {
        public abstract FavouriteNumbersPrototype Clone();
    }

    // ConcretePrototype
    class FavouriteNumbers : FavouriteNumbersPrototype
    {
        private int num0;
        private int num1;
        private int num2;

        public FavouriteNumbers(int num0, int num1, int num2)
        {
            this.num0 = num0;
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Num0
        {
            get { return num0; }
        }

        public int Num1
        {
            get { return num1; }
        }

        public int Num2
        {
            get { return num2; }
        }

        public override FavouriteNumbersPrototype Clone()
        {
            return this.MemberwiseClone() as FavouriteNumbersPrototype;
        }
    }
}
