namespace Municipal_Services_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set the background image from the Resources folder
            string imagePath = @"D:\SCHOOL\Varsity College Work\Year 3\Semester 2\PROG7312\Municipal Services Application\bg.jpg";
            this.BackgroundImage = Image.FromFile(imagePath);
            this.BackgroundImageLayout = ImageLayout.Stretch; // Stretch the image

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report_Form report_Form = new Report_Form();
            report_Form.Show();

            this.Hide();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            Events events = new Events();
            events.Show();

            this.Hide();

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            ServiceRequestForm service = new ServiceRequestForm();
            service.Show();

            this.Hide();
        }
    }
}
