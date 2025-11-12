namespace ServiceDeliveryPOE
{
    partial class ReportDetailsForm
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
            locationLbl = new Label();
            categoryLbl = new Label();
            descriptionLbl = new Label();
            submittedPb = new PictureBox();
            Success = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)submittedPb).BeginInit();
            SuspendLayout();
            // 
            // locationLbl
            // 
            locationLbl.AutoSize = true;
            locationLbl.Location = new Point(120, 51);
            locationLbl.Name = "locationLbl";
            locationLbl.Size = new Size(38, 15);
            locationLbl.TabIndex = 0;
            locationLbl.Text = "label1";
            // 
            // categoryLbl
            // 
            categoryLbl.AutoSize = true;
            categoryLbl.Location = new Point(120, 137);
            categoryLbl.Name = "categoryLbl";
            categoryLbl.Size = new Size(38, 15);
            categoryLbl.TabIndex = 1;
            categoryLbl.Text = "label2";
            // 
            // descriptionLbl
            // 
            descriptionLbl.AutoSize = true;
            descriptionLbl.Location = new Point(120, 222);
            descriptionLbl.Name = "descriptionLbl";
            descriptionLbl.Size = new Size(38, 15);
            descriptionLbl.TabIndex = 2;
            descriptionLbl.Text = "label3";
            // 
            // submittedPb
            // 
            submittedPb.Location = new Point(374, 204);
            submittedPb.Name = "submittedPb";
            submittedPb.Size = new Size(225, 182);
            submittedPb.TabIndex = 3;
            submittedPb.TabStop = false;
            // 
            // Success
            // 
            Success.AutoSize = true;
            Success.ForeColor = Color.FromArgb(0, 192, 0);
            Success.Location = new Point(374, 26);
            Success.Name = "Success";
            Success.Size = new Size(48, 15);
            Success.TabIndex = 4;
            Success.Text = "Success";
            // 
            // button1
            // 
            button1.Location = new Point(661, 37);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReportDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Success);
            Controls.Add(submittedPb);
            Controls.Add(descriptionLbl);
            Controls.Add(categoryLbl);
            Controls.Add(locationLbl);
            Name = "ReportDetailsForm";
            Text = "ReportDetailsForm";
            Load += ReportDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)submittedPb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label locationLbl;
        private Label categoryLbl;
        private Label descriptionLbl;
        private PictureBox submittedPb;
        private Label Success;
        private Button button1;
    }
}