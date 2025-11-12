using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDeliveryPOE.Data;

namespace ServiceDeliveryPOE
{
    public class ReportHeap
    {
        private List<Report> heap = new List<Report> ();

        public ReportHeap (List<Report> reports)
        {
            foreach (var r in reports)
                Insert(r);
        }

        public void Insert (Report r)
        {
            heap.Add(r);
            HeapifyUp(heap.Count - 1);
        }

        public List<Report> GetSortedReports()
        {
            List<Report> sorted = new List<Report>();
            while (heap.Count > 0)
            {
                sorted.Add(ExtractMax());
            }
            return sorted;
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parent = (index - 1) / 2;
                if (heap[index].ReportId <= heap[parent].ReportId) break;

                var temp = heap[index];
                heap[index] = heap[parent];
                heap[parent] = temp;

                index = parent;
            }
        }

        public Report ExtractMax()
        {
            if (heap.Count == 0)
                return null;

            var max = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);
            return max;
        }

        private void HeapifyDown(int index)
        {
            int left, right, largest;

            while (true)
            {
                left = 2 * index + 1;
                right = 2 * index + 2;
                largest = index;

                if (left < heap.Count && heap[left].ReportId > heap[largest].ReportId)
                    largest = left;
                if (right < heap.Count && heap[right].ReportId > heap[largest].ReportId)
                    largest = right;

                if (largest == index) break;

                var temp = heap[index];
                heap[index] = heap[largest];
                heap[largest] = temp;

                index = largest;
            }
        }
    }
}
