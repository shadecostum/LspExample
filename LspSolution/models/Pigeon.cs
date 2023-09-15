using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspSolution.models
{
    internal class Pigeon:IBird,ILordBird
    {
        public string Name { get; set; }
        public  void Fly()
        {
            Console.WriteLine("Pigeon flying");
        }
        public void BodyColor()
        {
            Console.WriteLine("Pigeon color is white");
        }
        public void Feathers()
        {
            Console.WriteLine("have feathers");
        }

        public void Nail()
        {
            Console.WriteLine("sparrow have nail");
        }
    }
}
