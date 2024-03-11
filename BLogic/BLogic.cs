using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Model;

namespace BLogic
{
    public class Logic
    {
        public List<People> allpeoples { get; set; } = new List<People>();
        public List<People> peoplesonvac { get; set; } = new List<People>();
        public List<People> peoplewithsert { get; set; } = new List<People>();
        public void vsehnavac()
        {
            List<People> vseh = new List<People>();
            foreach (People k in allpeoples)
            {
                peoplesonvac.Add(k);
                vseh.Add(k);
            }
            foreach(People k in vseh)
            {
                allpeoples.Remove(k);
            }
        }
        public void vsehnaperv()
        {
            List<People> perv = new List<People>();
            foreach (People k in allpeoples)
            {
                if (k.count == 0)
                {
                    peoplesonvac.Add(k);
                    perv.Add(k);
                }
            }
            foreach(People k in perv)
            {
                allpeoples.Remove(k);
            }
        }
        public void vsehnapovtor()
        {
            List<People> povtor = new List<People>();
            foreach (People k in allpeoples)
            {
                if (k.count == 1)
                {
                    peoplesonvac.Add(k);
                    povtor.Add(k);
                }
            }
            foreach(People p in povtor)
            {
                allpeoples.Remove(p);
            }
        }
        public void vac()
        {
            List<People> vacc = new List<People>();
            Random rand = new Random();
            foreach (People k in peoplesonvac)
            {
                int s = rand.Next(0, 2);
                if (s == 1)
                {
                    k.count++;
                    if (k.count == 2)
                    {
                        vacc.Add(k);
                        peoplewithsert.Add(k);
                    }
                    if (k.count == 1)
                    {
                        vacc.Add(k);
                        allpeoples.Add(k);
                    }
                }
                if (s == 0)
                {
                    vacc.Add(k);
                    allpeoples.Add(k);
                }
            }
            foreach (People s in vacc)
            {
                peoplesonvac.Remove(s);
            }
        }
        public string[] Print(List<People> m)
        {
            int i = 0;
            string[] y=new string[m.Count];
            foreach(People k in m)
            {
                y[i] =$"[{k.count}] {k.Name}";
                i++;
            }
            return y;
            
        }
        public void GeneratePeople()
        {
            People people1 = new People()
            {
                Name = "Дима"
            };
            People people2 = new People()
            {
                Name = "Саша"
            };
            People people3 = new People()
            {
                Name = "Маша"
            };

            People people4 = new People()
            {
                Name = "Наташа"
            };
            People people5 = new People()
            {
                Name = "Илья"
            };
            allpeoples.Add(people1);
            allpeoples.Add(people2);
            allpeoples.Add(people3);
            allpeoples.Add(people4);
            allpeoples.Add(people5);
        }
    }
}
