using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


/*
 * Alice recently started learning about cryptography and found that anagrams are very useful. Two strings are anagrams of each 
 * other if they have same character set. For example strings "bacdc" and "dcbac" 
 * are anagrams, while strings "bacdc" and "dcbad" are not.

Alice decides on an encryption scheme involving 2 large strings where encryption is dependent on the minimum number of 
character deletions required to make the two strings anagrams. She need your help in finding out this number.

Given two strings (they can be of same or different length) help her in finding out the minimum number of character deletions 
required to make two strings anagrams. Any characters can be deleted from any of the strings.


Two strings will be anagram if count of characters in each of them will be same. So, Keep a count array for each of them and 
count number of occurrence of each of characters(a-z), finally suppose character c is occurring in A number of times in one 
string and B number of times in another, then we will have to do max(A,B) - min(A,B) number of deletion, and we have to do it 
for all the characters.
 * 
 */

namespace Anagram
{
	class MainClass
	{


		public static int Solve (String first, String Second)
		{
			int[] A = new int[26];
			int[] B = new int[26]; 

			char[] aChar = first.ToCharArray ();
			char[] bChar = Second.ToCharArray ();

			int num = 0;


			// Keep a count of what characters show up in each string
			for (int i = 0; i < first.Length; i++) {
				A [aChar [i] - 'a']++;

			}
			for (int i = 0; i < Second.Length; i++) {
				B [bChar [i] - 'a']++;
			}

			for (int i = 0; i < A.Length; i++) {

				num += Math.Max (A [i], B [i]) - Math.Min (A [i], B [i]);


			}

			Console.Write (num);
			return num;

		}



		public static void Main (string[] args)
		{

			String path = "data.txt";
			String line1, line2;


			// in future iteration, try and do the exception handling first instead of last.

			//line1 = Console.ReadLine ();
			//line2 = Console.ReadLine ();

			//Solve (line1, line2);


			try
			{

				using(StreamReader theStreamReader = new StreamReader(path))
				{
					while(theStreamReader.Peek() >= 0)
					{
						//Console.WriteLine(theStreamReader.ReadLine());
						line1 = theStreamReader.ReadLine();
						line2 = theStreamReader.ReadLine();

						Solve(line1, line2);
					}


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
