using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
					
public class Program
{
	public static void Main()
	{
		List<string> knjige = new List<string>();
		knjige.Add("Prstenova druzina;Dostupna");
		knjige.Add("Dvije kule;Dostupna");
		knjige.Add("Povratak kralja;Na posudbi");
		knjige.Add("Rat i mir;Dostupna");
		knjige.Add("Zlocin i kazna;Na posudbi");
		knjige.Add("Jadnici;Dostupna");
		
		string ulaz = " ";
		do{
		Console.WriteLine("Naredba: ");
		ulaz = Console.ReadLine();
		string knjiga = "";
		
		List<string> naredba = new List<string>();
		if(ulaz != "#exit" && ulaz.Substring(0,7)=="#status"){
			naredba.AddRange(ulaz.Split(' '));
			for(int i = 1; i<naredba.Count(); i++)
				if(i!=naredba.Count()-1) knjiga += naredba[i]+" ";
				else knjiga += naredba[i];
			
			bool zastava = true;
			for(int j = 0; j<knjige.Count(); j++){
				if(knjiga == knjige[j].Substring(0, knjiga.Length)){
					zastava = false;
					if(knjige[j].Substring((knjiga.Length)+1)=="Dostupna")
						Console.WriteLine("Knjiga "+knjiga+" je dostupna.");
					else Console.WriteLine("Knjiga "+knjiga+" nije dostupna.");
				}	
			}
			if(zastava == true) Console.WriteLine("Ta knjiga ne postoji!");
			Console.WriteLine("------------------------------");	
		}	
		}while(ulaz != "#exit");
		
		Console.Clear();
		
	}
}