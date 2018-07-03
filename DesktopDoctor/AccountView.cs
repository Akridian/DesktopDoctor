using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopDoctor
{
    public class AccountView
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Fename { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string SecurityLevel { get; set; }
        public bool IsDeleted { get; set; }
    }
}
