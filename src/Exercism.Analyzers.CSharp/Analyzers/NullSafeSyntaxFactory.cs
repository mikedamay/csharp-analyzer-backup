
                using System;
                using System.Collections.Generic;
                using System.Text;
                using System.Threading;
                using Microsoft.CodeAnalysis;
                using Microsoft.CodeAnalysis.CSharp;
                using Microsoft.CodeAnalysis.CSharp.Syntax;
                using Microsoft.CodeAnalysis.Text;
                

namespace Exercism.Analyzers.CSharp.Analyzers
{

public static class NullSafeSyntaxFactory
{
	public static Boolean AreEquivalent<TNode>(SeparatedSyntaxList<TNode> @oldList, SeparatedSyntaxList<TNode> @newList, Boolean @topLevel) where TNode: SyntaxNode
	{
		return SyntaxFactory.AreEquivalent<TNode>(@oldList, @newList, @topLevel);
	}

	public static Boolean AreEquivalent<TNode>(SeparatedSyntaxList<TNode> @oldList, SeparatedSyntaxList<TNode> @newList, Func<SyntaxKind, Boolean> @ignoreChildNode) where TNode: SyntaxNode
	{
		return SyntaxFactory.AreEquivalent<TNode>(@oldList, @newList, @ignoreChildNode);
	}

	public static ExpressionSyntax GetStandaloneExpression(ExpressionSyntax @expression)
	{
		return SyntaxFactory.GetStandaloneExpression(@expression);
	}

	public static ExpressionSyntax GetNonGenericExpression(ExpressionSyntax @expression)
	{
		return SyntaxFactory.GetNonGenericExpression(@expression);
	}

	public static Boolean IsCompleteSubmission(SyntaxTree @tree)
	{
		return SyntaxFactory.IsCompleteSubmission(@tree);
	}

	public static CaseSwitchLabelSyntax CaseSwitchLabel(ExpressionSyntax @value)
	{
		return SyntaxFactory.CaseSwitchLabel(@value);
	}

	public static DefaultSwitchLabelSyntax DefaultSwitchLabel()
	{
		return SyntaxFactory.DefaultSwitchLabel();
	}

	public static BlockSyntax Block(StatementSyntax[] @statements)
	{
		return SyntaxFactory.Block(@statements);
	}

	public static BlockSyntax Block(IEnumerable<StatementSyntax> @statements)
	{
		return SyntaxFactory.Block(@statements);
	}

	public static PropertyDeclarationSyntax PropertyDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, TypeSyntax @type, ExplicitInterfaceSpecifierSyntax @explicitInterfaceSpecifier, SyntaxToken @identifier, AccessorListSyntax @accessorList)
	{
		return SyntaxFactory.PropertyDeclaration(@attributeLists, @modifiers, @type, @explicitInterfaceSpecifier, @identifier, @accessorList);
	}

	public static ConversionOperatorDeclarationSyntax ConversionOperatorDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @implicitOrExplicitKeyword, SyntaxToken @operatorKeyword, TypeSyntax @type, ParameterListSyntax @parameterList, BlockSyntax @body, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.ConversionOperatorDeclaration(@attributeLists, @modifiers, @implicitOrExplicitKeyword, @operatorKeyword, @type, @parameterList, @body, @semicolonToken);
	}

	public static OperatorDeclarationSyntax OperatorDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, TypeSyntax @returnType, SyntaxToken @operatorKeyword, SyntaxToken @operatorToken, ParameterListSyntax @parameterList, BlockSyntax @body, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.OperatorDeclaration(@attributeLists, @modifiers, @returnType, @operatorKeyword, @operatorToken, @parameterList, @body, @semicolonToken);
	}

	public static UsingDirectiveSyntax UsingDirective(NameEqualsSyntax @alias, NameSyntax @name)
	{
		return SyntaxFactory.UsingDirective(@alias, @name);
	}

	public static AccessorDeclarationSyntax AccessorDeclaration(SyntaxKind @kind, SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, BlockSyntax @body)
	{
		return SyntaxFactory.AccessorDeclaration(@kind, @attributeLists, @modifiers, @body);
	}

	public static AccessorDeclarationSyntax AccessorDeclaration(SyntaxKind @kind, SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @keyword, BlockSyntax @body, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.AccessorDeclaration(@kind, @attributeLists, @modifiers, @keyword, @body, @semicolonToken);
	}

	public static AccessorDeclarationSyntax AccessorDeclaration(SyntaxKind @kind, SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, ArrowExpressionClauseSyntax @expressionBody)
	{
		return SyntaxFactory.AccessorDeclaration(@kind, @attributeLists, @modifiers, @expressionBody);
	}

	public static AccessorDeclarationSyntax AccessorDeclaration(SyntaxKind @kind, SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @keyword, ArrowExpressionClauseSyntax @expressionBody, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.AccessorDeclaration(@kind, @attributeLists, @modifiers, @keyword, @expressionBody, @semicolonToken);
	}

	public static TypeDeclarationSyntax TypeDeclaration(SyntaxKind @kind, SyntaxToken @identifier)
	{
		return SyntaxFactory.TypeDeclaration(@kind, @identifier);
	}

	public static TypeDeclarationSyntax TypeDeclaration(SyntaxKind @kind, String @identifier)
	{
		return SyntaxFactory.TypeDeclaration(@kind, @identifier);
	}

	public static TypeDeclarationSyntax TypeDeclaration(SyntaxKind @kind, SyntaxList<AttributeListSyntax> @attributes, SyntaxTokenList @modifiers, SyntaxToken @keyword, SyntaxToken @identifier, TypeParameterListSyntax @typeParameterList, BaseListSyntax @baseList, SyntaxList<TypeParameterConstraintClauseSyntax> @constraintClauses, SyntaxToken @openBraceToken, SyntaxList<MemberDeclarationSyntax> @members, SyntaxToken @closeBraceToken, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.TypeDeclaration(@kind, @attributes, @modifiers, @keyword, @identifier, @typeParameterList, @baseList, @constraintClauses, @openBraceToken, @members, @closeBraceToken, @semicolonToken);
	}

	public static XmlEmptyElementSyntax XmlParamRefElement(String @parameterName)
	{
		return SyntaxFactory.XmlParamRefElement(@parameterName);
	}

	public static XmlEmptyElementSyntax XmlNullKeywordElement()
	{
		return SyntaxFactory.XmlNullKeywordElement();
	}

	public static XmlElementSyntax XmlPlaceholderElement(XmlNodeSyntax[] @content)
	{
		return SyntaxFactory.XmlPlaceholderElement(@content);
	}

	public static XmlElementSyntax XmlPlaceholderElement(SyntaxList<XmlNodeSyntax> @content)
	{
		return SyntaxFactory.XmlPlaceholderElement(@content);
	}

	public static XmlEmptyElementSyntax XmlEmptyElement(String @localName)
	{
		return SyntaxFactory.XmlEmptyElement(@localName);
	}

	public static XmlElementSyntax XmlElement(String @localName, SyntaxList<XmlNodeSyntax> @content)
	{
		return SyntaxFactory.XmlElement(@localName, @content);
	}

	public static XmlElementSyntax XmlElement(XmlNameSyntax @name, SyntaxList<XmlNodeSyntax> @content)
	{
		return SyntaxFactory.XmlElement(@name, @content);
	}

	public static XmlTextAttributeSyntax XmlTextAttribute(String @name, String @value)
	{
		return SyntaxFactory.XmlTextAttribute(@name, @value);
	}

	public static XmlTextAttributeSyntax XmlTextAttribute(String @name, SyntaxToken[] @textTokens)
	{
		return SyntaxFactory.XmlTextAttribute(@name, @textTokens);
	}

	public static XmlTextAttributeSyntax XmlTextAttribute(String @name, SyntaxKind @quoteKind, SyntaxTokenList @textTokens)
	{
		return SyntaxFactory.XmlTextAttribute(@name, @quoteKind, @textTokens);
	}

	public static XmlTextAttributeSyntax XmlTextAttribute(XmlNameSyntax @name, SyntaxKind @quoteKind, SyntaxTokenList @textTokens)
	{
		return SyntaxFactory.XmlTextAttribute(@name, @quoteKind, @textTokens);
	}

	public static XmlElementSyntax XmlMultiLineElement(String @localName, SyntaxList<XmlNodeSyntax> @content)
	{
		return SyntaxFactory.XmlMultiLineElement(@localName, @content);
	}

	public static XmlElementSyntax XmlMultiLineElement(XmlNameSyntax @name, SyntaxList<XmlNodeSyntax> @content)
	{
		return SyntaxFactory.XmlMultiLineElement(@name, @content);
	}

	public static XmlTextSyntax XmlNewLine(String @text)
	{
		return SyntaxFactory.XmlNewLine(@text);
	}

	public static SyntaxToken XmlTextNewLine(String @text)
	{
		return SyntaxFactory.XmlTextNewLine(@text);
	}

	public static SyntaxToken XmlTextNewLine(SyntaxTriviaList @leading, String @text, String @value, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.XmlTextNewLine(@leading, @text, @value, @trailing);
	}

	public static SyntaxToken XmlTextNewLine(String @text, Boolean @continueXmlDocumentationComment)
	{
		return SyntaxFactory.XmlTextNewLine(@text, @continueXmlDocumentationComment);
	}

	public static XmlTextSyntax XmlText(String @value)
	{
		return SyntaxFactory.XmlText(@value);
	}

	public static XmlTextSyntax XmlText(SyntaxToken[] @textTokens)
	{
		return SyntaxFactory.XmlText(@textTokens);
	}

	public static SyntaxToken XmlTextLiteral(String @value)
	{
		return SyntaxFactory.XmlTextLiteral(@value);
	}

	public static SyntaxToken XmlTextLiteral(String @text, String @value)
	{
		return SyntaxFactory.XmlTextLiteral(@text, @value);
	}

	public static SyntaxTrivia DocumentationCommentExterior(String @text)
	{
		return SyntaxFactory.DocumentationCommentExterior(@text);
	}

	public static SyntaxList<TNode> List<TNode>() where TNode: SyntaxNode
	{
		return SyntaxFactory.List<TNode>();
	}

	public static SyntaxList<TNode> SingletonList<TNode>(TNode @node) where TNode: SyntaxNode
	{
		return SyntaxFactory.SingletonList<TNode>(@node);
	}

	public static SyntaxList<TNode> List<TNode>(IEnumerable<TNode> @nodes) where TNode: SyntaxNode
	{
		return SyntaxFactory.List<TNode>(@nodes);
	}

	public static SyntaxTokenList TokenList()
	{
		return SyntaxFactory.TokenList();
	}

	public static SyntaxTokenList TokenList(SyntaxToken @token)
	{
		return SyntaxFactory.TokenList(@token);
	}

	public static SyntaxTokenList TokenList(SyntaxToken[] @tokens)
	{
		return SyntaxFactory.TokenList(@tokens);
	}

	public static SyntaxTokenList TokenList(IEnumerable<SyntaxToken> @tokens)
	{
		return SyntaxFactory.TokenList(@tokens);
	}

	public static SyntaxTrivia Trivia(StructuredTriviaSyntax @node)
	{
		return SyntaxFactory.Trivia(@node);
	}

	public static SyntaxTriviaList TriviaList()
	{
		return SyntaxFactory.TriviaList();
	}

	public static SyntaxTriviaList TriviaList(SyntaxTrivia @trivia)
	{
		return SyntaxFactory.TriviaList(@trivia);
	}

	public static SyntaxTriviaList TriviaList(SyntaxTrivia[] @trivias)
	{
		return SyntaxFactory.TriviaList(@trivias);
	}

	public static SyntaxTriviaList TriviaList(IEnumerable<SyntaxTrivia> @trivias)
	{
		return SyntaxFactory.TriviaList(@trivias);
	}

	public static SeparatedSyntaxList<TNode> SeparatedList<TNode>() where TNode: SyntaxNode
	{
		return SyntaxFactory.SeparatedList<TNode>();
	}

	public static SeparatedSyntaxList<TNode> SingletonSeparatedList<TNode>(TNode @node) where TNode: SyntaxNode
	{
		return SyntaxFactory.SingletonSeparatedList<TNode>(@node);
	}

	public static SeparatedSyntaxList<TNode> SeparatedList<TNode>(IEnumerable<TNode> @nodes) where TNode: SyntaxNode
	{
		return SyntaxFactory.SeparatedList<TNode>(@nodes);
	}

	public static SeparatedSyntaxList<TNode> SeparatedList<TNode>(IEnumerable<TNode> @nodes, IEnumerable<SyntaxToken> @separators) where TNode: SyntaxNode
	{
		return SyntaxFactory.SeparatedList<TNode>(@nodes, @separators);
	}

	public static SeparatedSyntaxList<TNode> SeparatedList<TNode>(IEnumerable<SyntaxNodeOrToken> @nodesAndTokens) where TNode: SyntaxNode
	{
		return SyntaxFactory.SeparatedList<TNode>(@nodesAndTokens);
	}

	public static SeparatedSyntaxList<TNode> SeparatedList<TNode>(SyntaxNodeOrTokenList @nodesAndTokens) where TNode: SyntaxNode
	{
		return SyntaxFactory.SeparatedList<TNode>(@nodesAndTokens);
	}

	public static SyntaxNodeOrTokenList NodeOrTokenList()
	{
		return SyntaxFactory.NodeOrTokenList();
	}

	public static SyntaxNodeOrTokenList NodeOrTokenList(IEnumerable<SyntaxNodeOrToken> @nodesAndTokens)
	{
		return SyntaxFactory.NodeOrTokenList(@nodesAndTokens);
	}

	public static SyntaxNodeOrTokenList NodeOrTokenList(SyntaxNodeOrToken[] @nodesAndTokens)
	{
		return SyntaxFactory.NodeOrTokenList(@nodesAndTokens);
	}

	public static IdentifierNameSyntax IdentifierName(String @name)
	{
		return SyntaxFactory.IdentifierName(@name);
	}

	public static SyntaxTree SyntaxTree(SyntaxNode @root, ParseOptions @options, String @path, Encoding @encoding)
	{
		return SyntaxFactory.SyntaxTree(@root, @options, @path, @encoding);
	}

	public static SyntaxTree ParseSyntaxTree(String @text, ParseOptions @options, String @path, Encoding @encoding, CancellationToken @cancellationToken)
	{
		return SyntaxFactory.ParseSyntaxTree(@text, @options, @path, @encoding, @cancellationToken);
	}

	public static SyntaxTree ParseSyntaxTree(SourceText @text, ParseOptions @options, String @path, CancellationToken @cancellationToken)
	{
		return SyntaxFactory.ParseSyntaxTree(@text, @options, @path, @cancellationToken);
	}

	public static SyntaxTriviaList ParseLeadingTrivia(String @text, Int32 @offset)
	{
		return SyntaxFactory.ParseLeadingTrivia(@text, @offset);
	}

	public static SyntaxTriviaList ParseTrailingTrivia(String @text, Int32 @offset)
	{
		return SyntaxFactory.ParseTrailingTrivia(@text, @offset);
	}

	public static SyntaxToken ParseToken(String @text, Int32 @offset)
	{
		return SyntaxFactory.ParseToken(@text, @offset);
	}

	public static IEnumerable<SyntaxToken> ParseTokens(String @text, Int32 @offset, Int32 @initialTokenPosition, CSharpParseOptions @options)
	{
		return SyntaxFactory.ParseTokens(@text, @offset, @initialTokenPosition, @options);
	}

	public static NameSyntax ParseName(String @text, Int32 @offset, Boolean @consumeFullText)
	{
		return SyntaxFactory.ParseName(@text, @offset, @consumeFullText);
	}

	public static TypeSyntax ParseTypeName(String @text, Int32 @offset, Boolean @consumeFullText)
	{
		return SyntaxFactory.ParseTypeName(@text, @offset, @consumeFullText);
	}

	public static ExpressionSyntax ParseExpression(String @text, Int32 @offset, ParseOptions @options, Boolean @consumeFullText)
	{
		return SyntaxFactory.ParseExpression(@text, @offset, @options, @consumeFullText);
	}

	public static StatementSyntax ParseStatement(String @text, Int32 @offset, ParseOptions @options, Boolean @consumeFullText)
	{
		return SyntaxFactory.ParseStatement(@text, @offset, @options, @consumeFullText);
	}

	public static CompilationUnitSyntax ParseCompilationUnit(String @text, Int32 @offset, CSharpParseOptions @options)
	{
		return SyntaxFactory.ParseCompilationUnit(@text, @offset, @options);
	}

	public static ParameterListSyntax ParseParameterList(String @text, Int32 @offset, ParseOptions @options, Boolean @consumeFullText)
	{
		return SyntaxFactory.ParseParameterList(@text, @offset, @options, @consumeFullText);
	}

	public static BracketedParameterListSyntax ParseBracketedParameterList(String @text, Int32 @offset, ParseOptions @options, Boolean @consumeFullText)
	{
		return SyntaxFactory.ParseBracketedParameterList(@text, @offset, @options, @consumeFullText);
	}

	public static ArgumentListSyntax ParseArgumentList(String @text, Int32 @offset, ParseOptions @options, Boolean @consumeFullText)
	{
		return SyntaxFactory.ParseArgumentList(@text, @offset, @options, @consumeFullText);
	}

	public static BracketedArgumentListSyntax ParseBracketedArgumentList(String @text, Int32 @offset, ParseOptions @options, Boolean @consumeFullText)
	{
		return SyntaxFactory.ParseBracketedArgumentList(@text, @offset, @options, @consumeFullText);
	}

	public static AttributeArgumentListSyntax ParseAttributeArgumentList(String @text, Int32 @offset, ParseOptions @options, Boolean @consumeFullText)
	{
		return SyntaxFactory.ParseAttributeArgumentList(@text, @offset, @options, @consumeFullText);
	}

	public static Boolean AreEquivalent(SyntaxTree @oldTree, SyntaxTree @newTree, Boolean @topLevel)
	{
		return SyntaxFactory.AreEquivalent(@oldTree, @newTree, @topLevel);
	}

	public static Boolean AreEquivalent(SyntaxNode @oldNode, SyntaxNode @newNode, Boolean @topLevel)
	{
		return SyntaxFactory.AreEquivalent(@oldNode, @newNode, @topLevel);
	}

	public static Boolean AreEquivalent(SyntaxNode @oldNode, SyntaxNode @newNode, Func<SyntaxKind, Boolean> @ignoreChildNode)
	{
		return SyntaxFactory.AreEquivalent(@oldNode, @newNode, @ignoreChildNode);
	}

	public static Boolean AreEquivalent(SyntaxToken @oldToken, SyntaxToken @newToken)
	{
		return SyntaxFactory.AreEquivalent(@oldToken, @newToken);
	}

	public static Boolean AreEquivalent(SyntaxTokenList @oldList, SyntaxTokenList @newList)
	{
		return SyntaxFactory.AreEquivalent(@oldList, @newList);
	}

	public static Boolean AreEquivalent<TNode>(SyntaxList<TNode> @oldList, SyntaxList<TNode> @newList, Boolean @topLevel) where TNode: CSharpSyntaxNode
	{
		return SyntaxFactory.AreEquivalent<TNode>(@oldList, @newList, @topLevel);
	}

	public static Boolean AreEquivalent<TNode>(SyntaxList<TNode> @oldList, SyntaxList<TNode> @newList, Func<SyntaxKind, Boolean> @ignoreChildNode) where TNode: SyntaxNode
	{
		return SyntaxFactory.AreEquivalent<TNode>(@oldList, @newList, @ignoreChildNode);
	}

	public static SyntaxTrivia Space { get; } = SyntaxFactory.Space;

	public static SyntaxTrivia Tab { get; } = SyntaxFactory.Tab;

	public static SyntaxTrivia ElasticCarriageReturnLineFeed { get; } = SyntaxFactory.ElasticCarriageReturnLineFeed;

	public static SyntaxTrivia ElasticLineFeed { get; } = SyntaxFactory.ElasticLineFeed;

	public static SyntaxTrivia ElasticCarriageReturn { get; } = SyntaxFactory.ElasticCarriageReturn;

	public static SyntaxTrivia ElasticSpace { get; } = SyntaxFactory.ElasticSpace;

	public static SyntaxTrivia ElasticTab { get; } = SyntaxFactory.ElasticTab;

	public static SyntaxTrivia ElasticMarker { get; } = SyntaxFactory.ElasticMarker;

	public static SyntaxTrivia EndOfLine(String @text)
	{
		return SyntaxFactory.EndOfLine(@text);
	}

	public static SyntaxTrivia ElasticEndOfLine(String @text)
	{
		return SyntaxFactory.ElasticEndOfLine(@text);
	}

	public static SyntaxTrivia ElasticWhitespace(String @text)
	{
		return SyntaxFactory.ElasticWhitespace(@text);
	}

	public static SyntaxTrivia Comment(String @text)
	{
		return SyntaxFactory.Comment(@text);
	}

	public static SyntaxTrivia DisabledText(String @text)
	{
		return SyntaxFactory.DisabledText(@text);
	}

	public static SyntaxTrivia PreprocessingMessage(String @text)
	{
		return SyntaxFactory.PreprocessingMessage(@text);
	}

	public static SyntaxTrivia SyntaxTrivia(SyntaxKind @kind, String @text)
	{
		return SyntaxFactory.SyntaxTrivia(@kind, @text);
	}

	public static SyntaxToken Token(SyntaxKind @kind)
	{
		return SyntaxFactory.Token(@kind);
	}

	public static SyntaxToken Token(SyntaxTriviaList @leading, SyntaxKind @kind, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.Token(@leading, @kind, @trailing);
	}

	public static SyntaxToken Token(SyntaxTriviaList @leading, SyntaxKind @kind, String @text, String @valueText, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.Token(@leading, @kind, @text, @valueText, @trailing);
	}

	public static SyntaxToken MissingToken(SyntaxKind @kind)
	{
		return SyntaxFactory.MissingToken(@kind);
	}

	public static SyntaxToken MissingToken(SyntaxTriviaList @leading, SyntaxKind @kind, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.MissingToken(@leading, @kind, @trailing);
	}

	public static SyntaxToken Identifier(String @text)
	{
		return SyntaxFactory.Identifier(@text);
	}

	public static SyntaxToken Identifier(SyntaxTriviaList @leading, String @text, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.Identifier(@leading, @text, @trailing);
	}

	public static SyntaxToken VerbatimIdentifier(SyntaxTriviaList @leading, String @text, String @valueText, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.VerbatimIdentifier(@leading, @text, @valueText, @trailing);
	}

	public static SyntaxToken Identifier(SyntaxTriviaList @leading, SyntaxKind @contextualKind, String @text, String @valueText, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.Identifier(@leading, @contextualKind, @text, @valueText, @trailing);
	}

	public static SyntaxToken Literal(Int32 @value)
	{
		return SyntaxFactory.Literal(@value);
	}

	public static SyntaxToken Literal(String @text, Int32 @value)
	{
		return SyntaxFactory.Literal(@text, @value);
	}

	public static SyntaxToken Literal(SyntaxTriviaList @leading, String @text, Int32 @value, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.Literal(@leading, @text, @value, @trailing);
	}

	public static SyntaxToken Literal(UInt32 @value)
	{
		return SyntaxFactory.Literal(@value);
	}

	public static SyntaxToken Literal(String @text, UInt32 @value)
	{
		return SyntaxFactory.Literal(@text, @value);
	}

	public static SyntaxToken Literal(SyntaxTriviaList @leading, String @text, UInt32 @value, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.Literal(@leading, @text, @value, @trailing);
	}

	public static SyntaxToken Literal(Int64 @value)
	{
		return SyntaxFactory.Literal(@value);
	}

	public static SyntaxToken Literal(String @text, Int64 @value)
	{
		return SyntaxFactory.Literal(@text, @value);
	}

	public static SyntaxToken Literal(SyntaxTriviaList @leading, String @text, Int64 @value, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.Literal(@leading, @text, @value, @trailing);
	}

	public static SyntaxToken Literal(UInt64 @value)
	{
		return SyntaxFactory.Literal(@value);
	}

	public static SyntaxToken Literal(String @text, UInt64 @value)
	{
		return SyntaxFactory.Literal(@text, @value);
	}

	public static SyntaxToken Literal(SyntaxTriviaList @leading, String @text, UInt64 @value, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.Literal(@leading, @text, @value, @trailing);
	}

	public static SyntaxToken Literal(Single @value)
	{
		return SyntaxFactory.Literal(@value);
	}

	public static SyntaxToken Literal(String @text, Single @value)
	{
		return SyntaxFactory.Literal(@text, @value);
	}

	public static SyntaxToken Literal(SyntaxTriviaList @leading, String @text, Single @value, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.Literal(@leading, @text, @value, @trailing);
	}

	public static SyntaxToken Literal(Double @value)
	{
		return SyntaxFactory.Literal(@value);
	}

	public static SyntaxToken Literal(String @text, Double @value)
	{
		return SyntaxFactory.Literal(@text, @value);
	}

	public static SyntaxToken Literal(SyntaxTriviaList @leading, String @text, Double @value, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.Literal(@leading, @text, @value, @trailing);
	}

	public static SyntaxToken Literal(Decimal @value)
	{
		return SyntaxFactory.Literal(@value);
	}

	public static SyntaxToken Literal(String @text, Decimal @value)
	{
		return SyntaxFactory.Literal(@text, @value);
	}

	public static SyntaxToken Literal(SyntaxTriviaList @leading, String @text, Decimal @value, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.Literal(@leading, @text, @value, @trailing);
	}

	public static SyntaxToken Literal(String @value)
	{
		return SyntaxFactory.Literal(@value);
	}

	public static SyntaxToken Literal(String @text, String @value)
	{
		return SyntaxFactory.Literal(@text, @value);
	}

	public static SyntaxToken Literal(SyntaxTriviaList @leading, String @text, String @value, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.Literal(@leading, @text, @value, @trailing);
	}

	public static SyntaxToken Literal(Char @value)
	{
		return SyntaxFactory.Literal(@value);
	}

	public static SyntaxToken Literal(String @text, Char @value)
	{
		return SyntaxFactory.Literal(@text, @value);
	}

	public static SyntaxToken Literal(SyntaxTriviaList @leading, String @text, Char @value, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.Literal(@leading, @text, @value, @trailing);
	}

	public static SyntaxToken BadToken(SyntaxTriviaList @leading, String @text, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.BadToken(@leading, @text, @trailing);
	}

	public static SyntaxToken XmlTextLiteral(SyntaxTriviaList @leading, String @text, String @value, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.XmlTextLiteral(@leading, @text, @value, @trailing);
	}

	public static SyntaxToken XmlEntity(SyntaxTriviaList @leading, String @text, String @value, SyntaxTriviaList @trailing)
	{
		return SyntaxFactory.XmlEntity(@leading, @text, @value, @trailing);
	}

	public static DocumentationCommentTriviaSyntax DocumentationComment(XmlNodeSyntax[] @content)
	{
		return SyntaxFactory.DocumentationComment(@content);
	}

	public static XmlElementSyntax XmlSummaryElement(XmlNodeSyntax[] @content)
	{
		return SyntaxFactory.XmlSummaryElement(@content);
	}

	public static XmlElementSyntax XmlSummaryElement(SyntaxList<XmlNodeSyntax> @content)
	{
		return SyntaxFactory.XmlSummaryElement(@content);
	}

	public static XmlEmptyElementSyntax XmlSeeElement(CrefSyntax @cref)
	{
		return SyntaxFactory.XmlSeeElement(@cref);
	}

	public static XmlEmptyElementSyntax XmlSeeAlsoElement(CrefSyntax @cref)
	{
		return SyntaxFactory.XmlSeeAlsoElement(@cref);
	}

	public static XmlElementSyntax XmlSeeAlsoElement(Uri @linkAddress, SyntaxList<XmlNodeSyntax> @linkText)
	{
		return SyntaxFactory.XmlSeeAlsoElement(@linkAddress, @linkText);
	}

	public static XmlEmptyElementSyntax XmlThreadSafetyElement()
	{
		return SyntaxFactory.XmlThreadSafetyElement();
	}

	public static XmlEmptyElementSyntax XmlThreadSafetyElement(Boolean @isStatic, Boolean @isInstance)
	{
		return SyntaxFactory.XmlThreadSafetyElement(@isStatic, @isInstance);
	}

	public static XmlNameAttributeSyntax XmlNameAttribute(String @parameterName)
	{
		return SyntaxFactory.XmlNameAttribute(@parameterName);
	}

	public static XmlEmptyElementSyntax XmlPreliminaryElement()
	{
		return SyntaxFactory.XmlPreliminaryElement();
	}

	public static XmlCrefAttributeSyntax XmlCrefAttribute(CrefSyntax @cref)
	{
		return SyntaxFactory.XmlCrefAttribute(@cref);
	}

	public static XmlCrefAttributeSyntax XmlCrefAttribute(CrefSyntax @cref, SyntaxKind @quoteKind)
	{
		return SyntaxFactory.XmlCrefAttribute(@cref, @quoteKind);
	}

	public static XmlElementSyntax XmlRemarksElement(XmlNodeSyntax[] @content)
	{
		return SyntaxFactory.XmlRemarksElement(@content);
	}

	public static XmlElementSyntax XmlRemarksElement(SyntaxList<XmlNodeSyntax> @content)
	{
		return SyntaxFactory.XmlRemarksElement(@content);
	}

	public static XmlElementSyntax XmlReturnsElement(XmlNodeSyntax[] @content)
	{
		return SyntaxFactory.XmlReturnsElement(@content);
	}

	public static XmlElementSyntax XmlReturnsElement(SyntaxList<XmlNodeSyntax> @content)
	{
		return SyntaxFactory.XmlReturnsElement(@content);
	}

	public static XmlElementSyntax XmlValueElement(XmlNodeSyntax[] @content)
	{
		return SyntaxFactory.XmlValueElement(@content);
	}

	public static XmlElementSyntax XmlValueElement(SyntaxList<XmlNodeSyntax> @content)
	{
		return SyntaxFactory.XmlValueElement(@content);
	}

	public static XmlElementSyntax XmlExceptionElement(CrefSyntax @cref, XmlNodeSyntax[] @content)
	{
		return SyntaxFactory.XmlExceptionElement(@cref, @content);
	}

	public static XmlElementSyntax XmlExceptionElement(CrefSyntax @cref, SyntaxList<XmlNodeSyntax> @content)
	{
		return SyntaxFactory.XmlExceptionElement(@cref, @content);
	}

	public static XmlElementSyntax XmlPermissionElement(CrefSyntax @cref, XmlNodeSyntax[] @content)
	{
		return SyntaxFactory.XmlPermissionElement(@cref, @content);
	}

	public static XmlElementSyntax XmlPermissionElement(CrefSyntax @cref, SyntaxList<XmlNodeSyntax> @content)
	{
		return SyntaxFactory.XmlPermissionElement(@cref, @content);
	}

	public static XmlElementSyntax XmlExampleElement(XmlNodeSyntax[] @content)
	{
		return SyntaxFactory.XmlExampleElement(@content);
	}

	public static XmlElementSyntax XmlExampleElement(SyntaxList<XmlNodeSyntax> @content)
	{
		return SyntaxFactory.XmlExampleElement(@content);
	}

	public static XmlElementSyntax XmlParaElement(XmlNodeSyntax[] @content)
	{
		return SyntaxFactory.XmlParaElement(@content);
	}

	public static XmlElementSyntax XmlParaElement(SyntaxList<XmlNodeSyntax> @content)
	{
		return SyntaxFactory.XmlParaElement(@content);
	}

	public static XmlElementSyntax XmlParamElement(String @parameterName, XmlNodeSyntax[] @content)
	{
		return SyntaxFactory.XmlParamElement(@parameterName, @content);
	}

	public static XmlElementSyntax XmlParamElement(String @parameterName, SyntaxList<XmlNodeSyntax> @content)
	{
		return SyntaxFactory.XmlParamElement(@parameterName, @content);
	}

	public static XmlElementStartTagSyntax XmlElementStartTag(XmlNameSyntax @name, SyntaxList<XmlAttributeSyntax> @attributes)
	{
		return SyntaxFactory.XmlElementStartTag(@name, @attributes);
	}

	public static XmlElementStartTagSyntax XmlElementStartTag(XmlNameSyntax @name)
	{
		return SyntaxFactory.XmlElementStartTag(@name);
	}

	public static XmlElementEndTagSyntax XmlElementEndTag(SyntaxToken @lessThanSlashToken, XmlNameSyntax @name, SyntaxToken @greaterThanToken)
	{
		return SyntaxFactory.XmlElementEndTag(@lessThanSlashToken, @name, @greaterThanToken);
	}

	public static XmlElementEndTagSyntax XmlElementEndTag(XmlNameSyntax @name)
	{
		return SyntaxFactory.XmlElementEndTag(@name);
	}

	public static XmlEmptyElementSyntax XmlEmptyElement(SyntaxToken @lessThanToken, XmlNameSyntax @name, SyntaxList<XmlAttributeSyntax> @attributes, SyntaxToken @slashGreaterThanToken)
	{
		return SyntaxFactory.XmlEmptyElement(@lessThanToken, @name, @attributes, @slashGreaterThanToken);
	}

	public static XmlEmptyElementSyntax XmlEmptyElement(XmlNameSyntax @name, SyntaxList<XmlAttributeSyntax> @attributes)
	{
		return SyntaxFactory.XmlEmptyElement(@name, @attributes);
	}

	public static XmlEmptyElementSyntax XmlEmptyElement(XmlNameSyntax @name)
	{
		return SyntaxFactory.XmlEmptyElement(@name);
	}

	public static XmlNameSyntax XmlName(XmlPrefixSyntax @prefix, SyntaxToken @localName)
	{
		return SyntaxFactory.XmlName(@prefix, @localName);
	}

	public static XmlNameSyntax XmlName(SyntaxToken @localName)
	{
		return SyntaxFactory.XmlName(@localName);
	}

	public static XmlNameSyntax XmlName(String @localName)
	{
		return SyntaxFactory.XmlName(@localName);
	}

	public static XmlPrefixSyntax XmlPrefix(SyntaxToken @prefix, SyntaxToken @colonToken)
	{
		return SyntaxFactory.XmlPrefix(@prefix, @colonToken);
	}

	public static XmlPrefixSyntax XmlPrefix(SyntaxToken @prefix)
	{
		return SyntaxFactory.XmlPrefix(@prefix);
	}

	public static XmlPrefixSyntax XmlPrefix(String @prefix)
	{
		return SyntaxFactory.XmlPrefix(@prefix);
	}

	public static XmlTextAttributeSyntax XmlTextAttribute(XmlNameSyntax @name, SyntaxToken @equalsToken, SyntaxToken @startQuoteToken, SyntaxTokenList @textTokens, SyntaxToken @endQuoteToken)
	{
		return SyntaxFactory.XmlTextAttribute(@name, @equalsToken, @startQuoteToken, @textTokens, @endQuoteToken);
	}

	public static XmlTextAttributeSyntax XmlTextAttribute(XmlNameSyntax @name, SyntaxToken @startQuoteToken, SyntaxTokenList @textTokens, SyntaxToken @endQuoteToken)
	{
		return SyntaxFactory.XmlTextAttribute(@name, @startQuoteToken, @textTokens, @endQuoteToken);
	}

	public static XmlTextAttributeSyntax XmlTextAttribute(XmlNameSyntax @name, SyntaxToken @startQuoteToken, SyntaxToken @endQuoteToken)
	{
		return SyntaxFactory.XmlTextAttribute(@name, @startQuoteToken, @endQuoteToken);
	}

	public static XmlCrefAttributeSyntax XmlCrefAttribute(XmlNameSyntax @name, SyntaxToken @equalsToken, SyntaxToken @startQuoteToken, CrefSyntax @cref, SyntaxToken @endQuoteToken)
	{
		return SyntaxFactory.XmlCrefAttribute(@name, @equalsToken, @startQuoteToken, @cref, @endQuoteToken);
	}

	public static XmlCrefAttributeSyntax XmlCrefAttribute(XmlNameSyntax @name, SyntaxToken @startQuoteToken, CrefSyntax @cref, SyntaxToken @endQuoteToken)
	{
		return SyntaxFactory.XmlCrefAttribute(@name, @startQuoteToken, @cref, @endQuoteToken);
	}

	public static XmlNameAttributeSyntax XmlNameAttribute(XmlNameSyntax @name, SyntaxToken @equalsToken, SyntaxToken @startQuoteToken, IdentifierNameSyntax @identifier, SyntaxToken @endQuoteToken)
	{
		return SyntaxFactory.XmlNameAttribute(@name, @equalsToken, @startQuoteToken, @identifier, @endQuoteToken);
	}

	public static XmlNameAttributeSyntax XmlNameAttribute(XmlNameSyntax @name, SyntaxToken @startQuoteToken, IdentifierNameSyntax @identifier, SyntaxToken @endQuoteToken)
	{
		return SyntaxFactory.XmlNameAttribute(@name, @startQuoteToken, @identifier, @endQuoteToken);
	}

	public static XmlNameAttributeSyntax XmlNameAttribute(XmlNameSyntax @name, SyntaxToken @startQuoteToken, String @identifier, SyntaxToken @endQuoteToken)
	{
		return SyntaxFactory.XmlNameAttribute(@name, @startQuoteToken, @identifier, @endQuoteToken);
	}

	public static XmlTextSyntax XmlText(SyntaxTokenList @textTokens)
	{
		return SyntaxFactory.XmlText(@textTokens);
	}

	public static XmlTextSyntax XmlText()
	{
		return SyntaxFactory.XmlText();
	}

	public static XmlCDataSectionSyntax XmlCDataSection(SyntaxToken @startCDataToken, SyntaxTokenList @textTokens, SyntaxToken @endCDataToken)
	{
		return SyntaxFactory.XmlCDataSection(@startCDataToken, @textTokens, @endCDataToken);
	}

	public static XmlCDataSectionSyntax XmlCDataSection(SyntaxTokenList @textTokens)
	{
		return SyntaxFactory.XmlCDataSection(@textTokens);
	}

	public static XmlProcessingInstructionSyntax XmlProcessingInstruction(SyntaxToken @startProcessingInstructionToken, XmlNameSyntax @name, SyntaxTokenList @textTokens, SyntaxToken @endProcessingInstructionToken)
	{
		return SyntaxFactory.XmlProcessingInstruction(@startProcessingInstructionToken, @name, @textTokens, @endProcessingInstructionToken);
	}

	public static XmlProcessingInstructionSyntax XmlProcessingInstruction(XmlNameSyntax @name, SyntaxTokenList @textTokens)
	{
		return SyntaxFactory.XmlProcessingInstruction(@name, @textTokens);
	}

	public static XmlProcessingInstructionSyntax XmlProcessingInstruction(XmlNameSyntax @name)
	{
		return SyntaxFactory.XmlProcessingInstruction(@name);
	}

	public static XmlCommentSyntax XmlComment(SyntaxToken @lessThanExclamationMinusMinusToken, SyntaxTokenList @textTokens, SyntaxToken @minusMinusGreaterThanToken)
	{
		return SyntaxFactory.XmlComment(@lessThanExclamationMinusMinusToken, @textTokens, @minusMinusGreaterThanToken);
	}

	public static XmlCommentSyntax XmlComment(SyntaxTokenList @textTokens)
	{
		return SyntaxFactory.XmlComment(@textTokens);
	}

	public static IfDirectiveTriviaSyntax IfDirectiveTrivia(SyntaxToken @hashToken, SyntaxToken @ifKeyword, ExpressionSyntax @condition, SyntaxToken @endOfDirectiveToken, Boolean @isActive, Boolean @branchTaken, Boolean @conditionValue)
	{
		return SyntaxFactory.IfDirectiveTrivia(@hashToken, @ifKeyword, @condition, @endOfDirectiveToken, @isActive, @branchTaken, @conditionValue);
	}

	public static IfDirectiveTriviaSyntax IfDirectiveTrivia(ExpressionSyntax @condition, Boolean @isActive, Boolean @branchTaken, Boolean @conditionValue)
	{
		return SyntaxFactory.IfDirectiveTrivia(@condition, @isActive, @branchTaken, @conditionValue);
	}

	public static ElifDirectiveTriviaSyntax ElifDirectiveTrivia(SyntaxToken @hashToken, SyntaxToken @elifKeyword, ExpressionSyntax @condition, SyntaxToken @endOfDirectiveToken, Boolean @isActive, Boolean @branchTaken, Boolean @conditionValue)
	{
		return SyntaxFactory.ElifDirectiveTrivia(@hashToken, @elifKeyword, @condition, @endOfDirectiveToken, @isActive, @branchTaken, @conditionValue);
	}

	public static ElifDirectiveTriviaSyntax ElifDirectiveTrivia(ExpressionSyntax @condition, Boolean @isActive, Boolean @branchTaken, Boolean @conditionValue)
	{
		return SyntaxFactory.ElifDirectiveTrivia(@condition, @isActive, @branchTaken, @conditionValue);
	}

	public static ElseDirectiveTriviaSyntax ElseDirectiveTrivia(SyntaxToken @hashToken, SyntaxToken @elseKeyword, SyntaxToken @endOfDirectiveToken, Boolean @isActive, Boolean @branchTaken)
	{
		return SyntaxFactory.ElseDirectiveTrivia(@hashToken, @elseKeyword, @endOfDirectiveToken, @isActive, @branchTaken);
	}

	public static ElseDirectiveTriviaSyntax ElseDirectiveTrivia(Boolean @isActive, Boolean @branchTaken)
	{
		return SyntaxFactory.ElseDirectiveTrivia(@isActive, @branchTaken);
	}

	public static EndIfDirectiveTriviaSyntax EndIfDirectiveTrivia(SyntaxToken @hashToken, SyntaxToken @endIfKeyword, SyntaxToken @endOfDirectiveToken, Boolean @isActive)
	{
		return SyntaxFactory.EndIfDirectiveTrivia(@hashToken, @endIfKeyword, @endOfDirectiveToken, @isActive);
	}

	public static EndIfDirectiveTriviaSyntax EndIfDirectiveTrivia(Boolean @isActive)
	{
		return SyntaxFactory.EndIfDirectiveTrivia(@isActive);
	}

	public static RegionDirectiveTriviaSyntax RegionDirectiveTrivia(SyntaxToken @hashToken, SyntaxToken @regionKeyword, SyntaxToken @endOfDirectiveToken, Boolean @isActive)
	{
		return SyntaxFactory.RegionDirectiveTrivia(@hashToken, @regionKeyword, @endOfDirectiveToken, @isActive);
	}

	public static RegionDirectiveTriviaSyntax RegionDirectiveTrivia(Boolean @isActive)
	{
		return SyntaxFactory.RegionDirectiveTrivia(@isActive);
	}

	public static EndRegionDirectiveTriviaSyntax EndRegionDirectiveTrivia(SyntaxToken @hashToken, SyntaxToken @endRegionKeyword, SyntaxToken @endOfDirectiveToken, Boolean @isActive)
	{
		return SyntaxFactory.EndRegionDirectiveTrivia(@hashToken, @endRegionKeyword, @endOfDirectiveToken, @isActive);
	}

	public static EndRegionDirectiveTriviaSyntax EndRegionDirectiveTrivia(Boolean @isActive)
	{
		return SyntaxFactory.EndRegionDirectiveTrivia(@isActive);
	}

	public static ErrorDirectiveTriviaSyntax ErrorDirectiveTrivia(SyntaxToken @hashToken, SyntaxToken @errorKeyword, SyntaxToken @endOfDirectiveToken, Boolean @isActive)
	{
		return SyntaxFactory.ErrorDirectiveTrivia(@hashToken, @errorKeyword, @endOfDirectiveToken, @isActive);
	}

	public static ErrorDirectiveTriviaSyntax ErrorDirectiveTrivia(Boolean @isActive)
	{
		return SyntaxFactory.ErrorDirectiveTrivia(@isActive);
	}

	public static WarningDirectiveTriviaSyntax WarningDirectiveTrivia(SyntaxToken @hashToken, SyntaxToken @warningKeyword, SyntaxToken @endOfDirectiveToken, Boolean @isActive)
	{
		return SyntaxFactory.WarningDirectiveTrivia(@hashToken, @warningKeyword, @endOfDirectiveToken, @isActive);
	}

	public static WarningDirectiveTriviaSyntax WarningDirectiveTrivia(Boolean @isActive)
	{
		return SyntaxFactory.WarningDirectiveTrivia(@isActive);
	}

	public static BadDirectiveTriviaSyntax BadDirectiveTrivia(SyntaxToken @hashToken, SyntaxToken @identifier, SyntaxToken @endOfDirectiveToken, Boolean @isActive)
	{
		return SyntaxFactory.BadDirectiveTrivia(@hashToken, @identifier, @endOfDirectiveToken, @isActive);
	}

	public static BadDirectiveTriviaSyntax BadDirectiveTrivia(SyntaxToken @identifier, Boolean @isActive)
	{
		return SyntaxFactory.BadDirectiveTrivia(@identifier, @isActive);
	}

	public static DefineDirectiveTriviaSyntax DefineDirectiveTrivia(SyntaxToken @hashToken, SyntaxToken @defineKeyword, SyntaxToken @name, SyntaxToken @endOfDirectiveToken, Boolean @isActive)
	{
		return SyntaxFactory.DefineDirectiveTrivia(@hashToken, @defineKeyword, @name, @endOfDirectiveToken, @isActive);
	}

	public static DefineDirectiveTriviaSyntax DefineDirectiveTrivia(SyntaxToken @name, Boolean @isActive)
	{
		return SyntaxFactory.DefineDirectiveTrivia(@name, @isActive);
	}

	public static DefineDirectiveTriviaSyntax DefineDirectiveTrivia(String @name, Boolean @isActive)
	{
		return SyntaxFactory.DefineDirectiveTrivia(@name, @isActive);
	}

	public static UndefDirectiveTriviaSyntax UndefDirectiveTrivia(SyntaxToken @hashToken, SyntaxToken @undefKeyword, SyntaxToken @name, SyntaxToken @endOfDirectiveToken, Boolean @isActive)
	{
		return SyntaxFactory.UndefDirectiveTrivia(@hashToken, @undefKeyword, @name, @endOfDirectiveToken, @isActive);
	}

	public static UndefDirectiveTriviaSyntax UndefDirectiveTrivia(SyntaxToken @name, Boolean @isActive)
	{
		return SyntaxFactory.UndefDirectiveTrivia(@name, @isActive);
	}

	public static UndefDirectiveTriviaSyntax UndefDirectiveTrivia(String @name, Boolean @isActive)
	{
		return SyntaxFactory.UndefDirectiveTrivia(@name, @isActive);
	}

	public static LineDirectiveTriviaSyntax LineDirectiveTrivia(SyntaxToken @hashToken, SyntaxToken @lineKeyword, SyntaxToken @line, SyntaxToken @file, SyntaxToken @endOfDirectiveToken, Boolean @isActive)
	{
		return SyntaxFactory.LineDirectiveTrivia(@hashToken, @lineKeyword, @line, @file, @endOfDirectiveToken, @isActive);
	}

	public static LineDirectiveTriviaSyntax LineDirectiveTrivia(SyntaxToken @line, SyntaxToken @file, Boolean @isActive)
	{
		return SyntaxFactory.LineDirectiveTrivia(@line, @file, @isActive);
	}

	public static LineDirectiveTriviaSyntax LineDirectiveTrivia(SyntaxToken @line, Boolean @isActive)
	{
		return SyntaxFactory.LineDirectiveTrivia(@line, @isActive);
	}

	public static PragmaWarningDirectiveTriviaSyntax PragmaWarningDirectiveTrivia(SyntaxToken @hashToken, SyntaxToken @pragmaKeyword, SyntaxToken @warningKeyword, SyntaxToken @disableOrRestoreKeyword, SeparatedSyntaxList<ExpressionSyntax> @errorCodes, SyntaxToken @endOfDirectiveToken, Boolean @isActive)
	{
		return SyntaxFactory.PragmaWarningDirectiveTrivia(@hashToken, @pragmaKeyword, @warningKeyword, @disableOrRestoreKeyword, @errorCodes, @endOfDirectiveToken, @isActive);
	}

	public static PragmaWarningDirectiveTriviaSyntax PragmaWarningDirectiveTrivia(SyntaxToken @disableOrRestoreKeyword, SeparatedSyntaxList<ExpressionSyntax> @errorCodes, Boolean @isActive)
	{
		return SyntaxFactory.PragmaWarningDirectiveTrivia(@disableOrRestoreKeyword, @errorCodes, @isActive);
	}

	public static PragmaWarningDirectiveTriviaSyntax PragmaWarningDirectiveTrivia(SyntaxToken @disableOrRestoreKeyword, Boolean @isActive)
	{
		return SyntaxFactory.PragmaWarningDirectiveTrivia(@disableOrRestoreKeyword, @isActive);
	}

	public static PragmaChecksumDirectiveTriviaSyntax PragmaChecksumDirectiveTrivia(SyntaxToken @hashToken, SyntaxToken @pragmaKeyword, SyntaxToken @checksumKeyword, SyntaxToken @file, SyntaxToken @guid, SyntaxToken @bytes, SyntaxToken @endOfDirectiveToken, Boolean @isActive)
	{
		return SyntaxFactory.PragmaChecksumDirectiveTrivia(@hashToken, @pragmaKeyword, @checksumKeyword, @file, @guid, @bytes, @endOfDirectiveToken, @isActive);
	}

	public static PragmaChecksumDirectiveTriviaSyntax PragmaChecksumDirectiveTrivia(SyntaxToken @file, SyntaxToken @guid, SyntaxToken @bytes, Boolean @isActive)
	{
		return SyntaxFactory.PragmaChecksumDirectiveTrivia(@file, @guid, @bytes, @isActive);
	}

	public static ReferenceDirectiveTriviaSyntax ReferenceDirectiveTrivia(SyntaxToken @hashToken, SyntaxToken @referenceKeyword, SyntaxToken @file, SyntaxToken @endOfDirectiveToken, Boolean @isActive)
	{
		return SyntaxFactory.ReferenceDirectiveTrivia(@hashToken, @referenceKeyword, @file, @endOfDirectiveToken, @isActive);
	}

	public static ReferenceDirectiveTriviaSyntax ReferenceDirectiveTrivia(SyntaxToken @file, Boolean @isActive)
	{
		return SyntaxFactory.ReferenceDirectiveTrivia(@file, @isActive);
	}

	public static LoadDirectiveTriviaSyntax LoadDirectiveTrivia(SyntaxToken @hashToken, SyntaxToken @loadKeyword, SyntaxToken @file, SyntaxToken @endOfDirectiveToken, Boolean @isActive)
	{
		return SyntaxFactory.LoadDirectiveTrivia(@hashToken, @loadKeyword, @file, @endOfDirectiveToken, @isActive);
	}

	public static LoadDirectiveTriviaSyntax LoadDirectiveTrivia(SyntaxToken @file, Boolean @isActive)
	{
		return SyntaxFactory.LoadDirectiveTrivia(@file, @isActive);
	}

	public static ShebangDirectiveTriviaSyntax ShebangDirectiveTrivia(SyntaxToken @hashToken, SyntaxToken @exclamationToken, SyntaxToken @endOfDirectiveToken, Boolean @isActive)
	{
		return SyntaxFactory.ShebangDirectiveTrivia(@hashToken, @exclamationToken, @endOfDirectiveToken, @isActive);
	}

	public static ShebangDirectiveTriviaSyntax ShebangDirectiveTrivia(Boolean @isActive)
	{
		return SyntaxFactory.ShebangDirectiveTrivia(@isActive);
	}

	public static AnonymousMethodExpressionSyntax AnonymousMethodExpression()
	{
		return SyntaxFactory.AnonymousMethodExpression();
	}

	public static ConstructorDeclarationSyntax ConstructorDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @identifier, ParameterListSyntax @parameterList, ConstructorInitializerSyntax @initializer, BlockSyntax @body)
	{
		return SyntaxFactory.ConstructorDeclaration(@attributeLists, @modifiers, @identifier, @parameterList, @initializer, @body);
	}

	public static ConstructorDeclarationSyntax ConstructorDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @identifier, ParameterListSyntax @parameterList, ConstructorInitializerSyntax @initializer, BlockSyntax @body, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.ConstructorDeclaration(@attributeLists, @modifiers, @identifier, @parameterList, @initializer, @body, @semicolonToken);
	}

	public static ConstructorDeclarationSyntax ConstructorDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @identifier, ParameterListSyntax @parameterList, ConstructorInitializerSyntax @initializer, ArrowExpressionClauseSyntax @expressionBody)
	{
		return SyntaxFactory.ConstructorDeclaration(@attributeLists, @modifiers, @identifier, @parameterList, @initializer, @expressionBody);
	}

	public static ConstructorDeclarationSyntax ConstructorDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @identifier, ParameterListSyntax @parameterList, ConstructorInitializerSyntax @initializer, ArrowExpressionClauseSyntax @expressionBody, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.ConstructorDeclaration(@attributeLists, @modifiers, @identifier, @parameterList, @initializer, @expressionBody, @semicolonToken);
	}

	public static DestructorDeclarationSyntax DestructorDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @identifier, ParameterListSyntax @parameterList, BlockSyntax @body)
	{
		return SyntaxFactory.DestructorDeclaration(@attributeLists, @modifiers, @identifier, @parameterList, @body);
	}

	public static DestructorDeclarationSyntax DestructorDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @tildeToken, SyntaxToken @identifier, ParameterListSyntax @parameterList, BlockSyntax @body, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.DestructorDeclaration(@attributeLists, @modifiers, @tildeToken, @identifier, @parameterList, @body, @semicolonToken);
	}

	public static DestructorDeclarationSyntax DestructorDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @identifier, ParameterListSyntax @parameterList, ArrowExpressionClauseSyntax @expressionBody)
	{
		return SyntaxFactory.DestructorDeclaration(@attributeLists, @modifiers, @identifier, @parameterList, @expressionBody);
	}

	public static DestructorDeclarationSyntax DestructorDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @tildeToken, SyntaxToken @identifier, ParameterListSyntax @parameterList, ArrowExpressionClauseSyntax @expressionBody, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.DestructorDeclaration(@attributeLists, @modifiers, @tildeToken, @identifier, @parameterList, @expressionBody, @semicolonToken);
	}

	public static IndexerDeclarationSyntax IndexerDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, TypeSyntax @type, ExplicitInterfaceSpecifierSyntax @explicitInterfaceSpecifier, BracketedParameterListSyntax @parameterList, AccessorListSyntax @accessorList)
	{
		return SyntaxFactory.IndexerDeclaration(@attributeLists, @modifiers, @type, @explicitInterfaceSpecifier, @parameterList, @accessorList);
	}

	public static MethodDeclarationSyntax MethodDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, TypeSyntax @returnType, ExplicitInterfaceSpecifierSyntax @explicitInterfaceSpecifier, SyntaxToken @identifier, TypeParameterListSyntax @typeParameterList, ParameterListSyntax @parameterList, SyntaxList<TypeParameterConstraintClauseSyntax> @constraintClauses, BlockSyntax @body, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.MethodDeclaration(@attributeLists, @modifiers, @returnType, @explicitInterfaceSpecifier, @identifier, @typeParameterList, @parameterList, @constraintClauses, @body, @semicolonToken);
	}

	public static AccessorDeclarationSyntax AccessorDeclaration(SyntaxKind @kind, BlockSyntax @body)
	{
		return SyntaxFactory.AccessorDeclaration(@kind, @body);
	}

	public static RefTypeSyntax RefType(SyntaxToken @refKeyword, TypeSyntax @type)
	{
		return SyntaxFactory.RefType(@refKeyword, @type);
	}

	public static StackAllocArrayCreationExpressionSyntax StackAllocArrayCreationExpression(SyntaxToken @stackAllocKeyword, TypeSyntax @type)
	{
		return SyntaxFactory.StackAllocArrayCreationExpression(@stackAllocKeyword, @type);
	}

	public static SyntaxTrivia CarriageReturnLineFeed { get; } = SyntaxFactory.CarriageReturnLineFeed;

	public static SyntaxTrivia LineFeed { get; } = SyntaxFactory.LineFeed;

	public static SyntaxTrivia CarriageReturn { get; } = SyntaxFactory.CarriageReturn;

	public static ClassOrStructConstraintSyntax ClassOrStructConstraint(SyntaxKind @kind)
	{
		return SyntaxFactory.ClassOrStructConstraint(@kind);
	}

	public static TypeConstraintSyntax TypeConstraint(TypeSyntax @type)
	{
		return SyntaxFactory.TypeConstraint(@type);
	}

	public static FieldDeclarationSyntax FieldDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, VariableDeclarationSyntax @declaration, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.FieldDeclaration(@attributeLists, @modifiers, @declaration, @semicolonToken);
	}

	public static FieldDeclarationSyntax FieldDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, VariableDeclarationSyntax @declaration)
	{
		return SyntaxFactory.FieldDeclaration(@attributeLists, @modifiers, @declaration);
	}

	public static FieldDeclarationSyntax FieldDeclaration(VariableDeclarationSyntax @declaration)
	{
		return SyntaxFactory.FieldDeclaration(@declaration);
	}

	public static EventFieldDeclarationSyntax EventFieldDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @eventKeyword, VariableDeclarationSyntax @declaration, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.EventFieldDeclaration(@attributeLists, @modifiers, @eventKeyword, @declaration, @semicolonToken);
	}

	public static EventFieldDeclarationSyntax EventFieldDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, VariableDeclarationSyntax @declaration)
	{
		return SyntaxFactory.EventFieldDeclaration(@attributeLists, @modifiers, @declaration);
	}

	public static EventFieldDeclarationSyntax EventFieldDeclaration(VariableDeclarationSyntax @declaration)
	{
		return SyntaxFactory.EventFieldDeclaration(@declaration);
	}

	public static ExplicitInterfaceSpecifierSyntax ExplicitInterfaceSpecifier(NameSyntax @name, SyntaxToken @dotToken)
	{
		return SyntaxFactory.ExplicitInterfaceSpecifier(@name, @dotToken);
	}

	public static ExplicitInterfaceSpecifierSyntax ExplicitInterfaceSpecifier(NameSyntax @name)
	{
		return SyntaxFactory.ExplicitInterfaceSpecifier(@name);
	}

	public static MethodDeclarationSyntax MethodDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, TypeSyntax @returnType, ExplicitInterfaceSpecifierSyntax @explicitInterfaceSpecifier, SyntaxToken @identifier, TypeParameterListSyntax @typeParameterList, ParameterListSyntax @parameterList, SyntaxList<TypeParameterConstraintClauseSyntax> @constraintClauses, BlockSyntax @body, ArrowExpressionClauseSyntax @expressionBody, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.MethodDeclaration(@attributeLists, @modifiers, @returnType, @explicitInterfaceSpecifier, @identifier, @typeParameterList, @parameterList, @constraintClauses, @body, @expressionBody, @semicolonToken);
	}

	public static MethodDeclarationSyntax MethodDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, TypeSyntax @returnType, ExplicitInterfaceSpecifierSyntax @explicitInterfaceSpecifier, SyntaxToken @identifier, TypeParameterListSyntax @typeParameterList, ParameterListSyntax @parameterList, SyntaxList<TypeParameterConstraintClauseSyntax> @constraintClauses, BlockSyntax @body, ArrowExpressionClauseSyntax @expressionBody)
	{
		return SyntaxFactory.MethodDeclaration(@attributeLists, @modifiers, @returnType, @explicitInterfaceSpecifier, @identifier, @typeParameterList, @parameterList, @constraintClauses, @body, @expressionBody);
	}

	public static MethodDeclarationSyntax MethodDeclaration(TypeSyntax @returnType, SyntaxToken @identifier)
	{
		return SyntaxFactory.MethodDeclaration(@returnType, @identifier);
	}

	public static MethodDeclarationSyntax MethodDeclaration(TypeSyntax @returnType, String @identifier)
	{
		return SyntaxFactory.MethodDeclaration(@returnType, @identifier);
	}

	public static OperatorDeclarationSyntax OperatorDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, TypeSyntax @returnType, SyntaxToken @operatorKeyword, SyntaxToken @operatorToken, ParameterListSyntax @parameterList, BlockSyntax @body, ArrowExpressionClauseSyntax @expressionBody, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.OperatorDeclaration(@attributeLists, @modifiers, @returnType, @operatorKeyword, @operatorToken, @parameterList, @body, @expressionBody, @semicolonToken);
	}

	public static OperatorDeclarationSyntax OperatorDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, TypeSyntax @returnType, SyntaxToken @operatorToken, ParameterListSyntax @parameterList, BlockSyntax @body, ArrowExpressionClauseSyntax @expressionBody)
	{
		return SyntaxFactory.OperatorDeclaration(@attributeLists, @modifiers, @returnType, @operatorToken, @parameterList, @body, @expressionBody);
	}

	public static OperatorDeclarationSyntax OperatorDeclaration(TypeSyntax @returnType, SyntaxToken @operatorToken)
	{
		return SyntaxFactory.OperatorDeclaration(@returnType, @operatorToken);
	}

	public static ConversionOperatorDeclarationSyntax ConversionOperatorDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @implicitOrExplicitKeyword, SyntaxToken @operatorKeyword, TypeSyntax @type, ParameterListSyntax @parameterList, BlockSyntax @body, ArrowExpressionClauseSyntax @expressionBody, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.ConversionOperatorDeclaration(@attributeLists, @modifiers, @implicitOrExplicitKeyword, @operatorKeyword, @type, @parameterList, @body, @expressionBody, @semicolonToken);
	}

	public static ConversionOperatorDeclarationSyntax ConversionOperatorDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @implicitOrExplicitKeyword, TypeSyntax @type, ParameterListSyntax @parameterList, BlockSyntax @body, ArrowExpressionClauseSyntax @expressionBody)
	{
		return SyntaxFactory.ConversionOperatorDeclaration(@attributeLists, @modifiers, @implicitOrExplicitKeyword, @type, @parameterList, @body, @expressionBody);
	}

	public static ConversionOperatorDeclarationSyntax ConversionOperatorDeclaration(SyntaxToken @implicitOrExplicitKeyword, TypeSyntax @type)
	{
		return SyntaxFactory.ConversionOperatorDeclaration(@implicitOrExplicitKeyword, @type);
	}

	public static ConstructorDeclarationSyntax ConstructorDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @identifier, ParameterListSyntax @parameterList, ConstructorInitializerSyntax @initializer, BlockSyntax @body, ArrowExpressionClauseSyntax @expressionBody, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.ConstructorDeclaration(@attributeLists, @modifiers, @identifier, @parameterList, @initializer, @body, @expressionBody, @semicolonToken);
	}

	public static ConstructorDeclarationSyntax ConstructorDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @identifier, ParameterListSyntax @parameterList, ConstructorInitializerSyntax @initializer, BlockSyntax @body, ArrowExpressionClauseSyntax @expressionBody)
	{
		return SyntaxFactory.ConstructorDeclaration(@attributeLists, @modifiers, @identifier, @parameterList, @initializer, @body, @expressionBody);
	}

	public static ConstructorDeclarationSyntax ConstructorDeclaration(SyntaxToken @identifier)
	{
		return SyntaxFactory.ConstructorDeclaration(@identifier);
	}

	public static ConstructorDeclarationSyntax ConstructorDeclaration(String @identifier)
	{
		return SyntaxFactory.ConstructorDeclaration(@identifier);
	}

	public static ConstructorInitializerSyntax ConstructorInitializer(SyntaxKind @kind, SyntaxToken @colonToken, SyntaxToken @thisOrBaseKeyword, ArgumentListSyntax @argumentList)
	{
		return SyntaxFactory.ConstructorInitializer(@kind, @colonToken, @thisOrBaseKeyword, @argumentList);
	}

	public static ConstructorInitializerSyntax ConstructorInitializer(SyntaxKind @kind, ArgumentListSyntax @argumentList)
	{
		return SyntaxFactory.ConstructorInitializer(@kind, @argumentList);
	}

	public static DestructorDeclarationSyntax DestructorDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @tildeToken, SyntaxToken @identifier, ParameterListSyntax @parameterList, BlockSyntax @body, ArrowExpressionClauseSyntax @expressionBody, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.DestructorDeclaration(@attributeLists, @modifiers, @tildeToken, @identifier, @parameterList, @body, @expressionBody, @semicolonToken);
	}

	public static DestructorDeclarationSyntax DestructorDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @identifier, ParameterListSyntax @parameterList, BlockSyntax @body, ArrowExpressionClauseSyntax @expressionBody)
	{
		return SyntaxFactory.DestructorDeclaration(@attributeLists, @modifiers, @identifier, @parameterList, @body, @expressionBody);
	}

	public static DestructorDeclarationSyntax DestructorDeclaration(SyntaxToken @identifier)
	{
		return SyntaxFactory.DestructorDeclaration(@identifier);
	}

	public static DestructorDeclarationSyntax DestructorDeclaration(String @identifier)
	{
		return SyntaxFactory.DestructorDeclaration(@identifier);
	}

	public static PropertyDeclarationSyntax PropertyDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, TypeSyntax @type, ExplicitInterfaceSpecifierSyntax @explicitInterfaceSpecifier, SyntaxToken @identifier, AccessorListSyntax @accessorList, ArrowExpressionClauseSyntax @expressionBody, EqualsValueClauseSyntax @initializer, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.PropertyDeclaration(@attributeLists, @modifiers, @type, @explicitInterfaceSpecifier, @identifier, @accessorList, @expressionBody, @initializer, @semicolonToken);
	}

	public static PropertyDeclarationSyntax PropertyDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, TypeSyntax @type, ExplicitInterfaceSpecifierSyntax @explicitInterfaceSpecifier, SyntaxToken @identifier, AccessorListSyntax @accessorList, ArrowExpressionClauseSyntax @expressionBody, EqualsValueClauseSyntax @initializer)
	{
		return SyntaxFactory.PropertyDeclaration(@attributeLists, @modifiers, @type, @explicitInterfaceSpecifier, @identifier, @accessorList, @expressionBody, @initializer);
	}

	public static PropertyDeclarationSyntax PropertyDeclaration(TypeSyntax @type, SyntaxToken @identifier)
	{
		return SyntaxFactory.PropertyDeclaration(@type, @identifier);
	}

	public static PropertyDeclarationSyntax PropertyDeclaration(TypeSyntax @type, String @identifier)
	{
		return SyntaxFactory.PropertyDeclaration(@type, @identifier);
	}

	public static ArrowExpressionClauseSyntax ArrowExpressionClause(SyntaxToken @arrowToken, ExpressionSyntax @expression)
	{
		return SyntaxFactory.ArrowExpressionClause(@arrowToken, @expression);
	}

	public static ArrowExpressionClauseSyntax ArrowExpressionClause(ExpressionSyntax @expression)
	{
		return SyntaxFactory.ArrowExpressionClause(@expression);
	}

	public static EventDeclarationSyntax EventDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @eventKeyword, TypeSyntax @type, ExplicitInterfaceSpecifierSyntax @explicitInterfaceSpecifier, SyntaxToken @identifier, AccessorListSyntax @accessorList)
	{
		return SyntaxFactory.EventDeclaration(@attributeLists, @modifiers, @eventKeyword, @type, @explicitInterfaceSpecifier, @identifier, @accessorList);
	}

	public static EventDeclarationSyntax EventDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, TypeSyntax @type, ExplicitInterfaceSpecifierSyntax @explicitInterfaceSpecifier, SyntaxToken @identifier, AccessorListSyntax @accessorList)
	{
		return SyntaxFactory.EventDeclaration(@attributeLists, @modifiers, @type, @explicitInterfaceSpecifier, @identifier, @accessorList);
	}

	public static EventDeclarationSyntax EventDeclaration(TypeSyntax @type, SyntaxToken @identifier)
	{
		return SyntaxFactory.EventDeclaration(@type, @identifier);
	}

	public static EventDeclarationSyntax EventDeclaration(TypeSyntax @type, String @identifier)
	{
		return SyntaxFactory.EventDeclaration(@type, @identifier);
	}

	public static IndexerDeclarationSyntax IndexerDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, TypeSyntax @type, ExplicitInterfaceSpecifierSyntax @explicitInterfaceSpecifier, SyntaxToken @thisKeyword, BracketedParameterListSyntax @parameterList, AccessorListSyntax @accessorList, ArrowExpressionClauseSyntax @expressionBody, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.IndexerDeclaration(@attributeLists, @modifiers, @type, @explicitInterfaceSpecifier, @thisKeyword, @parameterList, @accessorList, @expressionBody, @semicolonToken);
	}

	public static IndexerDeclarationSyntax IndexerDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, TypeSyntax @type, ExplicitInterfaceSpecifierSyntax @explicitInterfaceSpecifier, BracketedParameterListSyntax @parameterList, AccessorListSyntax @accessorList, ArrowExpressionClauseSyntax @expressionBody)
	{
		return SyntaxFactory.IndexerDeclaration(@attributeLists, @modifiers, @type, @explicitInterfaceSpecifier, @parameterList, @accessorList, @expressionBody);
	}

	public static IndexerDeclarationSyntax IndexerDeclaration(TypeSyntax @type)
	{
		return SyntaxFactory.IndexerDeclaration(@type);
	}

	public static AccessorListSyntax AccessorList(SyntaxToken @openBraceToken, SyntaxList<AccessorDeclarationSyntax> @accessors, SyntaxToken @closeBraceToken)
	{
		return SyntaxFactory.AccessorList(@openBraceToken, @accessors, @closeBraceToken);
	}

	public static AccessorListSyntax AccessorList(SyntaxList<AccessorDeclarationSyntax> @accessors)
	{
		return SyntaxFactory.AccessorList(@accessors);
	}

	public static AccessorDeclarationSyntax AccessorDeclaration(SyntaxKind @kind, SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @keyword, BlockSyntax @body, ArrowExpressionClauseSyntax @expressionBody, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.AccessorDeclaration(@kind, @attributeLists, @modifiers, @keyword, @body, @expressionBody, @semicolonToken);
	}

	public static AccessorDeclarationSyntax AccessorDeclaration(SyntaxKind @kind, SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, BlockSyntax @body, ArrowExpressionClauseSyntax @expressionBody)
	{
		return SyntaxFactory.AccessorDeclaration(@kind, @attributeLists, @modifiers, @body, @expressionBody);
	}

	public static AccessorDeclarationSyntax AccessorDeclaration(SyntaxKind @kind)
	{
		return SyntaxFactory.AccessorDeclaration(@kind);
	}

	public static ParameterListSyntax ParameterList(SyntaxToken @openParenToken, SeparatedSyntaxList<ParameterSyntax> @parameters, SyntaxToken @closeParenToken)
	{
		return SyntaxFactory.ParameterList(@openParenToken, @parameters, @closeParenToken);
	}

	public static ParameterListSyntax ParameterList(SeparatedSyntaxList<ParameterSyntax> @parameters)
	{
		return SyntaxFactory.ParameterList(@parameters);
	}

	public static BracketedParameterListSyntax BracketedParameterList(SyntaxToken @openBracketToken, SeparatedSyntaxList<ParameterSyntax> @parameters, SyntaxToken @closeBracketToken)
	{
		return SyntaxFactory.BracketedParameterList(@openBracketToken, @parameters, @closeBracketToken);
	}

	public static BracketedParameterListSyntax BracketedParameterList(SeparatedSyntaxList<ParameterSyntax> @parameters)
	{
		return SyntaxFactory.BracketedParameterList(@parameters);
	}

	public static ParameterSyntax Parameter(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, TypeSyntax @type, SyntaxToken @identifier, EqualsValueClauseSyntax @default)
	{
		return SyntaxFactory.Parameter(@attributeLists, @modifiers, @type, @identifier, @default);
	}

	public static ParameterSyntax Parameter(SyntaxToken @identifier)
	{
		return SyntaxFactory.Parameter(@identifier);
	}

	public static IncompleteMemberSyntax IncompleteMember(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, TypeSyntax @type)
	{
		return SyntaxFactory.IncompleteMember(@attributeLists, @modifiers, @type);
	}

	public static IncompleteMemberSyntax IncompleteMember(TypeSyntax @type)
	{
		return SyntaxFactory.IncompleteMember(@type);
	}

	public static SkippedTokensTriviaSyntax SkippedTokensTrivia(SyntaxTokenList @tokens)
	{
		return SyntaxFactory.SkippedTokensTrivia(@tokens);
	}

	public static SkippedTokensTriviaSyntax SkippedTokensTrivia()
	{
		return SyntaxFactory.SkippedTokensTrivia();
	}

	public static DocumentationCommentTriviaSyntax DocumentationCommentTrivia(SyntaxKind @kind, SyntaxList<XmlNodeSyntax> @content, SyntaxToken @endOfComment)
	{
		return SyntaxFactory.DocumentationCommentTrivia(@kind, @content, @endOfComment);
	}

	public static DocumentationCommentTriviaSyntax DocumentationCommentTrivia(SyntaxKind @kind, SyntaxList<XmlNodeSyntax> @content)
	{
		return SyntaxFactory.DocumentationCommentTrivia(@kind, @content);
	}

	public static TypeCrefSyntax TypeCref(TypeSyntax @type)
	{
		return SyntaxFactory.TypeCref(@type);
	}

	public static QualifiedCrefSyntax QualifiedCref(TypeSyntax @container, SyntaxToken @dotToken, MemberCrefSyntax @member)
	{
		return SyntaxFactory.QualifiedCref(@container, @dotToken, @member);
	}

	public static QualifiedCrefSyntax QualifiedCref(TypeSyntax @container, MemberCrefSyntax @member)
	{
		return SyntaxFactory.QualifiedCref(@container, @member);
	}

	public static NameMemberCrefSyntax NameMemberCref(TypeSyntax @name, CrefParameterListSyntax @parameters)
	{
		return SyntaxFactory.NameMemberCref(@name, @parameters);
	}

	public static NameMemberCrefSyntax NameMemberCref(TypeSyntax @name)
	{
		return SyntaxFactory.NameMemberCref(@name);
	}

	public static IndexerMemberCrefSyntax IndexerMemberCref(SyntaxToken @thisKeyword, CrefBracketedParameterListSyntax @parameters)
	{
		return SyntaxFactory.IndexerMemberCref(@thisKeyword, @parameters);
	}

	public static IndexerMemberCrefSyntax IndexerMemberCref(CrefBracketedParameterListSyntax @parameters)
	{
		return SyntaxFactory.IndexerMemberCref(@parameters);
	}

	public static OperatorMemberCrefSyntax OperatorMemberCref(SyntaxToken @operatorKeyword, SyntaxToken @operatorToken, CrefParameterListSyntax @parameters)
	{
		return SyntaxFactory.OperatorMemberCref(@operatorKeyword, @operatorToken, @parameters);
	}

	public static OperatorMemberCrefSyntax OperatorMemberCref(SyntaxToken @operatorToken, CrefParameterListSyntax @parameters)
	{
		return SyntaxFactory.OperatorMemberCref(@operatorToken, @parameters);
	}

	public static OperatorMemberCrefSyntax OperatorMemberCref(SyntaxToken @operatorToken)
	{
		return SyntaxFactory.OperatorMemberCref(@operatorToken);
	}

	public static ConversionOperatorMemberCrefSyntax ConversionOperatorMemberCref(SyntaxToken @implicitOrExplicitKeyword, SyntaxToken @operatorKeyword, TypeSyntax @type, CrefParameterListSyntax @parameters)
	{
		return SyntaxFactory.ConversionOperatorMemberCref(@implicitOrExplicitKeyword, @operatorKeyword, @type, @parameters);
	}

	public static ConversionOperatorMemberCrefSyntax ConversionOperatorMemberCref(SyntaxToken @implicitOrExplicitKeyword, TypeSyntax @type, CrefParameterListSyntax @parameters)
	{
		return SyntaxFactory.ConversionOperatorMemberCref(@implicitOrExplicitKeyword, @type, @parameters);
	}

	public static ConversionOperatorMemberCrefSyntax ConversionOperatorMemberCref(SyntaxToken @implicitOrExplicitKeyword, TypeSyntax @type)
	{
		return SyntaxFactory.ConversionOperatorMemberCref(@implicitOrExplicitKeyword, @type);
	}

	public static CrefParameterListSyntax CrefParameterList(SyntaxToken @openParenToken, SeparatedSyntaxList<CrefParameterSyntax> @parameters, SyntaxToken @closeParenToken)
	{
		return SyntaxFactory.CrefParameterList(@openParenToken, @parameters, @closeParenToken);
	}

	public static CrefParameterListSyntax CrefParameterList(SeparatedSyntaxList<CrefParameterSyntax> @parameters)
	{
		return SyntaxFactory.CrefParameterList(@parameters);
	}

	public static CrefBracketedParameterListSyntax CrefBracketedParameterList(SyntaxToken @openBracketToken, SeparatedSyntaxList<CrefParameterSyntax> @parameters, SyntaxToken @closeBracketToken)
	{
		return SyntaxFactory.CrefBracketedParameterList(@openBracketToken, @parameters, @closeBracketToken);
	}

	public static CrefBracketedParameterListSyntax CrefBracketedParameterList(SeparatedSyntaxList<CrefParameterSyntax> @parameters)
	{
		return SyntaxFactory.CrefBracketedParameterList(@parameters);
	}

	public static CrefParameterSyntax CrefParameter(SyntaxToken @refKindKeyword, TypeSyntax @type)
	{
		return SyntaxFactory.CrefParameter(@refKindKeyword, @type);
	}

	public static CrefParameterSyntax CrefParameter(TypeSyntax @type)
	{
		return SyntaxFactory.CrefParameter(@type);
	}

	public static XmlElementSyntax XmlElement(XmlElementStartTagSyntax @startTag, SyntaxList<XmlNodeSyntax> @content, XmlElementEndTagSyntax @endTag)
	{
		return SyntaxFactory.XmlElement(@startTag, @content, @endTag);
	}

	public static XmlElementSyntax XmlElement(XmlElementStartTagSyntax @startTag, XmlElementEndTagSyntax @endTag)
	{
		return SyntaxFactory.XmlElement(@startTag, @endTag);
	}

	public static XmlElementStartTagSyntax XmlElementStartTag(SyntaxToken @lessThanToken, XmlNameSyntax @name, SyntaxList<XmlAttributeSyntax> @attributes, SyntaxToken @greaterThanToken)
	{
		return SyntaxFactory.XmlElementStartTag(@lessThanToken, @name, @attributes, @greaterThanToken);
	}

	public static SwitchSectionSyntax SwitchSection()
	{
		return SyntaxFactory.SwitchSection();
	}

	public static CasePatternSwitchLabelSyntax CasePatternSwitchLabel(SyntaxToken @keyword, PatternSyntax @pattern, WhenClauseSyntax @whenClause, SyntaxToken @colonToken)
	{
		return SyntaxFactory.CasePatternSwitchLabel(@keyword, @pattern, @whenClause, @colonToken);
	}

	public static CasePatternSwitchLabelSyntax CasePatternSwitchLabel(PatternSyntax @pattern, WhenClauseSyntax @whenClause, SyntaxToken @colonToken)
	{
		return SyntaxFactory.CasePatternSwitchLabel(@pattern, @whenClause, @colonToken);
	}

	public static CasePatternSwitchLabelSyntax CasePatternSwitchLabel(PatternSyntax @pattern, SyntaxToken @colonToken)
	{
		return SyntaxFactory.CasePatternSwitchLabel(@pattern, @colonToken);
	}

	public static CaseSwitchLabelSyntax CaseSwitchLabel(SyntaxToken @keyword, ExpressionSyntax @value, SyntaxToken @colonToken)
	{
		return SyntaxFactory.CaseSwitchLabel(@keyword, @value, @colonToken);
	}

	public static CaseSwitchLabelSyntax CaseSwitchLabel(ExpressionSyntax @value, SyntaxToken @colonToken)
	{
		return SyntaxFactory.CaseSwitchLabel(@value, @colonToken);
	}

	public static DefaultSwitchLabelSyntax DefaultSwitchLabel(SyntaxToken @keyword, SyntaxToken @colonToken)
	{
		return SyntaxFactory.DefaultSwitchLabel(@keyword, @colonToken);
	}

	public static DefaultSwitchLabelSyntax DefaultSwitchLabel(SyntaxToken @colonToken)
	{
		return SyntaxFactory.DefaultSwitchLabel(@colonToken);
	}

	public static TryStatementSyntax TryStatement(SyntaxToken @tryKeyword, BlockSyntax @block, SyntaxList<CatchClauseSyntax> @catches, FinallyClauseSyntax @finally)
	{
		return SyntaxFactory.TryStatement(@tryKeyword, @block, @catches, @finally);
	}

	public static TryStatementSyntax TryStatement(BlockSyntax @block, SyntaxList<CatchClauseSyntax> @catches, FinallyClauseSyntax @finally)
	{
		return SyntaxFactory.TryStatement(@block, @catches, @finally);
	}

	public static TryStatementSyntax TryStatement(SyntaxList<CatchClauseSyntax> @catches)
	{
		return SyntaxFactory.TryStatement(@catches);
	}

	public static CatchClauseSyntax CatchClause(SyntaxToken @catchKeyword, CatchDeclarationSyntax @declaration, CatchFilterClauseSyntax @filter, BlockSyntax @block)
	{
		return SyntaxFactory.CatchClause(@catchKeyword, @declaration, @filter, @block);
	}

	public static CatchClauseSyntax CatchClause(CatchDeclarationSyntax @declaration, CatchFilterClauseSyntax @filter, BlockSyntax @block)
	{
		return SyntaxFactory.CatchClause(@declaration, @filter, @block);
	}

	public static CatchClauseSyntax CatchClause()
	{
		return SyntaxFactory.CatchClause();
	}

	public static CatchDeclarationSyntax CatchDeclaration(SyntaxToken @openParenToken, TypeSyntax @type, SyntaxToken @identifier, SyntaxToken @closeParenToken)
	{
		return SyntaxFactory.CatchDeclaration(@openParenToken, @type, @identifier, @closeParenToken);
	}

	public static CatchDeclarationSyntax CatchDeclaration(TypeSyntax @type, SyntaxToken @identifier)
	{
		return SyntaxFactory.CatchDeclaration(@type, @identifier);
	}

	public static CatchDeclarationSyntax CatchDeclaration(TypeSyntax @type)
	{
		return SyntaxFactory.CatchDeclaration(@type);
	}

	public static CatchFilterClauseSyntax CatchFilterClause(SyntaxToken @whenKeyword, SyntaxToken @openParenToken, ExpressionSyntax @filterExpression, SyntaxToken @closeParenToken)
	{
		return SyntaxFactory.CatchFilterClause(@whenKeyword, @openParenToken, @filterExpression, @closeParenToken);
	}

	public static CatchFilterClauseSyntax CatchFilterClause(ExpressionSyntax @filterExpression)
	{
		return SyntaxFactory.CatchFilterClause(@filterExpression);
	}

	public static FinallyClauseSyntax FinallyClause(SyntaxToken @finallyKeyword, BlockSyntax @block)
	{
		return SyntaxFactory.FinallyClause(@finallyKeyword, @block);
	}

	public static FinallyClauseSyntax FinallyClause(BlockSyntax @block)
	{
		return SyntaxFactory.FinallyClause(@block);
	}

	public static CompilationUnitSyntax CompilationUnit(SyntaxList<ExternAliasDirectiveSyntax> @externs, SyntaxList<UsingDirectiveSyntax> @usings, SyntaxList<AttributeListSyntax> @attributeLists, SyntaxList<MemberDeclarationSyntax> @members, SyntaxToken @endOfFileToken)
	{
		return SyntaxFactory.CompilationUnit(@externs, @usings, @attributeLists, @members, @endOfFileToken);
	}

	public static CompilationUnitSyntax CompilationUnit(SyntaxList<ExternAliasDirectiveSyntax> @externs, SyntaxList<UsingDirectiveSyntax> @usings, SyntaxList<AttributeListSyntax> @attributeLists, SyntaxList<MemberDeclarationSyntax> @members)
	{
		return SyntaxFactory.CompilationUnit(@externs, @usings, @attributeLists, @members);
	}

	public static CompilationUnitSyntax CompilationUnit()
	{
		return SyntaxFactory.CompilationUnit();
	}

	public static ExternAliasDirectiveSyntax ExternAliasDirective(SyntaxToken @externKeyword, SyntaxToken @aliasKeyword, SyntaxToken @identifier, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.ExternAliasDirective(@externKeyword, @aliasKeyword, @identifier, @semicolonToken);
	}

	public static ExternAliasDirectiveSyntax ExternAliasDirective(SyntaxToken @identifier)
	{
		return SyntaxFactory.ExternAliasDirective(@identifier);
	}

	public static ExternAliasDirectiveSyntax ExternAliasDirective(String @identifier)
	{
		return SyntaxFactory.ExternAliasDirective(@identifier);
	}

	public static UsingDirectiveSyntax UsingDirective(SyntaxToken @usingKeyword, SyntaxToken @staticKeyword, NameEqualsSyntax @alias, NameSyntax @name, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.UsingDirective(@usingKeyword, @staticKeyword, @alias, @name, @semicolonToken);
	}

	public static UsingDirectiveSyntax UsingDirective(SyntaxToken @staticKeyword, NameEqualsSyntax @alias, NameSyntax @name)
	{
		return SyntaxFactory.UsingDirective(@staticKeyword, @alias, @name);
	}

	public static UsingDirectiveSyntax UsingDirective(NameSyntax @name)
	{
		return SyntaxFactory.UsingDirective(@name);
	}

	public static NamespaceDeclarationSyntax NamespaceDeclaration(SyntaxToken @namespaceKeyword, NameSyntax @name, SyntaxToken @openBraceToken, SyntaxList<ExternAliasDirectiveSyntax> @externs, SyntaxList<UsingDirectiveSyntax> @usings, SyntaxList<MemberDeclarationSyntax> @members, SyntaxToken @closeBraceToken, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.NamespaceDeclaration(@namespaceKeyword, @name, @openBraceToken, @externs, @usings, @members, @closeBraceToken, @semicolonToken);
	}

	public static NamespaceDeclarationSyntax NamespaceDeclaration(NameSyntax @name, SyntaxList<ExternAliasDirectiveSyntax> @externs, SyntaxList<UsingDirectiveSyntax> @usings, SyntaxList<MemberDeclarationSyntax> @members)
	{
		return SyntaxFactory.NamespaceDeclaration(@name, @externs, @usings, @members);
	}

	public static NamespaceDeclarationSyntax NamespaceDeclaration(NameSyntax @name)
	{
		return SyntaxFactory.NamespaceDeclaration(@name);
	}

	public static AttributeListSyntax AttributeList(SyntaxToken @openBracketToken, AttributeTargetSpecifierSyntax @target, SeparatedSyntaxList<AttributeSyntax> @attributes, SyntaxToken @closeBracketToken)
	{
		return SyntaxFactory.AttributeList(@openBracketToken, @target, @attributes, @closeBracketToken);
	}

	public static AttributeListSyntax AttributeList(AttributeTargetSpecifierSyntax @target, SeparatedSyntaxList<AttributeSyntax> @attributes)
	{
		return SyntaxFactory.AttributeList(@target, @attributes);
	}

	public static AttributeListSyntax AttributeList(SeparatedSyntaxList<AttributeSyntax> @attributes)
	{
		return SyntaxFactory.AttributeList(@attributes);
	}

	public static AttributeTargetSpecifierSyntax AttributeTargetSpecifier(SyntaxToken @identifier, SyntaxToken @colonToken)
	{
		return SyntaxFactory.AttributeTargetSpecifier(@identifier, @colonToken);
	}

	public static AttributeTargetSpecifierSyntax AttributeTargetSpecifier(SyntaxToken @identifier)
	{
		return SyntaxFactory.AttributeTargetSpecifier(@identifier);
	}

	public static AttributeSyntax Attribute(NameSyntax @name, AttributeArgumentListSyntax @argumentList)
	{
		return SyntaxFactory.Attribute(@name, @argumentList);
	}

	public static AttributeSyntax Attribute(NameSyntax @name)
	{
		return SyntaxFactory.Attribute(@name);
	}

	public static AttributeArgumentListSyntax AttributeArgumentList(SyntaxToken @openParenToken, SeparatedSyntaxList<AttributeArgumentSyntax> @arguments, SyntaxToken @closeParenToken)
	{
		return SyntaxFactory.AttributeArgumentList(@openParenToken, @arguments, @closeParenToken);
	}

	public static AttributeArgumentListSyntax AttributeArgumentList(SeparatedSyntaxList<AttributeArgumentSyntax> @arguments)
	{
		return SyntaxFactory.AttributeArgumentList(@arguments);
	}

	public static AttributeArgumentSyntax AttributeArgument(NameEqualsSyntax @nameEquals, NameColonSyntax @nameColon, ExpressionSyntax @expression)
	{
		return SyntaxFactory.AttributeArgument(@nameEquals, @nameColon, @expression);
	}

	public static AttributeArgumentSyntax AttributeArgument(ExpressionSyntax @expression)
	{
		return SyntaxFactory.AttributeArgument(@expression);
	}

	public static NameEqualsSyntax NameEquals(IdentifierNameSyntax @name, SyntaxToken @equalsToken)
	{
		return SyntaxFactory.NameEquals(@name, @equalsToken);
	}

	public static NameEqualsSyntax NameEquals(IdentifierNameSyntax @name)
	{
		return SyntaxFactory.NameEquals(@name);
	}

	public static NameEqualsSyntax NameEquals(String @name)
	{
		return SyntaxFactory.NameEquals(@name);
	}

	public static TypeParameterListSyntax TypeParameterList(SyntaxToken @lessThanToken, SeparatedSyntaxList<TypeParameterSyntax> @parameters, SyntaxToken @greaterThanToken)
	{
		return SyntaxFactory.TypeParameterList(@lessThanToken, @parameters, @greaterThanToken);
	}

	public static TypeParameterListSyntax TypeParameterList(SeparatedSyntaxList<TypeParameterSyntax> @parameters)
	{
		return SyntaxFactory.TypeParameterList(@parameters);
	}

	public static TypeParameterSyntax TypeParameter(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxToken @varianceKeyword, SyntaxToken @identifier)
	{
		return SyntaxFactory.TypeParameter(@attributeLists, @varianceKeyword, @identifier);
	}

	public static TypeParameterSyntax TypeParameter(SyntaxToken @identifier)
	{
		return SyntaxFactory.TypeParameter(@identifier);
	}

	public static TypeParameterSyntax TypeParameter(String @identifier)
	{
		return SyntaxFactory.TypeParameter(@identifier);
	}

	public static ClassDeclarationSyntax ClassDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @keyword, SyntaxToken @identifier, TypeParameterListSyntax @typeParameterList, BaseListSyntax @baseList, SyntaxList<TypeParameterConstraintClauseSyntax> @constraintClauses, SyntaxToken @openBraceToken, SyntaxList<MemberDeclarationSyntax> @members, SyntaxToken @closeBraceToken, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.ClassDeclaration(@attributeLists, @modifiers, @keyword, @identifier, @typeParameterList, @baseList, @constraintClauses, @openBraceToken, @members, @closeBraceToken, @semicolonToken);
	}

	public static ClassDeclarationSyntax ClassDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @identifier, TypeParameterListSyntax @typeParameterList, BaseListSyntax @baseList, SyntaxList<TypeParameterConstraintClauseSyntax> @constraintClauses, SyntaxList<MemberDeclarationSyntax> @members)
	{
		return SyntaxFactory.ClassDeclaration(@attributeLists, @modifiers, @identifier, @typeParameterList, @baseList, @constraintClauses, @members);
	}

	public static ClassDeclarationSyntax ClassDeclaration(SyntaxToken @identifier)
	{
		return SyntaxFactory.ClassDeclaration(@identifier);
	}

	public static ClassDeclarationSyntax ClassDeclaration(String @identifier)
	{
		return SyntaxFactory.ClassDeclaration(@identifier);
	}

	public static StructDeclarationSyntax StructDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @keyword, SyntaxToken @identifier, TypeParameterListSyntax @typeParameterList, BaseListSyntax @baseList, SyntaxList<TypeParameterConstraintClauseSyntax> @constraintClauses, SyntaxToken @openBraceToken, SyntaxList<MemberDeclarationSyntax> @members, SyntaxToken @closeBraceToken, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.StructDeclaration(@attributeLists, @modifiers, @keyword, @identifier, @typeParameterList, @baseList, @constraintClauses, @openBraceToken, @members, @closeBraceToken, @semicolonToken);
	}

	public static StructDeclarationSyntax StructDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @identifier, TypeParameterListSyntax @typeParameterList, BaseListSyntax @baseList, SyntaxList<TypeParameterConstraintClauseSyntax> @constraintClauses, SyntaxList<MemberDeclarationSyntax> @members)
	{
		return SyntaxFactory.StructDeclaration(@attributeLists, @modifiers, @identifier, @typeParameterList, @baseList, @constraintClauses, @members);
	}

	public static StructDeclarationSyntax StructDeclaration(SyntaxToken @identifier)
	{
		return SyntaxFactory.StructDeclaration(@identifier);
	}

	public static StructDeclarationSyntax StructDeclaration(String @identifier)
	{
		return SyntaxFactory.StructDeclaration(@identifier);
	}

	public static InterfaceDeclarationSyntax InterfaceDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @keyword, SyntaxToken @identifier, TypeParameterListSyntax @typeParameterList, BaseListSyntax @baseList, SyntaxList<TypeParameterConstraintClauseSyntax> @constraintClauses, SyntaxToken @openBraceToken, SyntaxList<MemberDeclarationSyntax> @members, SyntaxToken @closeBraceToken, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.InterfaceDeclaration(@attributeLists, @modifiers, @keyword, @identifier, @typeParameterList, @baseList, @constraintClauses, @openBraceToken, @members, @closeBraceToken, @semicolonToken);
	}

	public static InterfaceDeclarationSyntax InterfaceDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @identifier, TypeParameterListSyntax @typeParameterList, BaseListSyntax @baseList, SyntaxList<TypeParameterConstraintClauseSyntax> @constraintClauses, SyntaxList<MemberDeclarationSyntax> @members)
	{
		return SyntaxFactory.InterfaceDeclaration(@attributeLists, @modifiers, @identifier, @typeParameterList, @baseList, @constraintClauses, @members);
	}

	public static InterfaceDeclarationSyntax InterfaceDeclaration(SyntaxToken @identifier)
	{
		return SyntaxFactory.InterfaceDeclaration(@identifier);
	}

	public static InterfaceDeclarationSyntax InterfaceDeclaration(String @identifier)
	{
		return SyntaxFactory.InterfaceDeclaration(@identifier);
	}

	public static EnumDeclarationSyntax EnumDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @enumKeyword, SyntaxToken @identifier, BaseListSyntax @baseList, SyntaxToken @openBraceToken, SeparatedSyntaxList<EnumMemberDeclarationSyntax> @members, SyntaxToken @closeBraceToken, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.EnumDeclaration(@attributeLists, @modifiers, @enumKeyword, @identifier, @baseList, @openBraceToken, @members, @closeBraceToken, @semicolonToken);
	}

	public static EnumDeclarationSyntax EnumDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @identifier, BaseListSyntax @baseList, SeparatedSyntaxList<EnumMemberDeclarationSyntax> @members)
	{
		return SyntaxFactory.EnumDeclaration(@attributeLists, @modifiers, @identifier, @baseList, @members);
	}

	public static EnumDeclarationSyntax EnumDeclaration(SyntaxToken @identifier)
	{
		return SyntaxFactory.EnumDeclaration(@identifier);
	}

	public static EnumDeclarationSyntax EnumDeclaration(String @identifier)
	{
		return SyntaxFactory.EnumDeclaration(@identifier);
	}

	public static DelegateDeclarationSyntax DelegateDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, SyntaxToken @delegateKeyword, TypeSyntax @returnType, SyntaxToken @identifier, TypeParameterListSyntax @typeParameterList, ParameterListSyntax @parameterList, SyntaxList<TypeParameterConstraintClauseSyntax> @constraintClauses, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.DelegateDeclaration(@attributeLists, @modifiers, @delegateKeyword, @returnType, @identifier, @typeParameterList, @parameterList, @constraintClauses, @semicolonToken);
	}

	public static DelegateDeclarationSyntax DelegateDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxTokenList @modifiers, TypeSyntax @returnType, SyntaxToken @identifier, TypeParameterListSyntax @typeParameterList, ParameterListSyntax @parameterList, SyntaxList<TypeParameterConstraintClauseSyntax> @constraintClauses)
	{
		return SyntaxFactory.DelegateDeclaration(@attributeLists, @modifiers, @returnType, @identifier, @typeParameterList, @parameterList, @constraintClauses);
	}

	public static DelegateDeclarationSyntax DelegateDeclaration(TypeSyntax @returnType, SyntaxToken @identifier)
	{
		return SyntaxFactory.DelegateDeclaration(@returnType, @identifier);
	}

	public static DelegateDeclarationSyntax DelegateDeclaration(TypeSyntax @returnType, String @identifier)
	{
		return SyntaxFactory.DelegateDeclaration(@returnType, @identifier);
	}

	public static EnumMemberDeclarationSyntax EnumMemberDeclaration(SyntaxList<AttributeListSyntax> @attributeLists, SyntaxToken @identifier, EqualsValueClauseSyntax @equalsValue)
	{
		return SyntaxFactory.EnumMemberDeclaration(@attributeLists, @identifier, @equalsValue);
	}

	public static EnumMemberDeclarationSyntax EnumMemberDeclaration(SyntaxToken @identifier)
	{
		return SyntaxFactory.EnumMemberDeclaration(@identifier);
	}

	public static EnumMemberDeclarationSyntax EnumMemberDeclaration(String @identifier)
	{
		return SyntaxFactory.EnumMemberDeclaration(@identifier);
	}

	public static BaseListSyntax BaseList(SyntaxToken @colonToken, SeparatedSyntaxList<BaseTypeSyntax> @types)
	{
		return SyntaxFactory.BaseList(@colonToken, @types);
	}

	public static BaseListSyntax BaseList(SeparatedSyntaxList<BaseTypeSyntax> @types)
	{
		return SyntaxFactory.BaseList(@types);
	}

	public static SimpleBaseTypeSyntax SimpleBaseType(TypeSyntax @type)
	{
		return SyntaxFactory.SimpleBaseType(@type);
	}

	public static TypeParameterConstraintClauseSyntax TypeParameterConstraintClause(SyntaxToken @whereKeyword, IdentifierNameSyntax @name, SyntaxToken @colonToken, SeparatedSyntaxList<TypeParameterConstraintSyntax> @constraints)
	{
		return SyntaxFactory.TypeParameterConstraintClause(@whereKeyword, @name, @colonToken, @constraints);
	}

	public static TypeParameterConstraintClauseSyntax TypeParameterConstraintClause(IdentifierNameSyntax @name, SeparatedSyntaxList<TypeParameterConstraintSyntax> @constraints)
	{
		return SyntaxFactory.TypeParameterConstraintClause(@name, @constraints);
	}

	public static TypeParameterConstraintClauseSyntax TypeParameterConstraintClause(IdentifierNameSyntax @name)
	{
		return SyntaxFactory.TypeParameterConstraintClause(@name);
	}

	public static TypeParameterConstraintClauseSyntax TypeParameterConstraintClause(String @name)
	{
		return SyntaxFactory.TypeParameterConstraintClause(@name);
	}

	public static ConstructorConstraintSyntax ConstructorConstraint(SyntaxToken @newKeyword, SyntaxToken @openParenToken, SyntaxToken @closeParenToken)
	{
		return SyntaxFactory.ConstructorConstraint(@newKeyword, @openParenToken, @closeParenToken);
	}

	public static ConstructorConstraintSyntax ConstructorConstraint()
	{
		return SyntaxFactory.ConstructorConstraint();
	}

	public static ClassOrStructConstraintSyntax ClassOrStructConstraint(SyntaxKind @kind, SyntaxToken @classOrStructKeyword)
	{
		return SyntaxFactory.ClassOrStructConstraint(@kind, @classOrStructKeyword);
	}

	public static ConstantPatternSyntax ConstantPattern(ExpressionSyntax @expression)
	{
		return SyntaxFactory.ConstantPattern(@expression);
	}

	public static InterpolatedStringTextSyntax InterpolatedStringText(SyntaxToken @textToken)
	{
		return SyntaxFactory.InterpolatedStringText(@textToken);
	}

	public static InterpolatedStringTextSyntax InterpolatedStringText()
	{
		return SyntaxFactory.InterpolatedStringText();
	}

	public static InterpolationSyntax Interpolation(SyntaxToken @openBraceToken, ExpressionSyntax @expression, InterpolationAlignmentClauseSyntax @alignmentClause, InterpolationFormatClauseSyntax @formatClause, SyntaxToken @closeBraceToken)
	{
		return SyntaxFactory.Interpolation(@openBraceToken, @expression, @alignmentClause, @formatClause, @closeBraceToken);
	}

	public static InterpolationSyntax Interpolation(ExpressionSyntax @expression, InterpolationAlignmentClauseSyntax @alignmentClause, InterpolationFormatClauseSyntax @formatClause)
	{
		return SyntaxFactory.Interpolation(@expression, @alignmentClause, @formatClause);
	}

	public static InterpolationSyntax Interpolation(ExpressionSyntax @expression)
	{
		return SyntaxFactory.Interpolation(@expression);
	}

	public static InterpolationAlignmentClauseSyntax InterpolationAlignmentClause(SyntaxToken @commaToken, ExpressionSyntax @value)
	{
		return SyntaxFactory.InterpolationAlignmentClause(@commaToken, @value);
	}

	public static InterpolationFormatClauseSyntax InterpolationFormatClause(SyntaxToken @colonToken, SyntaxToken @formatStringToken)
	{
		return SyntaxFactory.InterpolationFormatClause(@colonToken, @formatStringToken);
	}

	public static InterpolationFormatClauseSyntax InterpolationFormatClause(SyntaxToken @colonToken)
	{
		return SyntaxFactory.InterpolationFormatClause(@colonToken);
	}

	public static GlobalStatementSyntax GlobalStatement(StatementSyntax @statement)
	{
		return SyntaxFactory.GlobalStatement(@statement);
	}

	public static BlockSyntax Block(SyntaxToken @openBraceToken, SyntaxList<StatementSyntax> @statements, SyntaxToken @closeBraceToken)
	{
		return SyntaxFactory.Block(@openBraceToken, @statements, @closeBraceToken);
	}

	public static BlockSyntax Block(SyntaxList<StatementSyntax> @statements)
	{
		return SyntaxFactory.Block(@statements);
	}

	public static LocalFunctionStatementSyntax LocalFunctionStatement(SyntaxTokenList @modifiers, TypeSyntax @returnType, SyntaxToken @identifier, TypeParameterListSyntax @typeParameterList, ParameterListSyntax @parameterList, SyntaxList<TypeParameterConstraintClauseSyntax> @constraintClauses, BlockSyntax @body, ArrowExpressionClauseSyntax @expressionBody, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.LocalFunctionStatement(@modifiers, @returnType, @identifier, @typeParameterList, @parameterList, @constraintClauses, @body, @expressionBody, @semicolonToken);
	}

	public static LocalFunctionStatementSyntax LocalFunctionStatement(SyntaxTokenList @modifiers, TypeSyntax @returnType, SyntaxToken @identifier, TypeParameterListSyntax @typeParameterList, ParameterListSyntax @parameterList, SyntaxList<TypeParameterConstraintClauseSyntax> @constraintClauses, BlockSyntax @body, ArrowExpressionClauseSyntax @expressionBody)
	{
		return SyntaxFactory.LocalFunctionStatement(@modifiers, @returnType, @identifier, @typeParameterList, @parameterList, @constraintClauses, @body, @expressionBody);
	}

	public static LocalFunctionStatementSyntax LocalFunctionStatement(TypeSyntax @returnType, SyntaxToken @identifier)
	{
		return SyntaxFactory.LocalFunctionStatement(@returnType, @identifier);
	}

	public static LocalFunctionStatementSyntax LocalFunctionStatement(TypeSyntax @returnType, String @identifier)
	{
		return SyntaxFactory.LocalFunctionStatement(@returnType, @identifier);
	}

	public static LocalDeclarationStatementSyntax LocalDeclarationStatement(SyntaxTokenList @modifiers, VariableDeclarationSyntax @declaration, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.LocalDeclarationStatement(@modifiers, @declaration, @semicolonToken);
	}

	public static LocalDeclarationStatementSyntax LocalDeclarationStatement(SyntaxTokenList @modifiers, VariableDeclarationSyntax @declaration)
	{
		return SyntaxFactory.LocalDeclarationStatement(@modifiers, @declaration);
	}

	public static LocalDeclarationStatementSyntax LocalDeclarationStatement(VariableDeclarationSyntax @declaration)
	{
		return SyntaxFactory.LocalDeclarationStatement(@declaration);
	}

	public static VariableDeclarationSyntax VariableDeclaration(TypeSyntax @type, SeparatedSyntaxList<VariableDeclaratorSyntax> @variables)
	{
		return SyntaxFactory.VariableDeclaration(@type, @variables);
	}

	public static VariableDeclarationSyntax VariableDeclaration(TypeSyntax @type)
	{
		return SyntaxFactory.VariableDeclaration(@type);
	}

	public static VariableDeclaratorSyntax VariableDeclarator(SyntaxToken @identifier, BracketedArgumentListSyntax @argumentList, EqualsValueClauseSyntax @initializer)
	{
		return SyntaxFactory.VariableDeclarator(@identifier, @argumentList, @initializer);
	}

	public static VariableDeclaratorSyntax VariableDeclarator(SyntaxToken @identifier)
	{
		return SyntaxFactory.VariableDeclarator(@identifier);
	}

	public static VariableDeclaratorSyntax VariableDeclarator(String @identifier)
	{
		return SyntaxFactory.VariableDeclarator(@identifier);
	}

	public static EqualsValueClauseSyntax EqualsValueClause(SyntaxToken @equalsToken, ExpressionSyntax @value)
	{
		return SyntaxFactory.EqualsValueClause(@equalsToken, @value);
	}

	public static EqualsValueClauseSyntax EqualsValueClause(ExpressionSyntax @value)
	{
		return SyntaxFactory.EqualsValueClause(@value);
	}

	public static SingleVariableDesignationSyntax SingleVariableDesignation(SyntaxToken @identifier)
	{
		return SyntaxFactory.SingleVariableDesignation(@identifier);
	}

	public static DiscardDesignationSyntax DiscardDesignation(SyntaxToken @underscoreToken)
	{
		return SyntaxFactory.DiscardDesignation(@underscoreToken);
	}

	public static DiscardDesignationSyntax DiscardDesignation()
	{
		return SyntaxFactory.DiscardDesignation();
	}

	public static ParenthesizedVariableDesignationSyntax ParenthesizedVariableDesignation(SyntaxToken @openParenToken, SeparatedSyntaxList<VariableDesignationSyntax> @variables, SyntaxToken @closeParenToken)
	{
		return SyntaxFactory.ParenthesizedVariableDesignation(@openParenToken, @variables, @closeParenToken);
	}

	public static ParenthesizedVariableDesignationSyntax ParenthesizedVariableDesignation(SeparatedSyntaxList<VariableDesignationSyntax> @variables)
	{
		return SyntaxFactory.ParenthesizedVariableDesignation(@variables);
	}

	public static ExpressionStatementSyntax ExpressionStatement(ExpressionSyntax @expression, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.ExpressionStatement(@expression, @semicolonToken);
	}

	public static ExpressionStatementSyntax ExpressionStatement(ExpressionSyntax @expression)
	{
		return SyntaxFactory.ExpressionStatement(@expression);
	}

	public static EmptyStatementSyntax EmptyStatement(SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.EmptyStatement(@semicolonToken);
	}

	public static EmptyStatementSyntax EmptyStatement()
	{
		return SyntaxFactory.EmptyStatement();
	}

	public static LabeledStatementSyntax LabeledStatement(SyntaxToken @identifier, SyntaxToken @colonToken, StatementSyntax @statement)
	{
		return SyntaxFactory.LabeledStatement(@identifier, @colonToken, @statement);
	}

	public static LabeledStatementSyntax LabeledStatement(SyntaxToken @identifier, StatementSyntax @statement)
	{
		return SyntaxFactory.LabeledStatement(@identifier, @statement);
	}

	public static LabeledStatementSyntax LabeledStatement(String @identifier, StatementSyntax @statement)
	{
		return SyntaxFactory.LabeledStatement(@identifier, @statement);
	}

	public static GotoStatementSyntax GotoStatement(SyntaxKind @kind, SyntaxToken @gotoKeyword, SyntaxToken @caseOrDefaultKeyword, ExpressionSyntax @expression, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.GotoStatement(@kind, @gotoKeyword, @caseOrDefaultKeyword, @expression, @semicolonToken);
	}

	public static GotoStatementSyntax GotoStatement(SyntaxKind @kind, SyntaxToken @caseOrDefaultKeyword, ExpressionSyntax @expression)
	{
		return SyntaxFactory.GotoStatement(@kind, @caseOrDefaultKeyword, @expression);
	}

	public static GotoStatementSyntax GotoStatement(SyntaxKind @kind, ExpressionSyntax @expression)
	{
		return SyntaxFactory.GotoStatement(@kind, @expression);
	}

	public static BreakStatementSyntax BreakStatement(SyntaxToken @breakKeyword, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.BreakStatement(@breakKeyword, @semicolonToken);
	}

	public static BreakStatementSyntax BreakStatement()
	{
		return SyntaxFactory.BreakStatement();
	}

	public static ContinueStatementSyntax ContinueStatement(SyntaxToken @continueKeyword, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.ContinueStatement(@continueKeyword, @semicolonToken);
	}

	public static ContinueStatementSyntax ContinueStatement()
	{
		return SyntaxFactory.ContinueStatement();
	}

	public static ReturnStatementSyntax ReturnStatement(SyntaxToken @returnKeyword, ExpressionSyntax @expression, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.ReturnStatement(@returnKeyword, @expression, @semicolonToken);
	}

	public static ReturnStatementSyntax ReturnStatement(ExpressionSyntax @expression)
	{
		return SyntaxFactory.ReturnStatement(@expression);
	}

	public static ThrowStatementSyntax ThrowStatement(SyntaxToken @throwKeyword, ExpressionSyntax @expression, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.ThrowStatement(@throwKeyword, @expression, @semicolonToken);
	}

	public static ThrowStatementSyntax ThrowStatement(ExpressionSyntax @expression)
	{
		return SyntaxFactory.ThrowStatement(@expression);
	}

	public static YieldStatementSyntax YieldStatement(SyntaxKind @kind, SyntaxToken @yieldKeyword, SyntaxToken @returnOrBreakKeyword, ExpressionSyntax @expression, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.YieldStatement(@kind, @yieldKeyword, @returnOrBreakKeyword, @expression, @semicolonToken);
	}

	public static YieldStatementSyntax YieldStatement(SyntaxKind @kind, ExpressionSyntax @expression)
	{
		return SyntaxFactory.YieldStatement(@kind, @expression);
	}

	public static WhileStatementSyntax WhileStatement(SyntaxToken @whileKeyword, SyntaxToken @openParenToken, ExpressionSyntax @condition, SyntaxToken @closeParenToken, StatementSyntax @statement)
	{
		return SyntaxFactory.WhileStatement(@whileKeyword, @openParenToken, @condition, @closeParenToken, @statement);
	}

	public static WhileStatementSyntax WhileStatement(ExpressionSyntax @condition, StatementSyntax @statement)
	{
		return SyntaxFactory.WhileStatement(@condition, @statement);
	}

	public static DoStatementSyntax DoStatement(SyntaxToken @doKeyword, StatementSyntax @statement, SyntaxToken @whileKeyword, SyntaxToken @openParenToken, ExpressionSyntax @condition, SyntaxToken @closeParenToken, SyntaxToken @semicolonToken)
	{
		return SyntaxFactory.DoStatement(@doKeyword, @statement, @whileKeyword, @openParenToken, @condition, @closeParenToken, @semicolonToken);
	}

	public static DoStatementSyntax DoStatement(StatementSyntax @statement, ExpressionSyntax @condition)
	{
		return SyntaxFactory.DoStatement(@statement, @condition);
	}

	public static ForStatementSyntax ForStatement(SyntaxToken @forKeyword, SyntaxToken @openParenToken, VariableDeclarationSyntax @declaration, SeparatedSyntaxList<ExpressionSyntax> @initializers, SyntaxToken @firstSemicolonToken, ExpressionSyntax @condition, SyntaxToken @secondSemicolonToken, SeparatedSyntaxList<ExpressionSyntax> @incrementors, SyntaxToken @closeParenToken, StatementSyntax @statement)
	{
		return SyntaxFactory.ForStatement(@forKeyword, @openParenToken, @declaration, @initializers, @firstSemicolonToken, @condition, @secondSemicolonToken, @incrementors, @closeParenToken, @statement);
	}

	public static ForStatementSyntax ForStatement(VariableDeclarationSyntax @declaration, SeparatedSyntaxList<ExpressionSyntax> @initializers, ExpressionSyntax @condition, SeparatedSyntaxList<ExpressionSyntax> @incrementors, StatementSyntax @statement)
	{
		return SyntaxFactory.ForStatement(@declaration, @initializers, @condition, @incrementors, @statement);
	}

	public static ForStatementSyntax ForStatement(StatementSyntax @statement)
	{
		return SyntaxFactory.ForStatement(@statement);
	}

	public static ForEachStatementSyntax ForEachStatement(SyntaxToken @forEachKeyword, SyntaxToken @openParenToken, TypeSyntax @type, SyntaxToken @identifier, SyntaxToken @inKeyword, ExpressionSyntax @expression, SyntaxToken @closeParenToken, StatementSyntax @statement)
	{
		return SyntaxFactory.ForEachStatement(@forEachKeyword, @openParenToken, @type, @identifier, @inKeyword, @expression, @closeParenToken, @statement);
	}

	public static ForEachStatementSyntax ForEachStatement(TypeSyntax @type, SyntaxToken @identifier, ExpressionSyntax @expression, StatementSyntax @statement)
	{
		return SyntaxFactory.ForEachStatement(@type, @identifier, @expression, @statement);
	}

	public static ForEachStatementSyntax ForEachStatement(TypeSyntax @type, String @identifier, ExpressionSyntax @expression, StatementSyntax @statement)
	{
		return SyntaxFactory.ForEachStatement(@type, @identifier, @expression, @statement);
	}

	public static ForEachVariableStatementSyntax ForEachVariableStatement(SyntaxToken @forEachKeyword, SyntaxToken @openParenToken, ExpressionSyntax @variable, SyntaxToken @inKeyword, ExpressionSyntax @expression, SyntaxToken @closeParenToken, StatementSyntax @statement)
	{
		return SyntaxFactory.ForEachVariableStatement(@forEachKeyword, @openParenToken, @variable, @inKeyword, @expression, @closeParenToken, @statement);
	}

	public static ForEachVariableStatementSyntax ForEachVariableStatement(ExpressionSyntax @variable, ExpressionSyntax @expression, StatementSyntax @statement)
	{
		return SyntaxFactory.ForEachVariableStatement(@variable, @expression, @statement);
	}

	public static UsingStatementSyntax UsingStatement(SyntaxToken @usingKeyword, SyntaxToken @openParenToken, VariableDeclarationSyntax @declaration, ExpressionSyntax @expression, SyntaxToken @closeParenToken, StatementSyntax @statement)
	{
		return SyntaxFactory.UsingStatement(@usingKeyword, @openParenToken, @declaration, @expression, @closeParenToken, @statement);
	}

	public static UsingStatementSyntax UsingStatement(VariableDeclarationSyntax @declaration, ExpressionSyntax @expression, StatementSyntax @statement)
	{
		return SyntaxFactory.UsingStatement(@declaration, @expression, @statement);
	}

	public static UsingStatementSyntax UsingStatement(StatementSyntax @statement)
	{
		return SyntaxFactory.UsingStatement(@statement);
	}

	public static FixedStatementSyntax FixedStatement(SyntaxToken @fixedKeyword, SyntaxToken @openParenToken, VariableDeclarationSyntax @declaration, SyntaxToken @closeParenToken, StatementSyntax @statement)
	{
		return SyntaxFactory.FixedStatement(@fixedKeyword, @openParenToken, @declaration, @closeParenToken, @statement);
	}

	public static FixedStatementSyntax FixedStatement(VariableDeclarationSyntax @declaration, StatementSyntax @statement)
	{
		return SyntaxFactory.FixedStatement(@declaration, @statement);
	}

	public static CheckedStatementSyntax CheckedStatement(SyntaxKind @kind, SyntaxToken @keyword, BlockSyntax @block)
	{
		return SyntaxFactory.CheckedStatement(@kind, @keyword, @block);
	}

	public static CheckedStatementSyntax CheckedStatement(SyntaxKind @kind, BlockSyntax @block)
	{
		return SyntaxFactory.CheckedStatement(@kind, @block);
	}

	public static UnsafeStatementSyntax UnsafeStatement(SyntaxToken @unsafeKeyword, BlockSyntax @block)
	{
		return SyntaxFactory.UnsafeStatement(@unsafeKeyword, @block);
	}

	public static UnsafeStatementSyntax UnsafeStatement(BlockSyntax @block)
	{
		return SyntaxFactory.UnsafeStatement(@block);
	}

	public static LockStatementSyntax LockStatement(SyntaxToken @lockKeyword, SyntaxToken @openParenToken, ExpressionSyntax @expression, SyntaxToken @closeParenToken, StatementSyntax @statement)
	{
		return SyntaxFactory.LockStatement(@lockKeyword, @openParenToken, @expression, @closeParenToken, @statement);
	}

	public static LockStatementSyntax LockStatement(ExpressionSyntax @expression, StatementSyntax @statement)
	{
		return SyntaxFactory.LockStatement(@expression, @statement);
	}

	public static IfStatementSyntax IfStatement(SyntaxToken @ifKeyword, SyntaxToken @openParenToken, ExpressionSyntax @condition, SyntaxToken @closeParenToken, StatementSyntax @statement, ElseClauseSyntax @else)
	{
		return SyntaxFactory.IfStatement(@ifKeyword, @openParenToken, @condition, @closeParenToken, @statement, @else);
	}

	public static IfStatementSyntax IfStatement(ExpressionSyntax @condition, StatementSyntax @statement, ElseClauseSyntax @else)
	{
		return SyntaxFactory.IfStatement(@condition, @statement, @else);
	}

	public static IfStatementSyntax IfStatement(ExpressionSyntax @condition, StatementSyntax @statement)
	{
		return SyntaxFactory.IfStatement(@condition, @statement);
	}

	public static ElseClauseSyntax ElseClause(SyntaxToken @elseKeyword, StatementSyntax @statement)
	{
		return SyntaxFactory.ElseClause(@elseKeyword, @statement);
	}

	public static ElseClauseSyntax ElseClause(StatementSyntax @statement)
	{
		return SyntaxFactory.ElseClause(@statement);
	}

	public static SwitchStatementSyntax SwitchStatement(SyntaxToken @switchKeyword, SyntaxToken @openParenToken, ExpressionSyntax @expression, SyntaxToken @closeParenToken, SyntaxToken @openBraceToken, SyntaxList<SwitchSectionSyntax> @sections, SyntaxToken @closeBraceToken)
	{
		return SyntaxFactory.SwitchStatement(@switchKeyword, @openParenToken, @expression, @closeParenToken, @openBraceToken, @sections, @closeBraceToken);
	}

	public static SwitchStatementSyntax SwitchStatement(ExpressionSyntax @expression, SyntaxList<SwitchSectionSyntax> @sections)
	{
		return SyntaxFactory.SwitchStatement(@expression, @sections);
	}

	public static SwitchStatementSyntax SwitchStatement(ExpressionSyntax @expression)
	{
		return SyntaxFactory.SwitchStatement(@expression);
	}

	public static SwitchSectionSyntax SwitchSection(SyntaxList<SwitchLabelSyntax> @labels, SyntaxList<StatementSyntax> @statements)
	{
		return SyntaxFactory.SwitchSection(@labels, @statements);
	}

	public static ArgumentListSyntax ArgumentList(SyntaxToken @openParenToken, SeparatedSyntaxList<ArgumentSyntax> @arguments, SyntaxToken @closeParenToken)
	{
		return SyntaxFactory.ArgumentList(@openParenToken, @arguments, @closeParenToken);
	}

	public static ArgumentListSyntax ArgumentList(SeparatedSyntaxList<ArgumentSyntax> @arguments)
	{
		return SyntaxFactory.ArgumentList(@arguments);
	}

	public static BracketedArgumentListSyntax BracketedArgumentList(SyntaxToken @openBracketToken, SeparatedSyntaxList<ArgumentSyntax> @arguments, SyntaxToken @closeBracketToken)
	{
		return SyntaxFactory.BracketedArgumentList(@openBracketToken, @arguments, @closeBracketToken);
	}

	public static BracketedArgumentListSyntax BracketedArgumentList(SeparatedSyntaxList<ArgumentSyntax> @arguments)
	{
		return SyntaxFactory.BracketedArgumentList(@arguments);
	}

	public static ArgumentSyntax Argument(NameColonSyntax @nameColon, SyntaxToken @refKindKeyword, ExpressionSyntax @expression)
	{
		return SyntaxFactory.Argument(@nameColon, @refKindKeyword, @expression);
	}

	public static ArgumentSyntax Argument(ExpressionSyntax @expression)
	{
		return SyntaxFactory.Argument(@expression);
	}

	public static NameColonSyntax NameColon(IdentifierNameSyntax @name, SyntaxToken @colonToken)
	{
		return SyntaxFactory.NameColon(@name, @colonToken);
	}

	public static NameColonSyntax NameColon(IdentifierNameSyntax @name)
	{
		return SyntaxFactory.NameColon(@name);
	}

	public static NameColonSyntax NameColon(String @name)
	{
		return SyntaxFactory.NameColon(@name);
	}

	public static DeclarationExpressionSyntax DeclarationExpression(TypeSyntax @type, VariableDesignationSyntax @designation)
	{
		return SyntaxFactory.DeclarationExpression(@type, @designation);
	}

	public static CastExpressionSyntax CastExpression(SyntaxToken @openParenToken, TypeSyntax @type, SyntaxToken @closeParenToken, ExpressionSyntax @expression)
	{
		return SyntaxFactory.CastExpression(@openParenToken, @type, @closeParenToken, @expression);
	}

	public static CastExpressionSyntax CastExpression(TypeSyntax @type, ExpressionSyntax @expression)
	{
		return SyntaxFactory.CastExpression(@type, @expression);
	}

	public static AnonymousMethodExpressionSyntax AnonymousMethodExpression(SyntaxToken @asyncKeyword, SyntaxToken @delegateKeyword, ParameterListSyntax @parameterList, CSharpSyntaxNode @body)
	{
		return SyntaxFactory.AnonymousMethodExpression(@asyncKeyword, @delegateKeyword, @parameterList, @body);
	}

	public static AnonymousMethodExpressionSyntax AnonymousMethodExpression(ParameterListSyntax @parameterList, CSharpSyntaxNode @body)
	{
		return SyntaxFactory.AnonymousMethodExpression(@parameterList, @body);
	}

	public static AnonymousMethodExpressionSyntax AnonymousMethodExpression(CSharpSyntaxNode @body)
	{
		return SyntaxFactory.AnonymousMethodExpression(@body);
	}

	public static SimpleLambdaExpressionSyntax SimpleLambdaExpression(SyntaxToken @asyncKeyword, ParameterSyntax @parameter, SyntaxToken @arrowToken, CSharpSyntaxNode @body)
	{
		return SyntaxFactory.SimpleLambdaExpression(@asyncKeyword, @parameter, @arrowToken, @body);
	}

	public static SimpleLambdaExpressionSyntax SimpleLambdaExpression(ParameterSyntax @parameter, CSharpSyntaxNode @body)
	{
		return SyntaxFactory.SimpleLambdaExpression(@parameter, @body);
	}

	public static RefExpressionSyntax RefExpression(SyntaxToken @refKeyword, ExpressionSyntax @expression)
	{
		return SyntaxFactory.RefExpression(@refKeyword, @expression);
	}

	public static RefExpressionSyntax RefExpression(ExpressionSyntax @expression)
	{
		return SyntaxFactory.RefExpression(@expression);
	}

	public static ParenthesizedLambdaExpressionSyntax ParenthesizedLambdaExpression(SyntaxToken @asyncKeyword, ParameterListSyntax @parameterList, SyntaxToken @arrowToken, CSharpSyntaxNode @body)
	{
		return SyntaxFactory.ParenthesizedLambdaExpression(@asyncKeyword, @parameterList, @arrowToken, @body);
	}

	public static ParenthesizedLambdaExpressionSyntax ParenthesizedLambdaExpression(ParameterListSyntax @parameterList, CSharpSyntaxNode @body)
	{
		return SyntaxFactory.ParenthesizedLambdaExpression(@parameterList, @body);
	}

	public static ParenthesizedLambdaExpressionSyntax ParenthesizedLambdaExpression(CSharpSyntaxNode @body)
	{
		return SyntaxFactory.ParenthesizedLambdaExpression(@body);
	}

	public static InitializerExpressionSyntax InitializerExpression(SyntaxKind @kind, SyntaxToken @openBraceToken, SeparatedSyntaxList<ExpressionSyntax> @expressions, SyntaxToken @closeBraceToken)
	{
		return SyntaxFactory.InitializerExpression(@kind, @openBraceToken, @expressions, @closeBraceToken);
	}

	public static InitializerExpressionSyntax InitializerExpression(SyntaxKind @kind, SeparatedSyntaxList<ExpressionSyntax> @expressions)
	{
		return SyntaxFactory.InitializerExpression(@kind, @expressions);
	}

	public static ObjectCreationExpressionSyntax ObjectCreationExpression(SyntaxToken @newKeyword, TypeSyntax @type, ArgumentListSyntax @argumentList, InitializerExpressionSyntax @initializer)
	{
		return SyntaxFactory.ObjectCreationExpression(@newKeyword, @type, @argumentList, @initializer);
	}

	public static ObjectCreationExpressionSyntax ObjectCreationExpression(TypeSyntax @type, ArgumentListSyntax @argumentList, InitializerExpressionSyntax @initializer)
	{
		return SyntaxFactory.ObjectCreationExpression(@type, @argumentList, @initializer);
	}

	public static ObjectCreationExpressionSyntax ObjectCreationExpression(TypeSyntax @type)
	{
		return SyntaxFactory.ObjectCreationExpression(@type);
	}

	public static AnonymousObjectMemberDeclaratorSyntax AnonymousObjectMemberDeclarator(NameEqualsSyntax @nameEquals, ExpressionSyntax @expression)
	{
		return SyntaxFactory.AnonymousObjectMemberDeclarator(@nameEquals, @expression);
	}

	public static AnonymousObjectMemberDeclaratorSyntax AnonymousObjectMemberDeclarator(ExpressionSyntax @expression)
	{
		return SyntaxFactory.AnonymousObjectMemberDeclarator(@expression);
	}

	public static AnonymousObjectCreationExpressionSyntax AnonymousObjectCreationExpression(SyntaxToken @newKeyword, SyntaxToken @openBraceToken, SeparatedSyntaxList<AnonymousObjectMemberDeclaratorSyntax> @initializers, SyntaxToken @closeBraceToken)
	{
		return SyntaxFactory.AnonymousObjectCreationExpression(@newKeyword, @openBraceToken, @initializers, @closeBraceToken);
	}

	public static AnonymousObjectCreationExpressionSyntax AnonymousObjectCreationExpression(SeparatedSyntaxList<AnonymousObjectMemberDeclaratorSyntax> @initializers)
	{
		return SyntaxFactory.AnonymousObjectCreationExpression(@initializers);
	}

	public static ArrayCreationExpressionSyntax ArrayCreationExpression(SyntaxToken @newKeyword, ArrayTypeSyntax @type, InitializerExpressionSyntax @initializer)
	{
		return SyntaxFactory.ArrayCreationExpression(@newKeyword, @type, @initializer);
	}

	public static ArrayCreationExpressionSyntax ArrayCreationExpression(ArrayTypeSyntax @type, InitializerExpressionSyntax @initializer)
	{
		return SyntaxFactory.ArrayCreationExpression(@type, @initializer);
	}

	public static ArrayCreationExpressionSyntax ArrayCreationExpression(ArrayTypeSyntax @type)
	{
		return SyntaxFactory.ArrayCreationExpression(@type);
	}

	public static ImplicitArrayCreationExpressionSyntax ImplicitArrayCreationExpression(SyntaxToken @newKeyword, SyntaxToken @openBracketToken, SyntaxTokenList @commas, SyntaxToken @closeBracketToken, InitializerExpressionSyntax @initializer)
	{
		return SyntaxFactory.ImplicitArrayCreationExpression(@newKeyword, @openBracketToken, @commas, @closeBracketToken, @initializer);
	}

	public static ImplicitArrayCreationExpressionSyntax ImplicitArrayCreationExpression(SyntaxTokenList @commas, InitializerExpressionSyntax @initializer)
	{
		return SyntaxFactory.ImplicitArrayCreationExpression(@commas, @initializer);
	}

	public static ImplicitArrayCreationExpressionSyntax ImplicitArrayCreationExpression(InitializerExpressionSyntax @initializer)
	{
		return SyntaxFactory.ImplicitArrayCreationExpression(@initializer);
	}

	public static StackAllocArrayCreationExpressionSyntax StackAllocArrayCreationExpression(SyntaxToken @stackAllocKeyword, TypeSyntax @type, InitializerExpressionSyntax @initializer)
	{
		return SyntaxFactory.StackAllocArrayCreationExpression(@stackAllocKeyword, @type, @initializer);
	}

	public static StackAllocArrayCreationExpressionSyntax StackAllocArrayCreationExpression(TypeSyntax @type, InitializerExpressionSyntax @initializer)
	{
		return SyntaxFactory.StackAllocArrayCreationExpression(@type, @initializer);
	}

	public static StackAllocArrayCreationExpressionSyntax StackAllocArrayCreationExpression(TypeSyntax @type)
	{
		return SyntaxFactory.StackAllocArrayCreationExpression(@type);
	}

	public static ImplicitStackAllocArrayCreationExpressionSyntax ImplicitStackAllocArrayCreationExpression(SyntaxToken @stackAllocKeyword, SyntaxToken @openBracketToken, SyntaxToken @closeBracketToken, InitializerExpressionSyntax @initializer)
	{
		return SyntaxFactory.ImplicitStackAllocArrayCreationExpression(@stackAllocKeyword, @openBracketToken, @closeBracketToken, @initializer);
	}

	public static ImplicitStackAllocArrayCreationExpressionSyntax ImplicitStackAllocArrayCreationExpression(InitializerExpressionSyntax @initializer)
	{
		return SyntaxFactory.ImplicitStackAllocArrayCreationExpression(@initializer);
	}

	public static QueryExpressionSyntax QueryExpression(FromClauseSyntax @fromClause, QueryBodySyntax @body)
	{
		return SyntaxFactory.QueryExpression(@fromClause, @body);
	}

	public static QueryBodySyntax QueryBody(SyntaxList<QueryClauseSyntax> @clauses, SelectOrGroupClauseSyntax @selectOrGroup, QueryContinuationSyntax @continuation)
	{
		return SyntaxFactory.QueryBody(@clauses, @selectOrGroup, @continuation);
	}

	public static QueryBodySyntax QueryBody(SelectOrGroupClauseSyntax @selectOrGroup)
	{
		return SyntaxFactory.QueryBody(@selectOrGroup);
	}

	public static FromClauseSyntax FromClause(SyntaxToken @fromKeyword, TypeSyntax @type, SyntaxToken @identifier, SyntaxToken @inKeyword, ExpressionSyntax @expression)
	{
		return SyntaxFactory.FromClause(@fromKeyword, @type, @identifier, @inKeyword, @expression);
	}

	public static FromClauseSyntax FromClause(TypeSyntax @type, SyntaxToken @identifier, ExpressionSyntax @expression)
	{
		return SyntaxFactory.FromClause(@type, @identifier, @expression);
	}

	public static FromClauseSyntax FromClause(SyntaxToken @identifier, ExpressionSyntax @expression)
	{
		return SyntaxFactory.FromClause(@identifier, @expression);
	}

	public static FromClauseSyntax FromClause(String @identifier, ExpressionSyntax @expression)
	{
		return SyntaxFactory.FromClause(@identifier, @expression);
	}

	public static LetClauseSyntax LetClause(SyntaxToken @letKeyword, SyntaxToken @identifier, SyntaxToken @equalsToken, ExpressionSyntax @expression)
	{
		return SyntaxFactory.LetClause(@letKeyword, @identifier, @equalsToken, @expression);
	}

	public static LetClauseSyntax LetClause(SyntaxToken @identifier, ExpressionSyntax @expression)
	{
		return SyntaxFactory.LetClause(@identifier, @expression);
	}

	public static LetClauseSyntax LetClause(String @identifier, ExpressionSyntax @expression)
	{
		return SyntaxFactory.LetClause(@identifier, @expression);
	}

	public static JoinClauseSyntax JoinClause(SyntaxToken @joinKeyword, TypeSyntax @type, SyntaxToken @identifier, SyntaxToken @inKeyword, ExpressionSyntax @inExpression, SyntaxToken @onKeyword, ExpressionSyntax @leftExpression, SyntaxToken @equalsKeyword, ExpressionSyntax @rightExpression, JoinIntoClauseSyntax @into)
	{
		return SyntaxFactory.JoinClause(@joinKeyword, @type, @identifier, @inKeyword, @inExpression, @onKeyword, @leftExpression, @equalsKeyword, @rightExpression, @into);
	}

	public static JoinClauseSyntax JoinClause(TypeSyntax @type, SyntaxToken @identifier, ExpressionSyntax @inExpression, ExpressionSyntax @leftExpression, ExpressionSyntax @rightExpression, JoinIntoClauseSyntax @into)
	{
		return SyntaxFactory.JoinClause(@type, @identifier, @inExpression, @leftExpression, @rightExpression, @into);
	}

	public static JoinClauseSyntax JoinClause(SyntaxToken @identifier, ExpressionSyntax @inExpression, ExpressionSyntax @leftExpression, ExpressionSyntax @rightExpression)
	{
		return SyntaxFactory.JoinClause(@identifier, @inExpression, @leftExpression, @rightExpression);
	}

	public static JoinClauseSyntax JoinClause(String @identifier, ExpressionSyntax @inExpression, ExpressionSyntax @leftExpression, ExpressionSyntax @rightExpression)
	{
		return SyntaxFactory.JoinClause(@identifier, @inExpression, @leftExpression, @rightExpression);
	}

	public static JoinIntoClauseSyntax JoinIntoClause(SyntaxToken @intoKeyword, SyntaxToken @identifier)
	{
		return SyntaxFactory.JoinIntoClause(@intoKeyword, @identifier);
	}

	public static JoinIntoClauseSyntax JoinIntoClause(SyntaxToken @identifier)
	{
		return SyntaxFactory.JoinIntoClause(@identifier);
	}

	public static JoinIntoClauseSyntax JoinIntoClause(String @identifier)
	{
		return SyntaxFactory.JoinIntoClause(@identifier);
	}

	public static WhereClauseSyntax WhereClause(SyntaxToken @whereKeyword, ExpressionSyntax @condition)
	{
		return SyntaxFactory.WhereClause(@whereKeyword, @condition);
	}

	public static WhereClauseSyntax WhereClause(ExpressionSyntax @condition)
	{
		return SyntaxFactory.WhereClause(@condition);
	}

	public static OrderByClauseSyntax OrderByClause(SyntaxToken @orderByKeyword, SeparatedSyntaxList<OrderingSyntax> @orderings)
	{
		return SyntaxFactory.OrderByClause(@orderByKeyword, @orderings);
	}

	public static OrderByClauseSyntax OrderByClause(SeparatedSyntaxList<OrderingSyntax> @orderings)
	{
		return SyntaxFactory.OrderByClause(@orderings);
	}

	public static OrderingSyntax Ordering(SyntaxKind @kind, ExpressionSyntax @expression, SyntaxToken @ascendingOrDescendingKeyword)
	{
		return SyntaxFactory.Ordering(@kind, @expression, @ascendingOrDescendingKeyword);
	}

	public static OrderingSyntax Ordering(SyntaxKind @kind, ExpressionSyntax @expression)
	{
		return SyntaxFactory.Ordering(@kind, @expression);
	}

	public static SelectClauseSyntax SelectClause(SyntaxToken @selectKeyword, ExpressionSyntax @expression)
	{
		return SyntaxFactory.SelectClause(@selectKeyword, @expression);
	}

	public static SelectClauseSyntax SelectClause(ExpressionSyntax @expression)
	{
		return SyntaxFactory.SelectClause(@expression);
	}

	public static GroupClauseSyntax GroupClause(SyntaxToken @groupKeyword, ExpressionSyntax @groupExpression, SyntaxToken @byKeyword, ExpressionSyntax @byExpression)
	{
		return SyntaxFactory.GroupClause(@groupKeyword, @groupExpression, @byKeyword, @byExpression);
	}

	public static GroupClauseSyntax GroupClause(ExpressionSyntax @groupExpression, ExpressionSyntax @byExpression)
	{
		return SyntaxFactory.GroupClause(@groupExpression, @byExpression);
	}

	public static QueryContinuationSyntax QueryContinuation(SyntaxToken @intoKeyword, SyntaxToken @identifier, QueryBodySyntax @body)
	{
		return SyntaxFactory.QueryContinuation(@intoKeyword, @identifier, @body);
	}

	public static QueryContinuationSyntax QueryContinuation(SyntaxToken @identifier, QueryBodySyntax @body)
	{
		return SyntaxFactory.QueryContinuation(@identifier, @body);
	}

	public static QueryContinuationSyntax QueryContinuation(String @identifier, QueryBodySyntax @body)
	{
		return SyntaxFactory.QueryContinuation(@identifier, @body);
	}

	public static OmittedArraySizeExpressionSyntax OmittedArraySizeExpression(SyntaxToken @omittedArraySizeExpressionToken)
	{
		return SyntaxFactory.OmittedArraySizeExpression(@omittedArraySizeExpressionToken);
	}

	public static OmittedArraySizeExpressionSyntax OmittedArraySizeExpression()
	{
		return SyntaxFactory.OmittedArraySizeExpression();
	}

	public static InterpolatedStringExpressionSyntax InterpolatedStringExpression(SyntaxToken @stringStartToken, SyntaxList<InterpolatedStringContentSyntax> @contents, SyntaxToken @stringEndToken)
	{
		return SyntaxFactory.InterpolatedStringExpression(@stringStartToken, @contents, @stringEndToken);
	}

	public static InterpolatedStringExpressionSyntax InterpolatedStringExpression(SyntaxToken @stringStartToken, SyntaxList<InterpolatedStringContentSyntax> @contents)
	{
		return SyntaxFactory.InterpolatedStringExpression(@stringStartToken, @contents);
	}

	public static InterpolatedStringExpressionSyntax InterpolatedStringExpression(SyntaxToken @stringStartToken)
	{
		return SyntaxFactory.InterpolatedStringExpression(@stringStartToken);
	}

	public static IsPatternExpressionSyntax IsPatternExpression(ExpressionSyntax @expression, SyntaxToken @isKeyword, PatternSyntax @pattern)
	{
		return SyntaxFactory.IsPatternExpression(@expression, @isKeyword, @pattern);
	}

	public static IsPatternExpressionSyntax IsPatternExpression(ExpressionSyntax @expression, PatternSyntax @pattern)
	{
		return SyntaxFactory.IsPatternExpression(@expression, @pattern);
	}

	public static ThrowExpressionSyntax ThrowExpression(SyntaxToken @throwKeyword, ExpressionSyntax @expression)
	{
		return SyntaxFactory.ThrowExpression(@throwKeyword, @expression);
	}

	public static ThrowExpressionSyntax ThrowExpression(ExpressionSyntax @expression)
	{
		return SyntaxFactory.ThrowExpression(@expression);
	}

	public static WhenClauseSyntax WhenClause(SyntaxToken @whenKeyword, ExpressionSyntax @condition)
	{
		return SyntaxFactory.WhenClause(@whenKeyword, @condition);
	}

	public static WhenClauseSyntax WhenClause(ExpressionSyntax @condition)
	{
		return SyntaxFactory.WhenClause(@condition);
	}

	public static DeclarationPatternSyntax DeclarationPattern(TypeSyntax @type, VariableDesignationSyntax @designation)
	{
		return SyntaxFactory.DeclarationPattern(@type, @designation);
	}

	public static IdentifierNameSyntax IdentifierName(SyntaxToken @identifier)
	{
		return SyntaxFactory.IdentifierName(@identifier);
	}

	public static QualifiedNameSyntax QualifiedName(NameSyntax @left, SyntaxToken @dotToken, SimpleNameSyntax @right)
	{
		return SyntaxFactory.QualifiedName(@left, @dotToken, @right);
	}

	public static QualifiedNameSyntax QualifiedName(NameSyntax @left, SimpleNameSyntax @right)
	{
		return SyntaxFactory.QualifiedName(@left, @right);
	}

	public static GenericNameSyntax GenericName(SyntaxToken @identifier, TypeArgumentListSyntax @typeArgumentList)
	{
		return SyntaxFactory.GenericName(@identifier, @typeArgumentList);
	}

	public static GenericNameSyntax GenericName(SyntaxToken @identifier)
	{
		return SyntaxFactory.GenericName(@identifier);
	}

	public static GenericNameSyntax GenericName(String @identifier)
	{
		return SyntaxFactory.GenericName(@identifier);
	}

	public static TypeArgumentListSyntax TypeArgumentList(SyntaxToken @lessThanToken, SeparatedSyntaxList<TypeSyntax> @arguments, SyntaxToken @greaterThanToken)
	{
		return SyntaxFactory.TypeArgumentList(@lessThanToken, @arguments, @greaterThanToken);
	}

	public static TypeArgumentListSyntax TypeArgumentList(SeparatedSyntaxList<TypeSyntax> @arguments)
	{
		return SyntaxFactory.TypeArgumentList(@arguments);
	}

	public static AliasQualifiedNameSyntax AliasQualifiedName(IdentifierNameSyntax @alias, SyntaxToken @colonColonToken, SimpleNameSyntax @name)
	{
		return SyntaxFactory.AliasQualifiedName(@alias, @colonColonToken, @name);
	}

	public static AliasQualifiedNameSyntax AliasQualifiedName(IdentifierNameSyntax @alias, SimpleNameSyntax @name)
	{
		return SyntaxFactory.AliasQualifiedName(@alias, @name);
	}

	public static AliasQualifiedNameSyntax AliasQualifiedName(String @alias, SimpleNameSyntax @name)
	{
		return SyntaxFactory.AliasQualifiedName(@alias, @name);
	}

	public static PredefinedTypeSyntax PredefinedType(SyntaxToken @keyword)
	{
		return SyntaxFactory.PredefinedType(@keyword);
	}

	public static ArrayTypeSyntax ArrayType(TypeSyntax @elementType, SyntaxList<ArrayRankSpecifierSyntax> @rankSpecifiers)
	{
		return SyntaxFactory.ArrayType(@elementType, @rankSpecifiers);
	}

	public static ArrayTypeSyntax ArrayType(TypeSyntax @elementType)
	{
		return SyntaxFactory.ArrayType(@elementType);
	}

	public static ArrayRankSpecifierSyntax ArrayRankSpecifier(SyntaxToken @openBracketToken, SeparatedSyntaxList<ExpressionSyntax> @sizes, SyntaxToken @closeBracketToken)
	{
		return SyntaxFactory.ArrayRankSpecifier(@openBracketToken, @sizes, @closeBracketToken);
	}

	public static ArrayRankSpecifierSyntax ArrayRankSpecifier(SeparatedSyntaxList<ExpressionSyntax> @sizes)
	{
		return SyntaxFactory.ArrayRankSpecifier(@sizes);
	}

	public static PointerTypeSyntax PointerType(TypeSyntax @elementType, SyntaxToken @asteriskToken)
	{
		return SyntaxFactory.PointerType(@elementType, @asteriskToken);
	}

	public static PointerTypeSyntax PointerType(TypeSyntax @elementType)
	{
		return SyntaxFactory.PointerType(@elementType);
	}

	public static NullableTypeSyntax NullableType(TypeSyntax @elementType, SyntaxToken @questionToken)
	{
		return SyntaxFactory.NullableType(@elementType, @questionToken);
	}

	public static NullableTypeSyntax NullableType(TypeSyntax @elementType)
	{
		return SyntaxFactory.NullableType(@elementType);
	}

	public static TupleTypeSyntax TupleType(SyntaxToken @openParenToken, SeparatedSyntaxList<TupleElementSyntax> @elements, SyntaxToken @closeParenToken)
	{
		return SyntaxFactory.TupleType(@openParenToken, @elements, @closeParenToken);
	}

	public static TupleTypeSyntax TupleType(SeparatedSyntaxList<TupleElementSyntax> @elements)
	{
		return SyntaxFactory.TupleType(@elements);
	}

	public static TupleElementSyntax TupleElement(TypeSyntax @type, SyntaxToken @identifier)
	{
		return SyntaxFactory.TupleElement(@type, @identifier);
	}

	public static TupleElementSyntax TupleElement(TypeSyntax @type)
	{
		return SyntaxFactory.TupleElement(@type);
	}

	public static OmittedTypeArgumentSyntax OmittedTypeArgument(SyntaxToken @omittedTypeArgumentToken)
	{
		return SyntaxFactory.OmittedTypeArgument(@omittedTypeArgumentToken);
	}

	public static OmittedTypeArgumentSyntax OmittedTypeArgument()
	{
		return SyntaxFactory.OmittedTypeArgument();
	}

	public static RefTypeSyntax RefType(SyntaxToken @refKeyword, SyntaxToken @readOnlyKeyword, TypeSyntax @type)
	{
		return SyntaxFactory.RefType(@refKeyword, @readOnlyKeyword, @type);
	}

	public static RefTypeSyntax RefType(TypeSyntax @type)
	{
		return SyntaxFactory.RefType(@type);
	}

	public static ParenthesizedExpressionSyntax ParenthesizedExpression(SyntaxToken @openParenToken, ExpressionSyntax @expression, SyntaxToken @closeParenToken)
	{
		return SyntaxFactory.ParenthesizedExpression(@openParenToken, @expression, @closeParenToken);
	}

	public static ParenthesizedExpressionSyntax ParenthesizedExpression(ExpressionSyntax @expression)
	{
		return SyntaxFactory.ParenthesizedExpression(@expression);
	}

	public static TupleExpressionSyntax TupleExpression(SyntaxToken @openParenToken, SeparatedSyntaxList<ArgumentSyntax> @arguments, SyntaxToken @closeParenToken)
	{
		return SyntaxFactory.TupleExpression(@openParenToken, @arguments, @closeParenToken);
	}

	public static TupleExpressionSyntax TupleExpression(SeparatedSyntaxList<ArgumentSyntax> @arguments)
	{
		return SyntaxFactory.TupleExpression(@arguments);
	}

	public static PrefixUnaryExpressionSyntax PrefixUnaryExpression(SyntaxKind @kind, SyntaxToken @operatorToken, ExpressionSyntax @operand)
	{
		return SyntaxFactory.PrefixUnaryExpression(@kind, @operatorToken, @operand);
	}

	public static PrefixUnaryExpressionSyntax PrefixUnaryExpression(SyntaxKind @kind, ExpressionSyntax @operand)
	{
		return SyntaxFactory.PrefixUnaryExpression(@kind, @operand);
	}

	public static AwaitExpressionSyntax AwaitExpression(SyntaxToken @awaitKeyword, ExpressionSyntax @expression)
	{
		return SyntaxFactory.AwaitExpression(@awaitKeyword, @expression);
	}

	public static AwaitExpressionSyntax AwaitExpression(ExpressionSyntax @expression)
	{
		return SyntaxFactory.AwaitExpression(@expression);
	}

	public static PostfixUnaryExpressionSyntax PostfixUnaryExpression(SyntaxKind @kind, ExpressionSyntax @operand, SyntaxToken @operatorToken)
	{
		return SyntaxFactory.PostfixUnaryExpression(@kind, @operand, @operatorToken);
	}

	public static PostfixUnaryExpressionSyntax PostfixUnaryExpression(SyntaxKind @kind, ExpressionSyntax @operand)
	{
		return SyntaxFactory.PostfixUnaryExpression(@kind, @operand);
	}

	public static MemberAccessExpressionSyntax MemberAccessExpression(SyntaxKind @kind, ExpressionSyntax @expression, SyntaxToken @operatorToken, SimpleNameSyntax @name)
	{
		return SyntaxFactory.MemberAccessExpression(@kind, @expression, @operatorToken, @name);
	}

	public static MemberAccessExpressionSyntax MemberAccessExpression(SyntaxKind @kind, ExpressionSyntax @expression, SimpleNameSyntax @name)
	{
		return SyntaxFactory.MemberAccessExpression(@kind, @expression, @name);
	}

	public static ConditionalAccessExpressionSyntax ConditionalAccessExpression(ExpressionSyntax @expression, SyntaxToken @operatorToken, ExpressionSyntax @whenNotNull)
	{
		return SyntaxFactory.ConditionalAccessExpression(@expression, @operatorToken, @whenNotNull);
	}

	public static ConditionalAccessExpressionSyntax ConditionalAccessExpression(ExpressionSyntax @expression, ExpressionSyntax @whenNotNull)
	{
		return SyntaxFactory.ConditionalAccessExpression(@expression, @whenNotNull);
	}

	public static MemberBindingExpressionSyntax MemberBindingExpression(SyntaxToken @operatorToken, SimpleNameSyntax @name)
	{
		return SyntaxFactory.MemberBindingExpression(@operatorToken, @name);
	}

	public static MemberBindingExpressionSyntax MemberBindingExpression(SimpleNameSyntax @name)
	{
		return SyntaxFactory.MemberBindingExpression(@name);
	}

	public static ElementBindingExpressionSyntax ElementBindingExpression(BracketedArgumentListSyntax @argumentList)
	{
		return SyntaxFactory.ElementBindingExpression(@argumentList);
	}

	public static ElementBindingExpressionSyntax ElementBindingExpression()
	{
		return SyntaxFactory.ElementBindingExpression();
	}

	public static ImplicitElementAccessSyntax ImplicitElementAccess(BracketedArgumentListSyntax @argumentList)
	{
		return SyntaxFactory.ImplicitElementAccess(@argumentList);
	}

	public static ImplicitElementAccessSyntax ImplicitElementAccess()
	{
		return SyntaxFactory.ImplicitElementAccess();
	}

	public static BinaryExpressionSyntax BinaryExpression(SyntaxKind @kind, ExpressionSyntax @left, SyntaxToken @operatorToken, ExpressionSyntax @right)
	{
		return SyntaxFactory.BinaryExpression(@kind, @left, @operatorToken, @right);
	}

	public static BinaryExpressionSyntax BinaryExpression(SyntaxKind @kind, ExpressionSyntax @left, ExpressionSyntax @right)
	{
		return SyntaxFactory.BinaryExpression(@kind, @left, @right);
	}

	public static AssignmentExpressionSyntax AssignmentExpression(SyntaxKind @kind, ExpressionSyntax @left, SyntaxToken @operatorToken, ExpressionSyntax @right)
	{
		return SyntaxFactory.AssignmentExpression(@kind, @left, @operatorToken, @right);
	}

	public static AssignmentExpressionSyntax AssignmentExpression(SyntaxKind @kind, ExpressionSyntax @left, ExpressionSyntax @right)
	{
		return SyntaxFactory.AssignmentExpression(@kind, @left, @right);
	}

	public static ConditionalExpressionSyntax ConditionalExpression(ExpressionSyntax @condition, SyntaxToken @questionToken, ExpressionSyntax @whenTrue, SyntaxToken @colonToken, ExpressionSyntax @whenFalse)
	{
		return SyntaxFactory.ConditionalExpression(@condition, @questionToken, @whenTrue, @colonToken, @whenFalse);
	}

	public static ConditionalExpressionSyntax ConditionalExpression(ExpressionSyntax @condition, ExpressionSyntax @whenTrue, ExpressionSyntax @whenFalse)
	{
		return SyntaxFactory.ConditionalExpression(@condition, @whenTrue, @whenFalse);
	}

	public static ThisExpressionSyntax ThisExpression(SyntaxToken @token)
	{
		return SyntaxFactory.ThisExpression(@token);
	}

	public static ThisExpressionSyntax ThisExpression()
	{
		return SyntaxFactory.ThisExpression();
	}

	public static BaseExpressionSyntax BaseExpression(SyntaxToken @token)
	{
		return SyntaxFactory.BaseExpression(@token);
	}

	public static BaseExpressionSyntax BaseExpression()
	{
		return SyntaxFactory.BaseExpression();
	}

	public static LiteralExpressionSyntax LiteralExpression(SyntaxKind @kind, SyntaxToken @token)
	{
		return SyntaxFactory.LiteralExpression(@kind, @token);
	}

	public static LiteralExpressionSyntax LiteralExpression(SyntaxKind @kind)
	{
		return SyntaxFactory.LiteralExpression(@kind);
	}

	public static MakeRefExpressionSyntax MakeRefExpression(SyntaxToken @keyword, SyntaxToken @openParenToken, ExpressionSyntax @expression, SyntaxToken @closeParenToken)
	{
		return SyntaxFactory.MakeRefExpression(@keyword, @openParenToken, @expression, @closeParenToken);
	}

	public static MakeRefExpressionSyntax MakeRefExpression(ExpressionSyntax @expression)
	{
		return SyntaxFactory.MakeRefExpression(@expression);
	}

	public static RefTypeExpressionSyntax RefTypeExpression(SyntaxToken @keyword, SyntaxToken @openParenToken, ExpressionSyntax @expression, SyntaxToken @closeParenToken)
	{
		return SyntaxFactory.RefTypeExpression(@keyword, @openParenToken, @expression, @closeParenToken);
	}

	public static RefTypeExpressionSyntax RefTypeExpression(ExpressionSyntax @expression)
	{
		return SyntaxFactory.RefTypeExpression(@expression);
	}

	public static RefValueExpressionSyntax RefValueExpression(SyntaxToken @keyword, SyntaxToken @openParenToken, ExpressionSyntax @expression, SyntaxToken @comma, TypeSyntax @type, SyntaxToken @closeParenToken)
	{
		return SyntaxFactory.RefValueExpression(@keyword, @openParenToken, @expression, @comma, @type, @closeParenToken);
	}

	public static RefValueExpressionSyntax RefValueExpression(ExpressionSyntax @expression, TypeSyntax @type)
	{
		return SyntaxFactory.RefValueExpression(@expression, @type);
	}

	public static CheckedExpressionSyntax CheckedExpression(SyntaxKind @kind, SyntaxToken @keyword, SyntaxToken @openParenToken, ExpressionSyntax @expression, SyntaxToken @closeParenToken)
	{
		return SyntaxFactory.CheckedExpression(@kind, @keyword, @openParenToken, @expression, @closeParenToken);
	}

	public static CheckedExpressionSyntax CheckedExpression(SyntaxKind @kind, ExpressionSyntax @expression)
	{
		return SyntaxFactory.CheckedExpression(@kind, @expression);
	}

	public static DefaultExpressionSyntax DefaultExpression(SyntaxToken @keyword, SyntaxToken @openParenToken, TypeSyntax @type, SyntaxToken @closeParenToken)
	{
		return SyntaxFactory.DefaultExpression(@keyword, @openParenToken, @type, @closeParenToken);
	}

	public static DefaultExpressionSyntax DefaultExpression(TypeSyntax @type)
	{
		return SyntaxFactory.DefaultExpression(@type);
	}

	public static TypeOfExpressionSyntax TypeOfExpression(SyntaxToken @keyword, SyntaxToken @openParenToken, TypeSyntax @type, SyntaxToken @closeParenToken)
	{
		return SyntaxFactory.TypeOfExpression(@keyword, @openParenToken, @type, @closeParenToken);
	}

	public static TypeOfExpressionSyntax TypeOfExpression(TypeSyntax @type)
	{
		return SyntaxFactory.TypeOfExpression(@type);
	}

	public static SizeOfExpressionSyntax SizeOfExpression(SyntaxToken @keyword, SyntaxToken @openParenToken, TypeSyntax @type, SyntaxToken @closeParenToken)
	{
		return SyntaxFactory.SizeOfExpression(@keyword, @openParenToken, @type, @closeParenToken);
	}

	public static SizeOfExpressionSyntax SizeOfExpression(TypeSyntax @type)
	{
		return SyntaxFactory.SizeOfExpression(@type);
	}

	public static InvocationExpressionSyntax InvocationExpression(ExpressionSyntax @expression, ArgumentListSyntax @argumentList)
	{
		return SyntaxFactory.InvocationExpression(@expression, @argumentList);
	}

	public static InvocationExpressionSyntax InvocationExpression(ExpressionSyntax @expression)
	{
		return SyntaxFactory.InvocationExpression(@expression);
	}

	public static ElementAccessExpressionSyntax ElementAccessExpression(ExpressionSyntax @expression, BracketedArgumentListSyntax @argumentList)
	{
		return SyntaxFactory.ElementAccessExpression(@expression, @argumentList);
	}

	public static ElementAccessExpressionSyntax ElementAccessExpression(ExpressionSyntax @expression)
	{
		return SyntaxFactory.ElementAccessExpression(@expression);
	}

}
}
