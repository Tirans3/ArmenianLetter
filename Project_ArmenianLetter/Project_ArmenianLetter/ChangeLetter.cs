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
            if (str == null)
                throw new ArgumentNullException();
            

            if (!str.Contains(' '))
            {

              
                
              string[] temp = str.ToCharArray().Select(c => c.ToString().ToUpper()).ToArray();

                int x = 0;
              return int.TryParse(str,out x) ?x.ToString():temp.Aggregate(" ", (a, b) => a + Enum.GetName(typeof(Alphabet.Armenian), Alphabet.AlphaBen[(Alphabet.Latin)Enum.Parse(typeof(Alphabet.Latin), b)]));
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
