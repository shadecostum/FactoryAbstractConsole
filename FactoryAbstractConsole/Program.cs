using FactoryAbstractClassLibrary.Models;

namespace FactoryAbstractConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarFactory sUVFactory = new SUVFactory();
            ITesla TeslaSuv = sUVFactory.CreateTesla();
            TeslaSuv.start();
            TeslaSuv.stop();
            Console.WriteLine("===========================================");
            IBmw bmwSuv=sUVFactory.CreateBMW();
            bmwSuv.start();
            bmwSuv.stop();
            Console.WriteLine("===========================================");

            ICarFactory SedanFactory = new SedanFactory();
            IBmw Bmwsedan = SedanFactory.CreateBMW();
            Bmwsedan.start();
            Bmwsedan.stop();
             Console.WriteLine("===========================================");
            ITesla TeslaSedan=SedanFactory.CreateTesla();
            TeslaSedan.start();
            TeslaSedan.stop();
            Console.WriteLine("===========================================");
        }
    }
}