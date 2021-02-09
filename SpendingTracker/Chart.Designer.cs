namespace SpendingTracker
{
    partial class Chart
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
            this.chartPurchases = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartPurchases)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPurchases
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPurchases.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPurchases.Legends.Add(legend1);
            this.chartPurchases.Location = new System.Drawing.Point(8, 16);
            this.chartPurchases.Name = "chartPurchases";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Purchases";
            this.chartPurchases.Series.Add(series1);
            this.chartPurchases.Size = new System.Drawing.Size(568, 392);
            this.chartPurchases.TabIndex = 0;
            this.chartPurchases.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Purchases Chart";
            this.chartPurchases.Titles.Add(title1);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(248, 432);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(96, 32);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 483);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.chartPurchases);
            this.Name = "Chart";
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPurchases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPurchases;
        private System.Windows.Forms.Button buttonOK;
    }
}