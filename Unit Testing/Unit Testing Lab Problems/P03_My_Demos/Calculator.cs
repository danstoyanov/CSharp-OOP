using System.Linq;

namespace P03MyTestDemos.App
{
    public class Calculator
    {
        public int Sum(params int[] numbers) => numbers.Sum();

        public int Product (params int[] numbers)
        {
            int result = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }

            return result;
        }
    }
}
