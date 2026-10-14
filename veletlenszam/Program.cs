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
		}
	}
}
