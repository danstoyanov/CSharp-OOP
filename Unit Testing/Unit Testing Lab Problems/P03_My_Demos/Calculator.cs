using System.Linq;

namespace P03MyTestDemos.App
{
    public class Calculator
    {
        public int Sum(params int[] numbers) => numbers.Sum();
    }
}
