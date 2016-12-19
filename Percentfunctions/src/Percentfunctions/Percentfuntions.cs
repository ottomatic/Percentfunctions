using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Percentfunctions
{
    public class Percentfuntions
    {
        public Percentfuntions()
        {
        }

        /// <summary>
        /// The percentile rank of a score is the percentage of scores in its frequency 
        /// distribution that are equal to or lower than it.
        /// See https://en.wikipedia.org/wiki/Percentile_rank
        /// </summary>
        /// <param name="elementValue">The value for which to calculate the percentile rank</param>
        /// <param name="elements">The collection of values to base the rank on.</param>
        /// <returns></returns>
        public static double? Percentrank(int? elementValue, int?[]elements)
        {
            if (elementValue == null)
            {
                return null;
            }

            int[] nonNullElements = (from int? element in elements
                                     where element.HasValue
                                     orderby element.Value descending
                                     select element.Value).ToArray();

            if (nonNullElements.Length == 0)
            {
                return 100d;
            }

            int countScoresLowerThanElementValue = nonNullElements.Length;
            int elementValueFrequency = 0;
            for (int elementIndex = 0; elementIndex < nonNullElements.Length; elementIndex++)
            {
                if (nonNullElements[elementIndex] < elementValue.Value)
                {
                    break;
                }
                else 
                {
                    countScoresLowerThanElementValue -= 1;
                    if (nonNullElements[elementIndex] == elementValue.Value)
                    {
                        elementValueFrequency += 1;
                    }
                }
            }
            return 100d * ((double)countScoresLowerThanElementValue + 0.5d * (double)elementValueFrequency) / (double)nonNullElements.Length;

        }

        /// <summary>
        /// The percentile rank of a score is the percentage of scores in its frequency 
        /// distribution that are equal to or lower than it.
        /// See https://en.wikipedia.org/wiki/Percentile_rank
        /// </summary>
        /// <param name="elementValue">The value for which to calculate the percentile rank</param>
        /// <param name="elements">The collection of values to base the rank on.</param>
        /// <returns></returns>
        public static double? Percentrank(double? elementValue, double?[] elements)
        {
            if (elementValue == null)
            {
                return null;
            }

            double[] nonNullElements = (from double? element in elements
                                     where element.HasValue
                                     orderby element.Value descending
                                     select element.Value).ToArray();

            if (nonNullElements.Length == 0)
            {
                return 100d;
            }

            int countScoresLowerThanElementValue = nonNullElements.Length;
            int elementValueFrequency = 0;
            for (int elementIndex = 0; elementIndex < nonNullElements.Length; elementIndex++)
            {
                if (nonNullElements[elementIndex] < elementValue.Value)
                {
                    break;
                }
                else
                {
                    countScoresLowerThanElementValue -= 1;
                    if (nonNullElements[elementIndex] == elementValue.Value)
                    {
                        elementValueFrequency += 1;
                    }
                }
            }
            return 100d * ((double)countScoresLowerThanElementValue + 0.5d * (double)elementValueFrequency) / (double)nonNullElements.Length;

        }
    }
}
