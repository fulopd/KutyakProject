using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakProject.Models
{
    class KutyaNev
    {
        public int id { get; set; }
        public string nev { get; set; }

        public KutyaNev(int id, string nev)
        {
            this.id = id;
            this.nev = nev;
        }

        public override string ToString()
        {
            return nev;
        }
    }
}
