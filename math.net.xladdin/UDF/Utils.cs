using ExcelDna.Integration;
using NetOffice.ExcelApi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace math.net.xladdin
{
    public static class CubicSpline
    {
        [ExcelFunction(Description = "CubicSpline InterpolateAkima")]
        public static object CubicSpline_InterpolateAkima(double[] x, [ExcelArgument()] double[] y)
        {
            try
            {
                return MathNet.Numerics.Interpolation.CubicSpline.InterpolateAkima(x, y);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
