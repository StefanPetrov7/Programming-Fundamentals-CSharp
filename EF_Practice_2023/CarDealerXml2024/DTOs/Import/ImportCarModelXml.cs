﻿using System.Xml.Serialization;

namespace CarDealer.DTOs.Import
{
    [XmlType("Car")]
    public class ImportCarModelXml
    {
        public ImportCarModelXml()
        {
            Parts = new List<ImportCarPartModelXml>();
        }

        [XmlElement("make")]
        public string Make { get; set; } = null!;

        [XmlElement("model")]
        public string Model { get; set; } = null!;

        [XmlElement("traveledDistance")]
        public long TraveledDistance { get; set; }

        [XmlArray("parts")]
        public List<ImportCarPartModelXml> Parts { get; set; }
    }
}
