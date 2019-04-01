using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ArmenianLetter
{
  
    class Program
    {


        static void Main(string[] args)
        {
            string st = "dhfdh,reiouir;dsff";
            string[] sd = st.Split(',', ';');
            StringBuilder df = new StringBuilder(st);
            foreach(var i in sd)
            {
                df.Replace(i," ghg");
            }
            Console.WriteLine(df);
                string s = Console.ReadLine();


                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine(ChangeLetter.ChangeLetterMethod(s));
            
        }
    }
}
