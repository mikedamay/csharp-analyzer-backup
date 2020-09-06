using Xunit;

namespace Exercism.Analyzers.CSharp.IntegrationTests
{
    public partial class ExerciseAnalyzerTests
    {
        [Fact]
        public void Single()
        {
            var testSolution = new TestSolution(slug : "two-fer", name : "Twofer", directory : "Solutions/TwoFer/Invalid/MissingSpeakMethod");
            SolutionShouldBeCorrectlyAnalyzed(testSolution);
        }
    }
}