using System;
using System.ComponentModel.Composition;
using Composition.Samples.Initial.Cars.CarContracts;

namespace Composition.Samples.Initial.Cars
{
    [Export(typeof(ICar))]
    public class Bmw : ICar
    {
        public void PrintCarMessage(string message)
        {
            Console.WriteLine($"{message} starts the BMW.");
        }
    }
}
