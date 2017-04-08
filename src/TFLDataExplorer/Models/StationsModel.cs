/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;


namespace TFLDataExplorer.Models
{
    [XmlRoot(ElementName = "PublishDateTime")]
    public class PublishDateTime
    {
        [XmlAttribute(AttributeName = "canonical")]
        public string Canonical { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Attribution")]
    public class Attribution
    {
        [XmlElement(ElementName = "Url")]
        public string Url { get; set; }
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
        [XmlElement(ElementName = "Logo")]
        public string Logo { get; set; }
    }

    [XmlRoot(ElementName = "Header")]
    public class Header
    {
        [XmlElement(ElementName = "Identifier")]
        public string Identifier { get; set; }
        [XmlElement(ElementName = "DisplayTitle")]
        public string DisplayTitle { get; set; }
        [XmlElement(ElementName = "Version")]
        public string Version { get; set; }
        [XmlElement(ElementName = "PublishDateTime")]
        public PublishDateTime PublishDateTime { get; set; }
        [XmlElement(ElementName = "Author")]
        public string Author { get; set; }
        [XmlElement(ElementName = "Owner")]
        public string Owner { get; set; }
        [XmlElement(ElementName = "RefreshRate")]
        public string RefreshRate { get; set; }
        [XmlElement(ElementName = "Max_Latency")]
        public string Max_Latency { get; set; }
        [XmlElement(ElementName = "TimeToError")]
        public string TimeToError { get; set; }
        [XmlElement(ElementName = "Schedule")]
        public string Schedule { get; set; }
        [XmlElement(ElementName = "Attribution")]
        public Attribution Attribution { get; set; }
        [XmlElement(ElementName = "Language")]
        public string Language { get; set; }
    }

    [XmlRoot(ElementName = "Icon")]
    public class Icon
    {
        [XmlElement(ElementName = "href")]
        public string Href { get; set; }
    }

    [XmlRoot(ElementName = "IconStyle")]
    public class IconStyle
    {
        [XmlElement(ElementName = "Icon")]
        public Icon Icon { get; set; }
    }

    [XmlRoot(ElementName = "Style")]
    public class Style
    {
        [XmlElement(ElementName = "IconStyle")]
        public IconStyle IconStyle { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "contactDetails")]
    public class ContactDetails
    {
        [XmlElement(ElementName = "address")]
        public string Address { get; set; }
        [XmlElement(ElementName = "phone")]
        public string Phone { get; set; }
    }

    [XmlRoot(ElementName = "servingLines")]
    public class ServingLines
    {
        [XmlElement(ElementName = "servingLine")]
        public List<string> ServingLine { get; set; }
    }

    [XmlRoot(ElementName = "zones")]
    public class Zones
    {
        [XmlElement(ElementName = "zone")]
        public string Zone { get; set; }
    }

    [XmlRoot(ElementName = "facility")]
    public class Facility
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "facilities")]
    public class Facilities
    {
        [XmlElement(ElementName = "facility")]
        public List<Facility> Facility { get; set; }
    }

    [XmlRoot(ElementName = "path")]
    public class Path
    {
        [XmlElement(ElementName = "heading")]
        public string Heading { get; set; }
        [XmlElement(ElementName = "pathDescription")]
        public string PathDescription { get; set; }
    }

    [XmlRoot(ElementName = "bookingHallToPlatform")]
    public class BookingHallToPlatform
    {
        [XmlElement(ElementName = "path")]
        public List<Path> Path { get; set; }
        [XmlElement(ElementName = "pointName")]
        public string PointName { get; set; }
        [XmlElement(ElementName = "pathDescription")]
        public string PathDescription { get; set; }
    }

    [XmlRoot(ElementName = "platformToTrain")]
    public class PlatformToTrain
    {
        [XmlElement(ElementName = "trainName")]
        public string TrainName { get; set; }
        [XmlElement(ElementName = "platformToTrainSteps")]
        public string PlatformToTrainSteps { get; set; }
    }

    [XmlRoot(ElementName = "entrance")]
    public class Entrance
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "entranceToBookingHall")]
        public string EntranceToBookingHall { get; set; }
        [XmlElement(ElementName = "bookingHallToPlatform")]
        public List<BookingHallToPlatform> BookingHallToPlatform { get; set; }
        [XmlElement(ElementName = "platformToTrain")]
        public List<PlatformToTrain> PlatformToTrain { get; set; }
    }

    [XmlRoot(ElementName = "entrances")]
    public class Entrances
    {
        [XmlElement(ElementName = "entrance")]
        public List<Entrance> Entrance { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
    }

    [XmlRoot(ElementName = "timeInterval")]
    public class TimeInterval
    {
        [XmlElement(ElementName = "from")]
        public string From { get; set; }
        [XmlElement(ElementName = "to")]
        public string To { get; set; }
    }

    [XmlRoot(ElementName = "timeIntervals")]
    public class TimeIntervals
    {
        [XmlElement(ElementName = "timeInterval")]
        public List<TimeInterval> TimeInterval { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "openingHour")]
    public class OpeningHour
    {
        [XmlElement(ElementName = "entrance")]
        public string Entrance { get; set; }
        [XmlElement(ElementName = "timeIntervals")]
        public List<TimeIntervals> TimeIntervals { get; set; }
    }

    [XmlRoot(ElementName = "openingHours")]
    public class OpeningHours
    {
        [XmlElement(ElementName = "openingHour")]
        public List<OpeningHour> OpeningHour { get; set; }
    }

    [XmlRoot(ElementName = "Point")]
    public class Point
    {
        [XmlElement(ElementName = "coordinates")]
        public string Coordinates { get; set; }
    }

    [XmlRoot(ElementName = "Placemark")]
    public class Placemark
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "Point")]
        public Point Point { get; set; }
        [XmlElement(ElementName = "styleUrl")]
        public string StyleUrl { get; set; }
    }

    [XmlRoot(ElementName = "station")]
    public class Station
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "contactDetails")]
        public ContactDetails ContactDetails { get; set; }
        [XmlElement(ElementName = "servingLines")]
        public ServingLines ServingLines { get; set; }
        [XmlElement(ElementName = "zones")]
        public Zones Zones { get; set; }
        [XmlElement(ElementName = "facilities")]
        public Facilities Facilities { get; set; }
        [XmlElement(ElementName = "entrances")]
        public Entrances Entrances { get; set; }
        [XmlElement(ElementName = "openingHours")]
        public OpeningHours OpeningHours { get; set; }
        [XmlElement(ElementName = "Placemark")]
        public Placemark Placemark { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "stations")]
    public class Stations
    {
        [XmlElement(ElementName = "station")]
        public List<Station> Station { get; set; }
    }

    [XmlRoot(ElementName = "Root")]
    public class StationsModel
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "open")]
        public string Open { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "Header")]
        public Header Header { get; set; }
        [XmlElement(ElementName = "Style")]
        public List<Style> Style { get; set; }
        [XmlElement(ElementName = "stations")]
        public Stations Stations { get; set; }
    }

}
