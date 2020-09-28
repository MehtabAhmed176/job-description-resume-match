namespace ResumeScanner
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.upload_resume_btn = new System.Windows.Forms.Button();
            this.job_description_txtBox = new System.Windows.Forms.TextBox();
            this.match_label = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.shuttonDownButton = new System.Windows.Forms.PictureBox();
            this.shutdoew_label = new System.Windows.Forms.Label();
            this.jdLabel = new MetroFramework.Controls.MetroLabel();
            this.overalljbLabel = new MetroFramework.Controls.MetroLabel();
            this.uploadedFileNameLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shuttonDownButton)).BeginInit();
            this.SuspendLayout();
            // 
            // upload_resume_btn
            // 
            this.upload_resume_btn.BackColor = System.Drawing.Color.Crimson;
            this.upload_resume_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.upload_resume_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_resume_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.upload_resume_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.upload_resume_btn.Location = new System.Drawing.Point(67, 630);
            this.upload_resume_btn.Name = "upload_resume_btn";
            this.upload_resume_btn.Size = new System.Drawing.Size(153, 50);
            this.upload_resume_btn.TabIndex = 0;
            this.upload_resume_btn.Text = "Upload your resume";
            this.upload_resume_btn.UseVisualStyleBackColor = false;
            this.upload_resume_btn.Click += new System.EventHandler(this.upload_resume_btn_Click);
            // 
            // job_description_txtBox
            // 
            this.job_description_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.job_description_txtBox.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_description_txtBox.Location = new System.Drawing.Point(67, 66);
            this.job_description_txtBox.Multiline = true;
            this.job_description_txtBox.Name = "job_description_txtBox";
            this.job_description_txtBox.Size = new System.Drawing.Size(654, 558);
            this.job_description_txtBox.TabIndex = 1;
            this.job_description_txtBox.Text = "Mehtab Ahmed\r\nBahnhofstrasse 47,\r\nDeggendorf, 94469\r\n01-521-466-5217\r\nahmedmehtab" +
    "176@gmail.com\r\n\r\n\r\n\r\n\r\nHiring Manager\r\n\r\nOCQ Soft GmbH\r\n\r\nDear Bjorn Kesper,\r\n\r\n" +
    "";
            // 
            // match_label
            // 
            this.match_label.AutoSize = true;
            this.match_label.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.match_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.match_label.Location = new System.Drawing.Point(750, 478);
            this.match_label.Name = "match_label";
            this.match_label.Size = new System.Drawing.Size(0, 34);
            this.match_label.TabIndex = 6;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.Red;
            this.chart1.BackSecondaryColor = System.Drawing.Color.Blue;
            this.chart1.BorderlineColor = System.Drawing.Color.DarkRed;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(768, 331);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(383, 293);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "PIE CHART";
            // 
            // shuttonDownButton
            // 
            this.shuttonDownButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shuttonDownButton.BackgroundImage")));
            this.shuttonDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shuttonDownButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("shuttonDownButton.InitialImage")));
            this.shuttonDownButton.Location = new System.Drawing.Point(1075, 671);
            this.shuttonDownButton.Name = "shuttonDownButton";
            this.shuttonDownButton.Size = new System.Drawing.Size(116, 53);
            this.shuttonDownButton.TabIndex = 8;
            this.shuttonDownButton.TabStop = false;
           this.shuttonDownButton.Click += new System.EventHandler(this.shuttonDownButton_Click);
            // 
            // shutdoew_label
            // 
            this.shutdoew_label.AutoSize = true;
            this.shutdoew_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdoew_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shutdoew_label.Location = new System.Drawing.Point(1067, 727);
            this.shutdoew_label.Name = "shutdoew_label";
            this.shutdoew_label.Size = new System.Drawing.Size(146, 19);
            this.shutdoew_label.TabIndex = 9;
            this.shutdoew_label.Text = "Press to close the App";
           this.shutdoew_label.Click += new System.EventHandler(this.shutdoew_label_Click);
            // 
            // jdLabel
            // 
            this.jdLabel.AutoSize = true;
            this.jdLabel.Location = new System.Drawing.Point(807, 271);
            this.jdLabel.Name = "jdLabel";
            this.jdLabel.Size = new System.Drawing.Size(70, 19);
            this.jdLabel.TabIndex = 10;
            this.jdLabel.Text = "Job Match";
            // 
            // overalljbLabel
            // 
            this.overalljbLabel.AutoSize = true;
            this.overalljbLabel.Location = new System.Drawing.Point(814, 66);
            this.overalljbLabel.Name = "overalljbLabel";
            this.overalljbLabel.Size = new System.Drawing.Size(47, 19);
            this.overalljbLabel.TabIndex = 11;
            this.overalljbLabel.Text = "Details";
            // 
            // uploadedFileNameLabel
            // 
            this.uploadedFileNameLabel.AutoSize = true;
            this.uploadedFileNameLabel.Location = new System.Drawing.Point(227, 645);
            this.uploadedFileNameLabel.Name = "uploadedFileNameLabel";
            this.uploadedFileNameLabel.Size = new System.Drawing.Size(0, 0);
            this.uploadedFileNameLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 758);
            this.ControlBox = false;
            this.Controls.Add(this.uploadedFileNameLabel);
            this.Controls.Add(this.overalljbLabel);
            this.Controls.Add(this.jdLabel);
            this.Controls.Add(this.shutdoew_label);
            this.Controls.Add(this.shuttonDownButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.match_label);
            this.Controls.Add(this.job_description_txtBox);
            this.Controls.Add(this.upload_resume_btn);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Job Scanner";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shuttonDownButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upload_resume_btn;
        private System.Windows.Forms.TextBox job_description_txtBox;
        private System.Windows.Forms.Label match_label;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox shuttonDownButton;
        private System.Windows.Forms.Label shutdoew_label;
        private MetroFramework.Controls.MetroLabel jdLabel;
        private MetroFramework.Controls.MetroLabel overalljbLabel;
        private MetroFramework.Controls.MetroLabel uploadedFileNameLabel;
    }
}

