
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.IndGphCancelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TotalsBtn = new System.Windows.Forms.Button();
            this.DailyAvgBtn = new System.Windows.Forms.Button();
            this.cnp_controller = new System.Windows.Forms.Panel();
            this.animalListTxb = new System.Windows.Forms.TextBox();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.nameTtl = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.cnp_controller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.TotalsBtn);
            this.groupBox1.Controls.Add(this.DailyAvgBtn);
            this.groupBox1.Controls.Add(this.cnp_controller);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.groupBox1.Location = new System.Drawing.Point(540, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 340);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weekly Data";
            // 
            // TotalsBtn
            // 
            this.TotalsBtn.BackColor = System.Drawing.Color.LightGray;
            this.TotalsBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.TotalsBtn.Location = new System.Drawing.Point(0, 312);
            this.TotalsBtn.Name = "TotalsBtn";
            this.TotalsBtn.Size = new System.Drawing.Size(121, 28);
            this.TotalsBtn.TabIndex = 2;
            this.TotalsBtn.Text = "Totals";
            this.TotalsBtn.UseVisualStyleBackColor = false;
            this.TotalsBtn.Click += new System.EventHandler(this.totalsBtn_Click);
            // 
            // DailyAvgBtn
            // 
            this.DailyAvgBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DailyAvgBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.DailyAvgBtn.Location = new System.Drawing.Point(123, 312);
            this.DailyAvgBtn.Name = "DailyAvgBtn";
            this.DailyAvgBtn.Size = new System.Drawing.Size(121, 28);
            this.DailyAvgBtn.TabIndex = 3;
            this.DailyAvgBtn.Text = "Daily Averages";
            this.DailyAvgBtn.UseVisualStyleBackColor = false;
            this.DailyAvgBtn.Click += new System.EventHandler(this.dailyAvgBtn_Click);
            // 
            // cnp_controller
            // 
            this.cnp_controller.AllowDrop = true;
            this.cnp_controller.AutoScroll = true;
            this.cnp_controller.AutoSize = true;
            this.cnp_controller.Controls.Add(this.animalListTxb);
            this.cnp_controller.Location = new System.Drawing.Point(6, 35);
            this.cnp_controller.MaximumSize = new System.Drawing.Size(230, 280);
            this.cnp_controller.Name = "cnp_controller";
            this.cnp_controller.Padding = new System.Windows.Forms.Padding(20);
            this.cnp_controller.Size = new System.Drawing.Size(230, 271);
            this.cnp_controller.TabIndex = 7;
            // 
            // animalListTxb
            // 
            this.animalListTxb.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.animalListTxb.Location = new System.Drawing.Point(0, 0);
            this.animalListTxb.Multiline = true;
            this.animalListTxb.Name = "animalListTxb";
            this.animalListTxb.ReadOnly = true;
            this.animalListTxb.Size = new System.Drawing.Size(230, 25);
            this.animalListTxb.TabIndex = 1;
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.AutoSize = true;
            this.totalCostLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLbl.Location = new System.Drawing.Point(578, 355);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(86, 22);
            this.totalCostLbl.TabIndex = 10;
            this.totalCostLbl.Text = "Total Cost: ";
            // 
            // nameTtl
            // 
            this.nameTtl.AutoSize = true;
            this.nameTtl.Font = new System.Drawing.Font("Palatino Linotype", 24F);
            this.nameTtl.Location = new System.Drawing.Point(170, 12);
            this.nameTtl.Name = "nameTtl";
            this.nameTtl.Size = new System.Drawing.Size(107, 44);
            this.nameTtl.TabIndex = 8;
            this.nameTtl.Text = "Name";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 80);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Food";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(518, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            title1.Name = "Food";
            this.chart1.Titles.Add(title1);
            // 
            // IndividualGraph
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalCostLbl);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.nameTtl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.IndGphCancelBtn);
            this.Name = "IndividualGraph";
            this.Text = "IndividualGraph";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cnp_controller.ResumeLayout(false);
            this.cnp_controller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button IndGphCancelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel cnp_controller;
        private System.Windows.Forms.Label nameTtl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label totalCostLbl;
        private System.Windows.Forms.TextBox animalListTxb;
        private System.Windows.Forms.Button DailyAvgBtn;
        private System.Windows.Forms.Button TotalsBtn;
    }
}