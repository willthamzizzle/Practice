using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

/*Roy wanted to increase his typing speed for programming contests. So, his friend advised him to type the 
 * sentence "The quick brown fox jumps over the lazy dog" repeatedly because it is a pangram. ( pangrams are 
 * sentences constructed by using every letter of the alphabet at least once. )

After typing the sentence several times, Roy became bored with it. So he started to look for other pangrams.

Given a sentence s, tell Roy if it is a pangram or not.

Input Format

Input consists of a line containing s.

Constraints 
Length of s can be atmost 103 (1≤|s|≤103) and it may contain spaces, lowercase and uppercase letters. 
Lowercase and uppercase instances of a letter are considered same.
 * */

namespace IsPangram
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			String theString = "This be here a string";

			theString = theString.ToLower ();

			// neat way of removing all whitespaces everywhere using regex
			theString = Regex.Replace(theString,  @"\s+", "");

			HashSet<char> abcSet = new HashSet<char> ();
			HashSet<char> inputString = new HashSet<char> ();

			for (char c = 'a'; c <= 'z'; c++) 
			{
				abcSet.Add (c);

			}

			foreach (char c in theString) 
			{
				inputString.Add (c);
				//Console.Write (c);
			}


			// intersects with saves the day again
			abcSet.IntersectWith (theString);

			if (abcSet.Count < 26)
				Console.Write ("not pangram");
			else if(abcSet.Count == 26)
				Console.Write ("pangram");

		}
	}
}
