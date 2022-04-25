using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eps
{
    public class Validaciones
    {
        public static void SoloInt(KeyPressEventArgs Sn)
        {
            if (char.IsDigit(Sn.KeyChar))
            {
                Sn.Handled = false;
            }
            else if (char.IsControl(Sn.KeyChar))
            {
                Sn.Handled = false;
            }
            else
            {
                Sn.Handled = true;
            }
        }

        public static void SoloString(KeyPressEventArgs Ss)
        {
            if (char.IsLetter(Ss.KeyChar))
            {
                Ss.Handled = false;
            }
            else if (char.IsControl(Ss.KeyChar))
            {
                Ss.Handled = false;
            }
            else if (char.IsSeparator(Ss.KeyChar))
            {
                Ss.Handled = false;
            }
            else
            {
                Ss.Handled = true;
            }
        }

        public static Boolean VerificacionEMail(String email)
        {
            return Regex.IsMatch(email, "^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$");
        }

        public static Boolean ValidarVacio(TextBox text)
        {
            if (text.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean ValidarContraseñas(String Contraseña, String ConfirmarContraseña)
        {
            if(Contraseña == ConfirmarContraseña)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
