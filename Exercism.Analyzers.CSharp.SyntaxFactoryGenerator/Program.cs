using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
            sb.AppendLine(@"
                using System;
                using System.Collections.Generic;
                using System.Text;
                using System.Threading;
                using Microsoft.CodeAnalysis;
                using Microsoft.CodeAnalysis.CSharp;
                using Microsoft.CodeAnalysis.CSharp.Syntax;
                using Microsoft.CodeAnalysis.Text;
                ");
            sb.AppendLine();
            sb.AppendLine("namespace Exercism.Analyzers.CSharp.Analyzers");
            sb.AppendLine("{");
            sb.AppendLine();
            sb.AppendLine("public static partial class NullSafeSyntaxFactory");
            sb.AppendLine("{");
            foreach (var method in roslynSyntaxFactoryMethods)
            {
                if (method.GetCustomAttributes().Any(a => a is ObsoleteAttribute))
                {
                    continue;
                }
                if (!method.IsSpecialName)
                {
                    AddMethod(sb, method);
                }
                else
                {
                    sb.Append("\tpublic static ");
                    sb.Append(method.ReturnType.PrettyTypeName());
                    sb.Append(" ");
                    sb.Append(method.Name.Substring(4));    // get_Space => Space
                    sb.Append(" { get; } = ");
                    sb.Append($"SyntaxFactory.{method.Name.Substring(4)};");
                    sb.AppendLine();
                    sb.AppendLine();
                }
            }
            sb.AppendLine("}");
            sb.AppendLine("}");
        }

        private static void AddMethod(StringBuilder sb, MethodInfo method)
        {
            AddSignature(sb, method);

            foreach (var genericArg in method.GetGenericArguments())
            {
                AddConstraints(genericArg, sb);
            }

            sb.AppendLine();
            sb.AppendLine("\t{");
            sb.Append("\t\tif (AnyNull(");
            AddArgumentNames(sb, method);
            sb.Append(")) return null;");
            sb.AppendLine();
            sb.Append("\t\t");
            sb.Append($"return SyntaxFactory.{method.Name}");
            AddGenericArguments(sb, method);
            sb.Append("(");
            AddArgumentNames(sb, method);
            sb.AppendLine(");");
            sb.AppendLine("\t}");
            sb.AppendLine();
        }

        private static void AddArgumentNames(StringBuilder sb, MethodInfo method)
        {
            ParameterInfo firstArg;
            if ((firstArg = method.GetParameters().FirstOrDefault()) != null)
                sb.Append($"@{firstArg.Name}{(firstArg.ParameterType.IsValueType ? "!.Value" : string.Empty)}");
            foreach (var arg in method.GetParameters().Skip(1))
            {
                sb.Append(", ");
                sb.Append($"@{arg.Name}{(arg.ParameterType.IsValueType ? "!.Value" : string.Empty)}");
            }
        }

        private static void AddSignature(StringBuilder sb, MethodInfo method)
        {
            sb.Append("\tpublic static ");
            sb.Append(method.ReturnType.PrettyTypeName());
            sb.Append("? ");
            sb.Append(method.Name);
            AddGenericArguments(sb, method);

            sb.Append("(");
            ParameterInfo firstParam;
            if ((firstParam = method.GetParameters().FirstOrDefault()) != null)
                sb.Append($"{firstParam.ParameterType.PrettyTypeName()}{(firstParam.ParameterType.IsArray ? string.Empty : "?")} @{firstParam.Name}");
            foreach (var param in method.GetParameters().Skip(1))
            {
                sb.Append(", ");
                sb.Append($"{param.ParameterType.PrettyTypeName()}{(param.ParameterType.IsArray ? string.Empty : "?")} @{param.Name}");
            }
            sb.Append(")");
        }

        private static void AddGenericArguments(StringBuilder sb, MethodInfo method)
        {
            if (method.GetGenericArguments().Length > 0)
            {
                sb.Append("<");
                Type firstGenericArg;
                if ((firstGenericArg = method.GetGenericArguments().First()) != null)
                    sb.Append(firstGenericArg.PrettyTypeName());
                foreach (var genericArg in method.GetGenericArguments().Skip(1))
                {
                    sb.Append(", ");
                    sb.Append(genericArg.PrettyTypeName());
                }

                sb.Append(">");
            }
        }

        private static void AddConstraints(Type genericArg, StringBuilder sb)
        {
            if (genericArg.GetGenericParameterConstraints().Length > 0)
            {
                sb.Append(" where ");
                sb.Append(genericArg.PrettyTypeName());
                sb.Append(": ");
            }

            Type firstConstraint;
            if ((firstConstraint = genericArg.GetGenericParameterConstraints().FirstOrDefault()) != null)
            {
                sb.Append(firstConstraint.PrettyTypeName());
            }

            foreach (var constraint in genericArg.GetGenericParameterConstraints().Skip(1))
            {
                sb.Append(", ");
                sb.Append(constraint.PrettyTypeName());
            }
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