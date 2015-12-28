using System;
using System.ComponentModel.Composition;
using CompositionSample.TypesafeSample.CarContracts.Contracts;

namespace CompositionSample.TypesafeSample.Daimler
{
    [ExportMetadata("CarName", "Mercedes")]
    [ExportMetadata("Color", CarColor.Blue)]
    [ExportMetadata("Price", (uint)48000)]
    [Export(typeof(ICarContract))]
    public class Mercedes : ICarContract
    {
        private Mercedes()
        {
            Console.WriteLine("Mercedes constructor called.");
        }

        public void PrintCarMessage(string message)
        {
            Console.WriteLine($"{message} starts the Mercedes-Benz, or not?");
        }
    }
}
