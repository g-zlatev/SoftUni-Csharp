﻿using SoftJail.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace SoftJail.DataProcessor.ImportDto
{
    [XmlType("Officer")]
    public class OfficerPrisonerInputModel
    {
        [XmlElement("Name")]
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [XmlElement("Money")]
        [Range(typeof(decimal), "0", "79228162514264337593543950335")]
        public decimal Money { get; set; }

        [XmlElement("Position")]
        [EnumDataType(typeof(Position))]
        public string Position { get; set; }

        [XmlElement("Weapon")]
        [EnumDataType(typeof(Weapon))]
        public string Weapon { get; set; }

        [XmlElement("DepartmentId")]
        public int DepartmentId { get; set; }

        [XmlArray("Prisoners")]
        public PrisonerInputModel[] Prisoners { get; set; }
    }

    [XmlType("Prisoner")]
    public class PrisonerInputModel
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
    }
}

//•	Id – integer, Primary Key
//•	FullName – text with min length 3 and max length 30 (required)
//•	Salary – decimal(non - negative, minimum value: 0)(required)
//•	Position - Position enumeration with possible values: “Overseer, Guard, Watcher, Labour” (required)
//•	Weapon - Weapon enumeration with possible values: “Knife, FlashPulse, ChainRifle, Pistol, Sniper” (required)
//•	DepartmentId - integer, foreign key(required)
//•	Department – the officer's department (required)
//•	OfficerPrisoners - collection of type OfficerPrisoner



//< Officer >
//    < Name > Minerva Kitchingman </ Name >

//       < Money > 2582 </ Money >

//       < Position > Invalid </ Position >

//       < Weapon > ChainRifle </ Weapon >

//       < DepartmentId > 2 </ DepartmentId >

//       < Prisoners >

//         < Prisoner id = "15" />

//        </ Prisoners >

//      </ Officer >
