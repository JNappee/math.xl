using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XlCirrus
{
    public static class UDFs
    {

        private static Type Compile(string linq)
        {
            using (Microsoft.CSharp.CSharpCodeProvider foo = new Microsoft.CSharp.CSharpCodeProvider(new Dictionary<string, string> { { "CompilerVersion", "v4.0" } }))
            {
                var code = @"
using System;
using System.Collections.Generic;
using System.Linq;
public class LinqFunction { public object Execute(double[] v) { return " + linq + ";}}";

                var parameters = new System.CodeDom.Compiler.CompilerParameters() { GenerateInMemory = true, ReferencedAssemblies = { "mscorlib.dll", "System.dll", "System.Core.dll", } };
                parameters.ReferencedAssemblies.Add("System.dll");

                var res = foo.CompileAssemblyFromSource(parameters, code);

                return res.CompiledAssembly.GetType("LinqFunction");
            }
        }

        private static object Run(Type myType, double[] data)
        {
            var obj = Activator.CreateInstance(myType);
            return myType.GetMethod("Execute").Invoke(obj, new object[] { data });
        }


        [ExcelFunction(Description = "Apply Linq to an array of data")]
        public static object Linq_DArray(
            [ExcelArgument(Description = "range of data")]double[] data,
            [ExcelArgument(Description = "linq string. Ex: d * 2 ")]string linq,
            [ExcelArgument(Description = "options, None by default, can add fill=true, warn=none")]string options = "None")
        {
            try
            {
                var caller = XlCall.Excel(XlCall.xlfCaller) as ExcelReference;

                // Some optimizations can be done here to cache compiled strings
                // Also some optim for loading this from an Appdomain so we can clean it after it hasnt been used for awhile so as not to ramp up memory?
                var f = Compile(linq);
                var res = Run(f, data);


                if (res is IEnumerable<object>)
                    return Format.Return(((IEnumerable<object>)res).ToArray(), caller, options);
                else if (res is IEnumerable<double>)
                    return Format.Return(((IEnumerable<double>)res).ToArray(), caller, options);
                else
                    return res;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
