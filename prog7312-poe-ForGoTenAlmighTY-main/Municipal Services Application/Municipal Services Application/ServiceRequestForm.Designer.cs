namespace Municipal_Services_Application
{
    partial class ServiceRequestForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label5 = new Label();
            label7 = new Label();
            txtRequestID = new TextBox();
            btnSearchRequest = new Button();
            txtDescription = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            txtPriority = new TextBox();
            label3 = new Label();
            cmbStatus = new ComboBox();
            btnAddRequest = new Button();
            btnProcessPriority = new Button();
            btnMenu = new Button();
            dataGridViewRequests = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lucida Bright", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(393, 40);
            label5.Name = "label5";
            label5.Size = new Size(216, 22);
            label5.TabIndex = 14;
            label5.Text = "Service Request Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(284, 96);
            label7.Name = "label7";
            label7.Size = new Size(139, 20);
            label7.TabIndex = 23;
            label7.Text = "Enter Request ID";
            // 
            // txtRequestID
            // 
            txtRequestID.Location = new Point(284, 126);
            txtRequestID.Name = "txtRequestID";
            txtRequestID.Size = new Size(188, 23);
            txtRequestID.TabIndex = 24;
            // 
            // btnSearchRequest
            // 
            btnSearchRequest.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchRequest.Location = new Point(284, 443);
            btnSearchRequest.Name = "btnSearchRequest";
            btnSearchRequest.Size = new Size(124, 45);
            btnSearchRequest.TabIndex = 25;
            btnSearchRequest.Text = "Search Request by ID";
            btnSearchRequest.UseVisualStyleBackColor = true;
            btnSearchRequest.Click += btnSearchRequest_Click;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(284, 187);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(294, 59);
            txtDescription.TabIndex = 26;
            txtDescription.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(284, 164);
            label1.Name = "label1";
            label1.Size = new Size(228, 20);
            label1.TabIndex = 27;
            label1.Text = "Description Of The Request:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(284, 259);
            label2.Name = "label2";
            label2.Size = new Size(231, 20);
            label2.TabIndex = 28;
            label2.Text = "Priority Of The Request: (1-5)";
            // 
            // txtPriority
            // 
            txtPriority.Location = new Point(284, 282);
            txtPriority.Name = "txtPriority";
            txtPriority.Size = new Size(188, 23);
            txtPriority.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(284, 319);
            label3.Name = "label3";
            label3.Size = new Size(186, 20);
            label3.TabIndex = 30;
            label3.Text = "Status Of The Request:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending", "In Progress", "Completed" });
            cmbStatus.Location = new Point(284, 342);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(150, 23);
            cmbStatus.TabIndex = 31;
            // 
            // btnAddRequest
            // 
            btnAddRequest.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddRequest.Location = new Point(393, 380);
            btnAddRequest.Name = "btnAddRequest";
            btnAddRequest.Size = new Size(139, 41);
            btnAddRequest.TabIndex = 32;
            btnAddRequest.Text = "Add Request";
            btnAddRequest.UseVisualStyleBackColor = true;
            btnAddRequest.Click += btnAddRequest_Click;
            // 
            // btnProcessPriority
            // 
            btnProcessPriority.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProcessPriority.Location = new Point(512, 443);
            btnProcessPriority.Name = "btnProcessPriority";
            btnProcessPriority.Size = new Size(123, 45);
            btnProcessPriority.TabIndex = 33;
            btnProcessPriority.Text = "Process Priority";
            btnProcessPriority.UseVisualStyleBackColor = true;
            btnProcessPriority.Click += btnProcessPriority_Click;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(404, 688);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(111, 42);
            btnMenu.TabIndex = 35;
            btnMenu.Text = "Main Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // dataGridViewRequests
            // 
            dataGridViewRequests.AllowUserToAddRows = false;
            dataGridViewRequests.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewRequests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRequests.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewRequests.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewRequests.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewRequests.GridColor = SystemColors.ControlText;
            dataGridViewRequests.Location = new Point(207, 505);
            dataGridViewRequests.Name = "dataGridViewRequests";
            dataGridViewRequests.ReadOnly = true;
            dataGridViewRequests.Size = new Size(564, 155);
            dataGridViewRequests.TabIndex = 36;
            // 
            // ServiceRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 757);
            Controls.Add(dataGridViewRequests);
            Controls.Add(btnMenu);
            Controls.Add(btnProcessPriority);
            Controls.Add(btnAddRequest);
            Controls.Add(cmbStatus);
            Controls.Add(label3);
            Controls.Add(txtPriority);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(btnSearchRequest);
            Controls.Add(txtRequestID);
            Controls.Add(label7);
            Controls.Add(label5);
            Name = "ServiceRequestForm";
            Text = "ServiceRequestForm";
            Load += ServiceRequestForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label7;
        private TextBox txtRequestID;
        private Button btnSearchRequest;
        private RichTextBox txtDescription;
        private Label label1;
        private Label label2;
        private TextBox txtPriority;
        private Label label3;
        private ComboBox cmbStatus;
        private Button btnAddRequest;
        private Button btnProcessPriority;
        private Button btnMenu;
        private DataGridView dataGridViewRequests;
    }
}