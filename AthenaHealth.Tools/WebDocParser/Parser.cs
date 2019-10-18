using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Tools.WebDocParser
{
    public class Parser
    {
        /// <summary>
        /// Parses Athena web documentation and creates c# properties. Early alpha version ;)
        /// Instruction:
        /// 1. paste html table into in.html
        /// 2. run app
        /// 3. see output file out.cs in bin\Debug\WebDocParser\
        /// </summary>
        public static void ParseAndSave()
        {
            var list = ParseItems("WebDocParser\\in.html");

            string template = File.ReadAllText("WebDocParser\\template.txt");


            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                string property = template.Replace("!SUMMARY!", item.Description ?? "");
                property = property.Replace("!PROPERTYNAME!", item.Name != null ? item.Name.FirstCharToUpper() : "");
                property = property.Replace("!PROPERTYTYPE!", ConvertType(item.Type) ?? "");
                property = property.Replace("!JSONPROPERTYNAME!", item.Name ?? "");
                sb.AppendLine(property);
            }

            File.WriteAllText("WebDocParser\\out.cs", sb.ToString());
        }


        private static string ConvertType(string typeDoc)
        {
            if (typeDoc == null)
                return "";
            typeDoc = typeDoc.Replace("integer", "int?");
            typeDoc = typeDoc.Replace("boolean", "bool?");
            return typeDoc;
        }


        public static List<Item> ParseItems(string file)
        {
            List<Item> items = new List<Item>();
            HtmlDocument doc = new HtmlDocument();
            doc.Load(file);
            foreach (var tr in doc.DocumentNode.SelectNodes("//tr"))
            {
                Item item = new Item();
                item.Name = tr.SelectNodes("./td[@class='outputname' and @data-label='Name']")?.First().InnerText.Trim();
                item.Type = tr.SelectNodes("./td[@class='outputtype' and @data-label='Type']")?.First().InnerText;
                item.Description = tr.SelectNodes("./td[@class='outputnote' and @data-label='Description']")?.First().InnerText;

                if(item.Name != null)
                    items.Add(item);
            }

            return items;
        }


        public class Item
        {
            public string Name;
            public string Type;
            public string Description;

            public override bool Equals(object other)
            {
                if (other == null)
                    return false;

                if (this.Name == ((Item)other).Name && this.Type == ((Item)other).Type && this.Description == ((Item)other).Description) 
                    return true; ;
                return false;
            }

            public override int GetHashCode()
            {
                return $"{Name}, {Type}, {Description}".GetHashCode();
            }
        }
    }
}
