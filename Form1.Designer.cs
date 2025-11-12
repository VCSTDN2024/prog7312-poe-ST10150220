namespace ServiceDeliveryPOE
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
            reportMenuBtn = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // reportMenuBtn
            // 
            reportMenuBtn.Location = new Point(321, 75);
            reportMenuBtn.Name = "reportMenuBtn";
            reportMenuBtn.Size = new Size(133, 43);
            reportMenuBtn.TabIndex = 0;
            reportMenuBtn.Text = "Report";
            reportMenuBtn.UseVisualStyleBackColor = true;
            reportMenuBtn.Click += reportMenuBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(321, 182);
            button2.Name = "button2";
            button2.Size = new Size(133, 43);
            button2.TabIndex = 1;
            button2.Text = "Local Events and Announcments";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(321, 292);
            button3.Name = "button3";
            button3.Size = new Size(133, 43);
            button3.TabIndex = 2;
            button3.Text = "Status";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(reportMenuBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button reportMenuBtn;
        private Button button2;
        private Button button3;
    }
}
