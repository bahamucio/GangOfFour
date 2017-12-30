using System;

namespace RealWorld
{
	/// <summary>
	/// Program startup class for Real-World
	/// Strategy Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            // Two contexts following different strategies
			SortedList studentRecords = new SortedList();

			studentRecords.Add("Samual");
			studentRecords.Add("Vivek");
			studentRecords.Add("Jimmy");
			studentRecords.Add("Sandra");
			studentRecords.Add("Anna");

			studentRecords.SetSortStrategy(new QuickSort());
			studentRecords.Sort();

			studentRecords.SetSortStrategy(new MergeSort());
			studentRecords.Sort();
			
			studentRecords.SetSortStrategy(new ShellSort());
			studentRecords.Sort();

			// Wait for user
			Console.ReadKey();
        }
    }
}
