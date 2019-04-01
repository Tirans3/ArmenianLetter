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
            if (str == null ||str== " ")
                throw new ArgumentNullException();

            char[] delimiterChars = { ' ', ',', '.', ':', '\t','-','_' };

            bool bools = delimiterChars.Any(s => str.Contains(s));

            if (  !bools )
            {

              
                
              string[] temp = str.ToCharArray().Select(c => c.ToString().ToUpper()).ToArray();

                
             return int.TryParse(str,out int x) ?x.ToString():temp.Aggregate(" ", (a, b) => a + Enum.GetName(typeof(Alphabet.Armenian), Alphabet.AlphaBen[(Alphabet.Latin)Enum.Parse(typeof(Alphabet.Latin), b)]));
            }
            else
            {
                
                StringBuilder s =new StringBuilder(str);
                string[] split = str.Split(' ', ',', '.', ':', '\t', '-', '_');
                foreach (var i in split)
                {
                    s.Replace(i, ChangeLetterMethod(i));
                }
                return s.ToString();
            }
        }

    }
}
