using System;

namespace AppDosNumeros
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num1, num2, suma, diferencia, producto, division;
			Console.WriteLine ("PROGRAMA MAYOR DE DOS NUMEROS");
			Console.WriteLine ("Lea Numero 1:");
			num1 = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Lea Numero 2:");
			num2 = int.Parse (Console.ReadLine ());
			if (num1>num2)
			{
				suma=num1+num2;
				diferencia=num1-num2;
				Console.WriteLine ("La suma es:"+suma);
				Console.WriteLine ("La diferencia es:"+diferencia);

			}
			else
			{
				producto=num1*num2;
				division=num1/num2;
				Console.WriteLine ("El producto es:"+producto);
				Console.WriteLine ("La division es:"+division);
			}
			Console.ReadKey ();
		
	}
	}
}
