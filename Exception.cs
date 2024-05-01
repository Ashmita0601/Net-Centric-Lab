using System;
namespace lab1
{
	public class Exception
	{
		public double Divide(double x, double y)
		{
			try
			{
				return( x / y);
			}
			catch(DivideByZeroException)
			{
				Console.WriteLine("Error: Division by 0");
				return 0;
			}
		}
	}
}

