using System;
using System.ComponentModel.Composition;
using Composition.Samples.Initial.Cars.CarContracts;

namespace Composition.Samples.Initial.Cars
{
    [Export(typeof(ICar))]
    public class Mercedes : ICar
    {
        public void PrintCarMessage(string message)
        {
            Console.WriteLine($"{message} starts the mercedes.");
        }
    }
}
