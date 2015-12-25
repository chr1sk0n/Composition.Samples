using System;
using System.ComponentModel.Composition;
using CompositionSamples.MetadataSample.Cars.Contracts;

namespace CompositionSamples.MetadataSample.Cars
{
    [ExportMetadata("Name", "BMW")]
    [ExportMetadata("Color", CarColor.Black)]
    [ExportMetadata("Price", (uint)55000)]
    [Export(typeof(ICarContract))]
    public class BMW : ICarContract
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BMW"/> class.
        /// </summary>
        public BMW()
        {
            Console.WriteLine("BMW constructor");    
        }

        /// <summary>
        /// Prints the car message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void PrintCarMessage(string message)
        {
            Console.WriteLine($"{message} starts the BMW");
        }
    }
}