using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopDoctor
{
    public partial class Patient
    {
        public override string ToString()
        {
            string result = Fename + " " + Name.Substring(0, 1) + ".";
            if (Patronymic.Length > 0)
            {
                result += Patronymic.Substring(0, 1) + ".";
            }
            return result;
        }
    }
}
