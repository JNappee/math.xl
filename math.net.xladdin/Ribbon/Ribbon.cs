using ExcelDna.Integration.CustomUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace math.net.xladdin
{
    [ComVisible(true)]
    public class RibbonController : ExcelRibbon
    {       
        public void OnOpenWebDocButtonPressed(IRibbonControl control)
        {
            System.Diagnostics.Process.Start("https://numerics.mathdotnet.com/api/");
        }

        public void OnToggelExcelErrorsButtonPressed(IRibbonControl control, bool isPressed)
        {
            Error.UseExcelErrors = isPressed;
        }
    }
}
