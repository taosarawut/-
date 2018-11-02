using System;
using System.Collections.Generic;

namespace taolovemild.Models
{
    public partial class Customer
    {
        public string CustId { get; set; }
        public string InitialCode { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public short? CustType { get; set; }
    }
}
