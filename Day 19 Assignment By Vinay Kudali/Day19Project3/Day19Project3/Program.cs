using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19Project1
{
    internal class Program
    {
        //Author: Vinay Kudali
        //Purpose: Creating xml and printing two details
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\Day 19 Assignment By Vinay Kudali\\XmlFiles\\Tagxml.xml");

            //XmlNode node = doc.DocumentElement.SelectSingleNode("/products/product");
            foreach (XmlNode node2 in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode node3 in node2.ChildNodes)
                {
                    if (node3.Name=="ProductId")
                        Console.Write($"{node3.InnerText}, ");
                    if (node3.Name=="ProductName")
                        Console.Write($"{node3.InnerText}, ");
                    if (node3.Name=="ProductBrand")
                        Console.Write($"{node3.InnerText}, \n");
                }

            }
            Console.ReadLine();


        }

    }
}
