namespace ServiceDeliveryPOE
{
    partial class ReportStatus
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
            btnSearch = new Button();
            tbID = new TextBox();
            listViewReportStatus = new ListView();
            btnBack = new Button();
            btnCleaar = new Button();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(346, 54);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbID
            // 
            tbID.Location = new Point(78, 54);
            tbID.Name = "tbID";
            tbID.PlaceholderText = "Enter Report ID";
            tbID.Size = new Size(137, 23);
            tbID.TabIndex = 1;
            tbID.TextChanged += tbID_TextChanged;
            // 
            // listViewReportStatus
            // 
            listViewReportStatus.Location = new Point(78, 129);
            listViewReportStatus.Name = "listViewReportStatus";
            listViewReportStatus.Size = new Size(601, 269);
            listViewReportStatus.TabIndex = 2;
            listViewReportStatus.UseCompatibleStateImageBehavior = false;
            listViewReportStatus.SelectedIndexChanged += listViewReportStatus_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(698, 53);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnCleaar
            // 
            btnCleaar.Location = new Point(604, 100);
            btnCleaar.Name = "btnCleaar";
            btnCleaar.Size = new Size(75, 23);
            btnCleaar.TabIndex = 4;
            btnCleaar.Text = "Reset";
            btnCleaar.UseVisualStyleBackColor = true;
            btnCleaar.Click += btnCleaar_Click;
            // 
            // ReportStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCleaar);
            Controls.Add(btnBack);
            Controls.Add(listViewReportStatus);
            Controls.Add(tbID);
            Controls.Add(btnSearch);
            Name = "ReportStatus";
            Text = "ReportStatus";
            Load += ReportStatus_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox tbID;
        private ListView listViewReportStatus;
        private Button btnBack;
        private Button btnCleaar;
    }
}