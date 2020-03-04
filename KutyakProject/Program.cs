using KutyakProject.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakProject
{
    class Program
    {
        static void Main(string[] args)
        {
            KutyaNevekRepo knr = new KutyaNevekRepo();
            KutyaFajtakRepo kfr = new KutyaFajtakRepo();
            KutyaRepo kr = new KutyaRepo();

            //3. Feladat            
            Console.WriteLine("3. Feladat: Kutyanevek száma: "+knr.getKutyaNevekSzama());
            Console.WriteLine(kr.getKutyaDarabszam());

            Console.ReadKey();
        }
    }
}
