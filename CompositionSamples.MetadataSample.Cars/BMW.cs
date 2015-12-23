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
        public BMW()
        {
            Console.WriteLine("BMW constructor");    
        }

        public void PrintCarMessage(string message)
        {
            Console.WriteLine($"{message} starts the BMW");
        }
    }
}