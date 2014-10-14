using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

/*
 * You are given a string of lowercase letters. Your task is to figure out the index of the character on whose 
 * removal will make the string a palindrome. There will always be a valid solution. 

In case string is already palindrome, then -1 is also a valid answer along with possible indices.

Input Format 
The first line contains T i.e. number of test cases.
T lines follow, each line containing a string.

Output Format 
Print the position ( 0 index ) of the letter by removing which the string turns into a palindrome. For string, such as

bcbc
we can remove b at index 0 or c at index 3. Both the answers are accepted.
 * */


namespace PalindromeIndex
{
	class MainClass
	{
		public static String Reverse(String s)
		{
			char[] chars = s.ToCharArray ();

			// s.lenght / 2 because first and last indexes are moved at the same time
			for (int i = 0; i < s.Length / 2; i++) 
			{
				char c = chars [i];
				chars [i] = chars [s.Length - 1];
				chars [s.Length - 1] = c; 
			}

			return new string (chars);
		}


		public static void Main (string[] args)
		{
			

			try
			{
				using (StreamReader theStream = new StreamReader("PalindromeText.txt"))
				{
					int number = int.Parse(theStream.ReadLine());
					int i, j;

					while(number > 0)
					{
						string theString = "hgygsvlfcwnswtuhmyaljkqlqjjqlqkjlaymhutwsnwcwflvsgygh"; //theStream.ReadLine();
						j = theString.Length - 1;
						i = 0;

						while(i < j)
						{
							//move indices toward each other and test
							if (theString[i] == theString[j])
							{
								i++;
								j--;
							}
							else if (theString[i+1] == theString[j])
							{
								// If there is s palindrome then print out the first index
								i++;
								Console.WriteLine(i);
								//break;
							}
							else
							{
								// If we get here then that means the last letter need to be removed to make it a palindrome
								//If there is a palindrome then print out the last index number
								Console.WriteLine(j);
								//break;
							}
						}
						number--;
						// If it is already a palindrome then write -1;
						if (!(i<j))
							Console.WriteLine("-1");
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
