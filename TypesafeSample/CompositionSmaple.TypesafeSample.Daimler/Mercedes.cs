using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositionSample.TypesafeSample.CarContracts;

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
