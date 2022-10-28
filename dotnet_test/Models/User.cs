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
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Pedro";
        public string Email { get; set; } = "pedro.com";
        public int Phone { get; set; } = 1234;
        public UserType Type { get; set; }  
    }
}