using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eps.Usuario
{
    class Paciente
    {
        private int pNumeroID;
        private String pNombre;
        private String pApellido;
        private String pFechaNacimiento;
        private String pDireccion;
        private String pEmail;
        private String pTelefono;
        private String pRegistro;
        private String pPazySalvo;

        public Paciente(int pNumeroID, string pNombre, string pApellido, string pFechaNacimiento, string pDireccion, string pEmail, string pTelefono, string pRegistro, string pPazySalvo)
        {
            this.pNumeroID = pNumeroID;
            this.pNombre = pNombre;
            this.pApellido = pApellido;
            this.pFechaNacimiento = pFechaNacimiento;
            this.pDireccion = pDireccion;
            this.pEmail = pEmail;
            this.pTelefono = pTelefono;
            this.pRegistro = pRegistro;
            this.pPazySalvo = pPazySalvo;
        }

        public int PNumeroID { get => pNumeroID; set => pNumeroID = value; }
        public string PNombre { get => pNombre; set => pNombre = value; }
        public string PApellido { get => pApellido; set => pApellido = value; }
        public string PFechaNacimiento { get => pFechaNacimiento; set => pFechaNacimiento = value; }
        public string PDireccion { get => pDireccion; set => pDireccion = value; }
        public string PTelefono { get => pTelefono; set => pTelefono = value; }
        public string PEmail { get => pEmail; set => pEmail = value; }
        public string PRegistro { get => pRegistro; set => pRegistro = value; }
        public string PPazySalvo { get => pPazySalvo; set => pPazySalvo = value; }
    }
}
