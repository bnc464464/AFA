
namespace AFA
{
    partial class IndividualGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.IndGphCancelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cnp_controller = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(44, 67);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Food";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(518, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F);
            this.label1.Location = new System.Drawing.Point(260, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // IndGphCancelBtn
            // 
            this.IndGphCancelBtn.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.IndGphCancelBtn.Location = new System.Drawing.Point(582, 386);
            this.IndGphCancelBtn.Name = "IndGphCancelBtn";
            this.IndGphCancelBtn.Size = new System.Drawing.Size(202, 52);
            this.IndGphCancelBtn.TabIndex = 5;
            this.IndGphCancelBtn.Text = "Exit";
            this.IndGphCancelBtn.UseVisualStyleBackColor = true;
            this.IndGphCancelBtn.Click += new System.EventHandler(this.IndGphCancelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.groupBox1.Location = new System.Drawing.Point(561, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 368);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weekly Food Average";
            // 
            // cnp_controller
            // 
            this.cnp_controller.AutoScroll = true;
            this.cnp_controller.AutoScrollMargin = new System.Drawing.Size(100, 0);
            this.cnp_controller.AutoScrollMinSize = new System.Drawing.Size(100, 0);
            this.cnp_controller.Location = new System.Drawing.Point(561, 48);
            this.cnp_controller.Name = "cnp_controller";
            this.cnp_controller.Size = new System.Drawing.Size(242, 329);
            this.cnp_controller.TabIndex = 7;
            // 
            // IndividualGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cnp_controller);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.IndGphCancelBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "IndividualGraph";
            this.Text = "IndividualGraph";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IndGphCancelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel cnp_controller;
    }
}