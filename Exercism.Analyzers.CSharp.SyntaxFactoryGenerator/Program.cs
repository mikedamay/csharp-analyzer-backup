using System;
using System.Linq;
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
            var classes = codeAnalysiscSharpAssembly?
                .GetTypes()
                .Where(t => t.IsClass)
                .FirstOrDefault(c => c.FullName == "Microsoft.CodeAnalysis.CSharp.SyntaxFactory");

            var list = assemblies[3].GetTypes().Where(t => t.IsClass).Where(c => c.FullName.Contains("SyntaxFactory"))
                .ToList();
        }
    }
}