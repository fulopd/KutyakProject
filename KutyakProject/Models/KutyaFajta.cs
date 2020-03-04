using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakProject.Models
{
    class KutyaFajta
    {
        public int id { get; set; }
        public string nev { get; set; }
        public string eredetiNev { get; set; }

        public KutyaFajta(int id, string nev, string eredetiNev)
        {
            this.id = id;
            this.nev = nev;
            this.eredetiNev = eredetiNev;
        }

        public override string ToString()
        {
            return nev;
        }

    }
}
