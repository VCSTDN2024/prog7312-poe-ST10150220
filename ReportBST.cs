using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDeliveryPOE.Data;

namespace ServiceDeliveryPOE
{
    public class ReportBST
    {
        private ReportNode root;

        public ReportBST(List<Report> reports)
        {
            foreach (var r in reports)
            {
                Insert(r);
            }
        }

        public void Insert(Report r) {
            root = InsertRecursive(root, r);
                }

        private ReportNode InsertRecursive(ReportNode node, Report report)
        {
            if(node == null)
                return new ReportNode(report);

            if(report.ReportId < node.ReportData.ReportId)
                node.Left = InsertRecursive(node.Left, report);
            else if (report.ReportId > node.ReportData.ReportId)
                node.Right = InsertRecursive(node.Right, report);
            return node;
        }

        public Report Search (int reportId)
        {
            return SearchRecursive(root, reportId);
        }

        private Report SearchRecursive(ReportNode node,  int reportId)
        {
            if (node == null)
                return null;

            if (reportId == node.ReportData.ReportId)
                return node.ReportData;

            if (reportId < node.ReportData.ReportId)
                return SearchRecursive(node.Left, reportId);
            else
                return SearchRecursive(node.Right, reportId);
        }

    }
}
