using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Strategy - Defines a family of algorithms, encapsulates each one, and makes them interchangeable. 
//           Strategy lets the algorithm vary independentlyfrom the clients that use it.


namespace Ducks
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public Duck()
        {

        }

        public abstract void display();

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void performFly()
        {
            flyBehavior.fly();
        }


        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        
        

    }
}
