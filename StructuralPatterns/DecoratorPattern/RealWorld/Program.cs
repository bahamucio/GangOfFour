using System;

namespace RealWorld
{
	/// <summary>
	/// Program startup class for Real-World
	/// Decorator Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            // Create a book
			Book book = new Book("Worley", "Inside ASP.NET", 10);
			book.Display();
	
			// Create a video
			Video video = new Video("Spielberg", "Jaws", 23, 92);
			video.Display();
	
			// Make the video borrowable then borrow and display
			Console.WriteLine("\nMaking the video borrowable:");

			Borrowable borrowVideo = new Borrowable(video);
			borrowVideo.BorrowItem("Customer #1");
			borrowVideo.BorrowItem("Customer #2");
			
			borrowVideo.Display();

			// Wait for user
			Console.ReadKey();
        }
    }
}
