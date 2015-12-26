using System;
using System.ComponentModel.Composition;
using Composition.Samples.ContructorSample.CarContracts.Contracts;

namespace Composition.Samples.ContructorSample.Cars
{
    [Export(typeof(ICarContract))]
    public class Bmw : ICarContract
    {
        [ImportingConstructor]
        public Bmw([Import("ConstructorParameter")]int parameter)
        {
            Console.WriteLine($"Parameter: {parameter}");
        }

        public void PrintCarMessage(string message)
        {
            Console.WriteLine($"{message} starts the BMW.");
        }
    }
}
