using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

/*
 * Sunny and Johnny together have M dollars and want to spend the amount at an ice cream parlour. 
 * The parlour offers N flavors, and they want to choose 2 flavors so that they end up spending the whole amount.

You are given a list of cost of these N flavors. The cost of ith flavor is denoted by (ci). 
You have to display the indices of two flavors whose sum is M.

Input Format

The first line of the input contains T, T test cases follow. 
Each test case follows the format: The first line contains M. The second line contains N. The third line 
contains N single space separated integers denoting the price of each flavor. Here, ith integer denotes ci.

Output Format

Output two integers, each of which is a valid index of the flavor. The lower index must be printed first. 
Indices are indexed from 1 to N.

Constraints

1 ≤ T ≤ 50 
2 ≤ M ≤ 10000 
2 ≤ N ≤ 10000 
1 ≤ ci ≤ 10000 
The prices of two items may be same and each test case has a unique solution.
 * 
 */

namespace IceCreamParlor
{
	class MainClass
	{

		public static void Solve (int sum, int[] theFlavors){

			for (int i = 0; i < theFlavors.Length; i++) {
				for (int j = i; j < theFlavors.Length; j++) {
					if (i == j)
						continue;
					if (theFlavors [i] + theFlavors [j] > sum) {
						continue;
					}
					else{

							if ((theFlavors [i] + theFlavors [j]) == sum) {

								Console.WriteLine ((i+1) + " " + (j+1));
							}
					}

				}
			}

		}


		public static void Main (string[] args)
		{
			String path = "test.txt";
			int testCase = 0;
			int amount = 0;
			int numFlavors = 0;
			String flavors;


			using (StreamReader sReader = new StreamReader (path)) {


				testCase = int.Parse(sReader.ReadLine());

				while (testCase > 0) {

					amount = int.Parse (sReader.ReadLine ());
					numFlavors = int.Parse (sReader.ReadLine ());

					int[] intFlavors = new int[numFlavors];

					flavors = sReader.ReadLine ();
					String[] stringFlavors = flavors.Split ();

					for (int i = 0; i < numFlavors; i++) {
						intFlavors [i] = int.Parse (stringFlavors [i]);
					}

					Solve (amount, intFlavors);
					testCase--;
				}


				/*
				 * int testCase = int.Parse(Console.ReadLine());


				while (testCase > 0) {

			        int amount = int.Parse(Console.ReadLine());
			        int numFlavors = int.Parse(Console.ReadLine());
			        String flavors;
                    
					int[] intFlavors = new int[numFlavors];

					flavors = Console.ReadLine ();
					String[] stringFlavors = flavors.Split ();

					for (int i = 0; i < numFlavors; i++) {
						intFlavors [i] = int.Parse (stringFlavors [i]);
					}

					Solve (amount, intFlavors);
					testCase--;
				}
				*/


			}


		}
	}
}
