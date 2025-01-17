﻿using ProductShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProductShop.DTOs.Import
{
    [XmlType("User")]
    public class UsersImportModel
    {
        [XmlElement("firstName")]
        public string FirstName { get; set; } = null!;

        [XmlElement("lastName")]

        public string LastName { get; set; } = null!;

        [XmlElement("age")]
        public int? Age { get; set; }

    }
}

// NOTE => XML imput

//< Users >
//    < User >
//        < firstName > Chrissy </ firstName >
//        < lastName > Falconbridge </ lastName >
//        < age > 50 </ age >
//    </ User >