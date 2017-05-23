using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math.net.xladdin
{
    public class Error : Exception
    {
        public Error(object first, params object[] msg)
            : base(first + string.Join("", msg))
        {

        }

        public Error(Exception inner, params object[] msg)
            : base(string.Join("", msg), inner)
        {

        }

        public static void Require(bool trueOrThrow, object first, params object[] msg)
        {
            if (!trueOrThrow)
                throw new Error(first, msg);
        }

        private static bool _useExcelErrors;

        public static bool UseExcelErrors { get => _useExcelErrors; set => _useExcelErrors = value; }
        public static object ExcelHandle(Exception ex)
        {
            if (!UseExcelErrors)
                return ex.ToString();

            return ExcelError.ExcelErrorValue;
        }
    }
}
