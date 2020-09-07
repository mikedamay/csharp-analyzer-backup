using System.Collections.Generic;
using static Exercism.Analyzers.CSharp.Analyzers.Shared.SharedComments;
using static Exercism.Analyzers.CSharp.Analyzers.TwoFer.TwoFerComments;

namespace Exercism.Analyzers.CSharp.Analyzers.TwoFer
{
    internal static class TwoFerAnalyzer
    {
        public static SolutionAnalysis Analyze(ParsedSolution parsedSolution) =>
            Analyze(TwoFerSolutionParser.Parse(parsedSolution));

        private static SolutionAnalysis Analyze(TwoFerSolution twoFerSolution) =>
            twoFerSolution.DisapproveWhenInvalid() ??
            twoFerSolution.ApproveWhenValid() ??
            twoFerSolution.ReferToMentor();

        private static SolutionAnalysis? DisapproveWhenInvalid(this TwoFerSolution twoFerSolution)
        {
            if (twoFerSolution.UsesOverloads)
                return twoFerSolution.DisapproveWithComment(UseSingleFormattedStringNotMultiple);

            if (twoFerSolution.MissingSpeakMethod ||
                twoFerSolution.InvalidSpeakMethod)
                return twoFerSolution.DisapproveWithComment(FixCompileErrors);

            if (twoFerSolution.UsesDuplicateString)
                return twoFerSolution.DisapproveWithComment(UseSingleFormattedStringNotMultiple);

            if (twoFerSolution.NoDefaultValue)
                return twoFerSolution.DisapproveWithComment(UseDefaultValue);

            if (twoFerSolution.InvalidDefaultValue)
                return twoFerSolution.DisapproveWithComment(InvalidDefaultValue);

            if (twoFerSolution.UsesStringReplace)
                return twoFerSolution.DisapproveWithComment(UseStringInterpolationNotStringReplace);

            if (twoFerSolution.UsesStringJoin)
                return twoFerSolution.DisapproveWithComment(UseStringInterpolationNotStringJoin);

            if (twoFerSolution.UsesStringConcat)
                return twoFerSolution.DisapproveWithComment(UseStringInterpolationNotStringConcat);

            return null;
        }

        private static SolutionAnalysis? ApproveWhenValid(this TwoFerSolution twoFerSolution) =>
            twoFerSolution.AnalyzeSingleLine() ??
            twoFerSolution.AnalyzeParameterAssignment() ??
            twoFerSolution.AnalyzeVariableAssignment();

        public static bool? ReturnsStringInterpolationWithDefaultValueBest(TwoFerSolution twoFerSolution)
        {
            bool? returnsStringInterpolationWithDefaultValue =
                twoFerSolution.ReturnsStringInterpolationWithDefaultValue();
            bool? usesExpressionBody =
                twoFerSolution.UsesExpressionBody();
            if (returnsStringInterpolationWithDefaultValue is null || usesExpressionBody is null)
                return null;
            return returnsStringInterpolationWithDefaultValue.Value &&
                   usesExpressionBody.Value;
        }

        public static bool? ReturnsStringInterpolationWithDefaultValueWorst(TwoFerSolution twoFerSolution)
        {
            bool? returnsStringInterpolationWithDefaultValue =
                twoFerSolution.ReturnsStringInterpolationWithDefaultValue();
            bool? usesExpressionBody =
                twoFerSolution.UsesExpressionBody();
            if (returnsStringInterpolationWithDefaultValue is null || usesExpressionBody is null)
                return null;
            return returnsStringInterpolationWithDefaultValue.Value &&
                   !usesExpressionBody.Value;
        }

        public static bool? ReturnsStringInterpolationWithNullCoalescingOperatorBest(TwoFerSolution twoFerSolution)
        {
            bool? returnsStringInterpolationWithDefaultValue =
                twoFerSolution.ReturnsStringInterpolationWithNullCoalescingOperator();
            bool? usesExpressionBody =
                twoFerSolution.UsesExpressionBody();
            if (returnsStringInterpolationWithDefaultValue is null || usesExpressionBody is null)
                return null;
            return returnsStringInterpolationWithDefaultValue.Value &&
                   usesExpressionBody.Value;
        }

        public static bool? ReturnsStringInterpolationWithNullCoalescingOperatorWorst(TwoFerSolution twoFerSolution)
        {
            bool? returnsStringInterpolationWithDefaultValue =
                twoFerSolution.ReturnsStringInterpolationWithNullCoalescingOperator();
            bool? usesExpressionBody =
                twoFerSolution.UsesExpressionBody();
            if (returnsStringInterpolationWithDefaultValue is null || usesExpressionBody is null)
                return null;
            return returnsStringInterpolationWithDefaultValue.Value &&
                   !usesExpressionBody.Value;
        }

        public static List<ApprovalOperation> singleLine = new List<ApprovalOperation>
        {
            new ApprovalOperation(TwoFerSyntax.UsesSingleLine, MentorReaction.None, string.Empty, true),
            new ApprovalOperation(TwoFerAnalyzer.ReturnsStringInterpolationWithDefaultValueBest,
                MentorReaction.Approve, string.Empty),
            new ApprovalOperation(TwoFerAnalyzer.ReturnsStringInterpolationWithDefaultValueWorst,
                MentorReaction.ApproveWithComment, UseExpressionBodiedMember),
            new ApprovalOperation(TwoFerAnalyzer.ReturnsStringInterpolationWithNullCoalescingOperatorBest,
                MentorReaction.Approve, string.Empty),
            new ApprovalOperation(TwoFerAnalyzer.ReturnsStringInterpolationWithNullCoalescingOperatorWorst,
                MentorReaction.ApproveWithComment, UseExpressionBodiedMember),
            new ApprovalOperation(TwoFerSyntax.ReturnsStringInterpolationWithIsNullOrEmptyCheck,
                MentorReaction.ApproveWithComment,
                 UseNullCoalescingOperatorNotTernaryOperatorWithIsNullOrEmptyCheck),
            new ApprovalOperation(TwoFerSyntax.ReturnsStringInterpolationWithIsNullOrWhiteSpaceCheck,
                MentorReaction.ApproveWithComment, UseNullCoalescingOperatorNotTernaryOperatorWithIsNullOrWhiteSpaceCheck),
            new ApprovalOperation(TwoFerSyntax.ReturnsStringInterpolationWithNullCheck,
                MentorReaction.ApproveWithComment, UseNullCoalescingOperatorNotTernaryOperatorWithNullCheck),
            new ApprovalOperation(TwoFerSyntax.ReturnsStringConcatenation,
                MentorReaction.ApproveWithComment, UseStringInterpolationNotStringConcatenation),
            new ApprovalOperation(TwoFerSyntax.ReturnsStringFormat,
                MentorReaction.ApproveWithComment, UseStringInterpolationNotStringFormat),
        };

        private static SolutionAnalysis? AnalyzeSingleLine(this TwoFerSolution twoFerSolution)
        {
            return ProcessSolution(twoFerSolution, singleLine);
        }

        public static List<ApprovalOperation> analyzeParameterAssignment = new List<ApprovalOperation>
        {
            new ApprovalOperation(TwoFerSyntax.AssignsToParameter, MentorReaction.None, string.Empty, true),
            new ApprovalOperation(TwoFerSyntax.AssignsParameterUsingKnownExpression, MentorReaction.ReferToMentor,
                string.Empty, true),
            new ApprovalOperation(TwoFerSyntax.ReturnsStringFormat, MentorReaction.ApproveWithComment,
                UseStringInterpolationNotStringFormat),
            new ApprovalOperation(TwoFerSyntax.ReturnsStringConcatenation, MentorReaction.ApproveWithComment,
                UseStringInterpolationNotStringConcatenation),
            new ApprovalOperation(TwoFerSyntax.AssignsParameterUsingNullCoalescingOperator,
                MentorReaction.ApproveWithComment, ReturnImmediately),
            new ApprovalOperation(TwoFerSyntax.AssignsParameterUsingNullCheck, MentorReaction.ApproveWithComment,
                UseNullCoalescingOperatorNotNullCheck),
            new ApprovalOperation(TwoFerSyntax.AssignsParameterUsingIfNullCheck, MentorReaction.ApproveWithComment,
                UseNullCoalescingOperatorNotNullCheck),
            new ApprovalOperation(TwoFerSyntax.AssignsParameterUsingIsNullOrEmptyCheck,
                MentorReaction.ApproveWithComment, UseNullCoalescingOperatorNotIsNullOrEmptyCheck),
            new ApprovalOperation(TwoFerSyntax.AssignsParameterUsingIfIsNullOrEmptyCheck,
                MentorReaction.ApproveWithComment, UseNullCoalescingOperatorNotIsNullOrEmptyCheck),
            new ApprovalOperation(TwoFerSyntax.AssignsParameterUsingIsNullOrWhiteSpaceCheck,
                MentorReaction.ApproveWithComment, UseNullCoalescingOperatorNotIsNullOrWhiteSpaceCheck),
            new ApprovalOperation(TwoFerSyntax.AssignsParameterUsingIfIsNullOrWhiteSpaceCheck,
                MentorReaction.ApproveWithComment, UseNullCoalescingOperatorNotIsNullOrWhiteSpaceCheck),
        };

        private static SolutionAnalysis? AnalyzeParameterAssignment(this TwoFerSolution twoFerSolution)
        {
            return ProcessSolution(twoFerSolution, analyzeParameterAssignment);
        }


        public static List<ApprovalOperation> variableAssignments = new List<ApprovalOperation>
        {
            new ApprovalOperation(TwoFerSyntax.AssignsVariable, MentorReaction.None, string.Empty, true),
            new ApprovalOperation(TwoFerSyntax.AssignsVariableUsingKnownInitializer, MentorReaction.ReferToMentor,
                string.Empty, true),
            new ApprovalOperation(TwoFerSyntax.ReturnsStringFormatWithVariable, MentorReaction.ApproveWithComment,
                UseStringInterpolationNotStringFormat),
            new ApprovalOperation(TwoFerSyntax.ReturnsStringConcatenationWithVariable,
                MentorReaction.ApproveWithComment, UseStringInterpolationNotStringConcatenation),
            new ApprovalOperation(TwoFerSyntax.ReturnsStringInterpolationWithVariable, MentorReaction.None,
                string.Empty, true),
            new ApprovalOperation(TwoFerSyntax.AssignsVariableUsingNullCoalescingOperator, MentorReaction.Approve,
                string.Empty),
            new ApprovalOperation(TwoFerSyntax.AssignsVariableUsingNullCheck, MentorReaction.ApproveWithComment,
                UseNullCoalescingOperatorNotTernaryOperatorWithNullCheck),
            new ApprovalOperation(TwoFerSyntax.AssignsVariableUsingIsNullOrEmptyCheck,
                MentorReaction.ApproveWithComment, UseNullCoalescingOperatorNotTernaryOperatorWithIsNullOrEmptyCheck),
            new ApprovalOperation(TwoFerSyntax.AssignsVariableUsingIsNullOrWhiteSpaceCheck,
                MentorReaction.ApproveWithComment,
                UseNullCoalescingOperatorNotTernaryOperatorWithIsNullOrWhiteSpaceCheck),
        };

        private static SolutionAnalysis? AnalyzeVariableAssignment(this TwoFerSolution twoFerSolution)
        {
            return ProcessSolution(twoFerSolution, variableAssignments);
        }

        public static SolutionAnalysis? ProcessSolution(TwoFerSolution twoFerSolution,
            List<ApprovalOperation> approvalOperations)
        {
            bool? MabyeNot(bool? res, bool not) => res switch
            {
                null => null,
                _ when not => !res,
                _ => res
            };

            foreach (var approvalAction in approvalOperations)
            {
                bool? result = MabyeNot(approvalAction.Condition(twoFerSolution), approvalAction.Not);
                if (result.HasValue && result.Value)
                {
                    return approvalAction.MentorReaction switch
                    {
                        MentorReaction.Approve => twoFerSolution.ApproveAsOptimal(),
                        MentorReaction.ApproveWithComment => twoFerSolution.ApproveWithComment(approvalAction.Comment),
                        MentorReaction.Disapprove => twoFerSolution.DisapproveWithComment(approvalAction.Comment),
                        MentorReaction.ReferToMentor => twoFerSolution.ReferToMentor(),
                        MentorReaction.None => null,
                        _ => null
                    };
                }
            }

            return null;
        }

        public enum MentorReaction
        {
            Approve,
            ApproveWithComment,
            Disapprove,
            ReferToMentor,
            None
        }

        public delegate bool? Condition(TwoFerSolution ts);

        public class ApprovalOperation
        {
            public Condition Condition { get; }
            public string Comment { get; }
            public MentorReaction MentorReaction { get; }
            public bool Not { get; }

            public ApprovalOperation(Condition cond,
                MentorReaction mentorReaction,
                string comment, bool not = false)
            {
                Condition = cond;
                Comment = comment;
                MentorReaction = mentorReaction;
                Not = not;
            }
        }
    }
}