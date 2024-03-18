namespace Weather_App
{
    partial class ForecastUC
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
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            this.labDT = new System.Windows.Forms.Label();
            this.labMainWeather = new System.Windows.Forms.Label();
            this.labWeatherDescription = new System.Windows.Forms.Label();
            this.labTemperature = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.Location = new System.Drawing.Point(3, 3);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(59, 69);
            this.picWeatherIcon.TabIndex = 0;
            this.picWeatherIcon.TabStop = false;
            // 
            // labDT
            // 
            this.labDT.AutoSize = true;
            this.labDT.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDT.ForeColor = System.Drawing.Color.White;
            this.labDT.Location = new System.Drawing.Point(68, 3);
            this.labDT.Name = "labDT";
            this.labDT.Size = new System.Drawing.Size(47, 15);
            this.labDT.TabIndex = 1;
            this.labDT.Text = "Sunday";
            this.labDT.Click += new System.EventHandler(this.labDT_Click);
            // 
            // labMainWeather
            // 
            this.labMainWeather.AutoSize = true;
            this.labMainWeather.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMainWeather.ForeColor = System.Drawing.Color.White;
            this.labMainWeather.Location = new System.Drawing.Point(68, 18);
            this.labMainWeather.Name = "labMainWeather";
            this.labMainWeather.Size = new System.Drawing.Size(36, 15);
            this.labMainWeather.TabIndex = 2;
            this.labMainWeather.Text = "Clear";
            // 
            // labWeatherDescription
            // 
            this.labWeatherDescription.AutoSize = true;
            this.labWeatherDescription.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWeatherDescription.ForeColor = System.Drawing.Color.White;
            this.labWeatherDescription.Location = new System.Drawing.Point(68, 33);
            this.labWeatherDescription.Name = "labWeatherDescription";
            this.labWeatherDescription.Size = new System.Drawing.Size(70, 15);
            this.labWeatherDescription.TabIndex = 3;
            this.labWeatherDescription.Text = "Description";
            // 
            // labTemperature
            // 
            this.labTemperature.AutoSize = true;
            this.labTemperature.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTemperature.ForeColor = System.Drawing.Color.White;
            this.labTemperature.Location = new System.Drawing.Point(68, 48);
            this.labTemperature.Name = "labTemperature";
            this.labTemperature.Size = new System.Drawing.Size(75, 15);
            this.labTemperature.TabIndex = 4;
            this.labTemperature.Text = "Temperature";
            this.labTemperature.Click += new System.EventHandler(this.label1_Click);
            // 
            // ForecastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labTemperature);
            this.Controls.Add(this.labWeatherDescription);
            this.Controls.Add(this.labMainWeather);
            this.Controls.Add(this.labDT);
            this.Controls.Add(this.picWeatherIcon);
            this.Name = "ForecastUC";
            this.Size = new System.Drawing.Size(258, 77);
            this.Load += new System.EventHandler(this.ForecastUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picWeatherIcon;
        public System.Windows.Forms.Label labDT;
        public System.Windows.Forms.Label labMainWeather;
        public System.Windows.Forms.Label labWeatherDescription;
        public System.Windows.Forms.Label labTemperature;
    }
}
