using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services_Application
{
    internal class ServiceRequest
    {
        public string RequestID { get; set; } // Unique identifier for each request
        public string Description { get; set; } // Description of the request
        public DateTime SubmissionDate { get; set; } // Submission date of the request
        public int Priority { get; set; } // Priority of the request (lower number = higher priority)
        public string Status { get; set; } // Current status of the request (Pending, In Progress, Completed)

        public ServiceRequest(string requestID, string description, DateTime submissionDate, int priority, string status)
        {
            RequestID = requestID;
            Description = description;
            SubmissionDate = submissionDate;
            Priority = priority;
            Status = status;
        }
    }
}
