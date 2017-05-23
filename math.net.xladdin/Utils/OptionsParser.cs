using System;

namespace math.net.xladdin
{
    public static class OptionsParser
    {
        public static string String(string options, string name, string defaultValue)
        {
            var opt = options.Split(';');
            var splitOpt = Array.ConvertAll(opt, o => o.Split('='));
            var res = Array.Find(splitOpt, sa => sa.GetLength(0) == 2 && sa[0] == name);
            if (res == null)
                return defaultValue;
            return res[1];
        }


        public static bool Bool(string options, string name, bool defaultValue)
        {
            var s = String(options, name, defaultValue.ToString());
            return bool.Parse(s);
        }

        public static double Double(string options, string name, double defaultValue)
        {
            var s = String(options, name, defaultValue.ToString());
            return double.Parse(s);
        }
    }
}
