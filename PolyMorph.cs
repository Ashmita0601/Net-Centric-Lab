using System;
namespace lab1
{
	public class StaticPolyMorph
	{
		public void Print(int num)
		{
			Console.WriteLine("int : {0}",num);
		}

        public void Print(string str)
        {
            Console.WriteLine("String : {0}", str);
        }
    }

	// Showing dynamic polymorhism using method overriding
	public class Animal
	{
		public void Speak(string voice)
		{
			Console.WriteLine("An animal {0}ed", voice);
		}
	}

	public class Dog:Animal
	{
		public void Speak()
		{
			Console.WriteLine("A dog barked");
		}
	}
}

