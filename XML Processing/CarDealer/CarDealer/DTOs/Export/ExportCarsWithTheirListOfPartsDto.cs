﻿using System.Xml.Serialization;

namespace CarDealer.DTOs.Export;

[XmlType("car")]
public class ExportCarsWithTheirListOfPartsDto
{
    [XmlAttribute("make")]
    public string Make { get; set; } = null!;

    [XmlAttribute("model")]
    public string Model { get; set; } = null!;

    [XmlAttribute("traveled-distance")]
    public long TraveledDistance { get; set; }

    public ExportPartsDto[] parts { get; set; }
}

[XmlType("part")]
public class ExportPartsDto
{
    [XmlAttribute("name")]
    public string Name { get; set; } = null!;

    [XmlAttribute("price")]
    public decimal Price { get; set; }
}

