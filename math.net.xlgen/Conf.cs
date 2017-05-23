using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math.net.xlgen
{
    public static class Conf
    {
        public static string Internal_Namespace =>  ConfigurationManager.AppSettings.Get("Internal.Namespace");
        public static string Internal_ClassName => ConfigurationManager.AppSettings.Get("Internal.ClassName");
        public static string Internal_WritePath => ConfigurationManager.AppSettings.Get("Internal.WritePath");
        public static string ExcelExport_Namespace => ConfigurationManager.AppSettings.Get("ExcelExport.Namespace");
        public static string ExcelExport_ClassName => ConfigurationManager.AppSettings.Get("ExcelExport.ClassName");
        public static string ExcelExport_WritePath => ConfigurationManager.AppSettings.Get("ExcelExport.WritePath");

    }
}
