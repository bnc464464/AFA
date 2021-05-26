
namespace AFA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainTitleTxb = new System.Windows.Forms.Label();
            this.Infotxb = new System.Windows.Forms.Label();
            this.CatBtn = new System.Windows.Forms.Button();
            this.DogBtn = new System.Windows.Forms.Button();
            this.BirdBtn = new System.Windows.Forms.Button();
            this.HorseBtn = new System.Windows.Forms.Button();
            this.CompletedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTitleTxb
            // 
            this.MainTitleTxb.AutoSize = true;
            this.MainTitleTxb.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitleTxb.Location = new System.Drawing.Point(200, 9);
            this.MainTitleTxb.Name = "MainTitleTxb";
            this.MainTitleTxb.Size = new System.Drawing.Size(378, 44);
            this.MainTitleTxb.TabIndex = 0;
            this.MainTitleTxb.Text = "The Animal Feeding App";
            // 
            // Infotxb
            // 
            this.Infotxb.AutoSize = true;
            this.Infotxb.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.Infotxb.Location = new System.Drawing.Point(94, 53);
            this.Infotxb.Name = "Infotxb";
            this.Infotxb.Size = new System.Drawing.Size(642, 208);
            this.Infotxb.TabIndex = 1;
            this.Infotxb.Text = resources.GetString("Infotxb.Text");
            // 
            // CatBtn
            // 
            this.CatBtn.Location = new System.Drawing.Point(50, 277);
            this.CatBtn.Name = "CatBtn";
            this.CatBtn.Size = new System.Drawing.Size(128, 82);
            this.CatBtn.TabIndex = 2;
            this.CatBtn.Text = "Cat\r\n*This will be replaced for a pic*";
            this.CatBtn.UseVisualStyleBackColor = true;
            this.CatBtn.Click += new System.EventHandler(this.CatBtn_Click);
            // 
            // DogBtn
            // 
            this.DogBtn.Location = new System.Drawing.Point(217, 277);
            this.DogBtn.Name = "DogBtn";
            this.DogBtn.Size = new System.Drawing.Size(128, 82);
            this.DogBtn.TabIndex = 3;
            this.DogBtn.Text = "Dog\n*This will be replaced for a pic*";
            this.DogBtn.UseVisualStyleBackColor = true;
            this.DogBtn.Click += new System.EventHandler(this.DogBtn_Click);
            // 
            // BirdBtn
            // 
            this.BirdBtn.Location = new System.Drawing.Point(384, 277);
            this.BirdBtn.Name = "BirdBtn";
            this.BirdBtn.Size = new System.Drawing.Size(128, 82);
            this.BirdBtn.TabIndex = 4;
            this.BirdBtn.Text = "Bird\r\n*This will be replaced for a pic*";
            this.BirdBtn.UseVisualStyleBackColor = true;
            this.BirdBtn.Click += new System.EventHandler(this.BirdBtn_Click);
            // 
            // HorseBtn
            // 
            this.HorseBtn.Location = new System.Drawing.Point(549, 277);
            this.HorseBtn.Name = "HorseBtn";
            this.HorseBtn.Size = new System.Drawing.Size(128, 82);
            this.HorseBtn.TabIndex = 5;
            this.HorseBtn.Text = "Horse\r\n*This will be replaced for a pic*";
            this.HorseBtn.UseVisualStyleBackColor = true;
            this.HorseBtn.Click += new System.EventHandler(this.HorseBtn_Click);
            // 
            // CompletedBtn
            // 
            this.CompletedBtn.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletedBtn.Location = new System.Drawing.Point(267, 385);
            this.CompletedBtn.Name = "CompletedBtn";
            this.CompletedBtn.Size = new System.Drawing.Size(186, 44);
            this.CompletedBtn.TabIndex = 6;
            this.CompletedBtn.Text = "Finished Adding";
            this.CompletedBtn.UseVisualStyleBackColor = true;
            this.CompletedBtn.Click += new System.EventHandler(this.CompletedBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CompletedBtn);
            this.Controls.Add(this.HorseBtn);
            this.Controls.Add(this.BirdBtn);
            this.Controls.Add(this.DogBtn);
            this.Controls.Add(this.CatBtn);
            this.Controls.Add(this.Infotxb);
            this.Controls.Add(this.MainTitleTxb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitleTxb;
        private System.Windows.Forms.Label Infotxb;
        private System.Windows.Forms.Button CatBtn;
        private System.Windows.Forms.Button DogBtn;
        private System.Windows.Forms.Button BirdBtn;
        private System.Windows.Forms.Button HorseBtn;
        private System.Windows.Forms.Button CompletedBtn;
    }
}

