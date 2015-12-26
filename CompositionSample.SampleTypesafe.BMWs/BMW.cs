using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositionSample.MedataSampleTypesafe.Cars.Contracts;

namespace CompositionSample.SampleTypesafe.BMWs
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
