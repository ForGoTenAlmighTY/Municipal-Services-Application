using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Municipal_Services_Application
{
    public partial class Report_Form : Form
    {
        // Declare a 2D list to store inputs
        List<List<string>> inputData = new List<List<string>>();

        public Report_Form()
        {
            InitializeComponent();

            // Set the background image from the Resources folder
            string imagePath = @"D:\SCHOOL\Varsity College Work\Year 3\Semester 2\PROG7312\Municipal Services Application\bg.jpg";
            this.BackgroundImage = Image.FromFile(imagePath);
            this.BackgroundImageLayout = ImageLayout.Stretch; // Stretch the image
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Close();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set properties of OpenFileDialog
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "All files (*.*)|*.*"; // Filter for specific file types
            openFileDialog.FilterIndex = 1; // Set default filter
            openFileDialog.RestoreDirectory = true; // Restore to the previously selected directory

            // Show the dialog and check if the user clicked OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of the selected file
                string filePath = openFileDialog.FileName;

                // Use the file path (e.g., read the file, display its contents, etc.)
                txtFile.Text = filePath;
                MessageBox.Show($"Selected file: {filePath}", "File Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Create a new list for a row of input data
            List<string> row = new List<string>();
            try
            {
                // Validate input: Check if the input is not empty
                if (string.IsNullOrEmpty(txtLocation.Text) || string.IsNullOrEmpty(listCategory.Text) || string.IsNullOrEmpty(txtDescription.Text))
                {
                    MessageBox.Show("Please enter all the reqiured values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  // Exit the method without adding the valus to the list
                }

                // Collect inputs from text boxes
                row.Add(txtLocation.Text);
                row.Add(listCategory.Text);
                row.Add(txtDescription.Text);
                row.Add(txtFile.Text);

                // Add the row to the 2D list
                inputData.Add(row);

                //Clearing The textboxes
                txtLocation.Clear();
                txtDescription.Clear();
                txtFile.Clear();

                // Show a message indicating the input has been stored
                MessageBox.Show("Issue Reported successfully!", "Issue Reported", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                // Handle any unexpected errors
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void btnShowIssues_Click(object sender, EventArgs e)
        {
            //Displaying the information captured 
            for (int i = 0; i < inputData.Count; i++)
            {
                MessageBox.Show("Location: " + inputData[i][0]+ 
                    "\nCategory: " + inputData[i][1]+
                    "\nDescription: " + inputData[i][2]+
                    "\nFile name: " + inputData[i][3]
                    , "Reported Issue: "+(i+1), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
