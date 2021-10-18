using System;

namespace MhLabs.Extensions
{
    /// <summary>
    /// Extension method for units
    /// </summary>
    public static class UnitExtension
    {
        /// <summary>
        /// Convert double to minor unit
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>Amount in minor unit</returns>
        public static int ToMinorUnit(this double amount)
        {
            try
            {
                var decimalAmount = Convert.ToDecimal(amount);
                return decimalAmount.ToMinorUnit();
            }
            catch 
            {
                throw new ArgumentException($"Unable to convert {amount} to MinorUnit");
            }
        }

        /// <summary>
        /// Convert decimal to minor unit
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>Amount in minor unit</returns>
        public static int ToMinorUnit(this decimal amount)
        {
            try
            {
                return (int)Math.Round(amount * 100m);
            }
            catch 
            {
                throw new ArgumentException($"Unable to convert {amount} to MinorUnit");
            }
        }

        /// <summary>
        /// Convert minor unit to major unit
        /// </summary>
        /// <param name="minorUnit"></param>
        /// <returns>Value in <typeparamref name="T"/></returns>
        public static T ToMajorUnit<T>(this int minorUnit)
        {
            try
            {
                var result = (decimal)minorUnit / 100;
                return (T)Convert.ChangeType(result, typeof(T));
            }
            catch 
            {
                throw new ArgumentException($"Unable to covert value to {typeof(T).Name}");
            }
        }
    }
}
