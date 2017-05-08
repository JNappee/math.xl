using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace XlCirrus
{
    public static class Format
    {
        internal static object Return(DataTable dt, ExcelReference caller, string options = "None")
        {
            var res = new object[dt.Rows.Count + 1, dt.Columns.Count];
            for (int j = 0; j < dt.Columns.Count; j++)
                res[0, j] = dt.Columns[j].ColumnName;
            for (int i = 0; i < dt.Rows.Count; i++)
                for (int j = 0; j < dt.Columns.Count; j++)
                    res[i + 1, j] = dt.Rows[i][j];

            return Return(res, caller, options);
        }

        internal static object Return<T>(T[,] a, ExcelReference caller, string options = "None")
        {
            var fill = OptionsParser.String(options, "fill", "NA");
            var warn = OptionsParser.String(options, "warn", "all");

            var l0 = a.GetLength(0);
            var l1 = a.GetLength(1);
            var destSize = DestSizes(caller);
            var ld0 = destSize.Item1;
            var ld1 = destSize.Item2;

            if (warn == "all")
            {
                Error.Require(l0 <= ld0, "Excel range rows [", ld0, "] is smaller than data size [", l0, "].");
                Error.Require(l1 <= ld1, "Excel range cols [", ld1, "] is smaller than data size [", l1, "].");
            }

            var doFill = l0 < ld0 || l1 < ld1;
            var filler = GetFiller(fill);
            if (doFill && !(filler is double && double.IsNaN((double)filler)))
            {
                var newArray = new object[ld0, ld1];
                for (int i = 0; i < Math.Min(l0, ld0); i++)
                {
                    for (int j = 0; j < Math.Min(l1, ld1); j++)
                        newArray[i, j] = a[i, j];
                    for (int j = Math.Min(l1, ld1); j < ld1; j++)
                        newArray[i, j] = filler;
                }

                for (int i = Math.Min(l0, ld0); i < ld0; i++)
                    for (int j = 0; j < ld1; j++)
                        newArray[i, j] = filler;

                return newArray;
            }
            return a;
        }


        internal static object Return<T>(T[] a, ExcelReference caller, string options = "None")
        {
            var fill = OptionsParser.String(options, "fill", "NA");
            var warn = OptionsParser.String(options, "warn", "all");

            var size = a.Length;
            var destSize = DestSize(caller);

            if (warn == "all")
                Error.Require(size <= destSize, "Excel range [", destSize, "] is smaller than data size [", size, "].");

            var doFill = size < destSize;
            if (doFill)
            {
                var filler = GetFiller(fill);
                if (!(filler is double && double.IsNaN((double)filler)))
                {
                    var newArray = new object[destSize];
                    Array.Copy(a, newArray, size);
                    for (int i = size; i < destSize; i++)
                        newArray[i] = filler;

                    return Transpose(newArray, caller);
                }
            }
            return Transpose(a, caller);
        }

        private static object GetFiller(string fill)
        {
            switch (fill)
            {
                case "string":
                    return "";
                case "double":
                    return 0.0;
                default:
                    return double.NaN;
            }
        }

        /// <summary>
        /// Use this if you want to expose a list of objects and their public properties automatically
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="exclude"></param>
        /// <returns></returns>
        internal static DataTable ToDataTable<T>(this IEnumerable<T> items, string[] exclude = null)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            var Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            // remove excluded ones
            if (exclude != null)
                Props = Props.Where(p => !exclude.Contains(p.Name)).ToArray();
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }


        private static object Transpose<T>(T[] a, ExcelReference caller)
        {
            var length = a.GetLength(0);
            if (length == 1)
                return a;

            if (IsDestColumn(caller))
            {
                var nres = new T[length, 1];
                for (int i = 0; i < length; i++)
                    nres[i, 0] = a[i];
                return nres;
            }
            return a;
        }

        private static bool IsDestColumn(ExcelReference caller)
        {
            return caller != null && caller.RowFirst != caller.RowLast && caller.ColumnFirst == caller.ColumnLast;
        }

        private static int DestSize(ExcelReference caller)
        {
            if (IsDestColumn(caller))
                return caller.RowLast - caller.RowFirst + 1;
            return caller.ColumnLast - caller.ColumnFirst + 1;
        }


        private static Tuple<int, int> DestSizes(ExcelReference caller)
        {
            return new Tuple<int, int>(caller.RowLast - caller.RowFirst + 1, caller.ColumnLast - caller.ColumnFirst + 1);
        }
    }
}
