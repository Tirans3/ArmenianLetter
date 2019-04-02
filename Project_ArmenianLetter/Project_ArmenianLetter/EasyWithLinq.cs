using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ArmenianLetter
{
    class EasyWithLinq
    {
        readonly static string[] temp = Enum.GetNames(typeof(Alphabet.Latin));
        readonly  static Dictionary<string, string> temp1 = new Dictionary<string, string>();
        static EasyWithLinq()
        {
            foreach(string i in temp)
            {
                temp1.Add(i, Enum.GetName(typeof(Alphabet.Armenian), Alphabet.AlphaBen[(Alphabet.Latin)Enum.Parse(typeof(Alphabet.Latin), i)]));
            }
        }

                  public static string Translit(string str)
                  {
                     if (str == null||str==" ")
                        throw new ArgumentNullException();

                    

                              str= str.ToUpper();

                       return   temp.Aggregate(str, (a, b) => a.Contains(b) ? a.Replace(b, temp1[b]) : a);
            
                  }
    }
}
