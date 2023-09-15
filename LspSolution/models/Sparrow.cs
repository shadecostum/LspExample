using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspSolution.models
{
    internal class Sparrow:IBird
    {
        public string Name { get; set; }
        public void Fly()
        {
            Console.WriteLine("Sparrow flying");
            Name = "dh";
        }

        public void BodyColor() 
        {
            Console.WriteLine("Sparrow color is Red");
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
