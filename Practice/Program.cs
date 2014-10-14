using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace Solution
{

	class Solution
	{
		public static void Solve(int number, List<String> lines)
		{

		}
		public static void Main (string[] args)
		{
			//string abc = "abcdefghijklmnopqrstuvwxyz";

			HashSet<char> theSet = new HashSet<char>();
			HashSet<char> currSet = new HashSet<char>();

			for (char c = 'a'; c <= 'z'; c++) 
			{
				theSet.Add (c);
			}

			try
			{
				using (StreamReader theStream = new StreamReader("EmptyTextFile.txt"))
				{
					/*
					while((line = theStream.ReadLine()) != null)
					{
						System.Console.WriteLine (line);
						counter++;
					}

					theStream.Close();
					System.Console.WriteLine("There were {0} lines.", counter);
					// Suspend the screen.
					System.Console.ReadLine();
					*/
					int number = int.Parse(theStream.ReadLine());
					String currentRocks;

					for (int i = 0; i < number; i++)
					{
						currSet.Clear();
						currentRocks = theStream.ReadLine();

						foreach( char c in currentRocks)
						{
							currSet.Add(c);
						}

						theSet.IntersectWith(currSet);
					}
					Console.Write(theSet.Count());

				}
			}
			catch(Exception e) 
			{
				Console.WriteLine("The file could not be read:");
				Console.WriteLine(e.Message);
			}
		}
	}
}
