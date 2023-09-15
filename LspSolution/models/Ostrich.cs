using LspSolution.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspSolution.Models
{
    internal class Ostrich:INonFly,ILordBird
    {
        public string Name { get; set; }

        public void NonFly()
        {
            Console.WriteLine("Non fly ostrich walk");
        }
        public void BodyColor()
        {
            Console.WriteLine("ostrich  color is brown");
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
