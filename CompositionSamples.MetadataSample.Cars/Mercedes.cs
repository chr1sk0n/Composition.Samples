using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Primitives;
using CompositionSamples.MetadataSample.Cars.Contracts;

namespace CompositionSamples.MetadataSample.Cars
{
    [ExportMetadata("Name", "Mercedes")]
    [ExportMetadata("Color", CarColor.Blue)]
    [ExportMetadata("Price", (uint)55100)]
    [Export(typeof(ICarContract))]
    public class Mercedes : ICarContract
    {
        public Mercedes()
        {
           Console.WriteLine("Mercedes constructor");
        }

        public void PrintCarMessage(string message)
        {
            Console.WriteLine($"{message} starts the Mercedes");
        }
    }
}