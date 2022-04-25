using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eps.Usuario
{
    public class Multa
    {
        int mCedulaP;
        int mValorMulta;

        public Multa(int mCedulaP, int mValorMulta)
        {
            this.mCedulaP = mCedulaP;
            this.mValorMulta = mValorMulta;
        }

        public int MCedulaP { get => mCedulaP; set => mCedulaP = value; }
        public int MValorMulta { get => mValorMulta; set => mValorMulta = value; }
    }
}
