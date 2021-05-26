
namespace AFA
{
    partial class CompleteGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.animalCtr = new System.Windows.Forms.TabControl();
            this.catValues = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dogValues = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cnpControllerDog = new System.Windows.Forms.Panel();
            this.birdValues = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cnpControllerBird = new System.Windows.Forms.Panel();
            this.horseValues = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ComGphCancelBtn = new System.Windows.Forms.Button();
            this.cnpControllerCat = new System.Windows.Forms.Panel();
            this.cnpControllerHorse = new System.Windows.Forms.Panel();
            this.animalCtr.SuspendLayout();
            this.catValues.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.dogValues.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.birdValues.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.horseValues.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // animalCtr
            // 
            this.animalCtr.Controls.Add(this.catValues);
            this.animalCtr.Controls.Add(this.dogValues);
            this.animalCtr.Controls.Add(this.birdValues);
            this.animalCtr.Controls.Add(this.horseValues);
            this.animalCtr.Location = new System.Drawing.Point(531, 12);
            this.animalCtr.Name = "animalCtr";
            this.animalCtr.SelectedIndex = 0;
            this.animalCtr.Size = new System.Drawing.Size(272, 368);
            this.animalCtr.TabIndex = 0;
            // 
            // catValues
            // 
            this.catValues.Controls.Add(this.groupBox1);
            this.catValues.Location = new System.Drawing.Point(4, 22);
            this.catValues.Name = "catValues";
            this.catValues.Padding = new System.Windows.Forms.Padding(3);
            this.catValues.Size = new System.Drawing.Size(264, 342);
            this.catValues.TabIndex = 0;
            this.catValues.Text = "Cat Food";
            this.catValues.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cnpControllerCat);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 368);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weekly Food Average";
            // 
            // dogValues
            // 
            this.dogValues.Controls.Add(this.groupBox2);
            this.dogValues.Location = new System.Drawing.Point(4, 22);
            this.dogValues.Name = "dogValues";
            this.dogValues.Padding = new System.Windows.Forms.Padding(3);
            this.dogValues.Size = new System.Drawing.Size(264, 342);
            this.dogValues.TabIndex = 1;
            this.dogValues.Text = "Dog Food";
            this.dogValues.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cnpControllerDog);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.groupBox2.Location = new System.Drawing.Point(8, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 368);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weekly Food Average";
            // 
            // cnpControllerDog
            // 
            this.cnpControllerDog.AutoScroll = true;
            this.cnpControllerDog.AutoScrollMargin = new System.Drawing.Size(100, 0);
            this.cnpControllerDog.AutoScrollMinSize = new System.Drawing.Size(100, 0);
            this.cnpControllerDog.Location = new System.Drawing.Point(2, 35);
            this.cnpControllerDog.Name = "cnpControllerDog";
            this.cnpControllerDog.Size = new System.Drawing.Size(242, 307);
            this.cnpControllerDog.TabIndex = 8;
            // 
            // birdValues
            // 
            this.birdValues.Controls.Add(this.groupBox3);
            this.birdValues.Location = new System.Drawing.Point(4, 22);
            this.birdValues.Name = "birdValues";
            this.birdValues.Size = new System.Drawing.Size(264, 342);
            this.birdValues.TabIndex = 2;
            this.birdValues.Text = "Bird Food";
            this.birdValues.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cnpControllerBird);
            this.groupBox3.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.groupBox3.Location = new System.Drawing.Point(8, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 368);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Weekly Food Average";
            // 
            // cnpControllerBird
            // 
            this.cnpControllerBird.AutoScroll = true;
            this.cnpControllerBird.AutoScrollMargin = new System.Drawing.Size(100, 0);
            this.cnpControllerBird.AutoScrollMinSize = new System.Drawing.Size(100, 0);
            this.cnpControllerBird.Location = new System.Drawing.Point(2, 35);
            this.cnpControllerBird.Name = "cnpControllerBird";
            this.cnpControllerBird.Size = new System.Drawing.Size(242, 307);
            this.cnpControllerBird.TabIndex = 8;
            // 
            // horseValues
            // 
            this.horseValues.Controls.Add(this.groupBox4);
            this.horseValues.Location = new System.Drawing.Point(4, 22);
            this.horseValues.Name = "horseValues";
            this.horseValues.Size = new System.Drawing.Size(264, 342);
            this.horseValues.TabIndex = 3;
            this.horseValues.Text = "Horse Food";
            this.horseValues.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cnpControllerHorse);
            this.groupBox4.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.groupBox4.Location = new System.Drawing.Point(8, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 368);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Weekly Food Average";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(7, 80);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Food";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(518, 300);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // ComGphCancelBtn
            // 
            this.ComGphCancelBtn.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.ComGphCancelBtn.Location = new System.Drawing.Point(571, 386);
            this.ComGphCancelBtn.Name = "ComGphCancelBtn";
            this.ComGphCancelBtn.Size = new System.Drawing.Size(202, 52);
            this.ComGphCancelBtn.TabIndex = 8;
            this.ComGphCancelBtn.Text = "Exit";
            this.ComGphCancelBtn.UseVisualStyleBackColor = true;
            this.ComGphCancelBtn.Click += new System.EventHandler(this.ComGphCancelBtn_Click);
            // 
            // cnpControllerCat
            // 
            this.cnpControllerCat.AutoScroll = true;
            this.cnpControllerCat.AutoScrollMargin = new System.Drawing.Size(100, 0);
            this.cnpControllerCat.AutoScrollMinSize = new System.Drawing.Size(100, 0);
            this.cnpControllerCat.Location = new System.Drawing.Point(3, 31);
            this.cnpControllerCat.Name = "cnpControllerCat";
            this.cnpControllerCat.Size = new System.Drawing.Size(242, 307);
            this.cnpControllerCat.TabIndex = 9;
            // 
            // cnpControllerHorse
            // 
            this.cnpControllerHorse.AutoScroll = true;
            this.cnpControllerHorse.AutoScrollMargin = new System.Drawing.Size(100, 0);
            this.cnpControllerHorse.AutoScrollMinSize = new System.Drawing.Size(100, 0);
            this.cnpControllerHorse.Location = new System.Drawing.Point(3, 31);
            this.cnpControllerHorse.Name = "cnpControllerHorse";
            this.cnpControllerHorse.Size = new System.Drawing.Size(242, 307);
            this.cnpControllerHorse.TabIndex = 9;
            // 
            // CompleteGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComGphCancelBtn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.animalCtr);
            this.Name = "CompleteGraph";
            this.Text = "CompleteGraph";
            this.animalCtr.ResumeLayout(false);
            this.catValues.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.dogValues.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.birdValues.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.horseValues.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl animalCtr;
        private System.Windows.Forms.TabPage catValues;
        private System.Windows.Forms.TabPage dogValues;
        private System.Windows.Forms.TabPage birdValues;
        private System.Windows.Forms.TabPage horseValues;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel cnpControllerDog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel cnpControllerBird;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button ComGphCancelBtn;
        private System.Windows.Forms.Panel cnpControllerCat;
        private System.Windows.Forms.Panel cnpControllerHorse;
    }
}