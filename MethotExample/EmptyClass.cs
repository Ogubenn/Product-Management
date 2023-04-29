using System;
namespace MethotExample
{
	public class EmptyClass
	{
		public EmptyClass()
		{
			Console.WriteLine("Ogu");
		}

		public void metot()
		{
			string deger = "Asdasd";
			deger = deger.Substring(5);
			deger = deger.Substring(0, 4);
		}
		public void metot(int deger)
		{
			Console.WriteLine("Gelen değer int");
		}
		public void metot(string deger)
		{
			Console.WriteLine("Gelen değer string");
		}

	}
}

