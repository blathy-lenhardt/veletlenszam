using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veletlenszam
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// VÉLETLEN SZÁMOK ELŐÁLLÍTÁSA

			/* Létre kell hoznunk egy Random objektumot névvel ellátva:
			 *	Random név = new Random();
			 *
			 * Egész számok generálásakkor a név.Next() függvényt kell használni,
			 *	melyet, ha üresen hagyunk, akkor egy tetszőleges int szám fog generálódni.
			 *
			 * A zárójelen belül megadhatunk egy intervallumot is, pl. név.Next(0,11)
			 * Ebben az esetben az első szám mondja meg a minimális még generálható értéket, az második szám a már nem generálható értéket.
			 * 
			 * név.Next(11) -> a 11 az előállítható számok darabszámát adja meg, ezért 0-tól indulva mindig a zárójelben megadott érték -1 lehet a legnagyobb szám.
			 * 
			 * név.Next(-50, 51) -> [-50,50]
			 * 
			 * Azért, hogy megmaradjon ez a generált szám, el kell tárolni egy változóban:
			 *	int veletlenszam = név.Next(11);
			 *	
			 * Nem egész számok véletlenszerű előállítása:
			 *	double veletlenszam = név.Next(11)/100;
			 *
			 * Valós számok generálása: név.NextDouble();
			 * Alapértelmezetten 0.0 és 1.0 közé fog generálni számokat.
			 * 
			 * 0 és 100 között generáljon valós számokat, akkor szorozzuk meg 100-al:
			 *	double veletlenszam = név.NextDouble()*100;
			 */

			// 1. feladat: Állítsunk elő véletlenszerűen két egész számot a [0,10] tartományból, és írjuk ki a számokat a képernyőre,
			//	majd azt, hogy melyik szám a nagyobb! Ha egyenlő, írjuk ki "A két szám egyenlő" szöveget!
			Random rnd = new Random();
			int[] randomNums = { 0, 0 };
			Console.WriteLine("1. feladat");
			randomNums[0] = rnd.Next(0, 11);
			randomNums[1] = rnd.Next(0, 11);
			Console.WriteLine("num1 = {0}\nnum2 = {1}", randomNums[0], randomNums[1]);
			if (randomNums[0] > randomNums[1])
			{
				Console.WriteLine("{0} > {1}", randomNums[0], randomNums[1]);
			}
			else if (randomNums[1] > randomNums[0])
			{
				Console.WriteLine("{0} > {1}", randomNums[1], randomNums[0]);
			}
			else
			{
				Console.WriteLine("A két szám egyenlő");
			}
		}
	}
}
