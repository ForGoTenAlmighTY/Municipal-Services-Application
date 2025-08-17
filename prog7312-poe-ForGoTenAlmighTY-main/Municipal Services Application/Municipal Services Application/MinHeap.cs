using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services_Application
{
    internal class MinHeap
    {
        private List<ServiceRequest> heap = new List<ServiceRequest>();

        // Insert a new request into the heap
        public void Insert(ServiceRequest request)
        {
            heap.Add(request);
            int index = heap.Count - 1;
            while (index > 0)
            {
                int parent = (index - 1) / 2;
                if (heap[index].Priority >= heap[parent].Priority) break;

                // Swap
                (heap[index], heap[parent]) = (heap[parent], heap[index]);
                index = parent;
            }
        }

        // Extract the request with the highest priority
        public ServiceRequest ExtractMin()
        {
            if (heap.Count == 0) return null;

            ServiceRequest min = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);

            int index = 0;
            while (index < heap.Count)
            {
                int left = 2 * index + 1;
                int right = 2 * index + 2;
                int smallest = index;

                if (left < heap.Count && heap[left].Priority < heap[smallest].Priority)
                    smallest = left;

                if (right < heap.Count && heap[right].Priority < heap[smallest].Priority)
                    smallest = right;

                if (smallest == index) break;

                // Swap
                (heap[index], heap[smallest]) = (heap[smallest], heap[index]);
                index = smallest;
            }

            return min;
        }

        public bool IsEmpty()
        {
            return heap.Count == 0;
        }
    }
}
