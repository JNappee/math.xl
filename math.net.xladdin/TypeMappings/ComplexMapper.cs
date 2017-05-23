using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace math.net.xladdin
{
    public class ComplexMapper : ITypeMapper<Complex>
    {
        // The pattern has been broken down for educational purposes
        private const string regexPattern =
            // Match any float, negative or positive, group it
            @"([-+]?\d+\.?\d*|[-+]?\d*\.?\d+)" +
            // ... possibly following that with whitespace
            @"\s*" +
            // ... followed by a plus
            @"\+" +
            // and possibly more whitespace:
            @"\s*" +
            // Match any other float, and save it
            @"([-+]?\d+\.?\d*|[-+]?\d*\.?\d+)" +
            // ... followed by 'i'
            @"i";
        private static Regex complexRE = new Regex(regexPattern, RegexOptions.Compiled);
        public static bool IsComplex(object o)
        {
            var v = o.ToString();
            return complexRE.IsMatch(v);
        }

        public Complex FromString(string complexString)
        {
            Match match = complexRE.Match(complexString);
            Error.Require(match.Success, "Could not parse [", complexString, "] into a complex number.");

            var real = double.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture);
            var img = double.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
            return new Complex(real, img);
        }

        public string ToString(Complex c)
        {
            bool hasImg = Math.Abs(c.Imaginary) > 10e-12;
            bool hasReal = Math.Abs(c.Real) > 10e-12;

            if (hasReal && hasImg)
                return c.Real.ToString() + (c.Imaginary > 0 ? " + " : " - ") + Math.Abs(c.Imaginary).ToString() + "i";

            if (hasReal)
                return c.Real.ToString();

            return c.Imaginary.ToString() + "i";
        }

    }
}
