using System.Linq;
using Exercism.Analyzers.CSharp.Analyzers.Syntax;
using Exercism.Analyzers.CSharp.Analyzers.Syntax.Comparison;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Exercism.Analyzers.CSharp.Analyzers.Shared.SharedSyntaxFactory;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Exercism.Analyzers.CSharp.Analyzers.TwoFer
{
    internal static class TwoFerSolutionParser
    {
        public static TwoFerSolution Parse(ParsedSolution solution)
        {
            var twoFerClass = solution.SyntaxRoot.GetClass("TwoFer");
            var speakMethod = twoFerClass?.GetMethod("Speak");
            var speakMethodParameter = speakMethod?.ParameterList.Parameters.FirstOrDefault();
            var speakMethodReturnedExpression = speakMethod?.ReturnedExpression();
            var speakMethodVariable = speakMethod?.AssignedVariable();
            var twoFerError = ToTwoFerError(twoFerClass, speakMethod, speakMethodParameter);

            return new TwoFerSolution(solution, twoFerClass, speakMethod, speakMethodParameter, speakMethodReturnedExpression, speakMethodVariable, twoFerError);
        }

        private static TwoFerError ToTwoFerError(ClassDeclarationSyntax? twoFerClass, MethodDeclarationSyntax? speakMethod, ParameterSyntax? speakMethodParameter)
        {
            
            if (twoFerClass?.UsesOverloads() ?? false)
                return TwoFerError.UsesOverloads;

            if (speakMethod?.MissingSpeakMethod() ?? true)
                return TwoFerError.MissingSpeakMethod;
                
            if (speakMethod?.InvalidSpeakMethod(speakMethodParameter) ?? false)
                return TwoFerError.InvalidSpeakMethod;

            if (speakMethod?.UsesDuplicateString() ?? false)
                return TwoFerError.UsesDuplicateString;

            if (speakMethod?.NoDefaultValue() ?? false)
                return TwoFerError.NoDefaultValue;

            if (speakMethodParameter?.UsesInvalidDefaultValue() ?? false)
                return TwoFerError.InvalidDefaultValue;

            if (speakMethod?.UsesStringReplace() ?? false)
                return TwoFerError.UsesStringReplace;

            if (speakMethod?.UsesStringJoin() ?? false)
                return TwoFerError.UsesStringJoin;

            if (speakMethod?.UsesStringConcat() ?? false)
                return TwoFerError.UsesStringConcat;

            return TwoFerError.None;
        }

        private static bool MissingSpeakMethod(this MethodDeclarationSyntax speakMethod) =>
            speakMethod == null;

        private static bool InvalidSpeakMethod(this MethodDeclarationSyntax speakMethod, ParameterSyntax? speakMethodParameter) =>
            speakMethod.ParameterList.Parameters.Count != 1 ||
            !(speakMethodParameter?.Type.IsEquivalentWhenNormalized(
                PredefinedType(Token(SyntaxKind.StringKeyword))) ?? false);

        private static bool UsesOverloads(this ClassDeclarationSyntax twoFerClass) =>
            twoFerClass.GetMethods("Speak").Count() > 1;

        private static bool UsesDuplicateString(this MethodDeclarationSyntax speakMethod)
        {
            var literalExpressionCount = speakMethod
                .DescendantNodes<LiteralExpressionSyntax>()
                .Count(literalExpression => literalExpression.Token.ValueText.Contains("One for"));

            var interpolatedStringTextCount = speakMethod
                .DescendantNodes<InterpolatedStringTextSyntax>()
                .Count(interpolatedStringText => interpolatedStringText.TextToken.ValueText.Contains("One for"));

            return literalExpressionCount + interpolatedStringTextCount > 1;
        }

        private static bool UsesStringJoin(this MethodDeclarationSyntax speakMethod) =>
            speakMethod.InvokesMethod(StringMemberAccessExpression(IdentifierName("Join")));

        private static bool UsesStringConcat(this MethodDeclarationSyntax speakMethod) =>
            speakMethod.InvokesMethod(StringMemberAccessExpression(IdentifierName("Concat")));

        private static bool UsesStringReplace(this MethodDeclarationSyntax methodDeclarationSyntax) =>
            methodDeclarationSyntax.InvokesMethod(IdentifierName("Replace"));

        private static bool NoDefaultValue(this MethodDeclarationSyntax speakMethod) =>
            speakMethod.ParameterList.Parameters.All(parameter => parameter.Default == null);

        private static bool UsesInvalidDefaultValue(this ParameterSyntax speakMethodParameter) =>
            !speakMethodParameter.Default.Value.IsEquivalentWhenNormalized(NullLiteralExpression()) &&
            !speakMethodParameter.Default.Value.IsEquivalentWhenNormalized(StringLiteralExpression("you"));
    }
}