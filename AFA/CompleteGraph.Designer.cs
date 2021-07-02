
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.animalCtr = new System.Windows.Forms.TabControl();
            this.catValues = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cnpControllerCat = new System.Windows.Forms.Panel();
            this.catListTxb = new System.Windows.Forms.TextBox();
            this.dogValues = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cnpControllerDog = new System.Windows.Forms.Panel();
            this.dogListTxb = new System.Windows.Forms.TextBox();
            this.birdValues = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cnpControllerBird = new System.Windows.Forms.Panel();
            this.birdListTxb = new System.Windows.Forms.TextBox();
            this.horseValues = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cnpControllerHorse = new System.Windows.Forms.Panel();
            this.horseListTxb = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ComGphCancelBtn = new System.Windows.Forms.Button();
            this.typeTtl = new System.Windows.Forms.Label();
            this.animalCtr.SuspendLayout();
            this.catValues.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cnpControllerCat.SuspendLayout();
            this.dogValues.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.cnpControllerDog.SuspendLayout();
            this.birdValues.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.cnpControllerBird.SuspendLayout();
            this.horseValues.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.cnpControllerHorse.SuspendLayout();
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
            this.groupBox1.Text = "Daily Food Average";
            // 
            // cnpControllerCat
            // 
            this.cnpControllerCat.AutoScroll = true;
            this.cnpControllerCat.Controls.Add(this.catListTxb);
            this.cnpControllerCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnpControllerCat.Location = new System.Drawing.Point(3, 32);
            this.cnpControllerCat.Name = "cnpControllerCat";
            this.cnpControllerCat.Padding = new System.Windows.Forms.Padding(20);
            this.cnpControllerCat.Size = new System.Drawing.Size(242, 333);
            this.cnpControllerCat.TabIndex = 9;
            // 
            // catListTxb
            // 
            this.catListTxb.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.catListTxb.Location = new System.Drawing.Point(3, 3);
            this.catListTxb.Multiline = true;
            this.catListTxb.Name = "catListTxb";
            this.catListTxb.ReadOnly = true;
            this.catListTxb.Size = new System.Drawing.Size(236, 25);
            this.catListTxb.TabIndex = 0;
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
            this.groupBox2.Text = "Daily Food Average";
            // 
            // cnpControllerDog
            // 
            this.cnpControllerDog.AutoScroll = true;
            this.cnpControllerDog.Controls.Add(this.dogListTxb);
            this.cnpControllerDog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnpControllerDog.Location = new System.Drawing.Point(3, 32);
            this.cnpControllerDog.Name = "cnpControllerDog";
            this.cnpControllerDog.Padding = new System.Windows.Forms.Padding(20);
            this.cnpControllerDog.Size = new System.Drawing.Size(242, 333);
            this.cnpControllerDog.TabIndex = 10;
            // 
            // dogListTxb
            // 
            this.dogListTxb.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.dogListTxb.Location = new System.Drawing.Point(3, 3);
            this.dogListTxb.Multiline = true;
            this.dogListTxb.Name = "dogListTxb";
            this.dogListTxb.ReadOnly = true;
            this.dogListTxb.Size = new System.Drawing.Size(236, 25);
            this.dogListTxb.TabIndex = 0;
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
            this.groupBox3.Text = "Daily Food Average";
            // 
            // cnpControllerBird
            // 
            this.cnpControllerBird.AutoScroll = true;
            this.cnpControllerBird.Controls.Add(this.birdListTxb);
            this.cnpControllerBird.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnpControllerBird.Location = new System.Drawing.Point(3, 32);
            this.cnpControllerBird.Name = "cnpControllerBird";
            this.cnpControllerBird.Padding = new System.Windows.Forms.Padding(20);
            this.cnpControllerBird.Size = new System.Drawing.Size(242, 333);
            this.cnpControllerBird.TabIndex = 10;
            // 
            // birdListTxb
            // 
            this.birdListTxb.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.birdListTxb.Location = new System.Drawing.Point(3, 3);
            this.birdListTxb.Multiline = true;
            this.birdListTxb.Name = "birdListTxb";
            this.birdListTxb.ReadOnly = true;
            this.birdListTxb.Size = new System.Drawing.Size(236, 25);
            this.birdListTxb.TabIndex = 0;
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
            this.groupBox4.Text = "Daily Food Average";
            // 
            // cnpControllerHorse
            // 
            this.cnpControllerHorse.AutoScroll = true;
            this.cnpControllerHorse.Controls.Add(this.horseListTxb);
            this.cnpControllerHorse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnpControllerHorse.Location = new System.Drawing.Point(3, 32);
            this.cnpControllerHorse.Name = "cnpControllerHorse";
            this.cnpControllerHorse.Padding = new System.Windows.Forms.Padding(20);
            this.cnpControllerHorse.Size = new System.Drawing.Size(242, 333);
            this.cnpControllerHorse.TabIndex = 10;
            // 
            // horseListTxb
            // 
            this.horseListTxb.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.horseListTxb.Location = new System.Drawing.Point(3, 3);
            this.horseListTxb.Multiline = true;
            this.horseListTxb.Name = "horseListTxb";
            this.horseListTxb.ReadOnly = true;
            this.horseListTxb.Size = new System.Drawing.Size(236, 25);
            this.horseListTxb.TabIndex = 0;
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
            // typeTtl
            // 
            this.typeTtl.AutoSize = true;
            this.typeTtl.Font = new System.Drawing.Font("Palatino Linotype", 24F);
            this.typeTtl.Location = new System.Drawing.Point(213, 12);
            this.typeTtl.Name = "typeTtl";
            this.typeTtl.Size = new System.Drawing.Size(83, 44);
            this.typeTtl.TabIndex = 9;
            this.typeTtl.Text = "Cats";
            // 
            // CompleteGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.typeTtl);
            this.Controls.Add(this.ComGphCancelBtn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.animalCtr);
            this.Name = "CompleteGraph";
            this.Text = "CompleteGraph";
            this.animalCtr.ResumeLayout(false);
            this.catValues.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.cnpControllerCat.ResumeLayout(false);
            this.cnpControllerCat.PerformLayout();
            this.dogValues.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.cnpControllerDog.ResumeLayout(false);
            this.cnpControllerDog.PerformLayout();
            this.birdValues.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.cnpControllerBird.ResumeLayout(false);
            this.cnpControllerBird.PerformLayout();
            this.horseValues.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.cnpControllerHorse.ResumeLayout(false);
            this.cnpControllerHorse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl animalCtr;
        private System.Windows.Forms.TabPage catValues;
        private System.Windows.Forms.TabPage dogValues;
        private System.Windows.Forms.TabPage birdValues;
        private System.Windows.Forms.TabPage horseValues;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button ComGphCancelBtn;
        private System.Windows.Forms.Label typeTtl;
        private System.Windows.Forms.Panel cnpControllerCat;
        private System.Windows.Forms.TextBox catListTxb;
        private System.Windows.Forms.Panel cnpControllerDog;
        private System.Windows.Forms.TextBox dogListTxb;
        private System.Windows.Forms.Panel cnpControllerBird;
        private System.Windows.Forms.TextBox birdListTxb;
        private System.Windows.Forms.Panel cnpControllerHorse;
        private System.Windows.Forms.TextBox horseListTxb;
    }
}