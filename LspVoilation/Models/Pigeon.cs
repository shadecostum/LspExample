using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspVoilation.Models
{
    internal class Pigeon:Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Pigeon flying");
        }
    }
}
