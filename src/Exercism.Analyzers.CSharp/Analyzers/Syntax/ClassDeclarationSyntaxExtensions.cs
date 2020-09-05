using System.Linq;
using Exercism.Analyzers.CSharp.Analyzers.Syntax.Comparison;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Exercism.Analyzers.CSharp.Analyzers.Syntax
{
    internal static class ClassDeclarationSyntaxExtensions
    {
        public static VariableDeclaratorSyntax? ArgumentVariable(this ClassDeclarationSyntax classDeclaration, ExpressionSyntax argumentExpression) =>
            argumentExpression is IdentifierNameSyntax arg ? classDeclaration.AssignedVariableWithName(arg) : null;

        private static VariableDeclaratorSyntax AssignedVariableWithName(this ClassDeclarationSyntax classDeclaration, IdentifierNameSyntax variableIdentifierName)
        {
            var xxx = classDeclaration
                .DescendantNodes<VariableDeclaratorSyntax>()
                .FirstOrDefault(variableDeclarator => variableDeclarator.Identifier.IsEquivalentWhenNormalized(variableIdentifierName.Identifier));
            return xxx;
        }
    }
}