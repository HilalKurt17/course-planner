namespace myCourses
{
    partial class improvementGraph
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.improvement_chrt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.improvement_chrt)).BeginInit();
            this.SuspendLayout();
            // 
            // improvement_chrt
            // 
            this.improvement_chrt.BackColor = System.Drawing.Color.LightGray;
            this.improvement_chrt.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.improvement_chrt.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.improvement_chrt.Legends.Add(legend1);
            this.improvement_chrt.Location = new System.Drawing.Point(12, 25);
            this.improvement_chrt.Name = "improvement_chrt";
            this.improvement_chrt.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Completed Courses";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValuesPerPoint = 12;
            this.improvement_chrt.Series.Add(series1);
            this.improvement_chrt.Size = new System.Drawing.Size(967, 398);
            this.improvement_chrt.TabIndex = 0;
            this.improvement_chrt.Text = "chart1";
            title1.Name = "Completed Courses";
            title1.Text = "Completed Courses";
            this.improvement_chrt.Titles.Add(title1);
            // 
            // improvementGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(991, 448);
            this.Controls.Add(this.improvement_chrt);
            this.Name = "improvementGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROGRESS";
            this.Load += new System.EventHandler(this.improvementGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.improvement_chrt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart improvement_chrt;
    }
}