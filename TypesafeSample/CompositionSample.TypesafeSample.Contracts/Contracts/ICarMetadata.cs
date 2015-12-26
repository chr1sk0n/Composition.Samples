using System.ComponentModel;

namespace CompositionSample.TypesafeSample.CarContracts
{
    public interface ICarMetadata
    {
        /// <summary>
        /// Gets the name of the car.
        /// </summary>
        /// <value>
        /// The name of the car.
        /// </value>
        [DefaultValue("NoName")] string CarName { get; }

        /// <summary>
        /// Gets the color.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        [DefaultValue(CarColor.Unknown)] CarColor Color { get; }

        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        [DefaultValue((uint)0)] uint Price { get; }
    }
}