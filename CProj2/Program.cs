using System;

namespace CProj2
{
	class Program
	{
		static void Main(string[] args)
		{

			//Variable For Inputs for Calc
			double input1 = 0;
			double input2 = 0;

			Console.Title = "Calc";
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write($"\n Name: ");
			Console.ResetColor();

			//Varible for Name | Takes input
			string name = Console.ReadLine();

			Console.WriteLine($" \n Hello {name} nice to meet you!\n");
			Console.Write(" Please Enter a Number: ");
			input1 = Convert.ToDouble(Console.ReadLine());

			Console.Write(" Please Enter another Number: ");
			input2 = Convert.ToDouble(Console.ReadLine());

			// int result = input1 * input2;  Could also use this instead and use + result

			Console.WriteLine($" Here is your calculation: {input1} * {input2} " +
			$"					\n Answer = " + input1 * input2);
			
		}
	}
}
