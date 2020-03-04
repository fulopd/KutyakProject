using KutyakProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakProject.Repositorys
{
    class KutyaNevekRepo
    {
        private List<KutyaNev> KutyaNevekLista = new List<KutyaNev>();

        public KutyaNevekRepo()
        {
            BeolvasKutyaNevek();
        }

        private List<KutyaNev> BeolvasKutyaNevek() 
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("KutyaNevek.csv"))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(';');
                        KutyaNevekLista.Add(new KutyaNev(Convert.ToInt32(line[0]), line[1]));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return KutyaNevekLista;
        }

        public int getKutyaNevekSzama() 
        {
            return KutyaNevekLista.Count();
        }
    }
}
