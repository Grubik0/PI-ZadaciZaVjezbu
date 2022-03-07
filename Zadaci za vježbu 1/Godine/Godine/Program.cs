using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Godina rođenja: ");
            int godinaRodenja = Convert.ToInt32(Console.ReadLine());
            int godinaTren = Convert.ToInt32(DateTime.Now.Year);
            int prezivljeno = 0;
            
            for(int i = godinaRodenja; i<=godinaTren; i++)
            {
                if (i % 4 == 0) prezivljeno++;
                /*
                else if (i % 100 != 0) prezivljeno++;
                else if (i % 400 == 0) prezivljeno++;
                */
                
            }
            Console.WriteLine("Starost: "+(godinaTren-godinaRodenja));
            Console.WriteLine("Preživljeno prijestupnih godina: "+prezivljeno);
            Console.ReadLine();

        }
    }
}
