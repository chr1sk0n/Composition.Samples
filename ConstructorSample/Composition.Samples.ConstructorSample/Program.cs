using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using Composition.Samples.ContructorSample.Cars.Contracts;

namespace Composition.Samples.ConstructorSample
{
    class Program
    {
        [Import(typeof (ICarContract))] Lazy<ICarContract> Car { get; set; }

        [Export("ConstructorParameter")]private int Parameter { get; set; }

        static void Main(string[] args)
        {
            new Program().Run();
            Console.ReadKey();
        }

        private void Run()
        {
            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);

            this.Parameter = 24;
            container.ComposeParts(this);
            this.Print(Car);
            container.Dispose();
        }

        void Print(Lazy<ICarContract> car)
        {
            //if(car.IsValueCreated)
                car.Value.PrintCarMessage("Christoph");
        }
    }
}
