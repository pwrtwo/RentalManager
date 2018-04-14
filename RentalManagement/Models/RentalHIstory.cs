using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalManagement.Models
{
    public class RentalHistory
    {
        public Guid ID { get; set; }
        public FullAddress FullAddress { get; set; }
        public bool Counter { get; set; }
    }
}