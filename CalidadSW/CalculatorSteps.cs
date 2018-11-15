using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample2;

namespace CalidadSW
{
    [Binding]
    public class CalculatorSteps
    {
        private Calculator calc = new Calculator();
        private int result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int firstNum)
        {
            calc.FirstNumber = firstNum;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int secondNum)
        {
            calc.SecondNumber = secondNum;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calc.Add();
        }

        [When(@"I press substract")]
        public void WhenIPressSubstract()
        {
            result = calc.substract();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            result = calc.multiply();
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            result = calc.divide();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }

        [When(@"I press divide by cero")]
        public void WhenIPressDivideByCero()
        {
            try
            {
                result = calc.divide();
            }
            catch(ArithmeticException ex) {
                ScenarioContext.Current["Error"] = ex;
            }

           
        }

        [Then(@"it should throw an exception")]
        public void ThenItShouldThrowAnException()
        {
            if (ScenarioContext.Current.ContainsKey("Error")) {
                System.Console.WriteLine(ScenarioContext.Current.ContainsKey("Error"));
            }
            Assert.IsTrue(ScenarioContext.Current.ContainsKey("Error"));
        }

    }
}
