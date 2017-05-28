using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Vertual_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Transformer trans = new Car();
            trans.Run();
        }
    }
}
