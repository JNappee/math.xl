using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math.net.xladdin
{
    interface ITypeMapper<T>
    {
        T FromString(string s);

        string ToString(T c);
    }
}
