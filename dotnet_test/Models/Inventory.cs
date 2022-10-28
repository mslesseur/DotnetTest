using dotnet_test.Models;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dotnet_test.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public string Name { get; set; } = "Juan";
        public string Description { get; set; } = "bla";
        public int Quantity { get; set; } = 10;
    }
}