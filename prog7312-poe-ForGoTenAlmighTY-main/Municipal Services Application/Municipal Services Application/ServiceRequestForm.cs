using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipal_Services_Application
{
    public partial class ServiceRequestForm : Form
    {
        private BinarySearchTree bst = new BinarySearchTree(); // For storing and searching requests
        private MinHeap minHeap = new MinHeap(); // For managing request priorities


        public ServiceRequestForm()
        {
            InitializeComponent();
            // Set the background image from the Resources folder
            string imagePath = @"D:\SCHOOL\Varsity College Work\Year 3\Semester 2\PROG7312\Municipal Services Application\dda.jpg";
            this.BackgroundImage = Image.FromFile(imagePath);
            this.BackgroundImageLayout = ImageLayout.Stretch; // Stretch the image
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            string requestID = txtRequestID.Text; // Request ID from TextBox
            string description = txtDescription.Text; // Description from TextBox
            int priority;
            if (!int.TryParse(txtPriority.Text, out priority)) // Validate priority input
            {
                MessageBox.Show("Priority must be a valid number.");
                return;
            }
            string status = cmbStatus.SelectedItem?.ToString() ?? "Pending"; // Status from ComboBox

            // Create and insert the new service request
            ServiceRequest request = new ServiceRequest(requestID, description, DateTime.Now, priority, status);
            bst.Insert(request); // Insert into the Binary Search Tree
            minHeap.Insert(request); // Insert into the Min-Heap

            DisplayAllRequests(); // Refresh the display
            MessageBox.Show("Service request added successfully.");
        }

        // Display all service requests in the DataGridView
        private void DisplayAllRequests()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Request ID");
            dt.Columns.Add("Description");
            dt.Columns.Add("Submission Date");
            dt.Columns.Add("Priority");
            dt.Columns.Add("Status");

            // Traverse the Binary Search Tree and populate the DataTable
            bst.InOrderTraversal(request =>
            {
                dt.Rows.Add(request.RequestID, request.Description, request.SubmissionDate.ToShortDateString(), request.Priority, request.Status);
            });

            dataGridViewRequests.DataSource = dt; // Bind the DataTable to the DataGridView
        }

        private void btnSearchRequest_Click(object sender, EventArgs e)
        {
            string requestID = txtRequestID.Text; // Get the ID to search for
            if (string.IsNullOrEmpty(requestID))
            {
                MessageBox.Show("Please enter a Request ID to search.");
                return;
            }

            ServiceRequest request = bst.Search(requestID); // Search in the Binary Search Tree
            if (request != null)
            {
                MessageBox.Show($"Request Found:\nID: {request.RequestID}\nDescription: {request.Description}\nStatus: {request.Status}\nPriority: {request.Priority}");
            }
            else
            {
                MessageBox.Show("No service request found with the given ID.");
            }
        }

        private void btnProcessPriority_Click(object sender, EventArgs e)
        {
            ServiceRequest request = minHeap.ExtractMin(); // Get the highest-priority request
            if (request != null)
            {
                MessageBox.Show($"Processing Request:\nID: {request.RequestID}\nDescription: {request.Description}\nStatus: {request.Status}\nPriority: {request.Priority}");
                DisplayAllRequests(); // Refresh the display
            }
            else
            {
                MessageBox.Show("No service requests to process.");
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Close();
        }


        private void LoadSampleData()
        {
            // Add sample requests
            AddRequest("SR001", "Water leakage in street", 2, "Pending");
            AddRequest("SR002", "Broken streetlight", 3, "In Progress");
            AddRequest("SR003", "Garbage not collected", 1, "Pending");
            AddRequest("SR004", "Road pothole repair", 5, "Completed");
            AddRequest("SR005", "Noise complaint", 4, "Pending");

            // Display the pre-loaded data in the DataGridView
            DisplayAllRequests();
        }

        // Helper method to add requests
        private void AddRequest(string requestID, string description, int priority, string status)
        {
            // Create a new service request
            ServiceRequest request = new ServiceRequest(requestID, description, DateTime.Now, priority, status);

            // Insert into Binary Search Tree and MinHeap
            bst.Insert(request);
            minHeap.Insert(request);
        }

        private void ServiceRequestForm_Load(object sender, EventArgs e)
        {
            // Load sample data on form load
            LoadSampleData();
        }
    }
}
