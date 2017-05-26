using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace math.net.xlgen
{
    public abstract class TypeHelper
    {
        private static readonly Dictionary<Type, TypeHelper> mappers = MapperAttribute.Mappers;

        public static bool Handles(Type t) { return mappers.ContainsKey(t); }
        public static TypeHelper Get(Type t) { return mappers[t]; }

        protected virtual bool NeedsAllowReference() { return false; }
        public abstract bool NeedsMapping();
        public abstract ExpressionStatementSyntax[] ToExpression(string name);
        public abstract string ToArgName(string name);
        public abstract string ExcelParameterTypeName();

        public static ParameterSyntax ToStringObjectExcelParameter(string name, DocFunction docF)
        {
            var pa = name.AsParameter()
                         .WithType("System.String".AsTypeSyntax());
            // add doc
            {
                string ExcelFuncAtt = "Name=\"" + name + "\"";
                if (docF != null)
                {
                    var ps = docF.Params.FirstOrDefault(a => a.Name == name);
                    if (ps != null)
                        ExcelFuncAtt += ", Description=@\"" + ps.Summary + "\"";
                }

                var paramExcelAtt = GenExcelExports.CreateAttribute("ExcelArgument", ExcelFuncAtt);
                pa = pa.AddAttributeLists(SyntaxFactory.AttributeList().AddAttributes(paramExcelAtt));
            }
            return pa;
        }

        public ParameterSyntax ToExcelParameter(ParameterInfo p, DocFunction docF)
        {
          var pa = p.Name.AsParameter()
                       .WithType(ExcelNameHelper.GetParameterNameClean(p).AsTypeSyntax());
            // add doc
            {
                string ExcelFuncAtt = "Name = \"" + p.Name + "\"";
                if (NeedsAllowReference())
                    ExcelFuncAtt += ", AllowReference = true";

                if (docF != null)
                {
                    var ps = docF.Params.FirstOrDefault(a => a.Name == p.Name);
                    if (ps != null)
                        ExcelFuncAtt += ", Description = @\"" + ps.Summary + "\"";
                }

                var paramExcelAtt = GenExcelExports.CreateAttribute("ExcelArgument", ExcelFuncAtt);
                pa = pa.AddAttributeLists(SyntaxFactory.AttributeList().AddAttributes(paramExcelAtt));
            }
            return pa;
        }
        
        public ParameterSyntax ToInternalParameter(ParameterInfo p)   
        {
            return p.Name.AsParameter()
                    .WithType(InternalNameHelper.GetNameClean(p).AsTypeSyntax());
        }

        public virtual List<StatementSyntax> HandleReturnType(ExpressionSyntax functionCall)
        {
            return new List<StatementSyntax>() { SyntaxFactory.ReturnStatement(functionCall).WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed) };
        }

        public virtual bool AddOptionsExcelParameter()
        {
            return false;
        }
    }
    
}
