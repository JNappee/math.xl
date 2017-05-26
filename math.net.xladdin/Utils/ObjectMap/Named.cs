using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math.net.xladdin
{
    public abstract class Named : INamed
    {
        private readonly string _name;
        public string Name => _name;

        protected Named(string name)
        {
            _name = name;
        }
    }

    public class NameContainer : Named
    {
        private readonly object _object;
        public object Object => _object;

        public NameContainer(string name, object o)
            : base(name)
        {
            _object = o;
        }
    }
}
