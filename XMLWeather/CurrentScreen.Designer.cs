namespace XMLWeather
{
    partial class CurrentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentScreen));
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.weatherlabel = new System.Windows.Forms.Label();
            this.TimeTimer = new System.Windows.Forms.Timer(this.components);
            this.iconlabel = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.citySearchLabel = new System.Windows.Forms.TextBox();
            this.searchButtonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconlabel)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Ostrich Sans Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(25, 74);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(200, 27);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("League Spartan SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.maxOutput.Location = new System.Drawing.Point(131, 221);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(87, 22);
            this.maxOutput.TabIndex = 32;
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("League Spartan SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.Snow;
            this.minOutput.Location = new System.Drawing.Point(32, 221);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(93, 22);
            this.minOutput.TabIndex = 30;
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(131, 136);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(22, 13);
            this.currentOutput.TabIndex = 28;
            // 
            // tempLabel
            // 
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("League Spartan Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(28, 109);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(192, 31);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Current Temperature";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("League Spartan Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("League Spartan Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(141, 29);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timelabel
            // 
            this.timelabel.BackColor = System.Drawing.Color.Transparent;
            this.timelabel.Font = new System.Drawing.Font("League Spartan", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.timelabel.Location = new System.Drawing.Point(144, 4);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(100, 19);
            this.timelabel.TabIndex = 43;
            this.timelabel.Text = "label1";
            this.timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weatherlabel
            // 
            this.weatherlabel.BackColor = System.Drawing.Color.Transparent;
            this.weatherlabel.Font = new System.Drawing.Font("League Spartan SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherlabel.ForeColor = System.Drawing.Color.White;
            this.weatherlabel.Location = new System.Drawing.Point(22, 285);
            this.weatherlabel.Name = "weatherlabel";
            this.weatherlabel.Size = new System.Drawing.Size(148, 91);
            this.weatherlabel.TabIndex = 44;
            this.weatherlabel.Text = "label1";
            this.weatherlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeTimer
            // 
            this.TimeTimer.Enabled = true;
            this.TimeTimer.Tick += new System.EventHandler(this.TimeTimer_Tick);
            // 
            // iconlabel
            // 
            this.iconlabel.BackColor = System.Drawing.Color.Transparent;
            this.iconlabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconlabel.Location = new System.Drawing.Point(170, 306);
            this.iconlabel.Name = "iconlabel";
            this.iconlabel.Size = new System.Drawing.Size(59, 50);
            this.iconlabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconlabel.TabIndex = 45;
            this.iconlabel.TabStop = false;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("League Spartan", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateLabel.Location = new System.Drawing.Point(4, 4);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(100, 19);
            this.dateLabel.TabIndex = 48;
            this.dateLabel.Text = "label1";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // citySearchLabel
            // 
            this.citySearchLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.citySearchLabel.Location = new System.Drawing.Point(31, 158);
            this.citySearchLabel.Name = "citySearchLabel";
            this.citySearchLabel.Size = new System.Drawing.Size(104, 20);
            this.citySearchLabel.TabIndex = 49;
            // 
            // searchButtonLabel
            // 
            this.searchButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchButtonLabel.Font = new System.Drawing.Font("League Spartan", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButtonLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchButtonLabel.Location = new System.Drawing.Point(141, 157);
            this.searchButtonLabel.Name = "searchButtonLabel";
            this.searchButtonLabel.Size = new System.Drawing.Size(77, 21);
            this.searchButtonLabel.TabIndex = 50;
            this.searchButtonLabel.Text = "SEARCH";
            this.searchButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchButtonLabel.Click += new System.EventHandler(this.searchButtonLabel_Click);
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.searchButtonLabel);
            this.Controls.Add(this.citySearchLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.iconlabel);
            this.Controls.Add(this.weatherlabel);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.label5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(250, 400);
            this.Load += new System.EventHandler(this.CurrentScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconlabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label weatherlabel;
        private System.Windows.Forms.Timer TimeTimer;
        private System.Windows.Forms.PictureBox iconlabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox citySearchLabel;
        private System.Windows.Forms.Label searchButtonLabel;
    }
}
