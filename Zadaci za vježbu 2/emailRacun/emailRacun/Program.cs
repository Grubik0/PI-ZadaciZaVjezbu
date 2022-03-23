using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emailRacun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Otvaranje e-mail korisničkog računa: ");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Ime: ");
            string ime = Console.ReadLine();
            Console.Write("Prezime: ");
            string prezime = Console.ReadLine();
            Console.WriteLine("---------------------------------------------");

            KorisnickiRacun korisnik = EmailServer.KreirajKorisnickiRacun(ime, prezime);

            Console.WriteLine("Podaci za korisnički račun:");
            Console.WriteLine("Ime: "+korisnik.ime);
            Console.WriteLine("Prezime: "+korisnik.prezime);
            Console.WriteLine("E-mail: "+korisnik.email);
            Console.WriteLine("Skraćeni e-mail: "+korisnik.skraceniEmail);
            Console.WriteLine("Lozinka: "+korisnik.lozinka);


            Console.ReadLine();
        }
    }
}
