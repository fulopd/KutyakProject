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
            Console.WriteLine("6. Feladat: {0:N2}",kr.atlagEletkor());
            var oreg = kr.getLegidosebbKutya();
            Console.WriteLine("7. Feladat: Legöregebb kutty: "+ oreg.eletkor + " " + oreg.kutyaNev + " " + oreg.kutyaFajta.nev);
            Console.WriteLine("8. Feladat: ");
            kr.fajtankentIdoreCsoport();
            Console.WriteLine("9. feladat: ");
            kr.csopDatumAlapjan();


            Console.ReadKey();
        }
    }
}
