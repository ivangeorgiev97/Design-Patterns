using System;

namespace Abstract_Factory_Gaming

{

    // Abstract Factory Design Pattern

    class MainClassGamingConsoles

    {

        public static void Main()

        {
            ConsoleFactory manuFacturer1 = new Manufacturer1();

            ConsoleWorld consoleWorld = new ConsoleWorld(manuFacturer1);

            consoleWorld.DescribeHowTheyWork();


            // type2

            ConsoleFactory manuFacturer2 = new ManuFacturer2();

            consoleWorld = new ConsoleWorld(manuFacturer2);

            consoleWorld.DescribeHowTheyWork();


            Console.ReadKey();

        }

    }


    // AbstractFactory

    abstract class ConsoleFactory

    {

        public abstract Portable CreatePortable();

        public abstract NotPortable CreateNotPortable();

    }


    // ConcreteFactory of type1

    class Manufacturer1 : ConsoleFactory
    {

        public override Portable CreatePortable()
        {
            return new PortableModel1();
        }

        public override NotPortable CreateNotPortable()
        {
            return new NotPortableModel1();
        }

    }


    // ConcreteFactory of type2

    class ManuFacturer2 : ConsoleFactory
    {

        public override Portable CreatePortable()
        {
            return new PoratbleModel2();
        }

        public override NotPortable CreateNotPortable()
        {
            return new NotPortableModel2();
        }

    }


    // AbstractProduct of type1

    abstract class Portable

    {

    }


    // AbstractProduct of type2

    abstract class NotPortable
    {

        public abstract void UseOnlyElectricity(Portable p);

    }


    // First Product of type1

    class PortableModel1 : Portable
    {

    }


    // First Product of type2

    class NotPortableModel1 : NotPortable
    {

        public override void UseOnlyElectricity(Portable p)
        {
            Console.WriteLine(this.GetType().Name +
              " uses only electricity instead of both electricity and battery like " + p.GetType().Name);
        }

    }


    // Second Product of type1

    class PoratbleModel2 : Portable
    {

    }


    // Second Product of type2

    class NotPortableModel2 : NotPortable
    {

        public override void UseOnlyElectricity(Portable p)
        {
            Console.WriteLine(this.GetType().Name +
              " uses only electricity instead of both electricity and battery like " + p.GetType().Name);
        }

    }


    // Client

    class ConsoleWorld
    {

        private Portable portable;

        private NotPortable notPortable;


        // Constructor
        public ConsoleWorld(ConsoleFactory factory)
        {
            notPortable = factory.CreateNotPortable();

            portable = factory.CreatePortable();
        }

        public void DescribeHowTheyWork()
        {
            notPortable.UseOnlyElectricity(portable);
        }

    }
}