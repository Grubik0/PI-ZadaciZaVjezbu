using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
					
public class Program
{
	public static void Main()
	{
		string[] mjeseci = new string[12];
		mjeseci[0]="siječanj";
		mjeseci[1]="veljača";
		mjeseci[2]="ožujak";
		mjeseci[3]="travanj";
		mjeseci[4]="svibanj";
		mjeseci[5]="lipanj";
		mjeseci[6]="srpanj";
		mjeseci[7]="kolovoz";
		mjeseci[8]="rujan";
		mjeseci[9]="listopad";
		mjeseci[10]="studeni";
		mjeseci[11]="prosinac";
		
		Console.Write("Datum rođenja: ");
		string ulaz = Console.ReadLine();
		string[] ulazL = new string[3];
		ulazL = ulaz.Split(' ');
		
		int danR = Convert.ToInt32(ulazL[0]);
		int mjesecR = 0;
		for(int i=0; i<12; i++) 
			if(ulazL[1] == mjeseci[i]) mjesecR = i+1;
		int godinaR = Convert.ToInt32(ulazL[2]);
		
		int godina = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
		int mjesec = Convert.ToInt32(DateTime.Now.ToString("MM"));
		int dan = Convert.ToInt32(DateTime.Now.ToString("dd"));
		
		if(mjesec>mjesecR)
			Console.WriteLine("Dana "+danR+"."+mjesecR+"."+godina+". ste napunili "+ (godina-godinaR)+" godina.");
		else if(mjesec==mjesecR){
			if(danR<=dan) Console.WriteLine("Dana "+danR+"."+mjesecR+"."+godina+". ste napunili "+ (godina-godinaR)+" godina.");
			else Console.WriteLine("Dana "+danR+"."+mjesecR+"."+godina+". ćete napuniti "+ (godina-godinaR)+" godina.");
		}
		else if(mjesec<mjesecR) Console.WriteLine("Dana "+danR+"."+mjesecR+"."+godina+". ćete napuniti "+ (godina-godinaR)+" godina.");
		
		Console.ReadLine();
	}
}