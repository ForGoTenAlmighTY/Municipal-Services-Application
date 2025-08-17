namespace Municipal_Services_Application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnReport = new Button();
            btnEvents = new Button();
            btnStatus = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Bright", 14.25F);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(228, 38);
            label1.Name = "label1";
            label1.Size = new Size(341, 22);
            label1.TabIndex = 0;
            label1.Text = "Welcome To The Municipal Services\r\n";
            // 
            // btnReport
            // 
            btnReport.Font = new Font("Lucida Bright", 9F);
            btnReport.Location = new Point(316, 140);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(119, 37);
            btnReport.TabIndex = 1;
            btnReport.Text = "Report Issues";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnEvents
            // 
            btnEvents.Font = new Font("Lucida Bright", 9F);
            btnEvents.Location = new Point(316, 210);
            btnEvents.Name = "btnEvents";
            btnEvents.Size = new Size(119, 44);
            btnEvents.TabIndex = 2;
            btnEvents.Text = "Local Events and Accouncements";
            btnEvents.UseVisualStyleBackColor = true;
            btnEvents.Click += btnEvents_Click;
            // 
            // btnStatus
            // 
            btnStatus.Font = new Font("Lucida Bright", 9F);
            btnStatus.Location = new Point(316, 288);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(119, 40);
            btnStatus.TabIndex = 3;
            btnStatus.Text = "Service Request Status";
            btnStatus.UseVisualStyleBackColor = true;
            btnStatus.Click += btnStatus_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Bright", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(295, 87);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 4;
            label2.Text = "Please Select A Task:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnStatus);
            Controls.Add(btnEvents);
            Controls.Add(btnReport);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnReport;
        private Button btnEvents;
        private Button btnStatus;
        private Label label2;
    }
}
