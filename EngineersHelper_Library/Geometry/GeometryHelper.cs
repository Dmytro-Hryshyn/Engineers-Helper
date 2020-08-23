using System;

namespace Geometry
{
    public static class GeometryHelper
    {
        /// <summary>
        /// Converting Angle from degrees to radians
        /// </summary>
        /// <param name="degrees">angle in degrees</param>
        /// <returns>Angle in radians format</returns>
        public static double ToRadian(this double degrees)
        {
            return degrees * Math.PI / 180;
        }

        /// <summary>
        /// Converting Agle from radians to degrees.
        /// </summary>
        /// <param name="radians">angle in radians </param>
        /// <returns>Angle in degrees format </returns>
        public static double ToDegrees(this double radians)
        {
            return radians * 180 / Math.PI;
        }


        public static double SqRoot(this double value)
        {
            return Math.Sqrt(value);
        }
    }
}
