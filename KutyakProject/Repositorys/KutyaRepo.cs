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
        public List<Kutyak> KutyakLista = new List<Kutyak>();

        public KutyaRepo()
        {
            BeolvasKutyak();
        }

        private void BeolvasKutyak()
        {
            KutyaFajtakRepo kfajtarepo = new KutyaFajtakRepo();
            KutyaNevekRepo knevrepo = new KutyaNevekRepo();
            using (StreamReader sr = new StreamReader("Kutyak.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');

                    KutyaFajta kfajta = kfajtarepo.KutyaFajtakLista.SingleOrDefault(x => x.id == Convert.ToInt32(line[1]));                 
                    KutyaNev knev = knevrepo.KutyaNevekLista.SingleOrDefault(x => x.id == Convert.ToInt32(line[2]));

                    KutyakLista.Add(new Kutyak(Convert.ToInt32(line[0]),
                                                    kfajta,
                                                    knev,
                                                    Convert.ToInt32(line[3]),
                                                    Convert.ToDateTime(line[4])
                                                    )
                        );
                }
            }
        }

        public int getKutyaDarabszam()
        {
            return KutyakLista.Count();
        }

        public double atlagEletkor() 
        {
            return KutyakLista.Average(x => x.eletkor);
        }

        public Kutyak getLegidosebbKutya()
        {
            var max = KutyakLista.Max(x => x.eletkor);
            var oregKutyu = KutyakLista.SingleOrDefault(x => x.eletkor == max);

            return oregKutyu;
        }

        public void fajtankentIdoreCsoport() 
        {
            var datum = new DateTime(2018, 01, 10);
            var datumCsoport = KutyakLista
                .Where(x => x.orvosiEllenorzes == datum) //datumra szürünk
                .GroupBy(x => x.kutyaFajta) //fajta szerint csoportositjuk
                .ToList();
            datumCsoport.ForEach(x =>
                    Console.WriteLine("\t"+x.Key.nev + " kutya " + x.Count())
                    );
        }

        public void csopDatumAlapjan() 
        {
            var csop = KutyakLista.GroupBy(x => x.orvosiEllenorzes).OrderByDescending(x => x.Count()).First();
            Console.WriteLine("Legjobban leterhelt nap: "+ csop.Key + " " + csop.Count());
        }

    }
}
