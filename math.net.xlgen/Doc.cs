using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace math.net.xlgen
{
    public static class Doc
    {
        private static readonly Dictionary<string, DocFunction> doc;
        static Doc()
        {
            var functions = Doc.LoadDoc();
            doc = functions.ToDictionary(f => f.Name, f => f);
        }

        public static DocFunction GetOrNull(Type t, MethodInfo m)
        {
            var docName = NameHelper.GetDocName(t, m);
            return GetOrNull(docName);
        }

        private static DocFunction GetOrNull(string name)
        {
            if (doc.ContainsKey(name))
                return doc[name];
            return null;
        }

        public static List<DocFunction> LoadDoc()
        {
            var path = typeof(MathNet.Numerics.Complex32).Assembly.Location.Replace(".dll", ".xml");
            var xDoc = XDocument.Load(path);
            var members = xDoc.Descendants("member");
            var functions = new List<DocFunction>();
            foreach (var m in members)
            {
                var name = m.Attribute("name").Value;
                if (!name.StartsWith("T:"))
                {
                    name = name.Replace("System.", "");
                    string summary = "No information";
                    var summaries = m.Descendants("summary");
                    if (summaries.Count() > 0)
                        summary = summaries.First().Value.Trim();
                    var parameters = m.Descendants("param");
                    var docParams = parameters.Select(p => new DocParam() { Name = p.Attribute("name").Value, Summary = p.Value.Trim() }).ToArray();
                    functions.Add(new DocFunction() { Name = name.Substring(2), Summary = summary, Params = docParams });
                }
            }
            return functions;
        }
    }


    public class DocFunction
    {
        public string Name { get; set; }
        public string Summary { get; set; }

        public DocParam[] Params { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class DocParam
    {
        public string Name { get; set; }
        public string Summary { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
