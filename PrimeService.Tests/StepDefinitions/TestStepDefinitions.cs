using FluentAssertions;
using TechTalk.SpecFlow;

namespace Gims.API.Integration.Test.StepDefinitions
{
    [Binding]
    public class TestStepDefinitions
    {
        private int _num1;
        private int _num2;
        private int _result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int num)
        {
            _num1 = num;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int num)
        {
            _num2 = num;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _num1 + _num2;
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            _result.Should().Be(result);
        }
    }
}
