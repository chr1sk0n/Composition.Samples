namespace CompositionSample.TypesafeSample.App
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;
    using System.Linq;
    using CompositionSample.TypesafeSample.CarContracts.Contracts;

    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Gets or sets the car parts.
        /// </summary>
        /// <value>
        /// The car parts.
        /// </value>
        [ImportMany(typeof(ICarContract))]
        private IEnumerable<Lazy<ICarContract, ICarMetadata>> CarParts { get; set; }

        /// <summary>
        /// starting point
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            new Program().Run();
            Console.ReadKey();
        }

        /// <summary>
        /// Runs this instance.
        /// </summary>
        private void Run()
        {
            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
            PrintCarMetadata(CarParts);
            Print(CarParts);
            container.Dispose();
        }

        /// <summary>
        /// Prints the car metadata.
        /// </summary>
        /// <param name="carParts">The car parts.</param>
        private void PrintCarMetadata(IEnumerable<Lazy<ICarContract, ICarMetadata>> carParts)
        {
            foreach (Lazy<ICarContract, ICarMetadata> car in carParts)
            {
                Console.WriteLine(car.Metadata.CarName);
                Console.WriteLine(car.Metadata.Color);
                Console.WriteLine(car.Metadata.Price);
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// Prints the specified car parts.
        /// </summary>
        /// <param name="carParts">The car parts.</param>
        private void Print(IEnumerable<Lazy<ICarContract, ICarMetadata>> carParts)
        {
            var blackCars = from lazyCarPart in carParts
                let metadata = lazyCarPart.Metadata
                where metadata.Color == CarColor.Black
                select lazyCarPart;
            foreach (var blackCar in blackCars)
            {
                blackCar.Value.PrintCarMessage("Christoph");
            }
            foreach (Lazy<ICarContract> carPart in carParts)
            {
                carPart.Value.PrintCarMessage("chr1sk0n");
            }
        }
    }
}
