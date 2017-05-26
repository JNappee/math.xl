using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math.net.xladdin
{
    public class Graph
    {
        public static Graph Instance { get; } = new Graph();
        private Graph() { }


        private readonly Dictionary<string, Tuple<int, INamed>> objects = new Dictionary<string, Tuple<int, INamed>>();

        public string Add(object o, string name, params object[] inputs)
        {
            var named = new NameContainer(name, o);
            var hash = ComputeHash(name, inputs);
            objects[named.Name] = new Tuple<int, INamed>(hash, named);
            return named.Name;
        }

        private int ComputeHash(object first, object[] inputs)
        {
            if (inputs.Length == 0)
                return first.GetHashCode();
            return first.GetHashCode() ^ Array.ConvertAll(inputs, ob => ob.GetHashCode()).Aggregate((h1, h2) => h1 ^ h2);
        }


        public bool HasCached<T>(out string excelName, string name, params object[] inputs)
        {
            if (objects.ContainsKey(name))
            {
                var tuple = objects[name];
                var hash = ComputeHash(name, inputs);
                if (tuple.Item1 == hash)
                {
                    var nc = tuple.Item2 as NameContainer;
                    if (nc != null && nc.Object is T)
                    {
                        excelName = ToExcelName(name);
                        return true;
                    }
                }
            }
            excelName = null;
            return false;
        }

        public T Get<T>(string name)
        {
            Error.Require(objects.ContainsKey(name), "Couldnt find ", name, " object of Type [", typeof(T), "].");
            var nc = objects[name].Item2 as NameContainer;
            return (T)nc.Object;
        }

        //public static bool IsExcelName(string excelName)
        //{
        //    return excelName.Contains("  ~<");
        //}

        //public static string GetName(string excelName)
        //{
        //    var i = excelName.IndexOf('~');
        //    Error.Require(i > -1, "name provided is not an Excel name");
        //    return excelName.Substring(0, i);
        //}


        public static string ToExcelName(string internalName)
        {
           // object app = ExcelDnaUtil.Application;
            object refText = "";// XlCall.Excel(XlCall.xlfReftext, xlref, true);

            return internalName + (char)10  + "  ~<" + refText + ">";
        }
    }
}
