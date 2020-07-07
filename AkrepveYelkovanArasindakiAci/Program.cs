using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkrepveYelkovanArasindakiAci
{
	class Program
	{
		static void Main(string[] args)
		{
			int akrep;
			int yelkovan;

			Console.Write("Akrep Değeri: ");
			akrep = Convert.ToInt32(Console.ReadLine());

			Console.Write("Yelkovan Değeri: ");
			yelkovan = Convert.ToInt32(Console.ReadLine());

			AciHesapla(akrep, yelkovan);

			Console.ReadKey();
		}

		static void AciHesapla(int akrep, int yelkovan)
		{
			//12 saatlik bir tur => 360°
			//Akrep 1 saatlik değişimi => 360 / 12 = 30°
			//Yelkovan 1 dakikalık değişimi => 360 / 60 = 6°
			//Yelkovan 1 dk lık değişimi sonucu akrep değişim oranı => 5 / 60 = 1/12°

			double aciSonuc = 0;
			double aci1 = 0;
			double aci2 = 0;
			double aci3 = 0;

			if (akrep>12)
			{
				akrep -= 12;
			}
			aci1 = akrep * 30;
			aci2 = yelkovan * 6;
			aci3 = Math.Abs(360 - aci1 + aci2 - (aci1 * (1 / 12)) - yelkovan / 2);
			aciSonuc = aci3 % 360;

			if (aciSonuc > 180)
			{
				aciSonuc = Math.Abs(aciSonuc - 360);
			}

			Console.WriteLine("\nSaat " + akrep + ":" + yelkovan + " olduğunda, arasındaki açı => " + aciSonuc);
		}
	}
}
