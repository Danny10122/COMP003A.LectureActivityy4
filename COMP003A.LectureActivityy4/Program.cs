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
        }
    }
}
