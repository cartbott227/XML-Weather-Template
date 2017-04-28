namespace XMLWeather
{
    partial class ForecastScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForecastScreen));
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minTemp = new System.Windows.Forms.Label();
            this.maxTemp = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.maxTemp2 = new System.Windows.Forms.Label();
            this.maxTemp3 = new System.Windows.Forms.Label();
            this.minTemp2 = new System.Windows.Forms.Label();
            this.minTemp3 = new System.Windows.Forms.Label();
            this.conditionsBox1 = new System.Windows.Forms.PictureBox();
            this.conditionsBox2 = new System.Windows.Forms.PictureBox();
            this.conditionsBox3 = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(142, 14);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "3 Day";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(18, 52);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(228, 37);
            this.cityOutput.TabIndex = 43;
            this.cityOutput.Text = "Stratford, ON";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(129, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minTemp
            // 
            this.minTemp.AutoSize = true;
            this.minTemp.BackColor = System.Drawing.Color.Transparent;
            this.minTemp.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTemp.ForeColor = System.Drawing.Color.White;
            this.minTemp.Location = new System.Drawing.Point(141, 184);
            this.minTemp.Name = "minTemp";
            this.minTemp.Size = new System.Drawing.Size(63, 32);
            this.minTemp.TabIndex = 68;
            this.minTemp.Text = "7 C";
            // 
            // maxTemp
            // 
            this.maxTemp.AutoSize = true;
            this.maxTemp.BackColor = System.Drawing.Color.Transparent;
            this.maxTemp.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTemp.ForeColor = System.Drawing.Color.White;
            this.maxTemp.Location = new System.Drawing.Point(44, 184);
            this.maxTemp.Name = "maxTemp";
            this.maxTemp.Size = new System.Drawing.Size(91, 32);
            this.maxTemp.TabIndex = 66;
            this.maxTemp.Text = "20 C ";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(131, 171);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(22, 13);
            this.currentOutput.TabIndex = 65;
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.BackColor = System.Drawing.Color.Transparent;
            this.date1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.ForeColor = System.Drawing.Color.White;
            this.date1.Location = new System.Drawing.Point(39, 146);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(174, 32);
            this.date1.TabIndex = 69;
            this.date1.Text = "24-7-2016";
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.BackColor = System.Drawing.Color.Transparent;
            this.date2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.ForeColor = System.Drawing.Color.White;
            this.date2.Location = new System.Drawing.Point(277, 146);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(174, 32);
            this.date2.TabIndex = 70;
            this.date2.Text = "24-7-2016";
            // 
            // date3
            // 
            this.date3.AutoSize = true;
            this.date3.BackColor = System.Drawing.Color.Transparent;
            this.date3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date3.ForeColor = System.Drawing.Color.White;
            this.date3.Location = new System.Drawing.Point(511, 146);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(174, 32);
            this.date3.TabIndex = 71;
            this.date3.Text = "24-7-2016";
            // 
            // maxTemp2
            // 
            this.maxTemp2.AutoSize = true;
            this.maxTemp2.BackColor = System.Drawing.Color.Transparent;
            this.maxTemp2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTemp2.ForeColor = System.Drawing.Color.White;
            this.maxTemp2.Location = new System.Drawing.Point(293, 184);
            this.maxTemp2.Name = "maxTemp2";
            this.maxTemp2.Size = new System.Drawing.Size(82, 32);
            this.maxTemp2.TabIndex = 72;
            this.maxTemp2.Text = "20 C";
            // 
            // maxTemp3
            // 
            this.maxTemp3.AutoSize = true;
            this.maxTemp3.BackColor = System.Drawing.Color.Transparent;
            this.maxTemp3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTemp3.ForeColor = System.Drawing.Color.White;
            this.maxTemp3.Location = new System.Drawing.Point(525, 184);
            this.maxTemp3.Name = "maxTemp3";
            this.maxTemp3.Size = new System.Drawing.Size(82, 32);
            this.maxTemp3.TabIndex = 73;
            this.maxTemp3.Text = "20 C";
            // 
            // minTemp2
            // 
            this.minTemp2.AutoSize = true;
            this.minTemp2.BackColor = System.Drawing.Color.Transparent;
            this.minTemp2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTemp2.ForeColor = System.Drawing.Color.White;
            this.minTemp2.Location = new System.Drawing.Point(381, 184);
            this.minTemp2.Name = "minTemp2";
            this.minTemp2.Size = new System.Drawing.Size(63, 32);
            this.minTemp2.TabIndex = 74;
            this.minTemp2.Text = "7 C";
            // 
            // minTemp3
            // 
            this.minTemp3.AutoSize = true;
            this.minTemp3.BackColor = System.Drawing.Color.Transparent;
            this.minTemp3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTemp3.ForeColor = System.Drawing.Color.White;
            this.minTemp3.Location = new System.Drawing.Point(613, 184);
            this.minTemp3.Name = "minTemp3";
            this.minTemp3.Size = new System.Drawing.Size(63, 32);
            this.minTemp3.TabIndex = 75;
            this.minTemp3.Text = "7 C";
            // 
            // conditionsBox1
            // 
            this.conditionsBox1.BackColor = System.Drawing.Color.Transparent;
            this.conditionsBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("conditionsBox1.BackgroundImage")));
            this.conditionsBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.conditionsBox1.Location = new System.Drawing.Point(50, 232);
            this.conditionsBox1.Name = "conditionsBox1";
            this.conditionsBox1.Size = new System.Drawing.Size(150, 150);
            this.conditionsBox1.TabIndex = 76;
            this.conditionsBox1.TabStop = false;
            // 
            // conditionsBox2
            // 
            this.conditionsBox2.BackColor = System.Drawing.Color.Transparent;
            this.conditionsBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("conditionsBox2.BackgroundImage")));
            this.conditionsBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.conditionsBox2.Location = new System.Drawing.Point(294, 232);
            this.conditionsBox2.Name = "conditionsBox2";
            this.conditionsBox2.Size = new System.Drawing.Size(150, 150);
            this.conditionsBox2.TabIndex = 77;
            this.conditionsBox2.TabStop = false;
            // 
            // conditionsBox3
            // 
            this.conditionsBox3.BackColor = System.Drawing.Color.Transparent;
            this.conditionsBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("conditionsBox3.BackgroundImage")));
            this.conditionsBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.conditionsBox3.Location = new System.Drawing.Point(531, 232);
            this.conditionsBox3.Name = "conditionsBox3";
            this.conditionsBox3.Size = new System.Drawing.Size(150, 150);
            this.conditionsBox3.TabIndex = 78;
            this.conditionsBox3.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(312, 14);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(114, 35);
            this.labelTime.TabIndex = 79;
            this.labelTime.Text = "label1";
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.conditionsBox3);
            this.Controls.Add(this.conditionsBox2);
            this.Controls.Add(this.conditionsBox1);
            this.Controls.Add(this.minTemp3);
            this.Controls.Add(this.minTemp2);
            this.Controls.Add(this.maxTemp3);
            this.Controls.Add(this.maxTemp2);
            this.Controls.Add(this.date3);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.minTemp);
            this.Controls.Add(this.maxTemp);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.label5);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(697, 400);
            ((System.ComponentModel.ISupportInitialize)(this.conditionsBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label minTemp;
        private System.Windows.Forms.Label maxTemp;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.Label maxTemp2;
        private System.Windows.Forms.Label maxTemp3;
        private System.Windows.Forms.Label minTemp2;
        private System.Windows.Forms.Label minTemp3;
        private System.Windows.Forms.PictureBox conditionsBox1;
        private System.Windows.Forms.PictureBox conditionsBox2;
        private System.Windows.Forms.PictureBox conditionsBox3;
        private System.Windows.Forms.Label labelTime;
    }
}
