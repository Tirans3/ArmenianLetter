using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ArmenianLetter
{
    public class Alphabet
    {
        
        
        public enum Latin
        {
            A, B, C, D, E, F, G,
            H, I, J, K, L, M, N,
            O, P, Q, R, S, T, U,
            V, W, X, Z, Y,CH,SH,
        }


        public enum Armenian

        {
            Ա, Բ, Գ, Դ, Ե, Զ, Է,
            Ը, Թ, Ժ, Ի, Լ, Խ, Ծ,
            Կ, Հ, Ձ, Ղ, Ճ, Մ, Յ,
            Ն, Շ, Ո, Չ, Պ, Ջ, Ռ,
            Ս, Վ, Տ, Ր, Ց, ՈՒ,
            Փ, Ք, ԵՎ, Օ, Ֆ
        }

        public static Dictionary<Enum, Enum> AlphaBen =new Dictionary<Enum, Enum>
        {
            { Latin.A,Armenian.Ա }, { Latin.M,Armenian.Մ },
            { Latin.B,Armenian.Բ }, { Latin.N,Armenian.Ն },
            { Latin.C,Armenian.Ց }, { Latin.O,Armenian.Օ },
            { Latin.D,Armenian.Դ }, { Latin.P,Armenian.Պ },
            { Latin.E,Armenian.Ե }, { Latin.Q,Armenian.Ք },
            { Latin.G,Armenian.Գ }, { Latin.R,Armenian.Ր },
            { Latin.H,Armenian.Հ }, { Latin.S,Armenian.Ս },
            { Latin.I,Armenian.Ի }, { Latin.T,Armenian.Տ },
            { Latin.J,Armenian.Ջ }, { Latin.U,Armenian.ՈՒ },
            { Latin.K,Armenian.Կ }, { Latin.V,Armenian.Վ },
            { Latin.L,Armenian.Լ }, { Latin.W,Armenian.ՈՒ },
            { Latin.Z,Armenian.Զ }, { Latin.X,Armenian.Խ },
            { Latin.Y,Armenian.Յ }, { Latin.CH,Armenian.Չ },
            { Latin.SH,Armenian.Շ },{ Latin.F,Armenian.Ֆ },
        };


        

    }
}
