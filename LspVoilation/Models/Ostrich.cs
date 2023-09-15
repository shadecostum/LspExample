using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspVoilation.Models
{
    internal class Ostrich:Bird
    {
        public override void Fly()
        {
            base.Fly();
            Console.WriteLine("ostrich cannot fly");
        }
    }
}
