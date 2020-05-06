using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace ClassLib
{
    public class ComputerReader
    {
        XmlDocument xDoc;
        XmlElement xRoot;
        List<Computer> computers;
        public string date;


        public List<Computer> getComputers(string interval)
        {
            int l = 0, r = 0;
            
            
            switch (interval)
            {
                case "1-100":
                    l = 0; r = 99;
                    break;
                case "101-200":
                    l = 100; r = 199;
                    break;
                case "201-300":
                    l = 200; r = 299;
                    break;
                case "301-400":
                    l = 300; r = 399;
                    break;
                case "401-500":
                    l = 400; r = 499;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }


            var q = from i in computers
                    where i.rank >= l + 1 && i.rank <= r + 1
                    select i;
            
            return q.ToList();
        }


        public ComputerReader(string path, string date)
        {
            xDoc = new XmlDocument();
            xDoc.Load(path);
            xRoot = xDoc.DocumentElement;
            computers = new List<Computer>();
            int cnt = 0;
            this.date = date;

            foreach (XmlNode xnode in xRoot)
            {
                int rank = 0;
                string systemName = "-";
                string computer = "-";
                string rmax = "-";
                string rpeak = "=";
                string power = "-";
                //if (cnt++ > 100) break;
                try
                {
                    foreach (XmlNode childNode in xnode.ChildNodes)
                    {
                        foreach(XmlNode ChildChildNode in childNode.ChildNodes)
                        {
                            if (ChildChildNode.Name == "top500:installation-site-name")
                            {
                                systemName = (ChildChildNode.InnerText);
                            }
                        }
                        if (childNode.Name == "top500:rank")
                        {
                            rank = int.Parse(childNode.InnerText);
                        }
                        if (childNode.Name == "top500:system-name")
                        {
                            systemName = (childNode.InnerText);
                        }
                        if (childNode.Name == "top500:computer")
                        {
                            computer = (childNode.InnerText);
                        }
                        if (childNode.Name == "top500:r-max")
                        {
                            rmax = (childNode.InnerText);
                        }
                        if (childNode.Name == "top500:r-peak")
                        {
                            rpeak = (childNode.InnerText);
                        }
                        if (childNode.Name == "top500:power")
                        {
                            power = (childNode.InnerText);
                        }
                    }
                } catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


                try
                {
                    computers.Add(new Computer(rank, systemName, computer, rmax, rpeak, power));
                    using (StreamWriter sw = new StreamWriter("Log.txt", true))
                        sw.WriteLine(new Computer(rank, systemName, computer, rmax, rpeak, power).ToString());
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }



    }
}
