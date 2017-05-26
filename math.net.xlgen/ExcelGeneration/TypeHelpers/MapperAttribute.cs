using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace math.net.xlgen
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class MapperAttribute : Attribute
    {
        private readonly Type _type;
        public MapperAttribute(Type t)
        {
            _type = t;
        }

        public static Dictionary<Type, TypeHelper> Mappers { get; } = GetAllMappers();
        
        private static Dictionary<Type, TypeHelper> GetAllMappers()
        {
            var t = typeof(MapperAttribute);
            var types = t.Assembly.GetTypes().Where(ty => ty.GetCustomAttributes(t, false).Any());
            var res = new Dictionary<Type, TypeHelper>();

            foreach (var mapper in types)
            {
                var att = mapper.GetCustomAttributes(t, false).Cast<MapperAttribute>();
                foreach (var a in att)
                {
                     var m = (TypeHelper)mapper.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).GetGetMethod().Invoke(null, null);
                    res[a._type] = m;
                }
            }

            return res;
        }
    }
}
