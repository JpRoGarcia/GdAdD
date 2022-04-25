using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eps.Usuario
{
    public class Cita
    {
        String cTipoCita;
        int cCedulaP;
        int cCedulaM;
        String cFecha;
        String cEstado;

        public Cita(string cTipoCita, int cCedulaP, int cCedulaM, string cFecha, string cEstado)
        {
            this.cTipoCita = cTipoCita;
            this.cCedulaP = cCedulaP;
            this.cCedulaM = cCedulaM;
            this.cFecha = cFecha;
            this.cEstado = cEstado;
        }

        public string CTipoCita { get => cTipoCita; set => cTipoCita = value; }
        public int CCedulaP { get => cCedulaP; set => cCedulaP = value; }
        public int CCedulaM { get => cCedulaM; set => cCedulaM = value; }
        public string CFecha { get => cFecha; set => cFecha = value; }
        public string CEstado { get => cEstado; set => cEstado = value; }
    }
}
