using System;
using System.Linq;
using System.Reflection;
using System.Text;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Exercism.Analyzers.CSharp.SyntaxFactoryGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var xxx = IdentifierName("");
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var codeAnalysiscSharpAssembly = assemblies
                .FirstOrDefault(a => a.FullName?.Split(',')[0] == "Microsoft.CodeAnalysis.CSharp");
            var roslynSyntaxFactoryClass = codeAnalysiscSharpAssembly?
                .GetTypes()
                .Where(t => t.IsClass)
                .FirstOrDefault(c => c.FullName == "Microsoft.CodeAnalysis.CSharp.SyntaxFactory");
            var roslynSyntaxFactoryMethods = roslynSyntaxFactoryClass
                .GetMethods()
                .Where(m => m.IsPublic && m.IsStatic)
                .ToList();
            var sb = new StringBuilder();
            sb.AppendLine("using Microsoft.CodeAnalysis.CSharp;");
            sb.AppendLine();
            sb.AppendLine("namespace Exercism.Analyzers.CSharp");
            sb.AppendLine("{");
            sb.AppendLine("public static class NullSafeSyntaxFactory");
            sb.AppendLine("{");
            foreach (var method in roslynSyntaxFactoryMethods)
            {
                sb.Append("\tpublic static ");
                sb.Append(method.ReturnType.PrettyTypeName());
                sb.Append(" ");
                sb.Append(method.Name);
                sb.Append("(");
                ParameterInfo firstParam; 
                if ((firstParam = method.GetParameters().FirstOrDefault()) != null)
                    sb.Append($"{firstParam.ParameterType.PrettyTypeName()} @{firstParam.Name}");
                foreach (var param in method.GetParameters().Skip(1))
                {
                    sb.Append(", ");
                    sb.Append($"{param.ParameterType.PrettyTypeName()} @{param.Name}");
                }
                sb.Append(")");
                sb.AppendLine();
                sb.AppendLine("\t{");
                sb.Append("\t\t");
                sb.Append($"return SyntaxFactory.{method.Name}");
                sb.Append("(");
                ParameterInfo firstArg; 
                if ((firstArg = method.GetParameters().FirstOrDefault()) != null)
                    sb.Append($"@{firstArg.Name}");
                foreach (var arg in method.GetParameters().Skip(1))
                {
                    sb.Append(", ");
                    sb.Append($"@{arg.Name}");
                }

                sb.AppendLine(");");
                sb.AppendLine("\t}");
                sb.AppendLine();
            }
            sb.AppendLine("}");
            sb.AppendLine("}");
            var @else = 55;
        }
        
    }

    public static class ToolExtensions
    {
        // https://stackoverflow.com/a/25287378/96167
        public static string PrettyTypeName(this Type t)
        {
            if (t.IsArray)
            {
                return PrettyTypeName(t.GetElementType()) + "[]";
            }

            if (t.IsGenericType)
            {
                return string.Format(
                    "{0}<{1}>",
                    t.Name.Substring(0, t.Name.LastIndexOf("`", StringComparison.InvariantCulture)),
                    string.Join(", ", t.GetGenericArguments().Select(PrettyTypeName)));
            }

            return t.Name;
        }
        
    }
}