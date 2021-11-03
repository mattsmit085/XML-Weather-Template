using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        //DISPLAY FORECAST INFORMATION TO LABELS
        public void displayForecast()
        {
            if (CurrentScreen.refreshweather == true)
            {
                Refresh();
                CurrentScreen.refreshweather = false;
            }
            int currentSec = DateTime.Now.Second;
            int currentMin = DateTime.Now.Minute;
            int currentHour = DateTime.Now.Hour;


            date1.Text = Convert.ToDateTime(CurrentScreen.days[0].date).ToString("dddd");
            d1l.Text = "L: " + Math.Round(Convert.ToDouble(CurrentScreen.days[0].tempLow)) + "°";
            d1maxLabel.Text = "H: " + Math.Round(Convert.ToDouble(CurrentScreen.days[1].tempHigh)) + "°";

            date2.Text = Convert.ToDateTime(CurrentScreen.days[1].date).ToString("dddd");
            d2l.Text = "L: " + Math.Round(Convert.ToDouble(CurrentScreen.days[1].tempLow)) + "°";
            d2maxLabel.Text = "H: " + Math.Round(Convert.ToDouble(CurrentScreen.days[1].tempHigh)) + "°";

            d3.Text = Convert.ToDateTime(CurrentScreen.days[2].date).ToString("dddd");
            d3l.Text = "L: " + Math.Round(Convert.ToDouble(CurrentScreen.days[2].tempLow)) + "°";
            d3h.Text = "H: " + Math.Round(Convert.ToDouble(CurrentScreen.days[2].tempHigh)) + "°";

            d4.Text = Convert.ToDateTime(CurrentScreen.days[3].date).ToString("dddd");
            d4l.Text = "L: " + Math.Round(Convert.ToDouble(CurrentScreen.days[3].tempLow)) + "°";
            d4h.Text = "H: " + Math.Round(Convert.ToDouble(CurrentScreen.days[3].tempHigh)) + "°";

            d5.Text = Convert.ToDateTime(CurrentScreen.days[4].date).ToString("dddd");
            d5l.Text = "L: " + Math.Round(Convert.ToDouble(CurrentScreen.days[4].tempLow)) + "°";
            d5h.Text = "H: " + Math.Round(Convert.ToDouble(CurrentScreen.days[4].tempHigh)) + "°";

            d6.Text = Convert.ToDateTime(CurrentScreen.days[5].date).ToString("dddd");
            d6l.Text = "L: " + Math.Round(Convert.ToDouble(CurrentScreen.days[5].tempLow)) + "°";
            d6h.Text = "H: " + Math.Round(Convert.ToDouble(CurrentScreen.days[5].tempHigh)) + "°";

            d7.Text = Convert.ToDateTime(CurrentScreen.days[6].date).ToString("dddd");
            d7l.Text = "L: " + Math.Round(Convert.ToDouble(CurrentScreen.days[6].tempLow)) + "°";
            d7h.Text = "H: " + Math.Round(Convert.ToDouble(CurrentScreen.days[6].tempHigh)) + "°";
        }

        //SWITCH SCREENS
        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void d2minLabel_Click(object sender, EventArgs e)
        {

        }

        private void ForecastScreen_Load(object sender, EventArgs e)
        {
        
        }

        //GRAB TIME.
        private void timeTimer_Tick(object sender, EventArgs e)
        {
            timelabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
