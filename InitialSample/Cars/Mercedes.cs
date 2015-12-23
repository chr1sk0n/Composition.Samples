using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars.Contracts;

namespace Cars
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
