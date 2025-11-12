using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDeliveryPOE.Data;

namespace ServiceDeliveryPOE
{
    public class ReportNode
    {
        public Report ReportData;
        public ReportNode Left;
        public ReportNode Right;

        public ReportNode(Report report)
        {
            ReportData = report;
            Left = null;
            Right = null;
        }
    }
}
