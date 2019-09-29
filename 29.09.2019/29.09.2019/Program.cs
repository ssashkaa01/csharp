using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._09._2019
{

    abstract class Creature
    {

    }

    interface IFlying
    {
        void Move();
    }

    interface IRunning
    {
        void Move();
    }

    interface IFloating
    {
        void Move();
    }

    interface ICreeping
    {
        void Move();
    }


    class Animal : Creature
    {
        public virtual void Kind()
        {
            Console.WriteLine("Kind undefined");
        }

        public virtual void Name()
        {
            Console.WriteLine("Name undefined");
        }

        public virtual void Voice()
        {
            Console.WriteLine("Voice undefined");
        }
    }

    class Reptile : Animal , ICreeping
    {
        public override void Kind()
        {
            Console.WriteLine("Kind - reptile");
        }

        public override void Voice()
        {
            Console.WriteLine("Sh SH Shhhhh...");
        }

        public virtual void Move()
        {
            Console.WriteLine("crawled");
        }
    }

    class Mammal : Animal , IRunning
    {
        public override void Kind()
        {
            Console.WriteLine("Kind - Mammal");
        }

        public override void Voice()
        {
            Console.WriteLine("Hello...");
        }

        public virtual void Move()
        {
            Console.WriteLine("Going");
        }
    }

    class Bird : Animal , IFlying
    {
        public override void Kind()
        {
            Console.WriteLine("Kind - bird");
        }

        public override void Voice()
        {
            Console.WriteLine("Ku Ku ...");
        }

        public virtual void Move()
        {
            Console.WriteLine("Flying");
        }
    }

    class Fish : Animal, IFloating
    {
        public override void Kind()
        {
            Console.WriteLine("Kind - fish");
        }

        public override void Voice()
        {
            Console.WriteLine("u u u u ...");
        }

        public void Move()
        {
            Console.WriteLine("Floats");
        }
    }

    class Bear : Mammal
    {
        public override void Name()
        {
            Console.WriteLine("Bear");
            
        }

        public override void Voice()
        {
            Console.WriteLine("RRRRR rrrr  ...");
        }
    }

    class Frog : Reptile
    {
        public override void Name()
        {
            Console.WriteLine("Frog");
        }

        public override void Voice()
        {
            Console.WriteLine("Kva kva kva ...");
        }
    }

    class Dolphin : Mammal
    {
        public override void Name()
        {
            Console.WriteLine("Dolphin");
        }

        public override void Voice()
        {
            Console.WriteLine("S ss ss  ...");
        }
    }

    class Carp : Fish
    {
        public override void Name()
        {
            Console.WriteLine("Carp");
        }
    }

    class Eagle : Bird
    {
        public override void Name()
        {
            Console.WriteLine("Eagle");
        }

        public override void Voice()
        {
            Console.WriteLine("kvuu uuu  uaauu ...");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Animal[] zoo = new Animal[]
            {
                new Eagle(),
                new Carp(),
                new Dolphin(),
                new Carp(),
                new Eagle(),
                new Bear(),
                new Frog(),
            };

            foreach(var anim in zoo)
            {
                Console.WriteLine("------------------------");
                
                anim.Kind();
                anim.Name();
                anim.Voice();
                
                Console.WriteLine("------------------------");
            }

        }
    }
}
