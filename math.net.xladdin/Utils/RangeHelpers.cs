using ExcelDna.Integration;
using NetOffice.ExcelApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math.net.xladdin
{
    internal static class RangeHelpers
    {
        internal static string[] RangeToStringArray(Range r)
        {
            // only allow a row range or col range
            Error.Require((r.Rows.Count == 1 && r.Columns.Count >= 1) || (r.Rows.Count >= 1 && r.Columns.Count == 1),
                "Expected only one row or one column.");

            var res = new string[r.Cells.Count];
            for (int i = 0; i < r.Cells.Count; i++)
                res[i] = r[i].Value2.ToString();
            return res;
        }

        internal static Int32[] RangeToIntArray(Range r)
        {
            // only allow a row range or col range
            Error.Require((r.Rows.Count == 1 && r.Columns.Count >= 1) || (r.Rows.Count >= 1 && r.Columns.Count == 1),
                "Expected only one row or one column.");

            var res = new Int32[r.Cells.Count];
            for (int i = 0; i < r.Cells.Count; i++)
                res[i] = Convert.ToInt32(r[i].Value2);
            return res;
        }

        internal static Range ObjectToRange(object xlref)
        {
            return ReferenceToRange((ExcelReference)xlref);
        }

        internal static Range ReferenceToRange(ExcelReference xlref)
        {
            object refText = XlCall.Excel(XlCall.xlfReftext, xlref, true);
            var xlApp = new NetOffice.ExcelApi.Application(null, ExcelDnaUtil.Application);
            return xlApp.Range(refText);
        }
    }
}
