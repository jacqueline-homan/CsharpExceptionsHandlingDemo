using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CsharpErrorHandling
{
	class Program
	{
		static void Main (string[] args)
		{
			//Console.WriteLine ("Kiss my ass!");
			string errorMsg;
			int numerator;
			int denominator;
			int result;

			Console.WriteLine ("Enter numerator:");
			numerator = Int32.Parse (Console.ReadLine ());

			Console.WriteLine ();
			Console.WriteLine ("Enter denominator:");
			denominator = Int32.Parse (Console.ReadLine ());

			try
			{
				result = numerator / denominator;

				Console.WriteLine();
				Console.WriteLine("The result is: " + result);
			}
			catch (OverflowException ofEx) 
			{
				errorMsg = ofEx.Message;
				Console.WriteLine (errorMsg);
			}
			catch (DivideByZeroException dEx) 
			{
				errorMsg = dEx.Message;
				Console.WriteLine (errorMsg);
			}
			catch (Exception e) 
			{
				errorMsg = e.Message;
				Console.WriteLine (errorMsg);
			}
			finally
			{
				//cleanup code goes here
			}

		}
	}
}
