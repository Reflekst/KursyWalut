using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursyWalut.Models
{
    //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

    public class Sender
    {
        public string id { get; set; }
    }

    public class Header
    {
        public string id { get; set; }
        public bool test { get; set; }
        public DateTime prepared { get; set; }
        public Sender sender { get; set; }
    }

    public class Observations
    {
        public List<int?> _0 { get; set; }
        public List<double?> _1 { get; set; }
        public List<double?> _2 { get; set; }
        public List<double?> _3 { get; set; }
        public List<double?> _4 { get; set; }
        public List<double?> _5 { get; set; }
        public List<double?> _6 { get; set; }
        public List<double?> _7 { get; set; }
        public List<double?> _8 { get; set; }
        public List<double?> _9 { get; set; }
        public List<double?> _10 { get; set; }
        public List<double?> _11 { get; set; }
        public List<double?> _12 { get; set; }
        public List<double?> _13 { get; set; }
        public List<double?> _14 { get; set; }
        public List<double?> _15 { get; set; }
        public List<double?> _16 { get; set; }
        public List<double?> _17 { get; set; }
        public List<double?> _18 { get; set; }
        public List<double?> _19 { get; set; }
        public List<double?> _20 { get; set; }
    }

    public class _00000
    {
        public List<int?> attributes { get; set; }
        public Observations observations { get; set; }
    }

    public class Series
    {
        //[JsonProperty("0:0:0:0:0")]
        public _00000 _00000 { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public List<Value> values { get; set; }
    }

    public class DataSet
    {
        public string action { get; set; }
        public DateTime validFrom { get; set; }
        public Series series { get; set; }
    }

    public class Link
    {
        public string title { get; set; }
        public string rel { get; set; }
        public string href { get; set; }
    }

    public class Value
    {
        public string id { get; set; }
        public string name { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }

    public class Observation
    {
        public string id { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public List<Value> values { get; set; }
    }

    public class Dimensions
    {
        public List<Series> series { get; set; }
        public List<Observation> observation { get; set; }
    }

    public class Attributes
    {
        public List<Series> series { get; set; }
        public List<Observation> observation { get; set; }
    }

    public class Structure
    {
        public List<Link> links { get; set; }
        public string name { get; set; }
        public Dimensions dimensions { get; set; }
        public Attributes attributes { get; set; }
    }

    public class Root
    {
        public Header header { get; set; }
        public List<DataSet> dataSets { get; set; }
        public Structure structure { get; set; }
    }


}
