using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eps.Usuario
{
    public class Medico
    {
        private int mCedula;
        private String mNombre;
        private String mApellido;
        private String mEspecialidad;
        private String mValorSalario;
        private String mAñosExperiencia;

        public Medico(int mCedula, string mNombre, string mApellido, string mEspecialidad, string mValorSalario, string mAñosExperiencia)
        {
            this.mCedula = mCedula;
            this.mNombre = mNombre;
            this.mApellido = mApellido;
            this.mEspecialidad = mEspecialidad;
            this.mValorSalario = mValorSalario;
            this.mAñosExperiencia = mAñosExperiencia;
        }

        public int MCedula { get => mCedula; set => mCedula = value; }
        public string MNombre { get => mNombre; set => mNombre = value; }
        public string MApellido { get => mApellido; set => mApellido = value; }
        public string MEspecialidad { get => mEspecialidad; set => mEspecialidad = value; }
        public string MValorSalario { get => mValorSalario; set => mValorSalario = value; }
        public string MAñosExperiencia { get => mAñosExperiencia; set => mAñosExperiencia = value; }
    }
}
