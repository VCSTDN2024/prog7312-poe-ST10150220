using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDeliveryPOE.Data
{
    public class Report
    {
        public int ReportId { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public byte[] ImageData { get; set; }

        public bool? Status { get; set; }
        public string? StatusDetails { get; set; }
    }
}
