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
            Console.WriteLine("adad");
            Console.OutputEncoding = Encoding.UTF8;
            
                string s = Console.ReadLine();
            

               Console.WriteLine(EasyWithLinq.Translit(s));

            string t = Console.ReadLine();

            Console.WriteLine(ChangeLetter.ChangeLetterMethod(t));
                Console.ReadLine();
            
        }
    }
}
