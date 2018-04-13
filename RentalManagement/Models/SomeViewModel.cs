using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalManagement.Models
{
    public class SomeViewModel
    {
        public IEnumerable<Asset> Assets { get; set; }
        public IEnumerable<FullAddress> FullAddresses { get; set; }
        public IEnumerable<Tenant> Tenants { get; set; }
        public IEnumerable<Occupancy> Occupancies { get; set; }
        public IEnumerable<MaintenanceRequest> MaintenanceRequests { get; set; }
        public IEnumerable<Rental> Rentals { get; set; }
    }
}