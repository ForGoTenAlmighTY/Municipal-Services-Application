namespace Municipal_Services_Application
{
    partial class Events
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
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            comboBoxCategory = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            btnSearch = new Button();
            btnMainMenu = new Button();
            btnPriority = new Button();
            btnShowSearchHistory = new Button();
            btnReset = new Button();
            btnSearchByName = new Button();
            label7 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = SystemColors.ControlText;
            dataGridView1.Location = new Point(256, 326);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(518, 295);
            dataGridView1.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(326, 155);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(302, 23);
            txtSearch.TabIndex = 2;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Music", "Conferences", "Sports", "Art", "Food", "Education", "Volunteer", "Festivals", "Health", "Business" });
            comboBoxCategory.Location = new Point(326, 230);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(121, 23);
            comboBoxCategory.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(496, 230);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lucida Bright", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(335, 48);
            label5.Name = "label5";
            label5.Size = new Size(321, 22);
            label5.TabIndex = 13;
            label5.Text = "Local Events and Announcements";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(364, 272);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 37);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainMenu.Location = new Point(446, 695);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(115, 37);
            btnMainMenu.TabIndex = 17;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnPriority
            // 
            btnPriority.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPriority.Location = new Point(578, 642);
            btnPriority.Name = "btnPriority";
            btnPriority.Size = new Size(143, 37);
            btnPriority.TabIndex = 18;
            btnPriority.Text = "High Priority Events";
            btnPriority.UseVisualStyleBackColor = true;
            btnPriority.Click += btnPriority_Click;
            // 
            // btnShowSearchHistory
            // 
            btnShowSearchHistory.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowSearchHistory.Location = new Point(541, 272);
            btnShowSearchHistory.Name = "btnShowSearchHistory";
            btnShowSearchHistory.Size = new Size(115, 37);
            btnShowSearchHistory.TabIndex = 19;
            btnShowSearchHistory.Text = "Search History";
            btnShowSearchHistory.UseVisualStyleBackColor = true;
            btnShowSearchHistory.Click += btnShowSearchHistory_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(308, 642);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(115, 37);
            btnReset.TabIndex = 20;
            btnReset.Text = "Reset Table";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSearchByName
            // 
            btnSearchByName.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchByName.Location = new Point(648, 155);
            btnSearchByName.Name = "btnSearchByName";
            btnSearchByName.Size = new Size(113, 31);
            btnSearchByName.TabIndex = 21;
            btnSearchByName.Text = "Search";
            btnSearchByName.UseVisualStyleBackColor = true;
            btnSearchByName.Click += btnSearchByName_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(326, 132);
            label7.Name = "label7";
            label7.Size = new Size(176, 20);
            label7.TabIndex = 22;
            label7.Text = "Search Event By Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(326, 207);
            label1.Name = "label1";
            label1.Size = new Size(280, 20);
            label1.TabIndex = 23;
            label1.Text = "Search Event By Category and Date:";
            // 
            // Events
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 758);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(btnSearchByName);
            Controls.Add(btnReset);
            Controls.Add(btnShowSearchHistory);
            Controls.Add(btnPriority);
            Controls.Add(btnMainMenu);
            Controls.Add(btnSearch);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBoxCategory);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Name = "Events";
            Text = "Events";
            Load += Events_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private ComboBox comboBoxCategory;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Button btnSearch;
        private Button btnMainMenu;
        private Button btnPriority;
        private Button btnShowSearchHistory;
        private Button btnReset;
        private Button btnSearchByName;
        private Label label7;
        private Label label1;
    }
}