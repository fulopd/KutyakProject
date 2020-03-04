using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakProject.Models
{
    class Kutyak
    {
        public int id { get; }
        public KutyaFajta kutyaFajta { get; }
        public KutyaNev kutyaNev { get; }
        public int eletkor { get; }
        public DateTime orvosiEllenorzes { get; }

        public Kutyak(int id, KutyaFajta kutyaFajta, KutyaNev kutyaNev, int eletkor, DateTime orvosiEllenorzes)
        {
            this.id = id;
            this.kutyaFajta = kutyaFajta;
            this.kutyaNev = kutyaNev;
            this.eletkor = eletkor;
            this.orvosiEllenorzes = orvosiEllenorzes;
        }


       

    }
}
