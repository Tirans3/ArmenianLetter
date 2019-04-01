using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ArmenianLetter
{
    
  public static  class ChangeLetter 
    {


        public static string ChangeLetterMethod(string str)
        {
            if (!str.Contains(' '))
            {


                var list1 = Enum.GetNames(typeof(Alphabet.Latin));
                var list2 = Enum.GetNames(typeof(Alphabet.Armenian));
                string[] temp1 = str.ToCharArray().Select(c => c.ToString().ToUpper()).ToArray();


               return  temp1.Aggregate(" ", (a, b) => a + Enum.GetName(typeof(Alphabet.Armenian), Alphabet.AlphaBen[(Alphabet.Latin)Enum.Parse(typeof(Alphabet.Latin), b)]));
            }
            else
            {
                string s="";
                string[] split = str.Split(' ');
                foreach(var i in split)
                {
                    s += ChangeLetterMethod(i) + " ";
                }
                return s;
            }
        }

    }
}
