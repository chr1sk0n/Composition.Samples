using System;
using Cars.Contracts;

namespace Composition.Samples
{
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;

    class Program
    {
        [ImportMany(typeof (ICar))] ICar[] _cars = null;

        static void Main(string[] args)
        {
            new Program().Run();
        }

        void Run()
        {
            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
            Print(_cars);
            Console.ReadKey();
        }

        private void Print(ICar[] cars)
        {
            foreach (var car in cars)
            {
                car.PrintCarMessage("Christoph");
            }
        }
    }
}
