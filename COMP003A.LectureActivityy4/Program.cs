using System.Diagnostics.Metrics;

namespace COMP003A.LectureActivityy4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taskNumber = 1;

            while (taskNumber <= 5)
            {
                Console.WriteLine("Task " + taskNumber + " completed");
                taskNumber++;
            }

            Console.WriteLine("\n");

            int attempt = 1;

            do
            {
                Console.WriteLine($"Attempt {attempt}");
                attempt++;
            }
            while (attempt <= 3);

            Console.WriteLine("\n");

            for(int i = 1; i <=4; i++)
            {
                Console.WriteLine($"Step {i}");
            }

            int number = 0;

            while (number <= 6)
            {
                number++;

                if (number == 4)
                {
                    continue;
                }

                if (number == 6)
                {
                    break;
                }

                Console.WriteLine(number);

            }

            /*
            1. Which loop type was easiest for you to understand?
            The do-while loop for sure
            2.Which loop required the most careful tracing?
            The while loop control
            3.How did comments help you understand your loops?
            comments help you explain the purpose of the loop, helping you stay organized
            */
        }
    }
}
