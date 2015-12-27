namespace Composition.Samples.Initial.Cars
{
    using System;
    using System.ComponentModel.Composition;
    using Composition.Samples.Initial.CarContracts.Contracts;

    /// <summary>
    /// class Mercedes
    /// </summary>
    /// <seealso cref="Composition.Samples.Initial.CarContracts.Contracts.ICarContract" />
    [Export(typeof(ICarContract))]
    public class Mercedes : ICarContract
    {
        /// <summary>
        /// Prints the car message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void PrintCarMessage(string message)
        {
            Console.WriteLine($"{message} starts the mercedes.");
        }
    }
}
