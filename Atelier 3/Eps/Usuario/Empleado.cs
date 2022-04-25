using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eps.Usuario
{
    public class Empleado
    {
        private int eCedula;
        private String eNombre;
        private String eApellido;
        private String eContraseña;

        public Empleado(int eCedula, string eNombre, string eApellido, string eContraseña)
        {
            this.eCedula = eCedula;
            this.eNombre = eNombre;
            this.eApellido = eApellido;
            this.eContraseña = eContraseña;
        }

        public int ECedula { get => eCedula; set => eCedula = value; }
        public string ENombre { get => eNombre; set => eNombre = value; }
        public string EApellido { get => eApellido; set => eApellido = value; }
        public string EContraseña { get => eContraseña; set => eContraseña = value; }

    }
}
