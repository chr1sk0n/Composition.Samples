using System;
using System.ComponentModel.Composition;
using CompositionSample.TypesafeSample.CarContracts;

namespace CompositionSample.TypesafeSample.BMWs
{
    [ExportMetadata("CarName", "BMW")]
    [ExportMetadata("Color", CarColor.Black)]
    [ExportMetadata("Price", (uint)44000)]
    [Export(typeof(ICarContract))]
    public class Mercedes : ICarContract
    {
        private Mercedes()
        {
            Console.WriteLine("BMW constructor called.");
        }

        public void PrintCarMessage(string message)
        {
            Console.WriteLine($"{message} starts the BMW, or not?");
        }
    }
}
