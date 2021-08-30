using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var file = "Sample.xml";
            Exercise1_1(file);
            Console.WriteLine("-------");

            Exercise1_2(file);
            Console.WriteLine("-------");

            Exercise1_3(file);
            Console.WriteLine("-------");

            Exercise1_4(file);
        }



        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements();
            foreach (var item in xelements) {
                XElement xname = item.Element("name");
                XElement xmember = item.Element("teammembers");
                Console.WriteLine("{0},{1}",xname.Value,xmember.Value);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements().OrderBy(x=>(string)(x.Element("firstplayed")));
            foreach (var item in xelements) {
                XAttribute name = item.Element("name").Attribute("kanji");
                Console.WriteLine(name.Value);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                                    .Select(x=> new {
                                        Name = x.Element("name").Value,
                                        Teammembers = x.Element("teammembers").Value
                                     })
                                        .OrderByDescending(x=>int.Parse(x.Teammembers)).First();
            Console.WriteLine("{0}",sports.Name);
                                    
                                    
            //var xmax = xdoc.Descendants("teammembers").Select(e => int.Parse(e.Value)).Max().ToString();
            //var xelements = xdoc.Root.Elements().Where(e => e.Element("teammembers").Value == xmax);

            //foreach (var item in xelements) {
            //    Console.WriteLine(item.Element("name").Value);
            //}

        }

        private static void Exercise1_4(string file) {
            var newfile = "sports.xml";
            var element = new XElement("sports",
                new XElement("name", "サッカー", new XAttribute("kanji","蹴球")),
                new XElement("teammembers","11"),
                new XElement("firstplayed","1873"));
            var xdoc = new XDocument(element);
            
            xdoc.Root.Add(newfile);
            xdoc.Save(newfile);

        }
    }
}
