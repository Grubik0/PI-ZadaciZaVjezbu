using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
					
public class Program
{
	public static void Main()
	{
		string[] ulaz = new string[6];
		ulaz[0]="ARG 1:1 ISL";
		ulaz[1]="HRV 2:0 NIG";
		ulaz[2]="ARG 0:3 HRV";
		ulaz[3]="NIG 2:0 ISL";
		ulaz[4]="NIG 1:2 ARG";
		ulaz[5]="ISL 1:2 HRV";
		
		string[] domacin = new string[6];
		string[] rezultat = new string[6];
		string[] gost = new string[6];
		
		int i = 0;
		foreach(string elem in ulaz){
			domacin[i] = elem.Substring(0,3);
			rezultat[i] = elem.Substring(4,3);
			gost[i] = elem.Substring(8,3);
			i++;
		}
		
		Console.Write("Oznaka reprezentacije: ");
		string unos = Console.ReadLine();
		
		for(int j = 0; j<6; j++){
			if(unos==domacin[j]) Console.WriteLine(domacin[j]+" "+rezultat[j]+" "+gost[j]);
			else if(unos==gost[j]) Console.WriteLine(gost[j]+" "+rezultat[j][2]+rezultat[j][1]+rezultat[j][0]+" "+domacin[j]);
		}
					  
		Console.ReadLine();
	}
}