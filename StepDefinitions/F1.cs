namespace BDD.StepDefinitions
{
    [Binding]
    internal class F1
    {
        [Given(@"open chrome")]
        public void GivenOpenChrome()
        {
            Console.WriteLine("Open Chrome");
        }

        [Given(@"B")]
        public void GivenB()
        {
            Console.WriteLine("B");
        }

        [When(@"C")]
        public void WhenC()
        {
            Console.WriteLine("C");
        }

        [Then(@"D")]
        public void ThenD()
        {
            Console.WriteLine("D");
        }

    }
}
