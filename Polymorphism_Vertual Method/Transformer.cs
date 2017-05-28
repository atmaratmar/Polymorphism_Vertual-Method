using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Vertual_Method
{
    class Transformer
    {
        public virtual void Run()// virtual mean dont run it now and if it is overrid
                                 //in the child class or not // if it is overrid it will excute that othrwis
                                 //it will came back and excute parent class 
        {
            Console.WriteLine("Run transformer");
        }
    }
    class Car : Transformer
    {
        public override void Run()
        {
            Console.WriteLine("Run Car");
        }
    }
}
