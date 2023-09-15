using LspVoilation.Models;

namespace LspVoilation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            bird.Fly();
            Sparrow sparrow = new Sparrow();
            sparrow.Fly();
            Pigeon pigeon = new Pigeon();
            pigeon.Fly();
            Ostrich ostrich = new Ostrich();
            ostrich.Fly();


        }
    }
}