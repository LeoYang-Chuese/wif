﻿/**************************************************************************
*      File Name：MathExtensions.cs
*    Description：MathExtensions.cs class description...
*      Copyright：Copyright © 2020 LeoYang-Chuese. All rights reserved.
*        Creator：Leo Yang
*    Create Time：2020/12/15
*Project Address：https://github.com/LeoYang-Chuese/wif
**************************************************************************/


using System;

namespace Frontier.Wif.Utilities.Extensions
{
    /// <summary>
    /// Extension methods for math operations.
    /// </summary>
    public static class MathExtensions
    {
        #region Methods

        /// <summary>
        /// Clips the specified value so it does not exceed min or max.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="minValue">The minimum value.</param>
        /// <param name="maxValue">The maximum value.</param>
        /// <returns>The clipped value.</returns>
        public static double Clip(this double value, double minValue, double maxValue)
        {
            return Math.Min(Math.Max(value, minValue), maxValue);
        }

        /// <summary>
        /// Clips the specified value so it does not exceed min or max.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="minValue">The minimum value.</param>
        /// <param name="maxValue">The maximum value.</param>
        /// <returns>The clipped value.</returns>
        public static float Clip(this float value, float minValue, float maxValue)
        {
            return Math.Min(Math.Max(value, minValue), maxValue);
        }

        /// <summary>
        /// Clips the specified value so it does not exceed min or max.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="minValue">The minimum value.</param>
        /// <param name="maxValue">The maximum value.</param>
        /// <returns>The clipped value.</returns>
        public static int Clip(this int value, int minValue, int maxValue)
        {
            return Math.Min(Math.Max(value, minValue), maxValue);
        }

        /// <summary>
        /// Clips the specified value so it does not exceed min or max.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="minValue">The minimum value.</param>
        /// <param name="maxValue">The maximum value.</param>
        /// <returns>The clipped value.</returns>
        public static long Clip(this long value, long minValue, long maxValue)
        {
            return Math.Min(Math.Max(value, minValue), maxValue);
        }

        #endregion
    }
}