using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
					
public class Program
{
	public static void Main()
	{
		string[] ulaz = new string[7];
		ulaz[0]="HRV 2:0 NIG";
		ulaz[1]="HRV 3:0 ARG";
		ulaz[2]="HRV 2:1 ISL";
		ulaz[3]="HRV 1:1 DAN";
		ulaz[4]="HRV 2:2 RUS";
		ulaz[5]="HRV 2:1 ENG";
		ulaz[6]="HRV 2:4 FRA";
		
		Console.WriteLine("------------------------------");
		
		int pobjeda = 0;
		int remi = 0;
		int poraz = 0;
		string pom = "";
		int x = 0;
		int y = 0;
		
		foreach(string elem in ulaz){
			x = Convert.ToInt32(elem[4]);
			y = Convert.ToInt32(elem[6]);
			
			if(x>y) pobjeda++;
			else if(x==y) remi++;
			else if(x<y) poraz++;
		}
		
		Console.WriteLine("Pobjede: "+pobjeda);
		Console.WriteLine("Poraz: "+poraz);
		Console.WriteLine("Remi: "+remi);
		
		Console.ReadLine();
		
	}
}