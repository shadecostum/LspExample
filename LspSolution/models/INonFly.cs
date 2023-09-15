using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspSolution.models
{
    internal interface INonFly:ILordBird
    {
        public void NonFly() {

            Console.WriteLine("aaaaaaaaaaaaa");
        }
    }
}
