namespace Municipal_Services_Application
{
    partial class Report_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            txtLocation = new TextBox();
            listCategory = new ListBox();
            txtDescription = new RichTextBox();
            txtFile = new TextBox();
            btnFile = new Button();
            btnMenu = new Button();
            btnSubmit = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnShowIssues = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(231, 75);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 2;
            label2.Text = "Location Of The Issue:";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(232, 99);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(274, 23);
            txtLocation.TabIndex = 3;
            // 
            // listCategory
            // 
            listCategory.BorderStyle = BorderStyle.FixedSingle;
            listCategory.FormattingEnabled = true;
            listCategory.ItemHeight = 15;
            listCategory.Items.AddRange(new object[] { "Sanitation", "Electricity", "Water", "Roads", "Waste", "Infastructure" });
            listCategory.Location = new Point(235, 160);
            listCategory.Name = "listCategory";
            listCategory.Size = new Size(134, 92);
            listCategory.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(230, 295);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(294, 59);
            txtDescription.TabIndex = 7;
            txtDescription.Text = "";
            // 
            // txtFile
            // 
            txtFile.Location = new Point(321, 358);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(203, 23);
            txtFile.TabIndex = 8;
            // 
            // btnFile
            // 
            btnFile.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFile.Location = new Point(229, 359);
            btnFile.Name = "btnFile";
            btnFile.Size = new Size(94, 23);
            btnFile.TabIndex = 9;
            btnFile.Text = "Attach A File";
            btnFile.UseVisualStyleBackColor = true;
            btnFile.Click += btnFile_Click;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(326, 452);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(108, 37);
            btnMenu.TabIndex = 10;
            btnMenu.Text = "Main Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(416, 409);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(108, 37);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit Issue";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lucida Bright", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(187, 32);
            label5.Name = "label5";
            label5.Size = new Size(525, 22);
            label5.TabIndex = 12;
            label5.Text = "Please Enter The Required Information About The Issue";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(233, 137);
            label6.Name = "label6";
            label6.Size = new Size(273, 20);
            label6.TabIndex = 13;
            label6.Text = "Select The Category Of The Issue: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(229, 272);
            label7.Name = "label7";
            label7.Size = new Size(205, 20);
            label7.TabIndex = 14;
            label7.Text = "Description Of The Issue:";
            // 
            // btnShowIssues
            // 
            btnShowIssues.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowIssues.Location = new Point(235, 409);
            btnShowIssues.Name = "btnShowIssues";
            btnShowIssues.Size = new Size(115, 37);
            btnShowIssues.TabIndex = 15;
            btnShowIssues.Text = "Reported Issues";
            btnShowIssues.UseVisualStyleBackColor = true;
            btnShowIssues.Click += btnShowIssues_Click;
            // 
            // Report_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 519);
            Controls.Add(btnShowIssues);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnSubmit);
            Controls.Add(btnMenu);
            Controls.Add(btnFile);
            Controls.Add(txtFile);
            Controls.Add(txtDescription);
            Controls.Add(listCategory);
            Controls.Add(txtLocation);
            Controls.Add(label2);
            Name = "Report_Form";
            Text = "Report Issues";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtLocation;
        private ListBox listCategory;
        private RichTextBox txtDescription;
        private TextBox txtFile;
        private Button btnFile;
        private Button btnMenu;
        private Button btnSubmit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnShowIssues;
    }
}