using System.Linq;
using Exercism.Analyzers.CSharp.Analyzers.Syntax;
using Microsoft.CodeAnalysis;
using static Exercism.Analyzers.CSharp.Analyzers.SharedComments;

namespace Exercism.Analyzers.CSharp.Analyzers
{
    internal static class SharedAnalyzer
    {
        public static SolutionAnalysis Analyze(ParsedSolution parsedSolution)
        {
            if (parsedSolution.HasCompileErrors())
                return parsedSolution.DisapproveWithComment(FixCompileErrors);

            if (parsedSolution.HasMainMethod())
                return parsedSolution.DisapproveWithComment(RemoveMainMethod);

            if (parsedSolution.ThrowsNotImplementedException())
                return parsedSolution.DisapproveWithComment(RemoveThrowNotImplementedException);
            
            return null;
        }

        private static bool HasCompileErrors(this ParsedSolution parsedSolution) =>
            parsedSolution.SyntaxRoot.GetDiagnostics().Any(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);

        private static bool HasMainMethod(this ParsedSolution parsedSolution) =>
            parsedSolution.SyntaxRoot.HasClass("Program") &&
            parsedSolution.SyntaxRoot.HasMethod("Main");

        private static bool ThrowsNotImplementedException(this ParsedSolution parsedSolution) =>
            parsedSolution.SyntaxRoot.ThrowsException("NotImplementedException") ||
            parsedSolution.SyntaxRoot.ThrowsException("System.NotImplementedException");
    }
}