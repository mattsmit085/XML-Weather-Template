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
            this.components = new System.ComponentModel.Container();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.d1l = new System.Windows.Forms.Label();
            this.d1maxLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.d2l = new System.Windows.Forms.Label();
            this.d2maxLabel = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.d4 = new System.Windows.Forms.Label();
            this.d4l = new System.Windows.Forms.Label();
            this.d4h = new System.Windows.Forms.Label();
            this.d3 = new System.Windows.Forms.Label();
            this.d3l = new System.Windows.Forms.Label();
            this.d3h = new System.Windows.Forms.Label();
            this.d7 = new System.Windows.Forms.Label();
            this.d7l = new System.Windows.Forms.Label();
            this.d7h = new System.Windows.Forms.Label();
            this.d6 = new System.Windows.Forms.Label();
            this.d6l = new System.Windows.Forms.Label();
            this.d6h = new System.Windows.Forms.Label();
            this.d5 = new System.Windows.Forms.Label();
            this.d5l = new System.Windows.Forms.Label();
            this.d5h = new System.Windows.Forms.Label();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("League Spartan SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(142, 27);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("League Spartan SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // d1l
            // 
            this.d1l.AutoSize = true;
            this.d1l.BackColor = System.Drawing.Color.Transparent;
            this.d1l.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1l.ForeColor = System.Drawing.Color.White;
            this.d1l.Location = new System.Drawing.Point(184, 87);
            this.d1l.Name = "d1l";
            this.d1l.Size = new System.Drawing.Size(41, 22);
            this.d1l.TabIndex = 46;
            this.d1l.Text = "LOW";
            // 
            // d1maxLabel
            // 
            this.d1maxLabel.AutoSize = true;
            this.d1maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.d1maxLabel.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1maxLabel.ForeColor = System.Drawing.Color.White;
            this.d1maxLabel.Location = new System.Drawing.Point(110, 87);
            this.d1maxLabel.Name = "d1maxLabel";
            this.d1maxLabel.Size = new System.Drawing.Size(43, 22);
            this.d1maxLabel.TabIndex = 44;
            this.d1maxLabel.Text = "HIGH";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(129, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.BackColor = System.Drawing.Color.Transparent;
            this.date1.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.ForeColor = System.Drawing.Color.White;
            this.date1.Location = new System.Drawing.Point(22, 87);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(39, 22);
            this.date1.TabIndex = 64;
            this.date1.Text = "Date";
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.BackColor = System.Drawing.Color.Transparent;
            this.date2.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.ForeColor = System.Drawing.Color.White;
            this.date2.Location = new System.Drawing.Point(22, 118);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(39, 22);
            this.date2.TabIndex = 69;
            this.date2.Text = "Date";
            // 
            // d2l
            // 
            this.d2l.AutoSize = true;
            this.d2l.BackColor = System.Drawing.Color.Transparent;
            this.d2l.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d2l.ForeColor = System.Drawing.Color.White;
            this.d2l.Location = new System.Drawing.Point(184, 118);
            this.d2l.Name = "d2l";
            this.d2l.Size = new System.Drawing.Size(41, 22);
            this.d2l.TabIndex = 67;
            this.d2l.Text = "LOW";
            this.d2l.Click += new System.EventHandler(this.d2minLabel_Click);
            // 
            // d2maxLabel
            // 
            this.d2maxLabel.AutoSize = true;
            this.d2maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.d2maxLabel.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d2maxLabel.ForeColor = System.Drawing.Color.White;
            this.d2maxLabel.Location = new System.Drawing.Point(110, 118);
            this.d2maxLabel.Name = "d2maxLabel";
            this.d2maxLabel.Size = new System.Drawing.Size(43, 22);
            this.d2maxLabel.TabIndex = 65;
            this.d2maxLabel.Text = "HIGH";
            // 
            // timelabel
            // 
            this.timelabel.BackColor = System.Drawing.Color.Transparent;
            this.timelabel.Font = new System.Drawing.Font("League Spartan", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.timelabel.Location = new System.Drawing.Point(77, 0);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(100, 23);
            this.timelabel.TabIndex = 70;
            this.timelabel.Text = "label1";
            this.timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d4
            // 
            this.d4.AutoSize = true;
            this.d4.BackColor = System.Drawing.Color.Transparent;
            this.d4.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d4.ForeColor = System.Drawing.Color.White;
            this.d4.Location = new System.Drawing.Point(22, 180);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(39, 22);
            this.d4.TabIndex = 76;
            this.d4.Text = "Date";
            // 
            // d4l
            // 
            this.d4l.AutoSize = true;
            this.d4l.BackColor = System.Drawing.Color.Transparent;
            this.d4l.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d4l.ForeColor = System.Drawing.Color.White;
            this.d4l.Location = new System.Drawing.Point(184, 180);
            this.d4l.Name = "d4l";
            this.d4l.Size = new System.Drawing.Size(41, 22);
            this.d4l.TabIndex = 75;
            this.d4l.Text = "LOW";
            // 
            // d4h
            // 
            this.d4h.AutoSize = true;
            this.d4h.BackColor = System.Drawing.Color.Transparent;
            this.d4h.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d4h.ForeColor = System.Drawing.Color.White;
            this.d4h.Location = new System.Drawing.Point(110, 180);
            this.d4h.Name = "d4h";
            this.d4h.Size = new System.Drawing.Size(43, 22);
            this.d4h.TabIndex = 74;
            this.d4h.Text = "HIGH";
            // 
            // d3
            // 
            this.d3.AutoSize = true;
            this.d3.BackColor = System.Drawing.Color.Transparent;
            this.d3.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d3.ForeColor = System.Drawing.Color.White;
            this.d3.Location = new System.Drawing.Point(22, 149);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(39, 22);
            this.d3.TabIndex = 73;
            this.d3.Text = "Date";
            // 
            // d3l
            // 
            this.d3l.AutoSize = true;
            this.d3l.BackColor = System.Drawing.Color.Transparent;
            this.d3l.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d3l.ForeColor = System.Drawing.Color.White;
            this.d3l.Location = new System.Drawing.Point(184, 149);
            this.d3l.Name = "d3l";
            this.d3l.Size = new System.Drawing.Size(41, 22);
            this.d3l.TabIndex = 72;
            this.d3l.Text = "LOW";
            // 
            // d3h
            // 
            this.d3h.AutoSize = true;
            this.d3h.BackColor = System.Drawing.Color.Transparent;
            this.d3h.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d3h.ForeColor = System.Drawing.Color.White;
            this.d3h.Location = new System.Drawing.Point(110, 149);
            this.d3h.Name = "d3h";
            this.d3h.Size = new System.Drawing.Size(43, 22);
            this.d3h.TabIndex = 71;
            this.d3h.Text = "HIGH";
            // 
            // d7
            // 
            this.d7.AutoSize = true;
            this.d7.BackColor = System.Drawing.Color.Transparent;
            this.d7.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d7.ForeColor = System.Drawing.Color.White;
            this.d7.Location = new System.Drawing.Point(22, 274);
            this.d7.Name = "d7";
            this.d7.Size = new System.Drawing.Size(39, 22);
            this.d7.TabIndex = 85;
            this.d7.Text = "Date";
            // 
            // d7l
            // 
            this.d7l.AutoSize = true;
            this.d7l.BackColor = System.Drawing.Color.Transparent;
            this.d7l.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d7l.ForeColor = System.Drawing.Color.White;
            this.d7l.Location = new System.Drawing.Point(184, 274);
            this.d7l.Name = "d7l";
            this.d7l.Size = new System.Drawing.Size(41, 22);
            this.d7l.TabIndex = 84;
            this.d7l.Text = "LOW";
            // 
            // d7h
            // 
            this.d7h.AutoSize = true;
            this.d7h.BackColor = System.Drawing.Color.Transparent;
            this.d7h.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d7h.ForeColor = System.Drawing.Color.White;
            this.d7h.Location = new System.Drawing.Point(110, 274);
            this.d7h.Name = "d7h";
            this.d7h.Size = new System.Drawing.Size(43, 22);
            this.d7h.TabIndex = 83;
            this.d7h.Text = "HIGH";
            // 
            // d6
            // 
            this.d6.AutoSize = true;
            this.d6.BackColor = System.Drawing.Color.Transparent;
            this.d6.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d6.ForeColor = System.Drawing.Color.White;
            this.d6.Location = new System.Drawing.Point(22, 243);
            this.d6.Name = "d6";
            this.d6.Size = new System.Drawing.Size(39, 22);
            this.d6.TabIndex = 82;
            this.d6.Text = "Date";
            // 
            // d6l
            // 
            this.d6l.AutoSize = true;
            this.d6l.BackColor = System.Drawing.Color.Transparent;
            this.d6l.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d6l.ForeColor = System.Drawing.Color.White;
            this.d6l.Location = new System.Drawing.Point(184, 243);
            this.d6l.Name = "d6l";
            this.d6l.Size = new System.Drawing.Size(41, 22);
            this.d6l.TabIndex = 81;
            this.d6l.Text = "LOW";
            // 
            // d6h
            // 
            this.d6h.AutoSize = true;
            this.d6h.BackColor = System.Drawing.Color.Transparent;
            this.d6h.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d6h.ForeColor = System.Drawing.Color.White;
            this.d6h.Location = new System.Drawing.Point(110, 243);
            this.d6h.Name = "d6h";
            this.d6h.Size = new System.Drawing.Size(43, 22);
            this.d6h.TabIndex = 80;
            this.d6h.Text = "HIGH";
            // 
            // d5
            // 
            this.d5.AutoSize = true;
            this.d5.BackColor = System.Drawing.Color.Transparent;
            this.d5.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d5.ForeColor = System.Drawing.Color.White;
            this.d5.Location = new System.Drawing.Point(22, 212);
            this.d5.Name = "d5";
            this.d5.Size = new System.Drawing.Size(39, 22);
            this.d5.TabIndex = 79;
            this.d5.Text = "Date";
            // 
            // d5l
            // 
            this.d5l.AutoSize = true;
            this.d5l.BackColor = System.Drawing.Color.Transparent;
            this.d5l.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d5l.ForeColor = System.Drawing.Color.White;
            this.d5l.Location = new System.Drawing.Point(184, 212);
            this.d5l.Name = "d5l";
            this.d5l.Size = new System.Drawing.Size(41, 22);
            this.d5l.TabIndex = 78;
            this.d5l.Text = "LOW";
            // 
            // d5h
            // 
            this.d5h.AutoSize = true;
            this.d5h.BackColor = System.Drawing.Color.Transparent;
            this.d5h.Font = new System.Drawing.Font("League Spartan SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d5h.ForeColor = System.Drawing.Color.White;
            this.d5h.Location = new System.Drawing.Point(110, 212);
            this.d5h.Name = "d5h";
            this.d5h.Size = new System.Drawing.Size(43, 22);
            this.d5h.TabIndex = 77;
            this.d5h.Text = "HIGH";
            // 
            // timeTimer
            // 
            this.timeTimer.Enabled = true;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.BG;
            this.Controls.Add(this.d7);
            this.Controls.Add(this.d7l);
            this.Controls.Add(this.d7h);
            this.Controls.Add(this.d6);
            this.Controls.Add(this.d6l);
            this.Controls.Add(this.d6h);
            this.Controls.Add(this.d5);
            this.Controls.Add(this.d5l);
            this.Controls.Add(this.d5h);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.d4l);
            this.Controls.Add(this.d4h);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.d3l);
            this.Controls.Add(this.d3h);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.d2l);
            this.Controls.Add(this.d2maxLabel);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.d1l);
            this.Controls.Add(this.d1maxLabel);
            this.Controls.Add(this.label5);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(250, 400);
            this.Load += new System.EventHandler(this.ForecastScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label d1l;
        private System.Windows.Forms.Label d1maxLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label d2l;
        private System.Windows.Forms.Label d2maxLabel;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label d4;
        private System.Windows.Forms.Label d4l;
        private System.Windows.Forms.Label d4h;
        private System.Windows.Forms.Label d3;
        private System.Windows.Forms.Label d3l;
        private System.Windows.Forms.Label d3h;
        private System.Windows.Forms.Label d7;
        private System.Windows.Forms.Label d7l;
        private System.Windows.Forms.Label d7h;
        private System.Windows.Forms.Label d6;
        private System.Windows.Forms.Label d6l;
        private System.Windows.Forms.Label d6h;
        private System.Windows.Forms.Label d5;
        private System.Windows.Forms.Label d5l;
        private System.Windows.Forms.Label d5h;
        private System.Windows.Forms.Timer timeTimer;
    }
}
