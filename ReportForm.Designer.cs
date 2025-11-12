namespace ServiceDeliveryPOE
{
    partial class ReportForm
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
            locationTxt = new TextBox();
            descriptionRichTxt = new RichTextBox();
            submitBtn = new Button();
            reportProgBar = new ProgressBar();
            categoryListBox = new ListBox();
            reportImagePb = new PictureBox();
            uploadBtn = new Button();
            backButton = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)reportImagePb).BeginInit();
            SuspendLayout();
            // 
            // locationTxt
            // 
            locationTxt.Location = new Point(69, 43);
            locationTxt.Name = "locationTxt";
            locationTxt.PlaceholderText = "Enter Location";
            locationTxt.Size = new Size(223, 23);
            locationTxt.TabIndex = 1;
            locationTxt.TextChanged += locationTxt_TextChanged;
            // 
            // descriptionRichTxt
            // 
            descriptionRichTxt.Location = new Point(482, 93);
            descriptionRichTxt.Name = "descriptionRichTxt";
            descriptionRichTxt.Size = new Size(421, 230);
            descriptionRichTxt.TabIndex = 2;
            descriptionRichTxt.Text = "";
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(828, 432);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(75, 23);
            submitBtn.TabIndex = 3;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // reportProgBar
            // 
            reportProgBar.Location = new Point(327, 496);
            reportProgBar.Name = "reportProgBar";
            reportProgBar.Size = new Size(299, 23);
            reportProgBar.TabIndex = 4;
            reportProgBar.Click += reportProgBar_Click;
            // 
            // categoryListBox
            // 
            categoryListBox.FormattingEnabled = true;
            categoryListBox.Items.AddRange(new object[] { "Cable Theft", "Illegal Connection", "Loose Power Cables", "Pothole", "Power Outage", "Road Hazard", "Road Works Needed", "Robots Out", "Sewage Leak", "Streetlights not working", "Water leak" });
            categoryListBox.Location = new Point(68, 117);
            categoryListBox.Name = "categoryListBox";
            categoryListBox.Size = new Size(176, 94);
            categoryListBox.TabIndex = 5;
            categoryListBox.SelectedIndexChanged += categoryListBox_SelectedIndexChanged;
            // 
            // reportImagePb
            // 
            reportImagePb.Location = new Point(69, 229);
            reportImagePb.Name = "reportImagePb";
            reportImagePb.Size = new Size(175, 149);
            reportImagePb.TabIndex = 6;
            reportImagePb.TabStop = false;
            reportImagePb.Click += reportImagePb_Click;
            // 
            // uploadBtn
            // 
            uploadBtn.Location = new Point(169, 401);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(75, 23);
            uploadBtn.TabIndex = 7;
            uploadBtn.Text = "Add Image";
            uploadBtn.UseVisualStyleBackColor = true;
            uploadBtn.Click += uploadBtn_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(843, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 8;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(482, 75);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 9;
            label1.Text = "Enter Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 93);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 10;
            label2.Text = "Select Category";
            label2.Click += label2_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(969, 552);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(backButton);
            Controls.Add(uploadBtn);
            Controls.Add(reportImagePb);
            Controls.Add(categoryListBox);
            Controls.Add(reportProgBar);
            Controls.Add(submitBtn);
            Controls.Add(descriptionRichTxt);
            Controls.Add(locationTxt);
            Name = "ReportForm";
            Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)reportImagePb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox locationTxt;
        private RichTextBox descriptionRichTxt;
        private Button submitBtn;
        private ProgressBar reportProgBar;
        private ListBox categoryListBox;
        private PictureBox reportImagePb;
        private Button uploadBtn;
        private Button backButton;
        private Label label1;
        private Label label2;
    }
}