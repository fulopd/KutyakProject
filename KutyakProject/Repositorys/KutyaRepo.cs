using KutyakProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakProject.Repositorys
{
    class KutyaRepo
    {
        private List<Kutyak> KutyaFajtakLista = new List<Kutyak>();

        public KutyaRepo()
        {
            BeolvasKutyak();
        }

        private void BeolvasKutyak()
        {
            using (StreamReader sr = new StreamReader("Kutyak.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');
                    KutyaFajtakLista.Add(new Kutyak(Convert.ToInt32(line[0]), 
                                                    Convert.ToInt32(line[1]), 
                                                    Convert.ToInt32(line[2]),
                                                    Convert.ToInt32(line[3]),
                                                    Convert.ToDateTime(line[4])
                                                    )
                        );
                }
            }
        }

        public int getKutyaDarabszam()
        {
            return KutyaFajtakLista.Count();
        }
    }
}
