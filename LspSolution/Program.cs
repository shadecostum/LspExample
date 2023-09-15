using LspSolution.models;
using LspSolution.Models;

namespace LspSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            PrintDetailsObjPass(new Sparrow());
            PrintDetailsObjPass(new Pigeon());
         
            PrintDetailNonFlysObjPass(new Ostrich());
            Console.WriteLine("=====================================================");

            cdnks(new Sparrow());
            //second interface passing
           // SecondInterfaceIlord(new Sparrow());
        

        }
        private static void cdnks(ILordBird lbird)
        {
            lbird.Feathers();
            lbird.Nail();
            lbird.BodyColor();
           // lbird.Fly();
        }

       
       
        private static void PrintDetailsObjPass(IBird bird)
        {
            bird.Fly();

            bird.BodyColor();
            bird.Feathers();
            bird.Nail();
            Console.WriteLine("===================");
        }
        private static void PrintDetailNonFlysObjPass(INonFly ostrich)
        {
            ostrich.NonFly();
            ostrich.BodyColor();
            ostrich.Feathers();
            ostrich.Nail();
        }

    }
}