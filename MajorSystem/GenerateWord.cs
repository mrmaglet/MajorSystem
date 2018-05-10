using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorSystem
{
	public class Major
	{
		public static void GenerateWord()
		{

			var consonant1 = "g";
			var consonant2 = "n";

			List<string> vowels = new List<string>();

			vowels.Add("a");
			vowels.Add("e");
			vowels.Add("i");
			vowels.Add("o");
			vowels.Add("u");
			vowels.Add("y");
			vowels.Add("å");
			vowels.Add("ä");
			vowels.Add("ö");

			foreach (var vowel in vowels)
			{
				Console.Write(vowel);
				Console.WriteLine(consonant1);
			}

			foreach (var vowel in vowels)
			{
				Console.Write(consonant1);
				Console.WriteLine(vowel);
			}

			foreach (var vowel in vowels)
			{
				foreach (var vowel1 in vowels)
				{
					Console.Write(vowel);
					Console.Write(consonant1);
					Console.WriteLine(vowel1);
				}

			}

			///////////////////////////////////

			foreach (var vowel in vowels)
			{
				Console.Write(vowel);
				Console.Write(consonant1);
				Console.WriteLine(consonant2);
			}

			foreach (var vowel in vowels)
			{
				foreach (var vowel1 in vowels)
				{
					Console.Write(vowel);
					Console.Write(consonant1);
					Console.Write(vowel1);
					Console.WriteLine(consonant2);
				}

			}

			foreach (var vowel in vowels)
			{
				foreach (var vowel1 in vowels)
				{
					Console.Write(vowel);
					Console.Write(consonant1);
					Console.Write(consonant2);
					Console.WriteLine(vowel1);
				}
			}

			foreach (var vowel in vowels)
			{
				foreach (var vowel1 in vowels)
				{
					Console.Write(consonant1);
					Console.Write(consonant2);
					Console.Write(vowel);
					Console.WriteLine(vowel1);
				}
			}

			foreach (var vowel in vowels)
			{
				foreach (var vowel1 in vowels)
				{
					Console.Write(consonant1);
					Console.Write(vowel);
					Console.Write(consonant2);
					Console.WriteLine(vowel1);
				}
			}

			foreach (var vowel in vowels)
			{
				foreach (var vowel1 in vowels)
				{
					Console.Write(consonant1);
					Console.Write(vowel);
					Console.Write(vowel1);
					Console.WriteLine(consonant2);
				}
			}
		}
	}
}
