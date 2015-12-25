﻿using System;
using System.ComponentModel.Composition;
using CompositionSamples.MetadataSample.Cars.Contracts;

namespace CompositionSamples.MetadataSample.Cars
{
    /// <summary>
    /// Mercedes
    /// </summary>
    /// <seealso cref="CompositionSamples.MetadataSample.Cars.Contracts.ICarContract" />
    [ExportMetadata("Name", "Mercedes")]
    [ExportMetadata("Color", CarColor.Blue)]
    [ExportMetadata("Price", (uint)55100)]
    [Export(typeof(ICarContract))]
    public class Mercedes : ICarContract
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mercedes"/> class.
        /// </summary>
        public Mercedes()
        {
           Console.WriteLine("Mercedes constructor");
        }

        /// <summary>
        /// Prints the car message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void PrintCarMessage(string message)
        {
            Console.WriteLine($"{message} starts the Mercedes");
        }
    }
}