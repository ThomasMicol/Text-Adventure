using System;
using System.Collections.Generic;
using System.Xml;

namespace My_First_Ever_Program
{
    class BiomeLogger
    {
        protected List<Biome> myBiomes = new List<Biome>();
        
        public BiomeLogger()
        {
            PopulateBiomes();

        }

        protected void PopulateBiomes()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("resources/biome_set.xml");
            foreach(XmlNode node in doc.SelectNodes("BiomeSets//Biome"))
            {
                XmlNode NameNode = node.SelectSingleNode("Name");
                XmlNode ResourceSetNode = node.SelectSingleNode("ResourceSet");
                XmlNode StageSetNode = node.SelectSingleNode("StageSet");
                XmlNode DescriptorNode = node.SelectSingleNode("Descriptor");
                myBiomes.Add(new Biome(NameNode.InnerText, ResourceSetNode.InnerText, StageSetNode.InnerText , DescriptorNode.InnerText));
            }
        }

        internal IBiome GetRandomBiome()
        {
            Random rand = new Random();
            int accession = rand.Next(0, myBiomes.Count);
            return myBiomes[accession];
        }
        
    }

} 