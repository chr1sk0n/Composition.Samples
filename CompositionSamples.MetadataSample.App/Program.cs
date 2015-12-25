using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using CompositionSamples.MetadataSample.Cars.Contracts;

namespace CompositionSamples.MetadataSample.App
{
    class Program
    {
        /// <summary>
        /// Gets or sets the car parts.
        /// </summary>
        /// <value>
        /// The car parts.
        /// </value>
        [ImportMany(typeof(ICarContract))]
        private IEnumerable<Lazy<ICarContract, Dictionary<string,object>>> CarParts { get; set; }

        /// <summary>
        /// Mains the specified arguments.
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
            Print(CarParts);
            container.Dispose();
        }

        /// <summary>
        /// Prints the specified car parts.
        /// </summary>
        /// <param name="carParts">The car parts.</param>
        private void Print(IEnumerable<Lazy<ICarContract, Dictionary<string, object>>> carParts)
        {
            if (carParts != null)
            {
                foreach (var carPart in carParts)
                {
                    if (carPart.Metadata.ContainsKey("Name")) Console.WriteLine(carPart.Metadata["Name"]);
                    if (carPart.Metadata.ContainsKey("Color")) Console.WriteLine(carPart.Metadata["Color"]);
                    if (carPart.Metadata.ContainsKey("Price")) Console.WriteLine(carPart.Metadata["Price"]);
                    Console.WriteLine();
                }
                foreach (Lazy<ICarContract> carPart in carParts)
                {
                    carPart.Value.PrintCarMessage("Christoph");
                }
            }
        }
    }
}
