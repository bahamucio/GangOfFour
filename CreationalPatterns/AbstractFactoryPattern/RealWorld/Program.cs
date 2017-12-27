﻿using System;

namespace RealWorld
{
	/// <summary>
	/// Program startup class for Real-World
	/// Abstract Factory Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point to the console application
		/// </summary>
        static void Main(string[] args)
        {
            // Create and run the African animal world
			ContinentFactory africa = new AfricaFactory();
			AnimalWorld world = new AnimalWorld(africa);
			world.RunFoodChain();

			// Create and run the American animal world
			ContinentFactory america = new AmericaFactory();
			world = new AnimalWorld(america);
			world.RunFoodChain();

			// Wait for the user input
			Console.ReadLine();
        }
    }
}
