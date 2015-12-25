﻿namespace CompositionSamples.MetadataSample.Cars.Contracts
{
    public interface ICarContract
    {
        /// <summary>
        /// Prints the car message.
        /// </summary>
        /// <param name="message">The message.</param>
        void PrintCarMessage(string message);
    }
}