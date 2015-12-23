using System;
using System.ComponentModel.Composition;
using Cars.Contracts;

namespace Cars
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
