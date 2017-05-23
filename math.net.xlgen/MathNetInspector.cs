using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace math.net.xlgen
{
    public static class MathNetInspector
    {
        /// <summary>
        /// Returns all methods in Math.Net that dont return void and arent Generic
        /// </summary>
        /// <returns></returns>
        public static Dictionary<Type, MethodInfo[]> GetMathNetMethods()
        {
            var MNAssembly = typeof(MathNet.Numerics.Combinatorics).Assembly;
            var types = MNAssembly.GetTypes();
            var res = new Dictionary<Type, MethodInfo[]>();
            foreach (var t in types.Where(type => type.IsPublic))
            {
                var ms = t.GetMethods(BindingFlags.Static | BindingFlags.Public);
                if (ms.Length > 0)
                    res[t] = ms;
            }
            return res;
        }

    }
}
