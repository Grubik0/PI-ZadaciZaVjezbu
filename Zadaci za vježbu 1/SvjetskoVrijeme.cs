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
		ulaz[0]="Santiago;-4";
		ulaz[1]="Salvador;-3";
		ulaz[2]="London;+0";
		ulaz[3]="Zagreb;+1";
		ulaz[4]="Damask;+2";
		ulaz[5]="Istanbul;+3";
		
		string[] gradovi = new string[6];
		int[] sati = new int[6];
		for(int i = 0; i<6; i++){
			gradovi[i] = ulaz[i].Substring(0,(ulaz[i].Length)-3);
		
			if(ulaz[i][(ulaz[i].Length)-2]=='+') sati[i] = Convert.ToInt32(ulaz[i][(ulaz[i].Length)-1]);
			else sati[i] = 0-Convert.ToInt32(ulaz[i][(ulaz[i].Length)-1]);
			Console.WriteLine("Vrijeme "+gradovi[i]+": "+DateTime.Now.AddHours(sati[i]).ToString("hh:mm"));
		}
		
		
		
		Console.ReadLine();
	}
}