



namespace Composition.Samples.Initial
{
    using System;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;

    using Composition.Samples.Initial.CarContracts.Contracts;

    /// <summary>
    /// class Program
    /// </summary>
    class Program
    {
        [ImportMany(typeof (ICarContract))] ICarContract[] _carsContract = null;

        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            new Program().Run();
        }

        /// <summary>
        /// Runs this instance.
        /// </summary>
        private void Run()
        {
            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
            Print(_carsContract);
            Console.ReadKey();
        }

        /// <summary>
        /// Prints the specified cars.
        /// </summary>
        /// <param name="cars">The cars.</param>
        private void Print(ICarContract[] cars)
        {
            foreach (var car in cars)
            {
                car.PrintCarMessage("Christoph");
            }
        }
    }
}
