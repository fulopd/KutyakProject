using KutyakProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakProject.Repositorys
{
    class KutyaFajtakRepo
    {
        public List<KutyaFajta> KutyaFajtakLista = new List<KutyaFajta>();

        public KutyaFajtakRepo()
        {
            BeolvasKutyaFajtak();
        }

        public List<KutyaFajta> BeolvasKutyaFajtak() 
        {
            using (StreamReader sr = new StreamReader("KutyaFajtak.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');
                    KutyaFajtakLista.Add(new KutyaFajta(Convert.ToInt32(line[0]), line[1], line[2]));
                }
            }

            return KutyaFajtakLista;
        }

        public int getFajtaDarabszam() 
        {
            return KutyaFajtakLista.Count();
        }
    }
}
