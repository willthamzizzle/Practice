using System;


/*
1.5 Implement a method to perform basic string compression using the counts of repeated characters. 
For example, the string aabcccccaaa would become a2blc5a3. If the "compressed" string would not become 
smaller than the original string, your method should return the original string.
*/

namespace StringCompression
{

	class MainClass
	{
		public static void Main (string[] args)
		{
			String theString = "aabcccccaaa";
			String newString = "";
			int count = 0;
			char last = theString.ToCharArray () [0];

			for (int i = 0; i < theString.Length; i++) 
			{
				if (theString.ToCharArray () [i] == last) 
				{
					//Console.Write (theString.ToCharArray ());
					count++;
				}
				else  
				{
					newString += last + "" + count;
					last = theString.ToCharArray () [i];
					count = 1;
				}

			}
			newString += last + "" + count;



			/*The runtime is 0(p + k2), where p is the size of the original string and k is the number 
			 * of character sequences. For example, if the string is aabccdeeaa, then there are six 
			 * character sequences. It's slow becausestring concatenation operates in 0(n2) time(see 
			 * StringBuffer in Chapter 1).
			*/


			if (theString.Length > newString.Length)
				Console.Write (newString);
			else
				Console.Write (theString);
		}
	}
}
